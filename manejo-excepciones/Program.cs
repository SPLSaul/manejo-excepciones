using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manejo_excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            bool opc = true;
            int num1=0;
            Console.Write("Ingresa un numero: ");
            try
            {
                 num1 = int.Parse(Console.ReadLine());
                //Console.WriteLine("asdf");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Formato incorrecto. \n{e.Message}");
                opc = false;
            }
            catch (OverflowException e)
            {
                Console.WriteLine($"Error // Numero muy grande \n{e.Message}");
                opc = false;

            }
            finally
            {
                Console.WriteLine("Fase 1 completada. ");
            }
            if (opc == false)
            {
                Console.WriteLine("Programa terminado");
            }
            else
            {
                int valor = (int)Math.Pow(num1, 2);
                try
                {
                    Console.WriteLine($"El valor de {num1} al cuadrado es: {valor}");
                }
                catch (OverflowException e)
                {
                    Console.WriteLine($"Error // Numero muy grande\n{e.Message}");
                }
                finally
                {
                    Console.WriteLine("Fase 2 terminada");
                }
            }
            
        }
    }
}
