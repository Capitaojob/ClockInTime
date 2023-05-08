using Workers;

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
            BtnManageUsers = new Button();
            BtnGeneralPayment = new Button();
            LblManagement = new Label();
            LblClockIn = new Label();
            LblPayment = new Label();
            BtnSignIn = new Button();
            BtnRole = new Button();
            BtnConference = new Button();
            BtnPayment = new Button();
            BtnClockIn = new Button();
            LblLogoTop = new Label();
            PnlDivider = new Panel();
            PnlInfoCircle = new Panel();
            LblQuestionMark = new Label();
            PnlUserInfo = new Panel();
            PbUser = new PictureBox();
            label1 = new Label();
            LblPath = new Label();
            PnlMainContent = new Panel();
            punchInViewer1 = new PunchInViewer();
            registerEmployee1 = new RegisterEmployee();
            roleManagement1 = new RoleManagement();
            userPayroll1 = new UserPayroll();
            punchInControl1 = new PunchInControl();
            userData1 = new UserData();
            PnlMainLeft.SuspendLayout();
            PnlInfoCircle.SuspendLayout();
            PnlUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbUser).BeginInit();
            PnlMainContent.SuspendLayout();
            SuspendLayout();
            // 
            // PnlMainLeft
            // 
            PnlMainLeft.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            PnlMainLeft.BackColor = SystemColors.HotTrack;
            PnlMainLeft.Controls.Add(BtnManageUsers);
            PnlMainLeft.Controls.Add(BtnGeneralPayment);
            PnlMainLeft.Controls.Add(LblManagement);
            PnlMainLeft.Controls.Add(LblClockIn);
            PnlMainLeft.Controls.Add(LblPayment);
            PnlMainLeft.Controls.Add(BtnSignIn);
            PnlMainLeft.Controls.Add(BtnRole);
            PnlMainLeft.Controls.Add(BtnConference);
            PnlMainLeft.Controls.Add(BtnPayment);
            PnlMainLeft.Controls.Add(BtnClockIn);
            PnlMainLeft.Controls.Add(LblLogoTop);
            PnlMainLeft.Location = new Point(0, 0);
            PnlMainLeft.Name = "PnlMainLeft";
            PnlMainLeft.Size = new Size(221, 620);
            PnlMainLeft.TabIndex = 0;
            // 
            // BtnManageUsers
            // 
            BtnManageUsers.Cursor = Cursors.Hand;
            BtnManageUsers.FlatStyle = FlatStyle.Flat;
            BtnManageUsers.Font = new Font("Neon 80s", 10F, FontStyle.Regular, GraphicsUnit.Point);
            BtnManageUsers.Location = new Point(12, 372);
            BtnManageUsers.Name = "BtnManageUsers";
            BtnManageUsers.Size = new Size(195, 43);
            BtnManageUsers.TabIndex = 11;
            BtnManageUsers.Text = "Consulta de Pontos Geral";
            BtnManageUsers.UseVisualStyleBackColor = true;
            // 
            // BtnGeneralPayment
            // 
            BtnGeneralPayment.Cursor = Cursors.Hand;
            BtnGeneralPayment.FlatStyle = FlatStyle.Flat;
            BtnGeneralPayment.Font = new Font("Neon 80s", 10F, FontStyle.Regular, GraphicsUnit.Point);
            BtnGeneralPayment.Location = new Point(12, 565);
            BtnGeneralPayment.Name = "BtnGeneralPayment";
            BtnGeneralPayment.Size = new Size(195, 43);
            BtnGeneralPayment.TabIndex = 10;
            BtnGeneralPayment.Text = "Demonstrativo Pagamento Geral";
            BtnGeneralPayment.UseVisualStyleBackColor = true;
            // 
            // LblManagement
            // 
            LblManagement.AutoSize = true;
            LblManagement.BackColor = Color.Transparent;
            LblManagement.Font = new Font("Neon 80s", 17F, FontStyle.Regular, GraphicsUnit.Point);
            LblManagement.Location = new Point(12, 345);
            LblManagement.Name = "LblManagement";
            LblManagement.Size = new Size(173, 24);
            LblManagement.TabIndex = 9;
            LblManagement.Text = "Gerenciamento";
            // 
            // LblClockIn
            // 
            LblClockIn.AutoSize = true;
            LblClockIn.BackColor = Color.Transparent;
            LblClockIn.Font = new Font("Neon 80s", 17F, FontStyle.Regular, GraphicsUnit.Point);
            LblClockIn.Location = new Point(12, 85);
            LblClockIn.Name = "LblClockIn";
            LblClockIn.Size = new Size(80, 24);
            LblClockIn.TabIndex = 8;
            LblClockIn.Text = "Pontos";
            // 
            // LblPayment
            // 
            LblPayment.AutoSize = true;
            LblPayment.BackColor = Color.Transparent;
            LblPayment.Font = new Font("Neon 80s", 17F, FontStyle.Regular, GraphicsUnit.Point);
            LblPayment.Location = new Point(12, 244);
            LblPayment.Name = "LblPayment";
            LblPayment.Size = new Size(130, 24);
            LblPayment.TabIndex = 5;
            LblPayment.Text = "Pagamento";
            // 
            // BtnSignIn
            // 
            BtnSignIn.Cursor = Cursors.Hand;
            BtnSignIn.FlatStyle = FlatStyle.Flat;
            BtnSignIn.Font = new Font("Neon 80s", 10F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSignIn.Location = new Point(12, 436);
            BtnSignIn.Name = "BtnSignIn";
            BtnSignIn.Size = new Size(195, 43);
            BtnSignIn.TabIndex = 7;
            BtnSignIn.Text = "Gerenciar Funcionários";
            BtnSignIn.UseVisualStyleBackColor = true;
            BtnSignIn.Click += BtnSignIn_Click;
            // 
            // BtnRole
            // 
            BtnRole.Cursor = Cursors.Hand;
            BtnRole.FlatStyle = FlatStyle.Flat;
            BtnRole.Font = new Font("Neon 80s", 10F, FontStyle.Regular, GraphicsUnit.Point);
            BtnRole.Location = new Point(12, 501);
            BtnRole.Name = "BtnRole";
            BtnRole.Size = new Size(195, 43);
            BtnRole.TabIndex = 6;
            BtnRole.Text = "Gerenciar Cargos";
            BtnRole.UseVisualStyleBackColor = true;
            BtnRole.Click += BtnRole_Click;
            // 
            // BtnConference
            // 
            BtnConference.BackColor = SystemColors.Control;
            BtnConference.Cursor = Cursors.Hand;
            BtnConference.FlatStyle = FlatStyle.Flat;
            BtnConference.Font = new Font("Neon 80s", 10F, FontStyle.Regular, GraphicsUnit.Point);
            BtnConference.Location = new Point(12, 174);
            BtnConference.Name = "BtnConference";
            BtnConference.Size = new Size(195, 43);
            BtnConference.TabIndex = 4;
            BtnConference.Text = "Consulta de Pontos";
            BtnConference.UseVisualStyleBackColor = false;
            BtnConference.Click += BtnConference_Click;
            // 
            // BtnPayment
            // 
            BtnPayment.Cursor = Cursors.Hand;
            BtnPayment.FlatStyle = FlatStyle.Flat;
            BtnPayment.Font = new Font("Neon 80s", 10F, FontStyle.Regular, GraphicsUnit.Point);
            BtnPayment.Location = new Point(12, 271);
            BtnPayment.Name = "BtnPayment";
            BtnPayment.Size = new Size(195, 43);
            BtnPayment.TabIndex = 3;
            BtnPayment.Text = "Demonstrativo de Pagamento";
            BtnPayment.UseVisualStyleBackColor = true;
            BtnPayment.Click += BtnPayment_Click;
            // 
            // BtnClockIn
            // 
            BtnClockIn.BackColor = SystemColors.Control;
            BtnClockIn.Cursor = Cursors.Hand;
            BtnClockIn.FlatStyle = FlatStyle.Flat;
            BtnClockIn.Font = new Font("Neon 80s", 10F, FontStyle.Regular, GraphicsUnit.Point);
            BtnClockIn.Location = new Point(12, 112);
            BtnClockIn.Name = "BtnClockIn";
            BtnClockIn.Size = new Size(195, 43);
            BtnClockIn.TabIndex = 2;
            BtnClockIn.Text = "Registro de Ponto";
            BtnClockIn.UseVisualStyleBackColor = false;
            BtnClockIn.Click += BtnClockIn_Click;
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
            PnlUserInfo.Controls.Add(PbUser);
            PnlUserInfo.Controls.Add(label1);
            PnlUserInfo.Cursor = Cursors.Hand;
            PnlUserInfo.Location = new Point(1150, 7);
            PnlUserInfo.Name = "PnlUserInfo";
            PnlUserInfo.Size = new Size(55, 55);
            PnlUserInfo.TabIndex = 4;
            PnlUserInfo.Click += PnlUserInfo_Click;
            // 
            // PbUser
            // 
            PbUser.BackColor = Color.Transparent;
            PbUser.BackgroundImage = Properties.Resources.user;
            PbUser.BackgroundImageLayout = ImageLayout.Zoom;
            PbUser.Location = new Point(12, 10);
            PbUser.Name = "PbUser";
            PbUser.Size = new Size(33, 35);
            PbUser.TabIndex = 4;
            PbUser.TabStop = false;
            PbUser.Click += PbUser_Click;
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
            LblPath.Size = new Size(219, 24);
            LblPath.TabIndex = 2;
            LblPath.Text = "Início > Minha Conta";
            // 
            // PnlMainContent
            // 
            PnlMainContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PnlMainContent.Controls.Add(punchInViewer1);
            PnlMainContent.Controls.Add(registerEmployee1);
            PnlMainContent.Controls.Add(roleManagement1);
            PnlMainContent.Controls.Add(userPayroll1);
            PnlMainContent.Controls.Add(punchInControl1);
            PnlMainContent.Controls.Add(userData1);
            PnlMainContent.Location = new Point(262, 112);
            PnlMainContent.Name = "PnlMainContent";
            PnlMainContent.Size = new Size(914, 482);
            PnlMainContent.TabIndex = 1;
            // 
            // punchInViewer1
            // 
            punchInViewer1.BackColor = Color.FromArgb(248, 250, 255);
            punchInViewer1.Location = new Point(0, 0);
            punchInViewer1.Name = "punchInViewer1";
            punchInViewer1.Size = new Size(914, 482);
            punchInViewer1.TabIndex = 11;
            punchInViewer1.Load += punchInViewer1_Load;
            // 
            // registerEmployee1
            // 
            registerEmployee1.BackColor = Color.FromArgb(248, 250, 255);
            registerEmployee1.Location = new Point(0, 0);
            registerEmployee1.Name = "registerEmployee1";
            registerEmployee1.Size = new Size(914, 482);
            registerEmployee1.TabIndex = 9;
            registerEmployee1.Load += registerEmployee_Load;
            // 
            // roleManagement1
            // 
            roleManagement1.BackColor = Color.FromArgb(248, 250, 255);
            roleManagement1.Location = new Point(0, 0);
            roleManagement1.Name = "roleManagement1";
            roleManagement1.Size = new Size(914, 482);
            roleManagement1.TabIndex = 8;
            // 
            // userPayroll1
            // 
            userPayroll1.BackColor = Color.FromArgb(248, 250, 255);
            userPayroll1.Location = new Point(0, 0);
            userPayroll1.Name = "userPayroll1";
            userPayroll1.Size = new Size(914, 482);
            userPayroll1.TabIndex = 7;
            userPayroll1.Load += userPayroll1_Load;
            // 
            // punchInControl1
            // 
            punchInControl1.BackColor = Color.FromArgb(248, 250, 255);
            punchInControl1.Location = new Point(0, 0);
            punchInControl1.Name = "punchInControl1";
            punchInControl1.Size = new Size(914, 482);
            punchInControl1.TabIndex = 6;
            punchInControl1.Load += punchInControl1_Load;
            // 
            // userData1
            // 
            userData1.BackColor = Color.FromArgb(248, 250, 255);
            userData1.Location = new Point(0, 0);
            userData1.Margin = new Padding(3, 2, 3, 2);
            userData1.Name = "userData1";
            userData1.Size = new Size(914, 482);
            userData1.TabIndex = 10;
            userData1.Load += userData1_Load;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1217, 620);
            Controls.Add(LblPath);
            Controls.Add(PnlUserInfo);
            Controls.Add(PnlInfoCircle);
            Controls.Add(PnlDivider);
            Controls.Add(PnlMainContent);
            Controls.Add(PnlMainLeft);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PointPay - Início";
            Load += MainForm_Load;
            PnlMainLeft.ResumeLayout(false);
            PnlMainLeft.PerformLayout();
            PnlInfoCircle.ResumeLayout(false);
            PnlInfoCircle.PerformLayout();
            PnlUserInfo.ResumeLayout(false);
            PnlUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PbUser).EndInit();
            PnlMainContent.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PnlMainLeft;
        private Panel PnlDivider;
        private Panel PnlInfoCircle;
        private Panel PnlUserInfo;
        private Label LblLogoTop;
        private Label LblQuestionMark;
        private Label LblPath;
        private PictureBox PbUser;
        private Label label1;
        private Label LblClockIn;
        private Label LblPayment;
        private Button BtnSignIn;
        private Button BtnRole;
        private Button BtnConference;
        private Button BtnPayment;
        private Button BtnClockIn;
        private Label LblManagement;
        private Button BtnGeneralPayment;
        //private RegisterEmployee registerEmployee;
        private Panel PnlMainContent;
        //private UserData userData1;
        private PunchInControl punchInControl1;
        private Button BtnManageUsers;
        private UserPayroll userPayroll1;
        private RoleManagement roleManagement1;
        private RegisterEmployee registerEmployee1;
        private UserData userData1;
        private PunchInViewer punchInViewer1;
    }
}