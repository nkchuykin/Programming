using System;

namespace TaskG
{
    internal class Storage
    {
        private readonly int[,,] storage;

        public static int AmountOfUnsatisfiedCustomers;

        public Storage(int rows, int shelves, int sections)
        {
            throw new NotImplementedException();
        }

        private int[,,] FillStorage(int rows, int shelves, int sections)
        {
            throw new NotImplementedException();
        }

        private int GetAlmostRandomNumber(int a, int b, int c)
        {
            int bits = 32;
            long number = a + b + c + 42 / 2;
            number = (number * 0x5DEECE66DL + 0xBL) & ((1L << 48) - 1);
            return (int)Math.Abs(number >> (48 - bits)) / 1234567;
        }

        private int[] ParseLocation(string locationInfo)
        {
            throw new NotImplementedException();
        }

        public bool GetItem(string locationInfo)
        {
            throw new NotImplementedException();
        }
    }
}
