﻿using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.NazarovaKH.Sprint1.Task2.V11.Lib
{
    public class DataService : ISprint1Task2V11
    {
        public int ConvertHoursMinutesToSeconds(int value, int valueTwo)
        {
            return value * 60 * 60;
        }
    }
}
