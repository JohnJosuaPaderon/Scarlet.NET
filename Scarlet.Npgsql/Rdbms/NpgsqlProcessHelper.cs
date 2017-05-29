using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Scarlet.Rdbms
{
    public sealed partial class NpgsqlProcessHelper : IDbProcessHelper<NpgsqlConnection, NpgsqlTransaction, NpgsqlCommand, NpgsqlParameter, NpgsqlDataReader>, IDisposable
    {
        public NpgsqlProcessHelper(SecureString secureConnectionString)
        {
            ConnectionEstablisher = new NpgsqlConnectionEstablisher(secureConnectionString);
        }
        
        private NpgsqlConnectionEstablisher ConnectionEstablisher { get; set; }

        public void Dispose()
        {
            ConnectionEstablisher.Dispose();
            ConnectionEstablisher = null;
        }

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
                    return execute(connection, transaction);
                }
            }
        }

        public T ExecuteNonQuery<T>(Func<NpgsqlConnection, NpgsqlCommand> createCommand)
        {
            throw new NotImplementedException();
        }

        public T ExecuteNonQuery<T>(Func<NpgsqlConnection, NpgsqlTransaction, NpgsqlCommand> createCommand)
        {
            throw new NotImplementedException();
        }

        public T ExecuteNonQuery<T>(Func<NpgsqlConnection, NpgsqlCommand> createCommand, Func<int, NpgsqlCommand, T> postAction)
        {
            throw new NotImplementedException();
        }

        public T ExecuteNonQuery<T>(Func<NpgsqlConnection, NpgsqlTransaction, NpgsqlCommand> createCommand, Func<int, NpgsqlCommand, T> postAction)
        {
            throw new NotImplementedException();
        }

        public Task<T> ExecuteNonQueryAsync<T>(Func<NpgsqlConnection, T> execute)
        {
            throw new NotImplementedException();
        }

        public Task<T> ExecuteNonQueryAsync<T>(Func<NpgsqlConnection, NpgsqlTransaction, T> execute)
        {
            throw new NotImplementedException();
        }

        public Task<T> ExecuteNonQueryAsync<T>(Func<NpgsqlConnection, Task<T>> executeAsync)
        {
            throw new NotImplementedException();
        }

        public Task<T> ExecuteNonQueryAsync<T>(Func<NpgsqlConnection, NpgsqlTransaction, Task<T>> executeAsync)
        {
            throw new NotImplementedException();
        }

        public Task<T> ExecuteNonQueryAsync<T>(Func<NpgsqlConnection, NpgsqlCommand> createCommand)
        {
            throw new NotImplementedException();
        }

        public Task<T> ExecuteNonQueryAsync<T>(Func<NpgsqlConnection, NpgsqlTransaction, NpgsqlCommand> createCommand)
        {
            throw new NotImplementedException();
        }

        public Task ExecuteNonQueryAsync(Func<NpgsqlConnection, NpgsqlCommand> createCommand, Action<int, NpgsqlCommand> postAction)
        {
            throw new NotImplementedException();
        }

        public Task ExecuteNonQueryAsync(Func<NpgsqlConnection, NpgsqlTransaction, NpgsqlCommand> createCommand, Action<int, NpgsqlCommand> postAction)
        {
            throw new NotImplementedException();
        }

        public Task<T> ExecuteNonQueryAsync<T>(Func<NpgsqlConnection, NpgsqlCommand> createCommand, Func<int, NpgsqlCommand, T> postAction)
        {
            throw new NotImplementedException();
        }

        public Task<T> ExecuteNonQueryAsync<T>(Func<NpgsqlConnection, NpgsqlTransaction, NpgsqlCommand> createCommand, Func<int, NpgsqlCommand, T> postAction)
        {
            throw new NotImplementedException();
        }

        public T ExecuteReader<T>(Func<NpgsqlConnection, NpgsqlCommand> createCommand, Func<NpgsqlDataReader, T> fromReader)
        {
            throw new NotImplementedException();
        }

        public T ExecuteReader<T>(Func<NpgsqlConnection, NpgsqlTransaction, NpgsqlCommand> createCommand, Func<NpgsqlDataReader, T> fromReader)
        {
            throw new NotImplementedException();
        }

        public Task<T> ExecuteReaderAsync<T>(Func<NpgsqlConnection, NpgsqlCommand> createCommand, Func<NpgsqlDataReader, T> fromReader)
        {
            throw new NotImplementedException();
        }

        public Task<T> ExecuteReaderAsync<T>(Func<NpgsqlConnection, NpgsqlTransaction, NpgsqlCommand> createCommand, Func<NpgsqlDataReader, T> fromReader)
        {
            throw new NotImplementedException();
        }

        public Task<T> ExecuteReaderAsync<T>(Func<NpgsqlConnection, NpgsqlCommand> createCommand, Func<NpgsqlDataReader, Task<T>> fromReaderAsync)
        {
            throw new NotImplementedException();
        }

        public Task<T> ExecuteReaderAsync<T>(Func<NpgsqlConnection, NpgsqlTransaction, NpgsqlCommand> createCommand, Func<NpgsqlDataReader, Task<T>> fromReaderAsync)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> ExecuteReaderIEnumerable<T>(Func<NpgsqlConnection, NpgsqlCommand> createCommand, Func<NpgsqlDataReader, T> fromReader)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> ExecuteReaderIEnumerable<T>(Func<NpgsqlConnection, NpgsqlTransaction, NpgsqlCommand> createCommand, Func<NpgsqlDataReader, T> fromReader)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> ExecuteReaderIEnumerableAsync<T>(Func<NpgsqlConnection, NpgsqlCommand> createCommand, Func<NpgsqlDataReader, T> fromReader)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> ExecuteReaderIEnumerableAsync<T>(Func<NpgsqlConnection, NpgsqlTransaction, NpgsqlCommand> createCommand, Func<NpgsqlDataReader, T> fromReader)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> ExecuteReaderIEnumerableAsync<T>(Func<NpgsqlConnection, NpgsqlCommand> createCommand, Func<NpgsqlDataReader, Task<T>> fromReaderAsync)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> ExecuteReaderIEnumerableAsync<T>(Func<NpgsqlConnection, NpgsqlTransaction, NpgsqlCommand> createCommand, Func<NpgsqlDataReader, Task<T>> fromReaderAsync)
        {
            throw new NotImplementedException();
        }

        public T ExecuteScalar<T>(Func<NpgsqlConnection, NpgsqlCommand> createCommand, Func<object, T> converter)
        {
            throw new NotImplementedException();
        }

        public T ExecuteScalar<T>(Func<NpgsqlConnection, NpgsqlTransaction, NpgsqlCommand> createCommand, Func<object> converter)
        {
            throw new NotImplementedException();
        }

        public Task<T> ExecuteScalarAsync<T>(Func<NpgsqlConnection, NpgsqlCommand> createCommand, Func<object, T> converter)
        {
            throw new NotImplementedException();
        }

        public Task<T> ExecuteScalarAsync<T>(Func<NpgsqlConnection, NpgsqlTransaction, NpgsqlCommand> createCommand, Func<object, T> converter)
        {
            throw new NotImplementedException();
        }
    }
}
