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

namespace CalculatorUI
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
        private void Calculate(object sender,RoutedEventArgs e)
        {
            List<int> thenumbers = new List<int>();
            string op = ((ComboBoxItem)Operator.SelectedItem).Content.ToString();
           
            string [] input = Number.Text.Split(",");

            foreach(string number in input)
            {
                if (int.TryParse(number, out int numberactual))
                {
                    thenumbers.Add(numberactual);
                }
            }
            if(input.Length == thenumbers.Count)
            {
                string output = calc(thenumbers, op);
                Output.Content = output;
            }
            else
            {
                Error.Content = "not all inputs were numbers seperated by a ,";
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

            return text;
        }
    }
}
