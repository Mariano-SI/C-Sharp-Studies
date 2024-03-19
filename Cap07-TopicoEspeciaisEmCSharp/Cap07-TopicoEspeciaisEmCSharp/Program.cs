using System.Globalization;

namespace Cap07_TopicoEspeciaisEmCSharp {
    internal class Program {
        static void Main(string[] args) {

            string original = "abcde FGHIJ ABC abc DEFG   ";
  
            //Mauisculo
            string maiusculo = original.ToUpper();
            //Minusculo
            string minusculo = original.ToLower();
            //Trim, remove espacos no inciio e final
            string stringComTrim = original.Trim();
            //Buscas
            int indexOfbc = original.IndexOf("bc"); //Mostra onde se inicia a primeira aparição desse trecho, no caso 1
            int lastIndexOfbc = original.LastIndexOf("bc"); //Mostra onde se inicia a ultima aparição desse trecho, no caso 17
            //Recorte de string
            string recortada3 = original.Substring(3); //corte de 3 em diante
            string recortadaComRange = original.Substring(3, 5); //comece em 3 + 5 caracteres
            //Substituicao de partes de string
            string trocaAPorX = original.Replace("a", "x");
            string trocaabcPorY = original.Replace("abc", "y");
            //Testar se a string é vazia ou nula
            bool isNullOrEmpty = String.IsNullOrEmpty(original);
            //Testar se a variavel é nula, composta somente de espacos ou vazia = true
            bool isNullOrWhiteSpace = String.IsNullOrWhiteSpace(original);

            Console.WriteLine("Original: " + original + "-");
            Console.WriteLine("Maiusculo: " + maiusculo + "-");
            Console.WriteLine("Minusculo: " + minusculo + "-");
            Console.WriteLine("Com trim: " + stringComTrim + "-");
            Console.WriteLine("Primeira aparição do bc: " + indexOfbc + "-");
            Console.WriteLine("Ultima aparição do bc: " + lastIndexOfbc + "-");
            Console.WriteLine("Substring3: " + recortada3 + "-");
            Console.WriteLine("Substring com range: " + recortadaComRange + "-");
            Console.WriteLine("Substituicao de partes de string: " + trocaAPorX + "-");
            Console.WriteLine("Substituicao de partes de string: " + trocaabcPorY + "-");
            Console.WriteLine("Is null or empty: " + isNullOrEmpty + "-");
            Console.WriteLine("Is null or white spacey: " + isNullOrWhiteSpace + "-");

        }
    }
}
