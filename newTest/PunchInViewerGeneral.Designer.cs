namespace newTest
{
    partial class PunchInViewerGeneral
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
            PnlLeft = new Panel();
            CbEmployees = new ComboBox();
            LblUpdateUser = new Label();
            BtnUpdate = new Button();
            LblIntro = new Label();
            LblWelcome = new Label();
            TblLastRegisters = new TableLayoutPanel();
            PnlLeft.SuspendLayout();
            SuspendLayout();
            // 
            // PnlLeft
            // 
            PnlLeft.Controls.Add(CbEmployees);
            PnlLeft.Controls.Add(LblUpdateUser);
            PnlLeft.Controls.Add(BtnUpdate);
            PnlLeft.Controls.Add(LblIntro);
            PnlLeft.Controls.Add(LblWelcome);
            PnlLeft.Location = new Point(0, 0);
            PnlLeft.Name = "PnlLeft";
            PnlLeft.Size = new Size(300, 482);
            PnlLeft.TabIndex = 28;
            // 
            // CbEmployees
            // 
            CbEmployees.Font = new Font("Neon 80s", 14F, FontStyle.Regular, GraphicsUnit.Point);
            CbEmployees.FormattingEnabled = true;
            CbEmployees.IntegralHeight = false;
            CbEmployees.ItemHeight = 20;
            CbEmployees.Location = new Point(9, 242);
            CbEmployees.Name = "CbEmployees";
            CbEmployees.Size = new Size(284, 28);
            CbEmployees.TabIndex = 37;
            CbEmployees.SelectedIndexChanged += CbEmployees_SelectedIndexChanged;
            // 
            // LblUpdateUser
            // 
            LblUpdateUser.AutoSize = true;
            LblUpdateUser.Font = new Font("Neon 80s", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LblUpdateUser.Location = new Point(22, 217);
            LblUpdateUser.Name = "LblUpdateUser";
            LblUpdateUser.Size = new Size(130, 22);
            LblUpdateUser.TabIndex = 36;
            LblUpdateUser.Text = "Funcionário";
            // 
            // BtnUpdate
            // 
            BtnUpdate.Cursor = Cursors.Hand;
            BtnUpdate.FlatStyle = FlatStyle.Flat;
            BtnUpdate.Font = new Font("Neon 80s", 15F, FontStyle.Regular, GraphicsUnit.Point);
            BtnUpdate.Location = new Point(22, 391);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(245, 38);
            BtnUpdate.TabIndex = 24;
            BtnUpdate.Text = "Atualizar Registros";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // LblIntro
            // 
            LblIntro.AutoSize = true;
            LblIntro.Font = new Font("Neon 80s", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LblIntro.Location = new Point(32, 103);
            LblIntro.MaximumSize = new Size(250, 0);
            LblIntro.Name = "LblIntro";
            LblIntro.Size = new Size(235, 63);
            LblIntro.TabIndex = 23;
            LblIntro.Text = "Verifique o histórico de pontos de qualquer funcionário";
            LblIntro.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblWelcome
            // 
            LblWelcome.AutoSize = true;
            LblWelcome.Font = new Font("Neon 80s", 30F, FontStyle.Regular, GraphicsUnit.Point);
            LblWelcome.Location = new Point(52, 42);
            LblWelcome.Name = "LblWelcome";
            LblWelcome.Size = new Size(179, 42);
            LblWelcome.TabIndex = 22;
            LblWelcome.Text = "Consulta";
            // 
            // TblLastRegisters
            // 
            TblLastRegisters.AutoScroll = true;
            TblLastRegisters.ColumnCount = 1;
            TblLastRegisters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TblLastRegisters.Location = new Point(306, 3);
            TblLastRegisters.Name = "TblLastRegisters";
            TblLastRegisters.RowCount = 1;
            TblLastRegisters.RowStyles.Add(new RowStyle());
            TblLastRegisters.Size = new Size(605, 495);
            TblLastRegisters.TabIndex = 38;
            // 
            // PunchInViewerGeneral
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TblLastRegisters);
            Controls.Add(PnlLeft);
            Name = "PunchInViewerGeneral";
            Size = new Size(914, 482);
            Load += PunchInViewerGeneral_Load;
            PnlLeft.ResumeLayout(false);
            PnlLeft.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlLeft;
        private Button BtnUpdate;
        private Label LblIntro;
        private Label LblWelcome;
        private ComboBox CbEmployees;
        private Label LblUpdateUser;
        private TableLayoutPanel TblLastRegisters;
    }
}
