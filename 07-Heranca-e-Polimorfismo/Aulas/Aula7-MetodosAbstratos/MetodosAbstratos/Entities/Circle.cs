using MetodosAbstratos.Entities.Enums;
namespace MetodosAbstratos.Entities
{
    class Circle : Shape
    {
        public double Radius { get; private set;}
        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2.0);
        }
    }
}
