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
    /// Логика взаимодействия для NewName.xaml
    /// </summary>
    public partial class SaveD : Window
    {
 

        public SaveD()
        {
            InitializeComponent();
        }

        private void NewName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
             
                using (var file = File.Create(System.IO.Path.Combine(@"C:\Users\TopDesktop-1\source\repos\WarningList 1Exp\WpfApp1\SaveData", N.Text)))
                {
                    //write
                    
                }

               



                this.Visibility = Visibility.Hidden;
                //N.Clear();

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