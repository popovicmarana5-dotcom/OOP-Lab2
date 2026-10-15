using Avalonia.Controls;
using Avalonia.Interactivity;
using System;

namespace QuadraticAvalonia
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            LblMessage.Text = "";

            if (!double.TryParse(TxtA.Text, out double a) || 
                !double.TryParse(TxtB.Text, out double b) || 
                !double.TryParse(TxtC.Text, out double c))
            {
                LblMessage.Text = "Помилка: введіть коректні числа!";
                return;
            }

            if (a == 0)
            {
                LblMessage.Text = "Помилка: коефіцієнт 'a' не може дорівнювати 0!";
                return;
            }

            double d = b * b - 4 * a * c;
            LblDiscriminant.Text = $"Дискримінант: {Math.Round(d, 3)}";

            if (d > 0)
            {
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);

                LblX1.IsVisible = true;
                TxtX1.IsVisible = true;
                TxtX1.Text = Math.Round(x1, 3).ToString();

                LblX2.IsVisible = true;
                TxtX2.IsVisible = true;
                TxtX2.Text = Math.Round(x2, 3).ToString();
            }
            else if (d == 0)
            {
                double x = -b / (2 * a);

                LblX1.IsVisible = true;
                TxtX1.IsVisible = true;
                TxtX1.Text = Math.Round(x, 3).ToString();

                LblX2.IsVisible = false;
                TxtX2.IsVisible = false;
            }
            else
            {
                LblX1.IsVisible = false;
                TxtX1.IsVisible = false;
                LblX2.IsVisible = false;
                TxtX2.IsVisible = false;

                LblMessage.Text = "Дійсних коренів немає (дискримінант < 0).";
            }
        }
    }
}
