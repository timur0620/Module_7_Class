using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Bogus;
using System.IO;
using Module_7_Class.HomeWork.HomeWork.Structures;
using System.Security.Cryptography.X509Certificates;
using System.Net.Http.Headers;

namespace Module_7_Class
{
    internal class Program
    {
        private const int MENU = 0;
        private const int PRINT = 8;
        private const int ADD_EMPLOYEE = 1;
        private const int VIEW_ALL = 2;
        private const int DELETE_EMPLOYEE = 3;
        private const int VIEW_ONE_EMPLOYEE = 4;
        private const int SORT_DATE_EMPLOYEE = 5;
        private const int ADD_FAKE_EMPLOYEE = 6;

        static void Main(string[] args)
        {   
            Repository rep = new Repository();

            int action = 0;

            while (true)
            {
                switch (action)
                {
                    case MENU:
                        Console.WriteLine($"_____________MENU______________\n" +
                                          $"1 Add employer\n" +
                                          $"2 View all employer\n" +
                                          $"3 Delete employer\n" +
                                          $"4 View one employer\n" +
                                          $"5 Sort date employer\n" +
                                          $"6 Add fake employer\n");

                        action = int.Parse(Console.ReadLine());
                        break;

                    case ADD_EMPLOYEE:
                        Console.WriteLine($"_____________Add employer______________\n" +
                                          $"Entered count employer");

                        int countEmployers = int.Parse(Console.ReadLine());

                        for (int i = 0; i < countEmployers; i++)
                        {
                            rep.AddWorkerFake(rep.FillFakeDb(1));
                        }
                        action = VIEW_ALL;
                        break;

                    case VIEW_ALL:

                        rep.PrintAllEmployer();

                        action = MENU;
                        break;

                    case DELETE_EMPLOYEE:
                        Console.WriteLine($"_____________Delete Employer______________\n" +
                                          $"Entered id employer");

                        int id = int.Parse(Console.ReadLine());

                        rep.DeleteWorker(id);

                        action = VIEW_ALL;
                        break;

                    case VIEW_ONE_EMPLOYEE:
                        Console.WriteLine($"_____________View one employer______________\n" +
                                          $"Entered id view employer");

                        int idView = int.Parse(Console.ReadLine());

                        rep.PrintOneEmployer(rep.GetWorkerById(idView));

                        action = MENU;
                        break;

                    case SORT_DATE_EMPLOYEE:
                        Console.WriteLine($"_____________SORT DATE EMPLOYEE______________\n" +
                                          $"Entered date from employer\n");
                        DateTime dateFrom = DateTime.Parse(Console.ReadLine());

                        Console.WriteLine($"Entered date to employer");
                        DateTime dateTo = DateTime.Parse(Console.ReadLine());

                        rep.GetWorkersBetweenTwoDates(dateFrom, dateTo);

                        action = VIEW_ALL;
                        break;

                    case ADD_FAKE_EMPLOYEE:
                        Console.WriteLine($"_____________ADD FAKE EMPLOYEE______________\n" +
                                          $"Entered date from employer\n");
                        int countEmp = int.Parse(Console.ReadLine());

                        rep.RecordData(rep.FillFakeDb(countEmp));

                        action = VIEW_ALL;
                        break;
                }
            }
        }
    }
}




