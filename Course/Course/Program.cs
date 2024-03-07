using System.Drawing;
using System.Globalization;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;


namespace Course {
    internal class Program {
        static void Main(string[] args) {

            /*
                Exercício 01
            
                Leia um valor inteiro X(1 <= X <= 1000).Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o
                X, se for o caso.

                //Versao 1 = mais comum
                int y = int.Parse(Console.ReadLine());

                for (int i = 1; i <= y; i++) {
                    if(i % 2 != 0) Console.WriteLine(i);
                }

                //Versao 2 = mais performatica
                int x = int.Parse(Console.ReadLine());

                for (int i = 1; i <= x; i+=2) {
                    Console.WriteLine(i);
                }

            */
            /*
                Exercício 02
                Correção: https://github.com/acenelio/nivelamento-csharp/blob/master/uri1072/uri1072/Program.cs
                            Leia um valor inteiro N.Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
                Mostre quantos destes valores X estão dentro do intervalo[10, 20] e quantos estão fora do intervalo, mostrando
                essas informações conforme exemplo(use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).

                int n = int.Parse(Console.ReadLine());

                int inside = 0, outside = 0;

                for(int i = 0; i < n; i++) {
                    Console.Write("Digite um valor: ");
                    int valor = int.Parse(Console.ReadLine());
                    if(valor >= 10 && valor <= 20) {
                        inside++;
                    }
                    else {
                        outside++;
                    }
                }

                Console.WriteLine($"{inside} in");
                Console.WriteLine($"{outside} out");
            */
            /*
                Exercício 03
                Correção: https://github.com/acenelio/nivelamento-csharp/blob/master/uri1079/uri1079/Program.cs
                Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste
                de 3 valores reais, cada um deles com uma casa decimal.Apresente a média ponderada para cada um destes
                conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem
                peso 5.
                int n = int.Parse(Console.ReadLine());

                int inside = 0, outside = 0;

                for (int i = 0; i < n; i++) {
                    string[] valores = Console.ReadLine().Split(' ');
                    double n1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
                    double n2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
                    double n3 = double.Parse(valores[2], CultureInfo.InvariantCulture);

                    double mediaPonderada = (n1 * 2 + n2 * 3 + n3 * 5) / 10;
                    Console.WriteLine(mediaPonderada.ToString("F1", CultureInfo.InvariantCulture));
                }
            */

            /*
                Exercício 04
                Correção: https://github.com/acenelio/nivelamento-csharp/blob/master/uri1116/uri1116/Program.cs
                Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo
                segundo. Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel"

                int n = int.Parse(Console.ReadLine());

                for(int i = 0; i < n; i++) {
                    string[] line = Console.ReadLine().Split(' ');
                    int x = int.Parse(line[0]);
                    int y = int.Parse(line[1]);

                    if (y == 0) {
                        Console.WriteLine("divisao impossivel");
                    }
                    else {
                        double result = (double)x / y;
                        Console.WriteLine(result.ToString("F1", CultureInfo.InvariantCulture);
                    }
                }
            */
            /*
                Exercício 05
                
                Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.
                Lembrando que, por definição, fatorial de 0 é 1.

                int n = int.Parse(Console.ReadLine());

                int somatorio = 1;
                for (int i = n; i >=1 ; i--) {
                    somatorio *= i;
                }

                Console.Write(somatorio);
            */

            /*
                Exercício 06
                
                Ler um número inteiro N e calcular todos os seus divisores.

                int n = int.Parse(Console.ReadLine());


                for (int i = 1; i <= n; i++) {
                    if (n % i == 0) {
                        Console.WriteLine(i);
                    }
                }
            */
            /*
                Exercício 07
            
                Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas,
                começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, conforme
                exemplo

                int n = int.Parse(Console.ReadLine());


                for (int i = 1; i <= n; i++) {
                    Console.WriteLine($"{i} {Math.Pow(i,2)} {Math.Pow(i, 3)}");
                }
            */
        }
        static int Maior(int n1, int n2, int n3) {
            if (n1 > n2 && n1 > n3) {
                return n1;
            }
            else if (n2 > n1 && n2 > n3) {
                return n2;
            }
            else {
                return n3;
            }
        }
    }
}
