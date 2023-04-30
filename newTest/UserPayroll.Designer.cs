namespace newTest
{
    partial class UserPayroll
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
            DtStart = new DateTimePicker();
            DtEnd = new DateTimePicker();
            LblStart = new Label();
            LblEnd = new Label();
            BtnGeneratePayroll = new Button();
            PnlLeftInfo = new Panel();
            LblDirectory = new Label();
            BtnFolder = new Button();
            FBD = new FolderBrowserDialog();
            PnlLeftInfo.SuspendLayout();
            SuspendLayout();
            // 
            // DtStart
            // 
            DtStart.CustomFormat = "  dd/MM/yyyy";
            DtStart.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DtStart.Format = DateTimePickerFormat.Custom;
            DtStart.Location = new Point(37, 127);
            DtStart.Name = "DtStart";
            DtStart.Size = new Size(223, 35);
            DtStart.TabIndex = 0;
            // 
            // DtEnd
            // 
            DtEnd.CustomFormat = "  dd/MM/yyyy";
            DtEnd.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DtEnd.Format = DateTimePickerFormat.Custom;
            DtEnd.Location = new Point(36, 198);
            DtEnd.Name = "DtEnd";
            DtEnd.Size = new Size(223, 35);
            DtEnd.TabIndex = 1;
            // 
            // LblStart
            // 
            LblStart.AutoSize = true;
            LblStart.Font = new Font("Neon 80s", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LblStart.Location = new Point(36, 104);
            LblStart.Name = "LblStart";
            LblStart.Size = new Size(57, 21);
            LblStart.TabIndex = 2;
            LblStart.Text = "Início";
            // 
            // LblEnd
            // 
            LblEnd.AutoSize = true;
            LblEnd.Font = new Font("Neon 80s", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LblEnd.Location = new Point(36, 174);
            LblEnd.Name = "LblEnd";
            LblEnd.Size = new Size(46, 21);
            LblEnd.TabIndex = 3;
            LblEnd.Text = "Fim";
            // 
            // BtnGeneratePayroll
            // 
            BtnGeneratePayroll.Font = new Font("Neon 80s", 15F, FontStyle.Regular, GraphicsUnit.Point);
            BtnGeneratePayroll.Location = new Point(36, 402);
            BtnGeneratePayroll.Name = "BtnGeneratePayroll";
            BtnGeneratePayroll.Size = new Size(224, 46);
            BtnGeneratePayroll.TabIndex = 4;
            BtnGeneratePayroll.Text = "Gerar Demonstrativo";
            BtnGeneratePayroll.UseVisualStyleBackColor = true;
            BtnGeneratePayroll.Click += BtnGeneratePayroll_Click;
            // 
            // PnlLeftInfo
            // 
            PnlLeftInfo.Controls.Add(LblDirectory);
            PnlLeftInfo.Controls.Add(LblEnd);
            PnlLeftInfo.Controls.Add(BtnFolder);
            PnlLeftInfo.Controls.Add(DtEnd);
            PnlLeftInfo.Location = new Point(0, 0);
            PnlLeftInfo.Name = "PnlLeftInfo";
            PnlLeftInfo.Size = new Size(316, 482);
            PnlLeftInfo.TabIndex = 5;
            // 
            // LblDirectory
            // 
            LblDirectory.AutoSize = true;
            LblDirectory.Font = new Font("Neon 80s", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LblDirectory.Location = new Point(37, 245);
            LblDirectory.Name = "LblDirectory";
            LblDirectory.Size = new Size(91, 21);
            LblDirectory.TabIndex = 6;
            LblDirectory.Text = "Diretório";
            // 
            // BtnFolder
            // 
            BtnFolder.Font = new Font("Neon 80s", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnFolder.Location = new Point(36, 269);
            BtnFolder.Name = "BtnFolder";
            BtnFolder.Size = new Size(224, 38);
            BtnFolder.TabIndex = 0;
            BtnFolder.Text = "Selecione o diretório";
            BtnFolder.TextAlign = ContentAlignment.MiddleLeft;
            BtnFolder.UseVisualStyleBackColor = true;
            BtnFolder.Click += BtnFolder_Click;
            // 
            // UserPayroll
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BtnGeneratePayroll);
            Controls.Add(LblStart);
            Controls.Add(DtStart);
            Controls.Add(PnlLeftInfo);
            Name = "UserPayroll";
            Size = new Size(914, 482);
            Load += UserPayroll_Load;
            PnlLeftInfo.ResumeLayout(false);
            PnlLeftInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker DtStart;
        private DateTimePicker DtEnd;
        private Label LblStart;
        private Label LblEnd;
        private Button BtnGeneratePayroll;
        private Panel PnlLeftInfo;
        private FolderBrowserDialog FBD;
        private Button BtnFolder;
        private Label LblDirectory;
    }
}
