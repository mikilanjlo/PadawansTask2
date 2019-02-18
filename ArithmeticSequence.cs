using System;

namespace PadawansTask2
{
    public static class ArithmeticSequence
    {
        public static int Calculate(int number, int add, int count)
        {
            
            if (count <= 0)
                throw new ArgumentException("count <= 0");
            int result = 0;
            try
            {
                for (int i = 0; i < count; i++)
                    result += number + add * i;
            }
            catch(OverflowException ex)
            {
                throw new OverflowException();
            }
            return result;
        }
    }
}
