## Ref e Out
  
  As KeyWords "Ref" e "Out" são utilizadas como ponteiros. Com elas podemos modificar os valores originais das variáveis passadas no método.
  Diferenças: Com o ref, a variável necessariamente deverá estar inicializada com algum valor. Já com o out, a variável será atribuida mesmo que não esteja inicializada.
  Exemplos:
  ```csharp
  class Calculator {
      public static void Triple(ref int variavel){
          variavel = variavel * 3;
      }

      public static void AdicionaDois(int origem, out int result){
          result = origem + 2;
      }
  }

  class Program {
      static void Main(string[] args){
          int num = 10;
          int num2;

          Calculator.Triple(ref num); // 'num' se tornará 30. (3x10 = 30)
          Calculator.AdicionaDois(20, out num2) // 'num2' se tornará 22. (20 + 2 = 22)
      }
  }

```
obs: Ambos são considerados "code smells" (design ruim) e devem ser evitados.
