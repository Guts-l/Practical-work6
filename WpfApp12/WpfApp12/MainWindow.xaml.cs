using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp12
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
        private void addingnumber_Click(object sender, RoutedEventArgs e)
        {
            Triad firstTriad = new Triad(int.Parse(triadonea.Text), int.Parse(triadtwoa.Text), int.Parse(triadthreea.Text));

            int a = Convert.ToInt32(triadonea.Text), b = Convert.ToInt32(triadtwoa.Text), c = Convert.ToInt32(triadthreea.Text);
            Triad triad1 = new Triad(a, b, c);
            MessageBox.Show((triad1.First + triad1.Second + triad1.Third).ToString()); ; ;
            //Triad resultTriad = firstTriad + int.Parse(inputnumber.Text);

            //MessageBox.Show($"{resultTriad.First} {resultTriad.Second} {resultTriad.Third}", $"Результат сложения триады A с числом {inputnumber.Text}", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void SumTriads_Click(object sender, RoutedEventArgs e)
        {
            Triad firstTriad = new Triad(int.Parse(triadonea.Text), int.Parse(triadtwoa.Text), int.Parse(triadthreea.Text));

            Triad secondTriad = new Triad(int.Parse(triadoneb.Text), int.Parse(triadtwob.Text), int.Parse(triadthreeb.Text));

            Triad resultTriad = firstTriad + secondTriad;

            MessageBox.Show($"Результат сложения триады А с триадой В и С - {resultTriad.First} {resultTriad.Second} {resultTriad.Third}", "Сложение триад", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void GetInformation_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выполнил Теселько М.Ю ИСП-34.", "О программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void inputnumber_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
