using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PrjSecondApplication
{
    class CollectionDemo
    {

        static void ArrayEg()
        {

            ArrayList al = new ArrayList();

            Console.WriteLine("Capacity{0}", al.Capacity);
            al.Add(10);
            Console.WriteLine("Capacity{0}", al.Capacity);
            al.Add("Devi");
            al.Add(100.0f);
            Console.WriteLine("Capacity{0}", al.Capacity);
            al.Add('a');
            Console.WriteLine("Capacity{0}", al.Capacity);
            al.Add(20);
            Console.WriteLine("Capacity{0}", al.Capacity);
            foreach (var arrayList in al)
            {

                Console.WriteLine("Elements are:{0}", arrayList);

            }

            Console.WriteLine("Count is {0}", al.Count);
            Console.WriteLine("Indexof is {0}", al.IndexOf(20));
            Console.WriteLine("Count is {0}", al.Capacity);
            al.Remove("Devi");
            al.Remove(20);

            foreach (var arrayList in al)
            {
                Console.WriteLine(arrayList);

            }

            Console.WriteLine("Capacity {0}", al.Capacity);



        }
        //Combination of key and Value

        static void HashtableEg() {

            Hashtable ht = new Hashtable();
            ht.Add("N","Networks");
            ht.Add("O", "Operating Systems");
            ht.Add("j", "Java");
            ht.Add("U", "Unix");

            Console.WriteLine("O");
            foreach (DictionaryEntry d in ht) {

                Console.WriteLine(d.Key + " " + d.Value);
            
            }


        }

        static void SortedListEg() {

            SortedList sl = new SortedList();
            sl.Add("N", "Networks");
            sl.Add("O", "Operating Systems");
            sl.Add("j", "Java");
            sl.Add("U", "Unix");

            Console.WriteLine("O");
            foreach (DictionaryEntry d in sl)
            {

                Console.WriteLine(d.Key + " " + d.Value);

            }

        }

        static void Main() {

            CollectionDemo demo = new CollectionDemo();
            ArrayEg();
            Console.WriteLine("HashTable");
            HashtableEg();
            Console.WriteLine("SorteList");
            SortedListEg();
            
        
        
        
        }

    }
}
