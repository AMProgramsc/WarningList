﻿using System;
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
        int check = Int32.Parse(File.ReadLines("Settings.txt").Skip(1).First());
        int screen = Int32.Parse(File.ReadLines("Settings.txt").Skip(3).First());
        int pb = Int32.Parse(File.ReadLines("Settings.txt").Skip(5).First());
        int lang = Int32.Parse(File.ReadLines("Settings.txt").Skip(7).First());
        int type = Int32.Parse(File.ReadLines("Settings.txt").Skip(9).First());
        int auto = Int32.Parse(File.ReadLines("Settings.txt").Skip(11).First());
        int checkR;
        int screenR;
        int pbR;
        int langR;
        int typeR;
        public int _width =100;
        public int _height = 100;
    
        public Settings()
        {
         
            InitializeComponent();
           
     
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

        //Russian
        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            lang = 0;
            if(auto == 1)
            {
                type = 1;
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
        //English
        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            lang = 1;
            if (auto == 1)
            {
                type = 0;
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
        //France
        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {
            lang = 2;
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
        //German
        private void RadioButton_Checked_4(object sender, RoutedEventArgs e)
        {
            lang = 3;
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
        //Ukraine
        private void RadioButton_Checked_5(object sender, RoutedEventArgs e)
        {
            lang = 4;
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
        private void BY_Checked(object sender, RoutedEventArgs e)
        {
            lang = 5;
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
        private void CZ_Checked(object sender, RoutedEventArgs e)
        {
            lang = 6;
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
        private void FI_Checked(object sender, RoutedEventArgs e)
        {
            lang = 7;
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

        private void BG_Checked(object sender, RoutedEventArgs e)
        {
            lang = 8;
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

        private void DK_Checked(object sender, RoutedEventArgs e)
        {
            lang = 9;
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
        private void RadioButton_Checked_6(object sender, RoutedEventArgs e)
        {
           
                type = 0;
      
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
       
        private void RadioButton_Checked_7(object sender, RoutedEventArgs e)
        {


            type = 1;
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

        private void RadioButton_Checked_8(object sender, RoutedEventArgs e)
        { 
                type = 2;
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

        private void RadioButton_Checked_9(object sender, RoutedEventArgs e)
        {
                
                type = 3;

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

        private void RadioButton_Checked_10(object sender, RoutedEventArgs e)
        {
                type = 4;

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

        private void BE_Checked(object sender, RoutedEventArgs e)
        {
            type = 5;


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
        private void CS_Checked(object sender, RoutedEventArgs e)
        {
            type = 6;
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
        private void fi_Checked_1(object sender, RoutedEventArgs e)
        {
            type = 7;
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

        private void bg_Checked_1(object sender, RoutedEventArgs e)
        {
            type = 8;
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

        private void DA_Checked(object sender, RoutedEventArgs e)
        {
            type = 9;
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

    }
}
//(c)AMProgramms, 2021