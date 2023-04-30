using iTextSharp.text;
using iTextSharp.text.pdf;
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
            PnlLeftInfo.BorderStyle = BorderStyle.FixedSingle;

            BtnGeneratePayroll.BackColor = DefaultColors.SandyBrown;
            BtnGeneratePayroll.ForeColor = DefaultColors.White;
            BtnGeneratePayroll.FlatStyle = FlatStyle.Flat;

            DtStart.Value = DateTime.Now.AddMonths(-1);
        }

        public void UpdateUser(Employee User)
        {
            this.User = User;
        }

        private void generatePayrollPdf()
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

                // Formatação para tabela de usuário
                table.SpacingAfter = 0;

                // Tabela Dados Usuário
                table = new PdfPTable(3);
                table.WidthPercentage = 100;
                table.SetWidths(new float[] { 0.6f, 0.2f, 0.2f });
                table.HorizontalAlignment = Element.ALIGN_CENTER;
                titles = new string[3] {"Nome", "CPF", "Cargo" }; //"Email", , "Cargo", "Salário"

                for (int i = 0; i < 3; i++)
                {
                    PdfPCell headerCell = new PdfPCell(new Phrase(titles[i]));
                    headerCell.Border = PdfPCell.TOP_BORDER | PdfPCell.LEFT_BORDER | PdfPCell.RIGHT_BORDER;
                    table.AddCell(headerCell);
                }

                cells = new PdfPCell(new Phrase(User.Id + " - " + User.Name));
                cells.Border = PdfPCell.BOTTOM_BORDER | PdfPCell.LEFT_BORDER | PdfPCell.RIGHT_BORDER;
                table.AddCell(cells);
                cells = new PdfPCell(new Phrase(User.CPF));
                cells.Border = PdfPCell.BOTTOM_BORDER | PdfPCell.LEFT_BORDER | PdfPCell.RIGHT_BORDER;
                table.AddCell(cells);
                EmployeeDaoPostgres Epsql = new EmployeeDaoPostgres();
                cells = new PdfPCell(new Phrase(Epsql.SelectRole(User.Id)));
                cells.Border = PdfPCell.BOTTOM_BORDER | PdfPCell.LEFT_BORDER | PdfPCell.RIGHT_BORDER;
                table.AddCell(cells);

                pdf.Add(table);

                pdf.Close();
                file.Close();

                //var pdfPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, documentName); //C:\\SDH\\demonstrativos\\
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

        private void UserDataList()
        {
            DateTime startDate = DtStart.Value;
            DateTime endDate = DtEnd.Value;
            List<string> UserData = new List<string>();

            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                Console.WriteLine(date.ToShortDateString());
            }
        }

        private void GetUserData(DateTime date)
        {

        }

        private void BtnGeneratePayroll_Click(object sender, EventArgs e)
        {
            generatePayrollPdf();
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
    }
}
