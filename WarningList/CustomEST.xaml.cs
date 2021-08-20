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
        bool Gpa = false;
        bool content = false;
        public CustomET()
        {
            InitializeComponent();
            BP.IsEnabled = false;
            Btype.IsEnabled = false;
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
            if(CP.SelectedIndex == 10 && (BP.SelectedIndex == -1 || Btype.SelectedIndex == -1))
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
                Btype.IsEnabled = true;
            }
            else
            {
                BP.IsEnabled = false;
                Btype.IsEnabled = false;
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            ComboBoxItem ComboItem = (ComboBoxItem)BP.SelectedItem;
            int BContent = Int32.Parse(ComboItem.Content.ToString());
            bx = ComboItem.Content.ToString();
            BC.Items.Clear();
            if (BG.Items.Count > BContent)
            {
                BG.Items.Clear();
                for (int CountB = 1; CountB <= BContent; CountB++)
                {
                    BG.Items.Add(new ListBoxItem { Content = "", Foreground = Brushes.White });
                }
            }
                BG.Items.Clear();
                for (int CountB = 1; CountB <= BContent; CountB++)
                {

                    BC.Items.Add(new ListBoxItem { Content = CountB.ToString(), HorizontalContentAlignment = HorizontalAlignment.Center, Background = Brushes.Gray });
                    BG.Items.Add(new ListBoxItem { Content = "", Foreground = Brushes.White });
                }
            

        }

        private void GPA_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(Btype.SelectedIndex == 5)
            {
                btype.IsEnabled = true;
            }
            else 
            {
                btype.IsEnabled = false;
            }
        }

        private void BC_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {



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

        private void ECB_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                if (content == true)
                {
                    BC.Items.Insert(BC.SelectedIndex, new ListBoxItem { Content = ECB.Text, HorizontalContentAlignment = HorizontalAlignment.Center, Background = Brushes.Gray });
                    BC.Items.Remove(BC.SelectedItem);
                    ECB.Clear();
                    ECB.Foreground = Brushes.Gray;
                    ECB.IsReadOnly = true;
                    content = false;
                }
                if (Gpa == true)
                {
                    BG.Items.RemoveAt(BC.SelectedIndex);
                    BG.Items.Insert(BC.SelectedIndex, new ListBoxItem { Content = "(" + ECB.Text + ")"  , Foreground = Brushes.White});
                    
                    ECB.Clear();
                    ECB.Foreground = Brushes.Gray;
                    ECB.IsReadOnly = true;
                    Gpa = false;
                }
            }
        }

        private void Color_Click(object sender, RoutedEventArgs e)
        {
        MessageBoxResult result = MessageBox.Show("Yes - Color button", "Choose further action:", MessageBoxButton.YesNo, MessageBoxImage.Question);
        if (result == MessageBoxResult.Yes)
        {
            ColorP.Visibility = Visibility.Visible;
        }
        else
        {
        

        }
    }

        private void Content_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure?", "Choose further action:", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                ECB.IsReadOnly = false;
                ECB.Clear();
                ECB.Foreground = Brushes.Black;
                content = true;
            }
            else
            {
                

            }
        }

        private void btype_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure?", "Choose further action:", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                ECB.IsReadOnly = false;
                ECB.Clear();
                ECB.Foreground = Brushes.Black;
                Gpa = true;
            }
            if(result == MessageBoxResult.No)
            {
                

            }
        }
    }
}
