using System.Globalization;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Cap06_MemoriaArraysEListas {
    internal class Program {
        static void Main(string[] args) {


            Console.Write("Informe o número de funcionários: ");
            int funcQntd = int.Parse(Console.ReadLine());

            List<Funcionario> funcionarios = new List<Funcionario>();

            for (int i = 1; i <= funcQntd; i++) {
                Console.WriteLine("Funcionário #" + i);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                funcionarios.Add(new Funcionario(id, name, salario));

            }

            Console.Write("Digite o ID do empregado que voce deseja aumentar o salario: ");
            int idFunc = int.Parse(Console.ReadLine());

           

            Funcionario selectedFunc = funcionarios.Find(funcionario => funcionario.Id == idFunc);

            if (selectedFunc != null) {
                Console.Write("Digite a porcentagem: ");
                int percentage = int.Parse(Console.ReadLine());
                selectedFunc.IncreaseSalary(percentage);
            }
            else {
                Console.WriteLine("This id does not exist!");
            }

  

            Console.WriteLine("Lista de funcionários atualizada: ");

            foreach (Funcionario func in funcionarios)
            {
                Console.WriteLine(func);
            }



        }
    }
}
