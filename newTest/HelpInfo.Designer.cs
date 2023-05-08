namespace newTest
{
    partial class HelpInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpInfo));
            LblHelp = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // LblHelp
            // 
            LblHelp.AutoSize = true;
            LblHelp.Font = new Font("Neon 80s", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LblHelp.Location = new Point(20, 12);
            LblHelp.MaximumSize = new Size(870, 0);
            LblHelp.Name = "LblHelp";
            LblHelp.Size = new Size(869, 840);
            LblHelp.TabIndex = 0;
            LblHelp.Text = resources.GetString("LblHelp.Text");
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(LblHelp);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 482);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // HelpInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "HelpInfo";
            Size = new Size(914, 482);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label LblHelp;
        private Panel panel1;
    }
}
