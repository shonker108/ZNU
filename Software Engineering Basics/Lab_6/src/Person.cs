using Lab_6.src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6.MyClasses
{
    public class Person
    {
        private string name;
        private string surname;
        private DateTime birthDate;

        // Цього поля нам не було сказано створити в Л/Р
        // Але для деякого ітератору це треба
        public int publicationsCount = 0;

        public Person(string name, string surname, DateTime birthDate)
        {
            this.name = name;
            this.surname = surname;
            this.birthDate = birthDate;
        }

        public Person()
        {
            this.name = "Undefined";
            this.surname = "Undefined";
            this.birthDate = new DateTime(1900, 1, 1);
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Surname
        {
            get => surname;
            set => surname = value;
        }

        public DateTime BirthDate
        {
            get => birthDate;
            set => birthDate = value;
        }

        public int BirthYear
        {
            get => birthDate.Year;
            set => birthDate = new DateTime(value, birthDate.Month, birthDate.Day);
        }

        public override string ToString()
        {
            return $"Name: {name}\nSurname: {surname}\nDate of birth: {birthDate.ToString("dd.MM.yyyy")}";
        }

        public virtual string ToShortString()
        {
            return $"{name} {surname}";
        }


        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Person other = (Person)obj;

            return name == other.name &&
                   surname == other.surname &&
                   birthDate.Equals(other.birthDate);
        }

        public static bool operator ==(Person person1, Person person2)
        {
            if (person1 is null || person2 is null)
            {
                return false;
            }

            return person1.Equals(person2);
        }

        public static bool operator !=(Person person1, Person person2)
        {
            return !(person1 == person2);
        }

        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 23 + name.GetHashCode();
            hash = hash * 23 + surname.GetHashCode();
            hash = hash * 23 + birthDate.GetHashCode();
            return hash;
        }

        public object DeepCopy()
        {
            return new Person(
                name,
                surname,
                new DateTime(birthDate.Year, birthDate.Month, birthDate.Day)
            );
        }
    }
}
