using Exercise_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    public class Person
    {
        public enum Genders
        {
            Male,
            Female
        };
        private string _name;
        private DateTime _birthDate;
        private Genders _gender;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public DateTime BirthDate
        {
            get
            {
                return _birthDate;
            }
            set
            {
                _birthDate = value;
            }
        }
        public Genders Gender
        {
            get
            {
                return _gender;
            }
            set
            {
                _gender = value;
            }
        }

        public Person()
        {

        }
        public Person(string name, DateTime birthDate, Genders gender)
        {
            Name = name;
            BirthDate = birthDate;
            Gender = gender;

        }


        public override string ToString() => $"{Name} born on {BirthDate.Date.ToShortDateString()} is a {Gender}.";
    }

    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person
            {
                Name = "Oxygen",
                BirthDate = DateTime.Now,
                Gender = Person.Genders.Female
            };

            var person2 = new Person
            {
                Name = "Anna",
                BirthDate = DateTime.Parse("12/05/1902 2:23:41 AM")
            };

            Console.WriteLine(person.ToString());
            Console.WriteLine(person2.ToString());
        }
    }
}
