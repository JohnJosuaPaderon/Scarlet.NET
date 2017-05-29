using Scarlet.Core.EntityManagementService;
using System;
using System.Threading.Tasks;
using Scarlet.Core.Entities;

namespace Scarlet.Services
{
    public class CoreEntityService : ICoreEntityService
    {
        public Task<Person> DeletePersonAsync(Person person)
        {
            throw new NotImplementedException();
        }

        public Task<Person> InsertPersonAsync(Person person)
        {
            throw new NotImplementedException();
        }

        public Task<Person> UpdatePersonAsync(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
