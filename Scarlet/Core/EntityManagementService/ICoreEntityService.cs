using Scarlet.Core.Entities;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Scarlet.Core.EntityManagementService
{
    [ServiceContract]
    public interface ICoreEntityService
    {
        [OperationContract]
        Task<Person> InsertPersonAsync(Person person);
        
        [OperationContract]
        Task<Person> UpdatePersonAsync(Person person);

        [OperationContract]
        Task<Person> DeletePersonAsync(Person person);
    }
}
