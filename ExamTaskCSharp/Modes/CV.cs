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
        public List<string> Skils { get; set; }=new List<string>();
        public List<PreviousWorkedCompanies> previousWorkedCompanies { get; set; }=new List<PreviousWorkedCompanies>();
        public List<string> Languages { get; set; } = new List<string>();
        public bool HasCertificate { get; set; }
        public string WebsiteLinks { get; set; }

        public void ShowCV()
        {
            Console.WriteLine($"Qualificaation    : {Qualification}");
            Console.WriteLine($"School            : {School}");
            Console.WriteLine($"University score  : {UniScore}");
            int c = 0;
            foreach (var item in Skils)
            {
                Console.WriteLine($"[{++c}] Skill : {item}");
            }

            foreach (var item in previousWorkedCompanies)
            {
                item.Show();
            }
            int k = 0;
            foreach (var item in Languages)
            {
                Console.WriteLine($"[{++k}] Language : {item}");

            }
            Console.WriteLine($"Certificate  : {HasCertificate}");
            Console.WriteLine($"Website Link : {WebsiteLinks}");


        }


    }
}
