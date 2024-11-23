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
    public class ContactsRepository
    {
        private readonly string _connectionString;

        public ContactsRepository(string connectionString)
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
                        ID_CONTATO AS Id,
                        NOME_CONTATO AS Name,
                        END_CONTATO AS Address,
                        CEL_CONTATO AS PhoneNumber,
                        EMAIL_CONTATO AS Email,
                        DTCADASTRO_CONTATO AS RegistrationDate,

                        CIDADE.ID_CIDADE AS CityId,
                        CIDADE.NOME_CIDADE AS CityName,
                        CIDADE.UF_CIDADE AS CityFederativeUnit
                    FROM CONTATO
                    INNER JOIN CIDADE
                        ON CONTATO.CIDADE_ID_CIDADE = CIDADE.ID_CIDADE
                    ORDER BY NOME_CONTATO
                ";

                var dataAdapter = new SqlDataAdapter(query, connection);

                dataAdapter.Fill(dataTable);
                dataAdapter.FillSchema(dataTable, SchemaType.Source);
            }

            return dataTable;
        }

        public int Save(Contact contact)
        {
            using (var connection = new SqlConnection(this._connectionString))
            {
                connection.Open();

                string query = @"
                    INSERT INTO CONTATO (
                        NOME_CONTATO,
                        END_CONTATO,
                        CEL_CONTATO,
                        EMAIL_CONTATO,
                        DTCADASTRO_CONTATO,
                        CIDADE_ID_CIDADE
                    )
                    VALUES (
                        @Name,
                        @Address,
                        @PhoneNumber,
                        @Email,
                        @RegistrationDate,
                        @CityId
                    );
                    SELECT CAST(SCOPE_IDENTITY() AS INT);
                ";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.Add(new SqlParameter("@Name", SqlDbType.VarChar));
                command.Parameters.Add(new SqlParameter("@Address", SqlDbType.VarChar));
                command.Parameters.Add(new SqlParameter("@CityId", SqlDbType.Int));
                command.Parameters.Add(new SqlParameter("@PhoneNumber", SqlDbType.VarChar));
                command.Parameters.Add(new SqlParameter("@Email", SqlDbType.VarChar));
                command.Parameters.Add(new SqlParameter("@RegistrationDate", SqlDbType.Date));

                command.Parameters["@Name"].Value = contact.Name;
                command.Parameters["@Address"].Value = contact.Address;
                command.Parameters["@CityId"].Value = contact.CityId;
                command.Parameters["@PhoneNumber"].Value = contact.PhoneNumber;
                command.Parameters["@Email"].Value = contact.Email;
                command.Parameters["@RegistrationDate"].Value = contact.RegistrationDate;

                return (int)command.ExecuteScalar();
            }
        }

        public int Update(Contact contact)
        {
            using (var connection = new SqlConnection(this._connectionString))
            {
                connection.Open();

                string query = @"
                    UPDATE CONTATO SET
                        NOME_CONTATO = @Name,
                        END_CONTATO = @Address,
                        CEL_CONTATO = @PhoneNumber,
                        EMAIL_CONTATO = @Email,
                        DTCADASTRO_CONTATO = @RegistrationDate,
                        CIDADE_ID_CIDADE = @CityId
                    WHERE ID_CONTATO = @Id
                ";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int));
                command.Parameters.Add(new SqlParameter("@Name", SqlDbType.VarChar));
                command.Parameters.Add(new SqlParameter("@Address", SqlDbType.VarChar));
                command.Parameters.Add(new SqlParameter("@CityId", SqlDbType.Int));
                command.Parameters.Add(new SqlParameter("@PhoneNumber", SqlDbType.VarChar));
                command.Parameters.Add(new SqlParameter("@Email", SqlDbType.VarChar));
                command.Parameters.Add(new SqlParameter("@RegistrationDate", SqlDbType.Date));

                command.Parameters["@Id"].Value = contact.Id;
                command.Parameters["@Name"].Value = contact.Name;
                command.Parameters["@Address"].Value = contact.Address;
                command.Parameters["@CityId"].Value = contact.CityId;
                command.Parameters["@PhoneNumber"].Value = contact.PhoneNumber;
                command.Parameters["@Email"].Value = contact.Email;
                command.Parameters["@RegistrationDate"].Value = contact.RegistrationDate;

                return command.ExecuteNonQuery();
            }
        }

        public int Delete(Contact contact)
        {
            using (var connection = new SqlConnection(this._connectionString))
            {
                connection.Open();

                string query = @"
                    DELETE FROM CONTATO
                    WHERE ID_CONTATO = @Id
                ";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int));

                command.Parameters["@Id"].Value = contact.Id;

                return command.ExecuteNonQuery();
            }
        }
    }
}
