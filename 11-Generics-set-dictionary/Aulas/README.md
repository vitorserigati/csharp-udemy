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

# GetHashCode e Equals

- São operações da classe Object utilizadas para comparar se um objeto é igual a outro
- Equals: lento, resposta 100%
- GetHashcode: rápido, porém resposta positiva não é 100%
- Os tipos pré-definidos já possuem implementação para essas operações. Classes e structs personalizados precisam sobrepô-las.

## Equals
    Método que compara se o objeto é igual a outro, retornando true ou false.

    ```csharp
    string a = "Maria";
    string b = "Alex";

    Console.WriteLine(a.Equals(b)); // False
    ```

## GetHashCode
    Método que retorna um número inteiro representando um código gerado a partir das informações do objeto.

    ```csharp
     string a = "Maria";
     string b = "Alex";

     Console.WriteLine(a.GetHashCode());
     Console.WriteLine(b.GetHashCode());
    ```

### Regra de ouro do GetHashcode
- Se o código e dois objetos for diferente, então os dois objetos são diferentes.
- Se o código de dois objetos for igual, muito <strong>provavelmente</strong> os objetos são iguais. (pode haver colisão).

# HashSet<T> e SortedSet<T>

- Representa um conjunto de elementos (similar ao da Álgebra)
    - Não admite repetições
    - Elementos não possuem posição
    - Acesso, inserção e remoção de elementos são rápidos
    - Oferece operações eficientes de conjunto: interseção, união, diferença.

```csharp
using System.Collections.Generic;

HashSet<string> set = New HashSet<string>();

set.Add("TV");
set.Add("Notebook");
set.Add("Tablet");
set.Contains("TV"); // True

foreach(string item in set){

    Console.WriteLine(item);
}
```

## Diferenças

- HashSet
    - Armazenamento em tabela Hash
    - Extremamente rápido: inserção, remoção e busca O(1).
    - A ordem dos elementos não é garantida.
- SortedSet
    - armazenamento em árvore
    - Rápido: inserção, remoção e busca O(log(n))
    - Os elementos são armazenados ordenadamente conforme implementação ICompararer<T>

### Alguns métodos importantes

- Add
- Clear
- Contains
- UninionWith(other) - Operação união: adiciona no conjunto os elementos do outro conjunto, sem repetição.
- IntersectWith(other) - Operação interseção: Remove do conjunto os elementos não contidos em other.
- ExceptWith(other) - Operação diferença: remove do conjunto os elementos contidos em other.
- Remove(T)
- RemoveWhere(predicate)

# Comparação de coleções Hash

- Se GetHashCode e Equals estiverem implementados:
    - Primeiro GetHashCode. Se der igual, usa Equals para confirmar.

- Se GetHashCode e Equals <strong> NÃO </strong> estiverem implementados:
    - Tipos referência: compara as referências dos objetos.
    - tipos valor: comparar os valores dos atributos.
