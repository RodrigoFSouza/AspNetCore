using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using BaltaStore.Domain.LojaContexto.Enums;

namespace BaltaStore.Domain.LojaContexto.Entidades
{
    public class Pedido
    {
        private readonly IList<ItemPedido> _itemsPedido;
        private readonly IList<Entrega> _entregas;

        public Pedido(Cliente cliente)
        {
            Cliente = cliente;
            DataCriacao = DateTime.Now;
            Status = EPedidoStatus.CRIADO;
            _itemsPedido = new List<ItemPedido>();
            _entregas = new List<Entrega>();
        }

        public string Numero { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public EPedidoStatus Status { get; private set; }
        public IReadOnlyCollection<ItemPedido> Items => _itemsPedido.ToArray();
        public IReadOnlyCollection<Entrega> Entregas => _entregas.ToArray();
        public Cliente Cliente { get; private set; }

        public void AdicionaItemPedido(ItemPedido itemPedido)
        {
            _itemsPedido.Add(itemPedido);
        }

        public void Fecha() 
        {

        }

        public void Criar()
        {
            Numero = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 8).ToUpper();
        }

        public void Pagar()
        {
            //A Cadas 5 produtos ah uma entrega
            var entregas = new List<Entrega>();
            entregas.Add(new Entrega(DateTime.Now.AddDays(5)));
            var contador = 1;

            foreach (var item in _itemsPedido)
            {
                if (contador == 5)
                {
                    contador = 1;
                    entregas.Add(new Entrega(DateTime.Now.AddDays(5)));
                }
                contador++;
            }
            entregas.ForEach(x => x.Enviar());
            entregas.ForEach(x => _entregas.Add(x));
        }

        public void Enviar()
        {

        }

        public void Cancelar()
        {
            Status = EPedidoStatus.CANCELADO;
            _entregas.ToList().ForEach(x => x.Cancelar());
        }

        public void AdicionaItem(ItemPedido item)
        {
            //Valida item
            //Adiciona o item
        }


    }
}