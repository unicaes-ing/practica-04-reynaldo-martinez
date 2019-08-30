using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
     public class Ejercicio3
    {
         public static void ejer3()
         {
             /*Capturar por teclado el nombre de una persona, calcular y mostrar cuantas vocales posee 
              * (incluyendo minúsculas, mayúsculas y tildadas)*/
             int vocales = 0;
            Console.WriteLine("Ingrese su nombre");
            string nombre = Console.ReadLine();

            char[] array = nombre.ToCharArray();

            for (int i = 0; i < nombre.Length; i++)
            {
                if (array[i] == 'a' || array[i] == 'e' || array[i] == 'i' || array[i] == 'o' || array[i] == 'u')
                {
                    vocales++;
                }
                if (array[i] == 'A' || array[i] == 'E' || array[i] == 'I' || array[i] == 'O' || array[i] == 'U')
                {
                    vocales++;
                }
                if (array[i] == 'á' || array[i] == 'é' || array[i] == 'í' || array[i] == 'ó' || array[i] == 'ú')
                {
                    vocales++;
                }
                if (array[i] == 'Á' || array[i] == 'É' || array[i] == 'Í' || array[i] == 'Ó' || array[i] == 'Ú')
                {
                    vocales++;
                }
            }
            Console.WriteLine("Cantidad de vocales: {0}", vocales);
        }
             
                    
	

             
                    
                    

         }

    }

