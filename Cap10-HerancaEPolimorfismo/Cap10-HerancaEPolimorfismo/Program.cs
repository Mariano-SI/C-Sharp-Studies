using Cap10_HerancaEPolimorfismo.Entities;

namespace Cap10_HerancaEPolimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Mariano", 0);

            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0, 500);

            //UPCASTING = conbersao de subclasse em superclasse

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0, 200);
            Account acc3 = new SavingsAccount(1004, "Ana", 0, 0.01);
            //quando convertemos subclasse em superclasse a superclasse so consegue acessar atributos e metodos da superclasse


            //DOWNCASTING = conversao de superclasse para subclasse. (Operacao insegura)

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100);

            //BusinessAccount acc5 = (BusinessAccount)acc3;

            if(acc3 is BusinessAccount)
            {
                BusinessAccount acc5 = (BusinessAccount)acc3;
                acc5.Loan(200);
                Console.WriteLine("Loan!");
            }

            if(acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = (SavingsAccount)acc3;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }

        }
    }
}
