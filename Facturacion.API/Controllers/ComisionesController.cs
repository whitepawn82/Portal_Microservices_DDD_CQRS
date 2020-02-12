using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Facturacion.API.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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

        [Route("{comisionId:int}")]
        [HttpGet]
        [ProducesResponseType(typeof(Comision), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<ActionResult> GetComisionAsync(int comisionId)
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

    }

}