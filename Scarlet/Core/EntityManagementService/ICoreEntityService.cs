using Scarlet.Core.Entities;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;

namespace Scarlet.Core.EntityManagementService
{
    [ServiceContract]
    public interface ICoreEntityService
    {
        [OperationContract]
        Person InsertPerson(Person person);

        [OperationContract]
        Task<Person> InsertPersonAsync(Person person);

        [OperationContract]
        Task<Person> InsertPersonAsync(Person person, CancellationToken cancellationToken);

        [OperationContract]
        Person UpdatePerson(Person person);

        [OperationContract]
        Task<Person> UpdatePersonAsync(Person person);

        [OperationContract]
        Task<Person> UpdatePersonAsync(Person person, CancellationToken cancellationToken);

        [OperationContract]
        Person DeletePerson(Person person);

        [OperationContract]
        Task<Person> DeletePersonAsync(Person person);

        [OperationContract]
        Task<Person> DeletePersonAsync(Person person, CancellationToken cancellationToken);
    }
}
