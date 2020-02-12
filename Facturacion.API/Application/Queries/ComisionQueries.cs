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

        public async Task<Comision> GetComisionAsync(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var result = await connection.QueryAsync<dynamic>(
                   @"select c.[Id] as ordernumber,o.OrderDate as date, o.Description as description,
                        o.Address_City as city, o.Address_Country as country, o.Address_State as state, o.Address_Street as street, o.Address_ZipCode as zipcode,
                        os.Name as status, 
                        oi.ProductName as productname, oi.Units as units, oi.UnitPrice as unitprice, oi.PictureUrl as pictureurl
                        FROM ordering.Orders o
                        LEFT JOIN ordering.Orderitems oi ON o.Id = oi.orderid 
                        LEFT JOIN ordering.orderstatus os on o.OrderStatusId = os.Id
                        WHERE o.Id=@id"
                        , new { id }
                    );

                if (result.AsList().Count == 0)
                    throw new KeyNotFoundException();

                return MapComisionItems(result);
            }

        }

        private Comision MapComisionItems(dynamic result)
        {
            var comision = new Comision
            {
                Agencia = result[0].agencia,
                Date = result[0].date,
                Facturacion = result[0].facturacion,
                Numero = result[0].numero,
                Pax = result[0].pax,
                Porcentaje = result[0].porcentaje,
                Tipo = result[0].tipo,
                Valor = result[0].valor,
                Voucher = result[0].voucher
            };


            return comision;
        }
    }
}
