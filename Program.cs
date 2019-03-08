using System;

namespace CondicionalIF
{
    class Program
    {
        static void Main(string[] args)
        {

            bool hacefrio;
            hacefrio = true;
            Console.WriteLine(hacefrio);
            Console.WriteLine(!hacefrio);



            Console.WriteLine("Vamos a evaluar si eres mayor de edad, ingresa tu edad");
            int edad;
            edad = Int32.Parse(Console.ReadLine());

            if (edad > 18)
            {
                Console.WriteLine("Adelante, eres mayor de edad");
            }
            else
            {
                Console.WriteLine("pa juera eres muy pequeño");
            }


        }
    }
}
