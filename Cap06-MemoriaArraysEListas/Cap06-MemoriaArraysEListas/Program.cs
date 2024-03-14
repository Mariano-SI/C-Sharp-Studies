namespace Cap06_MemoriaArraysEListas {
    internal class Program {
        static void Main(string[] args) {

            double? x = null;
            double? y = 10.0;

            //OPERAÇÕES BÁSICAS COM VALORES NULLABLE

            //Retorna o valor caso nao seja null, senão devolve o valor default daquele tipo
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());


            //devolve true caso tenha valor diferente de null, false caso seja null
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            //devolve o valor caso exista, lança exceção caso seja null
            Console.WriteLine(x.Value); //Vai disparar exceção e interromper o programa

            //Maneira correta
            if (x.HasValue) {
                Console.WriteLine(x.Value);
            }

            if (y.HasValue) {
                Console.WriteLine(y.Value);
            }

            //OPERADOR DE COALESCÊNCIA NULA

            double a = x ?? 5; // se x tiver valor, a = x, senao use o valor do lado esquerdo


            Console.WriteLine(a); //imprimirá 5

        }
    }
}
