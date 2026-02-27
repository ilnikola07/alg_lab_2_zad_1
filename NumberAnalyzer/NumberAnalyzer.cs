namespace NumberAnalyzer
{
    public class DigitParser
    {
        public class AnalysisResult
        {
            public int MaxDigit { get; set; }
            public int MinDigit { get; set; }
            public int[] DigitCounts { get; set; }
        }

        public AnalysisResult Analyze(string input)
        {
            input = input?.Trim();
            if (string.IsNullOrEmpty(input))
                throw new ArgumentException("Строка не может быть пустой.");

            string digitsOnly = (input[0] == '+' || input[0] == '-') ? input.Substring(1) : input;

            if (string.IsNullOrEmpty(digitsOnly))
                throw new ArgumentException("После знака должны быть цифры.");

            const int MAX_DIGITS = 100;
            if (digitsOnly.Length > MAX_DIGITS)
            {
                throw new ArgumentException($"Ввод слишком длинный. Максимум: {MAX_DIGITS}");
            }

            foreach (char ch in digitsOnly)
                if (!char.IsDigit(ch)) throw new FormatException($"Символ '{ch}' не цифра.");

            // Логика расчета
            var result = new AnalysisResult { MaxDigit = -1, MinDigit = 10, DigitCounts = new int[10] };
            foreach (char ch in digitsOnly)
            {
                int digit = ch - '0';
                if (digit > result.MaxDigit) result.MaxDigit = digit;
                if (digit < result.MinDigit) result.MinDigit = digit;
                result.DigitCounts[digit]++;
            }
            return result;
        }
    }
}
