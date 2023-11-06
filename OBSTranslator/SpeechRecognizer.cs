using NAudio.CoreAudioApi;
using System.Reflection;
using System.Runtime.CompilerServices;
using Vosk;

namespace OBSTranslator
{
    public class SpeechRecognizer
    {
        private int _sampleRate;
        private int _channelCount;
        private MMDeviceCollection _captureDevices;
        private MMDevice _selectedDevice;

        public SpeechRecognizer()
        {
            //Model model = new Model("model");
        }

        public List<string> GetInputDevices()
        {
            List<string> inputDevices = new List<string>();
            MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
            _captureDevices = enumerator.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active);
            foreach (var device in _captureDevices)
            {
                inputDevices.Add(device.FriendlyName);
            }
            return inputDevices;
        }

        public int GetDefaultDevice()
        {
            MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
            MMDevice defaultCaptureDevice = enumerator.GetDefaultAudioEndpoint(DataFlow.Capture, Role.Console);
            
            _sampleRate = defaultCaptureDevice.AudioClient.MixFormat.SampleRate;
            _channelCount = defaultCaptureDevice.AudioClient.MixFormat.Channels;

            return _captureDevices.IndexOf(defaultCaptureDevice);
        }

        public void SetInputDevice(int index)
        {
            _selectedDevice = _captureDevices[index];
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
}
