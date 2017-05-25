using System;
using Scarlet.Core.Entities;
using Scarlet.Core.EntityProcesses;
using Scarlet.Entities;

namespace Scarlet.Core.EntityManagers
{
    public sealed class PersonManager : IPersonManager
    {
        static PersonManager()
        {
            Person.Manager = Instance;
        }

        public static PersonManager Instance { get; } = new PersonManager();
        
        private static EntityCollection<Person, ulong> Collection { get; } = new EntityCollection<Person, ulong>();

        public string ConstructFullName<TProcess>(Person person)
            where TProcess : IConstructPersonFullName, new()
        {
            if (person != null)
            {
                using (var process = new TProcess())
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
            throw new NotImplementedException();
        }

        public string ConstructMiddleInitial(Person person)
        {
            if (person != null)
            {
                using (var process = new ConstructPersonMiddleInitial(person))
                {
                    return process.Execute();
                }
            }
            else
            {
                return null;
            }
        }
    }
}
