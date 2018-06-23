using System;

namespace BaltaStore.Domain.LojaContexto.Entidades
{
    public class Produto
    {
        public Produto(
            string nome, 
            string descricao, 
            string imagem, 
            decimal preco, 
            decimal quantidade)
        {
            Nome = nome;
            Descricao = descricao;
            Imagem = imagem;
            Preco = preco;
            QuantidadeEmEstoque = quantidade;
        }

        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public decimal Preco { get; set; }
        public decimal QuantidadeEmEstoque { get; set; }

        public override string ToString()
        {
            return $"{Descricao}";
        }
    }
}