using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTaskCSharp.Modes
{
    public class Menu
    {
        static Human CurrentUser = new Human();

        static Vacancy vacancy1 = new Vacancy
        {
            CompanyName = "IT STEP ACADEMY",
            Name = ".NET Developer",
            Requirments = new List<string>
          {
              "Müvafiq sahədə ən azı 2 il iş təcrübəsi",
              "ASP.NET Web Forms, ASP.NET MVC haqqında biliklər, bu platformalarda yeni proyektlərin tərtib edilməsi",
              "SOAP/REST tipli veb servislər ilə ən az 1 il iş təcrübəsi olması",
              "Minimum 2 il C# dili və .NET Framework ilə proqramlaşdırma təcrübəsi",
              "MS SQL haqqında bilik və bacarıqlar",
          },
            Salary = 10000
        };

        static Vacancy vacancy2 = new Vacancy
        {
            CompanyName = "Code ACADEMY",
            Name = "SMM",
            Requirments = new List<string>
          {
              "Sosial Media təqvimini, effektiv planı, mövzuları zamana görə planlaşdırır və hazırlayır ",
              "Brendin məqsədi və imicinə uyğun, gündəlik olaraq şəkil, mətn, video daxil olmaqla sosial mediada paylaşımları yaradır və yerləşdirir",
              "Brendlərin sosial səhifələrini yaradır və işlədir ",
              "Korporativ standartlara əsasən sosial mediada tələb olunan məlumatlar ilə müştərilərin və izləyicilərin suallarına cavab verir ",
              "Davamlı olaraq izləyicilərin, bəyənmələrin, rəylərin və paylaşımların sayının artırılmasını təmin edir ",
          },
            Salary = 3500
        };

        static Vacancy vacancy3 = new Vacancy
        {
            CompanyName = "Veyseloglu LLC",
            Name = "SMM",
            Requirments = new List<string>
          {
              "Sosial Media təqvimini, effektiv planı, mövzuları zamana görə planlaşdırır və hazırlayır ",
              "Brendin məqsədi və imicinə uyğun, gündəlik olaraq şəkil, mətn, video daxil olmaqla sosial mediada paylaşımları yaradır və yerləşdirir",
              "Brendlərin sosial səhifələrini yaradır və işlədir ",
              "Korporativ standartlara əsasən sosial mediada tələb olunan məlumatlar ilə müştərilərin və izləyicilərin suallarına cavab verir ",
              "Davamlı olaraq izləyicilərin, bəyənmələrin, rəylərin və paylaşımların sayının artırılmasını təmin edir ",
          },
            Salary = 3500
        };


        static Worker worker1 = new Worker
        {
            Name = "Nurlan",
            Surname = "Shirinov",
            Age = 24,
            City = "Agdam",
            Phone = "0517901252",
            Mail = "n",
            Password = "n",
            WorkerCV = new List<CV>
            {
                 new CV
                 {
                      Qualification ="BioMedical Engineering",
                      School ="48 numbered secondary school",
                      Languages = new List<string>{ "English - UpperIntermediate","Russian - Intermediate"},
                      Skils = new List<string>{ "Time Management and Efficiency", "Leadership skills", "Negotiation skills","Presentation and Communication skills" },
                      UniScore = 373,
                      HasCertificate = true,
                      previousWorkedCompanies = new List<PreviousWorkedCompanies>
                      {
                         new PreviousWorkedCompanies
                           {
                                  CompanyName = "M-Trans LLC",
                                   Position="Logistic Specialist",
                                    StartDate=new DateTime(2020,01,27),
                                     EndDate=new DateTime(2022,06,03)
                           }
                      },
                      WebsiteLinks = "in/nurlan-shirinov-482969185/"
                 }
            }
        };

        static Employer employer1 = new Employer
        {
            Name = "Melik",
            Surname = "Kazimov",
            Age = 45,
            City = "Baku",
            Phone = "0517612898",
            Mail = "m",
            Password = "m",
            Vacancies = new List<Vacancy> { vacancy1, vacancy2 },
        };

        static Employer employer2 = new Employer
        {
            Name = "Sebuhi",
            Surname = "Aliyev",
            Age = 34,
            City = "Baku",
            Phone = "0558751568",
            Mail = "sebuhi@inbox.ru",
            Password = "sebuhi123",
            Vacancies = new List<Vacancy> { vacancy3 },
        };



        static DataBase dataBase = new DataBase
        {
            humans = new List<Human> { employer1, employer2, worker1 }
        };

        public static void SignIn()
        {
            Console.Write("E-Mail : ");
            string email = Console.ReadLine();

            Console.Write("Password : ");
            string password = Console.ReadLine();

            foreach (var item in dataBase.humans)
            {
                if (email == item.Mail && password == item.Password)
                {
                    CurrentUser = item;
                    break;
                }
            }

            if (CurrentUser is Employer) EmployerPage();
            else if (CurrentUser is Worker) WorkerPage();
            else Console.WriteLine("User is not excist!!");

        }

        public static void SignUp()
        {

            Console.Write("Name : ");
            string name = Console.ReadLine();

            Console.Write("Surname : ");
            string surname = Console.ReadLine();

            Console.Write("Age : ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("City :");
            string city = Console.ReadLine();

            Console.Write("Phone : ");
            CurrentUser.Phone = Console.ReadLine();

            Console.Write("E-Mail : ");
            string mail = Console.ReadLine();

            Console.Write("Add Password : ");
            string password = Console.ReadLine();

            foreach (var item in dataBase.humans)
            {
                if (mail == item.Mail)
                {
                    Console.WriteLine("This E-Mail has already used!");
                    SignUp();
                }
            }

            Console.Write(@"You are Empoyer or Worker?

Employer   [1]
Worker     [2]

Add Here : ");
            int opt = int.Parse(Console.ReadLine());



        }


        public static void Start()
        {
            while (true)
            {

                Console.Write(@"Sign In   [1]
Sign up   [2]

Add Here : ");
                int select = int.Parse(Console.ReadLine());
                if (select == 1)
                {
                    SignIn();
                }
                else if (select == 2)
                {

                }
            }
        }

        public static void EmployerPage()
        {
            Employer CurrentEmployer = (Employer)CurrentUser;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"WELCOME {CurrentUser.Name} {CurrentUser.Surname}");
            Console.ResetColor();
            Console.Write(@"Show your vacancies    [1]
Add vacancy            [2]
Show Notification      [3]

Enter your option  : ");

            int option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                CurrentEmployer.ShowVacancies();
            }
            else if (option == 2)
            {
                CurrentEmployer.AddNewVacancies();
            }
            else if (option == 3)
            {
                Console.Clear();
                CurrentEmployer.ShowNotifications();
                Console.WriteLine("\n\n");
                Console.WriteLine("Enter Notification ID to Accept or Reject : ");
                int notificationId = int.Parse(Console.ReadLine());
                Console.Clear();
                CurrentEmployer.ShowNotificationByID(notificationId);
                Console.WriteLine("\n\n");

                Console.Write(@"Do you ACCEPT or REJECT?
ACCEPT  [1]
Reject  [2]

Add Here : ");
                int choosen = int.Parse(Console.ReadLine());
                if (choosen ==1)
                {
                    Console.Write("Enter Applicant ID : ");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter note to accepted Applicant : ");
                    string notification = Console.ReadLine();
                    dataBase.GetWorkerByID(id).Notifications.Add(notification);
                }
                else if (choosen == 2)
                {
                    Console.Write("Enter Applicant ID : ");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter note to Rejected Applicant : ");
                    string notification = Console.ReadLine();
                    dataBase.GetWorkerByID(id).Notifications.Add(notification);
                }


            }
        }

        public static void WorkerPage()
        {
            Worker CurrentWorker = (Worker)CurrentUser;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"WELCOME {CurrentWorker.Name} {CurrentWorker.Surname}");
            Console.ResetColor();

            Console.Write(@"
Show Vacancies    [1]
Apply Vacancies   [2]
Add CV            [3]
Show CV           [4]
Notification      [5]

Add your option  : ");

            int option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                foreach (var item in dataBase.humans)
                {
                    if (item is Employer)
                    {
                        Employer employer = (Employer)item;
                        employer.ShowVacancies();
                    }
                }
            }
            else if (option == 2)
            {
                Console.Write("Enter Id to Apply Vacancy : ");
                int id = int.Parse(Console.ReadLine());
                Notifications newNotification = new Notifications
                {
                    ApplicantName = CurrentWorker.Name,
                    ApplicantİD = CurrentWorker.Id,
                    ApplicantCV = CurrentWorker.WorkerCV,
                    NotificationDate = DateTime.Now,
                };
                dataBase.GetVacancyByID(id).Notifications.Add(newNotification);
            }
            else if (option == 3)
            {
                CurrentWorker.AddCV();
            }
            else if (option == 4)
            {
                dataBase.ShowCV();
            }
            else if (option == 5)
            {
                if (CurrentWorker.Notifications != null)
                {
                    foreach (var item in CurrentWorker.Notifications)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        }

    }
}
