﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PrjSecondApplication
{
    

    class Person { 
        
        public int id { get; set; }

        public string name { get; set; }


        public string city { get; set; }

        internal Person(int id, string name, string city) {

            this.id = id;
            this.name = name;
            this.city = city;
        
        
        }
    
    }

    class GenericsEg
    {
        static void ListEg() {

            List<string> fruits = new List<string>();
            fruits.Add("Mango");
            fruits.Add("Apple");
            fruits.Add("Orange");

            fruits.Insert(1, "Pineapple");
            fruits.RemoveAt(3);
            //fruits.Add(10);//TypeSafe

            List<string> Vegetables = new List<string>();

            Vegetables.Add("carrot");
            Vegetables.Add("Beetroot");
            Vegetables.AddRange(fruits);//adding onelist into anotherList

            foreach (var list in fruits) {

                Console.WriteLine("Fruits:{0}", list);

            
            }

            Console.WriteLine("Vegetables");

            foreach (var list in Vegetables) {

                Console.WriteLine("Vegetables:{0}", list);
            }
        
        
        }
        //key value pair

        static void DictionaryEg (){

            Dictionary<int, string> dt = new Dictionary<int, string>();
            dt.Add(1, "Java");
            dt.Add(2, "Networks");
            dt.Add(3, "AI");

            foreach (KeyValuePair<int, string> kp in dt) {

                Console.WriteLine(kp.Key + " " + kp.Value);
            
            }

        
        }

        static void StackEg() {

            Stack<int> st = new Stack<int>();
            st.Push(40);
            st.Push(30);
            st.Push(10);
            st.Push(50);

            foreach (var stack in st) {

                Console.WriteLine(stack);
            
            
            }
            st.Pop();
            Console.WriteLine("After 1 Pop");

            foreach (var stack in st) {

                Console.WriteLine(stack);

            
            }
            Console.WriteLine("peek:{0}", st.Peek());



        }

        static void QueueEg() {

            Queue<int> q = new Queue<int>();
            q.Enqueue(70);
            q.Enqueue(800);
            q.Enqueue(60);
            q.Enqueue(90);

            foreach (var queue in q) {

                Console.WriteLine(queue);
            
            }
            q.Dequeue();
            Console.WriteLine("After 1 dequeue");
            foreach (var queue in q) {

                Console.WriteLine(queue);
            }
            Console.WriteLine("peek:{0}", q.Peek());

        }

        static void SorteListEg() {

            SortedList<int,string> list = new SortedList<int,string>();
        }

        static void Main() {

            ListEg();
            Console.WriteLine("Person details");
            Console.WriteLine("---------------");
            List<Person> person = new List<Person>();
            person.Add(new Person(1, "SAI", "PUNE"));
            person.Add(new Person(2, "BABA", "Shirdi"));
            person.Add(new Person(3, "SabkaMalikEk", "PuNe"));
            foreach (Person p in person) {

                Console.WriteLine("ID:{0} || name:{1} || City:{2}", p.id, p.name, p.city);
            
            
            }
            Console.WriteLine("---------------");
            DictionaryEg();
            Console.WriteLine("----------------");
            StackEg();
            Console.WriteLine("----------------");
            QueueEg();




        }


    }

}
