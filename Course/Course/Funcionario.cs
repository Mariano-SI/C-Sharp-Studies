using System;

namespace Course {
    internal class Funcionario {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() {
            return SalarioBruto - Imposto;
        }

        public double AumentarSalario(double porcentagem) {
            return SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem * 0.01);
        }
    }
}
