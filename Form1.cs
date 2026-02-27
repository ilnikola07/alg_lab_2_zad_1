using NumberLogic;
namespace WinFormsApp_alg_lab_2_zad_2
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверяем, что textBox1 не пуст
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("Пожалуйста, введите число в поле ввода.",
                                   "Ошибка ввода",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                    return;
                }

                // Пытаемся преобразовать текст в число
                int N;
                if (!int.TryParse(textBox1.Text, out N))
                {
                    MessageBox.Show("Введённое значение не является корректным целым числом.",
                                   "Ошибка формата",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                    return;
                }
                if (N > 100)
                {
                    MessageBox.Show("Введённое значение больше 100.",
                                   "Переполнение",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                    return;
                }
                    
                // Проверяем, что число положительное
                if (N <= 0)
                {
                    MessageBox.Show("Пожалуйста, введите положительное целое число.",
                                   "Некорректное значение",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Warning);
                    return;
                }

                listBox1.Items.Clear(); // Очищаем список

                if (!int.TryParse(textBox1.Text, out int n) || n <= 0) return;

                listBox1.Items.Clear();

                // Создаем экземпляр класса из библиотеки
                var processor = new NumberProcessor();

                // Получаем данные
                var oddDigitNumbers = processor.GetNumbersWithAllOddDigits(n);

                // Выводим в UI
                foreach (var num in oddDigitNumbers)
                {
                    listBox1.Items.Add(num.ToString());
                }
            }
            catch (Exception ex)
            {
                // Общий обработчик неожиданных исключений
                MessageBox.Show($"Произошла непредвиденная ошибка: {ex.Message}",
                               "Критическая ошибка",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
           

        }
        //bool IsAllDigitsOdd(int number)
        //{
        //    while (number > 0)
        //    {
        //        int digit = number % 10; // Получаем последнюю цифру
        //        if (digit % 2 == 0) // Если цифра чётная
        //            return false;
        //        number /= 10; // Убираем последнюю цифру
        //    }
        //    return true;
        //}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
