using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTaskCSharp.Modes
{
    public class CV
    {

        public string Qualification { get; set; }
        public string School { get; set; }
        public double UniScore { get; set; }
        public List<string> Skils { get; set; }
        public List<PreviousWorkedCompanies> previousWorkedCompanies { get; set; }
        public List<string> Languages { get; set; }
        public bool HasCertificate { get; set; }
        public string WebsiteLinks { get; set; }
     

    }
}
