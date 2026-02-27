using System.Collections.Generic;
namespace NumberLogic
{
    public class NumberProcessor
    {
        // Метод возвращает список чисел, чтобы UI сам решал, куда их выводить
        public List<int> GetNumbersWithAllOddDigits(int n)
        {
            List<int> result = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                if (IsAllDigitsOdd(i))
                {
                    result.Add(i);
                }
            }
            return result;
        }

        // Делаем метод приватным или публичным в зависимости от нужд
        public bool IsAllDigitsOdd(int number)
        {
            if (number <= 0) return false;
            while (number > 0)
            {
                int digit = number % 10;
                if (digit % 2 == 0) return false;
                number /= 10;
            }
            return true;
        }
    }
}
