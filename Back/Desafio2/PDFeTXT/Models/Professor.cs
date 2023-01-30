using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFeTXT.Models
{
    public class Professor : Pessoa
    {
        public List<Professor> Professores { get; set; }
        public Professor()
        {
           

        }
    }
    
}
