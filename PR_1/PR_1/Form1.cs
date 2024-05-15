namespace PR_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ����� ��� ���������� ������� ����������� �� ������ ��������� ������������� ������: ������� �������� � ����������.
        /// </summary>
        /// Double.TryParse(tb_Averagespeed.Text, out double averagespeed) - ���� ��� �������� ������������� �����, ������� ���������� � �������� ���������� TextBox � ������ tb_Averagespeed � ����� � ��������� ������ double. ������� TryParse ���������� ���������� �������� (true ��� false) � ����������� �� ����, ������� �� ���� ��������������. ���� �������������� ������ �������, �������� ����� ��������� � ���������� averagespeed.
        public async void CalculateTravelTime()
        {
            {
                ErrorProvider errorProvider = new ErrorProvider();

                // �������� ���������� Class1 ��� ������������� ������ CalculateTime
                Class1 traveltime = new Class1();

                // �������� �� ������� ��������� ������ ������� �������� � ����������
                if (!String.IsNullOrEmpty(tb_Averagespeed.Text) && !String.IsNullOrEmpty(tb_Distance.Text))
                {
                    // �������� ������������ ��������� ������ ��� ������� ��������
                    if (Double.TryParse(tb_Averagespeed.Text, out double averagespeed) && averagespeed != 0 && averagespeed > 0)
                    {
                        // �������� ������������ ��������� ������ ��� ����������
                        if (Double.TryParse(tb_Distance.Text, out double distance) && distance != 0 && distance > 0)
                        {
                            // ���������� ������� � ����� ����������
                            double time = traveltime.CalculateTime(averagespeed, distance);
                            tb_Time.Text = $"{time} ���(��)";
                        }
                        else
                        {
                            // ������� ���� �������, ��������� ��������� �� ������ ��� ���������� � ��� ������� ����� 1.5 �������
                            tb_Time.Clear();
                            errorProvider.SetError(tb_Distance, "������� ������ 0!");
                            await Task.Delay(2000);
                            errorProvider.SetError(tb_Distance, "");
                        }
                    }
                    else
                    {
                        // ������� ���� �������, ��������� ��������� �� ������ ��� ������� �������� � ��� ������� ����� 1.5 �������
                        tb_Time.Clear();
                        errorProvider.SetError(tb_Averagespeed, "������� ������ 0!");
                        await Task.Delay(2000);
                        errorProvider.SetError(tb_Averagespeed, "");
                    }
                }
                else
                {
                    // ������� ���� �������, ��������� ��������� �� ������ ��� ������� �������� � ����������, � �� ������� ����� 2 �������
                    tb_Time.Clear();
                    errorProvider.SetError(tb_Averagespeed, "������ �� ����� ���� ������!");
                    errorProvider.SetError(tb_Distance, "������ �� ����� ���� ������!");
                    await Task.Delay(2000);
                    errorProvider.SetError(tb_Distance, "");
                    errorProvider.SetError(tb_Averagespeed, "");
                }
            }
        }
        // ����������� ������� ��� ToolStripMenuItem
        private void ����������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalculateTravelTime();
        }
        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tb_Averagespeed.Clear();
            tb_Distance.Clear();
            tb_Time.Clear();
        }
        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
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