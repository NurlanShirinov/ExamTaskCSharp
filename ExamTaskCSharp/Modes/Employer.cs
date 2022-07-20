using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTaskCSharp.Modes
{
    public class Employer : Human
    {
        public List<Vacancy> Vacancies { get; set; } = new List<Vacancy>();


        public void ShowVacancies()
        {
            foreach (var item in Vacancies)
            {
                item.ShowVacancy();
                Console.WriteLine("**************************************");
                Console.WriteLine("\n");
            }

        }

        public void AddNewVacancies()
        {
            Vacancy newVacancy = new Vacancy();

            Console.Write("Company Name : ");
            newVacancy.CompanyName = Console.ReadLine();

            Console.Write("Position Name : ");
            newVacancy.Name = Console.ReadLine();

            Console.Write("Salary per month : ");
            newVacancy.Salary = double.Parse(Console.ReadLine());

            Console.Write("Enter Count of Requirments : ");
            int requirmentCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < requirmentCount; i++)
            {
                Console.Write($"[{i + 1}] Requirment : ");
                string requirment = Console.ReadLine();
                newVacancy.Requirments.Add(requirment);
            }

            Vacancies.Add(newVacancy);
        }

        public void ShowNotifications()
        {
            foreach (var item in Vacancies)
            {
                foreach (var item2 in item.Notifications)
                {
                    item2.ShowNotification();
                }
            }

        }

        public void ShowNotificationByID(int id)
        {

            foreach (var item in Vacancies)
            {
                foreach (var item2 in item.Notifications)
                {
                    if (item2.Id == id)
                    {
                        item2.ShowNotification();
                    }
                    else
                    {
                        Console.WriteLine("Such Notification is not valid!");
                    }
                }

            }
        }


    }
}
