using Facturacion.Domain.Aggregates.ComisionAggregate;
using Facturacion.Domain.SeedWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.Infrastructure.Repositories
{
    public class ComisionRepository : IComisionRepository
    {

        private readonly FacturacionContext _context;
        public IUnitOfWork UnitOfWork
        {
            get
            {
                return _context;
            }
        }

        public Comision Add(Comision Comisiones)
        {
            if (Comisiones.IsTransient())
            {
                return _context.Comisiones
                    .Add(Comisiones)
                    .Entity;
            }
            else
            {
                return Comisiones;
            }
        }

        public Comision Delete(Comision comision)
        {
            // Prueba
            return comision;
        }


        public async Task<Comision> GetAsync(int comisionId)
        {
            var comision = _context
                            .Comisiones
                            .Local
                            .FirstOrDefault(o => o.Id == comisionId);

            return comision;
        }

        public Comision Update(Comision comision)
        {
            // Prueba
            return comision;
        }
    }
}
