using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesLadders.Services
{
    public interface IDigitService
    {
        int GetDigit();
    }

    public class DigitService : IDigitService
    {
        private const int _min = 1;
        private const int _max = 6;
        //private Random random = new Random(DateTime.Now.Millisecond);

        public int GetDigit()
        {
            int min = 1;
            int max = 6;
            Random random = new Random(DateTime.Now.Millisecond);
            var number = random.Next(min, max);
            return number;
        }
    }
}
