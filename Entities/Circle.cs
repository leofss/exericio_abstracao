using System;
using System.Collections.Generic;
using System.Text;
using exericio_abstração.Entities.Enums;

namespace exericio_abstração.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
