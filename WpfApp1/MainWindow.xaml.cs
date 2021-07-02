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
        double value, valueS, valueN;
        double ClickS;
        double NumberN;
        double result;
        double warning = 0;
        string name,sername,sizeN;
        bool delete = false;
        int Count = 13;
        Random rand = new Random();
        
        int sizeS = 0, sizeC = 0,sizeR =0;
        double TotalResult;
        
     
        public MainWindow()
        {
            
            
            InitializeComponent();
           
            user.ID = rand.Next(10000);
            Namer.IsEnabled = false;
            listbox.IsEnabled = false;
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
                //EnterC.IsEnabled = true;
                listbox.IsEnabled = true;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           
            MessageBoxResult result = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    
                   
                    
                    listbox.IsEnabled = false;
                    Namer.IsEnabled = true;
                    DialogeW.Text = "Enter name subject";
                    break;
                case MessageBoxResult.No:
                   
                    break;
            }
        }

        private void TextBox_MouseEnter(object sender, MouseEventArgs e)
        {
            Namer.Clear();
        }

        private void Namer_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.Key == Key.Enter)
            {
                sizeN = Namer.Text;
                
                //listbox.Items.Add(sizeN);
                Lister.Items.Add(0);
                listbox.Items.Insert(Count, sizeN);
                Count++;
                Namer.IsEnabled = false;
                listbox.IsEnabled = true;

            }
        }

        private void Score_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DialogeW.Text = "Confirm?";
            MessageBoxResult result = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    value -= Int32.Parse(Score.SelectedItem.ToString());
                    Score.Items.Remove(Score.SelectedItem);
                    ClickS--;
                    DialogeW.Text = "Press Buttons for score";
                    Score.SelectedItem = false;
                    break;
                case MessageBoxResult.No:
                    Score.SelectedItem = false;
                    DialogeW.Text = "Press Buttons for score";
                    break;
            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            MessageBoxResult result = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    delete = true;
                    listbox.IsEnabled = true;
                    break;
                case MessageBoxResult.No:
                  
                    break;
            }
          
            
        }

        private void EnterC_MouseEnter(object sender, MouseEventArgs e)
        {
            EnterC.Clear();
        }



        private void EnterC_KeyDown_1(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Enter)
            {
                sizeC = Int32.Parse(EnterC.Text);
                if (sizeC < 3)
                {
                    DialogeW.Text = "Error! Score very small!";
                    EnterC.Clear();
                }
                else 
                {

                    DialogeW.Text = "Press Buttons for score";
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
        }

       

        private void ListBox_SelectionChanged1(object sender, SelectionChangedEventArgs e)
        {
            if (delete == true)
            {
                listbox.Items.Remove(listbox.SelectedItem);
                Lister.Items.Remove(listbox.SelectedItem);
                Count--;
            }
            else
            {
                DialogeW.Text = "Change subject";
                MessageBoxResult result = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                switch (result)
                {
                    case MessageBoxResult.Yes:
                        foreach (UIElement el in Root.Children)
                        {
                            if (el is Button)
                            {

                                ((Button)el).IsEnabled = false;

                            }

                        }
                        EnterC.IsEnabled = true;
                        listbox.IsEnabled = false;
                        break;
                    case MessageBoxResult.No:
                        listbox.SelectedItem = false;
                        break;
                }
            }
            delete = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string s = (string)((Button)e.OriginalSource).Content;
            ClickS++;
            NumberN = ClickS;
            value += Int32.Parse(s);
            valueN = Int32.Parse(s);
            Clicker.Text = ClickS.ToString();
            Textbox1.Text = value.ToString();
            GEN.Clear();
            Score.Items.Add(valueN);
            

            if (ClickS == sizeC)
                {
                    result = value / ClickS;
                valueS = value;
                Lister.Items[listbox.SelectedIndex] = result;
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
                EnterC.IsEnabled = false;
                listbox.IsEnabled = true;
                Score.Items.Clear();
            }

            if(sizeS == Count)
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
