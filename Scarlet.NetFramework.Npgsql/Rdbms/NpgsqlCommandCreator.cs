using Npgsql;
using System;
using System.Data;
using System.Linq;

namespace Scarlet.Rdbms
{
    public sealed class NpgsqlCommandCreator : IDbCommandCreator<NpgsqlConnection, NpgsqlTransaction, NpgsqlCommand, NpgsqlParameter>
    {
        public NpgsqlCommand CreateCommand(string commandText, NpgsqlConnection connection)
        {
            ValidateCommandText(commandText);
            ValidateConnection(connection);

            var command = new NpgsqlCommand(commandText, connection);
            return command;
        }

        public NpgsqlCommand CreateCommand(string commandText, NpgsqlConnection connection, params NpgsqlParameter[] parameters)
        {
            ValidateCommandText(commandText);
            ValidateConnection(connection);

            var command = new NpgsqlCommand(commandText, connection);

            if (parameters?.Any() ?? false)
            {
                command.Parameters.AddRange(parameters);
            }

            return command;
        }

        public NpgsqlCommand CreateCommand(string commandText, NpgsqlConnection connection, NpgsqlTransaction transaction)
        {
            ValidateCommandText(commandText);
            ValidateConnection(connection);

            var command = new NpgsqlCommand(commandText, connection, transaction);
            return command;
        }

        public NpgsqlCommand CreateCommand(string commandText, NpgsqlConnection connection, NpgsqlTransaction transaction, params NpgsqlParameter[] parameters)
        {
            ValidateCommandText(commandText);
            ValidateConnection(connection);

            var command = new NpgsqlCommand(commandText, connection, transaction);

            if (parameters?.Any() ?? false)
            {
                command.Parameters.AddRange(parameters);
            }

            return command;
        }

        public NpgsqlCommand CreateProcedureCommand(string storedProcedure, NpgsqlConnection connection)
        {
            ValidateStoredProcedure(storedProcedure);
            ValidateConnection(connection);

            var command = new NpgsqlCommand()
            {
                CommandText = storedProcedure,
                Connection = connection,
                CommandType = CommandType.StoredProcedure
            };

            return command;
        }

        public NpgsqlCommand CreateProcedureCommand(string storedProcedure, NpgsqlConnection connection, params NpgsqlParameter[] parameters)
        {
            ValidateStoredProcedure(storedProcedure);
            ValidateConnection(connection);

            var command = new NpgsqlCommand()
            {
                CommandText = storedProcedure,
                Connection = connection,
                CommandType = CommandType.StoredProcedure
            };

            if (parameters?.Any() ?? false)
            {
                command.Parameters.AddRange(parameters);
            }

            return command;
        }

        public NpgsqlCommand CreateProcedureCommand(string storedProcedure, NpgsqlConnection connection, NpgsqlTransaction transaction)
        {
            ValidateStoredProcedure(storedProcedure);
            ValidateConnection(connection);

            var command = new NpgsqlCommand()
            {
                CommandText = storedProcedure,
                Connection = connection,
                Transaction = transaction,
                CommandType = CommandType.StoredProcedure
            };

            return command;
        }

        public NpgsqlCommand CreateProcedureCommand(string storedProcedure, NpgsqlConnection connection, NpgsqlTransaction transaction, params NpgsqlParameter[] parameters)
        {
            ValidateStoredProcedure(storedProcedure);
            ValidateConnection(connection);

            var command = new NpgsqlCommand()
            {
                CommandText = storedProcedure,
                Connection = connection,
                Transaction = transaction,
                CommandType = CommandType.StoredProcedure
            };

            if (parameters?.Any() ?? false)
            {
                command.Parameters.AddRange(parameters);
            }

            return command;
        }

        private void ValidateCommandText(string commandText)
        {
            if (string.IsNullOrWhiteSpace(commandText))
            {
                throw new ArgumentException("Command Text parameter value is null or white space.", nameof(commandText));
            }
        }

        private void ValidateStoredProcedure(string storedProcedure)
        {
            if (string.IsNullOrWhiteSpace(storedProcedure))
            {
                throw new ArgumentException("Stored Procedure parameter value is null or white space.", nameof(storedProcedure));
            }
        }

        private void ValidateConnection(NpgsqlConnection connection)
        {
            if (connection == null)
            {
                throw new ArgumentException("Connection is invalid.", nameof(connection));
            }

            if (connection.State != ConnectionState.Open)
            {
                throw new ArgumentException("Connection is unavailable.", nameof(connection));
            }
        }
    }
}
