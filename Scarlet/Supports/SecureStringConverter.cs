using System;
using System.Security;

namespace Scarlet.Supports
{
    public static class SecureStringConverter
    {
        public static string FromSecureString(SecureString value)
        {
            if (value != null)
            {
                throw new NotImplementedException();
                // TODO:
            }
            else
            {
                return null;
            }
        }

        public static SecureString ToSecureString(string value)
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                throw new NotImplementedException();
                // TODO:
            }
            else
            {
                return null;
            }
        }
    }
}
