using NAudio.CoreAudioApi;
using NAudio.Wave;
using System.Text;
using System.Reflection;
using System.Runtime.CompilerServices;
using Vosk;
using System.Text.Json;
using NLog;

namespace OBSTranslator
{
    public class SpeechRecognizer
    {
        private VoskRecognizer? _recognizer;
        private Model _model;
        private int _sampleRate;
        private int _channelCount;
        private MMDeviceCollection _captureDevices;
        private MMDevice _selectedDevice;
        private WaveInEvent _waveIn;
        Logger logger = LogManager.GetCurrentClassLogger();

        private List<string> _inputDevices;
        public List<string> InputDevices
        {
            get
            {
                GetInputDevices();
                return _inputDevices;
            }
            private set => _inputDevices = value;
        }
        private int _selectedDeviceIndex;
        public int SelectedDeviceIndex
        {
            get
            {
                GetDefaultDevice();
                return _selectedDeviceIndex;
            }
            private set => _selectedDeviceIndex = value;
        }

        public event EventHandler SpeechRecognized;

        public SpeechRecognizer()
        {
            GetInputDevices();
            GetDefaultDevice();
            _model = new Model("model");
        }
        
        DateTime _startTime;
        public void StartRecognize()
        {
            try
            {
                logger.Info("Recognition starting...");
                _recognizer = new VoskRecognizer(_model, _sampleRate);
                _waveIn = new WaveInEvent();
                _waveIn.WaveFormat = new WaveFormat(_sampleRate, _channelCount);
                //_waveIn.DeviceNumber = _selectedDeviceIndex;
                //_waveIn.BufferMilliseconds = 10000;
                _waveIn.DataAvailable += WaveInOnDataAvailable;
                _startTime = DateTime.Now;
                _waveIn.StartRecording();
            }
            catch { throw; }
        }

        public void StopRecognize()
        {
            try
            {
                logger.Info("Recognition stopping...");
                _waveIn.StopRecording();
            }
            catch { throw; }
        }

        private void WaveInOnDataAvailable(object? sender, WaveInEventArgs e)
        {
            try
            {
                if (_recognizer.AcceptWaveform(e.Buffer, e.BytesRecorded))
                {
                    var result = JsonSerializer.Deserialize<RecognizedResult>(_recognizer.FinalResult(),  new JsonSerializerOptions{ PropertyNameCaseInsensitive = true }) ;
                    _startTime = DateTime.Now;
                    //using (var writer = new StreamWriter("output.txt", true))
                    //{
                    //    writer.Write(DateTime.Now + ": " + text);
                    //}
                    if (!String.IsNullOrEmpty(result?.Text))
                        SpeechRecognized?.Invoke(this, new RecognizerEventArgs(result.Text));

                    //Console.WriteLine(DateTime.Now + ": " + _recognizer.Result());
                }
                else
                {
                    if (DateTime.Now - _startTime > TimeSpan.FromSeconds(10))
                    {
                        var result = JsonSerializer.Deserialize<RecognizedResult>(_recognizer.FinalResult(), new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                        _startTime = DateTime.Now;
                        if (!String.IsNullOrEmpty(result?.Text))
                            SpeechRecognized?.Invoke(this, new RecognizerEventArgs(result.Text));
                        _recognizer.Reset();
                    }
                }
            }
            catch (Exception ex) 
            {
                logger.Error(ex, "Speech unit recognition error.");
            }
        }

        public void SetInputDevice(int index)
        {
            _selectedDeviceIndex = index;
        }

        private void GetInputDevices()
        {
            List<string> inputDevices = new List<string>();
            MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
            _captureDevices = enumerator.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active);
            
            foreach (var device in _captureDevices)
            {
                inputDevices.Add(device.FriendlyName);
            }
            InputDevices = inputDevices;
        }

        public void GetDefaultDevice()
        {
            MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
            MMDevice _selectedDevice = enumerator.GetDefaultAudioEndpoint(DataFlow.Capture, Role.Console);
            
            _sampleRate = _selectedDevice.AudioClient.MixFormat.SampleRate;
            _channelCount = _selectedDevice.AudioClient.MixFormat.Channels;

            SelectedDeviceIndex = _captureDevices.IndexOf(_selectedDevice);
        }
    }

    public static class MMDeviceCollectionExtension
    {
        public static int IndexOf(this MMDeviceCollection deviceCollection, MMDevice device)
        {
            int defaultDeviceIndex = -1;
            for (int i = 0; i < deviceCollection.Count; i++)
            {
                if (deviceCollection[i].ID == device.ID)
                {
                    defaultDeviceIndex = i;
                    break;
                }
            }
            return defaultDeviceIndex;
        }
    }

    public class RecognizerEventArgs : EventArgs
    {
        public string Text { get; set; }
        public RecognizerEventArgs(string text)
        {
            Text = text;
        }
    }

    public class RecognizedResult
    {
        public string? Text { get; set; }

    }
}
