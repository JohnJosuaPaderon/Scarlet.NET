using System;
using System.Data.Common;
using System.Threading;
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
        int HandleExecute(Func<TConnection, int> execute);
        int HandleExecute(Func<TConnection, TTransaction, int> execute);
        Task<int> HandleExecuteAsync(Func<TConnection, int> execute);
        Task<int> HandleExecuteAsync(Func<TConnection, TTransaction, int> execute);
        Task<int> HandleExecuteAsync(Func<TConnection, int> execute, CancellationToken cancellationToken);
        Task<int> HandleExecuteAsync(Func<TConnection, TTransaction, int> execute, CancellationToken cancellationToken);
        Task<int> HandleExecuteAsync(Func<TConnection, Task<int>> executeAsync);
        Task<int> HandleExecuteAsync(Func<TConnection, TTransaction, Task<int>> executeAsync);
        Task<int> HandleExecuteAsync(Func<TConnection, CancellationToken, Task<int>> executeAsync, CancellationToken cancellationToken);
        Task<int> HandleExecuteAsync(Func<TConnection, TTransaction, CancellationToken, Task<int>> executeAsync, CancellationToken cancellationToken);
        T HandleExecute<T>(Func<TConnection, T> execute);
        T HandleExecute<T>(Func<TConnection, TTransaction, T> execute);
        Task<T> HandleExecuteAsync<T>(Func<TConnection, T> execute);
        Task<T> HandleExecuteAsync<T>(Func<TConnection, TTransaction, T> execute);
        Task<T> HandleExecuteAsync<T>(Func<TConnection, T> execute, CancellationToken cancellationToken);
        Task<T> HandleExecuteAsync<T>(Func<TConnection, TTransaction, T> execute, CancellationToken cancellationToken);
        Task<T> HandleExecuteAsync<T>(Func<TConnection, Task<T>> executeAsync);
        Task<T> HandleExecuteAsync<T>(Func<TConnection, TTransaction, Task<T>> executeAsync);
        Task<T> HandleExecuteAsync<T>(Func<TConnection, CancellationToken, Task<T>> executeAsync, CancellationToken cancellationToken);
        Task<T> HandleExecuteAsync<T>(Func<TConnection, TTransaction, CancellationToken, Task<T>> executeAsync, CancellationToken cancellationToken);
        int HandleExecute(Func<TConnection, TCommand> createCommand);
        int HandleExecute(Func<TConnection, TTransaction, TCommand> createCommand);
        Task<int> HandleExecuteAsync(Func<TConnection, TCommand> createCommand);
        Task<int> HandleExecuteAsync(Func<TConnection, TTransaction, TCommand> createCommand);
        Task<int> HandleExecuteAsync(Func<TConnection, TCommand> createCommand, CancellationToken cancellationToken);
        Task<int> HandleExecuteAsync(Func<TConnection, TTransaction, TCommand> createCommand, CancellationToken cancellationToken);
        T HandleExecute<T>(Func<TConnection, TCommand> createCommand);
        T HandleExecute<T>(Func<TConnection, TTransaction, TCommand> createCommand);
        Task<T> HandleExecuteAsync<T>(Func<TConnection, TCommand> createCommand);
        Task<T> HandleExecuteAsync<T>(Func<TConnection, TTransaction, TCommand> createCommand);
        Task<T> HandleExecuteAsync<T>(Func<TConnection, TCommand> createCommand, CancellationToken cancellationToken);
        Task<T> HandleExecuteAsync<T>(Func<TConnection, TTransaction, TCommand> createCommand, CancellationToken cancellationToken);
        void HandleExecute(Func<TConnection, TCommand> createCommand, Action<int, TCommand> postAction);
        void HandleExecute(Func<TConnection, TTransaction, TCommand> createCommand, Action<int, TCommand> postAction);
        Task HandleExecuteAsync(Func<TConnection, TCommand> createCommand, Action<int, TCommand> postAction);
        Task HandleExecuteAsync(Func<TConnection, TTransaction, TCommand> createCommand, Action<int, TCommand> postAction);
        Task HandleExecuteAsync(Func<TConnection, TCommand> createCommand, Action<int, TCommand> postAction, CancellationToken cancellationToken);
        Task HandleExecuteAsync(Func<TConnection, TTransaction, TCommand> createCommand, Action<int, TCommand> postAction, CancellationToken cancellationToken);
        T HandleExecute<T>(Func<TConnection, TCommand> createCommand, Func<int, TCommand, T> postAction);
        T HandleExecute<T>(Func<TConnection, TTransaction, TCommand> createCommand, Func<int, TCommand, T> postAction);
        Task<T> HandleExecuteAsync<T>(Func<TConnection, TCommand> createCommand, Func<int, TCommand, T> postAction);
        Task<T> HandleExecuteAsync<T>(Func<TConnection, TTransaction, TCommand> createCommand, Func<int, TCommand, T> postAction);
        Task<T> HandleExecuteAsync<T>(Func<TConnection, TCommand> createCommand, Func<int, TCommand, T> postAction, CancellationToken cancellationToken);
        Task<T> HandleExecuteAsync<T>(Func<TConnection, TTransaction, TCommand> createCommand, Func<int, TCommand, T> postAction, CancellationToken cancellationToken);
    }
}
