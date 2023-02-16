namespace ClassesMetodosSelados.Entities
{
    sealed class SavingsAccount : Account //Evita que a classe seja Herdada por outra.
    {
        public double InterestRate { get; private set; }
        public SavingsAccount() { }
        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public sealed override void Withdraw(double ammount) //Impede que o método seja sobreescrito por uma classe que herde desta classe.
        {
            Balance -= ammount;
        }
    }
}
