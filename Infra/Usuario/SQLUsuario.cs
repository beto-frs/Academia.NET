using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra
{
    public class SQLUsuario :Database,ISQLUsuario
    {
        private string sqlUsuarios = "SELECT [Id][ID],[Usuario][NOME],[Senha][SENHA DIGITADA],[Senha][SENHA CRIPTOGRAFADA] FROM Usuarios";
        public bool AtualizarDados(string[] dados)
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


            for (int i = 0; i < dados.Length; i++)
            {
                command.Parameters[i].Value = dados[i];
            }

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                FecharConexao();
            }
        }

        public bool ExcluirDados(string[] dados)
        {
            SqlConnection cn = AbrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            int cont = dados.Length - 1;
            command.CommandText = "DELETE FROM Pessoas where id = @id";
            command.Parameters.Add("@id", SqlDbType.Int);
            command.Parameters[0].Value = dados[cont];
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

        public bool IncluirDados(string[] dados)
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

            for (int i = 1; i < (dados.Length); i++)
            {
                command.Parameters[(i - 1)].Value = dados[i];
            }

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

                SqlCommand command = new SqlCommand(sqlUsuarios, cn);
                command.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception)
            {

                return null; ;
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
