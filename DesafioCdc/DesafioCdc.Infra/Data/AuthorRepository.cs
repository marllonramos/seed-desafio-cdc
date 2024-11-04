using DesafioCdc.Domain.Entitites;
using DesafioCdc.Domain.Repositories;
using Npgsql;

namespace DesafioCdc.Infra.Data
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly string _connectionString;

        public AuthorRepository()
        {
            _connectionString = "User ID=postgres;Password=1234;Host=localhost;Port=5432;Database=postgres;Timeout=30;SearchPath=dev_eficiente";
        }

        public async Task CreateAuthor(Author author)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(_connectionString))
            {
                await conn.OpenAsync();

                string query = @"INSERT INTO 
                                 author (id, name, email, description, date_on)
                                 VALUES (@id, @name, @email, @description, @date_on)";

                NpgsqlCommand cmd = new NpgsqlCommand(query.ToString(), conn);

                cmd.Parameters.AddWithValue("id", NpgsqlTypes.NpgsqlDbType.Uuid, author.Id);
                cmd.Parameters.AddWithValue("name", NpgsqlTypes.NpgsqlDbType.Varchar, author.Name);
                cmd.Parameters.AddWithValue("email", NpgsqlTypes.NpgsqlDbType.Varchar, author.Email);
                cmd.Parameters.AddWithValue("description", NpgsqlTypes.NpgsqlDbType.Varchar, author.Description);
                cmd.Parameters.AddWithValue("date_on", NpgsqlTypes.NpgsqlDbType.Timestamp, author.DateOn);

                await cmd.ExecuteNonQueryAsync();
            }
        }
    }
}
