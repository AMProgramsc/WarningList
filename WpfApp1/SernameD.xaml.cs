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
    /// Логика взаимодействия для SernameD.xaml
    /// </summary>
    public partial class SernameD : Window
    {
        UserInfo user = new UserInfo();
        string sername = "Sername.txt";

        public SernameD()
        {
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

        }
    }
}
//(c)AMProgramms, 2021