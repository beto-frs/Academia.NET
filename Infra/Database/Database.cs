
using Microsoft.Extensions.Configuration;
using System;
using System.Data.SqlClient;
using System.IO;

namespace Infra
{

    public class Database: IDatabase
    {
        IConfiguration configuration;

        protected SqlConnection cn;

        public Database()
        {
           
            configuration = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName)
                 .AddJsonFile("appsettings.json").Build();
        }
        
        public string ReturnJson(string index)
        {
            var mensagem =  (string)configuration.GetSection($"{index}").Value;
            return mensagem;
        }


        public void Conexao()
        {  
           cn = new SqlConnection(ReturnJson("DataBase:SQL"));
        }

        public SqlConnection AbrirConexao()
        {
            try
            {
                Conexao();
                cn.Open();
                return cn;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void FecharConexao()
        {
            try
            {
                cn.Close();
            }
            catch (Exception)
            {

                return;
            }
        }

        

        public Database GetDatabase(Database database)
        {
            return this;
        }

        
    }
}

