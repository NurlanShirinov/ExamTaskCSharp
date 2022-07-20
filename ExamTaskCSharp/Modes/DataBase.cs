using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTaskCSharp.Modes
{
    public class DataBase
    {
        public List<Human> humans { get; set; }

        public Vacancy GetVacancyByID(int id)
        {
            foreach (var item in humans)
            {
                if (item is Employer)
                {
                    Employer emp = (Employer)item;
                    foreach (var item2 in emp.Vacancies)
                    {
                        if (item2.ID == id)
                        {
                            Console.WriteLine("Succesfully Applied");
                            return item2;
                        }
                    }

                }
            }
            return null;
        }

        public void ShowCV()

        {
            Console.WriteLine("*************Worker CV**********************");

            foreach (var item in humans)
            {
                if (item is Worker)
                {
                    Worker worker = (Worker)item;
                    foreach (var item2 in worker.WorkerCV)
                    {
                        item2.ShowCV();
                    }
                }
            }

        }

        public Worker GetWorkerByID(int id)
        {
            foreach (var item in humans)
            {
                if (item is Worker && item.Id==id)
                {
                    Worker worker = (Worker)item;
                    return worker;
                }
            }
            return null;
        }


    }
}
