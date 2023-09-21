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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente x = new Cliente();
            x.Show();
            this.Visible = false;
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produto x = new Produto();
            x.Show();
            this.Visible = false;

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair do sistema?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RelatorioCliente x = new RelatorioCliente();
            x.Show();
            this.Visible = false;
        }

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RelatorioProduto x = new RelatorioProduto();
            x.Show();
            this.Visible = false;
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }


    

       

  

      
    }
}
