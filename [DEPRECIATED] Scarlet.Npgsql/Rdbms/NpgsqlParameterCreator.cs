using Npgsql;
using System;
using System.Data;

namespace Scarlet.Rdbms
{
    public sealed class NpgsqlParameterCreator : IDbParameterCreator<NpgsqlParameter>
    {
        public NpgsqlParameter CreateInOut(string parameterName, object initialValue)
        {
            ValidateParameterName(parameterName);

            return new NpgsqlParameter()
            {
                ParameterName = parameterName,
                Direction = ParameterDirection.InputOutput,
                Value = initialValue
            };
        }

        public NpgsqlParameter CreateInput(string parameterName, object value)
        {
            ValidateParameterName(parameterName);

            return new NpgsqlParameter()
            {
                ParameterName = parameterName,
                Direction = ParameterDirection.Input,
                Value = value
            };
        }

        public NpgsqlParameter CreateOutput(string parameterName)
        {
            ValidateParameterName(parameterName);

            return new NpgsqlParameter()
            {
                ParameterName = parameterName,
                Direction = ParameterDirection.Output
            };
        }

        private void ValidateParameterName(string parameterName)
        {
            if (string.IsNullOrWhiteSpace(parameterName))
            {
                throw new ArgumentException("Invalid Parameter Name", nameof(parameterName));
            }
        }
    }
}
