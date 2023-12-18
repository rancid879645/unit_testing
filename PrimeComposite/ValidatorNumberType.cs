namespace PrimeComposite
{
    public class ValidatorNumberType
    {
        public static void Validate(string initialNumber, string finalNumber)
        {
            var convertedInitialNumber = ConvertToInt(initialNumber);
            var convertedFinalNumber = ConvertToInt(finalNumber);

            if (convertedInitialNumber > convertedFinalNumber)
                throw new InvalidDataException();
            
            Iterate(convertedInitialNumber,convertedFinalNumber);
        }

        private static int ConvertToInt(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentNullException();

            if (!int.TryParse(value, out var validatedNumber))
                throw new InvalidCastException("you must digit only int numbers, character not allowed");
            return validatedNumber;
        }



        private static void Iterate(int initialNumber, int finalNumber)
        {
            for (var i = initialNumber; i <= finalNumber; i++)
            {
                if (i < 2)
                    Console.WriteLine(i);
                else if (IsComposite(i))
                    Console.WriteLine("Composite");
                else
                    Console.WriteLine("Prime");

            }
        }

        private static bool IsComposite(int number)
        {
            for (var i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return true;
            }
            return false;
        }

    }
}
