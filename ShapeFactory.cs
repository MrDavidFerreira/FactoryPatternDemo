
using System;

namespace FactoryPatternDemo
{
    public class ShapeFactory
    {
        //Se usa el método getShape para obtener un objeto de tipo Shape
        public Shape GetShape(string shapeType)
        {
            if (shapeType == null)
                return null;

            if (shapeType.Equals("CIRCLE", StringComparison.InvariantCultureIgnoreCase))
            {
                return new Circle();

            }
            else if (shapeType.Equals("RECTANGLE", StringComparison.InvariantCultureIgnoreCase))
            {
                return new Rectangle();

            }
            else if (shapeType.Equals("SQUARE", StringComparison.InvariantCultureIgnoreCase))
            {
                return new Square();
            }

            return null;
        }
    }
}