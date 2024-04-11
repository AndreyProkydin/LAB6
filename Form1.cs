using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace овощ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Функція, що обчислює відстань між двома точками
        static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            double deltaX = x1 - x2;
            double deltaY = y1 - y2;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            {
                // Отримання координат точок з TextBox та їх розділення
                string[] coords1 = textBox1.Text.Split(' ');
                string[] coords2 = textBox2.Text.Split(' ');

                // Перевірка наявності координат
                if (coords1.Length != 2 || coords2.Length != 2)
                {
                    MessageBox.Show("Будь ласка, введіть координати обох точок у відповідному форматі.");
                    return;
                }

                // Парсинг координат кожної точки
                if (!double.TryParse(coords1[0], out double x1) || !double.TryParse(coords1[1], out double y1) ||
                    !double.TryParse(coords2[0], out double x2) || !double.TryParse(coords2[1], out double y2))
                {
                    MessageBox.Show("Будь ласка, введіть коректні числові значення для координат.");
                    return;
                }

                // Обчислення відстані між точками
                double distance = CalculateDistance(x1, y1, x2, y2);

                // Виведення результату у Label
                label3.Text = $"Відстань між точками P1({x1}, {y1}) і P2({x2}, {y2}) дорівнює {distance}";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
    

