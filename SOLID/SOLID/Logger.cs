using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{

    // Liskov Substitution Principle, if you have a PARENT class that has overridable (virtual or abstract, or override)
    // member, that child class SHOULD be CLOSE to solving for what the parent class is solving for. ie.
    // you SHOULD be able to substitute your CHild class for your parent class and vise versa.
    public class Logger
    {
        public virtual void Log(string message)
        {
            Console.WriteLine(message);
        }
    }


    public class EmailLogger : Logger
    {
        public override void Log(string message)
        {
            // logic to send an email with logged information
        }
    }

    public class TextMessageLogger: Logger
    {
        // dependencies that you don't see

        public override void Log(string message)
        {
            // logic to send a text message with log information
        }

        // private methods
    }
}
