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
               
                Escreva um programa que repita a leitura de uma senha até que ela seja válida.Para cada leitura de senha
                incorreta informada, escrever a mensagem "Senha Invalida".Quando a senha for informada corretamente deve ser
                impressa a mensagem "Acesso Permitido" e o algoritmo encerrado.Considere que a senha correta é o valor 2002.
            
                string correctPassword = "2002";

                string passwordOnLogin = Console.ReadLine();

                while (passwordOnLogin != correctPassword) {
                    Console.WriteLine("Senha Invalida");
                    passwordOnLogin = Console.ReadLine();
                }

                Console.WriteLine("Acesso permitido");
            */

            /*
                Exercício 02
                Correção: https://github.com/acenelio/nivelamento-csharp/blob/master/uri1115/uri1115/Program.cs
                            Escreva um programa para ler as coordenadas (X, Y) de uma quantidade indeterminada de pontos no sistema
                cartesiano.Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
                menos uma de duas coordenadas for NULA(nesta situação sem escrever mensagem alguma).

                string[] coordenadas = Console.ReadLine().Split(" ");

                int x = int.Parse(coordenadas[0]);
                int y = int.Parse(coordenadas[1]);

                while (x != 0 && y != 0) {
                    if(x > 0 && y > 0) {
                        Console.WriteLine("primeiro");
                    }else if(x < 0 && y > 0) {
                        Console.WriteLine("segundo");
                    }
                    else if (x < 0 && y < 0) {
                        Console.WriteLine("terceiro");
                    }
                    else {
                        Console.WriteLine("quarto");
                    }

                    coordenadas = Console.ReadLine().Split(" ");

                    x = int.Parse(coordenadas[0]);
                    y = int.Parse(coordenadas[1]);
                }
            */

            /*
                Exercício 03
                
                Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
                um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
                4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até
                que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a
                mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme
                exemplo
                int codCombustivel = int.Parse(Console.ReadLine());
                int alcool = 0, gasolina = 0, diesel = 0;

                while (codCombustivel != 4) {
                    if (codCombustivel < 0 || codCombustivel > 4) {
                        Console.WriteLine("Código invalido. Digite novamente");
                        codCombustivel = int.Parse(Console.ReadLine());
                    }
                    else {
                        if (codCombustivel == 1) {
                            alcool++;
                        }
                        else if (codCombustivel == 2) {
                            gasolina++;
                        }
                        else {
                            diesel++;
                        }
                        codCombustivel = int.Parse(Console.ReadLine());
                    }

                }

                Console.WriteLine("MUITO OBRIGADO");
                Console.WriteLine("Alcool: " + alcool);
                Console.WriteLine("Gasolina: " + gasolina);
                Console.WriteLine("Diesel: " + diesel);
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
