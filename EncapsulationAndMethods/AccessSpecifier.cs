using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EncapsulationAndMethods
{
    class AccessSpecifier
    {
        public double FirstNumber;
        public double SecondNumber;
        public double ShowResult()
        {
            return FirstNumber + SecondNumber;
        }
        private string Message;
        public string ShowMessage()
        {
            Message = "this message is a private access and This is a Porn Site";
            return Message;
        }
    }
}
