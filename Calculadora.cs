using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cálculo_do_criculo
{
    class Calculadora
    {
        // declrando as variaveis
        public double Pi = 3.14;
        public double Circuferencia(double r)
        {
            //fórmula
            return 2.0 * Pi * r;
        }

        public double Volume(double r)
        {
            //fórmula
            return 4.0 / 3.0 * Pi * r * r * r;
        }
    }
}
