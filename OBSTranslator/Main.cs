namespace OBSTranslator
{
    public partial class Main : Form
    {
        private ObsSocket _obsSocket;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_LoadAsync(object sender, EventArgs e)
        {

        }

        private async void btn_Connect_ClickAsync(object sender, EventArgs e)
        {
            var obsUri = String.Join(':', tb_Ip.Text, tb_Port.Text);
            _obsSocket = new ObsSocket(obsUri);
            await _obsSocket.ConnectAsync();
        }

        private async void btn_CreateSource_ClickAsync(object sender, EventArgs e)
        {
            var sceneName = tb_SceneName.Text;
            var sourceName = tb_SourceName.Text;
            await _obsSocket.CreateInput(sceneName, sourceName, new InputSettings());
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
    }
}