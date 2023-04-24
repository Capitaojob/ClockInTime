namespace newTest
{
    partial class RegisterEmployee
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
            LblName = new Label();
            TxtName = new TextBox();
            LblEmail = new Label();
            TxtEmail = new TextBox();
            TxtCPF = new TextBox();
            LblCPF = new Label();
            LblRole = new Label();
            TxtBirthday = new TextBox();
            LblBirthday = new Label();
            PnlLeft = new Panel();
            LblInvalid = new Label();
            LblGreet = new Label();
            LblTz = new Label();
            comboBoxRoles = new ComboBox();
            btnRegister = new Button();
            PnlLeft.SuspendLayout();
            SuspendLayout();
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Font = new Font("Neon 80s", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LblName.Location = new Point(512, 21);
            LblName.Name = "LblName";
            LblName.Size = new Size(72, 22);
            LblName.TabIndex = 10;
            LblName.Text = "Nome";
            // 
            // TxtName
            // 
            TxtName.BorderStyle = BorderStyle.FixedSingle;
            TxtName.Font = new Font("Neon 80s", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtName.Location = new Point(501, 46);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(383, 35);
            TxtName.TabIndex = 11;
            TxtName.Leave += TxtName_Leave;
            // 
            // LblEmail
            // 
            LblEmail.AutoSize = true;
            LblEmail.Font = new Font("Neon 80s", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LblEmail.Location = new Point(512, 93);
            LblEmail.Name = "LblEmail";
            LblEmail.Size = new Size(66, 22);
            LblEmail.TabIndex = 12;
            LblEmail.Text = "Email";
            // 
            // TxtEmail
            // 
            TxtEmail.BorderStyle = BorderStyle.FixedSingle;
            TxtEmail.Font = new Font("Neon 80s", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtEmail.Location = new Point(501, 118);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(383, 35);
            TxtEmail.TabIndex = 13;
            TxtEmail.Leave += TxtEmail_Leave;
            // 
            // TxtCPF
            // 
            TxtCPF.BorderStyle = BorderStyle.FixedSingle;
            TxtCPF.Font = new Font("Neon 80s", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtCPF.Location = new Point(501, 188);
            TxtCPF.Name = "TxtCPF";
            TxtCPF.Size = new Size(383, 35);
            TxtCPF.TabIndex = 15;
            TxtCPF.Leave += TxtCPF_Leave;
            // 
            // LblCPF
            // 
            LblCPF.AutoSize = true;
            LblCPF.Font = new Font("Neon 80s", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LblCPF.Location = new Point(512, 163);
            LblCPF.Name = "LblCPF";
            LblCPF.Size = new Size(50, 22);
            LblCPF.TabIndex = 14;
            LblCPF.Text = "CPF";
            // 
            // LblRole
            // 
            LblRole.AutoSize = true;
            LblRole.Font = new Font("Neon 80s", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LblRole.Location = new Point(512, 235);
            LblRole.Name = "LblRole";
            LblRole.Size = new Size(73, 22);
            LblRole.TabIndex = 16;
            LblRole.Text = "Cargo";
            // 
            // TxtBirthday
            // 
            TxtBirthday.BorderStyle = BorderStyle.FixedSingle;
            TxtBirthday.Font = new Font("Neon 80s", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtBirthday.Location = new Point(501, 335);
            TxtBirthday.Name = "TxtBirthday";
            TxtBirthday.Size = new Size(383, 35);
            TxtBirthday.TabIndex = 19;
            TxtBirthday.Leave += TxtBirthday_Leave;
            // 
            // LblBirthday
            // 
            LblBirthday.AutoSize = true;
            LblBirthday.Font = new Font("Neon 80s", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LblBirthday.Location = new Point(512, 310);
            LblBirthday.Name = "LblBirthday";
            LblBirthday.Size = new Size(220, 22);
            LblBirthday.TabIndex = 18;
            LblBirthday.Text = "Data de Nascimento";
            // 
            // PnlLeft
            // 
            PnlLeft.Controls.Add(LblInvalid);
            PnlLeft.Controls.Add(LblGreet);
            PnlLeft.Controls.Add(LblTz);
            PnlLeft.Location = new Point(0, 0);
            PnlLeft.Name = "PnlLeft";
            PnlLeft.Size = new Size(458, 482);
            PnlLeft.TabIndex = 20;
            // 
            // LblInvalid
            // 
            LblInvalid.AutoSize = true;
            LblInvalid.Font = new Font("Neon 80s", 20F, FontStyle.Regular, GraphicsUnit.Point);
            LblInvalid.Location = new Point(94, 244);
            LblInvalid.Name = "LblInvalid";
            LblInvalid.Size = new Size(265, 29);
            LblInvalid.TabIndex = 23;
            LblInvalid.Text = "Campo CPF Inválido";
            LblInvalid.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblGreet
            // 
            LblGreet.AutoSize = true;
            LblGreet.Font = new Font("Neon 80s", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LblGreet.Location = new Point(71, 108);
            LblGreet.Name = "LblGreet";
            LblGreet.Size = new Size(324, 75);
            LblGreet.TabIndex = 22;
            LblGreet.Text = "Novo funcionário?  \r\nCadastre-o no sistema e de \r\nas boas vindas!";
            LblGreet.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblTz
            // 
            LblTz.AutoSize = true;
            LblTz.Font = new Font("Neon 80s", 40F, FontStyle.Regular, GraphicsUnit.Point);
            LblTz.Location = new Point(75, 25);
            LblTz.Name = "LblTz";
            LblTz.Size = new Size(309, 56);
            LblTz.TabIndex = 21;
            LblTz.Text = "TzSoluções";
            // 
            // comboBoxRoles
            // 
            comboBoxRoles.Font = new Font("Neon 80s", 18F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxRoles.FormattingEnabled = true;
            comboBoxRoles.IntegralHeight = false;
            comboBoxRoles.ItemHeight = 25;
            comboBoxRoles.Location = new Point(501, 260);
            comboBoxRoles.Name = "comboBoxRoles";
            comboBoxRoles.Size = new Size(383, 33);
            comboBoxRoles.TabIndex = 25;
            comboBoxRoles.Leave += comboBoxRoles_Leave;
            // 
            // btnRegister
            // 
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Neon 80s", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegister.Location = new Point(611, 407);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(162, 46);
            btnRegister.TabIndex = 26;
            btnRegister.Text = "Registrar";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // RegisterEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnRegister);
            Controls.Add(comboBoxRoles);
            Controls.Add(PnlLeft);
            Controls.Add(TxtBirthday);
            Controls.Add(LblBirthday);
            Controls.Add(LblRole);
            Controls.Add(TxtCPF);
            Controls.Add(LblCPF);
            Controls.Add(TxtEmail);
            Controls.Add(LblEmail);
            Controls.Add(TxtName);
            Controls.Add(LblName);
            Name = "RegisterEmployee";
            Size = new Size(914, 482);
            Load += RegisterEmployee_Load;
            PnlLeft.ResumeLayout(false);
            PnlLeft.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblName;
        private TextBox TxtName;
        private Label LblEmail;
        private TextBox TxtEmail;
        private TextBox TxtCPF;
        private Label LblCPF;
        private Label LblRole;
        private TextBox TxtBirthday;
        private Label LblBirthday;
        private Panel PnlLeft;
        private Label LblTz;
        private Label LblGreet;
        private ComboBox comboBoxRoles;
        private Button btnRegister;
        private Label LblInvalid;
    }
}
