using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Scarlet.Rdbms
{
    public interface IDbProcessHelper<TConnection, TTransaction, TCommand, TParameter, TDbDataReader>
        where TConnection : DbConnection
        where TTransaction : DbTransaction
        where TCommand : DbCommand
        where TParameter : DbParameter
        where TDbDataReader : DbDataReader 
    {
        T ExecuteNonQuery<T>(Func<TConnection, T> execute);
        T ExecuteNonQuery<T>(Func<TConnection, TTransaction, T> execute);
        Task<T> ExecuteNonQueryAsync<T>(Func<TConnection, T> execute);
        Task<T> ExecuteNonQueryAsync<T>(Func<TConnection, TTransaction, T> execute);
        Task<T> ExecuteNonQueryAsync<T>(Func<TConnection, Task<T>> executeAsync);
        Task<T> ExecuteNonQueryAsync<T>(Func<TConnection, TTransaction, Task<T>> executeAsync);
        T ExecuteNonQuery<T>(Func<TConnection, TCommand> createCommand);
        T ExecuteNonQuery<T>(Func<TConnection, TTransaction, TCommand> createCommand);
        Task<T> ExecuteNonQueryAsync<T>(Func<TConnection, TCommand> createCommand);
        Task<T> ExecuteNonQueryAsync<T>(Func<TConnection, TTransaction, TCommand> createCommand);
        Task ExecuteNonQueryAsync(Func<TConnection, TCommand> createCommand, Action<int, TCommand> postAction);
        Task ExecuteNonQueryAsync(Func<TConnection, TTransaction, TCommand> createCommand, Action<int, TCommand> postAction);
        T ExecuteNonQuery<T>(Func<TConnection, TCommand> createCommand, Func<int, TCommand, T> postAction);
        T ExecuteNonQuery<T>(Func<TConnection, TTransaction, TCommand> createCommand, Func<int, TCommand, T> postAction);
        Task<T> ExecuteNonQueryAsync<T>(Func<TConnection, TCommand> createCommand, Func<int, TCommand, T> postAction);
        Task<T> ExecuteNonQueryAsync<T>(Func<TConnection, TTransaction, TCommand> createCommand, Func<int, TCommand, T> postAction);
        T ExecuteReader<T>(Func<TConnection, TCommand> createCommand, Func<TDbDataReader, T> fromReader);
        T ExecuteReader<T>(Func<TConnection, TTransaction, TCommand> createCommand, Func<TDbDataReader, T> fromReader);
        Task<T> ExecuteReaderAsync<T>(Func<TConnection, TCommand> createCommand, Func<TDbDataReader, T> fromReader);
        Task<T> ExecuteReaderAsync<T>(Func<TConnection, TTransaction, TCommand> createCommand, Func<TDbDataReader, T> fromReader);
        Task<T> ExecuteReaderAsync<T>(Func<TConnection, TCommand> createCommand, Func<TDbDataReader, Task<T>> fromReaderAsync);
        Task<T> ExecuteReaderAsync<T>(Func<TConnection, TTransaction, TCommand> createCommand, Func<TDbDataReader, Task<T>> fromReaderAsync);
        IEnumerable<T> ExecuteReaderIEnumerable<T>(Func<TConnection, TCommand> createCommand, Func<TDbDataReader, T> fromReader);
        IEnumerable<T> ExecuteReaderIEnumerable<T>(Func<TConnection, TTransaction, TCommand> createCommand, Func<TDbDataReader, T> fromReader);
        Task<IEnumerable<T>> ExecuteReaderIEnumerableAsync<T>(Func<TConnection, TCommand> createCommand, Func<TDbDataReader, T> fromReader);
        Task<IEnumerable<T>> ExecuteReaderIEnumerableAsync<T>(Func<TConnection, TTransaction, TCommand> createCommand, Func<TDbDataReader, T> fromReader);
        Task<IEnumerable<T>> ExecuteReaderIEnumerableAsync<T>(Func<TConnection, TCommand> createCommand, Func<TDbDataReader, Task<T>> fromReaderAsync);
        Task<IEnumerable<T>> ExecuteReaderIEnumerableAsync<T>(Func<TConnection, TTransaction, TCommand> createCommand, Func<TDbDataReader, Task<T>> fromReaderAsync);
        T ExecuteScalar<T>(Func<TConnection, TCommand> createCommand, Func<object, T> converter);
        T ExecuteScalar<T>(Func<TConnection, TTransaction, TCommand> createCommand, Func<object> converter);
        Task<T> ExecuteScalarAsync<T>(Func<TConnection, TCommand> createCommand, Func<object, T> converter);
        Task<T> ExecuteScalarAsync<T>(Func<TConnection, TTransaction, TCommand> createCommand, Func<object, T> converter);
    }
}
