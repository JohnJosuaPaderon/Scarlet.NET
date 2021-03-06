﻿using Scarlet.Core.Entities;
using Scarlet.Entities;
using System.Text;

namespace Scarlet.Core.EntityProcesses
{
    public sealed class ConstructPersonFullName : IConstructPersonFullName
    {
        public Person Person { get; set; }

        public void Dispose()
        {
            Person = null;
        }

        public string Execute()
        {
            var hasLastName = !string.IsNullOrWhiteSpace(Person?.LastName);
            var hasNameSuffix = !string.IsNullOrWhiteSpace(Person?.NameSuffix);
            var hasFirstName = !string.IsNullOrWhiteSpace(Person?.FirstName);
            var hasMiddleName = !string.IsNullOrWhiteSpace(Person?.MiddleName);

            if (hasLastName || hasFirstName || hasMiddleName || hasNameSuffix)
            {
                var builder = new StringBuilder();

                if (hasLastName)
                {
                    builder.Append(Person.LastName.Trim());

                    if (hasNameSuffix)
                    {
                        builder.Append(" ");
                    }
                    else if (hasFirstName || hasMiddleName)
                    {
                        builder.Append(", ");
                    }
                }

                if (hasNameSuffix)
                {
                    builder.Append(Person.NameSuffix.Trim());

                    if (hasFirstName || hasMiddleName)
                    {
                        builder.Append(", ");
                    }
                }

                if (hasFirstName)
                {
                    builder.Append(Person.FirstName.Trim());

                    if (hasMiddleName)
                    {
                        builder.Append(" ");
                    }
                }

                if (hasMiddleName)
                {
                    builder.Append(Person.MiddleName.Trim());
                }

                return builder.ToString();
            }
            else
            {
                return null;
            }
        }
    }
}
