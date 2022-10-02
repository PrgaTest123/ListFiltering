using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace ListFiltering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<object> item = new List<object>() {1, 2, "a", "b"};
            Console.WriteLine(string.Join(",", GetIntegersFromList(item)));
        }

        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            //Best practice
            // return listOfItems.OfType<int>();
            var result = new List<int>();
            foreach (var item in listOfItems)
            {
                if (item is int)
                    result.Add((int)item);
            }
            return result;
        }


    }
}
