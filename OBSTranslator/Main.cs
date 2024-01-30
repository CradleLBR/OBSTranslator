using NLog;

namespace OBSTranslator
{
    public partial class Main : Form
    {
        private ObsSocket _obsSocket;
        private SpeechRecognizer _speechRecognizer;
        private string? _recognizedText;
        Logger logger = LogManager.GetCurrentClassLogger();

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            _speechRecognizer = new SpeechRecognizer();
            _speechRecognizer.SpeechRecognized += OnSpeechRecognized;
            cb_Micro.DataSource = _speechRecognizer.InputDevices;
            var selectedDevice = _speechRecognizer.SelectedDeviceIndex;
            cb_Micro.SelectedIndex = selectedDevice;
        }

        private async void btn_Connect_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                var obsUri = String.Join(':', tb_Ip.Text, tb_Port.Text);
                _obsSocket = new ObsSocket(obsUri);
                await _obsSocket.ConnectAsync();
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Connecting to WebSocket error.");
            }
        }

        private async void btn_CreateSource_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                var sceneName = tb_SceneName.Text;
                var sourceName = tb_SourceName.Text;
                await _obsSocket.CreateInput(sceneName, sourceName, new ObsSocket.InputSettings());
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Creating Input error.");
            }
        }

        private void lbl_HidePort_Click(object sender, EventArgs e)
        {
            if (tb_Port.PasswordChar != '\0')
                tb_Port.PasswordChar = '\0';
            else
                tb_Port.PasswordChar = '●';
        }

        private void lbl_HideIp_Click(object sender, EventArgs e)
        {
            if (tb_Ip.PasswordChar != '\0')
                tb_Ip.PasswordChar = '\0';
            else
                tb_Ip.PasswordChar = '●';
        }

        private void cb_Micro_DropDownClosed(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void cb_Micro_SelectedIndexChanged(object sender, EventArgs e)
        {
            _speechRecognizer.SetInputDevice(cb_Micro.SelectedIndex);
        }

        private void cb_Micro_DropDown(object sender, EventArgs e)
        {
            cb_Micro.DataSource = _speechRecognizer.InputDevices;
            var selectedDevice = _speechRecognizer.SelectedDeviceIndex;
            cb_Micro.SelectedIndex = selectedDevice;
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            Task.Run(() => _speechRecognizer.StartRecognize());
            //_speechRecognizer.StartRecognize();
        }

        private void OnSpeechRecognized(object? sender, EventArgs e)
        {
            _recognizedText = (e as RecognizerEventArgs)?.Text;
            //tb_RecognizedText.Text += DateTime.Now + ": " + _recognizedText + Environment.NewLine;
            //tb_RecognizedText.Text = DateTime.Now + ": test";
            if (tb_RecognizedText.InvokeRequired)
                tb_RecognizedText.BeginInvoke(new Action(() => { tb_RecognizedText.Text += DateTime.Now + ": " + _recognizedText + Environment.NewLine; }));
            //else
            //    tb_RecognizedText.Text = DateTime.Now + ": " + _recognizedText;
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            _speechRecognizer.StopRecognize();
        }
    }
}