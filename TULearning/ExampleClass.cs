using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TULearning
{
    public class ExampleClass
    {
        private string Name { get; set; }
        private string LastName { get; set; }

        public ExampleClass()
        {

        }

        public virtual string getLastName()
        {
            return LastName;
        }

        public void ChangeLastName(string newLastName)
        {
            LastName = newLastName;
        }
    }
}
