namespace CalcStats
{
    public class Operations
    {
        private readonly List<int> _numbers;
        private const char Separator = '-';
        public Operations(string numbers)
        {
            _numbers = ConvertStringInListInt(numbers);
        }

        private static List<int> ConvertStringInListInt(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                throw new ArgumentNullException();

            if (!numbers.Contains(Separator))
                throw new ArgumentException();

            var result = new List<int>();

            foreach (var number in numbers.Split(Separator))
            {
                if (!int.TryParse(number, out var validatedNumber))
                    throw new InvalidCastException("you must digit only int numbers, character not allowed");
                result.Add(validatedNumber);    
            }
            
            return result;
        }

        public int GetMinValue()
        {
            return _numbers.Min();
        }

        public int GetMaxValue()
        {
            return _numbers.Max();
        }

        public int CountElements()
        {
            return _numbers.Count();
        }

        public float GetAverageValue()
        {
            var result = (float)_numbers.Sum() / _numbers.Count();
            return result;
        }
    }
}
