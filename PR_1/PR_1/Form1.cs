namespace PR_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод для вычисления времени путешествия на основе введенных пользователем данных: средняя скорость и расстояние.
        /// </summary>
        /// Double.TryParse(tb_Averagespeed.Text, out double averagespeed) - Этот код пытается преобразовать текст, который содержится в элементе управления TextBox с именем tb_Averagespeed в число с плавающей точкой double. Функция TryParse возвращает логическое значение (true или false) в зависимости от того, успешно ли было преобразование. Если преобразование прошло успешно, значение будет сохранено в переменную averagespeed.
        public async void CalculateTravelTime()
        {
            {
                ErrorProvider errorProvider = new ErrorProvider();

                // Создание экземпляра Class1 для использования метода CalculateTime
                Class1 traveltime = new Class1();

                // Проверка на пустоту введенных данных средней скорости и расстояния
                if (!String.IsNullOrEmpty(tb_Averagespeed.Text) && !String.IsNullOrEmpty(tb_Distance.Text))
                {
                    // Проверка корректности введенных данных для средней скорости
                    if (Double.TryParse(tb_Averagespeed.Text, out double averagespeed) && averagespeed != 0 && averagespeed > 0)
                    {
                        // Проверка корректности введенных данных для расстояния
                        if (Double.TryParse(tb_Distance.Text, out double distance) && distance != 0 && distance > 0)
                        {
                            // Вычисление времени и вывод результата
                            double time = traveltime.CalculateTime(averagespeed, distance);
                            tb_Time.Text = $"{time} час(ов)";
                        }
                        else
                        {
                            // Очистка поля времени, установка сообщения об ошибке для расстояния и его очистка через 1.5 секунды
                            tb_Time.Clear();
                            errorProvider.SetError(tb_Distance, "Введите больше 0!");
                            await Task.Delay(2000);
                            errorProvider.SetError(tb_Distance, "");
                        }
                    }
                    else
                    {
                        // Очистка поля времени, установка сообщения об ошибке для средней скорости и его очистка через 1.5 секунды
                        tb_Time.Clear();
                        errorProvider.SetError(tb_Averagespeed, "Введите больше 0!");
                        await Task.Delay(2000);
                        errorProvider.SetError(tb_Averagespeed, "");
                    }
                }
                else
                {
                    // Очистка поля времени, установка сообщения об ошибке для средней скорости и расстояния, и их очистка через 2 секунды
                    tb_Time.Clear();
                    errorProvider.SetError(tb_Averagespeed, "Строка не может быть пустой!");
                    errorProvider.SetError(tb_Distance, "Строка не может быть пустой!");
                    await Task.Delay(2000);
                    errorProvider.SetError(tb_Distance, "");
                    errorProvider.SetError(tb_Averagespeed, "");
                }
            }
        }
        // Обработчики событий для ToolStripMenuItem
        private void программаРасчётыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalculateTravelTime();
        }
        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tb_Averagespeed.Clear();
            tb_Distance.Clear();
            tb_Time.Clear();
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newF = new Form2();
            newF.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            CalculateTravelTime();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}