using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Inicializar tu nombre y apellido
            Person person = new Person();
            // Invocar el método de recorrer del 1 al 100
            for (int i = 1; i<=100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(person.fusion);
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine(person.name);
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(person.lastName);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            // Parar ejecución y ver resultado.
            Console.ReadLine();
        }
    }
}
