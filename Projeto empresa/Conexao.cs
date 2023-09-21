using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms; // importação da biblio do MySql

namespace Projeto_empresa
{
    class Conexao
    {
        public static MySqlConnection con = new MySqlConnection();//Objeto de conexão
        public static MySqlCommand cmd = new MySqlCommand();//Objeto para enviar comandos.
        public static MySqlDataReader reader;//Objeto para a leitura dos dados.

        public static void Conectar()
        {
            try
            {
                con.ConnectionString = "Server=localhost; User id=root; Database=empresa_marcel; password=root";
                //Linha de conexão com o banco de dados
                cmd.Connection = con;
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
