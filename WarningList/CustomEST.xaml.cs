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
            if(CP.SelectedIndex == 10 && (BP.SelectedIndex == -1 || GPA.SelectedIndex == -1))
            {
                MessageBox.Show("GPA or Buttons not changed", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
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
            BC.Items.Clear();
            ComboBoxItem ComboItem = (ComboBoxItem)BP.SelectedItem;
            bx = ComboItem.Content.ToString();
            int BContent = Int32.Parse(ComboItem.Content.ToString());
            for (int CountB = 1; CountB <= BContent; CountB++)
            {
               
                BC.Items.Add(new ListBoxItem { Content = CountB.ToString() , HorizontalContentAlignment = HorizontalAlignment.Center , Background = Brushes.Gray});
            }


        }

        private void GPA_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BC_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ColorP.Visibility = Visibility.Visible;
        }

        private void ColorP_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            string c1 = ColorP.SelectedColor.Value.ToString();
            SolidColorBrush ck = (SolidColorBrush)new BrushConverter().ConvertFromString(c1);

            ListBoxItem lbi = BC.Items[BC.SelectedIndex] as ListBoxItem;
            lbi.Background = ck;
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ColorP.Visibility = Visibility.Hidden;
        }


    }
}
