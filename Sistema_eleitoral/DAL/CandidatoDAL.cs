using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{

    public class CandidatoDAL
    {
        public void Inserir(Candidato _candidato)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            SqlCommand cmd = cn.CreateCommand();
            try
            {
                cmd.CommandText = @"INSERT INTO Candidato(nome,numero) 
                              VALUES(@nome, @numero)";
                //cmd.CommandText = "SP_InserirEleitor";
                cmd.Parameters.AddWithValue("@nome", _candidato.Nome);
                cmd.Parameters.AddWithValue("@numero", _candidato.NumeroCandidato);
                //cmd.Commandtype = CommandType.StoredProcedure;
                cmd.CommandType = CommandType.Text;

                cn.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
        public void Excluir(Candidato _candidato)
        {

        }
        public void Alterar(Candidato _candidato)
        {

        }
        public List<Candidato> Buscar(string _titulo)
        {
            return new List<Candidato>();
        }
    }
}

