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
            tabControl1 = new TabControl();
            mainPage = new TabPage();
            settingsPage = new TabPage();
            groupBox2 = new GroupBox();
            btn_CreateSource = new Button();
            lbl_SourceName = new Label();
            tb_SourceName = new TextBox();
            lbl_SceneName = new Label();
            tb_SceneName = new TextBox();
            groupBox1 = new GroupBox();
            tb_Port = new TextBox();
            lbl_Port = new Label();
            lbl_HidePort = new Label();
            tb_Ip = new TextBox();
            lbl_Ip = new Label();
            lbl_HideIp = new Label();
            btn_Connect = new Button();
            tabControl1.SuspendLayout();
            settingsPage.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
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
            mainPage.Location = new Point(4, 24);
            mainPage.Name = "mainPage";
            mainPage.Padding = new Padding(3);
            mainPage.Size = new Size(792, 422);
            mainPage.TabIndex = 0;
            mainPage.Text = "Main";
            mainPage.UseVisualStyleBackColor = true;
            // 
            // settingsPage
            // 
            settingsPage.Controls.Add(groupBox2);
            settingsPage.Controls.Add(groupBox1);
            settingsPage.Location = new Point(4, 24);
            settingsPage.Name = "settingsPage";
            settingsPage.Padding = new Padding(3);
            settingsPage.Size = new Size(792, 422);
            settingsPage.TabIndex = 1;
            settingsPage.Text = "Settings";
            settingsPage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_CreateSource);
            groupBox2.Controls.Add(lbl_SourceName);
            groupBox2.Controls.Add(tb_SourceName);
            groupBox2.Controls.Add(lbl_SceneName);
            groupBox2.Controls.Add(tb_SceneName);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(3, 126);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(786, 166);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Text Source";
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
            // groupBox1
            // 
            groupBox1.Controls.Add(tb_Port);
            groupBox1.Controls.Add(lbl_Port);
            groupBox1.Controls.Add(lbl_HidePort);
            groupBox1.Controls.Add(tb_Ip);
            groupBox1.Controls.Add(lbl_Ip);
            groupBox1.Controls.Add(lbl_HideIp);
            groupBox1.Controls.Add(btn_Connect);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(786, 123);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Server";
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
            Name = "Main";
            Text = "OBSTranslator";
            Load += Main_LoadAsync;
            tabControl1.ResumeLayout(false);
            settingsPage.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private GroupBox groupBox2;
        private TextBox tb_SceneName;
        private GroupBox groupBox1;
        private Button btn_CreateSource;
        private Label lbl_SourceName;
        private TextBox tb_SourceName;
        private Label lbl_SceneName;
        private TextBox tb_Port;
        private Label lbl_Port;
        private Label lbl_HidePort;
    }
}