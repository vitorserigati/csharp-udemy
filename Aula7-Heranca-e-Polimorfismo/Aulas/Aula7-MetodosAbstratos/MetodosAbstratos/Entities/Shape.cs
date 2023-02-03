using MetodosAbstratos.Entities.Enums;
namespace MetodosAbstratos.Entities
{
    abstract class Shape
    {
        public Color Color {get; protected set;}

        public Shape(){}
        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
