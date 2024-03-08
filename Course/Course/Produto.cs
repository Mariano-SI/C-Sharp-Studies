using System;

namespace Course {
    internal class Produto {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque() {
            return Quantidade * Preco;
        }
        public void AdicionaProdutos(int quantity) {
            Quantidade += quantity;
        }
        public void RemoverProdutos(int quantity) {
            Quantidade -= quantity;
        }
    }
}
