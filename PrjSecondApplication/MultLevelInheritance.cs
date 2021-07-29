using System;
using System.Collections.Generic;
using System.Text;

namespace PrjSecondApplication
{


    enum feedback { 
    
        poor =1 , Fair , Good = 4, Excellent 
    
    };


    class Department { 
    
        // Protected is used  wth in the clas and only in derived class

        protected int Did { get; set; }

        protected string Dname { get; set; }


        protected string city{ get; set; }



        internal Department(int Did, string Dname, string city) {

            Console.WriteLine("Department Constructor");
            this.Did = Did;
            this.Dname = Dname;
            this.city = city;
        
        }


        protected internal void DisplayDepartmentinfo() {

            Console.WriteLine("Dis:{0},Dname{1}",Did,Dname);
        
        }

        ~Department() {

            Console.WriteLine("Departmet DeStructor");
        }
    }
    // Single Inheritance
    // Child or Derived Class Employee


    class Employee :Department {

        internal static string CompanyName = "LTI";

        internal int Eid { get; set; }

        internal String Name { get; set; }
        internal string City = "Pune";


        internal Employee(int Eid, string Name,int Did , String Dname, String City):base(Did,Dname,City)
        {
            Console.WriteLine("Employee Constructor");
            this.Eid = Eid;
            this.Name = Name;
        
        }

        internal void DisplayEmployeeinfo() {

            DisplayDepartmentinfo();
            Console.WriteLine("Department City  is :{0}", base.city);
            Console.WriteLine("Eid:{0} || Ename:{1}|| feedback:{2}", Eid, Name, (int)feedback.Excellent);
            Console.WriteLine("Employee City is :{0}", City);
        
        }
        ~Employee() {

            Console.WriteLine("Employee Destructor");
        }
    
    }
    class PartTimeEmployee : Employee { 
    
        internal int houseofwork { get; set; }

        internal int salary { get; set; }


        internal PartTimeEmployee(int Eid, string Name, int Did, String Dname, string City, int houseofwork, int salary) : base(Eid, Name, Did, Dname ,City) {

            this.houseofwork = houseofwork;
            this.salary = salary;

        
        
        
        }

        internal int MonthlySalary() {

            int Payment = houseofwork * 30 * salary;

            return Payment;
        
        }
        ~PartTimeEmployee(){

            Console.WriteLine("PartTimeEmployee Destructor");
        
        }
    
    
    }



    class MultLevelInheritance
    {

        static void Main() {

            // Single Inheritance
            /* Employee employee = new  Employee(1001,"SAI",101,"HR,"Madurai");
              employee.DisplayEmployeeinfo();*/

            // error : Since Protected 
            // employee.DisplayDepartmentinfo();

            // MultiLevel Inheritance

            PartTimeEmployee pt = new PartTimeEmployee(1001, "SAI", 101, "HR", "Madurai", 67, 200);
            pt.DisplayEmployeeinfo();
            Console.WriteLine("Monthly Salary:{0}", pt.MonthlySalary());

            GC.Collect();
        }
    }
}
