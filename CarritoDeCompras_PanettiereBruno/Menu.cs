using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoCompras
{
    class Menu
    {
        Operaciones myOperation = new Operaciones(0, 0, 0, false);
        Camisa myCamisa = new Camisa();
        public void menu()
        {
            Console.WriteLine("TIENDA ONLINE - Ventas por mayor y menor");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("- MENU -");
            Console.WriteLine("1- Añadir camisa al carro de compras");
            Console.WriteLine("2- Eliminar ítem del carro de compras");
            Console.WriteLine("3- Salir");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("         -Cantidad de camisas en el carro:" + myOperation.getContador());
            Console.WriteLine("         -Precio por unidad: 1000");
            Console.WriteLine("         -Precio total (sin descuento): " + myOperation.getTotal());
            myCamisa.mostrarDescuentos();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Ingrese el número de la opción que desea: ");
        }
    }
}
