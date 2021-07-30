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
    /// Логика взаимодействия для NameD.xaml
    /// </summary>
    public partial class NameD : Window
    {
        
        
        UserInfo user = new UserInfo();
        SernameD sn = new SernameD();
        string name = "Name.txt";
        int lang;
      
        public NameD()
        {

            lang = Int32.Parse(File.ReadLines("Settings.txt").Skip(7).First());
            if (lang == 0)
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("en-US");

            }
            if (lang == 1)
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("ru-RU");

            }
            if (lang == 2)
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("fr-FR");

            }
            if (lang == 3)
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("de-DE");

            }
            if (lang == 4)
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("uk-UA");

            }
            if (lang == 5)
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("be-BY");

            }
            if(lang == 6)
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("cs-CZ");
            }
            InitializeComponent();
        }
        private void NAME_KeyDown(object sender, KeyEventArgs e)
        
        {
       
            if (e.Key == Key.Enter)
            {
                File.WriteAllText(name, NAME.Text);
                sn.Show();
               Close();
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Visibility = Visibility.Hidden;
        }
    }
}
//(c)AMProgramms, 2021