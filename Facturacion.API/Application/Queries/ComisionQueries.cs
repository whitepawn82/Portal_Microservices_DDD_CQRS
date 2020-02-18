using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facturacion.API.Application.Queries
{
    public class ComisionQueries : IComisionQueries
    {

        private string _connectionString = string.Empty;

        public ComisionQueries(string constr)
        {
            _connectionString = !string.IsNullOrWhiteSpace(constr) ? constr : throw new ArgumentNullException(nameof(constr));
        }

        public async Task<IEnumerable<Comision>> GetAllComisionsAsync()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                return await connection.QueryAsync<Comision>("select * from facturacion.Comisiones");
            }
        }

        public async Task<Comision> GetComisionAsync(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var result = await connection.QueryAsync<dynamic>(
                   @"select * from facturacion.Comisiones as c 
                        WHERE c.ComisionId = @id"
                        , new { id }
                    );

                if (result.AsList().Count == 0)
                    throw new KeyNotFoundException();

                return MapComisionItems(result);

                //return await connection.QueryAsync<Comision>("select * from facturacion.Comisiones as c");
            }
        }

        private Comision MapComisionItems(dynamic result)
        {
            var comision = new Comision
            {
                Agencia = result[0].Agencia,
                Date = result[0].DateEmision,
                Facturacion = result[0].Facturacion,
                Numero = result[0].Numero,
                Pax = result[0].Pax,
                Porcentaje = result[0].Porcentaje,
                Tipo = result[0].Tipo,
                Valor = result[0].Valor,
                StatusId = result[0].StatusId,
                Voucher = result[0].Voucher
            };


            return comision;
        }
    }
}
