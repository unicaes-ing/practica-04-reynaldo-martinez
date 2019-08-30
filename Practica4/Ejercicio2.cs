using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    public class Ejercicio2
    {
        public static void ejer2()
        {
            /*Capturar  por  teclado la  calificación  y  asistencia  final  de  un  grupo  de  estudiantes de “Programación  Estructurada” 
              indicada  por  el  usuario,  
             calcular  y  mostrar  la  cantidad  de: Aprobados y Reprobados. (nota mínima de aprobación 7.0 y 75% de asistencia)*/
            int aprobados = 0, reprobados = 0;
            double notaFinal = 0, porcentaje;

                for (int i = 1; i < 6; i++)
                {
                    do
                    {
                        Console.Clear();
                       Console.WriteLine("Coloque la nota final del alumno " + i);
                       notaFinal = Convert.ToDouble(Console.ReadLine());
                    } while (notaFinal > 10);
                   
                    Console.WriteLine("Coloque la asistencia final del alumno " + i );
                    porcentaje = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                        if (notaFinal >= 7.0 && porcentaje >= 75)
                        {
                            aprobados = aprobados + 1;
                        }
                        else
                        {
                            reprobados = reprobados + 1;
                        }
                }

                Console.WriteLine("La cantidad de alumnos aprobados es: " + aprobados);
                Console.WriteLine("La cantidad de alumnos reprobados es: " + reprobados);
                Console.ReadKey();


        }
    }
}
