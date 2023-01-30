using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra
{
    public interface ISQLPessoa
    {
        bool IncluirDados(PessoaModel pessoa);

        bool AtualizarDados(PessoaModel pessoa);

        bool ExcluirDados(string id);

        DataTable ExecutarConsulta();
    }
}
