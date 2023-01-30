using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Path
{
    public interface IArquivos
    {
        bool Verifica();
        string ReturnJson(string index);
        void WriterPessoas(string texto);
        void WriterAlunos(string texto);
    }
}
