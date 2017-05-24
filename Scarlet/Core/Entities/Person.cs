using Scarlet.Core.EntityManagers;
using Scarlet.Entities;
using System;

namespace Scarlet.Core.Entities
{
    public class Person : Entity<ulong>
    {
        public static IPersonManager Manager { get; set; }

        private string _FirstName;
        private string _MiddleName;
        private string _LastName;
        private string _NameSuffix;
        private string _FullName;
        private string _InformalFullName;
        private string _MiddleInitial;

        private bool FullNameRefreshRequired;
        private bool InformalFullNameRefreshRequired;
        private bool MiddleInitialRefreshRequired;

        public string FirstName
        {
            get { return _FirstName; }
            set
            {
                if (_FirstName != value)
                {
                    _FirstName = value;
                    FullNameRefreshRequired = true;
                    InformalFullNameRefreshRequired = true;
                }
            }
        }
        public string MiddleName
        {
            get { return _MiddleName; }
            set
            {
                if (_MiddleName != value)
                {
                    _MiddleName = value;
                    FullNameRefreshRequired = true;
                    InformalFullNameRefreshRequired = true;
                    MiddleInitialRefreshRequired = true;
                }
            }
        }
        public string LastName
        {
            get { return _LastName; }
            set
            {
                if (_LastName != value)
                {
                    _LastName = value;
                    FullNameRefreshRequired = true;
                    InformalFullNameRefreshRequired = true;
                }
            }
        }
        public string NameSuffix
        {
            get { return _NameSuffix; }
            set
            {
                if (_NameSuffix != value)
                {
                    _NameSuffix = value;
                    FullNameRefreshRequired = true;
                    InformalFullNameRefreshRequired = true;
                }
            }
        }
        public string FullName
        {
            get
            {
                if (FullNameRefreshRequired)
                {
                    _FullName = Manager?.ConstructFullName(this);
                    FullNameRefreshRequired = false;
                }

                return _FullName;
            }
        }
        public string InformalFullName
        {
            get
            {
                if (InformalFullNameRefreshRequired)
                {
                    _InformalFullName = Manager?.ConstructInformalFullName(this);
                    InformalFullNameRefreshRequired = false;
                }

                return _InformalFullName;
            }
        }
        public string MiddleInitial
        {
            get
            {
                if (MiddleInitialRefreshRequired)
                {
                    _MiddleInitial = Manager?.ConstructMiddleInitial(this);
                    MiddleInitialRefreshRequired = false;
                }

                return _MiddleInitial;
            }
        }
        public Gender Gender { get; set; }
        public DateTime? BirthDate { get; set; }
        public bool Deceased { get; set; }

        public override string ToString()
        {
            return InformalFullName;
        }
    }
}
