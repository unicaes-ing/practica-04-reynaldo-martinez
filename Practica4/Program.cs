using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    class Program
    {
        static void Main(string[] args)
        {


          
            int menu = 0;
             Console.WriteLine("[1] Ejercicio 1");
             Console.WriteLine("[2] Ejercicio 2");
             Console.WriteLine("[3] Ejercicio 3");
             Console.WriteLine("[4] Ejercicio 4");
             Console.WriteLine("[5] Ejercicio 5");
             Console.WriteLine("[6] Ejercicio 6");
             Console.WriteLine("Que ejercicio desea ver?");
             menu = Convert.ToInt32(Console.ReadLine());
             Console.Clear();
            
             
              
                 switch (menu)
                 {
                     case 1:
                         Ejercicio1.ejer1();
                         break;
                     case 2:
                         Ejercicio2.ejer2();
                         break;
                     case 3:
                         Ejercicio3.ejer3();
                         break;
                     case 4:
                         Ejercicio4.ejer4();
                         break;
                     case 5:
                         Ejercicio5.ejer5();
                         break;
                     case 6:
                         Ejercicio6.ejer6();
                         break;

                     default:
                         break;




                 }


        }
    }
}
