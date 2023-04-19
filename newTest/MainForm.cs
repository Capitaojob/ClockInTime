using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newTest
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.BackColor = DefaultColors.InputGray;
            PnlMainLeft.BackColor = DefaultColors.DarkBlue;
            PnlDivider.BackColor = DefaultColors.Gray;
            LblLogoTop.BackColor = DefaultColors.DarkBlue;
            PnlMainContent.BackColor = DefaultColors.White;

            LblLogoTop.ForeColor = DefaultColors.SandyBrown;
            LblQuestionMark.ForeColor = DefaultColors.White;
            LblPath.ForeColor = DefaultColors.DarkBlue;
        }
    }
}
