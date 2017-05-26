using Scarlet.Core.Entities;
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
                    string[] middleNameChunks = SplitMiddleName(Person.MiddleName);

                    if (middleNameChunks.Any())
                    {
                        var builder = new StringBuilder();

                        foreach (var chunk in middleNameChunks)
                        {
                            ProcessFirstChar(builder, chunk);
                        }

                        return builder.ToString();
                    }
                }
            }

            return null;
        }

        private static string[] SplitMiddleName(string middleName)
        {
            return middleName?.Trim().Split(' ');
        }

        private static void ProcessFirstChar(StringBuilder builder, string chunk)
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
    }
}
