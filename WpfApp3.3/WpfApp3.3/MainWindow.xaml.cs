using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp3._3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        private void GenerateArray_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(ArraySizeInput.Text, out int a) && a > 0)
            {

                double[] n = new double[a];
                Random rand = new Random();
                double min = -110.34;
                double max = 110.35;

                InitialArrayText.Text = "";
                for (int i = 0; i < a; ++i)
                {
                    n[i] = Math.Round(rand.NextDouble() * (max - min) + min, 2);
                    InitialArrayText.Text += n[i] + "\t";
                }

                double sum = 0;
                NegativeEvenIndexElementsText.Text = "";
                for (int i = 0; i < a; i += 2)
                {
                    if (n[i] < 0)
                    {
                        sum += n[i];
                        NegativeEvenIndexElementsText.Text += n[i] + " ";
                    }
                }
                SumOfNegativeEvenElementsText.Text = $"Сума від'ємних елементів з парними індексами = {sum}";


                for (int i = 1; i < a - 1; i += 2)
                {
                    for (int j = i + 2; j < a; j += 2)
                    {
                        if (n[i] < n[j])
                        {
                            double t = n[i];
                            n[i] = n[j];
                            n[j] = t;
                        }
                    }
                }

                SortedArrayText.Text = "";
                foreach (double num in n)
                {
                    SortedArrayText.Text += num + " ";
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть коректне число більше нуля.");
            }
            Console.WriteLine();
        }
    }
}