using MaterialSkin;
using MaterialSkin.Controls;
using NLog;

namespace OBSTranslator
{
    public partial class Main : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        private ObsSocket _obsSocket;
        private SpeechRecognizer _speechRecognizer;
        private string? _recognizedText;
        Logger logger = LogManager.GetCurrentClassLogger();

        public Main()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.Green700, TextShade.WHITE);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            _speechRecognizer = new SpeechRecognizer();
            _speechRecognizer.SpeechRecognized += OnSpeechRecognized;
            mcb_Micro.DataSource = _speechRecognizer.InputDevices;
            var selectedDevice = _speechRecognizer.SelectedDeviceIndex;
            mcb_Micro.SelectedIndex = selectedDevice;
        }

        private async void mep_Server_ConnectClick(object sender, EventArgs e)
        {
            try
            {
                var obsUri = String.Join(':', mtb_ServerIp.Text, mtb_ServerPort.Text);
                _obsSocket = new ObsSocket(obsUri);
                await _obsSocket.ConnectAsync();
            }
            catch (Exception ex) // Error handling in async void
            {
                logger.Error(ex, "Connecting to WebSocket error.");
            }
        }

        private async void mep_Source_CreateClick(object sender, EventArgs e)
        {
            try
            {
                var sceneName = mtb_SceneName.Text;
                var sourceName = mtb_SourceName.Text;
                await _obsSocket.CreateInput(sceneName, sourceName, new ObsSocket.InputSettings());
            }
            catch (Exception ex) // Error handling in async void
            {
                logger.Error(ex, "Creating Input error.");
            }
        }

        private void mtb_ServerIp_LeadingIconClick(object sender, EventArgs e)
        {
            if (mtb_ServerIp.PasswordChar != '\0')
            {
                mtb_ServerIp.PasswordChar = '\0';
                mtb_ServerIp.LeadingIcon = Properties.Resources.hidePass;
            }
            else
            {
                mtb_ServerIp.PasswordChar = '●';
                mtb_ServerIp.LeadingIcon = Properties.Resources.showPass;
            }
        }

        private void mtb_ServerPort_LeadingIconClick(object sender, EventArgs e)
        {
            if (mtb_ServerPort.PasswordChar != '\0')
            {
                mtb_ServerPort.PasswordChar = '\0';
                mtb_ServerPort.LeadingIcon = Properties.Resources.hidePass;
            }
            else
            {
                mtb_ServerPort.PasswordChar = '●';
                mtb_ServerPort.LeadingIcon = Properties.Resources.showPass;
            }
        }

        private void mcb_Micro_DropDownClosed(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void mcb_Micro_SelectedIndexChanged(object sender, EventArgs e)
        {
            _speechRecognizer.SetInputDevice(mcb_Micro.SelectedIndex);
        }

        private void mcb_Micro_DropDown(object sender, EventArgs e)
        {
            mcb_Micro.DataSource = _speechRecognizer.InputDevices;
            var selectedDevice = _speechRecognizer.SelectedDeviceIndex;
            mcb_Micro.SelectedIndex = selectedDevice;
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            try
            {
                Task.Run(() => _speechRecognizer.StartRecognize());
                //_speechRecognizer.StartRecognize();
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Recognition starting error.");
            }
        }

        private void OnSpeechRecognized(object? sender, EventArgs e)
        {
            try
            {
                _recognizedText = (e as RecognizerEventArgs)?.Text;
                //tb_RecognizedText.Text += DateTime.Now + ": " + _recognizedText + Environment.NewLine;
                //tb_RecognizedText.Text = DateTime.Now + ": test";
                if (tb_RecognizedText.InvokeRequired)
                    tb_RecognizedText.BeginInvoke(new Action(() =>
                        {
                            var text = DateTime.Now.ToString("MM/dd/yy HH:mm:ss") + ": " + _recognizedText;
                            tb_RecognizedText.Text += text + Environment.NewLine;
                            logger.ConditionalDebug("||RECOGNIZED||" + text);
                        }));
                //else
                //    tb_RecognizedText.Text = DateTime.Now + ": " + _recognizedText;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Recognized text handling error.");
            }
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            try
            {
                _speechRecognizer.StopRecognize();
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Recognition stopping error.");
            }
        }

        private void flp_Settings_Layout(object sender, LayoutEventArgs e)
        {
            flp_Settings.SuspendLayout();
            foreach (Control ctrl in flp_Settings.Controls)
            {
                ctrl.Width = flp_Settings.ClientSize.Width - 34;
            }
            flp_Settings.ResumeLayout();
        }

        private void mep_Server_PanelExpand(object sender, EventArgs e)
        {
            mep_Source.Collapse = true;
        }

        private void mep_Source_PanelExpand(object sender, EventArgs e)
        {
            mep_Server.Collapse = true;
        }
    }
}