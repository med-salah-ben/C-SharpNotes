using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    internal class Students
    {
        public string name;
        public int age;
        public double gpa;

        public Students(string aName ,int aAge ,double  aGpa) { 
            name = aName;
            age= aAge;
            gpa = aGpa;
        }

        //METHODS
        public bool Honnor()
        {
            if(gpa > 3)
            {
                return true;
            }
            return false;
        }
    }
}
