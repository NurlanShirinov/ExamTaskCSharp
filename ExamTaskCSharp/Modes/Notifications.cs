using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTaskCSharp.Modes
{
    public class Notifications
    {
        public int Id { get; set; }
        public static int StaticID { get; set; }
        public int ApplicantİD { get; set; }
        public string ApplicantName { get; set; }
        public List<CV> ApplicantCV { get; set; }=new List<CV>();
        public DateTime NotificationDate { get; set; }

        public Notifications()
        {
            Id = ++StaticID;
        }

        public void ShowNotification()
        {
            Console.WriteLine($"ID  : {Id}");
            Console.WriteLine($"Applicant ID    : {ApplicantİD}");
            Console.WriteLine($"Applicant Name  : {ApplicantName}");
            foreach (var item in ApplicantCV)
            {
                item.ShowCV();
            }
            Console.WriteLine($"Notification Date  : {NotificationDate}");
        }
    }
}
