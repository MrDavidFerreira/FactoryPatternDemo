using System;

namespace FactoryPatternDemo
{
    public class Square : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Square::draw() method.");
        }
    }
}