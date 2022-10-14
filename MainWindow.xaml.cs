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

namespace SimpleCalculater
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        /// <summary>
        ///  The variable to hold the number of the edit box.
        /// </summary>
        private string FirstNumber;

        /// <summary>
        ///  The variable to hold the number after an operator is used.
        /// </summary>
        private string StoredNumber;

        /// <summary>
        ///  A variable to hold a number as a reference for the operator.
        /// </summary>
        private string Opperation;

        public MainWindow()
        {
            this.InitializeComponent();
        }

        /// <summary>
        ///  The button for number one.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberOneButton_Click(object sender, RoutedEventArgs e)
        {
            FirstNumber = FirstNumber + 1;
            ValueTextbox.Text = FirstNumber.ToString();
        }

        /// <summary>
        ///  The button for number two.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberTwoButton_Click(object sender, RoutedEventArgs e)
        {
            FirstNumber = FirstNumber + 2;
            ValueTextbox.Text = FirstNumber.ToString();
        }

        /// <summary>
        ///  The button for the number three. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberThreeButton_Click(object sender, RoutedEventArgs e)
        {
            FirstNumber = FirstNumber + 3;
            ValueTextbox.Text = FirstNumber.ToString();
        }

        /// <summary>
        ///  The button to muliply the numbers.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MultiplyButton_Click(object sender, RoutedEventArgs e)
        {
            StoredNumber = this.ValueTextbox.Text;

            Opperation = "1";
            this.ValueTextbox.Text = "";
        }

        /// <summary>
        ///  The text box that holds the numbers to do maths on.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValueTextbox_LostFocus(object sender, RoutedEventArgs e)
        {
            FirstNumber = this.ValueTextbox.Text;
        }

        /// <summary>
        ///  The button that calculates the equation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EqualButton_Click(object sender, RoutedEventArgs e)
        {
            decimal a = Convert.ToDecimal(StoredNumber);
            decimal b = Convert.ToDecimal(this.ValueTextbox.Text);
            decimal c;


            switch (Opperation)
            {
                case "1":
                                c = a * b;
                    StoredNumber = c.ToString();
                    this.ValueTextbox.Text = "";            
                    this.ValueTextbox.Text = c.ToString();
                    break;
                case "2":
                    c = a / b;
                    StoredNumber = c.ToString();
                    this.ValueTextbox.Text = c.ToString();
                    break;

                case "3":
                    c = a + b;
                    StoredNumber = c.ToString();
                    this.ValueTextbox.Text = "";
                    this.ValueTextbox.Text = c.ToString();
                    break;

                case "4":
                    c = a - b;
                    StoredNumber = c.ToString();
                    this.ValueTextbox.Text = "";
                    this.ValueTextbox.Text = c.ToString();
                    break;
            }

        }

        /// <summary>
        ///  The button for the number four.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberFourButton_Click(object sender, RoutedEventArgs e)
        {
            FirstNumber = FirstNumber + 4;
            ValueTextbox.Text = FirstNumber.ToString();
        }

        /// <summary>
        ///  The button for the number five.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberFiveButton_Click(object sender, RoutedEventArgs e)
        {
            FirstNumber = FirstNumber + 5;
            ValueTextbox.Text = FirstNumber.ToString();
        }

        /// <summary>
        ///  The button for the number six.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberSixButton_Click(object sender, RoutedEventArgs e)
        {
            FirstNumber = FirstNumber + 6;
            ValueTextbox.Text = FirstNumber.ToString();
        }

        /// <summary>
        ///  The button for the number seven.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberSevenButton_Click(object sender, RoutedEventArgs e)
        {
            FirstNumber = FirstNumber + 7;
            ValueTextbox.Text = FirstNumber.ToString();
        }

        /// <summary>
        ///  The button for the number eight.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberEightButton_Click(object sender, RoutedEventArgs e)
        {
            FirstNumber = FirstNumber + 8;
            ValueTextbox.Text = FirstNumber.ToString();
        }

        /// <summary>
        ///  The button for the number nine.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberNineButton_Click(object sender, RoutedEventArgs e)
        {
            FirstNumber = FirstNumber + 9;
            ValueTextbox.Text = FirstNumber.ToString();
        }

        private void NumberZeroButton_Click(object sender, RoutedEventArgs e)
        {
            FirstNumber = FirstNumber + 0;
            ValueTextbox.Text = FirstNumber.ToString();
        }

        /// <summary>
        ///  The button that divides the numbers.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DivideButton_Click(object sender, RoutedEventArgs e)
        {
            StoredNumber = this.ValueTextbox.Text;

            Opperation = "2";
            this.ValueTextbox.Text = "";
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            StoredNumber = this.ValueTextbox.Text;

            Opperation = "3";
            this.ValueTextbox.Text = "";

        }

        private void SubtractButton_Click(object sender, RoutedEventArgs e)
        {
            StoredNumber = this.ValueTextbox.Text;

            Opperation = "4";
            this.ValueTextbox.Text = "";

        }

        private void DecimalButton_Click(object sender, RoutedEventArgs e)
        {
            FirstNumber = FirstNumber + ".";
            ValueTextbox.Text = FirstNumber.ToString();
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            this.ValueTextbox.Text = "";
            this.FirstNumber = "";
            this.StoredNumber = "";
        }
    }
}
