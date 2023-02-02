namespace ClassesMetodosSelados.Entities
{
    class Account
    {
        public int Number { get; protected set; }
        public string Holder { get; protected set; }
        public double Balance { get; protected set; }

        public Account() { }
        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double ammount)
        {
            Balance -= ammount + 5.0;
        }
        public void Deposit(double ammount)
        {
            Balance += ammount;
        }
    }
}
