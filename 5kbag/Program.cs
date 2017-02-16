using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5kbag
{
    class Program
    {
        public   const int totalMemory= 4;
        public static string memory = new string(' ', 1024 * totalMemory);


        static void Main(string[] args)
        {
            var list = getList(1024 * (totalMemory+1));  //5k list of numbers

            foreach (var item in list)
            {

                memory.Add(memoryLocation, item);
                if (memory.Length > )
            }


        }



        /// <summary>
        /// generates a random list of numbers, range from 0 to 65535.  This code is ok; shouldn't need to be fixed.
        /// </summary>
        /// <param name="elements"></param>
        /// <returns></returns>
        private static IList getList(int elements)
        {
            Random rnd = new Random();
            var retVal = new List<uint>();
            uint randomNumber = 0;
            for (int x = 0; x < elements; x++)
            {
                randomNumber = randomNumber + (uint)rnd.Next(9);
                if (randomNumber > 65535)
                    return retVal;
                retVal.Add(randomNumber);
            }
            return retVal;
        }
    }
}
