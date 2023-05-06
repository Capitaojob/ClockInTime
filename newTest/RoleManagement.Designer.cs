namespace newTest
{
    partial class RoleManagement
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
            comboBoxRoles = new ComboBox();
            LblRole = new Label();
            TxtRoleName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            TxtRoleWage = new TextBox();
            CbHR = new CheckBox();
            BtnSave = new Button();
            LblHours = new Label();
            TxtHours = new TextBox();
            LblWarning = new Label();
            BtnNew = new Button();
            BtnDelete = new Button();
            SuspendLayout();
            // 
            // comboBoxRoles
            // 
            comboBoxRoles.Font = new Font("Neon 80s", 18F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxRoles.FormattingEnabled = true;
            comboBoxRoles.IntegralHeight = false;
            comboBoxRoles.ItemHeight = 25;
            comboBoxRoles.Location = new Point(44, 86);
            comboBoxRoles.Name = "comboBoxRoles";
            comboBoxRoles.Size = new Size(294, 33);
            comboBoxRoles.TabIndex = 30;
            comboBoxRoles.SelectedIndexChanged += comboBoxRoles_SelectedIndexChanged;
            // 
            // LblRole
            // 
            LblRole.AutoSize = true;
            LblRole.Font = new Font("Neon 80s", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LblRole.Location = new Point(44, 61);
            LblRole.Name = "LblRole";
            LblRole.Size = new Size(174, 22);
            LblRole.TabIndex = 18;
            LblRole.Text = "Atualizar Cargo";
            // 
            // TxtRoleName
            // 
            TxtRoleName.BorderStyle = BorderStyle.FixedSingle;
            TxtRoleName.Font = new Font("Neon 80s", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtRoleName.Location = new Point(574, 86);
            TxtRoleName.Name = "TxtRoleName";
            TxtRoleName.Size = new Size(294, 35);
            TxtRoleName.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Neon 80s", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(574, 61);
            label1.Name = "label1";
            label1.Size = new Size(173, 22);
            label1.TabIndex = 20;
            label1.Text = "Nome do Cargo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Neon 80s", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(574, 149);
            label2.Name = "label2";
            label2.Size = new Size(79, 22);
            label2.TabIndex = 22;
            label2.Text = "Salário";
            // 
            // TxtRoleWage
            // 
            TxtRoleWage.BorderStyle = BorderStyle.FixedSingle;
            TxtRoleWage.Font = new Font("Neon 80s", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtRoleWage.Location = new Point(574, 174);
            TxtRoleWage.Name = "TxtRoleWage";
            TxtRoleWage.Size = new Size(293, 35);
            TxtRoleWage.TabIndex = 32;
            TxtRoleWage.KeyPress += TxtRoleWage_KeyPress;
            // 
            // CbHR
            // 
            CbHR.AutoSize = true;
            CbHR.Cursor = Cursors.Hand;
            CbHR.Font = new Font("Neon 80s", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CbHR.Location = new Point(575, 340);
            CbHR.Name = "CbHR";
            CbHR.Size = new Size(217, 29);
            CbHR.TabIndex = 34;
            CbHR.Text = "Gerencia dados?";
            CbHR.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.BackgroundImageLayout = ImageLayout.None;
            BtnSave.Cursor = Cursors.Hand;
            BtnSave.FlatStyle = FlatStyle.Flat;
            BtnSave.Font = new Font("Neon 80s", 15F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSave.Location = new Point(579, 394);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(289, 39);
            BtnSave.TabIndex = 35;
            BtnSave.Text = "Salvar Alterações";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // LblHours
            // 
            LblHours.AutoSize = true;
            LblHours.Font = new Font("Neon 80s", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LblHours.Location = new Point(574, 244);
            LblHours.Name = "LblHours";
            LblHours.Size = new Size(230, 22);
            LblHours.TabIndex = 28;
            LblHours.Text = "Carga Horária Mensal";
            // 
            // TxtHours
            // 
            TxtHours.BorderStyle = BorderStyle.FixedSingle;
            TxtHours.Font = new Font("Neon 80s", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtHours.Location = new Point(574, 269);
            TxtHours.Name = "TxtHours";
            TxtHours.Size = new Size(293, 35);
            TxtHours.TabIndex = 33;
            TxtHours.KeyPress += TxtHours_KeyPress;
            // 
            // LblWarning
            // 
            LblWarning.AutoSize = true;
            LblWarning.Font = new Font("Neon 80s", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LblWarning.Location = new Point(325, 448);
            LblWarning.Name = "LblWarning";
            LblWarning.Size = new Size(265, 21);
            LblWarning.TabIndex = 29;
            LblWarning.Text = "Dados salvos com sucesso!";
            // 
            // BtnNew
            // 
            BtnNew.BackgroundImageLayout = ImageLayout.None;
            BtnNew.Cursor = Cursors.Hand;
            BtnNew.FlatStyle = FlatStyle.Flat;
            BtnNew.Font = new Font("Neon 80s", 15F, FontStyle.Regular, GraphicsUnit.Point);
            BtnNew.Location = new Point(44, 394);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(289, 39);
            BtnNew.TabIndex = 36;
            BtnNew.Text = "Novo Cargo";
            BtnNew.UseVisualStyleBackColor = true;
            BtnNew.Click += BtnNew_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.BackgroundImageLayout = ImageLayout.None;
            BtnDelete.Cursor = Cursors.Hand;
            BtnDelete.FlatStyle = FlatStyle.Flat;
            BtnDelete.Font = new Font("Neon 80s", 15F, FontStyle.Regular, GraphicsUnit.Point);
            BtnDelete.Location = new Point(44, 330);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(289, 39);
            BtnDelete.TabIndex = 37;
            BtnDelete.Text = "Remover Cargo";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // RoleManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BtnDelete);
            Controls.Add(BtnNew);
            Controls.Add(LblWarning);
            Controls.Add(LblHours);
            Controls.Add(TxtHours);
            Controls.Add(BtnSave);
            Controls.Add(CbHR);
            Controls.Add(label2);
            Controls.Add(TxtRoleWage);
            Controls.Add(label1);
            Controls.Add(TxtRoleName);
            Controls.Add(comboBoxRoles);
            Controls.Add(LblRole);
            Name = "RoleManagement";
            Size = new Size(914, 482);
            Load += RoleManagement_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxRoles;
        private Label LblRole;
        private TextBox TxtRoleName;
        private Label label1;
        private Label label2;
        private TextBox TxtRoleWage;
        private CheckBox CbHR;
        private Button BtnSave;
        private Label LblHours;
        private TextBox TxtHours;
        private Label LblWarning;
        private Button BtnNew;
        private Button BtnDelete;
    }
}
