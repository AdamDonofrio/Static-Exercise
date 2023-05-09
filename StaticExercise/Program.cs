namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Static belongs to class
            // not static belongs to object/instance

            double celsius = 25;
            double fahrenheit = 77;

            Console.WriteLine($"{celsius} celsius is {TempConverter.CelsiusToFahrenheit(celsius)} in fahrenheit");

            Console.WriteLine($"{fahrenheit} fahrenheit is {TempConverter.FahrenheitToCelsius(fahrenheit)} in celsius");
        }
    }
}
