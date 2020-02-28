using Facturacion.API.Application.Commands;
using Facturacion.Domain.Aggregates.ComisionAggregate;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static Facturacion.API.Application.Handlers.CreateComisionCommandHandler;

namespace Facturacion.API.Application.Handlers
{
    public class CreateComisionCommandHandler : IRequestHandler<CreateComisionCommand, ComisionDraftDTO>
    {
        private readonly IComisionRepository _comisionRepository;
        private readonly IMediator _mediator;

        public CreateComisionCommandHandler(IComisionRepository comisionRepository, IMediator mediator)
        {
            _comisionRepository = comisionRepository ?? throw new ArgumentNullException(nameof(comisionRepository)); ;
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        //public async Task<bool> Handle(CreateComisionCommand request, CancellationToken cancellationToken)
        //{
        //    var comision = new Comision(request.NotaFiscalId, request.NotaFiscalId, request.Numero, request.DateEmision, request.DatePago, request.Pax, request.Facturacion, request.Porcentaje, request.Valor, request.Tipo, request.Voucher, request.Agencia, request.Orden);

        //    _comisionRepository.Add(comision);

        //    return await _comisionRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);
        //}

        public Task<ComisionDraftDTO> Handle(CreateComisionCommand request, CancellationToken cancellationToken)
        {

            var comision = new Comision(request.ComisionId, request.NotaFiscalId, request.Numero, request.DateEmision, request.DatePago, 
                request.Pax, request.Facturacion, request.Porcentaje, request.Valor, request.Tipo, request.Voucher, request.Agencia, request.Orden);

            _comisionRepository.Add(comision);

            return Task.FromResult(ComisionDraftDTO.FromComision(comision));
        }

        public class ComisionDraftDTO
        {
            public int ComisionId { get; set; }

            public int StatusId { get; set; }

            public int NotaFiscalId { get; set; }

            public int Numero { get; set; }

            public DateTime DateEmision { get; set; }

            public DateTime DatePago { get; set; }

            public string Pax { get; set; }

            public int Facturacion { get; set; }

            public decimal Porcentaje { get; set; }

            public float Valor { get; set; }

            public string Tipo { get; set; }

            public string Voucher { get; set; }

            public string Agencia { get; set; }

            public int Orden { get; set; }


            public static ComisionDraftDTO FromComision(Comision comision)
            {
                return new ComisionDraftDTO()
                {
                    ComisionId = comision.ComisionId,
                    NotaFiscalId = comision.NotaFiscalId,
                    StatusId = comision.StatusId,
                    Numero = comision.Numero,
                    DateEmision = comision.DateEmision,
                    DatePago = comision.DatePago,
                    Pax = comision.Pax,
                    Facturacion = comision.Facturacion,
                    Porcentaje = comision.Porcentaje,
                    Valor = comision.Valor,
                    Tipo = comision.Tipo,
                    Voucher = comision.Voucher,
                    Agencia = comision.Agencia,
                    Orden = comision.Orden,

                };
            }

        }
    }
}
