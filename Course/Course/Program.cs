using System.Drawing;
using System.Globalization;
using System.Runtime.ConstrainedExecution;

namespace Course {
    internal class Program {
        static void Main(string[] args) {

            /*
                EXERCÍCIO 01:
                Fazer um programa para ler os valores da largura e altura de um retângulo. Em
                seguida, mostrar na tela o valor de sua área, perímetro e diagonal.Usar uma classe
                como mostrado no projeto ao lado.

                Retangulo meuRetangulo = new Retangulo();
                Console.WriteLine("Entre com a largura e altura do retangulo: ");

                Console.Write("Altura: ");
                meuRetangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Largura: ");
                meuRetangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("AREA = "+meuRetangulo.Area().ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("PERÍMETRO = "+meuRetangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("DIAGONAL = "+meuRetangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
            */

            /*
                EXERCÍCIO 02:
                Fazer um programa para ler os dados de um funcionário (nome,
                salário bruto e imposto). Em seguida, mostrar os dados do
                funcionário (nome e salário líquido). Em seguida, aumentar o salário
                do funcionário com base em uma porcentagem dada (somente o
                salário bruto é afetado pela porcentagem) e mostrar novamente os
                dados do funcionário. Use a classe projetada abaixo.

                Funcionario funcionarioExemplo = new Funcionario();

                Console.Write("Nome: ");
                funcionarioExemplo.Nome = Console.ReadLine();
                Console.Write("Salário bruto: ");
                funcionarioExemplo.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Imposto: ");
                funcionarioExemplo.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine($"Funcionário: {funcionarioExemplo}");

                Console.Write("Digite a porcentagem para aumentar o salário: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                funcionarioExemplo.AumentarSalario(porcentagem);

                Console.WriteLine($"Dados atualizados: {funcionarioExemplo}");
            */

            /*
                EXERCÍCIO 03:
                Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano
                (primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no
                ano. Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam
                para o aluno obter o mínimo para ser aprovado (que é 60 pontos). Você deve criar uma classe Aluno para resolver
                este problema.

                Aluno aluno = new Aluno();
                Console.Write("Nome do aluno: ");
                aluno.Nome = Console.ReadLine();
                Console.WriteLine("Digite as três notas do aluno:");
                aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("NOTA FINAL = "
                + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
                if (aluno.Aprovado()) {
                    Console.WriteLine("APROVADO");
                }
                else {
                    Console.WriteLine("REPROVADO");
                    Console.WriteLine("FALTARAM "
                    + aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)
                    + " PONTOS");
                }
            */


        }
    }
}
