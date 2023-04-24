namespace newTest
{
    partial class PunchIn
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
            PnlRight = new Panel();
            TblLastRegisters = new TableLayoutPanel();
            LblMainOut = new Label();
            LblLunchIn = new Label();
            LblLunchOut = new Label();
            LblDate = new Label();
            LblMainIn = new Label();
            LblUserId = new Label();
            LblLastRegisters = new Label();
            BtnPunchIn = new Button();
            lblCurrentTime = new Label();
            LblPageName = new Label();
            PnlRight.SuspendLayout();
            SuspendLayout();
            // 
            // PnlRight
            // 
            PnlRight.Controls.Add(TblLastRegisters);
            PnlRight.Controls.Add(LblMainOut);
            PnlRight.Controls.Add(LblLunchIn);
            PnlRight.Controls.Add(LblLunchOut);
            PnlRight.Controls.Add(LblDate);
            PnlRight.Controls.Add(LblMainIn);
            PnlRight.Controls.Add(LblUserId);
            PnlRight.Controls.Add(LblLastRegisters);
            PnlRight.Location = new Point(659, 0);
            PnlRight.Name = "PnlRight";
            PnlRight.Size = new Size(255, 482);
            PnlRight.TabIndex = 0;
            // 
            // TblLastRegisters
            // 
            TblLastRegisters.AutoScroll = true;
            TblLastRegisters.ColumnCount = 1;
            TblLastRegisters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TblLastRegisters.Location = new Point(23, 65);
            TblLastRegisters.Name = "TblLastRegisters";
            TblLastRegisters.RowCount = 1;
            TblLastRegisters.RowStyles.Add(new RowStyle());
            TblLastRegisters.Size = new Size(229, 374);
            TblLastRegisters.TabIndex = 7;
            // 
            // LblMainOut
            // 
            LblMainOut.AutoSize = true;
            LblMainOut.Font = new Font("Neon 80s", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LblMainOut.Location = new Point(25, 293);
            LblMainOut.Name = "LblMainOut";
            LblMainOut.Size = new Size(40, 21);
            LblMainOut.TabIndex = 6;
            LblMainOut.Text = "MC";
            // 
            // LblLunchIn
            // 
            LblLunchIn.AutoSize = true;
            LblLunchIn.Font = new Font("Neon 80s", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LblLunchIn.Location = new Point(25, 259);
            LblLunchIn.Name = "LblLunchIn";
            LblLunchIn.Size = new Size(40, 21);
            LblLunchIn.TabIndex = 5;
            LblLunchIn.Text = "MC";
            // 
            // LblLunchOut
            // 
            LblLunchOut.AutoSize = true;
            LblLunchOut.Font = new Font("Neon 80s", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LblLunchOut.Location = new Point(25, 224);
            LblLunchOut.Name = "LblLunchOut";
            LblLunchOut.Size = new Size(40, 21);
            LblLunchOut.TabIndex = 4;
            LblLunchOut.Text = "MC";
            // 
            // LblDate
            // 
            LblDate.AutoSize = true;
            LblDate.Font = new Font("Neon 80s", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LblDate.Location = new Point(25, 154);
            LblDate.Name = "LblDate";
            LblDate.Size = new Size(55, 21);
            LblDate.TabIndex = 3;
            LblDate.Text = "Date";
            // 
            // LblMainIn
            // 
            LblMainIn.AutoSize = true;
            LblMainIn.Font = new Font("Neon 80s", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LblMainIn.Location = new Point(25, 190);
            LblMainIn.Name = "LblMainIn";
            LblMainIn.Size = new Size(40, 21);
            LblMainIn.TabIndex = 2;
            LblMainIn.Text = "MC";
            // 
            // LblUserId
            // 
            LblUserId.AutoSize = true;
            LblUserId.Font = new Font("Neon 80s", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LblUserId.Location = new Point(25, 119);
            LblUserId.Name = "LblUserId";
            LblUserId.Size = new Size(28, 21);
            LblUserId.TabIndex = 1;
            LblUserId.Text = "ID";
            // 
            // LblLastRegisters
            // 
            LblLastRegisters.AutoSize = true;
            LblLastRegisters.Font = new Font("Neon 80s", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LblLastRegisters.Location = new Point(54, 20);
            LblLastRegisters.Name = "LblLastRegisters";
            LblLastRegisters.Size = new Size(149, 21);
            LblLastRegisters.TabIndex = 0;
            LblLastRegisters.Text = "Últimos Pontos";
            // 
            // BtnPunchIn
            // 
            BtnPunchIn.Font = new Font("Neon 80s", 17F, FontStyle.Regular, GraphicsUnit.Point);
            BtnPunchIn.Location = new Point(246, 396);
            BtnPunchIn.Name = "BtnPunchIn";
            BtnPunchIn.Size = new Size(179, 43);
            BtnPunchIn.TabIndex = 1;
            BtnPunchIn.Text = "Bater Ponto";
            BtnPunchIn.UseVisualStyleBackColor = true;
            BtnPunchIn.Click += BtnPunchIn_Click;
            // 
            // lblCurrentTime
            // 
            lblCurrentTime.AutoSize = true;
            lblCurrentTime.Font = new Font("Neon 80s", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblCurrentTime.Location = new Point(239, 119);
            lblCurrentTime.Name = "lblCurrentTime";
            lblCurrentTime.Size = new Size(186, 21);
            lblCurrentTime.TabIndex = 1;
            lblCurrentTime.Text = "Registro de Pontos";
            // 
            // LblPageName
            // 
            LblPageName.AutoSize = true;
            LblPageName.Font = new Font("Neon 80s", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LblPageName.Location = new Point(19, 20);
            LblPageName.Name = "LblPageName";
            LblPageName.Size = new Size(186, 21);
            LblPageName.TabIndex = 2;
            LblPageName.Text = "Registro de Pontos";
            // 
            // PunchIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LblPageName);
            Controls.Add(lblCurrentTime);
            Controls.Add(BtnPunchIn);
            Controls.Add(PnlRight);
            Name = "PunchIn";
            Size = new Size(914, 482);
            Load += PunchIn_Load;
            PnlRight.ResumeLayout(false);
            PnlRight.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PnlRight;
        private Label LblLastRegisters;
        private Button BtnPunchIn;
        private Label lblCurrentTime;
        private Label LblPageName;
        private Label LblDate;
        private Label LblMainIn;
        private Label LblUserId;
        private Label LblMainOut;
        private Label LblLunchIn;
        private Label LblLunchOut;
        private TableLayoutPanel TblLastRegisters;
    }
}
