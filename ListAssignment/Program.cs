using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//// The built-in List<T> class is a generic class that acts as a wrapper over the array class
//// Task: Build a custom generic list class that stores its values in an array.
//// Task: Write a method to add an object.
//// Task: Write a method to remove an object
//// Task: Make sure your class is iterable
//// Task: Override the ToString Method that converts the contents of the custom list to a string.
//// Task: Overload the + Operator in order to allow us to add two instances of your custom list class
//// Task: Overload the – Operator in order to allow us to subtract one custom list from another
//// Task: Implement a Count property
//// Task: Create a method to zipper two custom lists.
//// 10 Bonus Points: Sorting.You must tell us what sorting algorithm you used.You cannot use Array.Sort() for this.

namespace ListAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            //////List<string> newList = new List<string>();
            //////newList.Add("abc");
            //////newList.Add("DEF");
            //////newList.Add("ghi");
            //////newList.Add("TEST");

            MyList<int> sampleList = new MyList<int>();
            sampleList.Add(1);
            sampleList.Add(2);
            sampleList.Add(3);
            sampleList.Add(4);
            sampleList.Add(5);
            sampleList.Add(6);
            sampleList.Add(7);
            sampleList.Add(8);

            MyList<int> sample2List = new MyList<int>();
            sample2List.Add(9);
            sample2List.Add(10);
            sample2List.Add(2);
            sample2List.Add(4);
            sample2List.Add(6);
            sample2List.Add(8);

            MyList<int> combinedList = new MyList<int>();
            combinedList = (sampleList + sample2List);
            foreach (int i in combinedList)
            {
                Console.Write("{0} : ", i);
            }

            MyList<string> stringList = new MyList<string>();
            stringList.Add("abc");
            stringList.Add("DEF");
            stringList.Add("ghi");
            stringList.Add("JKL");
            stringList.Add("mno");
            stringList.Add("abc");
            stringList.Add("PQR");
            stringList.Add("stu");

            //foreach (int i in sampleList)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("Array length = {0} ", sampleList.Count());
            Console.WriteLine("");
            Console.WriteLine("");
            foreach (string i in stringList)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Array length = {0} ", stringList.Count());
            Console.WriteLine("");

            stringList.Remove("abc");

            foreach (string i in stringList)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Array length = {0} ", stringList.Count());
            Console.WriteLine("");

            Console.WriteLine(sampleList);
            Console.WriteLine(stringList);
            Console.WriteLine("");

            MyList<int> subtractedList = new MyList<int>();
            subtractedList = (sampleList - sample2List);
            Console.WriteLine("Subtracted list: ");
            foreach (int i in subtractedList)
            {
                Console.WriteLine(i);
            }


            ////////removing item by index////////
            //sampleList.RemoveAt(1);
            //foreach (int i in sampleList)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("Array length = {0} ", sampleList.Count());

            //sampleList.RemoveAt(2);
            //foreach (int i in sampleList)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("Array length = {0} ", sampleList.Count());

            //sampleList.RemoveAt(3);
            //foreach (int i in sampleList)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("Array length = {0} ", sampleList.Count());

            //sampleList.RemoveAt(4);
            //foreach (int i in sampleList)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("Array length = {0} ", sampleList.Count());
            ////////removing item by index////////

            ////////removing item by value////////
            //sampleList.Remove(5);
            //foreach (int i in sampleList)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("Array length = {0} ", sampleList.Count());
            ////////removing item by value////////


            Console.ReadLine();


        }
    }
}
