﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facturacion.API.Application.Queries
{
    public interface IAgenciaQueries
    {
        Task<Agencia> GetAgenciaAsync(int id);
    }
}
