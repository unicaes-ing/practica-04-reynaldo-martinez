using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    public class Ejercicio6
    {
        public static void ejer6()
        {
            /*Capturar  por  teclado  la  cantidad  de  sucursales  que  posee  la  empresa,  luego  capturar  por teclado las ventas 
             * realizadas para cada sucursal, ingresar cero para indicar la finalización de captura de  datos.  Para  cada  sucursal,  
             * calcular  y  mostrar:  total  y  promedio  de  ventas.  Y calcular y mostrar el total y promedio de ventas global 
             * (de todas las sucursales)*/

            int i = 0;
            double totalSucursal = 0.0, totalGlobal = 0.0;
            string mensaje = "";

                do
                {
                    Console.WriteLine("Ingrese el total de ventas de la sucursal {0}", i + 1);
                    totalSucursal = Convert.ToDouble(Console.ReadLine());
                    mensaje += "Cantidad sucursal " + i + ":" + totalSucursal + "\n";
                    totalGlobal += totalSucursal;
                    i++;
                } while (totalSucursal != 0);

            Console.WriteLine(mensaje);
            Console.WriteLine("Cantidad global: {0:N2} Promedio: {1:N2}", totalGlobal, totalGlobal / i);
        }
    }
}
