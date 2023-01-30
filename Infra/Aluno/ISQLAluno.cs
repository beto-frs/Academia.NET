using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra
{
    public interface ISQLAluno
    {
        bool IncluirDados(AlunoModel aluno);

        bool AtualizarDados(AlunoModel aluno);

        bool ExcluirDados(string id);

        DataTable ExecutarConsulta();
    }
}
