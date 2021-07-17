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
    /// Логика взаимодействия для Settings.xaml
    /// </summary>
    public partial class Settings : Window
    {
       int check = 0;
        int screen = 0;
      
     
        public Settings()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
           
            check = 1;
            using (StreamWriter w = new StreamWriter("Settings.txt", false, Encoding.GetEncoding(1251)))
            {
                //File.WriteAllText("Settings.txt", check.ToString());
                w.WriteLine(check.ToString());
                w.WriteLine(screen.ToString());
            }
        }

        private void Debug_Unchecked(object sender, RoutedEventArgs e)
        {
            check = 0;

            //File.WriteAllText("Settings.txt", check.ToString());
            using (StreamWriter w = new StreamWriter("Settings.txt", false, Encoding.GetEncoding(1251)))
            {
                //File.WriteAllText("Settings.txt", check.ToString());
                w.WriteLine(check.ToString());
                w.WriteLine(screen.ToString());
            }
        }

        private void Fullscreen_Checked(object sender, RoutedEventArgs e)
        {
           
            screen = 1;

            //File.WriteAllText("Settings.txt", screen.ToString());
            using (StreamWriter w = new StreamWriter("Settings.txt", false, Encoding.GetEncoding(1251)))
            {
                //File.WriteAllText("Settings.txt", check.ToString());
                w.WriteLine(check.ToString());
                w.WriteLine(screen.ToString());
            }
        }

        private void Fullscreen_Unchecked(object sender, RoutedEventArgs e)
        {
           
            screen = 0;
            //File.WriteAllText("Settings.txt", screen.ToString());
            using (StreamWriter w = new StreamWriter("Settings.txt", false, Encoding.GetEncoding(1251)))
            {
                //File.WriteAllText("Settings.txt", check.ToString());
                w.WriteLine(check.ToString());
                w.WriteLine(screen.ToString());
            }
        }
    }
}
//(c)AMProgramms, 2021