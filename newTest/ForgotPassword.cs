using Workers.dao;
using Workers;

namespace newTest
{
    public partial class ForgotPassword : Form
    {
        int Code = 0;
        Employee User = new Employee();

        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.Clock;

            this.BackColor = DefaultColors.DarkBlue;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            PnlMiddle.BackColor = DefaultColors.White;
            TxtInputCode.BackColor = DefaultColors.InputGray;
            TxtWarning.BackColor = DefaultColors.White;
            TxtWarning.ForeColor = DefaultColors.WarnRed;
        }

        private void BtnCode_Click(object sender, EventArgs e)
        {
            if (TxtInputCode.Text == "")
            {
                TxtWarning.Text = "Valor não informado!";
            }
            else if (BtnCode.Text == "Receber Código")
            {
                EmployeeDaoPostgres psql = new EmployeeDaoPostgres();
                User = psql.SelectSpecific(TxtInputCode.Text);

                if (User == null)
                {
                    TxtWarning.Text = "Email não cadastrado!";
                    return;
                }

                Code = EmailUtils.SendMessage(TxtInputCode.Text);

                TxtInputCode.Text = "";
                LblDescription.Text = "Insira o código recebido no email para continuar";
                BtnCode.Text = "Verificar Código";
            }
            else if (BtnCode.Text == "Verificar Código")
            {
                if (TxtInputCode.Text == Code.ToString())
                {
                    TxtInputCode.Text = "";
                    LblDescription.Text = "Insira a nova senha a ser registrada";
                    BtnCode.Text = "Salvar Senha";
                }
                else
                {
                    TxtWarning.Text = "Código incorreto!";
                }
            }
            else if (BtnCode.Text == "Salvar Senha")
            {
                if (TxtInputCode.Text.Length < 6)
                {
                    TxtWarning.Text = "Senha muito curta!";
                }
                else if (TxtInputCode.Text.Length > 30)
                {
                    TxtWarning.Text = "Senha muito longa!";
                }
                else
                {
                    User.Password = TxtInputCode.Text;

                    EmployeeDaoPostgres psql = new EmployeeDaoPostgres();
                    psql.Update(User);

                    TxtInputCode.Visible = false;
                    LblDescription.Text = "Senha alterada com sucesso";
                    BtnCode.Text = "Fazer Login";
                }
            }
            else if (BtnCode.Text == "Fazer Login")
            {
                this.Hide();

                loginForm newLF = new loginForm();
                newLF.Closed += (s, args) => this.Close();
                newLF.Show();
            }
        }
    }
}
