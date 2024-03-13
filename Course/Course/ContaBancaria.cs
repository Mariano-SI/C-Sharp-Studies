using System;
using System.Globalization;

namespace Course {
    internal class ContaBancaria {
        public int Numero { get; }
        public string NomeTitular { get; set; }

        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string nomeTitular) {
            Numero = numero;
            NomeTitular = nomeTitular;
        }

        public ContaBancaria(int numero, string nomeTitular, double depositoInicial) {
            Numero = numero;
            NomeTitular = nomeTitular;
            Saldo = depositoInicial;
        }

        public void Deposito(double valor) {
            Saldo += valor;

        }public void Saque(double valor) {
            Saldo -= (valor + 5);
        }

        public override string ToString() {
            return $"Conta {Numero}, Titular: {NomeTitular}, Saldo: $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
