using System.Data.Common;

namespace Scarlet.Rdbms
{
    public interface IDbCommandCreator<TConnection, TTransaction, TCommand, TParameter>
        where TConnection : DbConnection
        where TTransaction : DbTransaction
        where TCommand : DbCommand
        where TParameter : DbParameter
    {
        TCommand CreateCommand(string commandText, TConnection connection);
        TCommand CreateCommand(string commandText, TConnection connection, params TParameter[] parameters);
        TCommand CreateCommand(string commandText, TConnection connection, TTransaction transaction);
        TCommand CreateCommand(string commandText, TConnection connection, TTransaction transaction, params TParameter[] parameters);
        TCommand CreateProcedureCommand(string storedProcedure, TConnection connection);
        TCommand CreateProcedureCommand(string storedProcedure, TConnection connection, params TParameter[] parameters);
        TCommand CreateProcedureCommand(string storedProcedure, TConnection connection, TTransaction transaction);
        TCommand CreateProcedureCommand(string storedProcedure, TConnection connection, TTransaction transaction, params TParameter[] parameters);
    }
}
