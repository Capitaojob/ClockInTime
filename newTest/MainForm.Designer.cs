namespace newTest
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            PnlMainLeft = new Panel();
            LblLogoTop = new Label();
            PnlMainContent = new Panel();
            userInfo1 = new UserInfo();
            PnlDivider = new Panel();
            PnlInfoCircle = new Panel();
            LblQuestionMark = new Label();
            PnlUserInfo = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            LblPath = new Label();
            PnlMainLeft.SuspendLayout();
            PnlMainContent.SuspendLayout();
            PnlInfoCircle.SuspendLayout();
            PnlUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PnlMainLeft
            // 
            PnlMainLeft.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            PnlMainLeft.Controls.Add(LblLogoTop);
            PnlMainLeft.Location = new Point(0, 0);
            PnlMainLeft.Name = "PnlMainLeft";
            PnlMainLeft.Size = new Size(221, 620);
            PnlMainLeft.TabIndex = 0;
            // 
            // LblLogoTop
            // 
            LblLogoTop.AutoSize = true;
            LblLogoTop.Font = new Font("Neon 80s", 28F, FontStyle.Regular, GraphicsUnit.Point);
            LblLogoTop.Location = new Point(3, 16);
            LblLogoTop.Name = "LblLogoTop";
            LblLogoTop.Size = new Size(213, 40);
            LblLogoTop.TabIndex = 1;
            LblLogoTop.Text = "TzSoluções";
            // 
            // PnlMainContent
            // 
            PnlMainContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PnlMainContent.Controls.Add(userInfo1);
            PnlMainContent.Location = new Point(262, 112);
            PnlMainContent.Name = "PnlMainContent";
            PnlMainContent.Size = new Size(914, 482);
            PnlMainContent.TabIndex = 1;
            // 
            // userInfo1
            // 
            userInfo1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userInfo1.BackColor = SystemColors.Control;
            userInfo1.Location = new Point(0, 0);
            userInfo1.Name = "userInfo1";
            userInfo1.Size = new Size(914, 482);
            userInfo1.TabIndex = 5;
            // 
            // PnlDivider
            // 
            PnlDivider.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PnlDivider.Location = new Point(0, 68);
            PnlDivider.Name = "PnlDivider";
            PnlDivider.Size = new Size(1233, 2);
            PnlDivider.TabIndex = 2;
            // 
            // PnlInfoCircle
            // 
            PnlInfoCircle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PnlInfoCircle.BackgroundImage = (Image)resources.GetObject("PnlInfoCircle.BackgroundImage");
            PnlInfoCircle.BackgroundImageLayout = ImageLayout.Zoom;
            PnlInfoCircle.Controls.Add(LblQuestionMark);
            PnlInfoCircle.Cursor = Cursors.Hand;
            PnlInfoCircle.Location = new Point(1080, 7);
            PnlInfoCircle.Name = "PnlInfoCircle";
            PnlInfoCircle.Size = new Size(55, 55);
            PnlInfoCircle.TabIndex = 3;
            // 
            // LblQuestionMark
            // 
            LblQuestionMark.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LblQuestionMark.AutoSize = true;
            LblQuestionMark.BackColor = Color.Transparent;
            LblQuestionMark.Cursor = Cursors.Hand;
            LblQuestionMark.Font = new Font("Neon 80s", 28F, FontStyle.Regular, GraphicsUnit.Point);
            LblQuestionMark.Location = new Point(11, 8);
            LblQuestionMark.Name = "LblQuestionMark";
            LblQuestionMark.Size = new Size(36, 40);
            LblQuestionMark.TabIndex = 2;
            LblQuestionMark.Text = "?";
            // 
            // PnlUserInfo
            // 
            PnlUserInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PnlUserInfo.BackgroundImage = (Image)resources.GetObject("PnlUserInfo.BackgroundImage");
            PnlUserInfo.BackgroundImageLayout = ImageLayout.Zoom;
            PnlUserInfo.Controls.Add(pictureBox1);
            PnlUserInfo.Controls.Add(label1);
            PnlUserInfo.Cursor = Cursors.Hand;
            PnlUserInfo.Location = new Point(1150, 7);
            PnlUserInfo.Name = "PnlUserInfo";
            PnlUserInfo.Size = new Size(55, 55);
            PnlUserInfo.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.user;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 35);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Neon 80s", 28F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(11, 8);
            label1.Name = "label1";
            label1.Size = new Size(0, 40);
            label1.TabIndex = 3;
            // 
            // LblPath
            // 
            LblPath.AutoSize = true;
            LblPath.Font = new Font("Neon 80s", 17F, FontStyle.Regular, GraphicsUnit.Point);
            LblPath.Location = new Point(243, 85);
            LblPath.Name = "LblPath";
            LblPath.Size = new Size(86, 24);
            LblPath.TabIndex = 2;
            LblPath.Text = "Início > ";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1217, 620);
            Controls.Add(LblPath);
            Controls.Add(PnlUserInfo);
            Controls.Add(PnlInfoCircle);
            Controls.Add(PnlDivider);
            Controls.Add(PnlMainContent);
            Controls.Add(PnlMainLeft);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += MainForm_Load;
            PnlMainLeft.ResumeLayout(false);
            PnlMainLeft.PerformLayout();
            PnlMainContent.ResumeLayout(false);
            PnlInfoCircle.ResumeLayout(false);
            PnlInfoCircle.PerformLayout();
            PnlUserInfo.ResumeLayout(false);
            PnlUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PnlMainLeft;
        private Panel PnlMainContent;
        private Panel PnlDivider;
        private Panel PnlInfoCircle;
        private Panel PnlUserInfo;
        private Label LblLogoTop;
        private Label LblQuestionMark;
        private Label LblPath;
        private UserInfo userInfo1;
        private PictureBox pictureBox1;
        private Label label1;
    }
}