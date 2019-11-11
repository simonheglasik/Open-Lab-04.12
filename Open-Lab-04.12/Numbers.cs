using System;

namespace Open_Lab_04._12
{
    public class Numbers
    {
        public int MissingNum(int[] nums)
        {
            int a = 0;
            foreach(int i in nums)
            {
                a = a + i;
            }
            a = 55 - a;
            if (a == 0) return 10;
            return a;
        }
    }
}
