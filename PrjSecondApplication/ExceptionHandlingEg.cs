using System;
using System.Collections.Generic;
using System.Text;

namespace PrjSecondApplication
{


    //Custom or user defined Exception

    public class AgeNotValid : ApplicationException {

        public AgeNotValid(string Message) : base(Message) { 
        
        
        }
    
    }
    class ExceptionHandlingEg
    {
        static void Main()
        {
            try
            {
                int num = 10, div = 0;

                if (div == 0)
                {

                    throw new DivideByZeroException();

                }
                else
                {

                    num = num / div;

                }

                Console.WriteLine(num);
                int[] arr = new int[] { 20, 30, 40 };
                //Console.Writeline(arr[6]);
                Console.WriteLine("Enter the Age");
                int Age = Convert.ToInt32(Console.ReadLine());

                if (Age < 18)
                {

                    Console.WriteLine("Hello");

                }
                else {

                    Console.WriteLine("NO hello");
                
                
                }

            }
            //Error Child then Parent
            /* catch (Exception e) { 



              }*/
            catch (DivideByZeroException e)
            {

                // Console.WriteLine(e);
                // Console.WriteLine(e.Message);
                //Console.WriteLine(e.Source);
                Console.WriteLine("Please enter the Valid number!!! ");



            }
            catch (ArgumentOutOfRangeException e)
            {


                Console.WriteLine(e);
            }
            catch (Exception e)
            {

                Console.WriteLine(e);


            }
            finally {

                Console.WriteLine("Hope u are Good !!!");
            
            
            }
        
            
        }


    }
}
