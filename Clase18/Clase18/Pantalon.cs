using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase18
{
    class Pantalon : Ropa
    {

        public Pantalon(double precioFinal, bool premium) : base(precioFinal, premium)
        {
        }


        public double precio()
        {
            bool bermuda = false;
            double precio = this.precioFinal;
            base.precioTotal();

            if (bermuda)
            {
                precio -= (precio * 0.30);
            }

            return precio;

        }


    }
}
