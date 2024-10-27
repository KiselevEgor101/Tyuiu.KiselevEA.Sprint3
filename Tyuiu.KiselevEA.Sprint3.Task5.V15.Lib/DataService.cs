﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KiselevEA.Sprint3.Task5.V15.Lib
{
    public class DataService : ISprint3Task5V15
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double ss = 0;
            int i, j;
            for (i = startValue1; i <= stopValue1; i++)
            {
                for (j = startValue2; j <= stopValue2; j++)
                {
                    ss = ss + (Math.Sin(x) + Math.Pow(j, 2) / 2);
                }
            }
            return Math.Round(ss, 3);
        }
    }
}
