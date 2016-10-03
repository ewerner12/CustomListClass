using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//// The built-in List<T> class is a generic class that acts as a wrapper over the array class. [DONE]
//// Task: Build a custom generic list class that stores its values in an array. [DONE]
//// Task: Write a method to add an object. [DONE]
//// Task: Write a method to remove an object. [DONE]
//// Task: Make sure your class is iterable. [DONE]
//// Task: Override the ToString Method that converts the contents of the custom list to a string. [DONE]
//// Task: Overload the + Operator in order to allow us to add two instances of your custom list class. [DONE]
//// Task: Overload the – Operator in order to allow us to subtract one custom list from another. [DONE]
//// Task: Implement a Count property. [DONE]
//// Task: Create a method to zipper two custom lists. [DONE]
//// 10 Bonus Points: 
////    Sorting.You must tell us what sorting algorithm you used.You cannot use Array.Sort() for this. []

namespace ListAssignment
{
    public class MyList<T> : IEnumerable
    {
        private static int arraySize = 10;
        private T[] items = new T[arraySize];
        private int itemCounter = 0;

        public IEnumerator GetEnumerator()
        {
            for (int index = 0; index < itemCounter; index++)
            {
                yield return items[index];
            }
        }

        public int Count()
        {
            return itemCounter;
        }

        public void Add(T item)
        {
            if(itemCounter >= arraySize)
            {
                T[] tempItems = new T[arraySize + 10];
                for (int i = 0; i < itemCounter; i++)
                {
                    tempItems[i] = items[i];
                }
                items = new T[arraySize + 10];
                items = tempItems;
            }
            items[itemCounter++] = item;
        }

        public void RemoveAt(int counterInput)
        {
            for (int i = counterInput; i < itemCounter; i++)
            {
                items[i] = items[i + 1];
            }
            // resize array to fit new list of items (less item removed) //
            ////T[] newItems = new T[itemCounter - 1];
            ////newItems = items;
            itemCounter--;
        }

        public void Remove(T itemMatch)
        {
            T[] newItems = new T[itemCounter];
            int matchesFound = 0;

            for(int i = 0; i < itemCounter; i++)
            {
                if (items[i].Equals(itemMatch))
                {
                    matchesFound++;
                }
                else
                {
                    newItems[i - matchesFound] = items[i];
                }
            }
            items = newItems;
            itemCounter -= matchesFound;
        }

        public override string ToString()
        {
            string itemList = null;

            for (int i = 0; i < itemCounter; i++)
            {
                itemList += items[i] + " : ";
            }
            return itemList;
        }

        public static MyList<T> operator +(MyList<T> firstList, MyList<T> secondList)
        {
            MyList<T> combinedList = new MyList<T>();

            for (int i = 0; i < firstList.Count(); i++)
            {
                combinedList.Add(firstList.items[i]);
            }
            for (int j = 0; j < secondList.Count(); j++)
            {
                combinedList.Add(secondList.items[j]);
            }

            return combinedList;
        }

        public static MyList<T> operator -(MyList<T> firstList, MyList<T> secondList)
        {
            for (int i = 0; i < secondList.Count(); i++)
            {
                firstList.Remove(secondList.items[i]);
            }
            return firstList;
            
            ////following will subtract shorter list from longer list and return resulting list
            //MyList<T> subtractedList = new MyList<T>();

            //if (firstList.Count() > secondList.Count())
            //{
            //    for (int i = 0; i < firstList.Count(); i++)
            //    {
            //        firstList.Remove(secondList.items[i]);
            //    }
            //    return firstList;
            //}
            //else if (firstList.itemCounter < secondList.itemCounter)
            //{
            //    for (int i = 0; i < secondList.Count(); i++)
            //    {
            //        secondList.Remove(firstList.items[i]);
            //    }
            //    return secondList;
            //}
            //else
            //{
            //    for (int i = 0; i < firstList.Count(); i++)
            //    {
            //        firstList.Remove(secondList.items[i]);
            //    }
            //    return firstList;
            //}
        }

        public MyList<T> ZipperTwoLists(MyList<T> firstList, MyList<T> secondList)
        {
            MyList<T> zipperedList = new MyList<T>();

            if (firstList.Count() > secondList.Count())
            {
                for (int i = 0; i < firstList.Count(); i++)
                {
                    zipperedList.items[i] = GetZippedItem(firstList.items[i], secondList.items[i]);
                }
            }
            else if (firstList.itemCounter < secondList.itemCounter)
            {
                for (int i = 0; i < secondList.Count(); i++)
                {
                    zipperedList.items[i] = GetZippedItem(firstList.items[i], secondList.items[i]);
                }
            }
            else
            {
                for (int i = 0; i < firstList.Count(); i++)
                {
                    zipperedList.items[i] = GetZippedItem(firstList.items[i], secondList.items[i]);
                }
            }

            return zipperedList;
        }

        public T GetZippedItem(T firstItem, T secondItem)
        {
            //should check for nulls

            string zippedItem;
            zippedItem = firstItem + " : " + secondItem;

            return (T)(object)zippedItem;
        }

        ////public MyList<T> GetSortedList(MyList<T> unsortedList)
        ////{
        ////    T tempItem = default(T);

        ////    for (int i = 0; i < unsortedList.Count(); i++)
        ////    {

        ////    }
        ////}

    }
}
