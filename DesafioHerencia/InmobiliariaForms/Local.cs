using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariaForms
{
    class Local : Inmueble
    {

        public double local(double precioFinal, int anios, int metrosCuadrados, int numVentanas)
        {
            
            
            if (anios < 15)
            {
                precioFinal -= (precioFinal * 0.01);
            }
            else
            {
                precioFinal -= (precioFinal * 0.02);
            }
            if (metrosCuadrados > 50)
            {
                precioFinal += (precioFinal * 0.01);
            }
            if (numVentanas <= 1)
            {
                precioFinal -= (precioFinal * 0.02);
            }
            else if (numVentanas > 4)
            {
                precioFinal += (precioFinal * 0.02);
            }
            return precioFinal;
        }







    }
}
