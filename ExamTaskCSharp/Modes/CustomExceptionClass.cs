using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTaskCSharp.Modes
{
    public class CustomExceptionClass:ApplicationException
    {
        public CustomExceptionClass(string message, DateTime dateTime, int errorLine, string errorFilePath)
        {
            Message = message;
            this.dateTime = dateTime;
            ErrorLine = errorLine;
            ErrorFilePath = errorFilePath;
        }

        public string Message { get; set; }
        public DateTime dateTime { get; set; }
        public int ErrorLine { get; set; }
        public string ErrorFilePath { get; set; }
        public override string ToString()
        {
            return $@"Message : {Message}
Error Line : {ErrorLine}
Error Time : {dateTime}
Erro File Path {ErrorFilePath}";
        }

    }
}
