using System;
using System.Globalization;

namespace Course {
    internal class Produto {

        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto() {

        }

        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public string GetNome() {
            return _nome;
        }
        public void SetNome(string nome) {
            _nome = nome;
        }


        public double ValorTotalEmEstoque() {
            return _quantidade * _preco;
        }
        public void AdicionarProdutos(int quantity) {
            _quantidade += quantity;
        }
        public void RemoverProdutos(int quantity) {
            _quantidade -= quantity;
        }

        public override string ToString() {
            return $"{_nome}, $ {_preco.ToString("F2", CultureInfo.InvariantCulture)}, {_quantidade} unidades, Total $ {ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}

