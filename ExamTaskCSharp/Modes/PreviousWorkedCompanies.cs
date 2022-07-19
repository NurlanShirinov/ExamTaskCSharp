using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTaskCSharp.Modes
{
    public class PreviousWorkedCompanies
    {
        public int Id { get; set; }
        public static int StaticID { get; set; }
        public string CompanyName { get; set; }
        public string Position { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public PreviousWorkedCompanies()
        {
            Id = StaticID++;
        }
    }
}
