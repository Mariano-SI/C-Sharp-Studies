using System.Linq;

namespace Cap17_ExpressoesLambdaDelegatesELINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 - especificar a fonte de dados
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };

            //2 - definir a consulta
            var result = numbers.Where(x => x % 2 == 0).Select(x => x * 10); //O where serviu como um filter do JS e o Select um map;

            // 3 - Executar a consulta

            foreach (int x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}
