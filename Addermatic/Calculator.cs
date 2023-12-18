namespace Addermatic
{
    public class Calculator
    {
        public static int Sum(string operandA, string operandB)
        {
            var convertedOperandA = ConvertToInt(operandA);
            var convertedOperandB = ConvertToInt(operandB);
            return convertedOperandA + convertedOperandB;
        }

        private static int ConvertToInt(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentNullException();

            if (!int.TryParse(value, out var validatedNumber))
                throw new InvalidCastException("you must digit only int numbers, character not allowed");

            return ValidateNaturalNumber(validatedNumber);
        }

        private static int ValidateNaturalNumber(int number)
        {
            return number < 0 ? 0 : number;
        }


    }
}
