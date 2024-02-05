using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_7_Class.Structures
{
    public struct StructureHouse
    {
        public int houseNumber;
        public string houseAddress;
        public int countRoom;
        public int countBadRoom;
        private bool IsWood;
        private string post;
        private int[] massive;
        
        public string colorHouse { private get; set; }
        public string  Post
        {
            get { return this.post; }
            set { this.post = value; }
        }
        
        public StructureHouse(int houseNumber, string houseAddress, int countRoom, int countBadRoom)
        {
            this.houseNumber = houseNumber;
            this.houseAddress = houseAddress;
            this.countRoom = countRoom;
            this.countBadRoom = countBadRoom;
        }
        public int GetCountRoom()
        {
            return this.countRoom;
        }
        public void ChangeCountRoom(int count)
        {
            this.countBadRoom = count;
        }
        public bool GetWood()
        {
            return this.IsWood;
        }
        public void SetWood()
        {
            this.IsWood = !this.IsWood;
        }

    }
}
