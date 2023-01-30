using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra
{
    public class SQLAluno : Database, ISQLAluno
    {
        private string sqlAlunos = "SELECT [Id][ID],[Nome][NOME],[Telefone][TELEFONE],[Cidade][CIDADE],[RG],[CPF],[Matricula][MATRÍCULA],[Codigo_Curso][CÓDIGO],[Nome_Curso][CURSO] FROM Alunos";
        public bool AtualizarDados(AlunoModel aluno)
        {
            SqlConnection cn = AbrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;

            command.CommandText = "UPDATE Alunos set Nome = @nome, Telefone = @telefone, Cidade = @cidade, RG = @rg, CPF = @cpf, Matricula = @matricula, Codigo_Curso = @codigo, Nome_Curso = @curso where Id = @id";

            command.Parameters.Add("@nome", SqlDbType.VarChar);
            command.Parameters.Add("@telefone", SqlDbType.VarChar);
            command.Parameters.Add("@cidade", SqlDbType.VarChar);
            command.Parameters.Add("@rg", SqlDbType.VarChar);
            command.Parameters.Add("@cpf", SqlDbType.VarChar);
            command.Parameters.Add("@matricula", SqlDbType.VarChar);
            command.Parameters.Add("@codigo", SqlDbType.VarChar);
            command.Parameters.Add("@curso", SqlDbType.VarChar);
            command.Parameters.Add("@id", SqlDbType.Int);

            command.Parameters[0].Value = aluno._nome;
            command.Parameters[1].Value = aluno._telefone;
            command.Parameters[2].Value = aluno._cidade;
            command.Parameters[3].Value = aluno._rg;
            command.Parameters[4].Value = aluno._cpf;
            command.Parameters[5].Value = aluno._matricula;
            command.Parameters[6].Value = aluno._codigoCurso;
            command.Parameters[7].Value = aluno._nomeCurso;
            command.Parameters[8].Value = aluno._id;
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

        public bool ExcluirDados(string id)
        {
            SqlConnection cn = AbrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM Alunos where id = @id";
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

        public bool IncluirDados(AlunoModel aluno)
        {
            SqlConnection cn = AbrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;

            command.CommandText = "INSERT INTO Alunos values(@nome, @telefone, @cidade, @rg, @cpf, @matricula, @codigo, @curso )";

            command.Parameters.Add("@nome", SqlDbType.VarChar);
            command.Parameters.Add("@telefone", SqlDbType.VarChar);
            command.Parameters.Add("@cidade", SqlDbType.VarChar);
            command.Parameters.Add("@rg", SqlDbType.VarChar);
            command.Parameters.Add("@cpf", SqlDbType.VarChar);
            command.Parameters.Add("@matricula", SqlDbType.VarChar);
            command.Parameters.Add("@codigo", SqlDbType.VarChar);
            command.Parameters.Add("@curso", SqlDbType.VarChar);

            command.Parameters[0].Value = aluno._nome;
            command.Parameters[1].Value = aluno._telefone;
            command.Parameters[2].Value = aluno._cidade;
            command.Parameters[3].Value = aluno._rg;
            command.Parameters[4].Value = aluno._cpf;
            command.Parameters[5].Value = aluno._matricula;
            command.Parameters[6].Value = aluno._codigoCurso;
            command.Parameters[7].Value = aluno._nomeCurso;

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

                SqlCommand command = new SqlCommand(sqlAlunos, cn);
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
