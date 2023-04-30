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
            LblGreet = new Label();
            LblTz = new Label();
            LblInvalid = new Label();
            comboBoxRoles = new ComboBox();
            btnRegister = new Button();
            TxtPhone = new TextBox();
            LblNumber = new Label();
            TxtCEP = new TextBox();
            LblCEP = new Label();
            TxtNumber = new TextBox();
            LblStreetNumber = new Label();
            TxtAddSuplement = new TextBox();
            LblAddSuplement = new Label();
            PnlLeft.SuspendLayout();
            SuspendLayout();
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Font = new Font("Neon 80s", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LblName.Location = new Point(331, 21);
            LblName.Name = "LblName";
            LblName.Size = new Size(72, 22);
            LblName.TabIndex = 10;
            LblName.Text = "Nome";
            // 
            // TxtName
            // 
            TxtName.BorderStyle = BorderStyle.FixedSingle;
            TxtName.Font = new Font("Neon 80s", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtName.Location = new Point(331, 46);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(553, 35);
            TxtName.TabIndex = 11;
            TxtName.Leave += TxtName_Leave;
            // 
            // LblEmail
            // 
            LblEmail.AutoSize = true;
            LblEmail.Font = new Font("Neon 80s", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LblEmail.Location = new Point(331, 93);
            LblEmail.Name = "LblEmail";
            LblEmail.Size = new Size(66, 22);
            LblEmail.TabIndex = 12;
            LblEmail.Text = "Email";
            // 
            // TxtEmail
            // 
            TxtEmail.BorderStyle = BorderStyle.FixedSingle;
            TxtEmail.Font = new Font("Neon 80s", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtEmail.Location = new Point(331, 118);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(553, 35);
            TxtEmail.TabIndex = 12;
            TxtEmail.Leave += TxtEmail_Leave;
            // 
            // TxtCPF
            // 
            TxtCPF.BorderStyle = BorderStyle.FixedSingle;
            TxtCPF.Font = new Font("Neon 80s", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtCPF.Location = new Point(331, 188);
            TxtCPF.Name = "TxtCPF";
            TxtCPF.Size = new Size(241, 35);
            TxtCPF.TabIndex = 13;
            TxtCPF.Leave += TxtCPF_Leave;
            // 
            // LblCPF
            // 
            LblCPF.AutoSize = true;
            LblCPF.Font = new Font("Neon 80s", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LblCPF.Location = new Point(331, 163);
            LblCPF.Name = "LblCPF";
            LblCPF.Size = new Size(50, 22);
            LblCPF.TabIndex = 14;
            LblCPF.Text = "CPF";
            // 
            // LblRole
            // 
            LblRole.AutoSize = true;
            LblRole.Font = new Font("Neon 80s", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LblRole.Location = new Point(643, 163);
            LblRole.Name = "LblRole";
            LblRole.Size = new Size(73, 22);
            LblRole.TabIndex = 16;
            LblRole.Text = "Cargo";
            // 
            // TxtBirthday
            // 
            TxtBirthday.BorderStyle = BorderStyle.FixedSingle;
            TxtBirthday.Font = new Font("Neon 80s", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtBirthday.Location = new Point(331, 261);
            TxtBirthday.Name = "TxtBirthday";
            TxtBirthday.Size = new Size(241, 35);
            TxtBirthday.TabIndex = 15;
            TxtBirthday.Leave += TxtBirthday_Leave;
            // 
            // LblBirthday
            // 
            LblBirthday.AutoSize = true;
            LblBirthday.Font = new Font("Neon 80s", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LblBirthday.Location = new Point(331, 236);
            LblBirthday.Name = "LblBirthday";
            LblBirthday.Size = new Size(220, 22);
            LblBirthday.TabIndex = 18;
            LblBirthday.Text = "Data de Nascimento";
            // 
            // PnlLeft
            // 
            PnlLeft.Controls.Add(LblGreet);
            PnlLeft.Controls.Add(LblTz);
            PnlLeft.Location = new Point(0, 0);
            PnlLeft.Name = "PnlLeft";
            PnlLeft.Size = new Size(301, 482);
            PnlLeft.TabIndex = 20;
            // 
            // LblGreet
            // 
            LblGreet.AutoSize = true;
            LblGreet.Font = new Font("Neon 80s", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LblGreet.Location = new Point(11, 93);
            LblGreet.Name = "LblGreet";
            LblGreet.Size = new Size(277, 63);
            LblGreet.TabIndex = 22;
            LblGreet.Text = "Novo funcionário?  \r\nCadastre-o no sistema e de \r\nas boas vindas!";
            LblGreet.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblTz
            // 
            LblTz.AutoSize = true;
            LblTz.Font = new Font("Neon 80s", 30F, FontStyle.Regular, GraphicsUnit.Point);
            LblTz.Location = new Point(36, 34);
            LblTz.Name = "LblTz";
            LblTz.Size = new Size(224, 42);
            LblTz.TabIndex = 21;
            LblTz.Text = "TzSoluções";
            // 
            // LblInvalid
            // 
            LblInvalid.AutoSize = true;
            LblInvalid.Font = new Font("Neon 80s", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LblInvalid.Location = new Point(331, 456);
            LblInvalid.Name = "LblInvalid";
            LblInvalid.Size = new Size(201, 21);
            LblInvalid.TabIndex = 23;
            LblInvalid.Text = "Campo CPF Inválido";
            LblInvalid.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBoxRoles
            // 
            comboBoxRoles.Font = new Font("Neon 80s", 18F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxRoles.FormattingEnabled = true;
            comboBoxRoles.IntegralHeight = false;
            comboBoxRoles.ItemHeight = 25;
            comboBoxRoles.Location = new Point(643, 188);
            comboBoxRoles.Name = "comboBoxRoles";
            comboBoxRoles.Size = new Size(241, 33);
            comboBoxRoles.TabIndex = 14;
            comboBoxRoles.Leave += comboBoxRoles_Leave;
            // 
            // btnRegister
            // 
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Neon 80s", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegister.Location = new Point(722, 406);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(162, 46);
            btnRegister.TabIndex = 20;
            btnRegister.Text = "Registrar";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // TxtPhone
            // 
            TxtPhone.BorderStyle = BorderStyle.FixedSingle;
            TxtPhone.Font = new Font("Neon 80s", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtPhone.Location = new Point(643, 261);
            TxtPhone.Name = "TxtPhone";
            TxtPhone.Size = new Size(241, 35);
            TxtPhone.TabIndex = 16;
            TxtPhone.Leave += TxtNumber_Leave;
            // 
            // LblNumber
            // 
            LblNumber.AutoSize = true;
            LblNumber.Font = new Font("Neon 80s", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LblNumber.Location = new Point(643, 236);
            LblNumber.Name = "LblNumber";
            LblNumber.Size = new Size(216, 22);
            LblNumber.TabIndex = 27;
            LblNumber.Text = "Telefone (com DDD)";
            // 
            // TxtCEP
            // 
            TxtCEP.BorderStyle = BorderStyle.FixedSingle;
            TxtCEP.Font = new Font("Neon 80s", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtCEP.Location = new Point(331, 339);
            TxtCEP.Name = "TxtCEP";
            TxtCEP.Size = new Size(241, 35);
            TxtCEP.TabIndex = 17;
            TxtCEP.Leave += TxtCEP_Leave;
            // 
            // LblCEP
            // 
            LblCEP.AutoSize = true;
            LblCEP.Font = new Font("Neon 80s", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LblCEP.Location = new Point(331, 314);
            LblCEP.Name = "LblCEP";
            LblCEP.Size = new Size(50, 22);
            LblCEP.TabIndex = 29;
            LblCEP.Text = "CEP";
            // 
            // TxtNumber
            // 
            TxtNumber.BorderStyle = BorderStyle.FixedSingle;
            TxtNumber.Font = new Font("Neon 80s", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtNumber.Location = new Point(643, 339);
            TxtNumber.Name = "TxtNumber";
            TxtNumber.Size = new Size(241, 35);
            TxtNumber.TabIndex = 18;
            // 
            // LblStreetNumber
            // 
            LblStreetNumber.AutoSize = true;
            LblStreetNumber.Font = new Font("Neon 80s", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LblStreetNumber.Location = new Point(643, 314);
            LblStreetNumber.Name = "LblStreetNumber";
            LblStreetNumber.Size = new Size(94, 22);
            LblStreetNumber.TabIndex = 31;
            LblStreetNumber.Text = "Número";
            // 
            // TxtAddSuplement
            // 
            TxtAddSuplement.BorderStyle = BorderStyle.FixedSingle;
            TxtAddSuplement.Font = new Font("Neon 80s", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtAddSuplement.Location = new Point(331, 418);
            TxtAddSuplement.Name = "TxtAddSuplement";
            TxtAddSuplement.Size = new Size(241, 35);
            TxtAddSuplement.TabIndex = 19;
            // 
            // LblAddSuplement
            // 
            LblAddSuplement.AutoSize = true;
            LblAddSuplement.Font = new Font("Neon 80s", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LblAddSuplement.Location = new Point(331, 393);
            LblAddSuplement.Name = "LblAddSuplement";
            LblAddSuplement.Size = new Size(158, 22);
            LblAddSuplement.TabIndex = 33;
            LblAddSuplement.Text = "Complemento";
            // 
            // RegisterEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LblInvalid);
            Controls.Add(TxtAddSuplement);
            Controls.Add(LblAddSuplement);
            Controls.Add(TxtNumber);
            Controls.Add(LblStreetNumber);
            Controls.Add(TxtCEP);
            Controls.Add(LblCEP);
            Controls.Add(TxtPhone);
            Controls.Add(LblNumber);
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
        private TextBox TxtPhone;
        private Label LblNumber;
        private TextBox TxtCEP;
        private Label LblCEP;
        private TextBox TxtNumber;
        private Label LblStreetNumber;
        private TextBox TxtAddSuplement;
        private Label LblAddSuplement;
    }
}
