using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra
{
    public interface ISQLUsuario
    {
        bool IncluirDados(string[] dados);

        bool AtualizarDados(string[] dados);

        bool ExcluirDados(string[] dados);

        public DataTable ExecutarConsulta();
    }
}
