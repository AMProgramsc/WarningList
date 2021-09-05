using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
        
        public int savedataFCustomEST; 
        public int tabindexType;
        public string buttonsCount;
        bool Gpa = false;
        bool content = false;
        public CustomET()
        {
            InitializeComponent();

        }

        private void OpenDialog_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.ShowDialog();
            try 
            {
                ImageSource image =  new ImageSourceConverter().ConvertFromString(dialog.FileName) as ImageSource;
                LoadImagePath.Text = dialog.FileName;
                ImagePath.Source = image;
            }
            catch(Exception exp)
            {

            }
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int exit = Int32.Parse(File.ReadLines("Exit.txt").First());
            if (exit != 1)
            {
                try
                {
                    MessageBoxResult resExit = MessageBox.Show("All changes don't save!", Properties.Resources.Sure, MessageBoxButton.YesNo, MessageBoxImage.Warning);
                    if (resExit == MessageBoxResult.Yes)
                    {
                        e.Cancel = true;
                        this.Visibility = Visibility.Hidden;

                    }
                    else
                    {

                    }
                }
                catch(Exception exp)
                {
                    MessageBox.Show(exp.Message, "Error");
                }
            }
            else
            {
                File.WriteAllText("Exit.txt", "3");
            }


        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if (NameET.Text == "" || EType.SelectedIndex == -1)
            {
                MessageBox.Show("Name or type not specified", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            if(EType.SelectedIndex == 10 && (BCount.SelectedIndex == -1 || Btype.SelectedIndex == -1))
            {
                MessageBox.Show("GPA or Buttons not changed", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                savedataFCustomEST = 1;
                this.Visibility = Visibility.Hidden;
            }
        }

        private void CP_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tabindexType = EType.SelectedIndex;
            if(tabindexType > 9)
            {
                BCount.IsEnabled = true;
                Btype.IsEnabled = true;
            }
            else
            {
                BCount.IsEnabled = false;
                Btype.IsEnabled = false;
                BCount.SelectedIndex = -1;
                Btype.SelectedIndex = -1;
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            ComboBoxItem ComboItem = (ComboBoxItem)BCount.SelectedItem;
            int BContent = Int32.Parse(ComboItem.Content.ToString());
            buttonsCount = ComboItem.Content.ToString();

                ButtonsList.Items.Clear();
                if (ButtonSupplement.Items.Count > BContent)
                {
                    ButtonSupplement.Items.Clear();
                    for (int CountB = 1; CountB <= BContent; CountB++)
                    {
                        ButtonSupplement.Items.Add(new ListBoxItem { Content = "", Foreground = Brushes.White });
                    }
                }
                ButtonSupplement.Items.Clear();
                for (int CountB = 1; CountB <= BContent; CountB++)
                {

                    ButtonsList.Items.Add(new ListBoxItem { Content = CountB.ToString(), HorizontalContentAlignment = HorizontalAlignment.Center, Background = Brushes.Gray });
                    ButtonSupplement.Items.Add(new ListBoxItem { Content = "", Foreground = Brushes.White });
                }
            

        }

        private void GPA_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(Btype.SelectedIndex == 5)
            {
                ButtonSupp.IsEnabled = true;
            }
            else 
            {
                ButtonSupp.IsEnabled = false;
            }
        }

        private void BC_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {



        }

        private void ColorP_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            string c1 = ColorP.SelectedColor.Value.ToString();
            SolidColorBrush ck = (SolidColorBrush)new BrushConverter().ConvertFromString(c1);
            ListBoxItem lbi = ButtonsList.Items[ButtonsList.SelectedIndex] as ListBoxItem;
            lbi.Background = ck;
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ColorP.Visibility = Visibility.Hidden;
        }

        private void ECB_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Key == Key.Enter)
                {
                    if (content == true)
                    {
                        ButtonsList.Items.Insert(ButtonsList.SelectedIndex, new ListBoxItem { Content = EnterConSupp.Text, HorizontalContentAlignment = HorizontalAlignment.Center, Background = Brushes.Gray });
                        ButtonsList.Items.Remove(ButtonsList.SelectedItem);
                        EnterConSupp.Clear();
                        EnterConSupp.Foreground = Brushes.Gray;
                        EnterConSupp.IsReadOnly = true;
                        content = false;
                    }
                    if (Gpa == true)
                    {
                        ButtonSupplement.Items.RemoveAt(ButtonsList.SelectedIndex);
                        ButtonSupplement.Items.Insert(ButtonsList.SelectedIndex, new ListBoxItem { Content = "(" + EnterConSupp.Text + ")", Foreground = Brushes.White });

                        EnterConSupp.Clear();
                        EnterConSupp.Foreground = Brushes.Gray;
                        EnterConSupp.IsReadOnly = true;
                        Gpa = false;
                    }
                }
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message,"Error",MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }

        private void Color_Click(object sender, RoutedEventArgs e)
        {
          MessageBoxResult result = MessageBox.Show(Properties.Resources.Sure, "Choose further action:", MessageBoxButton.YesNo, MessageBoxImage.Question);
          if (result == MessageBoxResult.Yes)
          {
            ColorP.Visibility = Visibility.Visible;
          }
        }

        private void Content_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show(Properties.Resources.Sure, "Choose further action:", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                EnterConSupp.IsReadOnly = false;
                EnterConSupp.Clear();
                EnterConSupp.Foreground = Brushes.Black;
                content = true;
            }
        }

        private void btype_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure?", "Choose further action:", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                EnterConSupp.IsReadOnly = false;
                EnterConSupp.Clear();
                EnterConSupp.Foreground = Brushes.Black;
                Gpa = true;
            }
        }

    }
}
