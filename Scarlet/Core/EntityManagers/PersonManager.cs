using Scarlet.Core.EntityProcesses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Scarlet.Core.EntityManagers
{
    public sealed class PersonManager
    {
        public static IConstructPersonFullName ConstructFullNameProcess { get; private set; }
        public static IConstructPersonInformalFullName ConstructInformalFullNameProcess { get; private set; }

        public void SetProcess<T>()
        {
            
        }
    }
}
