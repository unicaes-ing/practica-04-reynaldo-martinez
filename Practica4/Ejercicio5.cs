using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    public class Ejercicio5
    {
        public static void ejer5()
        {
            /*Escribir  un  programa  que  almacene  en  una  constante  una  contraseña  para 
             * ingresar  al sistema, que le permita al usuario hasta 3 intentos para ingresar al sistema. El programa dará pistas al usuario revelando 
             * un carácter a la vez de la contraseña válida por cada vez que el usuario se equivoque al ingresar la contraseña.*/
            const int contraseña = 1234;
            int contra=0;
            int intentos=1, intento1=0, intento2=0;
            int[] array = { 1, 2, 3, 4 };
            int i = 1;

            do
            {
                Console.WriteLine("intento "+ intentos + " ingrese la contraseña");
                contra = Convert.ToInt32(Console.ReadLine());
                if (contra == contraseña)
                {
                    Console.WriteLine("Bienvenido!!!");
                    break;
                }
                else
                {
                    if (contra != contraseña && intentos == 1)
                    {
                        Console.WriteLine("El primer caracter de la contraseña es: " + array[0]);
                    }
                    else
                    {
                        if (contra != contraseña && intentos == 2)
                        {
                            Console.WriteLine("El segundo caracter de la contraseña es: " + array[1]);
                        }
                        else
                        {
                            if (contra != contraseña && intentos == 3)
                            {
                                Console.WriteLine("El tercer caracter de la contraseña es: " + array[2]);
                                Console.WriteLine(" ha terminado la cantidad de intentos admitidos y No pudo acceder :(");
                            }
                        }
                    }
                }
                
                
               
                
                intentos++;
                
            } while (intentos < 4);

            Console.ReadKey();
            

                
           


        }
    }
}
