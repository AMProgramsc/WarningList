using System;
using System.Collections.Generic;
using System.Globalization;
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
        public CustomETNameViewModel CurrentModel = new CustomETNameViewModel();
        CustomET CET = new CustomET();
        int check = Int32.Parse(File.ReadLines("Settings.txt").Skip(1).First());
        int screen = Int32.Parse(File.ReadLines("Settings.txt").Skip(3).First());
        int pb = Int32.Parse(File.ReadLines("Settings.txt").Skip(5).First());
        int lang = Int32.Parse(File.ReadLines("Settings.txt").Skip(7).First());
        int type = Int32.Parse(File.ReadLines("Settings.txt").Skip(9).First());
        int auto = Int32.Parse(File.ReadLines("Settings.txt").Skip(11).First());

        public int _width =100;
        public int _height = 100;
    
        public Settings()
        {
         
            InitializeComponent();
            this.DataContext = CurrentModel;
     
            if (check == 1)
            {
                Debug.IsChecked = true;
                Texter.Clear();
            }
            if (screen == 1)
            {
                Fullscreen.IsChecked = true;
                Texter.Clear();
            }
            if (pb == 1)
            {
                Pb.IsChecked = true;
                Texter.Clear();
            }
            
            if (auto == 1)
            {
                Auto.IsChecked = true;
                Type.IsEnabled = false;
                Texter.Clear();
            }
            if(File.ReadAllText(@"EST.txt") != "")
            {
                int strings = System.IO.File.ReadAllLines("EST.txt").Length;
                int str = 0;
                int data = strings / 6;
                for (int path = 0; path < data; path ++)
                {
                    if (File.ReadLines("EST.txt").Skip(str + path).First() == "")
                    {
                        continue;
                    }
                    else
                    {
                        WrapPanel wrapPanel = new WrapPanel();
                        RadioButton rdn = new RadioButton();
                        if (File.ReadLines("EST.txt").Skip(str + 3).First() != "")
                        {
                            ImageSource image = new ImageSourceConverter().ConvertFromString(File.ReadLines("EST.txt").Skip(str + 3).First()) as ImageSource;
                            wrapPanel.Children.Add(new Image { Source = image, Width = 17, Height = 15 });
                        }
                        wrapPanel.Children.Add(new TextBlock { Text = File.ReadLines("EST.txt").Skip(str + 1).First(), Foreground = Brushes.White });
                        rdn.TabIndex = Int32.Parse(File.ReadLines("EST.txt").Skip(5).First());
                        rdn.Content = wrapPanel;
                        rdn.Name = File.ReadLines("EST.txt").Skip(str + 1).First();
                        Tsys.Items.Add(rdn);
                        str += 6;
                    }
                }
            }

            foreach (UIElement uI in Tsys.Items)
            {
                if (uI is RadioButton)
                {
                    ((RadioButton)uI).Checked += Sys_Checked;

                }
            }
            foreach (UIElement uI in Lang.Items)
            {
                if (uI is RadioButton)
                {
                    ((RadioButton)uI).Checked += Lang_Checked;

                }
            }
        }
        //Fullscreen/Debug/VOID
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
           
            check = 1;
            VOID.Visibility = Visibility.Visible;
            Texter.Foreground = Brushes.Green;
            Texter.Text = Properties.Resources.Succeses;

            using (StreamWriter w = new StreamWriter("Settings.txt", false, Encoding.GetEncoding(1251)))
            {
                w.WriteLine("Debug:");
                w.WriteLine(check.ToString());
                w.WriteLine("Fullscreen:");
                w.WriteLine(screen.ToString());
                w.WriteLine("Progressbar:");
                w.WriteLine(pb.ToString());
                w.WriteLine("Language:");
                w.WriteLine(lang.ToString());
                w.WriteLine("TypeSys:");
                w.WriteLine(type.ToString());
                w.WriteLine("Auto:");
                w.WriteLine(auto.ToString());
            }

        }

        private void Debug_Unchecked(object sender, RoutedEventArgs e)
        {
            check = 0;
            VOID.Visibility = Visibility.Hidden;
            Texter.Foreground = Brushes.Green;
            Texter.Text = Properties.Resources.Succeses;

            using (StreamWriter w = new StreamWriter("Settings.txt", false, Encoding.GetEncoding(1251)))
            {
                w.WriteLine("Debug:");
                w.WriteLine(check.ToString());
                w.WriteLine("Fullscreen:");
                w.WriteLine(screen.ToString());
                w.WriteLine("Progressbar:");
                w.WriteLine(pb.ToString());
                w.WriteLine("Language:");
                w.WriteLine(lang.ToString());
                w.WriteLine("TypeSys:");
                w.WriteLine(type.ToString());
                w.WriteLine("Auto:");
                w.WriteLine(auto.ToString());
            }
        }

        private void Fullscreen_Checked(object sender, RoutedEventArgs e)
        {
           
            screen = 1;
            Texter.Foreground = Brushes.Green;
            Texter.Text = Properties.Resources.Succeses;

            using (StreamWriter w = new StreamWriter("Settings.txt", false, Encoding.GetEncoding(1251)))
            {
                w.WriteLine("Debug:");
                w.WriteLine(check.ToString());
                w.WriteLine("Fullscreen:");
                w.WriteLine(screen.ToString());
                w.WriteLine("Progressbar:");
                w.WriteLine(pb.ToString());
                w.WriteLine("Language:");
                w.WriteLine(lang.ToString());
                w.WriteLine("TypeSys:");
                w.WriteLine(type.ToString());
                w.WriteLine("Auto:");
                w.WriteLine(auto.ToString());
            }

        }

        private void Fullscreen_Unchecked(object sender, RoutedEventArgs e)
        {

            screen = 0;
            Texter.Foreground = Brushes.Green;
            Texter.Text = Properties.Resources.Succeses;

            using (StreamWriter w = new StreamWriter("Settings.txt", false, Encoding.GetEncoding(1251)))
            {
                w.WriteLine("Debug:");
                w.WriteLine(check.ToString());
                w.WriteLine("Fullscreen:");
                w.WriteLine(screen.ToString());
                w.WriteLine("Progressbar:");
                w.WriteLine(pb.ToString());
                w.WriteLine("Language:");
                w.WriteLine(lang.ToString());
                w.WriteLine("TypeSys:");
                w.WriteLine(type.ToString());
                w.WriteLine("Auto:");
                w.WriteLine(auto.ToString());
            }
        }

        private void Debug_MouseEnter(object sender, MouseEventArgs e)
        {
            Texter.Text = Properties.Resources.Dm;
        }
     
        private void VOID_MouseEnter(object sender, MouseEventArgs e)
        {
            Texter.Foreground = Brushes.Red;
            Texter.Text = Properties.Resources.Voider;
        }

        private void Fullscreen_MouseEnter(object sender, MouseEventArgs e)
        {
            Texter.Text = Properties.Resources.Fs;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Visibility = Visibility.Hidden;
        }

        private void Fullscreen_MouseLeave(object sender, MouseEventArgs e)
        {
            Texter.Clear();
            Texter.Foreground = Brushes.White;
        }

        private void Debug_MouseLeave(object sender, MouseEventArgs e)
        {
            Texter.Clear();
            Texter.Foreground = Brushes.White;
        }
        //VOID
        private void VOID_MouseLeave(object sender, MouseEventArgs e)
        {
            Texter.Foreground = Brushes.White;
            Texter.Clear();
        }
        private void VOID_Checked(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show(Properties.Resources.Sure, Properties.Resources.SureVoid1, MessageBoxButton.YesNo, MessageBoxImage.Warning);
           
            switch (result)
            {
                case MessageBoxResult.Yes:
                    MessageBoxResult results = MessageBox.Show(Properties.Resources.SV2, Properties.Resources.SureVoid2, MessageBoxButton.YesNo, MessageBoxImage.Error );
                    switch (results)
                    {
                        case MessageBoxResult.Yes:
                            MessageBoxResult resist = MessageBox.Show(Properties.Resources.SV3, Properties.Resources.SureVoid3, MessageBoxButton.OK , MessageBoxImage.Stop);
                            VOID.IsChecked = false;
                            break;
                        case MessageBoxResult.No:

                            break;
                    }



                    break;
                case MessageBoxResult.No:
                    
                    break;
            }
        }
        //Progressbar
        private void Pb_Checked(object sender, RoutedEventArgs e)
        {
            pb = 1;
            Texter.Foreground = Brushes.Green;
            Texter.Text = Properties.Resources.Succeses;


            using (StreamWriter w = new StreamWriter("Settings.txt", false, Encoding.GetEncoding(1251)))
            {
                w.WriteLine("Debug:");
                w.WriteLine(check.ToString());
                w.WriteLine("Fullscreen:");
                w.WriteLine(screen.ToString());
                w.WriteLine("Progressbar:");
                w.WriteLine(pb.ToString());
                w.WriteLine("Language:");
                w.WriteLine(lang.ToString());
                w.WriteLine("TypeSys:");
                w.WriteLine(type.ToString());
                w.WriteLine("Auto:");
                w.WriteLine(auto.ToString());
            }
        }
        private void Pb_MouseEnter(object sender, MouseEventArgs e)
        {
            Texter.Text = Properties.Resources.Pb;
        }
        private void Pb_MouseLeave(object sender, MouseEventArgs e)
        {
            Texter.Clear();
            Texter.Foreground = Brushes.White;
        }
        private void Pb_Unchecked(object sender, RoutedEventArgs e)
        {
            pb = 0;
            Texter.Foreground = Brushes.Green;
            Texter.Text = Properties.Resources.Succeses;


            using (StreamWriter w = new StreamWriter("Settings.txt", false, Encoding.GetEncoding(1251)))
            {
                w.WriteLine("Debug:");
                w.WriteLine(check.ToString());
                w.WriteLine("Fullscreen:");
                w.WriteLine(screen.ToString());
                w.WriteLine("Progressbar:");
                w.WriteLine(pb.ToString());
                w.WriteLine("Language:");
                w.WriteLine(lang.ToString());
                w.WriteLine("TypeSys:");
                w.WriteLine(type.ToString());
                w.WriteLine("Auto:");
                w.WriteLine(auto.ToString());
            }
        }

        //Language

        private void Lang_Checked(object sender, RoutedEventArgs e)
        {
            var radioButton = sender as RadioButton;
            lang = Convert.ToInt32(radioButton.TabIndex.ToString());
            if (auto == 1)
            {
                type = lang;
            }
            using (StreamWriter w = new StreamWriter("Settings.txt", false, Encoding.GetEncoding(1251)))
            {
                w.WriteLine("Debug:");
                w.WriteLine(check.ToString());
                w.WriteLine("Fullscreen:");
                w.WriteLine(screen.ToString());
                w.WriteLine("Progressbar:");
                w.WriteLine(pb.ToString());
                w.WriteLine("Language:");
                w.WriteLine(lang.ToString());
                w.WriteLine("TypeSys:");
                w.WriteLine(type.ToString());
                w.WriteLine("Auto:");
                w.WriteLine(auto.ToString());
            }
        }
        //Type system
        private void Sys_Checked(object sender, RoutedEventArgs e)
        {
            var radioButton = sender as RadioButton;
            type = Convert.ToInt32(radioButton.TabIndex.ToString());
            
                using (StreamWriter w = new StreamWriter("Settings.txt", false, Encoding.GetEncoding(1251)))
                {
                    w.WriteLine("Debug:");
                    w.WriteLine(check.ToString());
                    w.WriteLine("Fullscreen:");
                    w.WriteLine(screen.ToString());
                    w.WriteLine("Progressbar:");
                    w.WriteLine(pb.ToString());
                    w.WriteLine("Language:");
                    w.WriteLine(lang.ToString());
                    w.WriteLine("TypeSys:");
                    w.WriteLine(type.ToString());
                    w.WriteLine("Auto:");
                    w.WriteLine(auto.ToString());

                }
            if (radioButton.TabIndex > 9)
            {
                File.WriteAllText("NameEST.txt", radioButton.Name);
            }
            
        }
       
        //Auto choice
        private void Test_Checked(object sender, RoutedEventArgs e)
        {
            auto = 1;
            using (StreamWriter w = new StreamWriter("Settings.txt", false, Encoding.GetEncoding(1251)))
            {
                w.WriteLine("Debug:");
                w.WriteLine(check.ToString());
                w.WriteLine("Fullscreen:");
                w.WriteLine(screen.ToString());
                w.WriteLine("Progressbar:");
                w.WriteLine(pb.ToString());
                w.WriteLine("Language:");
                w.WriteLine(lang.ToString());
                w.WriteLine("TypeSys:");
                w.WriteLine(type.ToString());
                w.WriteLine("Auto:");
                w.WriteLine(auto.ToString());
            }
        }

        private void Test_Unchecked(object sender, RoutedEventArgs e)
        {
            auto = 0;
            using (StreamWriter w = new StreamWriter("Settings.txt", false, Encoding.GetEncoding(1251)))
            {
                w.WriteLine("Debug:");
                w.WriteLine(check.ToString());
                w.WriteLine("Fullscreen:");
                w.WriteLine(screen.ToString());
                w.WriteLine("Progressbar:");
                w.WriteLine(pb.ToString());
                w.WriteLine("Language:");
                w.WriteLine(lang.ToString());
                w.WriteLine("TypeSys:");
                w.WriteLine(type.ToString());
                w.WriteLine("Auto:");
                w.WriteLine(auto.ToString());
            }
        }

        private void Test_MouseEnter(object sender, MouseEventArgs e)
        {
            Texter.Text = Properties.Resources.AutoT;
        }

        private void Test_MouseLeave(object sender, MouseEventArgs e)
        {
            Texter.Clear();
        }
        //Reset
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show(Properties.Resources.Box2, Properties.Resources.Sure, MessageBoxButton.YesNo, MessageBoxImage.Warning);

            switch (result)
            {
                case MessageBoxResult.Yes:
                    auto = 1;
                    type = 0;
                    lang = 0;
                    screen = 0;
                    pb = 0;
                    check = 0;
                    using (StreamWriter w = new StreamWriter("Settings.txt", false, Encoding.GetEncoding(1251)))
                    {
                        w.WriteLine("Debug:");
                        w.WriteLine(check.ToString());
                        w.WriteLine("Fullscreen:");
                        w.WriteLine(screen.ToString());
                        w.WriteLine("Progressbar:");
                        w.WriteLine(pb.ToString());
                        w.WriteLine("Language:");
                        w.WriteLine(lang.ToString());
                        w.WriteLine("TypeSys:");
                        w.WriteLine(type.ToString());
                        w.WriteLine("Auto:");
                        w.WriteLine(auto.ToString());
                    }
                    break;
                case MessageBoxResult.No:
                   
                    break;
            }
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show(Properties.Resources.Sure, Properties.Resources.Message1, MessageBoxButton.YesNo, MessageBoxImage.Warning);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    File.WriteAllText("Exit.txt", "1");
                    System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
                    Application.Current.Shutdown();
                    break;
                case MessageBoxResult.No:

                    break;
            }
         

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            CET.Show();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            try
            {
                if (CET.ex == 1)
                {
                    WrapPanel wrapPanel = new WrapPanel();
                    RadioButton rdn = new RadioButton();
                    if (CET.FP.Text != "")
                    {
                        ImageSource image = new ImageSourceConverter().ConvertFromString(CET.FP.Text) as ImageSource;
                        wrapPanel.Children.Add(new Image { Source = image, Width = 17, Height = 15 });
                    }
                    wrapPanel.Children.Add(new TextBlock { Text = CET.NameET.Text, Foreground = Brushes.White  , Name = CET.NameET.Text });
                    rdn.Name = CET.NameET.Text;
                    rdn.TabIndex = CET.tx;
                    rdn.Content = wrapPanel;
                    using (StreamWriter w = new StreamWriter("EST.txt", true, Encoding.Default))
                    {
                        w.WriteLine("Name:");
                        w.WriteLine(CET.NameET.Text);
                        w.WriteLine("ImagePath:");
                        w.WriteLine(CET.FP.Text);
                        w.WriteLine("TabIndex:");
                        w.WriteLine(CET.tx.ToString());
                    }
                    if (CET.tx > 9)
                    {
                        using (StreamWriter f = new StreamWriter(@"C:\Users\TopDesktop-1\source\repos\WarningList 1Exp\WarningList\bin\Debug\ESTData\" + CET.NameET.Text + ".txt"))
                        {
                            f.WriteLine("Buttons:");
                            f.WriteLine(CET.bx);
                            f.WriteLine("GPA:");
                            f.WriteLine(CET.GPA.SelectedIndex);
                        }
                    }
                        Tsys.Items.Add(rdn);
                    


                    CET.ex = 0;
                    CET.FP.Clear();
                    CET.NameET.Clear();
                    foreach (UIElement uI in Tsys.Items)
                    {
                        if (uI is RadioButton)
                        {
                            ((RadioButton)uI).Checked += Sys_Checked;

                        }
                    }
                }
            }
            catch(Exception exp)
            {
                Texter.Text = exp.Message;
            }
        }

        private void Tsys_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                
                if (Tsys.SelectedIndex > 9)
                {

                    int i = 0;
                        var Lines = File.ReadAllLines("EST.txt");
                    for(; i < Lines.Length; i++)
                    {
                        if(Lines[i] == ((RadioButton)Tsys.SelectedValue).Name.ToString())
                        {
                            Lines[i - 1] = " ";
                            Lines[i + 1] = " ";
                            Lines[i + 2] = " ";
                            Lines[i + 3] = " ";
                            Lines[i + 4] = " ";
                            break;
                        }
                    }
                    var newLines = Lines.Where(line => !line.Contains(((RadioButton)Tsys.SelectedValue).Name.ToString()));
                    var newLineA = newLines.Where(line => !line.Contains(Lines[i - 1]));
                    File.WriteAllLines("EST.txt", newLineA);
                    Tsys.Items.Remove(Tsys.SelectedItem);
                }
                else
                {
                    MessageBox.Show("Error", "System item cannot be deleted", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message, "Error" , MessageBoxButton.OK ,MessageBoxImage.Error);
            }
        }
    }
}
//(c)AMProgramms, 2021