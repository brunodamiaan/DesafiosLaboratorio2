using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase18
{
    abstract class Ropa
    {
        protected double precioFinal;
        protected bool premium;

        public Ropa(double precioFinal, bool premium)
        {
            this.precioFinal = precioFinal;
            this.premium = premium;
        }


        public double precioTotal()
        {
            double precio = precioFinal;


            if (premium)
            {
                precio += 0.30;
            }

            precioFinal = precio;

            return precioFinal;




        }




    }
}
