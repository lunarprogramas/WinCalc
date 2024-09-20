using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info

namespace WinCalc
{ 
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        string selectedValue1 = "";
        string selectedValue2 = "";
        string mathMode = "N/A";
        bool requireSecondValues = false;
        bool fucked = false;

        public MainWindow()
        {
            this.InitializeComponent();
        }

        // function for each single math button

        private void Add_One(object sender, RoutedEventArgs e)
        {
            if (fucked)
            {
                return;
            }
            else
            {
                string numberAssigned = "1";
                if (!requireSecondValues)
                {
                    selectedValue1 += numberAssigned;
                    calculatorResult.Text = selectedValue1;
                }
                else
                {
                    selectedValue2 += numberAssigned;
                    calculatorResult.Text = selectedValue2;
                }
            }
        }

        private void Add_Two(object sender, RoutedEventArgs e)
        {
            if (fucked)
            {
                return;
            } else
            {
                string numberAssigned = "2";
                if (!requireSecondValues)
                {
                    selectedValue1 += numberAssigned;
                    calculatorResult.Text = selectedValue1;
                } else
                {
                    selectedValue2 += numberAssigned;
                    calculatorResult.Text = selectedValue2;
                }
            }
        }

        private void Add_Three(object sender, RoutedEventArgs e)
        {
            if (fucked)
            {
                return;
            }
            else
            {
                string numberAssigned = "3";
                if (!requireSecondValues)
                {
                    selectedValue1 += numberAssigned;
                    calculatorResult.Text = selectedValue1;
                }
                else
                {
                    selectedValue2 += numberAssigned;
                    calculatorResult.Text = selectedValue2;
                }
            }
        }

        private void Add_Four(object sender, RoutedEventArgs e)
        {
            if (fucked)
            {
                return;
            }
            else
            {
                string numberAssigned = "4";
                if (!requireSecondValues)
                {
                    selectedValue1 += numberAssigned;
                    calculatorResult.Text = selectedValue1;
                }
                else
                {
                    selectedValue2 += numberAssigned;
                    calculatorResult.Text = selectedValue2;
                }
            }
        }

        private void Add_Five(object sender, RoutedEventArgs e)
        {
            if (fucked)
            {
                return;
            }
            else
            {
                string numberAssigned = "5";
                if (!requireSecondValues)
                {
                    selectedValue1 += numberAssigned;
                    calculatorResult.Text = selectedValue1;
                }
                else
                {
                    selectedValue2 += numberAssigned;
                    calculatorResult.Text = selectedValue2;
                }
            }
        }

        private void Add_Six(object sender, RoutedEventArgs e)
        {
            if (fucked)
            {
                return;
            }
            else
            {
                string numberAssigned = "6";
                if (!requireSecondValues)
                {
                    selectedValue1 += numberAssigned;
                    calculatorResult.Text = selectedValue1;
                }
                else
                {
                    selectedValue2 += numberAssigned;
                    calculatorResult.Text = selectedValue2;
                }
            }
        }

        private void Add_Seven(object sender, RoutedEventArgs e)
        {
            if (fucked)
            {
                return;
            }
            else
            {
                string numberAssigned = "7";
                if (!requireSecondValues)
                {
                    selectedValue1 += numberAssigned;
                    calculatorResult.Text = selectedValue1;
                }
                else
                {
                    selectedValue2 += numberAssigned;
                    calculatorResult.Text = selectedValue2;
                }
            }
        }

        private void Add_Eight(object sender, RoutedEventArgs e)
        {
            if (fucked)
            {
                return;
            }
            else
            {
                string numberAssigned = "8";
                if (!requireSecondValues)
                {
                    selectedValue1 += numberAssigned;
                    calculatorResult.Text = selectedValue1;
                }
                else
                {
                    selectedValue2 += numberAssigned;
                    calculatorResult.Text = selectedValue2;
                }
            }
        }

        private void Add_Nine(object sender, RoutedEventArgs e)
        {
            if (fucked)
            {
                return;
            }
            else
            {
                string numberAssigned = "9";
                if (!requireSecondValues)
                {
                    selectedValue1 += numberAssigned;
                    calculatorResult.Text = selectedValue1;
                }
                else
                {
                    selectedValue2 += numberAssigned;
                    calculatorResult.Text = selectedValue2;
                }
            }
        }

        private void Add_Zero(object sender, RoutedEventArgs e)
        {
            if (fucked)
            {
                return;
            }
            else
            {
                string numberAssigned = "0";
                if (!requireSecondValues)
                {
                    selectedValue1 += numberAssigned;
                    calculatorResult.Text = selectedValue1;
                }
                else
                {
                    selectedValue2 += numberAssigned;
                    calculatorResult.Text = selectedValue2;
                }
            }
        }

        private void ClearContents(object sender, RoutedEventArgs e)
        {
            if (fucked)
            {
                return;
            } else
            {
                selectedValue1 = "";
                selectedValue2 = "";
                calculatorResult.Text = "No calculation inputed.";
            }
        }

        private void operation_Add(object sender, RoutedEventArgs e)
        {
            if (fucked && !requireSecondValues)
            {
                return;
            } else
            {
                this.mathOperation("Add");
            }
        }

        private void operation_Sum(object sender, RoutedEventArgs e)
        {
            if (fucked && !requireSecondValues)
            {
                return;
            }
            else
            {
                this.mathOperation("ReturnValue");
            }
        }
        // Figure out why the sidebar is fucking huge. L
        public void mathOperation(string input) 
        {
            if (input == "N/A")
            {
                return;
            }
            else if (input == "Add")
            {
                requireSecondValues = true;
                mathMode = "Add";
                Add.Background = new SolidColorBrush(Colors.LightGray);
            }
            else if (input == "ReturnValue")
            {
                if (mathMode == "Add")
                {
                    int value = int.Parse(selectedValue1) + int.Parse(selectedValue2);
                    calculatorResult.Text = value.ToString();
                }
            }
        }
    }
}
