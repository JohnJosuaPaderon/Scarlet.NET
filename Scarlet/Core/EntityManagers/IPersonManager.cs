using Scarlet.Core.Entities;

namespace Scarlet.Core.EntityManagers
{
    public interface IPersonManager
    {
        string ConstructFullName(Person person);
        string ConstructInformalFullName(Person person);
        string ConstructMiddleInitial(Person person);
    }
}
