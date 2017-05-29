using Npgsql;
using System;
using System.Threading.Tasks;

namespace Scarlet.Rdbms
{
    partial class NpgsqlProcessHelper
    {
        public T ExecuteScalar<T>(Func<NpgsqlConnection, NpgsqlCommand> createCommand, Func<object, T> converter)
        {
            using (var connection = ConnectionEstablisher.Establish())
            {
                using (var command = createCommand(connection))
                {
                    return converter(command.ExecuteScalar());
                }
            }
        }

        public async Task<T> ExecuteScalarAsync<T>(Func<NpgsqlConnection, NpgsqlCommand> createCommand, Func<object, T> converter)
        {
            using (var connection = await ConnectionEstablisher.EstablishAsync())
            {
                using (var command = createCommand(connection))
                {
                    return converter(await command.ExecuteScalarAsync());
                }
            }
        }
    }
}
