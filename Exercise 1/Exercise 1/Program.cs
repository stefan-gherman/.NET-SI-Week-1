using Exercise_1.Rooms;
using System;
using System.Globalization;

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


        public override string ToString()
        {
            CultureInfo culture = new CultureInfo("pt-BR");
           return $"{Name} born on {BirthDate.Date.ToString(@"dd/MMMM/yyyy", culture)} is a {Gender}.";
        }
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

            var employee = new Employee
            {
                Name = "Ferdinandius",
                BirthDate = DateTime.Parse("23/05/1999"),
                Gender = Person.Genders.Male,
                Salary = 2500,
                Profession = "Doctor"
            };

            var room = new Room
            {
                RoomNumber = 12,
            };

           
            employee.Room = room;
            var employeeClone = employee.Clone();
            Console.WriteLine(employee.ToString());
            Console.WriteLine(employeeClone.ToString());



            Employee Kovacs = new Employee("Géza", DateTime.Now, Person.Genders.Male, 1000, "léhűtő");
            Kovacs.Room = new Room(111);
            Employee Kovacs2 = (Employee)Kovacs.Clone();
            Kovacs2.Room.RoomNumber = 112;
            Console.WriteLine(Kovacs.ToString());
            Console.WriteLine(Kovacs2.ToString());
        }
    }
}
