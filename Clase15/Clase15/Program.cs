using System;

namespace Clase15
{
    class Program
    {
        static void Main(string[] args)
        {
            Lavadora myLavadora = new Lavadora();
            Television myTelevision = new Television();
            int opcion;
            Console.WriteLine("Eliga el producto:");
            Console.WriteLine("1- Televisor");
            Console.WriteLine("2- Lavadora");
            opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    myTelevision.precioFinal();
                    break;
                case 2:
                    myLavadora.precioFinal();
                    break;
                default:
                    break;
            }
            


        }
    }
}
