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
    public partial class Produto : Form
    {
        public Produto()
        {
            InitializeComponent();
        }
        String mascaraCNPJ;

        private void btsalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtnomedoproduto.Text == "")
                {
                    MessageBox.Show("Informe o nome do produto", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtnomedoproduto.Focus();
                }
                else if (cbcategoria.Text == "")
                {
                    MessageBox.Show("Escolha a categoria", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbcategoria.Focus();
                }
                else if (txtdescricao.Text == "")
                {
                    MessageBox.Show("Informe a descrição", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtdescricao.Focus();

                }
                else if (txtpreco.Text == "")
                {
                    MessageBox.Show("Informe o preço unitário", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtpreco.Focus();
                }
                else if (txtcnpj.Text == "")
                {
                    MessageBox.Show("Informe o CNPJ", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtcnpj.Focus();
                }

                else
                {
                    txtcnpj.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    mascaraCNPJ = txtcnpj.Text;

                    Conexao.cmd.CommandText = "INSERT INTO tbl_produto(nomeproduto,categoria,descricao,precounitario, cnpj) VALUES ('" + txtnomedoproduto.Text + "','" + cbcategoria.Text + "','" + txtdescricao.Text + "','" + txtpreco.Text + "','" + mascaraCNPJ+ "')";
                    
                    
                    Conexao.cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro de produto feito com sucesso!!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregaListProduto();
                    btlimpar.PerformClick();

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //----------------------------------------------------



        }

        private void Produto_Load(object sender, EventArgs e)
        {
            try
            {
                //Conexao.Conectar();
                txtcnpj.Mask = "00.000.000/0000-00";
                CarregaListProduto();
                CarregaComboCategoria();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void CarregaComboCategoria()
        {
            try
            {
                //abre a conexão e envia o comando do select para o banco 
                Conexao.cmd.CommandText = "SELECT * FROM tbl_categoria";
                Conexao.reader = Conexao.cmd.ExecuteReader();
                /*Retorna os dados, então é necessário solicitar ao objeto reader
                 para realizar a leitura dos dados vindos do banco*/
                while (Conexao.reader.Read())
                {
                    cbcategoria.Items.Add(Conexao.reader["nomecategoria"].ToString());
                    //Combobox tem seus itens adicionados pelas informações vindas do banco.
                }
                Conexao.reader.Close();
                //fecha a conexão da leitura

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
       

        private void btlimpar_Click(object sender, EventArgs e)
        {
            txtdescricao.Text = "";
            txtnomedoproduto.Text = "";
            txtpesquisa.Text = "";
            txtpreco.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
       }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir os dados?", "excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Conexao.cmd.CommandText = "DELETE FROM tbl_produto WHERE codproduto='" + lstProduto.Items[lstProduto.FocusedItem.Index].Text + "'";
                    Conexao.cmd.ExecuteNonQuery();
                    MessageBox.Show("Os dados foram deletados com sucesso!!", "Deletar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregaListProduto();
                    btlimpar.PerformClick();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }
            }
        }

        public void CarregaListProduto()
        {
            try
            {
                //limpa os dados da list antes de adicionar outros
                lstProduto.Items.Clear();

                if (txtpesquisa.Text == "")
                {
                    //Caso a caixa de texto "pesquisar" esteja vazia, são carregadaos todos os dados do banco em ordem alfabética
                    Conexao.cmd.CommandText = "SELECT * FROM tbl_produto ORDER BY nomeproduto ASC";

                }
                else
                {
                    //Realiza a busca de acordo com os dados escritos na caixa de pesquisa
                    Conexao.cmd.CommandText = "SELECT * FROM tbl_produto WHERE nomeproduto LIKE '" + txtpesquisa.Text + "%' ORDER BY nomeproduto ASC";

                }
                Conexao.reader = Conexao.cmd.ExecuteReader();

                while (Conexao.reader.Read())
                {
                    //Objeto que liga o componente ListView com a base de dados 
                    ListViewItem list = new ListViewItem(Conexao.reader[0].ToString());
                    //Preenchimento da list view com os dados do banco
                    list.SubItems.Add(Conexao.reader[1].ToString());
                    list.SubItems.Add(Conexao.reader[2].ToString());
                    list.SubItems.Add(Conexao.reader[3].ToString());
                    list.SubItems.Add(Conexao.reader[4].ToString());
                    list.SubItems.Add(Conexao.reader[5].ToString());
                    lstProduto.Items.AddRange(new ListViewItem[] { list });
                }

                Conexao.reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }




        private void txtpesquisa_TextChanged(object sender, EventArgs e)
        {
            CarregaListProduto();
        }

        private void lstProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lstCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtcnpj.Enabled = false;
                txtnomedoproduto.Text = lstProduto.Items[lstProduto.FocusedItem.Index].SubItems[1].Text;
                cbcategoria.Text = lstProduto.Items[lstProduto.FocusedItem.Index].SubItems[2].Text;
                txtdescricao.Text = lstProduto.Items[lstProduto.FocusedItem.Index].SubItems[3].Text;
                txtpreco.Text = lstProduto.Items[lstProduto.FocusedItem.Index].SubItems[4].Text;
                txtcnpj.Text = lstProduto.Items[lstProduto.FocusedItem.Index].SubItems[5].Text;




            }
            catch (Exception)
            {
                MessageBox.Show("Não existem dados no banco.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

       
       

            private void btnsair_Click_1(object sender, EventArgs e)
            {
                Menu x = new Menu();
                x.Show();
                this.Visible = false;
            }


            

            private void txtdescricao_TextChanged(object sender, EventArgs e)
            {

            }

            private void cbcategoria_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void label1_Click(object sender, EventArgs e)
            {

            }

            private void btnEditar_Click(object sender, EventArgs e)
            {
                try
                {
                    if (txtnomedoproduto.Text == "")
                    {
                        MessageBox.Show("Informe o nome do produto", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtnomedoproduto.Focus();
                    }
                    else if (cbcategoria.Text == "")
                    {
                        MessageBox.Show("Escolha a categoria", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cbcategoria.Focus();
                    }
                    else if (txtdescricao.Text == "")
                    {
                        MessageBox.Show("Informe a descrição", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtdescricao.Focus();

                    }
                    else if (txtpreco.Text == "")
                    {
                        MessageBox.Show("Informe o preço unitário", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtpreco.Focus();
                    }
                    else if (txtcnpj.Text == "")
                    {
                        MessageBox.Show("Informe o CNPJ", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtcnpj.Focus();
                    }
                    else
                    {
                        Conexao.cmd.CommandText = "UPDATE tbl_produto SET nomeproduto = '" + txtnomedoproduto.Text + "', categoria = '" + cbcategoria.Text + "', descricao = '" + txtdescricao.Text + "', precounitario = '" + txtpreco + "', precounitario = '" + txtcnpj + "' WHERE cnpj='" + lstProduto.Items[lstProduto.FocusedItem.Index].Text + "'";

                        Conexao.cmd.ExecuteNonQuery();
                        MessageBox.Show("Alteração feita com sucesso!!", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregaListProduto();
                        btlimpar.PerformClick();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

         

            private void txtcnpj_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
            {
                toolTip1.ToolTipTitle = "Número informado inválido";
                toolTip1.Show("Somente digitos de (0-14) são permitidos.", txtcnpj, txtcnpj.Location, 5000);
            }

            public void ValidaCNPJ()
            {
                if (!txtcnpj.MaskCompleted)
                {
                    MessageBox.Show("O campo incompleto!");
                }
                else
                {
                    if (!ValidacaoCPF.IsCpf(txtcnpj.Text))
                    {
                        MessageBox.Show("CNPJ válido!");
                        txtcnpj.Focus();
                    }
                    else
                    {
                        MessageBox.Show("CNPJ Inválido");
                    }
                }
            }

            private void txtcnpj_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (e.KeyChar == 13)
                    this.ValidaCNPJ();   
            }




      

        
    }
}
