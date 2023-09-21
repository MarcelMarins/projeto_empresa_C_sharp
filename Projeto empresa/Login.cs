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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public static string varlogin, varsenha;

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();
                Conexao.cmd.CommandText = "SELECT * FROM tbl_cliente WHERE email='" + txtLogin.Text + "' AND cpf='" + txtSenha.Text + "';";
                Conexao.reader = Conexao.cmd.ExecuteReader();
                if (Conexao.reader.Read())
                {
                    varlogin = Conexao.reader["email"].ToString();
                    varsenha = Conexao.reader["cpf"].ToString();

                    new Menu().Visible = true;
                    Hide();
                }
                else
                {
                    MessageBox.Show("Login ou senha inválidos");
                    txtLogin.Text = "";
                    txtSenha.Text = "";
                    Conexao.con.Close();
                }//Fecha o if
                Conexao.reader.Close();
            }//Fecha try 
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        private void lnklblCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cliente x = new Cliente();
            x.Show();
            this.Visible = false;
        }

        
    }
}
