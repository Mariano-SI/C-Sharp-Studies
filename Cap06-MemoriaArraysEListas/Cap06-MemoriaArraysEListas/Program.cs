using System.Globalization;
using System.Collections.Generic;

namespace Cap06_MemoriaArraysEListas {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Declaração e adição de elementos");
            //Adicionar elementos com Add: por padrão o novo elemento vai para o final da lista
            List<string> nomes = new List<string>();

            nomes.Add("Mariano");
            nomes.Add("Alex");
            nomes.Add("Bob");
            nomes.Add("Maria");
            nomes.Add("Joana");
            nomes.Add("Anna");


            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("------------------------------------------------------------------------------------------");

            //Adiconar elementos usando Insert. Diferença pro Add: com insert indicamos a posição em que desejamos inserir

            nomes.Insert(2, "Lucas");
            foreach (string nome in nomes) {
                Console.WriteLine(nome);
            }

            Console.WriteLine("------------------------------------------------------------------------------------------");


            Console.WriteLine("Exibiçao de tamanho");
            //Exibir tamanho da lista usando Count

            Console.WriteLine("List count: " + nomes.Count);

            Console.WriteLine("------------------------------------------------------------------------------------------");

            Console.WriteLine("BUscas de elementos, indices e filtragem");
            //Encontrar o primeiro ou último elemento da lista que satisfaça um predicado com list.Find, list.FindLast

            //Exemplo 1: Encontrar a primeira ocorrencia de um nome que comece com a letra A

            string firstNameStartingWithA = nomes.Find(nome => nome[0] == 'A');
            Console.WriteLine("Primeira ocorrencia de nome que começa com A: " + firstNameStartingWithA);

            //Exemplo 2: Encontrar a última ocorrencia de um nome que comece com a letra A

            string lastNameStartingWithA = nomes.FindLast(nome => nome[0] == 'A');
            Console.WriteLine("Última ocorrencia de nome que começa com A: " + lastNameStartingWithA);


            Console.WriteLine("------------------------------------------------------------------------------------------");

            //Encontrar a primeira e a última POSICAO de elemento na lista que satisfaça um predicado com list.FindIndex e list.FindLastIndex

            //Exemplo 1: Encontrar a posicao do primeiro nome que comece com a letra A
            int indexOfFirstNameStartingWithA = nomes.FindIndex(nome => nome[0] == 'A');
            Console.WriteLine("Indice do primeiro nome que começa com A: " + indexOfFirstNameStartingWithA);

            //Exemplo 2: Encontrar a posicao do ultimo nome que comece com a letra A
            int indexOfLastNameStartingWithA = nomes.FindLastIndex(nome => nome[0] == 'A');
            Console.WriteLine("Indice do último nome que começa com A: " + indexOfLastNameStartingWithA);

            Console.WriteLine("------------------------------------------------------------------------------------------");

            //Filtrar a lista com base num predicado com list.FindAll

            //Filtrar nomes que tenham 5 letras
            List<string> namesWithFiveCharacters = nomes.FindAll(nome => nome.Length == 5);

            foreach(string nameWithFiveCharacter in namesWithFiveCharacters) {
                Console.WriteLine(nameWithFiveCharacter);
            }

            Console.WriteLine("------------------------------------------------------------------------------------------");

            Console.WriteLine("Remoção por elemento, indice, condicao e range");
            //Remover elementos da lista com Remove, RemoveAll, RemoveAt e RemoveRange

            //Remove: espera como parametro um item da lista
            nomes.Remove("Mariano");
            foreach (string nome in nomes) {
                Console.WriteLine(nome);
            }

            Console.WriteLine("----");
            //RemoveAll remove todo mundo que satisfaz um predicato
            nomes.RemoveAll(nome => nome[0] == 'A');
            foreach (string nome in nomes) {
                Console.WriteLine(nome);
            }

            //RemoveAt: remove um elemento pela posicao que ele se encontra

            nomes.RemoveAt(0); //remove o primeiro elemento

            //RemoveRange: remove os elementos de uma faixa que se inicia no indice passado no primeiro parametro e se estende ate a quantidade do segundo

            nomes.RemoveRange(0, 2); //remove o primeiro elemento







        }
    }
}
