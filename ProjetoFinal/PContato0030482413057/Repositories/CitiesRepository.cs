using PContato0030482413057.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PContato0030482413057.Repositories
{
    public class CitiesRepository
    {
        private readonly string _connectionString;

        public CitiesRepository(string connectionString)
        {
            this._connectionString = connectionString;
        }

        public DataTable GetAll()
        {
            DataTable dataTable = new DataTable();

            using (var connection = new SqlConnection(this._connectionString))
            {
                connection.Open();

                string query = @"
                    SELECT
                        ID_CIDADE AS Id,
                        NOME_CIDADE AS Name,
                        UF_CIDADE AS FederativeUnit
                    FROM CIDADE
                    ORDER BY NOME_CIDADE
                ";

                var dataAdapter = new SqlDataAdapter(query, connection);

                dataAdapter.Fill(dataTable);
                dataAdapter.FillSchema(dataTable, SchemaType.Source);
            }

            return dataTable;
        }
    }
}
