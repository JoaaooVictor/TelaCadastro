using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using MySql.Data;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg.OpenPgp;
using Org.BouncyCastle.Utilities.Collections;

namespace TelaCadastro
{
    public class Conexao
    {
        #region Comando SQL
        public void BancoDados(string parametro)
        {
            MySqlConnection conecta = new MySqlConnection("server=localhost;User Id=root;database=cadastro; password=Joaozinho21*");
            try
            {
                MySqlCommand comando = new MySqlCommand(parametro, conecta);
                conecta.Open();
                comando.ExecuteNonQuery();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
                conecta.Close();
            }
            finally
            {
                conecta.Close();
            }

        }
        #endregion
    }
}
