## Classes Abstratas

Para evitar que uma classe seja instanciada, podemos utilizar a palavra "Abstract", dessa forma, a classe poderá ser herdada, mas não instanciada.
ex:
```csharp

namespace Program
{
    abstract class Account 
    {
        //logic


    }

    class BusinessAccount : Account
    {
        //logic
    }
}
```
Desta forma, podemos reutilizar toda a lógica que existe na classe Account, porém, ela não poderá ser instanciada.
A notação UML de classes abstratas é o Itálico.
Classes abstratas ainda podem sofrer polimorfismo, ou seja, podemos modificar seus métodos nas subclasses.
Podemos também fazer Upcasting (instanciar uma subclasse em uma variável da superclasse).

