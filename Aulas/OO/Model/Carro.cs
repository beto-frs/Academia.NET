using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO.Model
{
    public class Carro
    {
        public string _Modelo { get; private set; }
        public string _Cor { get; private set; }
        public int _Ano { get; private set; }
        public string _Chassi { get; private set; }
        public string _Proprietário { get; private set; }
        public double _VelMaxima { get; private set; }
        public double _VelAtual { get; private set; }
        public int _Portas { get; private set; }
        public int _QtdMarchas { get; private set; }
        public bool _Automatico { get; private set; }
        public bool _TetoSolar{ get; private set; }
        public double _QtdCombustivel { get; private set; }
        public string _TipoCombustivel { get; private set; }
        private int _MarchaAtual = 0;
        
        public Carro()
        {

        }

        public void Acelera()
        {
            if (_VelAtual < _VelMaxima )
            {
                _VelAtual++;
            }
            
        }

        public void Freia()
        {
            if (_VelAtual > 0)
            {
                _VelAtual--;
            }

        }

        public void AumentaMarcha()
        {
            if (_MarchaAtual < _QtdMarchas)
            {
                _MarchaAtual++;
            }
        }

        public void DiminuiMarcha()
        {
            if (_MarchaAtual>0)
            {
                _MarchaAtual--;
            }

        }

        
    }
}
