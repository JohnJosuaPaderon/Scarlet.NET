using Scarlet.Core.Entities;
using Scarlet.Core.EntityProcesses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Scarlet.Core.EntityManagers
{
    public sealed class PersonManager
    {
        public static IConstructPersonFullName ConstructFullNameProcess { get; set; }
        public static IConstructPersonInformalFullName ConstructInformalFullNameProcess { get; set; }

        public string ConstructFullName(Person person)
        {
            if (person != null)
            {
                ConstructFullNameProcess.Person = person;
                return ConstructFullNameProcess.Execute();
            }
            else
            {
                return null;
            }
        }
    }
}
