using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facturacion.API.Application.Queries
{
    public interface IComisionQueries
    {
        Task<Comision> GetComisionAsync(int id);

        Task<IEnumerable<Comision>> GetAllComisionsAsync();
    }
}
