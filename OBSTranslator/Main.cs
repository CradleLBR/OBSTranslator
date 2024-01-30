using NLog;

namespace OBSTranslator
{
    public partial class Main : Form
    {
        private ObsSocket _obsSocket;
        private SpeechRecognizer _speechRecognizer;
        Logger logger = LogManager.GetCurrentClassLogger();
        
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            _speechRecognizer = new SpeechRecognizer();
            cb_Micro.DataSource = _speechRecognizer.GetInputDevices();
            var selectedDevice = _speechRecognizer.GetDefaultDevice();
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
                await _obsSocket.CreateInput(sceneName, sourceName, new InputSettings());
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
    }
}