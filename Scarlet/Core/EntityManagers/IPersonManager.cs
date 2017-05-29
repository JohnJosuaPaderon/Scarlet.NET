using Scarlet.Core.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Scarlet.Core.EntityManagers
{
    public interface IPersonManager
    {
        string ConstructFullName(Person person);
        string ConstructInformalFullName(Person person);
        string ConstructMiddleInitial(Person person);
        Person Insert(Person person);
        Task<Person> InsertAsync(Person person);
        Task<Person> InsertAsync(Person person, CancellationToken cancellationToken);
    }
}
