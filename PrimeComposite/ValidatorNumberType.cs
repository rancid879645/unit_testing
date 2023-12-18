namespace PrimeComposite
{
    public class ValidatorNumberType
    {
        private readonly int _initialNumber;
        private readonly int _finalNumber;

        public ValidatorNumberType(string initialNumber, string finalNumber)
        {
            _initialNumber = ConvertToInt(initialNumber);
            _finalNumber = ConvertToInt(finalNumber);
        }

        private static int ConvertToInt(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentNullException();

            if (!int.TryParse(value, out var validatedNumber))
                throw new InvalidCastException("you must digit only int numbers, character not allowed");
            return validatedNumber;
        }

        public void Validate()
        {
            if (_initialNumber > _finalNumber)
                throw new InvalidDataException();

            for (var i = _initialNumber; i <= _finalNumber; i++)
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
