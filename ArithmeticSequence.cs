using System;

namespace PadawansTask2
{
    public static class ArithmeticSequence
    {
        public static int Calculate(int number, int add, int count)
        {
            if (add <= 0)
                throw new ArgumentException("add <= 0");
            if (count <= 0)
                throw new ArgumentException("count <= 0");
            int result = 0;
            try
            {
                for (int i = 0; i < count; i++)
                    result += number + add * i;
            }
            catch(ArgumentOutOfRangeException ex)
            {
                throw new ArgumentOutOfRangeException();
            }
            return result;
        }
    }
}
