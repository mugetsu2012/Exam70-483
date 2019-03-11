using System;
using System.Collections.Generic;
using System.Globalization;
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
using System.Windows.Threading;

namespace Ejemplo17
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CultureInfo.CurrentCulture = new CultureInfo("en-US");
        }

        private Task<double> ComputeAverages(long noOfValues)
        {
            return Task<double>.Run(() => { return ComputeAverage(noOfValues); });
        }

        private double ComputeAverage(long noOfValues)
        {
            double total = 0;

            Random rnd = new Random();

            for (long values = 0; values < noOfValues; values++)
            {
                total = total + rnd.NextDouble();
            }

            return total /noOfValues;
        }

        private  async void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            long noOfValues = long.Parse(NumberOfValuesTextBox.Text);

            ResultTextBlock.Text = "Calculating";

            double result = await ComputeAverages(noOfValues);

            ResultTextBlock.Text = "Result: " + result;

        }

        //private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        //{
        //    long noOfValues = long.Parse(NumberOfValuesTextBox.Text);


        //    Task.Run(() =>
        //    {
        //        double result = ComputeAverage(noOfValues);

        //        ResultTextBlock.Dispatcher.InvokeAsync(() => { ResultTextBlock.Text = "Result: " + result; },
        //            DispatcherPriority.Normal);
        //    });
        //}
    }
}
