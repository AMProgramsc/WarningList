using Microsoft.Win32;
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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для CustomET.xaml
    /// </summary>
    
    public partial class CustomET : Window
    {
        
        public int ex;
        public int tx;
        public string bx;
        public CustomET()
        {
            InitializeComponent();
            BP.IsEnabled = false;
            GPA.IsEnabled = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.ShowDialog();
            try 
            {
                ImageSource image =  new ImageSourceConverter().ConvertFromString(dialog.FileName) as ImageSource;
                FP.Text = dialog.FileName;
                IP.Source = image;
            }
            catch(Exception exp)
            {

            }
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

            e.Cancel = true;
            this.Visibility = Visibility.Hidden;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (NameET.Text == "" || CP.SelectedIndex == -1)
            {
                MessageBox.Show("Name or type not specified", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                ex = 1;
                this.Visibility = Visibility.Hidden;
            }
        }

        private void CP_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tx = CP.SelectedIndex;
            if(tx > 9)
            {
                BP.IsEnabled = true;
                GPA.IsEnabled = true;
            }
            else
            {
                BP.IsEnabled = false;
                GPA.IsEnabled = false;
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem ComboItem = (ComboBoxItem)BP.SelectedItem;
            bx = ComboItem.Content.ToString();


        }

        private void GPA_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
