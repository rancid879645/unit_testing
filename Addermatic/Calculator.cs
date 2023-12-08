﻿namespace Addermatic
{
    public class Calculator
    {
        private int _operandA;
        private int _operandB;

        public Calculator(string operandA, string operandB)
        {
            _operandA = ConvertToInt(operandA);
            _operandB = ConvertToInt(operandB);
        }
        private static int ConvertToInt(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentNullException();

            if (!int.TryParse(value, out var validatedNumber))
                throw new InvalidCastException("you must digit only int numbers, character not allowed");
            return validatedNumber;
        }

        public int SumOperands()
        {
            if (_operandA < 0)
                _operandA = 0;
            else if (_operandB == 0)
                _operandB = 0;

            return _operandA + _operandB;
        }
    }
}
