using UpcastingDowncasting.Entitites;
namespace UpcastingDowncasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex Green", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria Moore", 0.0, 500.0);

            //Upcasting
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Ana", 0.0, 0.01);

            //Downcasting
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);
            //acc2.Loan(100.00); Sem o Downcasting, o compilador não reconhece que esta variável é do tipo BusinessAccount.
            //Sendo assim, ela não possuí o método "Loan".
            //BusinessAccount acc5 = (BusinessAccount) acc3; Irá gerar um erro em tempo de execução. Pois são de tipos incompatíveis.

            if (acc3 is BusinessAccount)
            {
                BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc6 = acc3 as BusinessAccount; //sintaxe alternativa
            }
            else
            {
                Console.WriteLine(acc3.GetType());
            }
            if(acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = (SavingsAccount) acc3;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }
        }
    }
}
