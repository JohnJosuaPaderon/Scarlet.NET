using Scarlet.Core.Entities;
using Scarlet.Entities;
using System;
using System.Linq;
using System.Text;

namespace Scarlet.Core.EntityProcesses
{
    public sealed class ConstructPersonMiddleInitial : IConstructPersonMiddleInitial
    {
        public Person Person { get; set; }

        public void Dispose()
        {
            Person = null;
        }

        public string Execute()
        {
            if (Person != null)
            {
                var hasMiddleName = !string.IsNullOrWhiteSpace(Person.MiddleName);

                if (hasMiddleName)
                {
                    var middleNameChunks = Person.MiddleName.Trim().Split(' ');

                    if (middleNameChunks.Any())
                    {
                        var builder = new StringBuilder();

                        foreach (var chunk in middleNameChunks)
                        {
                            if (chunk.Any())
                            {
                                var first = chunk[0];

                                if (char.IsLetter(first))
                                {
                                    builder.Append(first);
                                }
                            }
                        }

                        return builder.ToString();
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
