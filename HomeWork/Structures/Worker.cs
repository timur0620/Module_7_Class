using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_7_Class.HomeWork.HomeWork.Structures
{
    public struct Worker
    {
        public int id { get; set; }
        public DateTime dateRegistration { get; set; }
        public string fullName { get; set; }
        public byte age { get; set; }
        public byte height { get; set; }
        public DateTime dateBirth { get; set; }
        public string placeBirth { get; set; }

        public string GetPath()
        {
            return "F:\\c#Projects\\Module_7_Class\\HomeWork\\DataBase\\baseWorkers.csv";
        }

        public Worker(int id, DateTime dateRegistration, string fullName, 
                      byte age, byte height, DateTime dateBirth, string placeBirth)
        {
            this.id = id;
            this.dateRegistration = dateRegistration;
            this.fullName = fullName;
            this.age = age;
            this.height = height;
            this.dateBirth = dateBirth;
            this.placeBirth = placeBirth;
        }

    }
}
