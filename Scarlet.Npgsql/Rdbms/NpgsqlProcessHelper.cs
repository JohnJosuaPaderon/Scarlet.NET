using Npgsql;
using System;
using System.Collections.Generic;
using System.Security;
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

        public T ExecuteReader<T>(Func<NpgsqlConnection, NpgsqlCommand> createCommand, Func<NpgsqlDataReader, T> fromReader)
        {
            throw new NotImplementedException();
        }

        public Task<T> ExecuteReaderAsync<T>(Func<NpgsqlConnection, NpgsqlCommand> createCommand, Func<NpgsqlDataReader, T> fromReader)
        {
            throw new NotImplementedException();
        }

        public Task<T> ExecuteReaderAsync<T>(Func<NpgsqlConnection, NpgsqlCommand> createCommand, Func<NpgsqlDataReader, Task<T>> fromReaderAsync)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> ExecuteReaderIEnumerable<T>(Func<NpgsqlConnection, NpgsqlCommand> createCommand, Func<NpgsqlDataReader, T> fromReader)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> ExecuteReaderIEnumerableAsync<T>(Func<NpgsqlConnection, NpgsqlCommand> createCommand, Func<NpgsqlDataReader, T> fromReader)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> ExecuteReaderIEnumerableAsync<T>(Func<NpgsqlConnection, NpgsqlCommand> createCommand, Func<NpgsqlDataReader, Task<T>> fromReaderAsync)
        {
            throw new NotImplementedException();
        }

        public T ExecuteScalar<T>(Func<NpgsqlConnection, NpgsqlCommand> createCommand, Func<object, T> converter)
        {
            throw new NotImplementedException();
        }

        public Task<T> ExecuteScalarAsync<T>(Func<NpgsqlConnection, NpgsqlCommand> createCommand, Func<object, T> converter)
        {
            throw new NotImplementedException();
        }
    }
}
