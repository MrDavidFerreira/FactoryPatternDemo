using System;

namespace FactoryPatternDemo
{
    public class Circle : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Circle::draw() method.");
        }
    }
}