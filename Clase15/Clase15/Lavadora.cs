using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase15
{
    class Lavadora : Electrodomestico
    {
        private int carga;

        public Lavadora(int carga)
        {
            this.carga = 15;
        }

        public Lavadora(double precioBase, int peso) : base(precioBase, peso)
        {
        }

        public Lavadora(double precioBase, string color, string consumoElectrico, int peso) : base(precioBase, color, consumoElectrico, peso)
        {

        }

        public Lavadora()
        {

        }

        public int getCarga()
        {
            return this.carga;
        }

        public new void precioFinal()
        {
            

            base.precioFinal();

            if (this.carga > 30)
            {
                this.precioBase += 50;
            }

            Console.WriteLine(consumoElectrico);
            Console.WriteLine(precioBase);
        }



        





    }
}
