using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TULearning
{
    class ChildExample : ExampleClass
    {
        private string MiddelName { get; set; }
        public ChildExample()
        {
            
        }

        public string getLastAndMiddelName()
        {
            return base.getLastName() + " " + MiddelName;
        }
        public string getLastAndMiddelName(string FirstName)
        {
            return base.getLastName() + " " + MiddelName + " " + FirstName;
        }

        public override string ToString()
        {
            return base.ToString() + "String";
        }
        public override string getLastName()
        {
            return base.getLastName() + " JR.";
        }
    }
}
