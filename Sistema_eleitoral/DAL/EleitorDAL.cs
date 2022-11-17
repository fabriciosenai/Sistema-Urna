using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EleitorDAL
    {
        public void Inserir(Eleitor _eleitor)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            SqlCommand cmd = cn.CreateCommand();
            try
            {
                cmd.CommandText = @"INSERT INTO Eleitor(Nome, Titulo) 
                              VALUES(@Nome, @Titulo)";
                //cmd.CommandText = "SP_InserirEleitor";
                cmd.Parameters.AddWithValue("@Nome", _eleitor.Nome);
                cmd.Parameters.AddWithValue("@Titulo", _eleitor.Titulo);
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
        public void Excluir(Eleitor _eleitor)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            SqlCommand cmd = cn.CreateCommand();
            try
            {
                cmd.CommandText = "DELETE FROM Eleitor WHERE Id = @Id";
                cmd.Parameters.AddWithValue("@Id", _eleitor.id);
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
        public void Alterar(Eleitor _eleitor)
        {

        }
        public DataTable BuscarPorTitulo(string _titulo)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try 
            {
                ///salvaras
                da.SelectCommand = cn.CreateCommand();
                da.SelectCommand.CommandText = "SELECT Id, Nome, Titulo, Votou, FROM Eleitor WHERE Titulo = @Titulo";
                da.SelectCommand.CommandType = CommandType.Text;
                da.SelectCommand.Parameters.AddWithValue("@Titulo", _titulo);
                cn.Open();
                da.Fill(dt);
                return dt;
            }
            finally
            {
                cn.Close();
                
            }
        }
    }
}


