using Facturacion.API.Application.Commands;
using Facturacion.Domain.Aggregates.ComisionAggregate;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Facturacion.API.Application.Handlers
{
    public class CreateComisionCommandHandler : IRequestHandler<CreateComisionCommand, bool>
    {
        private readonly IComisionRepository _comisionRepository;
        private readonly IMediator _mediator;

        public CreateComisionCommandHandler(IComisionRepository comisionRepository, IMediator mediator)
        {
            _comisionRepository = comisionRepository ?? throw new ArgumentNullException(nameof(comisionRepository)); ;
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        public async Task<bool> Handle(CreateComisionCommand request, CancellationToken cancellationToken)
        {
            var comision = new Comision(request.NotaFiscalId, request.NotaFiscalId, request.Numero, request.DateEmision, request.DatePago, request.Pax, request.Facturacion, request.Porcentaje, request.Valor, request.Tipo, request.Voucher, request.Agencia, request.Orden);

            _comisionRepository.Add(comision);

            return await _comisionRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);
        }
    }
}
