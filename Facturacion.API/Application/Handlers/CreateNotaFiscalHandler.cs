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

        public CreateNotaFiscalHandler (INotaFiscalRepository notafiscalRepository)
        {
            _notafiscalRepository = notafiscalRepository;
        }


        public async Task<bool> Handle(CreateNotaFiscalCommand request, CancellationToken cancellationToken)
        {
            var notafiscal = new NotaFiscal(request.DateEnvio, request.Empresa, request.NroNota, request.DateRechazo, 
                request.DatePago, request.Valor);

            _notafiscalRepository.Add(notafiscal);

            return await _notafiscalRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);

            //var notafiscal = await _notafiscalRepository.
        }
    }
}
