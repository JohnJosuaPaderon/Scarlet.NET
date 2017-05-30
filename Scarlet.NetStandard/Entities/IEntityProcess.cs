using System;
using System.Threading;
using System.Threading.Tasks;

namespace Scarlet.Entities
{
    public interface IEntityProcess : IDisposable
    {
        void Execute();
    }

    public interface IEntityProcess<T> : IDisposable
    {
        T Execute();
    }

    public interface IEntityProcess<T, TIdentifier> : IDisposable
        where T : IEntity<TIdentifier>
    {
        T Execute();
    }

    public interface IEntityProcessAsync : IDisposable
    {
        Task ExecuteAsync();
    }

    public interface IEntityProcessAsync<T> : IDisposable
    {
        Task<T> ExecuteAsync();
    }

    public interface IEntityProcessAsync<T, TIdentifier> : IDisposable
        where T : IEntity<TIdentifier>
    {
        Task<T> ExecuteAsync();
    }

    public interface ICancellableEntityProcessAsync : IDisposable
    {
        Task ExecuteAsync(CancellationToken cancellationToken);
    }

    public interface ICancellableEntityProcessAsync<T> : IDisposable
    {
        Task<T> ExecuteAsync(CancellationToken cancellationToken);
    }

    public interface ICancellableEntityProcessAsync<T, TIdentifier> : IDisposable
        where T : IEntity<TIdentifier>
    {
        Task<T> ExecuteAsync(CancellationToken cancellationToken);
    }
}
