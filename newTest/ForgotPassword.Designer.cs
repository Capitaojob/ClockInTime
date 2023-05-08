namespace newTest
{
    partial class ForgotPassword
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PnlMiddle = new Panel();
            TxtWarning = new TextBox();
            TxtInputCode = new TextBox();
            LblLogo = new Label();
            BtnCode = new Button();
            pwInput = new TextBox();
            LblDescription = new Label();
            LblMain = new Label();
            loginInput = new TextBox();
            PnlMiddle.SuspendLayout();
            SuspendLayout();
            // 
            // PnlMiddle
            // 
            PnlMiddle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PnlMiddle.BackColor = Color.FromArgb(219, 231, 245);
            PnlMiddle.BackgroundImageLayout = ImageLayout.None;
            PnlMiddle.Controls.Add(TxtWarning);
            PnlMiddle.Controls.Add(TxtInputCode);
            PnlMiddle.Controls.Add(LblLogo);
            PnlMiddle.Controls.Add(BtnCode);
            PnlMiddle.Controls.Add(pwInput);
            PnlMiddle.Controls.Add(LblDescription);
            PnlMiddle.Controls.Add(LblMain);
            PnlMiddle.Controls.Add(loginInput);
            PnlMiddle.Location = new Point(60, 60);
            PnlMiddle.Name = "PnlMiddle";
            PnlMiddle.Size = new Size(1097, 500);
            PnlMiddle.TabIndex = 7;
            // 
            // TxtWarning
            // 
            TxtWarning.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtWarning.BackColor = SystemColors.Window;
            TxtWarning.BorderStyle = BorderStyle.None;
            TxtWarning.Enabled = false;
            TxtWarning.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            TxtWarning.Location = new Point(356, 415);
            TxtWarning.MaximumSize = new Size(400, 60);
            TxtWarning.MaxLength = 50;
            TxtWarning.MinimumSize = new Size(197, 36);
            TxtWarning.Name = "TxtWarning";
            TxtWarning.ReadOnly = true;
            TxtWarning.Size = new Size(390, 36);
            TxtWarning.TabIndex = 3;
            TxtWarning.TabStop = false;
            TxtWarning.TextAlign = HorizontalAlignment.Center;
            TxtWarning.WordWrap = false;
            // 
            // TxtInputCode
            // 
            TxtInputCode.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtInputCode.BorderStyle = BorderStyle.None;
            TxtInputCode.Font = new Font("Neon 80s", 20F, FontStyle.Regular, GraphicsUnit.Point);
            TxtInputCode.Location = new Point(356, 252);
            TxtInputCode.MaximumSize = new Size(400, 60);
            TxtInputCode.MaxLength = 50;
            TxtInputCode.MinimumSize = new Size(197, 36);
            TxtInputCode.Name = "TxtInputCode";
            TxtInputCode.Size = new Size(388, 36);
            TxtInputCode.TabIndex = 1;
            TxtInputCode.WordWrap = false;
            // 
            // LblLogo
            // 
            LblLogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblLogo.AutoSize = true;
            LblLogo.Font = new Font("Neon 80s", 35.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblLogo.ForeColor = Color.FromArgb(211, 179, 122);
            LblLogo.Location = new Point(45, 45);
            LblLogo.Name = "LblLogo";
            LblLogo.Size = new Size(280, 49);
            LblLogo.TabIndex = 6;
            LblLogo.Text = "TzSoluções";
            // 
            // BtnCode
            // 
            BtnCode.BackColor = Color.FromArgb(211, 179, 122);
            BtnCode.BackgroundImageLayout = ImageLayout.None;
            BtnCode.Cursor = Cursors.Hand;
            BtnCode.FlatAppearance.BorderSize = 0;
            BtnCode.FlatStyle = FlatStyle.Flat;
            BtnCode.Font = new Font("Neon 80s", 23F, FontStyle.Regular, GraphicsUnit.Point);
            BtnCode.ForeColor = Color.FromArgb(248, 250, 255);
            BtnCode.Location = new Point(356, 338);
            BtnCode.Name = "BtnCode";
            BtnCode.Size = new Size(390, 60);
            BtnCode.TabIndex = 2;
            BtnCode.Text = "Receber Código";
            BtnCode.UseVisualStyleBackColor = false;
            BtnCode.Click += BtnCode_Click;
            // 
            // pwInput
            // 
            pwInput.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pwInput.BorderStyle = BorderStyle.None;
            pwInput.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            pwInput.Location = new Point(359, 715);
            pwInput.MaximumSize = new Size(400, 60);
            pwInput.MinimumSize = new Size(197, 36);
            pwInput.Name = "pwInput";
            pwInput.PasswordChar = '*';
            pwInput.Size = new Size(398, 36);
            pwInput.TabIndex = 3;
            // 
            // LblDescription
            // 
            LblDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            LblDescription.AutoSize = true;
            LblDescription.Font = new Font("Neon 80s", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LblDescription.ForeColor = Color.FromArgb(43, 59, 85);
            LblDescription.Location = new Point(245, 204);
            LblDescription.Name = "LblDescription";
            LblDescription.Size = new Size(637, 25);
            LblDescription.TabIndex = 5;
            LblDescription.Text = "Insira seu email e receba o código para redefinir a senha\r\n";
            // 
            // LblMain
            // 
            LblMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            LblMain.AutoSize = true;
            LblMain.Font = new Font("Neon 80s", 35F, FontStyle.Regular, GraphicsUnit.Point);
            LblMain.ForeColor = Color.FromArgb(43, 59, 85);
            LblMain.Location = new Point(311, 155);
            LblMain.Name = "LblMain";
            LblMain.Size = new Size(488, 49);
            LblMain.TabIndex = 4;
            LblMain.Text = "Esqueceu sua senha?";
            // 
            // loginInput
            // 
            loginInput.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            loginInput.BorderStyle = BorderStyle.None;
            loginInput.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            loginInput.Location = new Point(359, 641);
            loginInput.MaximumSize = new Size(400, 60);
            loginInput.MaxLength = 50;
            loginInput.MinimumSize = new Size(197, 36);
            loginInput.Name = "loginInput";
            loginInput.Size = new Size(398, 36);
            loginInput.TabIndex = 0;
            loginInput.WordWrap = false;
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1217, 620);
            Controls.Add(PnlMiddle);
            Name = "ForgotPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PointPay - Redefinir Senha";
            Load += ForgotPassword_Load;
            PnlMiddle.ResumeLayout(false);
            PnlMiddle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlMiddle;
        private Label LblLogo;
        private Button BtnCode;
        private TextBox pwInput;
        private Label LblDescription;
        private Label LblMain;
        private TextBox loginInput;
        private TextBox TxtInputCode;
        private TextBox TxtWarning;
    }
}