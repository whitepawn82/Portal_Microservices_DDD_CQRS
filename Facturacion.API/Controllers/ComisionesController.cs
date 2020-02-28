using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Facturacion.API.Application.Commands;
using Facturacion.API.Application.Queries;
using Facturacion.API.Application.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Comision = Facturacion.API.Application.Models.Comision;
using static Facturacion.API.Application.Handlers.CreateComisionCommandHandler;

namespace Facturacion.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComisionesController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IComisionQueries _comisionQueries;

        public ComisionesController(IMediator mediator, IComisionQueries comisionQueries)
        {
            _mediator = mediator;
            _comisionQueries = comisionQueries;
            //_mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            //_comisionQueries = comisionQueries ?? throw new ArgumentNullException(nameof(comisionQueries));
        }

        [Route("")]
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Comision>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<Comision>>> GetAllComisions()
        {
            var comisions = await _comisionQueries.GetAllComisionsAsync();

            return Ok(comisions);
        }

        [Route("{comisionId}")]
        [HttpGet]
        [ProducesResponseType(typeof(Comision), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> GetComisionAsync(int comisionId)
        {
            try
            {
                var comision = await _comisionQueries.GetComisionAsync(comisionId);

                return Ok(comision);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [Route("alta")]
        [HttpPost]
        //[ProducesResponseType((int)HttpStatusCode.Created)]
        //[ProducesResponseType(StatusCodes.Status201Created)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ComisionDraftDTO>> CreateComisionAsync([FromBody] CreateComisionCommand request)
        {
            return await _mediator.Send(request);
        }

    }

}