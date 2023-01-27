# Modificador PARAMS:
  O modificador params é usado da mesma forma que o *args em outras linguagens. 
  Ao utilizá-lo, fará com que todos os argumentos passados para a função, sejam vistos como um array e assim, podemos fazer a operação com indeterminados números de parâmetros.
  ex:
  ```csharp
  class Calculator
  {
      public static int Sum(params int[] numbers)
      {
          int sum = 0;
          for (int i=0; i < numbers.Length; i++)
          {
              sum += numbers[i];
          }
          return sum;
      }
  }
  class Program
  {
      static void Main(string[] args)
      {
          int calc = Calculator.Sum(1, 2, 3, 4);
          Console.WriteLine(calc); // 10
      }
  }
  ```
