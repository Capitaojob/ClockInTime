namespace newTest
{
    partial class UserInfo
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            LblUserName = new Label();
            LblEmail = new Label();
            TxtEmail = new TextBox();
            TxtPw = new TextBox();
            LblPw = new Label();
            TxtCpf = new TextBox();
            LblCpf = new Label();
            TxtRole = new TextBox();
            LblRole = new Label();
            LblName = new Label();
            BtnUpdatePw = new Button();
            LblPwWarning = new Label();
            ImgPwEye = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ImgPwEye).BeginInit();
            SuspendLayout();
            // 
            // LblUserName
            // 
            LblUserName.AutoSize = true;
            LblUserName.Font = new Font("Neon 80s", 25F, FontStyle.Regular, GraphicsUnit.Point);
            LblUserName.Location = new Point(46, 48);
            LblUserName.Name = "LblUserName";
            LblUserName.Size = new Size(388, 35);
            LblUserName.TabIndex = 0;
            LblUserName.Text = "Thomas Alberto Araujo";
            // 
            // LblEmail
            // 
            LblEmail.AutoSize = true;
            LblEmail.Font = new Font("Neon 80s", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LblEmail.Location = new Point(58, 102);
            LblEmail.Name = "LblEmail";
            LblEmail.Size = new Size(75, 22);
            LblEmail.TabIndex = 1;
            LblEmail.Text = "E-mail";
            // 
            // TxtEmail
            // 
            TxtEmail.BackColor = SystemColors.Control;
            TxtEmail.BorderStyle = BorderStyle.None;
            TxtEmail.Enabled = false;
            TxtEmail.Font = new Font("Neon 80s", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtEmail.Location = new Point(46, 127);
            TxtEmail.MaxLength = 200;
            TxtEmail.Name = "TxtEmail";
            TxtEmail.ReadOnly = true;
            TxtEmail.Size = new Size(663, 28);
            TxtEmail.TabIndex = 2;
            TxtEmail.Text = "thomas@gmail.com";
            // 
            // TxtPw
            // 
            TxtPw.BackColor = SystemColors.Control;
            TxtPw.BorderStyle = BorderStyle.None;
            TxtPw.Font = new Font("Neon 80s", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtPw.Location = new Point(46, 215);
            TxtPw.MaxLength = 200;
            TxtPw.Name = "TxtPw";
            TxtPw.PasswordChar = '*';
            TxtPw.Size = new Size(663, 28);
            TxtPw.TabIndex = 4;
            TxtPw.Text = "senha";
            // 
            // LblPw
            // 
            LblPw.AutoSize = true;
            LblPw.Font = new Font("Neon 80s", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LblPw.Location = new Point(58, 190);
            LblPw.Name = "LblPw";
            LblPw.Size = new Size(74, 22);
            LblPw.TabIndex = 3;
            LblPw.Text = "Senha";
            // 
            // TxtCpf
            // 
            TxtCpf.BackColor = SystemColors.Control;
            TxtCpf.BorderStyle = BorderStyle.None;
            TxtCpf.Enabled = false;
            TxtCpf.Font = new Font("Neon 80s", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtCpf.Location = new Point(46, 312);
            TxtCpf.MaxLength = 200;
            TxtCpf.Name = "TxtCpf";
            TxtCpf.ReadOnly = true;
            TxtCpf.Size = new Size(663, 28);
            TxtCpf.TabIndex = 6;
            TxtCpf.Text = "111.222.333-45";
            // 
            // LblCpf
            // 
            LblCpf.AutoSize = true;
            LblCpf.Font = new Font("Neon 80s", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LblCpf.Location = new Point(58, 287);
            LblCpf.Name = "LblCpf";
            LblCpf.Size = new Size(50, 22);
            LblCpf.TabIndex = 5;
            LblCpf.Text = "CPF";
            // 
            // TxtRole
            // 
            TxtRole.BackColor = SystemColors.Control;
            TxtRole.BorderStyle = BorderStyle.None;
            TxtRole.Enabled = false;
            TxtRole.Font = new Font("Neon 80s", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtRole.Location = new Point(46, 410);
            TxtRole.MaxLength = 200;
            TxtRole.Name = "TxtRole";
            TxtRole.ReadOnly = true;
            TxtRole.Size = new Size(663, 28);
            TxtRole.TabIndex = 8;
            TxtRole.Text = "Desenvolvedor";
            // 
            // LblRole
            // 
            LblRole.AutoSize = true;
            LblRole.Font = new Font("Neon 80s", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LblRole.Location = new Point(58, 385);
            LblRole.Name = "LblRole";
            LblRole.Size = new Size(73, 22);
            LblRole.TabIndex = 7;
            LblRole.Text = "Cargo";
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Font = new Font("Neon 80s", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LblName.Location = new Point(58, 26);
            LblName.Name = "LblName";
            LblName.Size = new Size(72, 22);
            LblName.TabIndex = 9;
            LblName.Text = "Nome";
            // 
            // BtnUpdatePw
            // 
            BtnUpdatePw.BackColor = SystemColors.ControlDarkDark;
            BtnUpdatePw.BackgroundImageLayout = ImageLayout.None;
            BtnUpdatePw.Cursor = Cursors.Hand;
            BtnUpdatePw.FlatStyle = FlatStyle.Flat;
            BtnUpdatePw.Font = new Font("Neon 80s", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BtnUpdatePw.ForeColor = SystemColors.Control;
            BtnUpdatePw.Location = new Point(582, 215);
            BtnUpdatePw.Name = "BtnUpdatePw";
            BtnUpdatePw.Size = new Size(127, 28);
            BtnUpdatePw.TabIndex = 10;
            BtnUpdatePw.Text = "Atualizar Senha";
            BtnUpdatePw.UseVisualStyleBackColor = false;
            BtnUpdatePw.Click += BtnUpdatePw_Click;
            // 
            // LblPwWarning
            // 
            LblPwWarning.AutoSize = true;
            LblPwWarning.Enabled = false;
            LblPwWarning.Font = new Font("Neon 80s", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LblPwWarning.ForeColor = SystemColors.ControlText;
            LblPwWarning.Location = new Point(60, 246);
            LblPwWarning.Name = "LblPwWarning";
            LblPwWarning.Size = new Size(0, 20);
            LblPwWarning.TabIndex = 11;
            // 
            // ImgPwEye
            // 
            ImgPwEye.BackColor = Color.Transparent;
            ImgPwEye.BackgroundImage = Properties.Resources.view;
            ImgPwEye.BackgroundImageLayout = ImageLayout.Stretch;
            ImgPwEye.Cursor = Cursors.Hand;
            ImgPwEye.Image = Properties.Resources.view;
            ImgPwEye.Location = new Point(539, 210);
            ImgPwEye.Name = "ImgPwEye";
            ImgPwEye.Size = new Size(38, 39);
            ImgPwEye.TabIndex = 12;
            ImgPwEye.TabStop = false;
            ImgPwEye.Click += ImgPwEye_Click;
            // 
            // UserInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(ImgPwEye);
            Controls.Add(LblPwWarning);
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
            Name = "UserInfo";
            Size = new Size(914, 482);
            Load += UserInfo_Load;
            ((System.ComponentModel.ISupportInitialize)ImgPwEye).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblUserName;
        private Label LblEmail;
        private TextBox TxtEmail;
        private TextBox TxtPw;
        private Label LblPw;
        private TextBox TxtCpf;
        private Label LblCpf;
        private TextBox TxtRole;
        private Label LblRole;
        private Label LblName;
        private Button BtnUpdatePw;
        private Label LblPwWarning;
        private PictureBox ImgPwEye;
    }
}
