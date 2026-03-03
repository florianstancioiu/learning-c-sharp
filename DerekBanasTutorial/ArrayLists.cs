using System.Collections;
using System.Collections.Generic;

namespace LearningCSharp.DerekBanasTutorial
{
    class ArrayLists
    {
        public ArrayLists()
        {
            // ArrayList is similar to arrays in PHP, you can add whatever datatypes you want in them
            // and they increase in size automatically

            ArrayList arrayList = new ArrayList();
            arrayList.Add("Bob");
            arrayList.Add(40);
            
            Console.WriteLine("Count: {0}", arrayList.Count);
            Console.WriteLine("Capacity: {0}", arrayList.Capacity);
            
            ArrayList secondArrayList = new ArrayList();
            secondArrayList.AddRange(new object[] {"Mike", "Sally", "Egg"});
            arrayList.Add(secondArrayList);

            // secondArrayList.Sort();
            secondArrayList.Insert(1, "Turkey");

            Console.WriteLine("Turkey index: {0}", secondArrayList.IndexOf("Turkey", 0));

            foreach(object o in secondArrayList)
            {
                Console.WriteLine(o);
            }
        }
    }
}