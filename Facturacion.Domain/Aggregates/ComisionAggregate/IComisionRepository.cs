using Facturacion.Domain.SeedWork;
using System.Threading.Tasks;

namespace Facturacion.Domain.Aggregates.ComisionAggregate
{
    public interface IComisionRepository : IRepository<Comision>
    {
        Comision Delete(Comision comision);

        Task<Comision> FindAsync(string ComisionIdentityId);

        Comision Add(Comision comision);

    }
}
