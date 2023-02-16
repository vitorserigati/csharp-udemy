namespace UpcastingDowncasting.Entitites
{
    class BusinessAccount : Account
    {
        public double LoanLimit { get; protected set; }

        public BusinessAccount() { }
        public BusinessAccount(int number, string holder, double balance, double loanlimit) : base(number, holder, balance)
        {
            LoanLimit = loanlimit;
        }
        public void Loan(double ammount)
        {
            if (ammount <= LoanLimit)
            {
                Balance += ammount;
            }
        }
    }
}
