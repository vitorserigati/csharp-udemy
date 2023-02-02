## Polimorfismo

  Em Programação Orientada a Objetos, Polimorfismo é o recurso que permite que variáveis de um mesmo tipo mais genérico possam apontar para objetos de tipos específicos diferentes, tendo assim comportamentos diferentes conforme cada tipo específico.

  ```csharp
  Account acc1 = new Account(1001, "Alex", 500.0);
  Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);

  acc1.Withdraw(10.0);
  acc2.Withdraw(10.0);

  Console.WriteLine(acc1.Balance); // 485.0 Pois em nosso código a classe Account tinha um acrescimo de 5.0 em cada saque.
  Console.WriteLine(acc2.Balacne); // 490.0 Pois alteramos o método na classe SavingsAccount para remover o acrescimo de 5.0 em cada saque.
  ```
  Ou seja, o comportamento do método é diferente para cada implementação do mesmo.
