using System;

namespace Encapsulation
{
    public class Employee
    {
        private int empExperience;

        public int EmpExperience
        {
            get
            {
                return empExperience;
            }
            set
            {
                empExperience = value;
            }
        }
        static void Main(string[] args)
        {
            Employee objEmployee = new Employee();
            //objEmployee.empExperience = 3; //Not Possible
            objEmployee.EmpExperience = 3;
        }
    }
}