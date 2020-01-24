using System;
using System.Collections.Generic;
using System.Text;

namespace Facturacion.Domain.SharedKernel
{
    public class StatusValue
    {
        public string Status { get;}

        public StatusValue(string status)
        {
            this.Status = status;
        }
    }
}
