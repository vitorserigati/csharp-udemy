namespace InterfaceClassAbstractDemo.Model.Entities;
using InterfaceClassAbstractDemo.Model.Enums;
public abstract class AbstractShape : IShape
{
    public Color Color {get; set;}
    
    public abstract double Area();
}
