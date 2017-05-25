using Scarlet.Core.Entities;
using Scarlet.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Scarlet.Core.EntityProcesses
{
    public sealed class ConstructPersonInformalFullName : IEntityProcess<string>
    {
        public Person Person { get; set; }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public string Execute()
        {
            throw new NotImplementedException();
        }
    }
}
