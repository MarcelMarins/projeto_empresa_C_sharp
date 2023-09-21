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
    public partial class RelatorioCliente : Form
    {
        public RelatorioCliente()
        {
            InitializeComponent();
        }
        Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();

        private void DgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RelatorioCliente_Load(object sender, EventArgs e)
        {

        }

        //Carrega dados da datagridview
        public void CarregaGrid(DataGridView data)
        {
            Conexao.Conectar();
            Conexao.cmd.CommandText = "SELECT * FROM tbl_cliente";
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = Conexao.cmd;
                DataTable dgvCliente = new DataTable();
                adapter.Fill(dgvCliente);
                BindingSource RelatorioCliente = new BindingSource();
                RelatorioCliente.DataSource = dgvCliente;
                data.DataSource = RelatorioCliente;
                adapter.Update(dgvCliente);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            CarregaGrid(DgvCliente);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Menu x = new Menu();
            x.Show();
            this.Visible = false;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {  
                if (DgvCliente.Rows.Count > 0)
                {
                    try
                    {
                        XcelApp.Application.Workbooks.Add(Type.Missing);
                        for (int i = 1; i < DgvCliente.Columns.Count + 1; i++)
                        {
                            XcelApp.Cells[1, i] = DgvCliente.Columns[i - 1].HeaderText;
                        }
                        //
                        for (int i = 0; i < DgvCliente.Rows.Count - 1; i++)
                        {
                            for (int j = 0; j < DgvCliente.Columns.Count; j++)
                            {
                                XcelApp.Cells[i + 2, j + 1] = DgvCliente.Rows[i].Cells[j].Value.ToString();
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
            exportgridpdf(DgvCliente, "Documento");
        }

        //Metodo para Gerar em PDF
        public void exportgridpdf(DataGridView DgvCliente, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdftable = new PdfPTable(DgvCliente.Columns.Count);
            pdftable.DefaultCell.Padding = 3;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.DefaultCell.BorderWidth = 1;


            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);

            foreach (DataGridViewColumn column in DgvCliente.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                //cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
                pdftable.AddCell(cell);

            }

            foreach (DataGridViewRow row in DgvCliente.Rows)
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

        private void btnImprimir_Click(object sender, EventArgs e)
        {     
            printDGV.Print_DataGridView(DgvCliente);
        }

/*private static void DrawFooter(System.Drawing.Printing.PrintPageEventArgs e,
            int RowsPerPage)
{
    double cnt = 0;

    // Determina o número de linhas a imprimir
    if (PrintAllRows)
    {
        if (dgv.Rows[dgv.Rows.Count - 1].IsNewRow)
            cnt = dgv.Rows.Count - 2; // Quando o DataGridView NÃO permite adicionar linhas
        else
            cnt = dgv.Rows.Count - 1; // Quando o DataGridView permite adicionar linhas
    }
    else
        cnt = dgv.SelectedRows.Count;

    // Escreve o número da página
    string PageNum = PageNo.ToString() + " de " +
        Math.Ceiling((double)(cnt / RowsPerPage)).ToString();

    e.Graphics.DrawString(PageNum, dgv.Font, Brushes.Black,
        e.MarginBounds.Left + (e.MarginBounds.Width -
        e.Graphics.MeasureString(PageNum, dgv.Font,
        e.MarginBounds.Width).Width) / 2, e.MarginBounds.Top +
        e.MarginBounds.Height + 31);
}

    }*/
           
        }

}
    
    
    
