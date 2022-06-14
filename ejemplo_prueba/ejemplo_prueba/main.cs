using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_prueba
{
    internal class main
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("\n Welcome user");
            char opcion;
            do
            {
                Console.WriteLine("\n You want to register an employee \n choose 1 yes \n choose 2 no \n");
                opcion = char.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (opcion)
                {
                    case '1': menu menu = new menu(); menu.Menu(); break; 
                    case '2':  Environment.Exit(0); break; 
                }
            }while(true);


        }
    }
}
