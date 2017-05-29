using Scarlet.Core.EntityManagementService;
using System;
using System.Threading.Tasks;
using Scarlet.Core.Entities;
using System.Threading;

namespace Scarlet.Services
{
    public class CoreEntityService : ICoreEntityService
    {
        public Person DeletePerson(Person person)
        {
            throw new NotImplementedException();
        }

        public Task<Person> DeletePersonAsync(Person person)
        {
            throw new NotImplementedException();
        }

        public Task<Person> DeletePersonAsync(Person person, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Person InsertPerson(Person person)
        {
            throw new NotImplementedException();
        }

        public Task<Person> InsertPersonAsync(Person person)
        {
            throw new NotImplementedException();
        }

        public Task<Person> InsertPersonAsync(Person person, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Person UpdatePerson(Person person)
        {
            throw new NotImplementedException();
        }

        public Task<Person> UpdatePersonAsync(Person person)
        {
            throw new NotImplementedException();
        }

        public Task<Person> UpdatePersonAsync(Person person, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
