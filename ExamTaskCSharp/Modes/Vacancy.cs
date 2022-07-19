using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTaskCSharp.Modes
{
    public class Vacancy
    {
        public int ID { get; set; }
        static public int StaticId { get; set; }
        public string CompanyName { get; set; }
        public string Name { get; set; }
        public List<string> Requirments { get; set; }
        public double Salary { get; set; }
        public List<Notifications> Notifications { get; set; }
        public int UnreadNotificationCount { get; set; }
        public Vacancy()
        {
            ID = ++StaticId;
        }

        public void ShowVacancy()
        {
            Console.WriteLine($"Vacancy ID   : {ID}");
            Console.WriteLine($"Company Name : {CompanyName}");
            Console.WriteLine($"Name         : {Name}");
            foreach (var item in Requirments)
            {
                if (Requirments != null)
                {
                    Console.WriteLine($"Requirments : {item}");
                }
            }
            Console.WriteLine($"Salary : {Salary}");



        }
    }
}
