using System;
using System.Windows.Forms;

namespace UP_4._2_Graphic_interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Function(int n)
        {
            if (n == 0)
                return;
            else
                Function(n - 1);

            ResultBox.Text += (n + " ");
        }

        private void GetResultButton_Click(object sender, EventArgs e)
        {
            ResultBox.Text = "";
            if (!int.TryParse(NValueBox.Text, out int N) || N < 1000)
            {
                MessageBox.Show("Недопустимые данные в поле N!\n" +
                    "N должно быть целым числом больше или равное 1000!");
                return;
            }
            Function(N);
        }
    }
}
