using System;
using System.Globalization;

namespace Course {
    internal class Produto {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto(string nome, double preco, int quantidade) {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double ValorTotalEmEstoque() {
            return Quantidade * Preco;
        }
        public void AdicionaProdutos(int quantity) {
            Quantidade += quantity;
        }
        public void RemoverProdutos(int quantity) {
            Quantidade -= quantity;
        }

        public override string ToString() {
            return $"{Nome}, $ {Preco.ToString("F2", CultureInfo.InvariantCulture)}, {Quantidade} unidades, Total $ {ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}

