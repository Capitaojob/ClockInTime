namespace newTest
{
    partial class UserData
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ImgPwEye = new PictureBox();
            BtnUpdatePw = new Button();
            LblWelcome = new Label();
            TxtRole = new TextBox();
            LblRole = new Label();
            TxtCpf = new TextBox();
            LblCpf = new Label();
            TxtPw = new TextBox();
            LblPw = new Label();
            TxtEmail = new TextBox();
            LblEmail = new Label();
            LblUserName = new Label();
            LblPwWarning = new Label();
            PnlLeft = new Panel();
            BtnChangeAc = new Button();
            BtnQuit = new Button();
            LblIntro = new Label();
            ((System.ComponentModel.ISupportInitialize)ImgPwEye).BeginInit();
            PnlLeft.SuspendLayout();
            SuspendLayout();
            // 
            // ImgPwEye
            // 
            ImgPwEye.BackColor = Color.Transparent;
            ImgPwEye.BackgroundImage = Properties.Resources.view;
            ImgPwEye.BackgroundImageLayout = ImageLayout.Stretch;
            ImgPwEye.Cursor = Cursors.Hand;
            ImgPwEye.Image = Properties.Resources.view;
            ImgPwEye.Location = new Point(718, 213);
            ImgPwEye.Name = "ImgPwEye";
            ImgPwEye.Size = new Size(34, 35);
            ImgPwEye.TabIndex = 24;
            ImgPwEye.TabStop = false;
            ImgPwEye.Click += ImgPwEye_Click;
            // 
            // BtnUpdatePw
            // 
            BtnUpdatePw.BackColor = SystemColors.ControlDarkDark;
            BtnUpdatePw.BackgroundImageLayout = ImageLayout.None;
            BtnUpdatePw.Cursor = Cursors.Hand;
            BtnUpdatePw.FlatStyle = FlatStyle.Flat;
            BtnUpdatePw.Font = new Font("Neon 80s", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnUpdatePw.ForeColor = SystemColors.ControlText;
            BtnUpdatePw.Location = new Point(758, 215);
            BtnUpdatePw.Name = "BtnUpdatePw";
            BtnUpdatePw.Size = new Size(139, 33);
            BtnUpdatePw.TabIndex = 23;
            BtnUpdatePw.Text = "Atualizar Senha";
            BtnUpdatePw.UseVisualStyleBackColor = false;
            BtnUpdatePw.Click += BtnUpdatePw_Click;
            // 
            // LblWelcome
            // 
            LblWelcome.AutoSize = true;
            LblWelcome.Font = new Font("Neon 80s", 30F, FontStyle.Regular, GraphicsUnit.Point);
            LblWelcome.Location = new Point(41, 42);
            LblWelcome.Name = "LblWelcome";
            LblWelcome.Size = new Size(231, 42);
            LblWelcome.TabIndex = 22;
            LblWelcome.Text = "Bem-Vindo,";
            // 
            // TxtRole
            // 
            TxtRole.BackColor = SystemColors.ControlDark;
            TxtRole.BorderStyle = BorderStyle.None;
            TxtRole.Enabled = false;
            TxtRole.Font = new Font("Neon 80s", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtRole.Location = new Point(324, 411);
            TxtRole.MaxLength = 200;
            TxtRole.Name = "TxtRole";
            TxtRole.ReadOnly = true;
            TxtRole.Size = new Size(388, 28);
            TxtRole.TabIndex = 21;
            TxtRole.Text = "Desenvolvedor";
            // 
            // LblRole
            // 
            LblRole.AutoSize = true;
            LblRole.Font = new Font("Neon 80s", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LblRole.Location = new Point(336, 386);
            LblRole.Name = "LblRole";
            LblRole.Size = new Size(73, 22);
            LblRole.TabIndex = 20;
            LblRole.Text = "Cargo";
            // 
            // TxtCpf
            // 
            TxtCpf.BackColor = SystemColors.ControlDark;
            TxtCpf.BorderStyle = BorderStyle.None;
            TxtCpf.Enabled = false;
            TxtCpf.Font = new Font("Neon 80s", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtCpf.Location = new Point(324, 313);
            TxtCpf.MaxLength = 200;
            TxtCpf.Name = "TxtCpf";
            TxtCpf.ReadOnly = true;
            TxtCpf.Size = new Size(388, 28);
            TxtCpf.TabIndex = 19;
            TxtCpf.Text = "111.222.333-45";
            // 
            // LblCpf
            // 
            LblCpf.AutoSize = true;
            LblCpf.Font = new Font("Neon 80s", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LblCpf.Location = new Point(336, 288);
            LblCpf.Name = "LblCpf";
            LblCpf.Size = new Size(50, 22);
            LblCpf.TabIndex = 18;
            LblCpf.Text = "CPF";
            // 
            // TxtPw
            // 
            TxtPw.BackColor = SystemColors.ControlDark;
            TxtPw.BorderStyle = BorderStyle.None;
            TxtPw.Font = new Font("Neon 80s", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtPw.Location = new Point(324, 216);
            TxtPw.MaxLength = 200;
            TxtPw.Name = "TxtPw";
            TxtPw.PasswordChar = '*';
            TxtPw.Size = new Size(388, 28);
            TxtPw.TabIndex = 17;
            // 
            // LblPw
            // 
            LblPw.AutoSize = true;
            LblPw.Font = new Font("Neon 80s", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LblPw.Location = new Point(336, 191);
            LblPw.Name = "LblPw";
            LblPw.Size = new Size(74, 22);
            LblPw.TabIndex = 16;
            LblPw.Text = "Senha";
            // 
            // TxtEmail
            // 
            TxtEmail.BackColor = SystemColors.ControlDark;
            TxtEmail.BorderStyle = BorderStyle.None;
            TxtEmail.Enabled = false;
            TxtEmail.Font = new Font("Neon 80s", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtEmail.Location = new Point(324, 128);
            TxtEmail.MaxLength = 200;
            TxtEmail.Name = "TxtEmail";
            TxtEmail.ReadOnly = true;
            TxtEmail.Size = new Size(388, 28);
            TxtEmail.TabIndex = 15;
            TxtEmail.Text = "thomas@gmail.com";
            // 
            // LblEmail
            // 
            LblEmail.AutoSize = true;
            LblEmail.Font = new Font("Neon 80s", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LblEmail.Location = new Point(336, 103);
            LblEmail.Name = "LblEmail";
            LblEmail.Size = new Size(75, 22);
            LblEmail.TabIndex = 14;
            LblEmail.Text = "E-mail";
            // 
            // LblUserName
            // 
            LblUserName.AutoSize = true;
            LblUserName.BackColor = SystemColors.Control;
            LblUserName.Font = new Font("Neon 80s", 25F, FontStyle.Regular, GraphicsUnit.Point);
            LblUserName.Location = new Point(324, 49);
            LblUserName.Name = "LblUserName";
            LblUserName.Size = new Size(388, 35);
            LblUserName.TabIndex = 13;
            LblUserName.Text = "Thomas Alberto Araujo";
            // 
            // LblPwWarning
            // 
            LblPwWarning.AutoSize = true;
            LblPwWarning.Enabled = false;
            LblPwWarning.Font = new Font("Neon 80s", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LblPwWarning.ForeColor = SystemColors.ControlText;
            LblPwWarning.Location = new Point(359, 247);
            LblPwWarning.Name = "LblPwWarning";
            LblPwWarning.Size = new Size(0, 20);
            LblPwWarning.TabIndex = 25;
            // 
            // PnlLeft
            // 
            PnlLeft.Controls.Add(BtnChangeAc);
            PnlLeft.Controls.Add(BtnQuit);
            PnlLeft.Controls.Add(LblIntro);
            PnlLeft.Controls.Add(LblWelcome);
            PnlLeft.Location = new Point(0, 0);
            PnlLeft.Name = "PnlLeft";
            PnlLeft.Size = new Size(300, 482);
            PnlLeft.TabIndex = 26;
            // 
            // BtnChangeAc
            // 
            BtnChangeAc.Cursor = Cursors.Hand;
            BtnChangeAc.FlatStyle = FlatStyle.Flat;
            BtnChangeAc.Font = new Font("Neon 80s", 15F, FontStyle.Regular, GraphicsUnit.Point);
            BtnChangeAc.Location = new Point(26, 337);
            BtnChangeAc.Name = "BtnChangeAc";
            BtnChangeAc.Size = new Size(246, 38);
            BtnChangeAc.TabIndex = 28;
            BtnChangeAc.Text = "Trocar Conta";
            BtnChangeAc.UseVisualStyleBackColor = true;
            BtnChangeAc.Click += BtnChangeAc_Click;
            // 
            // BtnQuit
            // 
            BtnQuit.Cursor = Cursors.Hand;
            BtnQuit.FlatStyle = FlatStyle.Flat;
            BtnQuit.Font = new Font("Neon 80s", 15F, FontStyle.Regular, GraphicsUnit.Point);
            BtnQuit.Location = new Point(26, 405);
            BtnQuit.Name = "BtnQuit";
            BtnQuit.Size = new Size(246, 38);
            BtnQuit.TabIndex = 27;
            BtnQuit.Text = "Sair";
            BtnQuit.UseVisualStyleBackColor = true;
            BtnQuit.Click += BtnQuit_Click;
            // 
            // LblIntro
            // 
            LblIntro.AutoSize = true;
            LblIntro.Font = new Font("Neon 80s", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LblIntro.Location = new Point(32, 103);
            LblIntro.MaximumSize = new Size(250, 0);
            LblIntro.Name = "LblIntro";
            LblIntro.Size = new Size(250, 126);
            LblIntro.TabIndex = 23;
            LblIntro.Text = "Aqui você pode navegar pelo sistema, verificar seus dados, gerenciar pontos e retirar o demonstrativo de pagamento!\r\n";
            LblIntro.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UserData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PnlLeft);
            Controls.Add(LblUserName);
            Controls.Add(LblPwWarning);
            Controls.Add(ImgPwEye);
            Controls.Add(BtnUpdatePw);
            Controls.Add(TxtRole);
            Controls.Add(LblRole);
            Controls.Add(TxtCpf);
            Controls.Add(LblCpf);
            Controls.Add(TxtPw);
            Controls.Add(LblPw);
            Controls.Add(TxtEmail);
            Controls.Add(LblEmail);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserData";
            Size = new Size(914, 482);
            Load += UserData_Load;
            ((System.ComponentModel.ISupportInitialize)ImgPwEye).EndInit();
            PnlLeft.ResumeLayout(false);
            PnlLeft.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ImgPwEye;
        private Button BtnUpdatePw;
        private Label LblWelcome;
        private TextBox TxtRole;
        private Label LblRole;
        private TextBox TxtCpf;
        private Label LblCpf;
        private TextBox TxtPw;
        private Label LblPw;
        private TextBox TxtEmail;
        private Label LblEmail;
        private Label LblUserName;
        private Label LblPwWarning;
        private Panel PnlLeft;
        private Label LblIntro;
        private Button BtnChangeAc;
        private Button BtnQuit;
    }
}
