using System;
using System.Windows.Forms;

namespace UP_4_Graphic_interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static int NOD(int a, int b)
        {
            if (a > b) return NOD(a - b, b);

            else if (a < b) return NOD(a, b - a);
            else return a;
        }
         
        private void GetNodButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(AValueBox.Text, out int a) || a <= 0)
            {
                MessageBox.Show("Поле a содержит недопустимые данные!\n" +
                                "Число а должно быть целым и положительным!", "Ошибка!");
                return;
            }

            if (!int.TryParse(BValueBox.Text, out int b) || b <= 0)
            {
                MessageBox.Show("Поле b содержит недопустимые данные!\n" +
                                "Число b должно быть целым и положительным!", "Ошибка!");
                return;
            }

            MessageBox.Show($"НОД чисел {a} и {b}: {NOD(a, b)}");
        }
    }
}
