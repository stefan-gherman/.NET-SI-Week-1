using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    public class Employee : Person
    {
        private int _salary;
        private string _profession;
        
        public Employee()
        {

        }
        public Employee(string name, DateTime birthDate, Genders gender, int salary, string profession) : base(name, birthDate, gender)
        {
            _salary = salary;
            _profession = profession;
        } 
        public int Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public string Profession
        {
            get { return _profession; }
            set { _profession = value; }
        }

        public override string ToString() => base.ToString().Remove(base.ToString().Length - 1) + $" works as {Profession}, earns {Salary}";

    }
}
