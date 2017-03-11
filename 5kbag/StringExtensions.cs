using System;

namespace _5kbag
{
    public static class StringExtensions
    {
        public static string Poke(this string value, int loc, int item)
        {
            if (value == "")  return ((char)item).ToString();

            int x = item - value.Peek(loc+1);
            char end = value[value.Length - 1];
            if (end > 15)
            {
                value += (char)x;
            }
            else
            {
                int next = Convert.ToInt32(((int)end).ToString() + x.ToString()) + 20;
                value = value.Substring(0, value.Length - 1) + ((char)next).ToString();
            }

            return value;
        }

        public static int Peek(this string value, int loc)
        {
            int pos = 0;
            int last = 0;
            foreach (char c in value)
            {
                if (pos > loc) break;
                if (c > 15)
                {
                    foreach (char d in (c - 20).ToString())
                    {
                        if (pos > loc) break;
                        last += Convert.ToInt32(d.ToString());
                        pos++;
                    }
                }
                else
                {
                    last += c;
                    pos++;
                }
            }
            return last;
        }
    }
}
