using System;

namespace TaskC
{
    internal class Programmer
    {
    

        private int GetAlmostRandomNumber()
        {
            return (int)Math.Abs(Math.Sin(GetIdDigitsSum() % 11 + 1) * 12345);
        }

        public Programmer(int id)
        {throw new NotImplementedException();
        }

        private int GetIdDigitsSum()
        {
            throw new NotImplementedException();
        }

        public int Id
        {
            get { throw new NotImplementedException(); }
        }

        public int LinesOfCode
        {
            get { throw new NotImplementedException(); }
        }

        }
}