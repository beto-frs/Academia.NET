using System.Data;
using System.Data.SqlClient;

namespace Infra
{
    public interface IDatabase
    {
        string ReturnJson(string index);
        void Conexao();
        SqlConnection AbrirConexao();

        void FecharConexao();

        public Database GetDatabase(Database database);
    }
}
