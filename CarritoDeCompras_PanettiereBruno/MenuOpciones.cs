using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoCompras
{
    class MenuOpciones
    {
        Operaciones myOperation = new Operaciones(0, 0, 0, false);
        Camisa myCamisa = new Camisa();
        Menu myMenu = new Menu();
        public void menu()
        {
            int opcion;
            do
            {
                myMenu.menu();
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        myCamisa.logicaNegocio();
                        break;
                    case 2:
                        myCamisa.descontarCamisas();
                        break;

                    case 3:
                        myCamisa.salida();
                        break;
                    default:
                        break;
                        Console.WriteLine("15% de descuento llevando entre 3 a 5 camisas");
                        Console.WriteLine("20% de descuento llevando más de 6 camisas");
                }

            } while (opcion != 3 && myOperation.getSalida() != true);
        }

    }
}
