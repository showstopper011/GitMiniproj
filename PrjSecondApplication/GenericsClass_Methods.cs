using System;
using System.Collections.Generic;
using System.Text;

namespace PrjSecondApplication
{

    class Sample<T> {

        T Name;
        T City;
        internal Sample(T Name, T City) {

            this.Name = Name;
            this.City = City;
        
        }
        // Normal Mtd

        internal void Add(int x, int y) {

            Console.WriteLine("Addition is :{0}", (x + y));
        }
        // Generic Method
        // <T>
        internal void Swap<T>(T x, T y) {

            T temp;
            temp = x;
            x = y;
            y = temp;
            Console.WriteLine("X is {0} || y is :{1}", x, y);
        }
    
    }
    /*Generic Constraint
     * Where T:Struct // value Type
     * Where T : Class// reference Type 
     
     * Where T : new // Default Paramenter Constraint
     * Where T: <interface Name>
      
      
      
     */
    class Student<T> where T : struct { }




    class GenericsClass_Methods
    {
        static void Main() {

            Sample<string> sample = new Sample<string>("Anu", "Chennai");
            sample.Swap<int>(6, 8);
            sample.Swap<string>("Good", "Morning");
            // struct Constraint
            //error Because student Class will Accept only struct value(Value type)
            //Student<string> student = new Student<string>();

            Student<int> student1 = new Student<int>();
        
        }

    }       
}
