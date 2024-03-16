using System;
using System.Globalization;

namespace Cap06_MemoriaArraysEListas {
    internal class Funcionario {
        public int Id { get;  }
        public string Nome { get; private set; }
        public double Salario { get; set; }

        public Funcionario(int id, string nome, double salario) {
            Id = id;
            Nome = nome;
            Salario = salario;
        }
        public void IncreaseSalary(int percentage) {
            Salario += Salario * percentage / 100.0;
        }

        public override string ToString() {
            return $"{Id}, {Nome}, {Salario.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }

    
}
