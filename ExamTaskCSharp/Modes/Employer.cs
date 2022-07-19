using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTaskCSharp.Modes
{
    public class Employer : Human
    {
        public List<Vacancy> Vacancies { get; set; }

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
                Console.Write($"[{i + 1}]");
                newVacancy.Requirments[i] = Console.ReadLine();
            }

            Vacancies.Add(newVacancy);
        }


    }
}
