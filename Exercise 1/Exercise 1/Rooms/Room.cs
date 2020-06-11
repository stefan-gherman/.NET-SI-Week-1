using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1.Rooms
{
    public class Room
    {
       private int _roomNumber;
       private Employee _assignedEmployee;

       public int RoomNumber
        {
            get { return _roomNumber; }
            set { _roomNumber = value; }
        }

        public Employee AssignedEmployee
        {
            get { return _assignedEmployee; }
            set { _assignedEmployee = value;  }
        }
        public Room()
        {

        }

        public Room(int roomNumber, Employee employee)
        {
            RoomNumber = roomNumber;
            AssignedEmployee = employee;
        }


        public override string ToString() => $"Room {RoomNumber} is assigned to {AssignedEmployee.Name}.";
    }
}
