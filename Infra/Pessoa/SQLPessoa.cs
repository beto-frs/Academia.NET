using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra
{
    public class SQLPessoa : Database, ISQLPessoa
    {
        private string sqlPessoas = "SELECT [Id][ID],[Nome][NOME],[Telefone][TELEFONE],[Cidade][CIDADE],[RG],[CPF] FROM Pessoas";


        public bool AtualizarDados(PessoaModel pessoa)
        {
            SqlConnection cn = AbrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;

            command.CommandText = "UPDATE Pessoas set Nome = @nome, Telefone = @telefone, Cidade = @cidade, RG = @rg, CPF = @cpf where Id = @id";

            command.Parameters.Add("@nome", SqlDbType.VarChar);
            command.Parameters.Add("@telefone", SqlDbType.VarChar);
            command.Parameters.Add("@cidade", SqlDbType.VarChar);
            command.Parameters.Add("@rg", SqlDbType.VarChar);
            command.Parameters.Add("@cpf", SqlDbType.VarChar);
            command.Parameters.Add("@id", SqlDbType.Int);

            command.Parameters[0].Value = pessoa._nome;
            command.Parameters[1].Value = pessoa._telefone;
            command.Parameters[2].Value = pessoa._cidade;
            command.Parameters[3].Value = pessoa._rg;
            command.Parameters[4].Value = pessoa._cpf;
            command.Parameters[5].Value = pessoa._id;

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                FecharConexao();
            }
        }

        public bool ExcluirDados(string id)
        {
            SqlConnection cn = AbrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM Pessoas where id = @id";
            command.Parameters.Add("@id", SqlDbType.Int);
            command.Parameters[0].Value = id;
            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch
            {
               
                tran.Rollback();
                return false;
            }
            finally
            {
                FecharConexao();
            }
        }

        public bool IncluirDados(PessoaModel pessoa)
        {
            
            SqlConnection cn = AbrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;

            command.CommandText = "INSERT INTO Pessoas values(@nome, @telefone, @cidade, @rg, @cpf)";

            command.Parameters.Add("@nome", SqlDbType.VarChar);
            command.Parameters.Add("@telefone", SqlDbType.VarChar);
            command.Parameters.Add("@cidade", SqlDbType.VarChar);
            command.Parameters.Add("@rg", SqlDbType.VarChar);
            command.Parameters.Add("@cpf", SqlDbType.VarChar);

            command.Parameters[0].Value = pessoa._nome;
            command.Parameters[1].Value = pessoa._telefone;
            command.Parameters[2].Value = pessoa._cidade;
            command.Parameters[3].Value = pessoa._rg;
            command.Parameters[4].Value = pessoa._cpf;


            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                FecharConexao();
            }


        }

        public DataTable ExecutarConsulta()
        {
            try
            {
                AbrirConexao();

                SqlCommand command = new SqlCommand(sqlPessoas, cn);
                command.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch
            {

                return null;
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
