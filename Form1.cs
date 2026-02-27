using NumberAnalyzer;
namespace WinFormsApp_alg_lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var analyzer = new DigitParser();
                var result = analyzer.Analyze(textBox1.Text);

                string report = $"Макс: {result.MaxDigit}\nМин: {result.MinDigit}\n\n";
                for (int i = 0; i <= 9; i++)
                    report += $"Цифра {i}: {result.DigitCounts[i]}\n";

                labelresult.Text = report;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelresult_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }
    }
}
