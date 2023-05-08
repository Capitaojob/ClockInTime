namespace newTest
{
    partial class GeneralPayroll
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
            BtnGeneratePayroll = new Button();
            PnlLeftInfo = new Panel();
            LblIntro = new Label();
            LblWelcome = new Label();
            LblDirectory = new Label();
            DtEnd = new DateTimePicker();
            LblStart = new Label();
            BtnFolder = new Button();
            DtStart = new DateTimePicker();
            LblEnd = new Label();
            CbEmployees = new ComboBox();
            LblUpdateUser = new Label();
            CbIsGeneralPaycheck = new CheckBox();
            FBD = new FolderBrowserDialog();
            PnlLeftInfo.SuspendLayout();
            SuspendLayout();
            // 
            // BtnGeneratePayroll
            // 
            BtnGeneratePayroll.Cursor = Cursors.Hand;
            BtnGeneratePayroll.FlatStyle = FlatStyle.Flat;
            BtnGeneratePayroll.Font = new Font("Neon 80s", 15F, FontStyle.Regular, GraphicsUnit.Point);
            BtnGeneratePayroll.Location = new Point(641, 405);
            BtnGeneratePayroll.Name = "BtnGeneratePayroll";
            BtnGeneratePayroll.Size = new Size(224, 46);
            BtnGeneratePayroll.TabIndex = 12;
            BtnGeneratePayroll.Text = "Gerar Demonstrativo";
            BtnGeneratePayroll.UseVisualStyleBackColor = true;
            BtnGeneratePayroll.Click += BtnGeneratePayroll_Click;
            // 
            // PnlLeftInfo
            // 
            PnlLeftInfo.Controls.Add(LblIntro);
            PnlLeftInfo.Controls.Add(LblWelcome);
            PnlLeftInfo.Location = new Point(0, 0);
            PnlLeftInfo.Name = "PnlLeftInfo";
            PnlLeftInfo.Size = new Size(300, 482);
            PnlLeftInfo.TabIndex = 13;
            // 
            // LblIntro
            // 
            LblIntro.AutoSize = true;
            LblIntro.Font = new Font("Neon 80s", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LblIntro.Location = new Point(21, 103);
            LblIntro.MaximumSize = new Size(270, 0);
            LblIntro.Name = "LblIntro";
            LblIntro.Size = new Size(269, 105);
            LblIntro.TabIndex = 25;
            LblIntro.Text = "Escolha o período desejado, o funcionário e o diretório para o salvamento e visualize o demonstrativo de pagamento!";
            LblIntro.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblWelcome
            // 
            LblWelcome.AutoSize = true;
            LblWelcome.Font = new Font("Neon 80s", 30F, FontStyle.Regular, GraphicsUnit.Point);
            LblWelcome.Location = new Point(3, 42);
            LblWelcome.Name = "LblWelcome";
            LblWelcome.Size = new Size(294, 42);
            LblWelcome.TabIndex = 24;
            LblWelcome.Text = "Demonstrativo";
            // 
            // LblDirectory
            // 
            LblDirectory.AutoSize = true;
            LblDirectory.Font = new Font("Neon 80s", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LblDirectory.Location = new Point(346, 225);
            LblDirectory.Name = "LblDirectory";
            LblDirectory.Size = new Size(91, 21);
            LblDirectory.TabIndex = 14;
            LblDirectory.Text = "Diretório";
            // 
            // DtEnd
            // 
            DtEnd.CustomFormat = "  dd/MM/yyyy";
            DtEnd.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DtEnd.Format = DateTimePickerFormat.Custom;
            DtEnd.Location = new Point(346, 153);
            DtEnd.Name = "DtEnd";
            DtEnd.Size = new Size(223, 35);
            DtEnd.TabIndex = 9;
            // 
            // LblStart
            // 
            LblStart.AutoSize = true;
            LblStart.Font = new Font("Neon 80s", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LblStart.Location = new Point(345, 55);
            LblStart.Name = "LblStart";
            LblStart.Size = new Size(57, 21);
            LblStart.TabIndex = 10;
            LblStart.Text = "Início";
            // 
            // BtnFolder
            // 
            BtnFolder.Font = new Font("Neon 80s", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnFolder.Location = new Point(345, 249);
            BtnFolder.Name = "BtnFolder";
            BtnFolder.Size = new Size(521, 38);
            BtnFolder.TabIndex = 7;
            BtnFolder.Text = "Selecione o diretório";
            BtnFolder.TextAlign = ContentAlignment.MiddleLeft;
            BtnFolder.UseVisualStyleBackColor = true;
            BtnFolder.Click += BtnFolder_Click;
            // 
            // DtStart
            // 
            DtStart.CustomFormat = "  dd/MM/yyyy";
            DtStart.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DtStart.Format = DateTimePickerFormat.Custom;
            DtStart.Location = new Point(346, 78);
            DtStart.Name = "DtStart";
            DtStart.Size = new Size(223, 35);
            DtStart.TabIndex = 8;
            // 
            // LblEnd
            // 
            LblEnd.AutoSize = true;
            LblEnd.Font = new Font("Neon 80s", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LblEnd.Location = new Point(346, 129);
            LblEnd.Name = "LblEnd";
            LblEnd.Size = new Size(46, 21);
            LblEnd.TabIndex = 11;
            LblEnd.Text = "Fim";
            // 
            // CbEmployees
            // 
            CbEmployees.Font = new Font("Neon 80s", 14F, FontStyle.Regular, GraphicsUnit.Point);
            CbEmployees.FormattingEnabled = true;
            CbEmployees.IntegralHeight = false;
            CbEmployees.ItemHeight = 20;
            CbEmployees.Location = new Point(344, 332);
            CbEmployees.Name = "CbEmployees";
            CbEmployees.Size = new Size(520, 28);
            CbEmployees.TabIndex = 37;
            // 
            // LblUpdateUser
            // 
            LblUpdateUser.AutoSize = true;
            LblUpdateUser.Font = new Font("Neon 80s", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LblUpdateUser.Location = new Point(345, 308);
            LblUpdateUser.Name = "LblUpdateUser";
            LblUpdateUser.Size = new Size(215, 21);
            LblUpdateUser.TabIndex = 36;
            LblUpdateUser.Text = "Atualizar Funcionário";
            // 
            // CbIsGeneralPaycheck
            // 
            CbIsGeneralPaycheck.AutoSize = true;
            CbIsGeneralPaycheck.Font = new Font("Neon 80s", 15F, FontStyle.Regular, GraphicsUnit.Point);
            CbIsGeneralPaycheck.Location = new Point(346, 405);
            CbIsGeneralPaycheck.Name = "CbIsGeneralPaycheck";
            CbIsGeneralPaycheck.Size = new Size(236, 46);
            CbIsGeneralPaycheck.TabIndex = 38;
            CbIsGeneralPaycheck.Text = "Folha de Pagamento?\r\n(Geral da Empresa)";
            CbIsGeneralPaycheck.UseVisualStyleBackColor = true;
            // 
            // GeneralPayroll
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CbIsGeneralPaycheck);
            Controls.Add(CbEmployees);
            Controls.Add(BtnGeneratePayroll);
            Controls.Add(LblUpdateUser);
            Controls.Add(PnlLeftInfo);
            Controls.Add(LblDirectory);
            Controls.Add(DtEnd);
            Controls.Add(LblStart);
            Controls.Add(BtnFolder);
            Controls.Add(DtStart);
            Controls.Add(LblEnd);
            Name = "GeneralPayroll";
            Size = new Size(914, 482);
            Load += GeneralPayroll_Load;
            PnlLeftInfo.ResumeLayout(false);
            PnlLeftInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnGeneratePayroll;
        private Panel PnlLeftInfo;
        private Label LblIntro;
        private Label LblWelcome;
        private Label LblDirectory;
        private DateTimePicker DtEnd;
        private Label LblStart;
        private Button BtnFolder;
        private DateTimePicker DtStart;
        private Label LblEnd;
        private ComboBox CbEmployees;
        private Label LblUpdateUser;
        private CheckBox CbIsGeneralPaycheck;
        private FolderBrowserDialog FBD;
    }
}
