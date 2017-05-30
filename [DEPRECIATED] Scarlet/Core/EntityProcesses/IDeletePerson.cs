using Scarlet.Core.Entities;
using Scarlet.Entities;

namespace Scarlet.Core.EntityProcesses
{
    public interface IDeletePerson : IEntityProcess<Person>, IEntityProcessAsync<Person>, ICancellableEntityProcessAsync<Person>
    {
        Person Person { get; set; }
    }
}
