using System.Globalization;

namespace Course {
    internal class Program {
        static void Main(string[] args) {

            /*
                EX 1
                int x, y, soma;
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
                soma = x + y;

                Console.WriteLine($"Soma = {soma}");
            */


            /*
                EX 2
                double raio, area, pi = 3.14159;

                raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                area = pi * Math.Pow(raio, 2);

                Console.WriteLine($"A = {area.ToString("F4", CultureInfo.InvariantCulture)}");
            */

            /*
                EX 3
                int A, B, C, D, resultado;
                A = int.Parse(Console.ReadLine());
                B = int.Parse(Console.ReadLine());
                C = int.Parse(Console.ReadLine());
                D = int.Parse(Console.ReadLine());

                resultado = (A * B) - (C * D);

                Console.WriteLine($"DIFERENCA = {resultado}");
            */

            /*
                EX 4
                int funcionarioNum, horasTrabalhadas;
                double valorHora, salarioFunc;

                funcionarioNum = int.Parse(Console.ReadLine());
                horasTrabalhadas = int.Parse(Console.ReadLine());
                valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                salarioFunc = horasTrabalhadas * valorHora;

                Console.WriteLine($"NUMBER = {funcionarioNum}");
                Console.WriteLine($"SALARY = U${salarioFunc.ToString("F2", CultureInfo.InvariantCulture)}");
            */

            /*
                EX 5
                int cod1, cod2, qte1, qte2;
                double preco1, preco2, total;

                string[] valores = Console.ReadLine().Split(' ');
                cod1 = int.Parse(valores[0]);
                qte1 = int.Parse(valores[1]);
                preco1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

                valores = Console.ReadLine().Split(' ');
                cod2 = int.Parse(valores[0]);
                qte2 = int.Parse(valores[1]);
                preco2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

                total = preco1 * qte1 + preco2 * qte2;

                Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            */


            /*
                EX 6
                double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo;

                string[] valores = Console.ReadLine().Split(' ');
                A = double.Parse(valores[0], CultureInfo.InvariantCulture);
                B = double.Parse(valores[1], CultureInfo.InvariantCulture);
                C = double.Parse(valores[2], CultureInfo.InvariantCulture);

                triangulo = A * C / 2.0;
                circulo = 3.14159 * C * C;
                trapezio = (A + B) / 2.0 * C;
                quadrado = B * B;
                retangulo = A * B;

                Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
                Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
                Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
                Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
                Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));

            */





        }
    }
}
