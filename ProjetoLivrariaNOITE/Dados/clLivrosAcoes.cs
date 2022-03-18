using MySql.Data.MySqlClient;
using ProjetoLivrariaNOITE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoLivrariaNOITE.Dados
{
    public class clLivrosAcoes
    {// instanciando objeto para a classe de conexão
        conexao con = new conexao();

        public void inserirLivro(ClLivros cm) // cm: É um objeto que vai trazer as "VARIAVEIS DO MODELO".
        {
            MySqlCommand cmd = new MySqlCommand("insert into tbLivro (nomeLivro, codAutor) values (@nome, @codAutor)", con.MyConectarBD()); // @: PARAMETRO


            cmd.Parameters.Add("@nome",
                MySqlDbType.VarChar).Value = cm.nomeLivro;
            cmd.Parameters.Add("@codAutor", MySqlDbType.VarChar).Value = cm.codAutor;

            // nomeCli e telCli: São variaveis

            cmd.ExecuteNonQuery();
            con.MyDesConectarBD();

        }

        public void inserirAutor(ClLivros cm) // cm: É um objeto que vai trazer as "VARIAVEIS DO MODELO".
        {
            MySqlCommand cmd = new MySqlCommand("insert into tbAutor (nomeAutor, sta) values (@nomeAutor, @sta)", con.MyConectarBD()); // @: PARAMETRO


            cmd.Parameters.Add("@nomeAutor",MySqlDbType.VarChar).Value = cm.nomeAutor;
            cmd.Parameters.Add("@sta", MySqlDbType.VarChar).Value = cm.sta;

            // nomeCli e telCli: São variaveis

            cmd.ExecuteNonQuery();
            con.MyDesConectarBD();
         

        }



    }
}