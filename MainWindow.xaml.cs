using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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
using System.Drawing;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       UserInfo user = new UserInfo();
       NewName nnr = new NewName();
       SernameD snr = new SernameD();
       NameD n = new NameD();

        double value, valueS, valueN;
        double ClickS;
        double NumberN;
        double result;
        double warning = 0;
        Random rand = new Random();
        string inf = "Inf.txt";
        string sizeN;
        bool delete = false;
        bool edit = false;
        int Count = 13;
        int hit =0;
        bool Check;
       
        
        int sizeS = 0, sizeC = 0,sizeR = -1;
        double TotalResult;
        
     
        public MainWindow()
        {
            
            
            InitializeComponent();
           
           
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
                Lister.Items.Add("-");
                listbox.Items.Add(sizeN);
                Count++;
                Namer.IsEnabled = false;
                listbox.IsEnabled = true;

            }
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            var response = MessageBox.Show("Do you really want to exit?", "Exiting...",
                MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
            if (response == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Application.Current.Shutdown();
            }

            base.OnClosing(e);
        }

        private void Name_MouseEnter(object sender, MouseEventArgs e)
        {
            n.Show();
            if(Sername.Text != null)
            {
              
                Name.IsEnabled = false;
                Id.Text = rand.Next(10000).ToString();
              
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


                    // Score.SelectedItem = false;
                    value -= Int32.Parse(Score.SelectedItem.ToString());
                    Score.Items.Remove(Score.SelectedItem);
                  
                    ClickS--;
                        DialogeW.Text = "Press Buttons for score";
                  

                    break;
                    case MessageBoxResult.No:
                        Score.SelectedItem = false;
                        DialogeW.Text = "Press Buttons for score";
                        
                        break;

                }
            result = MessageBoxResult.No;


        }

   
        private void Background_Checked(object sender, RoutedEventArgs e)
        {
            Root.Background = Brushes.Black;
            Menu.Background = Brushes.White;
            Lister.Foreground = Brushes.White;
            EnterC.Foreground = Brushes.White;
            Textbox1.Foreground = Brushes.White;
            Name.Foreground = Brushes.White;
            Sername.Foreground = Brushes.White;
            Id.Foreground = Brushes.White;
            Namer.Foreground = Brushes.White;
            Totalresult.Foreground = Brushes.White;
            DialogeW.Foreground = Brushes.White;
            GEN.Foreground = Brushes.White;
            Score.Foreground = Brushes.White;
       
        }


        private void Red_Click(object sender, RoutedEventArgs e)
        {
          
            Lister.Foreground = Brushes.Red;
            EnterC.Foreground = Brushes.Red;
            Textbox1.Foreground = Brushes.Red;
            Name.Foreground = Brushes.Red;
            Sername.Foreground = Brushes.Red;
            Id.Foreground = Brushes.Red;
            Namer.Foreground = Brushes.Red;
            Totalresult.Foreground = Brushes.Red;
            DialogeW.Foreground = Brushes.Red;
            GEN.Foreground = Brushes.Red;
            Score.Foreground = Brushes.Red;
        }

        private void Blue_Click(object sender, RoutedEventArgs e)
        {
           
            Lister.Foreground = Brushes.Blue;
            EnterC.Foreground = Brushes.Blue;
            Textbox1.Foreground = Brushes.Blue;
            Name.Foreground = Brushes.Blue;
            Sername.Foreground = Brushes.Blue;
            Id.Foreground = Brushes.Blue;
            Namer.Foreground = Brushes.Blue;
            Totalresult.Foreground = Brushes.Blue;
            DialogeW.Foreground = Brushes.Blue;
            GEN.Foreground = Brushes.Blue;
            Score.Foreground = Brushes.Blue;
        }

        private void Green_Click(object sender, RoutedEventArgs e)
        {
            
            Lister.Foreground = Brushes.Green;
            EnterC.Foreground = Brushes.Green;
            Textbox1.Foreground = Brushes.Green;
            Name.Foreground = Brushes.Green;
            Sername.Foreground = Brushes.Green;
            Id.Foreground = Brushes.Green;
            Namer.Foreground = Brushes.Green;
            Totalresult.Foreground = Brushes.Green;
            DialogeW.Foreground = Brushes.Green;
            GEN.Foreground = Brushes.Green;
            Score.Foreground = Brushes.Green;
        }

        private void Yellow_Click(object sender, RoutedEventArgs e)
        {
           
            Lister.Foreground = Brushes.DarkOrange;
            EnterC.Foreground = Brushes.DarkOrange;
            Textbox1.Foreground = Brushes.DarkOrange;
            Name.Foreground = Brushes.DarkOrange;
            Sername.Foreground = Brushes.DarkOrange;
            Id.Foreground = Brushes.DarkOrange;
            Namer.Foreground = Brushes.DarkOrange;
            Totalresult.Foreground = Brushes.DarkOrange;
            DialogeW.Foreground = Brushes.DarkOrange;
            GEN.Foreground = Brushes.DarkOrange;
            Score.Foreground = Brushes.DarkOrange;
        }

        private void Black_Click(object sender, RoutedEventArgs e)
        {
          
            Lister.Foreground = Brushes.Black;
            EnterC.Foreground = Brushes.Black;
            Textbox1.Foreground = Brushes.Black;
            Name.Foreground = Brushes.Black;
            Sername.Foreground = Brushes.Black;
            Id.Foreground = Brushes.Black;
            Namer.Foreground = Brushes.Black;
            Totalresult.Foreground = Brushes.Black;
            DialogeW.Foreground = Brushes.Black;
            GEN.Foreground = Brushes.Black;
            Score.Foreground = Brushes.Black;
        }

        private void Background_Unchecked(object sender, RoutedEventArgs e)
        {
            Root.Background = Brushes.White;
            Menu.Background = Brushes.Gray;
            Lister.Foreground = Brushes.Black;
            EnterC.Foreground = Brushes.Black;
            Textbox1.Foreground = Brushes.Black;
            Name.Foreground =  Brushes.Black; 
            Sername.Foreground = Brushes.Black;
            Id.Foreground = Brushes.Black;
            Namer.Foreground = Brushes.Black;
            Totalresult.Foreground = Brushes.Black;
            DialogeW.Foreground = Brushes.Black;
            GEN.Foreground = Brushes.Black;
            Score.Foreground = Brushes.Black;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
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

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    delete = true;
                    listbox.IsEnabled = true;
                    DialogeW.Text = "Click element for delete!";
                    break;
                case MessageBoxResult.No:

                    break;
            }
        }
        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    edit = true;
                    listbox.IsEnabled = true;
                    DialogeW.Text = "Click element for edit!";
                    nnr.Show();
                    
                    break;
                case MessageBoxResult.No:

                    break;
            }
        }

        private void R_Click(object sender, RoutedEventArgs e)
        {
            listbox.Items.Insert(listbox.SelectedIndex, new ListBoxItem() { Content = listbox.SelectedItem, Background = Brushes.Red });
            listbox.Items.Remove(listbox.SelectedItem);
         

        }

        private void G_Click(object sender, RoutedEventArgs e)
        {
            listbox.Items.Insert(listbox.SelectedIndex, new ListBoxItem() { Content = listbox.SelectedItem, Background = Brushes.Green });
            listbox.Items.Remove(listbox.SelectedItem);
        }

        private void B_Click(object sender, RoutedEventArgs e)
        {
            listbox.Items.Insert(listbox.SelectedIndex, new ListBoxItem() { Content = listbox.SelectedItem, Background = Brushes.Blue });
            listbox.Items.Remove(listbox.SelectedItem);
        }

        private void O_Click(object sender, RoutedEventArgs e)
        {
            listbox.Items.Insert(listbox.SelectedIndex, new ListBoxItem() { Content = listbox.SelectedItem, Background = Brushes.Orange });
            listbox.Items.Remove(listbox.SelectedItem);
        }

        private void C_Click(object sender, RoutedEventArgs e)
        {
            listbox.Items.Insert(listbox.SelectedIndex, new ListBoxItem() { Content = listbox.SelectedItem, Background = Brushes.Cyan });
            listbox.Items.Remove(listbox.SelectedItem);
        }

        private void Y_Click(object sender, RoutedEventArgs e)
        {
            listbox.Items.Insert(listbox.SelectedIndex, new ListBoxItem() { Content = listbox.SelectedItem, Background = Brushes.Yellow });
            listbox.Items.Remove(listbox.SelectedItem);
        }

        private void Br_Click(object sender, RoutedEventArgs e)
        {
            listbox.Items.Insert(listbox.SelectedIndex, new ListBoxItem() { Content = listbox.SelectedItem, Background = Brushes.Brown });
            listbox.Items.Remove(listbox.SelectedItem);
        }

        private void Gr_Click(object sender, RoutedEventArgs e)
        {
            listbox.Items.Insert(listbox.SelectedIndex, new ListBoxItem() { Content = listbox.SelectedItem, Background = Brushes.Gray });
            listbox.Items.Remove(listbox.SelectedItem);
        }

        private void bold_Click(object sender, RoutedEventArgs e)
        {
            listbox.FontWeight = FontWeights.Bold;
            Menu.FontWeight = FontWeights.Bold;
            Lister.FontWeight = FontWeights.Bold;
            EnterC.FontWeight = FontWeights.Bold;
            Textbox1.FontWeight = FontWeights.Bold;
            Name.FontWeight = FontWeights.Bold;
            Sername.FontWeight = FontWeights.Bold;
            Id.FontWeight = FontWeights.Bold;
            Namer.FontWeight = FontWeights.Bold;
            Totalresult.FontWeight = FontWeights.Bold;
            GEN.FontWeight = FontWeights.Bold;
            Score.FontWeight = FontWeights.Bold;
        }

        private void italic_Click(object sender, RoutedEventArgs e)
        {
            listbox.FontStyle = FontStyles.Italic;
            Menu.FontStyle = FontStyles.Italic;
            Lister.FontStyle = FontStyles.Italic;
            EnterC.FontStyle = FontStyles.Italic;
            Textbox1.FontStyle = FontStyles.Italic;
            Name.FontStyle = FontStyles.Italic;
            Sername.FontStyle = FontStyles.Italic;
            Id.FontStyle = FontStyles.Italic;
            Namer.FontStyle = FontStyles.Italic;
            Totalresult.FontStyle = FontStyles.Italic;
            GEN.FontStyle = FontStyles.Italic;
            Score.FontStyle = FontStyles.Italic;
        }

        private void underline_Click(object sender, RoutedEventArgs e)
        {
            EnterC.TextDecorations = TextDecorations.Underline;
            Textbox1.TextDecorations = TextDecorations.Underline;
            Name.TextDecorations = TextDecorations.Underline;
            Sername.TextDecorations = TextDecorations.Underline;
            Id.TextDecorations = TextDecorations.Underline;
            Namer.TextDecorations = TextDecorations.Underline;
            Totalresult.TextDecorations = TextDecorations.Underline;
            GEN.TextDecorations = TextDecorations.Underline;
        }

        private void normal_Click(object sender, RoutedEventArgs e)
        {
            listbox.FontWeight = FontWeights.Normal; 
            Menu.FontWeight = FontWeights.Normal;
            Lister.FontWeight = FontWeights.Normal;
            EnterC.FontWeight = FontWeights.Normal;
            Textbox1.FontWeight = FontWeights.Normal;
            Name.FontWeight = FontWeights.Normal;
            Sername.FontWeight = FontWeights.Normal;
            Id.FontWeight = FontWeights.Normal;
            Namer.FontWeight = FontWeights.Normal;
            Totalresult.FontWeight = FontWeights.Normal;
            GEN.FontWeight = FontWeights.Normal;
            Score.FontWeight = FontWeights.Normal;
            listbox.FontStyle = FontStyles.Normal;
            Menu.FontStyle = FontStyles.Normal;
            Lister.FontStyle = FontStyles.Normal;
            EnterC.FontStyle = FontStyles.Normal;
            Textbox1.FontStyle = FontStyles.Normal;
            Name.FontStyle = FontStyles.Normal;
            Sername.FontStyle = FontStyles.Normal;
            Id.FontStyle = FontStyles.Normal;
            Namer.FontStyle = FontStyles.Normal;
            Totalresult.FontStyle = FontStyles.Normal;
            GEN.FontStyle = FontStyles.Normal;
            Score.FontStyle = FontStyles.Normal;
    
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
            sizeN = File.ReadAllText(@"Newname.txt");           
            Name.Text = File.ReadAllText(@"Name.txt");
            Sername.Text = File.ReadAllText(@"Sername.txt");
            if (delete == true)
            {
             
                listbox.Items.Remove(listbox.SelectedItem);
                Lister.Items.Remove(listbox.SelectedItem);
                Count--;
                DialogeW.Text = "Change subject";
                
            }
            if (edit == true)
            {

            
                listbox.Items[listbox.SelectedIndex + 1] = sizeN;
               
                DialogeW.Text = "Change subject";
             
               
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
        
            edit = false;
            delete = false;
        }
//(c)AMProgramms, 2021
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
            
        }

       
    }
}
//(c)AMProgramms, 2021