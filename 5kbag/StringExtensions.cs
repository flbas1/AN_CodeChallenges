namespace _5kbag
{
    public static class StringExtensions
    {
        public static string Poke(this string value, int loc, uint item)
        {
            string tmp = value.Decompress();
            int last = 0;
            foreach (char c in tmp)
                last += c - '0';
            tmp += (item - last).ToString();
            return tmp.Compress();
        }

        public static uint Peek(this string value, int loc)
        {
            string tmp = value.Decompress();
            int num = 0;
            for (int i = 0; i <= loc; i++)
                num += tmp[i] - '0';
            return (uint)num;
        }
    }
}
