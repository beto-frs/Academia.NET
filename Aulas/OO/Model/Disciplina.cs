using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OO.Model
{
    public class Disciplina
    {
        public string _nome { get; private set; }
        public string _cargaHoraria { get; private set; }

        public Disciplina()
        {

        }
        /// <summary>
        /// Método para gravar dados inserindo o nome e carga horária
        /// </summary>
        /// <param name="n">Nome</param>
        /// <param name="c">Carga Horária</param>
        public void GravarDados(string n, string c)
        {
            this._nome = n;
            this._cargaHoraria = c;
        }

        public void ExibirDados()
        {
            WriteLine($"nome da disciplina: {this._nome} com carga horária de {this._cargaHoraria}.");
        }
    }
}
