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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            pgRecognition = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            tb_RecognizedText = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            tb_TranslatedText = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            pnl_Start = new Panel();
            btn_Start = new MaterialSkin.Controls.MaterialButton();
            pnl_Stop = new Panel();
            btn_Stop = new MaterialSkin.Controls.MaterialButton();
            materialDrawer1 = new MaterialSkin.Controls.MaterialDrawer();
            pgSettings = new TabPage();
            flp_Settings = new FlowLayoutPanel();
            mc_Micro = new MaterialSkin.Controls.MaterialCard();
            tableLayoutPanel1 = new TableLayoutPanel();
            mcb_Micro = new MaterialSkin.Controls.MaterialComboBox();
            mlbl_Micro = new MaterialSkin.Controls.MaterialLabel();
            mep_Server = new MaterialSkin.Controls.MaterialExpansionPanel();
            mtb_ServerPort = new MaterialSkin.Controls.MaterialTextBox2();
            mtb_ServerIp = new MaterialSkin.Controls.MaterialTextBox2();
            mep_Source = new MaterialSkin.Controls.MaterialExpansionPanel();
            panel1 = new Panel();
            mtb_SceneName = new MaterialSkin.Controls.MaterialTextBox2();
            panel2 = new Panel();
            mtb_SourceName = new MaterialSkin.Controls.MaterialTextBox2();
            menuIconList = new ImageList(components);
            materialTabControl1.SuspendLayout();
            pgRecognition.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            pnl_Start.SuspendLayout();
            pnl_Stop.SuspendLayout();
            pgSettings.SuspendLayout();
            flp_Settings.SuspendLayout();
            mc_Micro.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            mep_Server.SuspendLayout();
            mep_Source.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(pgRecognition);
            materialTabControl1.Controls.Add(pgSettings);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.ImageList = menuIconList;
            materialTabControl1.Location = new Point(0, 24);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(900, 573);
            materialTabControl1.TabIndex = 1;
            // 
            // pgRecognition
            // 
            pgRecognition.BackColor = Color.White;
            pgRecognition.Controls.Add(tableLayoutPanel2);
            pgRecognition.Controls.Add(pnl_Start);
            pgRecognition.Controls.Add(pnl_Stop);
            pgRecognition.Controls.Add(materialDrawer1);
            pgRecognition.ImageKey = "wave-sound.png";
            pgRecognition.Location = new Point(4, 39);
            pgRecognition.Name = "pgRecognition";
            pgRecognition.Padding = new Padding(13);
            pgRecognition.Size = new Size(892, 530);
            pgRecognition.TabIndex = 0;
            pgRecognition.Text = "Recognition";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tb_RecognizedText, 0, 0);
            tableLayoutPanel2.Controls.Add(tb_TranslatedText, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(13, 13);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(866, 412);
            tableLayoutPanel2.TabIndex = 9;
            // 
            // tb_RecognizedText
            // 
            tb_RecognizedText.AnimateReadOnly = true;
            tb_RecognizedText.BackgroundImageLayout = ImageLayout.None;
            tb_RecognizedText.CharacterCasing = CharacterCasing.Normal;
            tb_RecognizedText.Depth = 0;
            tb_RecognizedText.Dock = DockStyle.Fill;
            tb_RecognizedText.HideSelection = true;
            tb_RecognizedText.Hint = "Recognized";
            tb_RecognizedText.Location = new Point(3, 3);
            tb_RecognizedText.MaxLength = 32767;
            tb_RecognizedText.MouseState = MaterialSkin.MouseState.OUT;
            tb_RecognizedText.Name = "tb_RecognizedText";
            tb_RecognizedText.PasswordChar = '\0';
            tb_RecognizedText.ReadOnly = true;
            tb_RecognizedText.ScrollBars = ScrollBars.Vertical;
            tb_RecognizedText.SelectedText = "";
            tb_RecognizedText.SelectionLength = 0;
            tb_RecognizedText.SelectionStart = 0;
            tb_RecognizedText.ShortcutsEnabled = true;
            tb_RecognizedText.Size = new Size(860, 200);
            tb_RecognizedText.TabIndex = 1;
            tb_RecognizedText.TabStop = false;
            tb_RecognizedText.TextAlign = HorizontalAlignment.Left;
            tb_RecognizedText.UseSystemPasswordChar = false;
            // 
            // tb_TranslatedText
            // 
            tb_TranslatedText.AnimateReadOnly = true;
            tb_TranslatedText.BackgroundImageLayout = ImageLayout.None;
            tb_TranslatedText.CharacterCasing = CharacterCasing.Normal;
            tb_TranslatedText.Depth = 0;
            tb_TranslatedText.Dock = DockStyle.Fill;
            tb_TranslatedText.HideSelection = true;
            tb_TranslatedText.Hint = "Translated";
            tb_TranslatedText.Location = new Point(3, 209);
            tb_TranslatedText.MaxLength = 32767;
            tb_TranslatedText.MouseState = MaterialSkin.MouseState.OUT;
            tb_TranslatedText.Name = "tb_TranslatedText";
            tb_TranslatedText.PasswordChar = '\0';
            tb_TranslatedText.ReadOnly = true;
            tb_TranslatedText.ScrollBars = ScrollBars.Vertical;
            tb_TranslatedText.SelectedText = "";
            tb_TranslatedText.SelectionLength = 0;
            tb_TranslatedText.SelectionStart = 0;
            tb_TranslatedText.ShortcutsEnabled = true;
            tb_TranslatedText.Size = new Size(860, 200);
            tb_TranslatedText.TabIndex = 2;
            tb_TranslatedText.TabStop = false;
            tb_TranslatedText.TextAlign = HorizontalAlignment.Left;
            tb_TranslatedText.UseSystemPasswordChar = false;
            // 
            // pnl_Start
            // 
            pnl_Start.Controls.Add(btn_Start);
            pnl_Start.Dock = DockStyle.Bottom;
            pnl_Start.Location = new Point(13, 425);
            pnl_Start.Name = "pnl_Start";
            pnl_Start.Padding = new Padding(0, 3, 0, 2);
            pnl_Start.Size = new Size(866, 46);
            pnl_Start.TabIndex = 7;
            // 
            // btn_Start
            // 
            btn_Start.AutoSize = false;
            btn_Start.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_Start.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_Start.Depth = 0;
            btn_Start.Dock = DockStyle.Fill;
            btn_Start.HighEmphasis = true;
            btn_Start.Icon = null;
            btn_Start.Location = new Point(0, 3);
            btn_Start.Margin = new Padding(4, 6, 4, 6);
            btn_Start.MouseState = MaterialSkin.MouseState.HOVER;
            btn_Start.Name = "btn_Start";
            btn_Start.NoAccentTextColor = Color.Empty;
            btn_Start.Size = new Size(866, 41);
            btn_Start.TabIndex = 4;
            btn_Start.Text = "Start";
            btn_Start.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_Start.UseAccentColor = false;
            btn_Start.UseVisualStyleBackColor = true;
            btn_Start.Click += btn_Start_Click;
            // 
            // pnl_Stop
            // 
            pnl_Stop.Controls.Add(btn_Stop);
            pnl_Stop.Dock = DockStyle.Bottom;
            pnl_Stop.Location = new Point(13, 471);
            pnl_Stop.Name = "pnl_Stop";
            pnl_Stop.Padding = new Padding(0, 3, 0, 2);
            pnl_Stop.Size = new Size(866, 46);
            pnl_Stop.TabIndex = 8;
            // 
            // btn_Stop
            // 
            btn_Stop.AutoSize = false;
            btn_Stop.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_Stop.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_Stop.Depth = 0;
            btn_Stop.Dock = DockStyle.Fill;
            btn_Stop.HighEmphasis = true;
            btn_Stop.Icon = null;
            btn_Stop.Location = new Point(0, 3);
            btn_Stop.Margin = new Padding(4, 6, 4, 6);
            btn_Stop.MouseState = MaterialSkin.MouseState.HOVER;
            btn_Stop.Name = "btn_Stop";
            btn_Stop.NoAccentTextColor = Color.Empty;
            btn_Stop.Size = new Size(866, 41);
            btn_Stop.TabIndex = 5;
            btn_Stop.Text = "Stop";
            btn_Stop.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_Stop.UseAccentColor = false;
            btn_Stop.UseVisualStyleBackColor = true;
            btn_Stop.Click += btn_Stop_Click;
            // 
            // materialDrawer1
            // 
            materialDrawer1.AutoHide = false;
            materialDrawer1.AutoShow = false;
            materialDrawer1.BackgroundWithAccent = false;
            materialDrawer1.BaseTabControl = null;
            materialDrawer1.Depth = 0;
            materialDrawer1.HighlightWithAccent = true;
            materialDrawer1.IndicatorWidth = 0;
            materialDrawer1.IsOpen = false;
            materialDrawer1.Location = new Point(-250, 267);
            materialDrawer1.MouseState = MaterialSkin.MouseState.HOVER;
            materialDrawer1.Name = "materialDrawer1";
            materialDrawer1.ShowIconsWhenHidden = false;
            materialDrawer1.Size = new Size(250, 120);
            materialDrawer1.TabIndex = 3;
            materialDrawer1.Text = "materialDrawer1";
            materialDrawer1.UseColors = false;
            // 
            // pgSettings
            // 
            pgSettings.BackColor = Color.White;
            pgSettings.Controls.Add(flp_Settings);
            pgSettings.ImageKey = "setting.png";
            pgSettings.Location = new Point(4, 39);
            pgSettings.Name = "pgSettings";
            pgSettings.Padding = new Padding(3);
            pgSettings.Size = new Size(892, 530);
            pgSettings.TabIndex = 1;
            pgSettings.Text = "Settings";
            // 
            // flp_Settings
            // 
            flp_Settings.AutoScroll = true;
            flp_Settings.BackColor = Color.White;
            flp_Settings.Controls.Add(mc_Micro);
            flp_Settings.Controls.Add(mep_Server);
            flp_Settings.Controls.Add(mep_Source);
            flp_Settings.Dock = DockStyle.Fill;
            flp_Settings.FlowDirection = FlowDirection.TopDown;
            flp_Settings.Location = new Point(3, 3);
            flp_Settings.Name = "flp_Settings";
            flp_Settings.Padding = new Padding(0, 13, 0, 0);
            flp_Settings.Size = new Size(886, 524);
            flp_Settings.TabIndex = 2;
            flp_Settings.WrapContents = false;
            flp_Settings.Layout += flp_Settings_Layout;
            // 
            // mc_Micro
            // 
            mc_Micro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            mc_Micro.BackColor = Color.FromArgb(255, 255, 255);
            mc_Micro.Controls.Add(tableLayoutPanel1);
            mc_Micro.Depth = 0;
            mc_Micro.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mc_Micro.Location = new Point(16, 14);
            mc_Micro.Margin = new Padding(16, 1, 16, 0);
            mc_Micro.MouseState = MaterialSkin.MouseState.HOVER;
            mc_Micro.Name = "mc_Micro";
            mc_Micro.Padding = new Padding(14);
            mc_Micro.Size = new Size(854, 77);
            mc_Micro.TabIndex = 14;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(mcb_Micro, 1, 0);
            tableLayoutPanel1.Controls.Add(mlbl_Micro, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(14, 14);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(826, 49);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // mcb_Micro
            // 
            mcb_Micro.AutoResize = false;
            mcb_Micro.BackColor = Color.White;
            mcb_Micro.Depth = 0;
            mcb_Micro.Dock = DockStyle.Fill;
            mcb_Micro.DrawMode = DrawMode.OwnerDrawVariable;
            mcb_Micro.DropDownHeight = 174;
            mcb_Micro.DropDownStyle = ComboBoxStyle.DropDownList;
            mcb_Micro.DropDownWidth = 121;
            mcb_Micro.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            mcb_Micro.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mcb_Micro.FormattingEnabled = true;
            mcb_Micro.IntegralHeight = false;
            mcb_Micro.ItemHeight = 43;
            mcb_Micro.Location = new Point(100, 0);
            mcb_Micro.Margin = new Padding(0);
            mcb_Micro.MaxDropDownItems = 4;
            mcb_Micro.MouseState = MaterialSkin.MouseState.OUT;
            mcb_Micro.Name = "mcb_Micro";
            mcb_Micro.Size = new Size(726, 49);
            mcb_Micro.StartIndex = 0;
            mcb_Micro.TabIndex = 1;
            mcb_Micro.DropDown += mcb_Micro_DropDown;
            mcb_Micro.SelectedIndexChanged += mcb_Micro_SelectedIndexChanged;
            mcb_Micro.DropDownClosed += mcb_Micro_DropDownClosed;
            // 
            // mlbl_Micro
            // 
            mlbl_Micro.Depth = 0;
            mlbl_Micro.Dock = DockStyle.Fill;
            mlbl_Micro.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            mlbl_Micro.Location = new Point(0, 0);
            mlbl_Micro.Margin = new Padding(0, 0, 15, 0);
            mlbl_Micro.MouseState = MaterialSkin.MouseState.HOVER;
            mlbl_Micro.Name = "mlbl_Micro";
            mlbl_Micro.Size = new Size(85, 49);
            mlbl_Micro.TabIndex = 0;
            mlbl_Micro.Text = "Microphone";
            mlbl_Micro.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mep_Server
            // 
            mep_Server.BackColor = Color.FromArgb(255, 255, 255);
            mep_Server.CancelButtonText = "CONNECT";
            mep_Server.Collapse = true;
            mep_Server.Controls.Add(mtb_ServerPort);
            mep_Server.Controls.Add(mtb_ServerIp);
            mep_Server.Depth = 0;
            mep_Server.Description = "";
            mep_Server.ExpandHeight = 250;
            mep_Server.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            mep_Server.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mep_Server.Location = new Point(16, 92);
            mep_Server.Margin = new Padding(16, 1, 16, 0);
            mep_Server.MouseState = MaterialSkin.MouseState.HOVER;
            mep_Server.Name = "mep_Server";
            mep_Server.Padding = new Padding(24, 64, 24, 16);
            mep_Server.Size = new Size(854, 48);
            mep_Server.TabIndex = 7;
            mep_Server.Title = "Server";
            mep_Server.ValidationButtonEnable = true;
            mep_Server.ValidationButtonText = "CANCEL";
            mep_Server.CancelClick += mep_Server_ConnectClick;
            mep_Server.PanelExpand += mep_Server_PanelExpand;
            // 
            // mtb_ServerPort
            // 
            mtb_ServerPort.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            mtb_ServerPort.AnimateReadOnly = false;
            mtb_ServerPort.BackgroundImageLayout = ImageLayout.None;
            mtb_ServerPort.CharacterCasing = CharacterCasing.Normal;
            mtb_ServerPort.Depth = 0;
            mtb_ServerPort.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtb_ServerPort.HideSelection = true;
            mtb_ServerPort.Hint = "Server Port";
            mtb_ServerPort.LeadingIcon = Properties.Resources.showPass;
            mtb_ServerPort.Location = new Point(26, 121);
            mtb_ServerPort.MaxLength = 32767;
            mtb_ServerPort.MouseState = MaterialSkin.MouseState.OUT;
            mtb_ServerPort.Name = "mtb_ServerPort";
            mtb_ServerPort.PasswordChar = '●';
            mtb_ServerPort.PrefixSuffixText = null;
            mtb_ServerPort.ReadOnly = false;
            mtb_ServerPort.RightToLeft = RightToLeft.No;
            mtb_ServerPort.SelectedText = "";
            mtb_ServerPort.SelectionLength = 0;
            mtb_ServerPort.SelectionStart = 0;
            mtb_ServerPort.ShortcutsEnabled = true;
            mtb_ServerPort.Size = new Size(810, 48);
            mtb_ServerPort.TabIndex = 3;
            mtb_ServerPort.TabStop = false;
            mtb_ServerPort.TextAlign = HorizontalAlignment.Left;
            mtb_ServerPort.TrailingIcon = null;
            mtb_ServerPort.UseSystemPasswordChar = false;
            mtb_ServerPort.LeadingIconClick += mtb_ServerPort_LeadingIconClick;
            // 
            // mtb_ServerIp
            // 
            mtb_ServerIp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            mtb_ServerIp.AnimateReadOnly = false;
            mtb_ServerIp.BackgroundImageLayout = ImageLayout.None;
            mtb_ServerIp.CharacterCasing = CharacterCasing.Normal;
            mtb_ServerIp.Depth = 0;
            mtb_ServerIp.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtb_ServerIp.HideSelection = true;
            mtb_ServerIp.Hint = "Server IP";
            mtb_ServerIp.LeadingIcon = Properties.Resources.showPass;
            mtb_ServerIp.Location = new Point(26, 55);
            mtb_ServerIp.MaxLength = 32767;
            mtb_ServerIp.MouseState = MaterialSkin.MouseState.OUT;
            mtb_ServerIp.Name = "mtb_ServerIp";
            mtb_ServerIp.PasswordChar = '●';
            mtb_ServerIp.PrefixSuffixText = null;
            mtb_ServerIp.ReadOnly = false;
            mtb_ServerIp.RightToLeft = RightToLeft.No;
            mtb_ServerIp.SelectedText = "";
            mtb_ServerIp.SelectionLength = 0;
            mtb_ServerIp.SelectionStart = 0;
            mtb_ServerIp.ShortcutsEnabled = true;
            mtb_ServerIp.Size = new Size(810, 48);
            mtb_ServerIp.TabIndex = 2;
            mtb_ServerIp.TabStop = false;
            mtb_ServerIp.TextAlign = HorizontalAlignment.Left;
            mtb_ServerIp.TrailingIcon = null;
            mtb_ServerIp.UseSystemPasswordChar = false;
            mtb_ServerIp.LeadingIconClick += mtb_ServerIp_LeadingIconClick;
            // 
            // mep_Source
            // 
            mep_Source.BackColor = Color.FromArgb(255, 255, 255);
            mep_Source.CancelButtonText = "CREATE";
            mep_Source.Collapse = true;
            mep_Source.Controls.Add(panel1);
            mep_Source.Controls.Add(panel2);
            mep_Source.Depth = 0;
            mep_Source.Description = "";
            mep_Source.Dock = DockStyle.Top;
            mep_Source.ExpandHeight = 250;
            mep_Source.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            mep_Source.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mep_Source.Location = new Point(16, 141);
            mep_Source.Margin = new Padding(16, 1, 16, 0);
            mep_Source.MouseState = MaterialSkin.MouseState.HOVER;
            mep_Source.Name = "mep_Source";
            mep_Source.Padding = new Padding(26, 55, 18, 16);
            mep_Source.Size = new Size(854, 48);
            mep_Source.TabIndex = 15;
            mep_Source.Title = "OBS Text Source";
            mep_Source.ValidationButtonEnable = true;
            mep_Source.ValidationButtonText = "CANCEL";
            mep_Source.CancelClick += mep_Source_CreateClick;
            mep_Source.PanelExpand += mep_Source_PanelExpand;
            // 
            // panel1
            // 
            panel1.Controls.Add(mtb_SceneName);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(26, 103);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 18, 0, 0);
            panel1.Size = new Size(810, 66);
            panel1.TabIndex = 16;
            // 
            // mtb_SceneName
            // 
            mtb_SceneName.AnimateReadOnly = false;
            mtb_SceneName.BackgroundImageLayout = ImageLayout.None;
            mtb_SceneName.CharacterCasing = CharacterCasing.Normal;
            mtb_SceneName.Depth = 0;
            mtb_SceneName.Dock = DockStyle.Fill;
            mtb_SceneName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtb_SceneName.HideSelection = true;
            mtb_SceneName.Hint = "Scene Name";
            mtb_SceneName.LeadingIcon = null;
            mtb_SceneName.Location = new Point(0, 18);
            mtb_SceneName.MaxLength = 32767;
            mtb_SceneName.MouseState = MaterialSkin.MouseState.OUT;
            mtb_SceneName.Name = "mtb_SceneName";
            mtb_SceneName.PasswordChar = '\0';
            mtb_SceneName.PrefixSuffixText = null;
            mtb_SceneName.ReadOnly = false;
            mtb_SceneName.RightToLeft = RightToLeft.No;
            mtb_SceneName.SelectedText = "";
            mtb_SceneName.SelectionLength = 0;
            mtb_SceneName.SelectionStart = 0;
            mtb_SceneName.ShortcutsEnabled = true;
            mtb_SceneName.Size = new Size(810, 48);
            mtb_SceneName.TabIndex = 5;
            mtb_SceneName.TabStop = false;
            mtb_SceneName.TextAlign = HorizontalAlignment.Left;
            mtb_SceneName.TrailingIcon = null;
            mtb_SceneName.UseSystemPasswordChar = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(mtb_SourceName);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(26, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(810, 48);
            panel2.TabIndex = 16;
            // 
            // mtb_SourceName
            // 
            mtb_SourceName.AnimateReadOnly = false;
            mtb_SourceName.BackgroundImageLayout = ImageLayout.None;
            mtb_SourceName.CharacterCasing = CharacterCasing.Normal;
            mtb_SourceName.Depth = 0;
            mtb_SourceName.Dock = DockStyle.Fill;
            mtb_SourceName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtb_SourceName.HideSelection = false;
            mtb_SourceName.Hint = "Source Name";
            mtb_SourceName.LeadingIcon = null;
            mtb_SourceName.Location = new Point(0, 0);
            mtb_SourceName.MaxLength = 32767;
            mtb_SourceName.MouseState = MaterialSkin.MouseState.OUT;
            mtb_SourceName.Name = "mtb_SourceName";
            mtb_SourceName.PasswordChar = '\0';
            mtb_SourceName.PrefixSuffixText = null;
            mtb_SourceName.ReadOnly = false;
            mtb_SourceName.RightToLeft = RightToLeft.No;
            mtb_SourceName.SelectedText = "";
            mtb_SourceName.SelectionLength = 0;
            mtb_SourceName.SelectionStart = 0;
            mtb_SourceName.ShortcutsEnabled = true;
            mtb_SourceName.Size = new Size(810, 48);
            mtb_SourceName.TabIndex = 4;
            mtb_SourceName.TabStop = false;
            mtb_SourceName.TextAlign = HorizontalAlignment.Left;
            mtb_SourceName.TrailingIcon = null;
            mtb_SourceName.UseSystemPasswordChar = false;
            // 
            // menuIconList
            // 
            menuIconList.ColorDepth = ColorDepth.Depth32Bit;
            menuIconList.ImageStream = (ImageListStreamer)resources.GetObject("menuIconList.ImageStream");
            menuIconList.TransparentColor = Color.Transparent;
            menuIconList.Images.SetKeyName(0, "wave-sound.png");
            menuIconList.Images.SetKeyName(1, "setting.png");
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 600);
            Controls.Add(materialTabControl1);
            DrawerAutoShow = true;
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTabControl1;
            FormStyle = FormStyles.ActionBar_None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(600, 400);
            Name = "Main";
            Padding = new Padding(0, 24, 0, 3);
            Text = "OBSTranslator";
            Load += Main_Load;
            materialTabControl1.ResumeLayout(false);
            pgRecognition.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            pnl_Start.ResumeLayout(false);
            pnl_Stop.ResumeLayout(false);
            pgSettings.ResumeLayout(false);
            flp_Settings.ResumeLayout(false);
            mc_Micro.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            mep_Server.ResumeLayout(false);
            mep_Server.PerformLayout();
            mep_Source.ResumeLayout(false);
            mep_Source.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage pgRecognition;
        private TabPage pgSettings;
        private ImageList menuIconList;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 tb_TranslatedText;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 tb_RecognizedText;
        private MaterialSkin.Controls.MaterialDrawer materialDrawer1;
        private MaterialSkin.Controls.MaterialButton btn_Stop;
        private MaterialSkin.Controls.MaterialButton btn_Start;
        private Panel pnl_Start;
        private Panel pnl_Stop;
        private FlowLayoutPanel flp_Settings;
        private MaterialSkin.Controls.MaterialCard mc_Micro;
        private MaterialSkin.Controls.MaterialComboBox mcb_Micro;
        private MaterialSkin.Controls.MaterialLabel mlbl_Micro;
        private MaterialSkin.Controls.MaterialExpansionPanel mep_Server;
        private MaterialSkin.Controls.MaterialExpansionPanel mep_Source;
        private MaterialSkin.Controls.MaterialTextBox2 mtb_ServerPort;
        private MaterialSkin.Controls.MaterialTextBox2 mtb_ServerIp;
        private MaterialSkin.Controls.MaterialTextBox2 mtb_SourceName;
        private MaterialSkin.Controls.MaterialTextBox2 mtb_SceneName;
        private Panel panel1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
    }
}