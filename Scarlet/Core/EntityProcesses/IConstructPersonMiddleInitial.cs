using Scarlet.Core.Entities;
using Scarlet.Entities;

namespace Scarlet.Core.EntityProcesses
{
    public interface IConstructPersonMiddleInitial : IEntityProcess<string>
    {
        Person Person { get; set; }
    }
}
