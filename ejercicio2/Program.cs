using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
             string producto1, producto2, producto3;
            Console.WriteLine("bienvenido al programa");
            Console.WriteLine("ingrese el precio de 3 productos  ");
            Console.WriteLine("producto 1");
            producto1 = Console.ReadLine();
            double pro1 = double.Parse(producto1);

           
            Console.WriteLine("producto 2");
            producto2 = Console.ReadLine();
            double pro2 = double.Parse(producto2);

            Console.WriteLine("producto 3");
            producto3 = Console.ReadLine();
            double pro3 = double.Parse(producto3);

           double  totalDePromocion = pro1 + pro2 + pro3 ; 
           double  compraTotal = pro1 + pro2 + pro3;
           double  ahorro = totalDePromocion - pro3;

            if (totalDePromocion > 100) {
                double Promocion = pro1 + pro2 + pro3 * 0.15;
                Console.WriteLine("el total de descuento es: " + Promocion);
            }

            
            Console.WriteLine("El total compra es: " + compraTotal);
            Console.WriteLine("el ahorro de descuento es: " + ahorro);

 
           Console.ReadLine();
           


        }
    }
}
