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
    

       public int RoomNumber
        {
            get { return _roomNumber; }
            set { _roomNumber = value; }
        }

       
        public Room()
        {

        }

        public Room(int roomNumber, Employee employee)
        {
            RoomNumber = roomNumber;
        }

    }
}
