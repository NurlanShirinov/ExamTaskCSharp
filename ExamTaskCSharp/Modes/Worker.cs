using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTaskCSharp.Modes
{
    public class Worker:Human
    {
        public List<CV> WorkerCV { get; set; }
        public List<string> Notifications { get; set; }

        public void AddCV()
        {
            CV newCV = new CV();
            Console.Write("Qualification : ");
            newCV.Qualification = Console.ReadLine();

            Console.Write("School        : ");
            newCV.School = Console.ReadLine();

            Console.Write("UniScore      : ");
            newCV.UniScore = int.Parse(Console.ReadLine());

            Console.Write("Enter count of skills you want to add : ");
            int skillCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < skillCount; i++)
            {
                Console.Write($"[{i + 1}] Skill  : ");
                newCV.Skils[i] = Console.ReadLine();
            }


            Console.Write("Enter count of previous company you have worked : ");
            int CompaniCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < CompaniCount; i++)
            {
                PreviousWorkedCompanies newPWC = new PreviousWorkedCompanies();
                Console.Write("Company Name : ");
                newPWC.CompanyName = Console.ReadLine();

                Console.Write("Position : ");
                newPWC.Position = Console.ReadLine();

                Console.Write("Enter Start Date : ");
                newPWC.StartDate = DateTime.Parse(Console.ReadLine());

                Console.Write("Enter End Date : ");
                newPWC.EndDate = DateTime.Parse(Console.ReadLine());

                newCV.previousWorkedCompanies.Add(newPWC);
            }

            Console.Write("Enter count of Languages : ");
            int languageCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < languageCount; i++)
            {
                Console.Write($"[{i + 1}] Language  : ");
                newCV.Languages[i] = Console.ReadLine();
            }

            Console.Write("WebsiteLinks      : ");
            newCV.WebsiteLinks = Console.ReadLine();

            Console.Write("Has ceritificate      : ");
            newCV.HasCertificate = bool.Parse(Console.ReadLine());

            WorkerCV.Add(newCV);
        }


        public void ShowCV()
        {
            Console.WriteLine("*************Worker CV**********************");

            foreach (var item in WorkerCV)
            {
                Console.WriteLine(item);
            }

        }

    }

  
  
}
