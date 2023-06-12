# Generics

- Generics permitem que classes, interfaces e métodos possam ser parametrizados por tipo. Seus benefícios são:
    - Reuso
    - Type Safety
    - Performance

- Uso comum: Coleções

```csharp
    List <string> list = new List<string>();
    list.Add("Maria");
    string name = list[0];
```
- Generics podem ter certas restrições.

Problema exemplo:
    Uma empresa de consultoria deseja avaliar a performance de produtos, funcionários, dentre outras coisas. Um dos cálculos que ela precisa é encontrar o maior dentre um conjunto de elementos.
    Fazer um programa que leia um conjunto de N produtos, conforme exemplo, e depois mostre o mais caro deles.

ex de output:

```
Enter N: 3
Computer, 890.50
Iphone X, 910.00
Tablet,550.00

Most expensive:
Iphone, 910.00
```

Restrições Possíveis:
- where T: struct
- where T: class
- where T: unmanaged
- where T: new()
- where T: <base type name>
- where T: U
