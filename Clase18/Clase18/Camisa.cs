using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase18
{
    class Camisa : Ropa
    {
        
        public Camisa(double precioFinal, bool premium) : base(precioFinal, premium)
        {
        }

        
        public double precio()
        {
            double precio = this.precioFinal;
            bool mangaCorta = false;


            base.precioTotal();

            if (mangaCorta)
            {
                precio -= 0.10;
            }

            return precio;
        }
        
    }
}
