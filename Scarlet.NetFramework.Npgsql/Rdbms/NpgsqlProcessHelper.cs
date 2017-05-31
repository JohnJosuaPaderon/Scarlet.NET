using Npgsql;
using System;
using System.Security;

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
    }
}
