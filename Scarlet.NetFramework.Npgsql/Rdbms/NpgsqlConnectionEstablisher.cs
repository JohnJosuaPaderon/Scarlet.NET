using Npgsql;
using Scarlet.Supports;
using System;
using System.Security;
using System.Threading;
using System.Threading.Tasks;

namespace Scarlet.Rdbms
{
    public sealed class NpgsqlConnectionEstablisher : IDbConnectionEstablisher<NpgsqlConnection>
    {
        public NpgsqlConnectionEstablisher(SecureString secureConnectionString)
        {
            SecureConnectionString = secureConnectionString ?? throw new ArgumentNullException(nameof(secureConnectionString));
        }

        public SecureString SecureConnectionString { get; }

        public void Dispose()
        {
            SecureConnectionString.Dispose();
        }

        public NpgsqlConnection Establish()
        {
            var connection = new NpgsqlConnection()
            {
                ConnectionString = SecureStringConverter.FromSecureString(SecureConnectionString)
            };

            try
            {
                connection.Open();
            }
            catch (Exception)
            {
                throw;
            }

            return connection;
        }

        public async Task<NpgsqlConnection> EstablishAsync()
        {
            var connection = new NpgsqlConnection(SecureStringConverter.FromSecureString(SecureConnectionString));

            try
            {
                await connection.OpenAsync();
            }
            catch (Exception)
            {
                throw;
            }

            return connection;
        }

        public async Task<NpgsqlConnection> EstablishAsync(CancellationToken cancellationToken)
        {
            var connection = new NpgsqlConnection(SecureStringConverter.FromSecureString(SecureConnectionString));

            try
            {
                await connection.OpenAsync(cancellationToken);
            }
            catch (Exception)
            {
                throw;
            }

            return connection;
        }
    }
}
