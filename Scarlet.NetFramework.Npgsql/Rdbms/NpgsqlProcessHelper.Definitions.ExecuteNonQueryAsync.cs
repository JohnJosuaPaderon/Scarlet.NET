using Npgsql;
using System;
using System.Threading.Tasks;

namespace Scarlet.Rdbms
{
    partial class NpgsqlProcessHelper
    {
        public async Task<T> ExecuteNonQueryAsync<T>(Func<NpgsqlConnection, T> execute)
        {
            using (var connection = await ConnectionEstablisher.EstablishAsync())
            {
                return execute(connection);
            }
        }

        public async Task<T> ExecuteNonQueryAsync<T>(Func<NpgsqlConnection, NpgsqlTransaction, T> execute)
        {
            using (var connection = await ConnectionEstablisher.EstablishAsync())
            {
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        var result = execute(connection, transaction);
                        await transaction.CommitAsync();
                        return result;
                    }
                    catch (Exception)
                    {
                        await transaction.RollbackAsync();
                        throw;
                    }
                }
            }
        }

        public async Task<T> ExecuteNonQueryAsync<T>(Func<NpgsqlConnection, Task<T>> executeAsync)
        {
            using (var connection = await ConnectionEstablisher.EstablishAsync())
            {
                return await executeAsync(connection);
            }
        }

        public async Task<T> ExecuteNonQueryAsync<T>(Func<NpgsqlConnection, NpgsqlTransaction, Task<T>> executeAsync)
        {
            using (var connection = await ConnectionEstablisher.EstablishAsync())
            {
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        var result = await executeAsync(connection, transaction);
                        await transaction.CommitAsync();
                        return result;
                    }
                    catch (Exception)
                    {
                        await transaction.RollbackAsync();
                        throw;
                    }
                }
            }
        }

        public async Task ExecuteNonQueryAsync(Func<NpgsqlConnection, NpgsqlCommand> createCommand, Action<int, NpgsqlCommand> postAction)
        {
            using (var connection = await ConnectionEstablisher.EstablishAsync())
            {
                using (var command = createCommand(connection))
                {
                    postAction(await command.ExecuteNonQueryAsync(), command);
                }
            }
        }

        public async Task ExecuteNonQueryAsync(Func<NpgsqlConnection, NpgsqlTransaction, NpgsqlCommand> createCommand, Action<int, NpgsqlCommand> postAction)
        {
            using (var connection = await ConnectionEstablisher.EstablishAsync())
            {
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        using (var command = createCommand(connection, transaction))
                        {
                            postAction(await command.ExecuteNonQueryAsync(), command);
                            await transaction.CommitAsync();
                        }
                    }
                    catch (Exception)
                    {
                        await transaction.RollbackAsync();
                        throw;
                    }
                }
            }
        }

        public async Task<T> ExecuteNonQueryAsync<T>(Func<NpgsqlConnection, NpgsqlCommand> createCommand, Func<int, NpgsqlCommand, T> postAction)
        {
            using (var connection = await ConnectionEstablisher.EstablishAsync())
            {
                using (var command = createCommand(connection))
                {
                    return postAction(await command.ExecuteNonQueryAsync(), command);
                }
            }
        }

        public async Task<T> ExecuteNonQueryAsync<T>(Func<NpgsqlConnection, NpgsqlTransaction, NpgsqlCommand> createCommand, Func<int, NpgsqlCommand, T> postAction)
        {
            using (var connection = await ConnectionEstablisher.EstablishAsync())
            {
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        using (var command = createCommand(connection, transaction))
                        {
                            var result = postAction(await command.ExecuteNonQueryAsync(), command);
                            await transaction.CommitAsync();
                            return result;
                        }
                    }
                    catch (Exception)
                    {
                        await transaction.RollbackAsync();
                        throw;
                    }
                }
            }
        }
    }
}
