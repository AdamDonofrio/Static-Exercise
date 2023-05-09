using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {
        //Static belongs to class
        // not static belongs to object/instance

        public static double FahrenheitToCelsius (double fahrenheit)
        {

            return ((fahrenheit - 32.0) * 5.0 / 9.0);
        }

        public static double CelsiusToFahrenheit(double celsius)
        {

            return ((celsius * (9.0/5.0) ) + 32.0);
        }
    }
}
