using Npgsql;
using System;
using System.Data.Common;
using System.Threading.Tasks;

namespace Scarlet.Rdbms
{
    partial class NpgsqlProcessHelper
    {
        public T ExecuteReader<T>(Func<NpgsqlConnection, NpgsqlCommand> createCommand, Func<NpgsqlDataReader, T> fromReader)
        {
            using (var connection = ConnectionEstablisher.Establish())
            {
                using (var command = createCommand(connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            return fromReader(reader);
                        }
                        else
                        {
                            return default(T);
                        }
                    }
                }
            }
        }

        public async Task<T> ExecuteReaderAsync<T>(Func<NpgsqlConnection, NpgsqlCommand> createCommand, Func<DbDataReader, T> fromReader)
        {
            using (var connection = await ConnectionEstablisher.EstablishAsync())
            {
                using (var command = createCommand(connection))
                {
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                        {
                            await reader.ReadAsync();
                            return fromReader(reader);
                        }
                        else
                        {
                            return default(T);
                        }
                    }
                }
            }
        }

        public async Task<T> ExecuteReaderAsync<T>(Func<NpgsqlConnection, NpgsqlCommand> createCommand, Func<DbDataReader, Task<T>> fromReaderAsync)
        {
            using (var connection = await ConnectionEstablisher.EstablishAsync())
            {
                using (var command = createCommand(connection))
                {
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                        {
                            await reader.ReadAsync();
                            return await fromReaderAsync(reader);
                        }
                        else
                        {
                            return default(T);
                        }
                    }
                }
            }
        }
    }
}
