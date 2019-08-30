using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    public class Ejercicio1
    {
        public static void ejer1()
        {
            /*Capturar  por  teclado  el  sueldo  de  20  empleados,  calcular  y  mostrar  
             en  pantalla  el  total  y promedio de sueldos.*/
            #region todo
            double sueldo, total = 0, promedio  ;
            for (int i = 1; i < 21; i++)
            {
                do
                {
                 Console.WriteLine("Coloque el sueldo del trabajador " + i);
                 sueldo = Convert.ToInt32(Console.ReadLine());
                 total = total + sueldo;
                } while (sueldo <= 0);
               
            }
            promedio = total / 20;
            Console.WriteLine("El total es : $" + total.ToString("N2"));
            Console.WriteLine("El promedio es: $" +  promedio.ToString("N2"));
            #endregion

        }
    }
}
