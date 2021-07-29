using System;
using System.Collections.Generic;
using System.Text;

namespace PrjSecondApplication
{
    class UGC { 
    
    string [] rules = { "Dress Code , Identity Card"};

        public virtual void RulesMethod() {


            foreach (var r in rules) {

                Console.WriteLine("Rules;{0}", r);
            
            }
        
        } 
    
    
    }


    class MIT : UGC{

        string mitrule = "No mobile";
        public override void RulesMethod()
        {
            base.RulesMethod();
            Console.WriteLine("MIT Rules:{0}", mitrule);

        }


    }


    class AnnaUniversity : UGC {

        string annarule = "only Formal dress";
        public new void RulesMethod() {

            base.RulesMethod();
            Console.WriteLine("AnnaUniversity:{0}", annarule);
        
        }
    
    }
    class VirtualEg
    {

        static void Main() {

            UGC uGC = new UGC();
            Console.WriteLine("UGC Rules");

            uGC.RulesMethod();
            Console.WriteLine("MIT Rules");

            MIT mitobj = new MIT();
            mitobj.RulesMethod();



        
        }

    }
}
