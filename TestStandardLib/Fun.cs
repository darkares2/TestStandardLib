using System;

namespace TestStandardLib
{
    public class Fun
    {
        public int Return10()
        {
            Random random = new Random();
            int value = random.Next(100);
            value += 45;
            value -= random.Next(45);
            return value;
        }
    }
}
