﻿using Scarlet.Core.Entities;
using Scarlet.Entities;

namespace Scarlet.Core.EntityProcesses
{
    public interface IUpdatePerson : IEntityProcess<Person>, IEntityProcessAsync<Person>, ICancellableEntityProcessAsync<Person>
    {
        Person Person { get; set; }
    }
}
