using System;
using System.Collections.Generic;

namespace _5kbag
{
    class Program
    {

        #region "defaults for project.  This area should be ok"
        /// <summary>
        /// how much memory we are able to use
        /// </summary>
        public const int totalMemory = 4;

        /// <summary>
        /// our actual memory container
        /// </summary>
        public static string memory = string.Empty;

        /// <summary>
        /// generates a random list of numbers, range from 0 to 65535.  This code is ok; shouldn't need to be fixed.
        /// </summary>
        /// <param name="elements"></param>
        /// <returns></returns>
        private static List<int> getList(int elements)
        {
            Random rnd = new Random();
            var retVal = new List<int>();
            int randomNumber = 0;
            for (int x = 0; x < elements; x++)
            {
                randomNumber = randomNumber + rnd.Next(8) + 1;
                if (randomNumber > 65535)
                    return retVal;
                retVal.Add(randomNumber);
            }
            return retVal;
        }

        #endregion

        static void Main(string[] args)
        {
            var list = getList(1024 * (totalMemory + 1));  //5k list of numbers

            int memoryLocation = 0;
            foreach (int item in list)
            {
                memory = memory.Poke(memoryLocation++, item);

                if (memory.Length > 1024 * totalMemory)
                    throw new OutOfMemoryException();
            }

            //done.  now lets test
            for (var loc = 0; loc < list.Count - 1; loc++)
                if (list[loc] != memory.Peek(loc))  //please make this line work also
                    throw new NotFiniteNumberException();

            Console.WriteLine("Success!");
            Console.WriteLine(list.Count);
            Console.WriteLine(memory.Length);
            Console.ReadLine();

        }
    }
}
