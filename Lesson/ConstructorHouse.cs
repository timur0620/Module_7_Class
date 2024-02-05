using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_7_Class.Structures
{
    public struct ConstructorHouse(int houseNumber, string houseAddress, int countRoom, int countBadRoom)
    {
        public int houseNumber = houseNumber;
        public string houseAddress = houseAddress;
        public int countRoom = countRoom;
        public int countBadRoom = countBadRoom;

    }
}
