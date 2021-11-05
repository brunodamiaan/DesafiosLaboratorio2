using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariaForms
{
    public class Piso : Inmueble
    {
        
        
        public double ingresarPiso(double precioFinal, int numPiso, int anios)
        {
            if (anios < 15)
            {
                precioFinal -= (precioFinal * 0.01);
            }
            else
            {
                precioFinal -= (precioFinal * 0.02);
            }
            if (numPiso >= 3)
            {
                precioFinal += (precioFinal * 0.03);
            }
            return precioFinal;
        }

        

        
    }
}
