namespace CalcStats
{
    public class Operations
    {
        private readonly List<int> _numbers;

        public Operations(string numbers)
        {
            _numbers = ConvertStringInListInt(numbers);
        }

        private static List<int> ConvertStringInListInt(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                throw new ArgumentNullException();

            var result = new List<int>();

            foreach (var number in numbers.Split())
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
            return _numbers.Sum()/_numbers.Count();
        }
    }
}
