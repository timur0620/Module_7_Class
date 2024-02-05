using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_7_Class.HomeWork.HomeWork.Structures
{
    public class Repository
    {
        public  Worker[] FillFakeDb(int countWorkers)
        {
            Random random = new Random();

            Worker[] worker = new Worker[countWorkers];

            for (int i = 0; i < worker.Length; i++)
            {
                var faker = new Faker("sk");

                worker[i] = new Worker(i,
                                        DateTime.Now,
                                        faker.Person.FullName,
                                        Convert.ToByte(random.Next(18, 80)),
                                        Convert.ToByte(random.Next(150, 180)),
                                        faker.Person.DateOfBirth,
                                        faker.Person.Address.Suite + " " + faker.Person.Address.City
                                      );
            }
            return worker;
        }
        public  void RecordData(Worker[] workers)
        {
            Worker workerPath = new Worker();

            int workersIndex = GetAllWorkers().Length;

            using (StreamWriter sw = new StreamWriter(workerPath.GetPath()))
            {
                for (int i = 0; i < workers.Length; i++)
                {
                    sw.WriteLine($"{workersIndex}|" +
                        $"{workers[i].dateRegistration}|" +
                        $"{workers[i].fullName}|" +
                        $"{workers[i].age}|" +
                        $"{workers[i].height}|" +
                        $"{workers[i].dateBirth}|" +
                        $"{workers[i].placeBirth}|");

                    workersIndex++;
                }
            }
        }
        public  Worker[] GetAllWorkers()
        {
            Worker workerPath = new Worker();

            List<string> termsList = new List<string>();

            if (!File.Exists(workerPath.GetPath()))
            {
                StreamWriter sr = new StreamWriter(workerPath.GetPath());

                sr.Close();
            }
            using (StreamReader sr = File.OpenText(workerPath.GetPath()))
            {
                string s = "";

                while ((s = sr.ReadLine()) != null)
                {
                    termsList.Add(s);
                }
            }
            string[] workerStr = termsList.ToArray();

            Worker[] workers = new Worker[workerStr.Length];

            for (int i = 0; i < workers.Length; i++)
            {
                workers[i].id = Convert.ToInt32(workerStr[i].Split("|")[0]);
                workers[i].dateRegistration = DateTime.Parse(workerStr[i].Split("|")[1]);
                workers[i].fullName = workerStr[i].Split("|")[2];
                workers[i].age = Convert.ToByte(workerStr[i].Split("|")[3]);
                workers[i].height = Convert.ToByte(workerStr[i].Split("|")[4]);
                workers[i].dateBirth = DateTime.Parse(workerStr[i].Split("|")[5]);
                workers[i].placeBirth = workerStr[i].Split("|")[6];
            }
            return workers;
        }
        public  Worker GetWorkerById(int id)
        {
            Worker[] arrayWorkers = GetAllWorkers();

            return arrayWorkers[id];
        }
        public  string DeleteWorker(int id)
        {
            Worker[] arrayWorkers = GetAllWorkers();

            Worker[] tempArray = new Worker[arrayWorkers.Length - 1];

            List<Worker> termsList = new List<Worker>();

            foreach (Worker worker in arrayWorkers)
            {
                if (worker.id == id)
                {
                    continue;
                }
                termsList.Add(worker);

            }
            tempArray = termsList.ToArray();

            RecordData(tempArray);

            return "Done";
        }
        public  void AddWorkerFake(Worker[] worker)
        {
            Worker[] arrayWorkers = GetAllWorkers();

            Worker[] tempArray = new Worker[arrayWorkers.Length + 1];

            List<Worker> termsList = [.. arrayWorkers, worker[0]];

            tempArray = termsList.ToArray();

            RecordData(tempArray);
        }
        public  Worker[] GetWorkersBetweenTwoDates(DateTime dateFrom, DateTime dateTo)
        {
            Worker[] arrayWorkers = GetAllWorkers();

            Worker[] tempArray = new Worker[arrayWorkers.Length];

            List<Worker> termsList = new List<Worker>();

            for (int i = 0; i < arrayWorkers.Length; i++)
            {
                if (arrayWorkers[i].dateBirth > dateFrom || arrayWorkers[i].dateBirth < dateTo)
                {
                    termsList.Add(arrayWorkers[i]);
                }
            }
            tempArray = termsList.ToArray();

            return tempArray;
        }
        public void PrintAllEmployer()
        {
            Worker workerPath = new Worker();

            using (StreamReader sr = File.OpenText(workerPath.GetPath()))
            {
                string s = "";

                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
        public void PrintOneEmployer(Worker worker)
        {
            Console.WriteLine($"|{worker.id}| {worker.dateRegistration}| " +
                $"{worker.fullName}| {worker.age}| {worker.height}| " +
                $"{worker.dateBirth} {worker.placeBirth}".ToUpper());
        }
    }
}
