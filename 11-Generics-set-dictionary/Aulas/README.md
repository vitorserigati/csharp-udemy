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

- Problema motivador 1 (reuso)

Deseja-se fazer um programa que leia um conjunto de N números inteiros (N de 1 a 10), e depois imprima esses números de forma organizada.
Em seguida, informar qual foi o primeiro valor informado.

```UML
    + addValue(value: int): void
    + first(): int
    + print(): void
```
