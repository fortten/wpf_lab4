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

namespace wpf_lab4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        #region Валюты
        private void ButtonUSD_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rateUSD.Text);
            double sumDollar = Convert.ToDouble(sumUSD.Text);
            double resDollar = rateDollar * sumDollar;
            resUSD.Text = resDollar.ToString();
        }

        private void ButtonEUR_Click(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rateEUR.Text);
            double sumEuro = Convert.ToDouble(sumEUR.Text);
            double resEuro = rateEuro * sumEuro;
            resEUR.Text = resEuro.ToString();
        }

        private void ButtonUAH_Click(object sender, RoutedEventArgs e)
        {
            double rateHriv = Convert.ToDouble(rateUAH.Text);
            double sumHriv = Convert.ToDouble(sumUAH.Text);
            double resHriv = rateHriv * sumHriv;
            resUAH.Text = resHriv.ToString();
        }

        private void ButtonGBP_Click(object sender, RoutedEventArgs e)
        {
            double ratePound = Convert.ToDouble(rateGBP.Text);
            double sumPound = Convert.ToDouble(sumGBP.Text);
            double resPound = ratePound * sumPound;
            resGBP.Text = resPound.ToString();
        }
        #endregion

        #region Расстояния
        private void ButtonInch_Click(object sender, RoutedEventArgs e)
        {
            double rateIn = Convert.ToDouble(rateInch.Text);            
            double resIn = rateIn * 0.0254;
            resInch.Text = resIn.ToString();
        }

        private void ButtonFt_Click(object sender, RoutedEventArgs e)
        {
            double rateFoot = Convert.ToDouble(rateFt.Text);
            double resFoot = rateFoot * 0.3048;
            resFt.Text = resFoot.ToString();
        }

        private void ButtonMile_Click(object sender, RoutedEventArgs e)
        {
            double rateMl = Convert.ToDouble(rateMile.Text);
            double resMl = rateMl * 1609.344;
            resMile.Text = resMl.ToString();
        }

        private void ButtonVerst_Click(object sender, RoutedEventArgs e)
        {
            double rateVr = Convert.ToDouble(rateVerst.Text);
            double resVr = rateVr * 1066.8;
            resVerst.Text = resVr.ToString();
        }
        #endregion
    }
}
