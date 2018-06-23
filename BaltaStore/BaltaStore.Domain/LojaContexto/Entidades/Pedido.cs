using System;
using System.Collections.Generic;
using System.Transactions;
using BaltaStore.Domain.LojaContexto.Enums;

namespace BaltaStore.Domain.LojaContexto.Entidades
{
    public class Pedido
    {
        public Pedido(Cliente cliente)
        {
            Cliente = cliente;
            Numero = Guid.NewGuid().ToString().Replace("-","").Substring(0,8).ToUpper();
            DataCriacao = DateTime.Now;
            Status = EPedidoStatus.CRIADO;
            Items = new List<ItemPedido>();
            Entregas = new List<Entrega>();
        }

        public string Numero { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public EPedidoStatus Status { get; private set; }
        public IReadOnlyCollection<ItemPedido> Items { get; private set; }
        public IReadOnlyCollection<Entrega> Entregas { get; private set; }
        public Cliente Cliente { get; private set; }

        public void Fecha() 
        {

        }

        public void AdicionaItem(ItemPedido item)
        {
            //Valida item
            //Adiciona o item
        }


    }
}