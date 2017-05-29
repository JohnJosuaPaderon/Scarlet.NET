using System;
using System.Threading.Tasks;
using Scarlet.Core.Entities;
using Scarlet.Core.EntityProcesses;

namespace Scarlet.Core.EntityManagers
{
    public sealed class PersonManager : IPersonManager
    {
        public string ConstructFullName(Person person)
        {
            if (person != null)
            {
                using (var process = new ConstructPersonFullName())
                {
                    process.Person = person;
                    return process.Execute();
                }
            }
            else
            {
                return null;
            }
        }

        public string ConstructInformalFullName(Person person)
        {
            if (person != )
            {

            }

        }

        public string ConstructMiddleInitial(Person person)
        {
            throw new NotImplementedException();
        }

        public Task<Person> InsertAsync(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
