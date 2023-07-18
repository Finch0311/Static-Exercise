

namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Fahrenheit ---> Celsius : {TempConverter.FahrenheitToCelsius(32)}");
            Console.WriteLine();

            Console.WriteLine($"Celsius ---> Fahrenheit : {TempConverter.CelsiusToFahrenheit(0)}");
            Console.WriteLine();

        }
    }
}
