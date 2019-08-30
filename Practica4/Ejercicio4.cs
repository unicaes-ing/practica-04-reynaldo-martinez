using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    public class Ejercicio4
    {
        public static void ejer4()
        {
            /*Capturar por teclado las ventas realizadas por un vendedor, indicar la finalización de captura de datos
             con -1, mostrar el total de ventas, calcular y mostrar una bonificación del 5% por las ventas realizadas.*/
          
            double total = 0;
            double valor = 0;
            int i = 1;
            
            do
            {
                Console.WriteLine("Coloque el valor de la venta " + i);
                valor = Convert.ToDouble(Console.ReadLine());
                total = total + valor;
                i++;

            } while (valor != -1);
            total = total + 1;
            double bonificacion = (total * 0.05);
            double nTotal = total + bonificacion;
            Console.WriteLine("El total en ventas es: " + total + "\n" + "Total con bonificacion: " +nTotal.ToString("N2"));

            Console.ReadKey();

        }
    }
}
