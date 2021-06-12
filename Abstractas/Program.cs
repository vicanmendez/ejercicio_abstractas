using System;

namespace Abstractas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Rectangulo rectangulo1 = new Rectangulo(100, 50);
            Console.WriteLine("El área es: " + rectangulo1.CalcularArea());
            Console.WriteLine("El perímetro es: " + rectangulo1.CalcularPerimetro());
        }
    }
}
