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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }
        String sexo;
        String mascaraCPF;
        String DataFormatada;
        String dt = "";

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btsalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtcpf.Text == "")
                {
                    MessageBox.Show("Informe o CPF", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtcpf.Focus();
                }
                else if (txtnome.Text == "")
                {
                    MessageBox.Show("Informe o Nome", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtnome.Focus();
                }
                else if (txtemail.Text == "")
                {
                    MessageBox.Show("Informe o E-mail", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtemail.Focus();

                }
                else if (txttelefone.Text == "")
                {
                    MessageBox.Show("Informe o Telefone", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txttelefone.Focus();
                }
                else if (cbestado.Text == "")
                {
                    MessageBox.Show("Informe o estado", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbestado.Focus();
                }
                else if (txtdata.Text == "")
                {
                    MessageBox.Show("Informe a data de nascimento", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbestado.Focus();
                }
                else
                {
                    //DateTime.Parse("yyyyMMdd");
                    DateTime data = DateTime.Now;
                    //DataFormatada = data.ToString("dd/MM/yyyy"); 
                    //txtdata.Text = Convert.Parse(dt).ToString("yyyy/MM/dd");
                    DataFormatada = Convert.ToDateTime(DataFormatada).ToString("yyyy/MM/dd");

                    txtcpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    mascaraCPF = txtcpf.Text;
                    Conexao.cmd.CommandText = "INSERT INTO tbl_cliente(cpf,nome,email,telefone,estado,sexo,data) VALUES ('" + mascaraCPF + "','" + txtnome.Text + "','" + txtemail.Text + "','" + txttelefone.Text + "','" + cbestado.Text + "', '" + sexo + "', '" + DataFormatada + "')";
                    Conexao.cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro feito com sucesso!!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregaListClient();
                    btlimpar.PerformClick();                    
                    DataFormatada = DateTime.Parse(txtdata.Text).ToString("dd/MM/yyyy");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void rbmasculino_CheckedChanged(object sender, EventArgs e)
        {
            sexo = "Masculino";
        }

        private void rbfeminino_CheckedChanged(object sender, EventArgs e)
        {
            sexo = "Feminino";
        }

        private void btoutros_CheckedChanged(object sender, EventArgs e)
        {
            sexo = "Outros";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //Conexao.Conectar();
                txtcpf.Mask = "000,000,000-00";
                //txtdata.Mask = "00/00/0000";
                CarregaComboEstado();
                CarregaListClient();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //fecha

        //Método para carregar dados da combo box "estado"
        public void CarregaComboEstado()
        {
            try
            {
                //abre a conexão e envia o comando do select para o banco 
                Conexao.cmd.CommandText = "SELECT * FROM tbl_estado";
                Conexao.reader = Conexao.cmd.ExecuteReader();
                /*Retorna os dados, então é necessário solicitar ao objeto reader
                 para realizar a leitura dos dados vindos do banco*/
                while (Conexao.reader.Read())
                
                {
                    cbestado.Items.Add(Conexao.reader["nomestado"].ToString());
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
            txtcpf.Text = "";
            txtemail.Text = "";
            txttelefone.Text = "";
            txtnome.Text = "";
            cbestado.Text = "";
            rbfeminino.Checked = false;
            rbmasculino.Checked = false;
            btoutros.Checked = false;
            txtdata.Text = "";
            txtcpf.Focus();
        }

        private void btsair_Click(object sender, EventArgs e)
        {
            Menu x = new Menu();
            x.Show();
            this.Visible = false;

            
        }

        //Método para carregar os dados da list view

        public void CarregaListClient()
        {
            try
            {
                //limpa os dados da list antes de adicionar outros
                lstCliente.Items.Clear();

                if (txtpesquisa.Text == "")
                {
                    //Caso a caixa de texto "pesquisar" esteja vazia, são carregadaos todos os dados do banco em ordem alfabética
                    Conexao.cmd.CommandText = "SELECT * FROM tbl_cliente ORDER BY nome ASC";

                }
                else 
                {
                    //Realiza a busca de acordo com os dados escritos na caixa de pesquisa
                    Conexao.cmd.CommandText = "SELECT * FROM tbl_cliente WHERE nome LIKE '"+txtpesquisa.Text+"%' ORDER BY nome ASC";
                    
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
                    //DateTime.Now.ToString("dd/MM/yyyy");                      
                    //DataFormatada = Convert.ToDateTime(txtdata).ToString("yyyy/MM/dd
                                     
                    list.SubItems.Add(Conexao.reader[6].ToString());

                    lstCliente.Items.AddRange(new ListViewItem[] { list });
                }

                Conexao.reader.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            
            }
    }

        private void txtpesquisa_TextChanged(object sender, EventArgs e)
        {
            CarregaListClient();
        }

        private void lstCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtcpf.Enabled = false;
                txtdata.Enabled = false;
                txtcpf.Text = lstCliente.Items[lstCliente.FocusedItem.Index].SubItems[0].Text;
                txtnome.Text = lstCliente.Items[lstCliente.FocusedItem.Index].SubItems[1].Text;
                txtemail.Text = lstCliente.Items[lstCliente.FocusedItem.Index].SubItems[2].Text;
                txttelefone.Text = lstCliente.Items[lstCliente.FocusedItem.Index].SubItems[3].Text;
                txtdata.Text = lstCliente.Items[lstCliente.FocusedItem.Index].SubItems[4].Text;



            }
            catch (Exception)
            {
                MessageBox.Show("Não existem dados no banco.","Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtcpf.Text == "")
                {
                    MessageBox.Show("Informe o CPF", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtcpf.Focus();
                }
                else if (txtnome.Text == "")
                {
                    MessageBox.Show("Informe o Nome", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtnome.Focus();
                }
                else if (txtemail.Text == "")
                {
                    MessageBox.Show("Informe o E-mail", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtemail.Focus();

                }
                else if (txttelefone.Text == "")
                {
                    MessageBox.Show("Informe o Telefone", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txttelefone.Focus();
                }
                else if (cbestado.Text == "")
                {
                    MessageBox.Show("Informe o estado", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbestado.Focus();
                }
                else
                {
                    Conexao.cmd.CommandText = "UPDATE tbl_cliente SET nome = '" + txtnome.Text + "', email = '" + txttelefone.Text + "', estado = '" + cbestado.Text + "', sexo = '" + sexo + "' WHERE cpf= '" + lstCliente.Items[lstCliente.FocusedItem.Index].Text + "'";

                    Conexao.cmd.ExecuteNonQuery();
                    MessageBox.Show("Alteração feita com sucesso!!", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregaListClient();
                    btlimpar.PerformClick();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja realmente excluir os dados?", "excluir", MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                try 
                {
                    Conexao.cmd.CommandText = "DELETE FROM tbl_cliente WHERE cpf='" + lstCliente.Items[lstCliente.FocusedItem.Index].Text + "'";
                    Conexao.cmd.ExecuteNonQuery();
                    MessageBox.Show("Os dados foram deletados com sucesso!!", "Deletar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregaListClient();
                    btlimpar.PerformClick();
                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
                }
            }

        private void txtcpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //Verifica se o numero digitado coincide com os 11 dígitos do CPF
            toolTip1.ToolTipTitle = "Número informado inválido";
            toolTip1.Show("Somente digitos de (0-9) são permitidos.",txtcpf,txtcpf.Location, 5000);
        }

        private void rbValidarCPF_CheckedChanged(object sender, EventArgs e)
        {
            /*
            txtcpf.Text = "";
            txtcpf.Mask = "000.000.000-00";
            txtcpf.MaskInputRejected += new MaskInputRejectedEventHandler(txtcpf_MaskInputRejected);
            */
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            /*
            string valor = txtcpf.Text;
            if (rbValidarCPF.Checked)
            {
                if (ValidacaoCPF.IsCpf(valor))
                {
                    MessageBox.Show("O número é o CPF válido");
                }
                else {
                    MessageBox.Show("O número do CPF é inválido");
                }    
            }
            */
        }

        //Método para a classe de Validação do CPF
        public void ValidaCPF()
        {
            if (!txtcpf.MaskCompleted)
            {
                MessageBox.Show("O campo incompleto!");
            }
            else 
            {
                if (!ValidacaoCPF.IsCpf(txtcpf.Text))
                {
                    MessageBox.Show("CPF válido!");
                    txtcpf.Focus();
                }
                else 
                {
                    MessageBox.Show("CPF Inválido");
                }
            }
        }

        private void txtcpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                this.ValidaCPF();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }
     



        } 
    }
