using System;
// using System.Collections.Generic;

namespace _06_mastermind
{
    class Compare
    {
        int _number;
        public void GenerateNumber()
        {
            Random RandomGenerator = new Random();
            _number = RandomGenerator.Next(1000,10000);
        }
    }
}