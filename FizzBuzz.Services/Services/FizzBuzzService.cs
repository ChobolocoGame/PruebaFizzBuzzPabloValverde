using System;


/*Creamos la lógica del juego FizzBuzz donde capturamos el rango del valor*/
namespace FizzBuzz.Services
{ 
    public class FizzBuzzService : IFizzBuzzService
    {
        public string Check(int number)
        {
            if (number < 1 || number > 100)
            {
                throw new ArgumentOutOfRangeException(string.Format("valores comprendido entre uno y cien", number));
            }
            if (number % 15 == 0) return "FizzBuzz";
            if (number % 3 == 0) return "Fizz";
            if (number % 5 == 0) return "Buzz";
            return number.ToString();
        }
    }
}
