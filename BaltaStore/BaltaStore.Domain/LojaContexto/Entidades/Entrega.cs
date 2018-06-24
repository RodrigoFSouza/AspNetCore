using System;
using BaltaStore.Domain.LojaContexto.Enums;

namespace BaltaStore.Domain.LojaContexto.Entidades
{
    public class Entrega
    {
        public Entrega(DateTime dataEstimadaDaEntrega)
        {
            DataCriacao = DateTime.Now;
            DataEntrega = dataEstimadaDaEntrega;
            Status = EEntregaStatus.AGUARDANDO;
        }

        public DateTime DataCriacao { get; set; }
        public DateTime DataEntrega { get; set; } 
        public EEntregaStatus Status { get; set; }

        public void Enviar()
        {
            Status = EEntregaStatus.ENVIADO;
        }

        public void Cancelar()
        {
            // Se o status da entrega for Entregue não é possível cancelar.
            Status = EEntregaStatus.CANCELADO;
        }

    }
}