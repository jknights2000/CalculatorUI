using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace CalculatorUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string num ="";
        string output = "";
        List<int> thenumbers = new List<int>();
        public MainWindow()
        {
            InitializeComponent();
            NumberOutput.Content = num;
        }

        private void Calculate(object sender,RoutedEventArgs e)
        {
            if (num != "")
            {
                thenumbers.Add(int.Parse(num));
            }
            string op = ((ComboBoxItem)Operator.SelectedItem).Content.ToString();

        
                string output = calc(thenumbers, op);
                Output.Content = output;
                num = "";
                thenumbers.Clear();
                NumberOutput.Content = num;
   
        }
        public void Numberseleceted(object sender, RoutedEventArgs e)
        {
            Output.Content = "";
            var button = sender as Button;
            var i = button.Content.ToString();
           if( num == "" && i == "0")
                {
                return;
            }else
            {
                num += i;
                NumberOutput.Content = output + num;
            }
        }
        public void Enter(object sender, RoutedEventArgs e)
        {
            if(num == "0")
            {
                num = "";
            }
            else
            {
                thenumbers.Add(int.Parse(num));
                string op = ((ComboBoxItem)Operator.SelectedItem).Content.ToString();
                NumberOutput.Content = output + op;
                num = "";
            }
        }
            public string calc(List<int>touse,string ainput)
        {
            int output2 = 0;
            string output3 = "";


            switch (ainput)
            {
                case "*":
                    
                    output2 = touse.Aggregate((result, item) => result * item);
                    break;
                case "-":
                    
                    output2 = touse.Aggregate((result, item) => result - item);
                    break;
                case "+":
                    
                    output2 = touse.Sum();
                    break;
                case "/":
                    
                    output2 = touse.Aggregate((result, item) => result / item);
                    break;
            }
       
            foreach (int i in touse)
            {
                if (output3 == "")
                {
                    output3 += i;
                }
                else
                {
                    output3 += " " + ainput + " " + i;
                }
            }
            string text = output3 + " = " + output2;
            num = "";
            return text;
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime date = (DateTime)Cal.SelectedDate;
            if(DaysToAdd.Text != "")
            {
                DateTime newdate  = date.AddDays(int.Parse(DaysToAdd.Text));
                Date.Content = date.Date.ToString("dd/MM/yyyy") + " with " + DaysToAdd.Text +" days added = " + newdate.Date.ToString("dd/MM/yyyy");
            }
            else
            {
                Date.Content = date.Date.ToString("dd/MM/yyyy");
            }
            
        }

        private void DaysToAdd_TextChanged(object sender, TextChangedEventArgs e)
        {
            DateTime date = (DateTime)Cal.SelectedDate;
            if (Cal.SelectedDate != null )
            {
                if (DaysToAdd.Text != "")
                {
                    
                    DateTime newdate = date.AddDays(int.Parse(DaysToAdd.Text));
                    Date.Content = date.Date.ToString("dd/MM/yyyy") + " with " + DaysToAdd.Text + " days added = " + Environment.NewLine + newdate.Date.ToString("dd/MM/yyyy");
                }
                else
                {
                    Date.Content = date.Date.ToString("dd/MM/yyyy");
                }
            }
        }

        private void Operator_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            num = "";
            thenumbers.Clear();
            NumberOutput.Content = "";
            Output.Content = "";
        }
    }
}
