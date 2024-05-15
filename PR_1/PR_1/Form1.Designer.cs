namespace PR_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            Рассчитать = new Label();
            toolTip1 = new ToolTip(components);
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            вычислитьToolStripMenuItem = new ToolStripMenuItem();
            программаРасчётыToolStripMenuItem = new ToolStripMenuItem();
            очиститьToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            groupBox2 = new GroupBox();
            tb_Distance = new TextBox();
            tb_Averagespeed = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            tb_Time = new TextBox();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Info;
            groupBox1.Controls.Add(Рассчитать);
            groupBox1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox1.Location = new Point(0, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(930, 63);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = resources.GetString("groupBox1.Text");
            // 
            // Рассчитать
            // 
            Рассчитать.AutoSize = true;
            Рассчитать.BackColor = SystemColors.Info;
            Рассчитать.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Рассчитать.Location = new Point(35, 29);
            Рассчитать.Name = "Рассчитать";
            Рассчитать.Size = new Size(0, 15);
            Рассчитать.TabIndex = 3;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, справкаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(934, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { вычислитьToolStripMenuItem, очиститьToolStripMenuItem, выходToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // вычислитьToolStripMenuItem
            // 
            вычислитьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { программаРасчётыToolStripMenuItem });
            вычислитьToolStripMenuItem.Name = "вычислитьToolStripMenuItem";
            вычислитьToolStripMenuItem.Size = new Size(135, 22);
            вычислитьToolStripMenuItem.Text = "Вычислить";
            // 
            // программаРасчётыToolStripMenuItem
            // 
            программаРасчётыToolStripMenuItem.Name = "программаРасчётыToolStripMenuItem";
            программаРасчётыToolStripMenuItem.Size = new Size(198, 22);
            программаРасчётыToolStripMenuItem.Text = "Программа \"Расчёты\"";
            программаРасчётыToolStripMenuItem.Click += программаРасчётыToolStripMenuItem_Click;
            // 
            // очиститьToolStripMenuItem
            // 
            очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            очиститьToolStripMenuItem.Size = new Size(135, 22);
            очиститьToolStripMenuItem.Text = "Очистить";
            очиститьToolStripMenuItem.Click += очиститьToolStripMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(135, 22);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { оПрограммеToolStripMenuItem });
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(65, 20);
            справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(149, 22);
            оПрограммеToolStripMenuItem.Text = "О программе";
            оПрограммеToolStripMenuItem.Click += оПрограммеToolStripMenuItem_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Info;
            groupBox2.Controls.Add(tb_Distance);
            groupBox2.Controls.Add(tb_Averagespeed);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox2.Location = new Point(0, 143);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(342, 99);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Исходные данные:";
            // 
            // tb_Distance
            // 
            tb_Distance.Location = new Point(217, 67);
            tb_Distance.Name = "tb_Distance";
            tb_Distance.Size = new Size(100, 22);
            tb_Distance.TabIndex = 7;
            // 
            // tb_Averagespeed
            // 
            tb_Averagespeed.Location = new Point(208, 34);
            tb_Averagespeed.Name = "tb_Averagespeed";
            tb_Averagespeed.Size = new Size(100, 22);
            tb_Averagespeed.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(6, 70);
            label2.Name = "label2";
            label2.Size = new Size(187, 14);
            label2.TabIndex = 5;
            label2.Text = "Введите расстояние ( > 0) :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(6, 37);
            label1.Name = "label1";
            label1.Size = new Size(170, 14);
            label1.TabIndex = 4;
            label1.Text = "Введите скорость ( > 0) :";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.Info;
            groupBox3.Controls.Add(tb_Time);
            groupBox3.Controls.Add(label4);
            groupBox3.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox3.Location = new Point(342, 143);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(588, 99);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Результат:";
            // 
            // tb_Time
            // 
            tb_Time.Location = new Point(295, 48);
            tb_Time.Name = "tb_Time";
            tb_Time.ReadOnly = true;
            tb_Time.Size = new Size(325, 22);
            tb_Time.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(6, 52);
            label4.Name = "label4";
            label4.Size = new Size(283, 13);
            label4.TabIndex = 4;
            label4.Text = "Время за которое проедет водный транспорт :";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(643, 363);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Выход";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.Location = new Point(191, 363);
            button2.Name = "button2";
            button2.Size = new Size(88, 23);
            button2.TabIndex = 6;
            button2.Text = "Вычислить";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(934, 409);
            Controls.Add(groupBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Мое приложение";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ToolTip toolTip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem вычислитьToolStripMenuItem;
        private ToolStripMenuItem программаРасчётыToolStripMenuItem;
        private ToolStripMenuItem очиститьToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private Label Рассчитать;
        private GroupBox groupBox2;
        private Label label1;
        private Label label2;
        private TextBox tb_Distance;
        private TextBox tb_Averagespeed;
        private GroupBox groupBox3;
        private TextBox tb_Time;
        private Label label4;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private Button button1;
        private Button button2;
    }
}
