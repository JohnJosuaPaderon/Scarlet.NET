using Scarlet.Core.EntityManagers;
using Scarlet.Entities;
using System;
using System.Runtime.Serialization;

namespace Scarlet.Core.Entities
{
    [DataContract]
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

        [DataMember]
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

        [DataMember]
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

        [DataMember]
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

        [DataMember]
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

        [DataMember]
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

        [DataMember]
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

        [DataMember]
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

        [DataMember]
        public Gender Gender { get; set; }

        [DataMember]
        public DateTime? BirthDate { get; set; }

        [DataMember]
        public bool Deceased { get; set; }

        public override string ToString()
        {
            return InformalFullName;
        }
    }
}
