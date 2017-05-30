using System;
using System.Data.Common;
using System.Security;
using System.Threading;
using System.Threading.Tasks;

namespace Scarlet.Rdbms
{
    public interface IDbConnectionEstablisher<TConnection> : IDisposable
        where TConnection : DbConnection
    {
        SecureString SecureConnectionString { get; }
        TConnection Establish();
        Task<TConnection> EstablishAsync();
        Task<TConnection> EstablishAsync(CancellationToken cancellationToken);

    }
}
