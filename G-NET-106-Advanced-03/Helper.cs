using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_106_Advanced_03
{
    internal class Helper
    {
        public static void printCollection<T>(String collectionName, IEnumerable<T> collection)
        {
            Console.WriteLine($"{collectionName}:  {string.Join(", ", collection)}");

        }
    }
}
