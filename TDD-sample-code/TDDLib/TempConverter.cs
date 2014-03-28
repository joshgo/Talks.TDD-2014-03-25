using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDDLib
{
    public enum TempEnum
    {
        Fahrenheit,
        Celsius,
        Kelvin
    };
    
    public class TempConverter
    {
        public double Convert(double value, TempEnum from, TempEnum to)
        {
            if (from == to)
                return value;

            if (from == TempEnum.Fahrenheit)
            {
                if (to == TempEnum.Celsius)
                    return (value - 32) * 5.0 / 9;
                if (to == TempEnum.Kelvin)
                    return Convert(value, from, TempEnum.Celsius) + 273;
            }

            if (from == TempEnum.Celsius)
            {
                if (to == TempEnum.Fahrenheit)
                    return value * 9.0 / 5 + 32;
                if (to == TempEnum.Kelvin)
                    return value + 273;
            }

            if (from == TempEnum.Kelvin)
            {
                if (to == TempEnum.Fahrenheit)
                    return Convert(value, TempEnum.Fahrenheit, TempEnum.Celsius);
                if (to == TempEnum.Celsius)
                    return value - 273;
            }

            throw new ApplicationException();
        }
    }
}
