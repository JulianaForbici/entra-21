
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.BancoDados01.Ado.Nett.BancoDados
{
    internal class Conexao
    {
        public SqlConnection Conectar()
        {

            //Instanciando um objeto da classe SqlConnection, que permitirá fazer selects, inserts, updates, deletes...
            SqlConnection conexao = new SqlConnection();

            // String que contém o caminho para o banco de dados, o que permitirá conectar ao banco de dados
            var connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\\Server\c#-noturno\juliana.forbici\Desktop\ExemploBancoDados01ADONET.mdf;Integrated Security=True;Connect Timeout=30";

            // Definir o caminho da conexão para o SqlConnection
            conexao.ConnectionString = connectionString;

            // Abrir a conexão com o banco de dados
            conexao.Open();

            return conexao;
        }
    }
}
