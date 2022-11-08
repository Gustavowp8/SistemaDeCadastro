using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteApp
{
    internal class Produto
    {
        private string Nome;

        public string nome
        {
            get { return Nome; }
            set
            {
                if (value.Length > 1)
                    Nome = value;
                else
                    throw new Exception("Nome do produto deve ter pelo menos 2 caracteres");
            }
        }

        public double Preco { get; set; }

        public int Estoque { get; private set; }

        public Produto()
        {
            this.Estoque = 0;
        }

        public Produto(string nome, double preco)
        {
            this.nome = nome;
            this.Preco = preco;
            this.Estoque = 0;
        }

        public int Vender(int qtde)
        {
            if(this.Estoque - qtde >= 0)
                this.Estoque -= qtde;
            return this.Estoque;
        }

        public int Comprar(int qtde)
        {
            this.Estoque += qtde;
            return this.Estoque;
        }

        public string ObterTexto()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"\nNome: {this.nome}\n");
            sb.Append($"Preço: {this.Preco}\n");
            sb.Append($"Estoque: {this.Estoque}\n");
            return sb.ToString();
            //Aula05
        }
    }
}
