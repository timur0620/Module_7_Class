using Module_7_Class.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_7_Class.Lesson
{
    internal class Lessons
    {
        //static void Main(string[] args)
        //{
        //    AddDataStructure_1();
        //    AddHouseData();
        //}
        public struct Structure_1()
        {
            public string month;
            public int income;
            public int consumption;
            public int arrived;

        }
        static void AddDataStructure_1()
        {
            Structure_1 st = new Structure_1();
            st.month = "December";
            st.income = 1000;
            st.consumption = 500;
            st.arrived = st.income + st.consumption;
        }
        static void AddHouseData()
        {
            StructureHouse structHouse = new StructureHouse();
            StructureHouse constHouse = new StructureHouse(12121, "", 12, 12);
            structHouse.houseAddress = "Some Address";
            structHouse.countRoom = 3;
            structHouse.countBadRoom = 2;
            structHouse.houseNumber = 12545458;
            structHouse.GetCountRoom();
            structHouse.ChangeCountRoom(2);
            structHouse.GetWood();
            structHouse.SetWood();
            structHouse.Post = "OI 121212";
            structHouse.colorHouse = "Red";

            StructureHouse[] houses = new StructureHouse[12];
            houses[0] = new StructureHouse()
            {
                houseAddress = "Alabama",
                countRoom = 3,
                countBadRoom = 2,
                houseNumber = 13131321,
            };
            houses[1].houseNumber = 2131321;
            houses[1].countRoom = 3;
            houses[1].houseAddress = "New-York";
            houses[1].countBadRoom = 2;

            ConstructorHouse ch = new ConstructorHouse(121212, "Disney", 3, 2);


        }
    }
}
