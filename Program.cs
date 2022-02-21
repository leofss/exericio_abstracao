using System;
using System.Collections.Generic;
using exericio_abstração.Entities.Enums;
using exericio_abstração.Entities;

namespace exericio_abstração
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            Console.WriteLine("Entre com a quantidade de figuras: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Figura numero {i}");
                Console.WriteLine("Retangulo ou circulo r/c ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Qual a cor (black, blue, red)");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if(ch == 'r')
                {
                    Console.WriteLine("Altura: ");
                    double alt = double.Parse(Console.ReadLine());
                    Console.WriteLine("Largura: ");
                    double lg = double.Parse(Console.ReadLine());
                    list.Add(new Rectangle(lg, alt, color));
                }
                else if(ch == 'c')
                {
                    Console.WriteLine("Radius: ");
                    double rad = double.Parse(Console.ReadLine());
                    list.Add(new Circle(rad, color));
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Area das figuras");
            foreach(Shape shape in list)
            {
                Console.WriteLine(shape.Area());
            }
        }
    }
}
