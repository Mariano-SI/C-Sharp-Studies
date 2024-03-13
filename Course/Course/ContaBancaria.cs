using System;
using System.Globalization;

namespace Course {
    internal class ContaBancaria {
        public int Numero { get; }
        public string Titular { get; set; }

        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string nome) {
            Numero = numero;
            Titular = nome;
        }

        public ContaBancaria(int numero, string nome, double saldo) :this(numero, nome) {
            Saldo = saldo;
        }

        public void Deposito(double quantia) {
            Saldo += quantia;

        }public void Saque(double quantia) {
            Saldo -= (quantia + 5);
        }

        public override string ToString() {
            return $"Conta {Numero}, Titular: {Titular}, Saldo: $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
