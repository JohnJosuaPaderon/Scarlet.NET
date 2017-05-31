using Npgsql;
using System;

namespace Scarlet.Rdbms
{
    partial class NpgsqlProcessHelper
    {
        public T ExecuteNonQuery<T>(Func<NpgsqlConnection, T> execute)
        {
            using (var connection = ConnectionEstablisher.Establish())
            {
                return execute(connection);
            }
        }

        public T ExecuteNonQuery<T>(Func<NpgsqlConnection, NpgsqlTransaction, T> execute)
        {
            using (var connection = ConnectionEstablisher.Establish())
            {
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        var result = execute(connection, transaction);
                        transaction.Commit();
                        return result;
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public T ExecuteNonQuery<T>(Func<NpgsqlConnection, NpgsqlCommand> createCommand, Func<int, NpgsqlCommand, T> postAction)
        {
            using (var connection = ConnectionEstablisher.Establish())
            {
                using (var command = createCommand(connection))
                {
                    return postAction(command.ExecuteNonQuery(), command);
                }
            }
        }

        public T ExecuteNonQuery<T>(Func<NpgsqlConnection, NpgsqlTransaction, NpgsqlCommand> createCommand, Func<int, NpgsqlCommand, T> postAction)
        {
            using (var connection = ConnectionEstablisher.Establish())
            {
                using (var transaction = connection.BeginTransaction())
                {
                    using (var command = createCommand(connection, transaction))
                    {
                        try
                        {
                            var result = postAction(command.ExecuteNonQuery(), command);
                            transaction.Commit();
                            return result;
                        }
                        catch (Exception)
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
            }
        }
    }
}
