using iTextSharp.text;
using iTextSharp.text.pdf;
using PunchIn;
using PunchIn.dao;
using Roles;
using Roles.Dao;
using System.Diagnostics;
using Workers;
using Workers.dao;

namespace newTest
{
    public partial class UserPayroll : UserControl
    {
        Employee User = new Employee();

        public UserPayroll()
        {
            InitializeComponent();
        }

        private void UserPayroll_Load(object sender, EventArgs e)
        {
            this.BackColor = DefaultColors.White;
            //PnlLeftInfo.BackColor = DefaultColors.InputGray;
            PnlLeftInfo.BackColor = DefaultColors.DarkBlue;

            LblWelcome.ForeColor = DefaultColors.SandyBrown;
            LblIntro.ForeColor = DefaultColors.Gray;

            BtnGeneratePayroll.BackColor = DefaultColors.SandyBrown;
            //BtnGeneratePayroll.FlatStyle = FlatStyle.Flat;
            BtnGeneratePayroll.FlatAppearance.BorderSize = 0;

            DtStart.Value = DateTime.Now.AddMonths(-1);
        }

        public void UpdateUser(Employee User)
        {
            this.User = User;
        }

        private void GeneratePayrollPdf()
        {
            try
            {
                // Configurando PDF
                var pxPerMm = 72 / 25.5F;
                var pdf = new Document(PageSize.A4, 15 * pxPerMm, 15 * pxPerMm, 15 * pxPerMm, 20 * pxPerMm);
                string documentName = BtnFolder.Text == "Selecione o diretório" ? $"D:\\Downloads(D)\\demonstrativo-{DateTime.Now.ToString("yyyy-MM-dd")}-name.pdf" : BtnFolder.Text + $"\\demonstrativo-{DateTime.Now.ToString("yyyy-MM-dd")}-name.pdf";
                var file = new FileStream(documentName, FileMode.Create);
                var writer = PdfWriter.GetInstance(pdf, file);
                pdf.Open();

                var baseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);

                // Titulo
                var pFont = new iTextSharp.text.Font(baseFont, 25, iTextSharp.text.Font.NORMAL, BaseColor.Black);
                var title = new Paragraph("Demonstrativo de Pagamento\n\n", pFont);
                title.Alignment = Element.ALIGN_CENTER;
                pdf.Add(title);

                pFont = new iTextSharp.text.Font(baseFont, 10, iTextSharp.text.Font.NORMAL, BaseColor.Black);
                title = new Paragraph("Empregadora\n", pFont);
                title.SpacingAfter = 5;
                title.Alignment = Element.ALIGN_LEFT;
                pdf.Add(title);

                // Tabela Dados Empresa
                // Linha 1 (Nome e CNPJ)
                var table = new PdfPTable(2);
                table.WidthPercentage = 100;
                table.SetWidths(new float[] { 0.7f, 0.3f });
                table.HorizontalAlignment = Element.ALIGN_CENTER;
                string[] titles = new string[2] { "Nome", "CNPJ" };

                table.HeaderRows = 1;
                table.SpacingBefore = 0;
                table.SpacingAfter = 0;
                table.DefaultCell.BorderWidth = 1;
                table.DefaultCell.BorderColor = BaseColor.Black;

                for (int i = 0; i < 2; i++)
                {
                    PdfPCell headerCell = new PdfPCell(new Phrase(titles[i]));
                    headerCell.Border = PdfPCell.TOP_BORDER | PdfPCell.LEFT_BORDER | PdfPCell.RIGHT_BORDER;
                    table.AddCell(headerCell);
                }

                PdfPCell cells = new PdfPCell(new Phrase("Tz Solucoes em Softwares LTDA"));
                cells.Border = PdfPCell.BOTTOM_BORDER | PdfPCell.LEFT_BORDER | PdfPCell.RIGHT_BORDER;
                table.AddCell(cells);
                cells = new PdfPCell(new Phrase("47.304.645/0001-81"));
                cells.Border = PdfPCell.BOTTOM_BORDER | PdfPCell.LEFT_BORDER | PdfPCell.RIGHT_BORDER;
                table.AddCell(cells);

                pdf.Add(table);

                // Linha 2 (Endereço)
                table = new PdfPTable(2);
                table.WidthPercentage = 100;
                table.SetWidths(new float[] { 0.8f, 0.2f });
                table.HorizontalAlignment = Element.ALIGN_CENTER;
                table.SpacingAfter = 10;
                titles = new string[2] { "Endereço", "Mês/Ano" };

                for (int i = 0; i < 2; i++)
                {
                    PdfPCell headerCell = new PdfPCell(new Phrase(titles[i]));
                    headerCell.Border = PdfPCell.TOP_BORDER | PdfPCell.LEFT_BORDER | PdfPCell.RIGHT_BORDER;
                    table.AddCell(headerCell);
                }

                cells = new PdfPCell(new Phrase("R. Chile, 967 - Jardim Irajá"));
                cells.Border = PdfPCell.BOTTOM_BORDER | PdfPCell.LEFT_BORDER | PdfPCell.RIGHT_BORDER;
                table.AddCell(cells);

                cells = new PdfPCell(new Phrase(DtEnd.Value.ToString("MM/yyyy")));
                cells.Border = PdfPCell.BOTTOM_BORDER | PdfPCell.LEFT_BORDER | PdfPCell.RIGHT_BORDER;
                table.AddCell(cells);

                pdf.Add(table);

                // Formatação para tabela de funcionário
                table.SpacingAfter = 0;
                title = new Paragraph("Funcionário\n", pFont);
                title.SpacingAfter = 5;
                pdf.Add(title);

                // Tabela Dados Funcionário
                table = new PdfPTable(3);
                table.WidthPercentage = 100;
                table.SetWidths(new float[] { 0.6f, 0.2f, 0.2f });
                table.HorizontalAlignment = Element.ALIGN_CENTER;
                table.SpacingAfter = 30;
                titles = new string[3] { "Nome", "CPF", "Cargo" }; //"Email", , "Cargo", "Salário"

                for (int i = 0; i < 3; i++)
                {
                    PdfPCell headerCell = new PdfPCell(new Phrase(titles[i]));
                    headerCell.Border = PdfPCell.TOP_BORDER | PdfPCell.LEFT_BORDER | PdfPCell.RIGHT_BORDER;
                    table.AddCell(headerCell);
                }

                cells = new PdfPCell(new Phrase(User.Id + " - " + User.Name));
                cells.Border = PdfPCell.BOTTOM_BORDER | PdfPCell.LEFT_BORDER | PdfPCell.RIGHT_BORDER;
                table.AddCell(cells);
                cells = new PdfPCell(new Phrase(Convert.ToUInt64(User.CPF).ToString(@"000\.000\.000\-00")));
                cells.Border = PdfPCell.BOTTOM_BORDER | PdfPCell.LEFT_BORDER | PdfPCell.RIGHT_BORDER;
                table.AddCell(cells);
                EmployeeDaoPostgres Epsql = new EmployeeDaoPostgres();
                cells = new PdfPCell(new Phrase(Epsql.SelectRole(User.Id)));
                cells.Border = PdfPCell.BOTTOM_BORDER | PdfPCell.LEFT_BORDER | PdfPCell.RIGHT_BORDER;
                table.AddCell(cells);

                pdf.Add(table);

                // Pagamento
                table = new PdfPTable(5);
                table.WidthPercentage = 100;
                table.SetWidths(new float[] { 0.1f, 0.34f, 0.16f, 0.2f, 0.2f });
                table.HorizontalAlignment = Element.ALIGN_CENTER;
                titles = new string[5] { "Cód", "Descrição", "Referência", "Proventos", "Descontos" };

                for (int i = 0; i < 5; i++)
                {
                    PdfPCell headerCell = new PdfPCell(new Phrase(titles[i]));
                    table.AddCell(headerCell);
                }

                RoleDaoPostgres Rpsql = new RoleDaoPostgres();
                Role role = new Role();
                role = Rpsql.SelectSpecific(User.Role);

                // Salario base
                cells = new PdfPCell(new Phrase("001"));
                table.AddCell(cells);
                cells = new PdfPCell(new Phrase("Salario Base"));
                table.AddCell(cells);
                cells = new PdfPCell(new Phrase(role.Hours.ToString() + "h"));
                table.AddCell(cells);
                cells = new PdfPCell(new Phrase("R$" + role.Wage.ToString("F")));
                table.AddCell(cells);
                cells = new PdfPCell(new Phrase(""));
                table.AddCell(cells);

                int workedHours = GetWorkedHours();
                decimal hourEffect = CalcHourEffect(workedHours, role.Hours, role.Wage);

                decimal totalDeduction = 0;
                decimal totalAddition = role.Wage;

                if (workedHours > role.Hours)
                {
                    // Hora Extra
                    cells = new PdfPCell(new Phrase("009"));
                    table.AddCell(cells);
                    cells = new PdfPCell(new Phrase("Hora Extra"));
                    table.AddCell(cells);
                    cells = new PdfPCell(new Phrase(workedHours.ToString() + "h"));
                    table.AddCell(cells);
                    cells = new PdfPCell(new Phrase("R$" + hourEffect.ToString("F")));
                    table.AddCell(cells);
                    cells = new PdfPCell(new Phrase(""));
                    table.AddCell(cells);
                    totalAddition += hourEffect;
                }
                else if (workedHours < role.Hours)
                {
                    // Dedução
                    cells = new PdfPCell(new Phrase("010"));
                    table.AddCell(cells);
                    cells = new PdfPCell(new Phrase("Dedução"));
                    table.AddCell(cells);
                    cells = new PdfPCell(new Phrase(workedHours.ToString() + "h"));
                    table.AddCell(cells);
                    cells = new PdfPCell(new Phrase(""));
                    table.AddCell(cells);
                    cells = new PdfPCell(new Phrase("R$" + hourEffect.ToString("F")));
                    table.AddCell(cells);
                    totalDeduction += hourEffect;
                }

                // INSS
                cells = new PdfPCell(new Phrase("020"));
                table.AddCell(cells);
                cells = new PdfPCell(new Phrase("INSS"));
                table.AddCell(cells);

                decimal INSS = Rpsql.SelectINSS(User.Role);

                cells = new PdfPCell(new Phrase(INSS.ToString("F") + "%"));
                table.AddCell(cells);
                cells = new PdfPCell(new Phrase(""));
                table.AddCell(cells);

                decimal deductionINSS = CalcINSS(role.Wage, INSS);

                cells = new PdfPCell(new Phrase("R$" + deductionINSS.ToString("F")));
                table.AddCell(cells);

                decimal calcBase = role.Wage - deductionINSS;
                decimal IRRF = GetIRRFPercent(calcBase);

                // IRRF
                cells = new PdfPCell(new Phrase("033"));
                table.AddCell(cells);
                cells = new PdfPCell(new Phrase("IRRF"));
                table.AddCell(cells);
                cells = new PdfPCell(new Phrase(IRRF.ToString("F") + "%"));
                table.AddCell(cells);
                cells = new PdfPCell(new Phrase(""));
                table.AddCell(cells);

                decimal deductionIRRF = CalcIRRF(calcBase);

                cells = new PdfPCell(new Phrase("R$" + deductionIRRF.ToString("F")));
                table.AddCell(cells);

                pdf.Add(table);

                // Totals
                table = new PdfPTable(3);
                table.WidthPercentage = 100;
                table.SetWidths(new float[] { 0.6f, 0.2f, 0.2f });
                table.HorizontalAlignment = Element.ALIGN_CENTER;

                cells = new PdfPCell(new Phrase("TOTAIS:"));
                table.AddCell(cells);

                totalDeduction += deductionIRRF + deductionINSS;

                cells = new PdfPCell(new Phrase("R$" + totalAddition.ToString("F")));
                table.AddCell(cells);
                cells = new PdfPCell(new Phrase("R$" + totalDeduction.ToString("F")));
                table.AddCell(cells);

                pdf.Add(table);

                table = new PdfPTable(3);
                table.WidthPercentage = 100;
                table.SetWidths(new float[] { 0.6f, 0.2f, 0.2f });
                table.HorizontalAlignment = Element.ALIGN_CENTER;

                // Total Líquido
                cells = new PdfPCell(new Phrase("TOTAL LÍQUIDO:"));
                table.AddCell(cells);
                cells = new PdfPCell(new Phrase("R$" + (totalAddition - totalDeduction).ToString("F")));
                table.AddCell(cells);
                cells = new PdfPCell(new Phrase(""));
                table.AddCell(cells);

                pdf.Add(table);

                // Se tiver hora a mais cod de abonação

                pdf.Close();
                file.Close();

                if (File.Exists(documentName))
                {
                    Process.Start
                    (
                        new ProcessStartInfo()
                        {
                            Arguments = $"/c start {documentName}",
                            FileName = "cmd.exe",
                            CreateNoWindow = true
                        }

                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex);
            }
        }

        private int GetWorkedHours()
        {
            DateTime startDate = DtStart.Value;
            DateTime endDate = DtEnd.Value;
            endDate = endDate.AddDays(1).AddTicks(-1);
            //List<string> UserData = new List<string>();
            int hours = 0;

            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                hours += GetDateHours(date);
            }

            return hours;
        }

        PunchInDaoPostgres Ppsql = new PunchInDaoPostgres();

        private int GetDateHours(DateTime date)
        {
            ClockIn? clockIn = Ppsql.SelectSpecific(User.Id, date.Date);

            if (clockIn == null || clockIn.MainClockIn == null)
            {
                return 0;
            }

            TimeSpan start = (TimeSpan)clockIn.MainClockIn;
            TimeSpan end;

            if (clockIn.MainClockOut == null)
            {
                return 0;
            }
            else
            {
                end = (TimeSpan)clockIn.MainClockOut;
            }

            TimeSpan timeElapsed = end - start + ((TimeSpan)clockIn.LunchClockOut - (TimeSpan)clockIn.LunchClockIn);
            return (int)Math.Round(timeElapsed.TotalHours);
        }

        private decimal CalcHourEffect(int workedHours, int referenceHours, decimal wage)
        {
            if (workedHours == 0 || referenceHours == 0)
            {
                return wage;
            }

            return Math.Abs(wage - (wage * workedHours / (decimal)referenceHours));
        }

        private void BtnGeneratePayroll_Click(object sender, EventArgs e)
        {
            GeneratePayrollPdf();
        }

        private void BtnFolder_Click(object sender, EventArgs e)
        {
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = FBD.SelectedPath;
                BtnFolder.Text = selectedPath;
                // Do something with the selected folder path
            }
        }

        private decimal CalcINSS(decimal wage, decimal INSS)
        {
            decimal INSSTop = 7507.49m;

            if (wage > INSSTop)
            {
                wage = wage - INSSTop;
                return wage + (INSSTop * INSS / 100);
            }
            else
            {
                return wage * INSS / 100;
            }
        }

        private decimal CalcIRRF(decimal calcBase)
        {
            if (calcBase <= 1903.98m)
            {
                return 0m;
            }
            else if (calcBase <= 2826.65m)
            {
                calcBase = calcBase * 7.5m / 100;
                calcBase -= 142.8m;
                return calcBase;
            }
            else if (calcBase <= 3751.05m)
            {
                calcBase = calcBase * 15 / 100;
                calcBase -= 354.80m;
                return calcBase;
            }
            else if (calcBase <= 4664.68m)
            {
                calcBase = calcBase * 22.5m / 100;
                calcBase -= 636.13m;
                return calcBase;
            }
            else
            {
                calcBase = calcBase * 27.5m / 100;
                calcBase -= 869.36m;
                return calcBase;
            }
        }

        private decimal GetIRRFPercent(decimal calcBase)
        {
            if (calcBase <= 1903.98m)
            {
                return 0m;
            }
            else if (calcBase <= 2826.65m)
            {
                return 7.5m;
            }
            else if (calcBase <= 3751.05m)
            {
                return 15;
            }
            else if (calcBase <= 4664.68m)
            {
                return 22.5m;
            }
            else
            {
                return 27.5m;
            }
        }
    }
}
