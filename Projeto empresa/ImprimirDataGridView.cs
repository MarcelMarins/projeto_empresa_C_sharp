using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_empresa
{
    public partial class ImprimirDataGridView : Form
    {
        public ImprimirDataGridView()
        {
            InitializeComponent();
        }

        public ImprimirDataGridView(List<string>availabeFields)
        {
            InitializeComponent();
            foreach (string field in availabeFields)
                chklst.Items.Add(field, true);
        }

        public List<string> GetSelectedColumns()
        {
            List<string> lst = new List<string>();
            foreach (object item in chklst.CheckedItems)
                lst.Add(item.ToString());
            return lst;
        }

        public string PrintTitle 
        {
            get { return txtTitle.Text; } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAceitar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ImprimirDataGridView_Load(object sender, EventArgs e)
        {

        }
    }
}
