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
                        return item2;
                    }
                     
                }
            }
            return null;
        }


    }
}
