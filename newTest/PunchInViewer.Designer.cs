namespace newTest
{
    partial class PunchInViewer
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
            TblLastRegisters = new TableLayoutPanel();
            PnlLeft = new Panel();
            BtnUpdate = new Button();
            LblIntro = new Label();
            LblWelcome = new Label();
            PnlLeft.SuspendLayout();
            SuspendLayout();
            // 
            // TblLastRegisters
            // 
            TblLastRegisters.AutoScroll = true;
            TblLastRegisters.ColumnCount = 1;
            TblLastRegisters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TblLastRegisters.Location = new Point(309, 7);
            TblLastRegisters.Name = "TblLastRegisters";
            TblLastRegisters.RowCount = 1;
            TblLastRegisters.RowStyles.Add(new RowStyle());
            TblLastRegisters.Size = new Size(605, 495);
            TblLastRegisters.TabIndex = 8;
            // 
            // PnlLeft
            // 
            PnlLeft.Controls.Add(BtnUpdate);
            PnlLeft.Controls.Add(LblIntro);
            PnlLeft.Controls.Add(LblWelcome);
            PnlLeft.Location = new Point(0, 0);
            PnlLeft.Name = "PnlLeft";
            PnlLeft.Size = new Size(300, 482);
            PnlLeft.TabIndex = 27;
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
            BtnUpdate.Text = "Atualizar";
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
            LblIntro.Text = "Verifique o histórico de seus pontos em tempo real";
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
            // PunchInViewer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PnlLeft);
            Controls.Add(TblLastRegisters);
            Name = "PunchInViewer";
            Size = new Size(914, 482);
            Load += PunchInViewer_Load;
            PnlLeft.ResumeLayout(false);
            PnlLeft.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel TblLastRegisters;
        private Panel PnlLeft;
        private Label LblIntro;
        private Label LblWelcome;
        private Button BtnUpdate;
    }
}
