using Lab_6.src;

namespace Lab_6.MyClasses
{
    public class Team : INameAndCopy, IComparable
    {
        protected string name;
        protected int registrationNumber;
        public string Name { get; set; }
        public int RegistrationNumber { get => registrationNumber;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Registration number can't be less or equal to 0");
            
                registrationNumber = value;
            } 
        }

        public Team()
        {
            name = string.Empty;
            registrationNumber = 1;
        }

        public Team(string name, int registrationNumber)
        {
            this.name = name;    
            this.registrationNumber = registrationNumber;
        }


        public virtual object DeepCopy()
        {
           return new Team(name, registrationNumber);
        }

        public virtual bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Team other = (Team)obj;

            return name == other.name &&
                   registrationNumber == other.registrationNumber;
        }

        public static bool operator ==(Team t1, Team t2)
        {
            if (t1 is null || t2 is null)
            {
                return false;
            }

            return t1.Equals(t2);
        }

        public static bool operator !=(Team t1, Team t2)
        {
            return !(t1 == t2);
        }

        public static explicit operator Team(string v)
        {
            throw new NotImplementedException();
        }

        public virtual int GetHashCode()
        {
            int hash = 17;
            hash = hash * 23 + name.GetHashCode();
            hash = hash * 23 + registrationNumber.GetHashCode();
            return hash;
        }

        public int CompareTo(object? obj)
        {
            if (obj is Team other)
            {
                return this.registrationNumber - other.registrationNumber;
            }
            else
            {
                throw new ArgumentException("Can't compare objects!");
            }
        }
    }
}