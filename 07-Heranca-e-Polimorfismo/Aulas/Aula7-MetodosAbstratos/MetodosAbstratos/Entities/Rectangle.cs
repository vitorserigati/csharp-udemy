using MetodosAbstratos.Entities.Enums;
namespace MetodosAbstratos.Entities
{
    class Rectangle : Shape
    {
        public double Width {get; private set;}
        public double Height {get; private set;}

        public Rectangle(double width, double height, Color color) : base(color)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }

}
