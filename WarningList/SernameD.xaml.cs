using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для SernameD.xaml
    /// </summary>
    public partial class SernameD : Window
    {

        private const int GWL_STYLE = -16;
        private const int WS_SYSMENU = 0x80000;
        [DllImport("user32.dll", SetLastError = true)]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);
        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);


        UserInfo user = new UserInfo();
        string sername = "Sername.txt";
        int lang;
        public int t;
        public SernameD()
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
            InitializeComponent();
          
        }

        private void SERNAME_KeyDown(object sender, KeyEventArgs e)
        {
         
                
            if (e.Key == Key.Enter)
            {

                File.WriteAllText(sername, SERNAME.Text);
                Close();
            }
        
        
        
        
        }
     
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
          
            e.Cancel = true;
            this.Visibility = Visibility.Hidden;
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var hwnd = new WindowInteropHelper(this).Handle;
            SetWindowLong(hwnd, GWL_STYLE, GetWindowLong(hwnd, GWL_STYLE) & ~WS_SYSMENU);
        }
    }
}
//(c)AMProgramms, 2021