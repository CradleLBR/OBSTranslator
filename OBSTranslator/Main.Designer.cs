namespace OBSTranslator
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            tabControl1 = new TabControl();
            mainPage = new TabPage();
            btn_Stop = new Button();
            btn_Start = new Button();
            tb_TranslatedText = new TextBox();
            tb_RecognizedText = new TextBox();
            settingsPage = new TabPage();
            gb_Sound = new GroupBox();
            cb_Micro = new ComboBox();
            label1 = new Label();
            gb_TSource = new GroupBox();
            btn_CreateSource = new Button();
            lbl_SourceName = new Label();
            tb_SourceName = new TextBox();
            lbl_SceneName = new Label();
            tb_SceneName = new TextBox();
            gb_Server = new GroupBox();
            tb_Port = new TextBox();
            lbl_Port = new Label();
            lbl_HidePort = new Label();
            tb_Ip = new TextBox();
            lbl_Ip = new Label();
            lbl_HideIp = new Label();
            btn_Connect = new Button();
            tabControl1.SuspendLayout();
            mainPage.SuspendLayout();
            settingsPage.SuspendLayout();
            gb_Sound.SuspendLayout();
            gb_TSource.SuspendLayout();
            gb_Server.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(mainPage);
            tabControl1.Controls.Add(settingsPage);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // mainPage
            // 
            mainPage.Controls.Add(btn_Stop);
            mainPage.Controls.Add(btn_Start);
            mainPage.Controls.Add(tb_TranslatedText);
            mainPage.Controls.Add(tb_RecognizedText);
            mainPage.Location = new Point(4, 24);
            mainPage.Name = "mainPage";
            mainPage.Padding = new Padding(3);
            mainPage.Size = new Size(792, 422);
            mainPage.TabIndex = 0;
            mainPage.Text = "Main";
            mainPage.UseVisualStyleBackColor = true;
            // 
            // btn_Stop
            // 
            btn_Stop.BackColor = Color.LightGray;
            btn_Stop.Dock = DockStyle.Bottom;
            btn_Stop.FlatStyle = FlatStyle.Flat;
            btn_Stop.Location = new Point(3, 384);
            btn_Stop.Name = "btn_Stop";
            btn_Stop.Size = new Size(786, 35);
            btn_Stop.TabIndex = 5;
            btn_Stop.Text = "Stop";
            btn_Stop.UseVisualStyleBackColor = false;
            btn_Stop.Click += btn_Stop_Click;
            // 
            // btn_Start
            // 
            btn_Start.BackColor = Color.LightGray;
            btn_Start.Dock = DockStyle.Top;
            btn_Start.FlatStyle = FlatStyle.Flat;
            btn_Start.Location = new Point(3, 349);
            btn_Start.Name = "btn_Start";
            btn_Start.Size = new Size(786, 35);
            btn_Start.TabIndex = 4;
            btn_Start.Text = "Start";
            btn_Start.UseVisualStyleBackColor = false;
            btn_Start.Click += btn_Start_Click;
            // 
            // tb_TranslatedText
            // 
            tb_TranslatedText.BackColor = SystemColors.ButtonHighlight;
            tb_TranslatedText.Dock = DockStyle.Top;
            tb_TranslatedText.Location = new Point(3, 176);
            tb_TranslatedText.Multiline = true;
            tb_TranslatedText.Name = "tb_TranslatedText";
            tb_TranslatedText.ReadOnly = true;
            tb_TranslatedText.Size = new Size(786, 173);
            tb_TranslatedText.TabIndex = 1;
            // 
            // tb_RecognizedText
            // 
            tb_RecognizedText.BackColor = SystemColors.ButtonHighlight;
            tb_RecognizedText.Dock = DockStyle.Top;
            tb_RecognizedText.Location = new Point(3, 3);
            tb_RecognizedText.Multiline = true;
            tb_RecognizedText.Name = "tb_RecognizedText";
            tb_RecognizedText.ReadOnly = true;
            tb_RecognizedText.Size = new Size(786, 173);
            tb_RecognizedText.TabIndex = 0;
            // 
            // settingsPage
            // 
            settingsPage.Controls.Add(gb_Sound);
            settingsPage.Controls.Add(gb_TSource);
            settingsPage.Controls.Add(gb_Server);
            settingsPage.Location = new Point(4, 24);
            settingsPage.Name = "settingsPage";
            settingsPage.Padding = new Padding(3);
            settingsPage.Size = new Size(792, 422);
            settingsPage.TabIndex = 1;
            settingsPage.Text = "Settings";
            settingsPage.UseVisualStyleBackColor = true;
            // 
            // gb_Sound
            // 
            gb_Sound.Controls.Add(cb_Micro);
            gb_Sound.Controls.Add(label1);
            gb_Sound.Dock = DockStyle.Top;
            gb_Sound.Location = new Point(3, 292);
            gb_Sound.Name = "gb_Sound";
            gb_Sound.Size = new Size(786, 100);
            gb_Sound.TabIndex = 7;
            gb_Sound.TabStop = false;
            gb_Sound.Text = "Sound";
            // 
            // cb_Micro
            // 
            cb_Micro.FormattingEnabled = true;
            cb_Micro.Location = new Point(123, 25);
            cb_Micro.Name = "cb_Micro";
            cb_Micro.Size = new Size(220, 23);
            cb_Micro.TabIndex = 9;
            cb_Micro.DropDown += cb_Micro_DropDown;
            cb_Micro.SelectedIndexChanged += cb_Micro_SelectedIndexChanged;
            cb_Micro.DropDownClosed += cb_Micro_DropDownClosed;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 28);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 8;
            label1.Text = "Microphone:";
            // 
            // gb_TSource
            // 
            gb_TSource.Controls.Add(btn_CreateSource);
            gb_TSource.Controls.Add(lbl_SourceName);
            gb_TSource.Controls.Add(tb_SourceName);
            gb_TSource.Controls.Add(lbl_SceneName);
            gb_TSource.Controls.Add(tb_SceneName);
            gb_TSource.Dock = DockStyle.Top;
            gb_TSource.Location = new Point(3, 126);
            gb_TSource.Name = "gb_TSource";
            gb_TSource.Size = new Size(786, 166);
            gb_TSource.TabIndex = 6;
            gb_TSource.TabStop = false;
            gb_TSource.Text = "Text Source";
            // 
            // btn_CreateSource
            // 
            btn_CreateSource.Location = new Point(367, 90);
            btn_CreateSource.Name = "btn_CreateSource";
            btn_CreateSource.Size = new Size(91, 23);
            btn_CreateSource.TabIndex = 8;
            btn_CreateSource.Text = "Create";
            btn_CreateSource.UseVisualStyleBackColor = true;
            btn_CreateSource.Click += btn_CreateSource_ClickAsync;
            // 
            // lbl_SourceName
            // 
            lbl_SourceName.AutoSize = true;
            lbl_SourceName.Location = new Point(24, 94);
            lbl_SourceName.Name = "lbl_SourceName";
            lbl_SourceName.Size = new Size(81, 15);
            lbl_SourceName.TabIndex = 7;
            lbl_SourceName.Text = "Source Name:";
            // 
            // tb_SourceName
            // 
            tb_SourceName.Location = new Point(123, 91);
            tb_SourceName.Name = "tb_SourceName";
            tb_SourceName.Size = new Size(220, 23);
            tb_SourceName.TabIndex = 6;
            // 
            // lbl_SceneName
            // 
            lbl_SceneName.AutoSize = true;
            lbl_SceneName.Location = new Point(24, 46);
            lbl_SceneName.Name = "lbl_SceneName";
            lbl_SceneName.Size = new Size(76, 15);
            lbl_SceneName.TabIndex = 5;
            lbl_SceneName.Text = "Scene Name:";
            // 
            // tb_SceneName
            // 
            tb_SceneName.Location = new Point(123, 43);
            tb_SceneName.Name = "tb_SceneName";
            tb_SceneName.Size = new Size(220, 23);
            tb_SceneName.TabIndex = 4;
            // 
            // gb_Server
            // 
            gb_Server.Controls.Add(tb_Port);
            gb_Server.Controls.Add(lbl_Port);
            gb_Server.Controls.Add(lbl_HidePort);
            gb_Server.Controls.Add(tb_Ip);
            gb_Server.Controls.Add(lbl_Ip);
            gb_Server.Controls.Add(lbl_HideIp);
            gb_Server.Controls.Add(btn_Connect);
            gb_Server.Dock = DockStyle.Top;
            gb_Server.Location = new Point(3, 3);
            gb_Server.Name = "gb_Server";
            gb_Server.Size = new Size(786, 123);
            gb_Server.TabIndex = 5;
            gb_Server.TabStop = false;
            gb_Server.Text = "Server";
            // 
            // tb_Port
            // 
            tb_Port.Location = new Point(123, 76);
            tb_Port.Name = "tb_Port";
            tb_Port.PasswordChar = '●';
            tb_Port.Size = new Size(220, 23);
            tb_Port.TabIndex = 4;
            // 
            // lbl_Port
            // 
            lbl_Port.AutoSize = true;
            lbl_Port.Location = new Point(24, 79);
            lbl_Port.Name = "lbl_Port";
            lbl_Port.Size = new Size(67, 15);
            lbl_Port.TabIndex = 5;
            lbl_Port.Text = "Server Port:";
            // 
            // lbl_HidePort
            // 
            lbl_HidePort.AutoSize = true;
            lbl_HidePort.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_HidePort.Location = new Point(89, 76);
            lbl_HidePort.Name = "lbl_HidePort";
            lbl_HidePort.Size = new Size(30, 20);
            lbl_HidePort.TabIndex = 6;
            lbl_HidePort.Text = "👁️";
            lbl_HidePort.Click += lbl_HidePort_Click;
            // 
            // tb_Ip
            // 
            tb_Ip.Location = new Point(123, 32);
            tb_Ip.Name = "tb_Ip";
            tb_Ip.PasswordChar = '●';
            tb_Ip.Size = new Size(220, 23);
            tb_Ip.TabIndex = 0;
            // 
            // lbl_Ip
            // 
            lbl_Ip.AutoSize = true;
            lbl_Ip.Location = new Point(24, 35);
            lbl_Ip.Name = "lbl_Ip";
            lbl_Ip.Size = new Size(55, 15);
            lbl_Ip.TabIndex = 1;
            lbl_Ip.Text = "Server IP:";
            // 
            // lbl_HideIp
            // 
            lbl_HideIp.AutoSize = true;
            lbl_HideIp.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_HideIp.Location = new Point(89, 32);
            lbl_HideIp.Name = "lbl_HideIp";
            lbl_HideIp.Size = new Size(30, 20);
            lbl_HideIp.TabIndex = 3;
            lbl_HideIp.Text = "👁️";
            lbl_HideIp.Click += lbl_HideIp_Click;
            // 
            // btn_Connect
            // 
            btn_Connect.Location = new Point(367, 75);
            btn_Connect.Name = "btn_Connect";
            btn_Connect.Size = new Size(91, 23);
            btn_Connect.TabIndex = 2;
            btn_Connect.Text = "Connect";
            btn_Connect.UseVisualStyleBackColor = true;
            btn_Connect.Click += btn_Connect_ClickAsync;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            Text = "OBSTranslator";
            Load += Main_Load;
            tabControl1.ResumeLayout(false);
            mainPage.ResumeLayout(false);
            mainPage.PerformLayout();
            settingsPage.ResumeLayout(false);
            gb_Sound.ResumeLayout(false);
            gb_Sound.PerformLayout();
            gb_TSource.ResumeLayout(false);
            gb_TSource.PerformLayout();
            gb_Server.ResumeLayout(false);
            gb_Server.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage mainPage;
        private TabPage settingsPage;
        private TextBox tb_Ip;
        private Label lbl_Ip;
        private Label lbl_HideIp;
        private Button btn_Connect;
        private GroupBox gb_TSource;
        private TextBox tb_SceneName;
        private GroupBox gb_Server;
        private Button btn_CreateSource;
        private Label lbl_SourceName;
        private TextBox tb_SourceName;
        private Label lbl_SceneName;
        private TextBox tb_Port;
        private Label lbl_Port;
        private Label lbl_HidePort;
        private GroupBox gb_Sound;
        private ComboBox cb_Micro;
        private Label label1;
        private TextBox tb_RecognizedText;
        private TextBox tb_TranslatedText;
        private Button btn_Stop;
        private Button btn_Start;
    }
}