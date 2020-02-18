using Facturacion.API.Application.Commands;
using Facturacion.Domain.Aggregates.NotaFiscalAggregate;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Facturacion.API.Application.Handlers
{
    public class CreateNotaFiscalHandler : IRequestHandler<CreateNotaFiscalCommand, bool>
    {
        private readonly INotaFiscalRepository _notafiscalRepository;
        private readonly IMediator _mediator;

        public CreateNotaFiscalHandler (INotaFiscalRepository notafiscalRepository, IMediator mediator)
        {
            _notafiscalRepository = notafiscalRepository;
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }


        public async Task<bool> Handle(CreateNotaFiscalCommand request, CancellationToken cancellationToken)
        {
            var notafiscal = new NotaFiscal(request.NotaFiscalId, request.DateEnvio, request.Empresa, request.NroNota, request.DateRechazo, 
                request.DatePago, request.Valor);

            _notafiscalRepository.Add(notafiscal);

            return await _notafiscalRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);

            //var notafiscal = await _notafiscalRepository.
        }
    }
}
