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
            comboBoxRoles.TabIndex = 17;
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
            TxtRoleName.Location = new Point(554, 86);
            TxtRoleName.Name = "TxtRoleName";
            TxtRoleName.Size = new Size(294, 35);
            TxtRoleName.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Neon 80s", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(554, 61);
            label1.Name = "label1";
            label1.Size = new Size(173, 22);
            label1.TabIndex = 20;
            label1.Text = "Nome do Cargo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Neon 80s", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(555, 157);
            label2.Name = "label2";
            label2.Size = new Size(79, 22);
            label2.TabIndex = 22;
            label2.Text = "Salário";
            // 
            // TxtRoleWage
            // 
            TxtRoleWage.BorderStyle = BorderStyle.FixedSingle;
            TxtRoleWage.Font = new Font("Neon 80s", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtRoleWage.Location = new Point(555, 182);
            TxtRoleWage.Name = "TxtRoleWage";
            TxtRoleWage.Size = new Size(293, 35);
            TxtRoleWage.TabIndex = 21;
            // 
            // CbHR
            // 
            CbHR.AutoSize = true;
            CbHR.Cursor = Cursors.Hand;
            CbHR.Font = new Font("Neon 80s", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CbHR.Location = new Point(554, 270);
            CbHR.Name = "CbHR";
            CbHR.Size = new Size(217, 29);
            CbHR.TabIndex = 25;
            CbHR.Text = "Gerencia dados?";
            CbHR.UseVisualStyleBackColor = true;
            // 
            // RoleManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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
    }
}
