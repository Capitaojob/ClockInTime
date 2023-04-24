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
            LblName = new Label();
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
            ((System.ComponentModel.ISupportInitialize)ImgPwEye).BeginInit();
            SuspendLayout();
            // 
            // ImgPwEye
            // 
            ImgPwEye.BackColor = Color.Transparent;
            ImgPwEye.BackgroundImage = Properties.Resources.view;
            ImgPwEye.BackgroundImageLayout = ImageLayout.Stretch;
            ImgPwEye.Cursor = Cursors.Hand;
            ImgPwEye.Image = Properties.Resources.view;
            ImgPwEye.Location = new Point(532, 208);
            ImgPwEye.Name = "ImgPwEye";
            ImgPwEye.Size = new Size(38, 39);
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
            BtnUpdatePw.Font = new Font("Neon 80s", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BtnUpdatePw.ForeColor = SystemColors.Control;
            BtnUpdatePw.Location = new Point(575, 213);
            BtnUpdatePw.Name = "BtnUpdatePw";
            BtnUpdatePw.Size = new Size(127, 28);
            BtnUpdatePw.TabIndex = 23;
            BtnUpdatePw.Text = "Atualizar Senha";
            BtnUpdatePw.UseVisualStyleBackColor = false;
            BtnUpdatePw.Click += BtnUpdatePw_Click;
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Font = new Font("Neon 80s", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LblName.Location = new Point(51, 24);
            LblName.Name = "LblName";
            LblName.Size = new Size(72, 22);
            LblName.TabIndex = 22;
            LblName.Text = "Nome";
            // 
            // TxtRole
            // 
            TxtRole.BackColor = SystemColors.Control;
            TxtRole.BorderStyle = BorderStyle.None;
            TxtRole.Enabled = false;
            TxtRole.Font = new Font("Neon 80s", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtRole.Location = new Point(39, 408);
            TxtRole.MaxLength = 200;
            TxtRole.Name = "TxtRole";
            TxtRole.ReadOnly = true;
            TxtRole.Size = new Size(663, 28);
            TxtRole.TabIndex = 21;
            TxtRole.Text = "Desenvolvedor";
            // 
            // LblRole
            // 
            LblRole.AutoSize = true;
            LblRole.Font = new Font("Neon 80s", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LblRole.Location = new Point(51, 383);
            LblRole.Name = "LblRole";
            LblRole.Size = new Size(73, 22);
            LblRole.TabIndex = 20;
            LblRole.Text = "Cargo";
            // 
            // TxtCpf
            // 
            TxtCpf.BackColor = SystemColors.Control;
            TxtCpf.BorderStyle = BorderStyle.None;
            TxtCpf.Enabled = false;
            TxtCpf.Font = new Font("Neon 80s", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtCpf.Location = new Point(39, 310);
            TxtCpf.MaxLength = 200;
            TxtCpf.Name = "TxtCpf";
            TxtCpf.ReadOnly = true;
            TxtCpf.Size = new Size(663, 28);
            TxtCpf.TabIndex = 19;
            TxtCpf.Text = "111.222.333-45";
            // 
            // LblCpf
            // 
            LblCpf.AutoSize = true;
            LblCpf.Font = new Font("Neon 80s", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LblCpf.Location = new Point(51, 285);
            LblCpf.Name = "LblCpf";
            LblCpf.Size = new Size(50, 22);
            LblCpf.TabIndex = 18;
            LblCpf.Text = "CPF";
            // 
            // TxtPw
            // 
            TxtPw.BackColor = SystemColors.Control;
            TxtPw.BorderStyle = BorderStyle.None;
            TxtPw.Font = new Font("Neon 80s", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtPw.Location = new Point(39, 213);
            TxtPw.MaxLength = 200;
            TxtPw.Name = "TxtPw";
            TxtPw.PasswordChar = '*';
            TxtPw.Size = new Size(663, 28);
            TxtPw.TabIndex = 17;
            // 
            // LblPw
            // 
            LblPw.AutoSize = true;
            LblPw.Font = new Font("Neon 80s", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LblPw.Location = new Point(51, 188);
            LblPw.Name = "LblPw";
            LblPw.Size = new Size(74, 22);
            LblPw.TabIndex = 16;
            LblPw.Text = "Senha";
            // 
            // TxtEmail
            // 
            TxtEmail.BackColor = SystemColors.Control;
            TxtEmail.BorderStyle = BorderStyle.None;
            TxtEmail.Enabled = false;
            TxtEmail.Font = new Font("Neon 80s", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtEmail.Location = new Point(39, 125);
            TxtEmail.MaxLength = 200;
            TxtEmail.Name = "TxtEmail";
            TxtEmail.ReadOnly = true;
            TxtEmail.Size = new Size(663, 28);
            TxtEmail.TabIndex = 15;
            TxtEmail.Text = "thomas@gmail.com";
            // 
            // LblEmail
            // 
            LblEmail.AutoSize = true;
            LblEmail.Font = new Font("Neon 80s", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LblEmail.Location = new Point(51, 100);
            LblEmail.Name = "LblEmail";
            LblEmail.Size = new Size(75, 22);
            LblEmail.TabIndex = 14;
            LblEmail.Text = "E-mail";
            // 
            // LblUserName
            // 
            LblUserName.AutoSize = true;
            LblUserName.Font = new Font("Neon 80s", 25F, FontStyle.Regular, GraphicsUnit.Point);
            LblUserName.Location = new Point(39, 46);
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
            LblPwWarning.Location = new Point(51, 244);
            LblPwWarning.Name = "LblPwWarning";
            LblPwWarning.Size = new Size(0, 20);
            LblPwWarning.TabIndex = 25;
            // 
            // UserData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LblPwWarning);
            Controls.Add(ImgPwEye);
            Controls.Add(BtnUpdatePw);
            Controls.Add(LblName);
            Controls.Add(TxtRole);
            Controls.Add(LblRole);
            Controls.Add(TxtCpf);
            Controls.Add(LblCpf);
            Controls.Add(TxtPw);
            Controls.Add(LblPw);
            Controls.Add(TxtEmail);
            Controls.Add(LblEmail);
            Controls.Add(LblUserName);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserData";
            Size = new Size(914, 482);
            Load += UserData_Load;
            ((System.ComponentModel.ISupportInitialize)ImgPwEye).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ImgPwEye;
        private Button BtnUpdatePw;
        private Label LblName;
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
    }
}
