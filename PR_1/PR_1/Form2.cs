using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://e.mail.ru/compose/",
                UseShellExecute = true
            });
            //System.Diagnostics.Process.Start - Этот метод используется для запуска нового процесса. В данном случае, он будет запускать процесс, связанный с указанным URL.
            //new ProcessStartInfo - Этот конструктор создает новый экземпляр класса ProcessStartInfo, который содержит информацию о процессе, который нужно запустить.
            //FileName = "https://e.mail.ru/compose/" - Здесь указывается имя файла или URL, который нужно открыть. В данном случае, это URL для письма на почтовом сервисе mail.ru.
            //UseShellExecute = true - Этот параметр указывает, что процесс должен запускаться через оболочку операционной системы. В данном случае, это означает, что URL будет открыт в браузере по умолчанию.


        }
    }
}
