using Cap10_HerancaEPolimorfismo.Entities;

namespace Cap10_HerancaEPolimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100, 500);

            Console.WriteLine(account.Balance);

            account.Balance = 200; // nao consigo acessar metodos protected fora da classe e seus filhos.
        }
    }
}
