using _06_ExercicioPropostoExcecoes.Entities.Exceptions;


namespace _06_ExercicioPropostoExcecoes.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {

        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit; 
        }

        public void Deposit(double amount)
        {
            if (amount < 0)
            {
               throw new DomainException("It is not possible to deposit a negative amount");
            }
            Balance += amount;
        }
        public void Withdraw(double amount)
        {
            if(amount > WithdrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }else if (Balance <= 0)
            {
                throw new DomainException("Not enough balance");
            }
            else if (amount > Balance)
            {
                throw new DomainException("Not enough balance");
            }

            Balance -= amount;
        }
    }
}
