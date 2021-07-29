using System;
using System.Collections.Generic;
using System.Text;

namespace PrjSecondApplication
{

    abstract class RBI
    {
        internal string rule = "Customer should have aadhar card";
        // Abstract Method
        abstract public int HomeLoan();
        abstract public int EduLoan();

        // Non Abstrat Method
        internal void Rules()
        {

            Console.WriteLine("Rules to be followed by all bank:{0}", rule);



        }
    }

        abstract class SBI : RBI {
            // SBI abstract Methd
            abstract public void SBICustomer();
            // RBI Abstract MTD

            public override int HomeLoan() {

                return 8;
            
            }
            public override int EduLoan()
            {
                return 10;
            }


        }

    class SBIBranch : SBI {

        public override void SBICustomer() {

            Console.WriteLine("it has 1 lakh customer");
        
        }
    }
    
    
    
    class AbstractEg
    {
        static void Main() {

            // object cant be created for abstract class
            // RBI r = new RBI();

            /* SBI sbiobj = new SBI();
             Console.WriteLine("SbiHomeLoan:{0}",sbiobj.HomeLoan());
            
              Console.WriteLine("SbiEDULoan:{0}", sbiobj.EduLoan());

 

               sbiobj.Rules();*/

            /*  SBIBranch sBIBranchobj = new SBIBranch();
              Console.WriteLine("SbiHomeLoan:{0}",sBIBranchobj.EduLoan());
              Console.WriteLine("SbiEDULoan:{0}",sBIBranchobj.HomeLoan()); 
              sBIBranchobj.SBICustomer();
              sBIBranchobj.Rules();*/

            // runtime Polymorphism
            // reference of Parent class 
            RBI rbiobj = new SBIBranch();

            // object of child Class
            Console.WriteLine("SbiHomeLoan:{0}", rbiobj.EduLoan());
            Console.WriteLine("SbiEduLoan:{0}", rbiobj.HomeLoan());

            SBI sbiobj = new SBIBranch();
            sbiobj.SBICustomer();

            sbiobj.Rules();
            rbiobj.Rules();
        }

    }
}
