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
using WPF_CalculatorDinner;

namespace WPF_CalculatorDinner
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DinnerParty dinnerParty = new DinnerParty();
        public MainWindow()
        {

            InitializeComponent();

            //dinnerParty = new DinnerParty() { NumberOfPeople = 5 };
            //dinnerParty.SetHealthyOption(false);
            //dinnerParty.CalculateCostOfDecorations(false);
            //DisplayDinnerPartyCost();
            //totalSum.Content = "Sum is here";
        }

        public void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.CalculateCost(CheckHealth(healthy.IsChecked));
            //totalSum.Content = Cost.ToString("c");
            string message = Cost.ToString();
            totalSum.Content = message;
        }






















        private bool CheckHealth(bool? isChecked)
        {
            if (healthy.IsChecked == true)
                return true;
            return false;
        }

        // заколхозили UpDownNumeric
        private void cmdDown_Click(object sender, RoutedEventArgs e)
        {
            txtNum.Text = (int.Parse(txtNum.Text) - 1).ToString();
        }

        private void cmdUp_Click(object sender, RoutedEventArgs e)
        {


            txtNum.Text = (int.Parse(txtNum.Text) + 1).ToString();
        }

        private void txtNum_TextChanged(object sender, TextChangedEventArgs e)
        {
            {
                dinnerParty.NumberOfPeople = int.Parse(txtNum.Text);
                DisplayDinnerPartyCost();
            }
        }
    }




}


