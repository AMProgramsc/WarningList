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
        public NameD()
        {
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
    }
}
//(c)AMProgramms, 2021