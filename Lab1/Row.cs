using System;

namespace Lab1
{
    public class Row
    {
        public Row()
        {
            
        }

        public Row(DateTime i1, DateTime i2, double i3)
        {
            Item1 = i1;
            Item2 = i2;
            Item3 = i3;
        }
        public DateTime Item1;
        public DateTime Item2;
        public double Item3;
    }
}
