namespace Heranca.Entities
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

        public void Withdraw(double qnt)
        {
            Balance -= qnt;
        }
        public void Deposit(double qnt)
        {
            Balance += qnt;
        }
    }
}
