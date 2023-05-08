namespace newTest
{
    partial class loginForm
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
            MiddlePanel = new Panel();
            LblForgotPw = new LinkLabel();
            ImgPwEye = new PictureBox();
            TxtLoginWarning = new TextBox();
            loginLogo = new Label();
            loginBtn = new Button();
            pwInput = new TextBox();
            label1 = new Label();
            lbl_welcome = new Label();
            loginInput = new TextBox();
            MiddlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ImgPwEye).BeginInit();
            SuspendLayout();
            // 
            // MiddlePanel
            // 
            MiddlePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MiddlePanel.BackColor = Color.FromArgb(219, 231, 245);
            MiddlePanel.BackgroundImageLayout = ImageLayout.None;
            MiddlePanel.Controls.Add(LblForgotPw);
            MiddlePanel.Controls.Add(ImgPwEye);
            MiddlePanel.Controls.Add(TxtLoginWarning);
            MiddlePanel.Controls.Add(loginLogo);
            MiddlePanel.Controls.Add(loginBtn);
            MiddlePanel.Controls.Add(pwInput);
            MiddlePanel.Controls.Add(label1);
            MiddlePanel.Controls.Add(lbl_welcome);
            MiddlePanel.Controls.Add(loginInput);
            MiddlePanel.Location = new Point(60, 60);
            MiddlePanel.Name = "MiddlePanel";
            MiddlePanel.Size = new Size(1099, 522);
            MiddlePanel.TabIndex = 0;
            // 
            // LblForgotPw
            // 
            LblForgotPw.ActiveLinkColor = SystemColors.HotTrack;
            LblForgotPw.AutoSize = true;
            LblForgotPw.Cursor = Cursors.Hand;
            LblForgotPw.Font = new Font("Neon 80s", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblForgotPw.LinkColor = SystemColors.ControlDarkDark;
            LblForgotPw.Location = new Point(434, 456);
            LblForgotPw.Name = "LblForgotPw";
            LblForgotPw.Size = new Size(247, 16);
            LblForgotPw.TabIndex = 8;
            LblForgotPw.TabStop = true;
            LblForgotPw.Text = "Esqueceu sua senha? Redefina-a";
            LblForgotPw.TextAlign = ContentAlignment.MiddleCenter;
            LblForgotPw.VisitedLinkColor = SystemColors.ControlDarkDark;
            LblForgotPw.LinkClicked += LblForgotPw_LinkClicked;
            // 
            // ImgPwEye
            // 
            ImgPwEye.BackColor = Color.Transparent;
            ImgPwEye.BackgroundImage = Properties.Resources.view;
            ImgPwEye.BackgroundImageLayout = ImageLayout.Stretch;
            ImgPwEye.Cursor = Cursors.Hand;
            ImgPwEye.Image = Properties.Resources.view;
            ImgPwEye.Location = new Point(709, 328);
            ImgPwEye.Name = "ImgPwEye";
            ImgPwEye.Size = new Size(37, 35);
            ImgPwEye.TabIndex = 0;
            ImgPwEye.TabStop = false;
            ImgPwEye.Click += ImgPwEye_Click;
            // 
            // TxtLoginWarning
            // 
            TxtLoginWarning.BorderStyle = BorderStyle.None;
            TxtLoginWarning.Enabled = false;
            TxtLoginWarning.Font = new Font("Neon 80s", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TxtLoginWarning.ForeColor = Color.Red;
            TxtLoginWarning.Location = new Point(359, 485);
            TxtLoginWarning.Name = "TxtLoginWarning";
            TxtLoginWarning.Size = new Size(390, 22);
            TxtLoginWarning.TabIndex = 6;
            TxtLoginWarning.TextAlign = HorizontalAlignment.Center;
            // 
            // loginLogo
            // 
            loginLogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            loginLogo.AutoSize = true;
            loginLogo.Font = new Font("Neon 80s", 35.25F, FontStyle.Bold, GraphicsUnit.Point);
            loginLogo.ForeColor = Color.FromArgb(211, 179, 122);
            loginLogo.Location = new Point(45, 45);
            loginLogo.Name = "loginLogo";
            loginLogo.Size = new Size(280, 49);
            loginLogo.TabIndex = 5;
            loginLogo.Text = "TzSoluções";
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.FromArgb(211, 179, 122);
            loginBtn.BackgroundImageLayout = ImageLayout.None;
            loginBtn.Cursor = Cursors.Hand;
            loginBtn.FlatAppearance.BorderSize = 0;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Neon 80s", 23F, FontStyle.Regular, GraphicsUnit.Point);
            loginBtn.ForeColor = Color.FromArgb(248, 250, 255);
            loginBtn.Location = new Point(359, 389);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(390, 60);
            loginBtn.TabIndex = 4;
            loginBtn.Text = "ENTRAR";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // pwInput
            // 
            pwInput.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pwInput.BorderStyle = BorderStyle.None;
            pwInput.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            pwInput.Location = new Point(359, 315);
            pwInput.MaximumSize = new Size(400, 60);
            pwInput.MinimumSize = new Size(197, 36);
            pwInput.Name = "pwInput";
            pwInput.PasswordChar = '*';
            pwInput.Size = new Size(390, 36);
            pwInput.TabIndex = 3;
            pwInput.KeyDown += pwInput_KeyDown;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Neon 80s", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(43, 59, 85);
            label1.Location = new Point(359, 203);
            label1.Name = "label1";
            label1.Size = new Size(291, 25);
            label1.TabIndex = 2;
            label1.Text = "Faça login em sua conta:";
            // 
            // lbl_welcome
            // 
            lbl_welcome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_welcome.AutoSize = true;
            lbl_welcome.Font = new Font("Neon 80s", 35F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_welcome.ForeColor = Color.FromArgb(43, 59, 85);
            lbl_welcome.Location = new Point(424, 154);
            lbl_welcome.Name = "lbl_welcome";
            lbl_welcome.Size = new Size(257, 49);
            lbl_welcome.TabIndex = 1;
            lbl_welcome.Text = "Bem-vindo";
            // 
            // loginInput
            // 
            loginInput.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            loginInput.BorderStyle = BorderStyle.None;
            loginInput.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            loginInput.Location = new Point(359, 241);
            loginInput.MaximumSize = new Size(400, 60);
            loginInput.MaxLength = 50;
            loginInput.MinimumSize = new Size(197, 36);
            loginInput.Name = "loginInput";
            loginInput.Size = new Size(390, 36);
            loginInput.TabIndex = 0;
            loginInput.WordWrap = false;
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 59, 85);
            ClientSize = new Size(1219, 642);
            Controls.Add(MiddlePanel);
            Name = "loginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClockInTime - Login";
            Load += loginForm_Load;
            MiddlePanel.ResumeLayout(false);
            MiddlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ImgPwEye).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel MiddlePanel;
        private TextBox loginInput;
        private Label lbl_welcome;
        private Label label1;
        private TextBox pwInput;
        private Button loginBtn;
        private Label loginLogo;
        private TextBox TxtLoginWarning;
        private PictureBox ImgPwEye;
        private LinkLabel LblForgotPw;
    }
}