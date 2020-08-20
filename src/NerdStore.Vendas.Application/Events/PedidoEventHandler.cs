﻿using System.Threading;
using System.Threading.Tasks;
using MediatR;
using NerdStore.Core.Communication.Mediator;
using NerdStore.Core.Messages.CommonMessages.IntegrationEvents;

namespace NerdStore.Vendas.Application.Events
{
    public class PedidoEventHandler :
        INotificationHandler<PedidoRascunhoIniciadoEvent>,
        INotificationHandler<PedidoAtualizadoEvent>,
        INotificationHandler<PedidoItemAdicionadoEvent>,
		INotificationHandler<PedidoIniciadoEvent>,
		INotificationHandler<PedidoEstoqueRejeitadoEvent>,
		INotificationHandler<PagamentoRealizadoEvent>,
		INotificationHandler<PagamentoRecusadoEvent>
	{
        public Task Handle(PedidoRascunhoIniciadoEvent notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(PedidoAtualizadoEvent notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(PedidoItemAdicionadoEvent notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

		public Task Handle(PedidoIniciadoEvent notification, CancellationToken cancellationToken)
		{
			return Task.CompletedTask;
		}

		public Task Handle(PedidoEstoqueRejeitadoEvent notification, CancellationToken cancellationToken)
		{
			// cancelar o processamento do pedido retornar erro para o cliente

			return Task.CompletedTask;
		}

		public Task Handle(PagamentoRealizadoEvent notification, CancellationToken cancellationToken)
		{
			return Task.CompletedTask;
		}

		public Task Handle(PagamentoRecusadoEvent notification, CancellationToken cancellationToken)
		{
			return Task.CompletedTask;
		}
	}
}