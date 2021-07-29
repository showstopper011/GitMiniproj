using System;
using System.Collections.Generic;
using System.Text;

namespace PrjSecondApplication
{


    interface INormalCal {

        // Public and Abstract

        int Add(int x, int y);
        int Sub(int x, int y);
  
    }

    interface IScical {

        int Add(int x, int y);
        int mul (int a, int b);

    }

    class Calculator : INormalCal, IScical {

        int INormalCal.Add(int x, int y) {


            return x + y;
        
        }

        public int Sub(int x, int y) {

            return x - y;
        
        }

        int IScical.Add(int x, int y) {

            return x + y;
        
        }

        public int mul(int a, int b) {

            return a * b;
        
        }
    
    }


    class InterfaceEg
    {
        static void Main() {
            INormalCal ncal = new Calculator();
            Console.WriteLine("Addition of Normal Calculator:{0}",ncal.Add(5,7));
            Console.WriteLine("Subtraction of Normal Calculator:{0}", ncal.Sub(90, 7));
            IScical scical = new Calculator();
            Console.WriteLine("Addition of Scientific Calculator:{0}", scical.Add(5, 7));
            Console.WriteLine("Multiply of Scientific Calculator:{0}", scical.mul(10, 7));
        }
    }
}
