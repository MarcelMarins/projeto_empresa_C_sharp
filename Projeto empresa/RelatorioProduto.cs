using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_empresa
{
    public partial class RelatorioProduto : Form
    {
        public RelatorioProduto()
        {
            InitializeComponent();
        }

        Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();

        public void CarregaGrid(DataGridView data)
        {
            Conexao.Conectar();
            Conexao.cmd.CommandText = "SELECT * FROM tbl_produto";
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = Conexao.cmd;
                DataTable DgvProduto = new DataTable();
                adapter.Fill(DgvProduto);
                BindingSource RelatorioCliente = new BindingSource();
                RelatorioCliente.DataSource = DgvProduto;
                data.DataSource = RelatorioCliente;
                adapter.Update(DgvProduto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }





        private void btnGerar_Click(object sender, EventArgs e)
        {
            CarregaGrid(DgvProduto);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (DgvProduto.Rows.Count > 0)
            {
                try
                {
                    XcelApp.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < DgvProduto.Columns.Count + 1; i++)
                    {
                        XcelApp.Cells[1, i] = DgvProduto.Columns[i - 1].HeaderText;
                    }
                    //
                    for (int i = 0; i < DgvProduto.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < DgvProduto.Columns.Count; j++)
                        {
                            XcelApp.Cells[i + 2, j + 1] = DgvProduto.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    //
                    XcelApp.Columns.AutoFit();
                    //
                    XcelApp.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                    XcelApp.Quit();
                }
            }
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            exportgridpdf(DgvProduto, "Documento");
        }

        //Metodo para Gerar em PDF
        public void exportgridpdf(DataGridView DgvProduto, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdftable = new PdfPTable(DgvProduto.Columns.Count);
            pdftable.DefaultCell.Padding = 3;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.DefaultCell.BorderWidth = 1;


            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);

            foreach (DataGridViewColumn column in DgvProduto.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                //cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
                pdftable.AddCell(cell);

            }

            foreach (DataGridViewRow row in DgvProduto.Rows)
            {

                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdftable.AddCell(new Phrase(cell.Value.ToString(), text));
                }

            }


            var savefiledialoge = new SaveFileDialog();
            savefiledialoge.FileName = filename;
            savefiledialoge.DefaultExt = ".pdf";
            if (savefiledialoge.ShowDialog() == DialogResult.OK)
            {

                using (FileStream stream = new FileStream(savefiledialoge.FileName, FileMode.Create))
                {

                    Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(pdftable);
                    pdfdoc.Close();
                    stream.Close();
                }
            }
        }

        private void btnPDF_Click_1(object sender, EventArgs e)
        {
            exportgridpdf(DgvProduto, "Documento");
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printDGV.Print_DataGridView(DgvProduto);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Menu x = new Menu();
            x.Show();
            this.Visible = false;
        }
    }
}
