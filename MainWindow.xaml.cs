//Program for testing calendar props for work with days

using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace CalendarTesting
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 



    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalendarDayButton_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            MessageBox.Show("Test");
        }
    }
}
