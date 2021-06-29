using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UserInfo user = new UserInfo();
        double value,valueS;
        double ClickS;
        double NumberN;
        double result;
        double warning = 0;
        string name,sername;
  
        Random rand = new Random();
        
        int sizeS = 0, sizeC = 0;
        double TotalResult;
        
     
        public MainWindow()
        {
            
            
            InitializeComponent();
            
            user.ID = rand.Next(10000);

            EnterC.IsEnabled = false;
                foreach (UIElement el in Root.Children)
                {
                    if (el is Button)
                    {
                    ((Button)el).Click += Button_Click;
                    ((Button)el).IsEnabled = false;

                    }

                }
          
            
        }

        private void Name_KeyDown(object sender, KeyEventArgs e)
        {
            user.Name += Name.Text;
            if(e.Key == Key.Enter)
            {
                Name.IsReadOnly = true;
                
            }
        }

        private void Sername_KeyDown(object sender, KeyEventArgs e)
        {
            user.Sername += Sername.Text;
            if (e.Key == Key.Enter)
            {
                Sername.IsReadOnly = true;
                Id.Text += rand.Next(10000).ToString();
                DialogeW.Text = "Enter subjects for score:";
            }
            EnterC.IsEnabled = true;
           
        }

        private void EnterC_KeyDown_1(object sender, KeyEventArgs e)
        {
        
            if (e.Key == Key.Enter)
            {       
                sizeC = Int32.Parse(EnterC.Text);
                EnterC.IsEnabled = false;
                foreach (UIElement el in Root.Children)
                {
                    if (el is Button)
                    {                      
                        ((Button)el).IsEnabled = true;
                    }

                }

            }
        }

       

        private void ListBox_SelectionChanged1(object sender, SelectionChangedEventArgs e)
        {
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string s = (string)((Button)e.OriginalSource).Content;
            ClickS++;
            NumberN = ClickS;
            value += Int32.Parse(s);
            Clicker.Text = ClickS.ToString();
            Textbox1.Text = value.ToString();
            GEN.Clear();
                

                if (ClickS == sizeC)
                {
                    result = value / ClickS;
                valueS = value;
                Lister.Items[sizeS]= result;
                    TotalResult += result;
           
                if (result <= 2.5)
                {
                    GEN.Text = "Your middle score = " + result + "\r\n";
                    GEN.Text += "WARNING!!! Low-score! " + "\r\n";
                    
                    for (; warning < 2.6;)
                    {
                        warning = (valueS + 3) / (NumberN + 1);
                        valueS += 3;
                        NumberN += 1;
                        GEN.Text += "You need: " + 3 + " for " + warning + "\r\n";
                    }
                    warning = 0;
                    
                }
                else if (result <= 3.5)
                {
                    GEN.Text = "Your middle score = " + result + "\r\n";
                    GEN.Text += "Warning! Score equal 3!" + "\r\n";
                    
                    for (; warning < 3.6;)
                    {
                        warning = (valueS + 4) / (NumberN + 1);
                        valueS += 4;
                        NumberN += 1;
                        GEN.Text += "You need: " + 4 + " for " + warning + "\r\n";
                    }
                    
                    warning = 0;
                    
                }
                else if (result <= 4.5)
                {
                    GEN.Text = "Your middle score = " + result + "\r\n";
                    GEN.Text += "Warning! Score equal 4!" + "\r\n";
                    
                    for (; warning < 4.6;)
                    {
                        warning = (valueS + 5) / (NumberN + 1);
                        valueS += 5;
                        NumberN += 1;
                        GEN.Text += "You need: " + 5 + " for " + warning + "\r\n";
                    }
                    warning = 0;
                   
                }
                else
                {
                   
                        GEN.Text = "Your middle score = " + result + "\r\n";
                        GEN.Text += "Total score is normal! ;) " + "\r\n";
                    
                }
                value = 0;
                result = 0;
                ClickS = 0;
                sizeC = 0;
                sizeS++;
                EnterC.IsEnabled = true;
                foreach (UIElement el in Root.Children)
                {
                    if (el is Button)
                    {
                        ((Button)el).IsEnabled = false;
                    }

                }
                EnterC.Clear();
            }

            if(sizeS == 13)
            {
                TotalResult /= 13;
                Totalresult.Text = "Your total result = " + TotalResult;
            }
            
            /*
            foreach (var item in listbox.Items)
            {
                if(ClickS == 5)
                {
                    result = value / ClickS;
                  
                }
            }
            */
        }

       
    }
}
