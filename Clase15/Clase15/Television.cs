using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase15
{
    class Television : Electrodomestico
    {
        private int resolucion;
        private bool sintonizadorTDT;


        public Television()
        {
        }

        public Television(int resolucion, bool sintonizadorTDT)
        {
            this.resolucion = 20;
            this.sintonizadorTDT = false;
        }

        public Television(double precioBase, int peso) : base(precioBase, peso)
        {
        }

        public Television(double precioBase, string color, string consumoElectrico, int peso) : base(precioBase, color, consumoElectrico, peso)
        {
        }

        public int getResolucion()
        {
            return this.resolucion;
        }

        public bool getsintonizadorTDT()
        {
            return this.sintonizadorTDT;
        }


        public void precioFinal()
        {
            int sintonizador;

            base.precioFinal();

            Console.WriteLine("Ingrese la resolución:");
            this.resolucion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("¿Tiene sintonizador?");
            Console.WriteLine("1- Si");
            Console.WriteLine("2- No");
            sintonizador = Convert.ToInt32(Console.ReadLine());

            if (resolucion > 40)
            {
                precioBase = (precioBase * 1.30f);
            }

            if(sintonizador == 1)
            {
                sintonizadorTDT = true;

                if (sintonizadorTDT == true)
                {
                    precioBase = (precioBase * 1.50f);
                }
            }
            else
            {
                sintonizadorTDT = false;
            }
            
            
            
            

            Console.WriteLine(consumoElectrico);
            Console.WriteLine(precioBase);
            



        }



    }
}
