using Cap10_HerancaEPolimorfismo.Entities;

namespace Cap10_HerancaEPolimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "Mariano", 500);
            Account acc2 = new SavingsAccount(1001, "Nelio", 500, 0.01);

            acc1.Withdraw(10);
            acc2.Withdraw(10);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }
}
