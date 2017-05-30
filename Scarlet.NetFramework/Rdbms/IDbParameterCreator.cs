using System.Data.Common;

namespace Scarlet.Rdbms
{
    public interface IDbParameterCreator<TParameter>
        where TParameter : DbParameter
    {
        TParameter CreateInput(string parameterName, object value);
        TParameter CreateOutput(string parameterName);
        TParameter CreateInOut(string parameterName, object initialValue);
    }
}
