using System;
using System.Collections.Generic;
using System.Linq;

namespace PrjSecondApplication



    /*    Query Syntax
     *    From <range Variable> in enumerable<T> or iquerable<T> Collection
     *    Standard Query Operators
     *    Select or group by operator <result Formation>
     * 
     */
{

    class Student { 
    
        public int Rollno { get; set; }
        public string Name { get; set; }

        public string City { get; set; }

        public string Gender { get; set; }
        public int Age { get; set; }

        internal Student(int Rollno, string Name, string City, string Gender, int Age) {

            this.Rollno = Rollno;
            this.Name = Name;
            this.City = City;
            this.Gender = Gender;
            this.Age = Age;
        
        }
    
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] book = { "English", "Tamil", "Maths", "Science" };

            // LINQ : Query Syntax

            var result = from b in book
                            select b;
            foreach (var bname in result) {

                Console.WriteLine(bname);
            
            
            }
            Console.WriteLine("-----------------");
            Console.WriteLine("Display the book name that contains 'a'");
            //display the book name that contains 'a'

            var r = from bookname in book
                    where bookname.Contains('a')
                    select bookname;

            //Method Syntax

            var m1 = book.Where(s => s.Contains('a'));

            foreach (var bname in r) {

                Console.WriteLine(bname);
            }
            int[] Marks = { 90, 78, 67, 99, 100 };

            Console.WriteLine("Minimum Marks:{0}", Marks.Min());

            Console.WriteLine("Maximum Marks:{0}", Marks.Max());

            //Marks btw 70 and 100

            var r1 = from m in Marks
                     where m > 70 && m <= 100
                     select m;
            foreach (var marks in r1) {

                Console.WriteLine(marks);
            }
            


            //method syntax

            var m2 = Marks.Where(mark => mark > 70 && mark <= 100);


            var r2 = (from m in Marks
                      where m > 70 && m <= 100
                      select m).Count();

            Console.WriteLine("No of marks btw 70 and 100:{0}", r2);

            List<Student> stu = new List<Student>()
            {
                new Student(1001,"JANAKA","TRICHY","female",20),
                new Student(1002,"RoHAN","Chennai","Male",19),
                new Student(1003,"Raja","Madurai","Male",22),
                new Student(1004,"ABI","Salem","female",18),


            };
            // method syntax
            // Display max age of student
            var student = stu.Max(stud => stud.Age);

            // Display name and city where city is chennai

            var stucity = from s in stu
                          where s.City.Equals("Chennai")
                          select new { s.Name, s.City };
            Console.WriteLine("------------------");

            Console.WriteLine("Display name and city where city is Chennai");
            foreach (var st in stucity) {

                Console.WriteLine(st.Name + " " + st.City);
            }

            Console.WriteLine("------------------");
            Console.WriteLine("/order the student info based on gender");
            //order by 
            // order the student info based on gender

            var stugender = from s in stu
                            orderby s.Gender, s.Name
                            select s;
            foreach (var st in stugender) {

                Console.WriteLine(st.Name + "  " + st.City + "   " + st.Gender);
            
            }

            Console.WriteLine("----------------");
            Console.WriteLine("// No of Females");
            // Group by
            // No of Males and Females

            var stumf = from s in stu
                        group s by s.Gender;

            foreach ( var s in stumf) {

                Console.WriteLine(s.Key + " " + s.Count() );
            
            }




        }
    }
}
