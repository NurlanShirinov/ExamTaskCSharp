using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTaskCSharp.Modes
{
    public class Human
    {
        public int Id { get; set; }
        public static int StaticID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public Human()
        {
            Id = StaticID++;
        }

        public override string ToString()
        {
            return $@"Id     : {Id}
Name     : {Name}
Surname  : {Surname}
Age      : {Age}
Phone    : {Phone}
City     : {City}
E-Mail   : {Mail}
Password : {Password}";

        }

    }
}
