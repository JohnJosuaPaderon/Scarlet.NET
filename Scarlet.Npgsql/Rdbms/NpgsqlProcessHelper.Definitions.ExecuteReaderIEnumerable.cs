using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Scarlet.Rdbms
{
    partial class NpgsqlProcessHelper
    {
        public IEnumerable<T> ExecuteReaderIEnumerable<T>(Func<NpgsqlConnection, NpgsqlCommand> createCommand, Func<NpgsqlDataReader, T> fromReader)
        {
            using (var connection = ConnectionEstablisher.Establish())
            {
                using (var command = createCommand(connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            var result = new List<T>();

                            while (reader.Read())
                            {
                                result.Add(fromReader(reader));
                            }

                            return result;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }

        public async Task<IEnumerable<T>> ExecuteReaderIEnumerableAsync<T>(Func<NpgsqlConnection, NpgsqlCommand> createCommand, Func<DbDataReader, T> fromReader)
        {
            using (var connection = await ConnectionEstablisher.EstablishAsync())
            {
                using (var command = createCommand(connection))
                {
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                        {
                            var result = new List<T>();

                            while (await reader.ReadAsync())
                            {
                                result.Add(fromReader(reader));
                            }

                            return result;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }

        public async Task<IEnumerable<T>> ExecuteReaderIEnumerableAsync<T>(Func<NpgsqlConnection, NpgsqlCommand> createCommand, Func<DbDataReader, Task<T>> fromReaderAsync)
        {
            using (var connection = await ConnectionEstablisher.EstablishAsync())
            {
                using (var command = createCommand(connection))
                {
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                        {
                            var result = new List<T>();

                            while (await reader.ReadAsync())
                            {
                                result.Add(await fromReaderAsync(reader));
                            }

                            return result;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }
    }
}
