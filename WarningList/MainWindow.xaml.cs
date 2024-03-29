﻿using System;
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
using GongSolutions.Wpf.DragDrop;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    //Copyright (c) 2021 by AMProgramms
    //All rights reserved
    //Published under the terms of the Apache 2.0 license , More details in license.md file
    public partial class MainWindow : Window
    {
        UserInfo user = new UserInfo();

        SernameD snr = new SernameD();
     
        NameD n = new NameD();


        MessageBoxResult SelectionChangedResult;
        double value, valueS, valueN;
        double ClickS;
        double NumberN;
        double result;
        double warning = 0;
        double TotalResult;
        string sizeG, sizeH;
        string colorPick = "Black";
        string saveS = "Save.txt";
        string countType;

        bool delete = false;
        bool edit = false;
        bool name = false;
        bool drop = false;
        bool res = false;
        bool iscountWarnString = false;
        int localsymbol;
        int Count;
        int countS , countE;
        int exit = 0;
        int cls, cls2;
        int debugCheck = 0;
        int lang = 0;
        int type = 0;
        int sizeS = 0, sizeC = 0;
        int mainE, file;
        int summarymodeCheck;
        int backgroundCheck;
        int fontType;

        public void WarningResult(double resWarn, int countWarn, string typeWarn)
        {

                GEN.Text = Properties.Resources.Gen + result + "\r\n";
                GEN.Text += Properties.Resources.Gen2 + typeWarn + "\r\n";

                for (; warning < resWarn;)
                {
                    warning = (valueS + countWarn) / (NumberN + 1);
                    valueS += countWarn;
                    NumberN += 1;
                if (iscountWarnString == false)
                {
                    GEN.Text += Properties.Resources.GenN + countWarn + Properties.Resources.GenF + warning + "\r\n";
                }
                else
                {
                    GEN.Text += Properties.Resources.GenN + countType + Properties.Resources.GenF + warning + "\r\n";
                }
                }
                warning = 0;
            iscountWarnString = false;
        }
        public void getGPAEng()
        {
            D1.Content = "1";
            D2.Content = "2";
            D2.Background = Brushes.HotPink;
            D3.Content = "3";
            D3.Background = Brushes.Orange;
            C1.Content = "4";
            C1.Background = Brushes.Yellow;
            C2.Visibility = Visibility.Visible;
            C3.Visibility = Visibility.Visible;
            B1.Visibility = Visibility.Visible;
            int iter = 0;
            foreach (UIElement uI in Buttons.Children)
            {
                if(uI is TextBlock)
                {
                    ((TextBlock)uI).Visibility = Visibility.Visible;
                    iter++;
                }
                if(iter == 7)
                {
                    break;
                }
            }
            Score.Height = 210;
            Score.Margin = new Thickness(162, 197, 0, 0);
        }
        public void getGPAGer()
        {
            D1.Content = "0";
            D2.Content = "3";
            D2.Background = Brushes.Orange;
            D3.Content = "6";
            D3.Background = Brushes.Yellow;
            C1.Content = "9";
            C1.Background = Brushes.Green;
            C2.Content = "12";
            C2.Background = Brushes.Cyan;
            C3.Content = "15";
            C3.Background = Brushes.Blue;

            T1.Visibility = Visibility.Visible;
            T1.Text = "(6)";
            T2.Visibility = Visibility.Visible;
            T2.Text = "(5)";
            T3.Visibility = Visibility.Visible;
            T3.Text = "(4)";
            T4.Visibility = Visibility.Visible;
            T4.Text = "(3)";
            T5.Visibility = Visibility.Visible;
            T5.Text = "(2)";
            T6.Visibility = Visibility.Visible;
            T6.Text = "(1)";
        }
        public void getGPAFra()
        {
            D1.Content = "1";
            D2.Content = "2";
            D3.Content = "3";
            C1.Content = "4";
            C1.Background = Brushes.Cyan;
            C2.Content = "5";
            C2.Background = Brushes.Blue;
            T1.Visibility = Visibility.Visible;
            T1.Text = "(<7)";
            T1.Width = 22;
            T2.Visibility = Visibility.Visible;
            T2.Text = "(9-7)";
            T2.Width = 25;
            T3.Visibility = Visibility.Visible;
            T3.Text = "(13-10)";
            T3.Width = 38;
            T4.Visibility = Visibility.Visible;
            T4.Text = "(16-14)";
            T4.Width = 38;
            T5.Visibility = Visibility.Visible;
            T5.Text = "(20-17)";

            T5.Width = 38;
        }
        public void getGPADen()
        {
            D1.Content = "-3";
            D2.Content = "0";
            D2.Background = Brushes.HotPink;
            D3.Content = "2";
            D3.Background = Brushes.Orange;
            C1.Content = "4";
            C1.Background = Brushes.Yellow;
            C2.Content = "7";
            C2.Background = Brushes.Green;
            C3.Content = "10";
            C3.Background = Brushes.Cyan;
            B1.Content = "12";
            B1.Background = Brushes.Blue;
            T1.Text = "(F)";
            T1.Visibility = Visibility.Visible;
            T2.Text = "(Fx)";
            T2.Visibility = Visibility.Visible;
            T3.Text = "(E)";
            T3.Visibility = Visibility.Visible;
            T4.Text = "(D)";
            T4.Visibility = Visibility.Visible;
            T5.Text = "(C)";
            T5.Visibility = Visibility.Visible;
            T6.Text = "(B)";
            T6.Visibility = Visibility.Visible;
            T7.Text = "(A)";
            T7.Visibility = Visibility.Visible;
        }
        
        public void RussianType()
        {
            if (type == 0)
            {
                if (result <= 2.5)
                {
                    WarningResult(2.6,3,"2");
                }
                else if (result <= 3.5)
                {
                    WarningResult(3.6, 4, "3");
                }
                else if (result <= 4.5)
                {
                    WarningResult(4.6, 5, "4");
                }
                else
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen4 + "\r\n";
                }
                Lister.Items.RemoveAt(Subjects.SelectedIndex);
                Lister.Items.Insert(Subjects.SelectedIndex, new ListBoxItem { Content = result });
            }
        }
        public void EnglishType()
        {
            if (type == 1)
            {
                string[] valueSymbol= new string[]{"F","E","D", "C","B" ,"A","*A" };
               
                iscountWarnString = true;
                if (result < 2)
                {
                    countType = "E";
                    localsymbol = 0;
                    WarningResult(1.5,2,"F");
                }
                else if (result < 3)
                {
                    countType = "D";
                    localsymbol = 1;
                    WarningResult(2.5, 3, "E");
                }
                else if (result < 4)
                {
                    countType = "C";
                    localsymbol = 2;
                    WarningResult(3.5, 4, "D");
                }
                else if (result < 5)
                {
                    countType = "B";
                    localsymbol = 3;
                    WarningResult(4.5, 5, "C");
                }
                else if (result <= 6)
                {
                    countType = "A";
                    localsymbol = 4;
                    WarningResult(5.5, 6, "B");
                }
                else if (result < 7)
                {
                    countType = "A";
                    localsymbol = 5;
                    WarningResult(6.5, 7, "A*");
                }
                else
                {
                    localsymbol = 6;
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen4 + " - " + "A*" + "\r\n";

                }
                Lister.Items.RemoveAt(Subjects.SelectedIndex);
                Lister.Items.Insert(Subjects.SelectedIndex, new ListBoxItem { Content = valueSymbol[localsymbol] });
            }
        }   
        public void FrenchType()
        {

            if (type == 2)
            {
                int countFrench = 7;
                iscountWarnString = true;
                if (result <= 1.2)
                {
                    countType = "8";
                    countFrench = 7;
                    WarningResult(1.3, 2, "<7");
                }
                else if (result > 1.2 && result < 1.5)
                {
                    countType = "9";
                    countFrench = 8;
                    WarningResult(1.6, 2, "8");
                }
                else if (result < 2 && result > 1.5 && result < 1.9)
                {
                    countType = "10";
                    countFrench = 9;
                    WarningResult(1.9, 2, "9");
                }
                else if (result < 2 && result >= 1.9)
                {
                    countType = "11";
                    countFrench = 10;
                    WarningResult(2, 2, "10");
                }
                else if (result < 2.5)
                {
                    countType = "12";
                    countFrench = 11;
                    WarningResult(2.6, 3, "11");
                }
                else if (result < 3 && result > 2.5 && result < 2.9)
                {
                    countType = "13";
                    countFrench = 12;
                    WarningResult(2.9, 3, "12");
                }
                else if (result < 3 && result >= 2.9)
                {
                    countType = "14";
                    countFrench = 13;
                    WarningResult(3, 3, "13");
                }
                else if (result < 3.5)
                {
                    countType = "15";
                    countFrench = 14;
                    WarningResult(3.5, 4, "14");
                }
                else if (result < 4 && result > 3.5 && result < 3.9)
                {
                    countType = "16";
                    countFrench = 15;
                    WarningResult(3.9, 4, "15");
                }
                else if (result < 4 && result >= 3.9)
                {
                    countType = "17";
                    countFrench = 16;
                    WarningResult(4, 4, "16");
                }
                else if (result < 4.5)
                {
                    countType = "18";
                    countFrench = 17;
                    WarningResult(4.5, 5, "17");
                }
                else if (result < 5 && result > 4.5 && result < 4.9)
                {
                    countType = "19";
                    countFrench = 18;
                    WarningResult(4.9, 5, "18");
                }
                else if (result < 5 && result >= 4.9)
                {
                    countType = "20";
                    countFrench = 19;
                    WarningResult(5, 5, "19");
                }
                else
                {
                    countFrench = 20;
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen4 + " - " + "20" + "\r\n";

                }
                

                Lister.Items.RemoveAt(Subjects.SelectedIndex);
                Lister.Items.Insert(Subjects.SelectedIndex, new ListBoxItem { Content = countFrench });
            
            }
        }
        public void GermanyType()
        {
            if (type == 3)
            {
                int countGermany = 6;
                iscountWarnString = true;
                if (result < 3)
                {
                    countType = "5";
                    countGermany = 6;
                    WarningResult(1.5, 3, "6");
                }
                else if (result <= 6 && result >= 3)
                {
                    countType = "4";
                    countGermany = 5;
                    WarningResult(3, 6, "5");
                }
                else if (result <= 9 && result >= 6)
                {
                    countType = "3";
                    countGermany = 4;
                    WarningResult(4.5, 9, "4");
                }
                else if (result <= 12 && result >= 9)
                {
                    countType = "2";
                    countGermany = 3;
                    WarningResult(6, 12, "3");
                }
                else if (result <= 15 && result >= 12)
                {
                    countType = "1";
                    countGermany = 2;
                    WarningResult(7.5, 15, "2");
                }
                else
                {
                    countGermany = 1;
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen4 + " - " + "1" + "\r\n";

                }
    
                Lister.Items.RemoveAt(Subjects.SelectedIndex);
                Lister.Items.Insert(Subjects.SelectedIndex, new ListBoxItem { Content = countGermany });
            }
        }
        public void UkraineType()
        {
            if (type == 4)
            {
                if (result <= 1.5)
                {
                    WarningResult(1.6, 2, "1");
                }
                else if (result <= 2.5)
                {
                    WarningResult(2.6, 3, "2");
                }
                else if (result <= 3.5)
                {
                    WarningResult(3.6, 4, "3");
                }
                else if (result <= 4.5)
                {
                    WarningResult(4.6, 5, "4");
                }
                else if (result <= 5.5)
                {
                    WarningResult(5.6, 6, "5");
                }
                else if (result <= 6.5)
                {
                    WarningResult(6.6, 7, "6");
                }
                else if (result <= 7.5)
                {
                    WarningResult(7.6, 8, "7");
                }
                else if (result <= 8.5)
                {
                    WarningResult(8.6, 9, "8");
                }
                else if (result <= 9.5)
                {
                    WarningResult(9.6, 10, "9");
                }
                else if (result <= 10.5)
                {
                    WarningResult(10.6, 11, "10");
                }
                else if (result <= 11.5)
                {
                    WarningResult(11.6, 12, "11");
                }
                else
                {

                    GEN.Text = Properties.Resources.Gen + "12" + "\r\n";
                    GEN.Text += Properties.Resources.Gen4 + "\r\n";

                }
                Lister.Items.RemoveAt(Subjects.SelectedIndex);
                Lister.Items.Insert(Subjects.SelectedIndex, new ListBoxItem { Content = result });
            }
        }
        public void BelarusType()
        {
            if (type == 5)
            {
                if (result <= 1.5)
                {

                    WarningResult(1.6, 2, result.ToString());
                }
                else if (result <= 2.5)
                {
                    WarningResult(2.6, 3, result.ToString());

                }
                else if (result <= 3.5)
                {
                    WarningResult(3.6, 4, result.ToString());
                }
                else if (result <= 4.5)
                {
                    WarningResult(4.6, 5, result.ToString());
                }
                else if (result <= 5.5)
                {
                    WarningResult(5.6, 6, result.ToString());
                }
                else if (result <= 6.5)
                {
                    WarningResult(6.6, 7, result.ToString());
                }
                else if (result <= 7.5)
                {
                    WarningResult(7.6, 8, result.ToString());
                }
                else if (result <= 8.5)
                {
                    WarningResult(8.6, 9, result.ToString());
                }
                else if (result <= 9.5)
                {
                    WarningResult(9.6, 10, result.ToString());
                }
                else
                {

                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen4 + "\r\n";

                }
                Lister.Items.RemoveAt(Subjects.SelectedIndex);
                Lister.Items.Insert(Subjects.SelectedIndex, new ListBoxItem { Content = result });
            }
        }
        public void CzechType()
        {
            if (type == 6)
            {
                if (result < 1.5)
                {
                    WarningResult(1.5, 2, "2");
                }
                else if (result < 2.5)
                {
                    WarningResult(2.6, 3, "3");
                }
                else if (result < 3.5)
                {
                    WarningResult(3.6, 4, "4");
                }
                else if (result < 4.5)
                {
                    WarningResult(4.6, 5, "5");
                }
                else
                {

                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen4 + " - " + "5" + "\r\n";

                }

                Lister.Items.RemoveAt(Subjects.SelectedIndex);
                Lister.Items.Insert(Subjects.SelectedIndex, new ListBoxItem { Content = result });
            }
        }
        public void FinlandType()
        {
            if(type == 7)
            {
                iscountWarnString = true;
                if (result <= 4.5)
                {
                    countType = "5";
                    WarningResult(4.5, 5, "4");
                }
                else if (result <= 5.5)
                {
                    countType = "6";
                    WarningResult(5.6, 6, "5");
                }
                else if (result <= 6.5)
                {
                    countType = "7";
                    WarningResult(6.6, 7, "6");
                }
                else if (result <= 7.5)
                {
                    countType = "8";
                    WarningResult(7.6, 8, "7");
                }
                else if (result <= 8.5)
                {
                    countType = "9";
                    WarningResult(8.6, 9, "8");
                }
                else if (result <= 9.5)
                {
                    countType = "10";
                    WarningResult(9.6, 10, "9");
                }
                else
                {

                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen4 + "\r\n";

                }
                Lister.Items.RemoveAt(Subjects.SelectedIndex);
                Lister.Items.Insert(Subjects.SelectedIndex, new ListBoxItem { Content = result });
            }
        }
        public void BulgariaType()
        {
            if (type == 8)
            {
                if (result < 2.5)
                {
                    WarningResult(2.6, 3, "2");
                }
                else if (result < 3.5)
                {
                    WarningResult(3.6, 4, "3");
                }
                else if (result < 4.5)
                {
                    WarningResult(4.6, 5, "4");
                }
                else if (result < 5.5)
                {
                    WarningResult(5.6, 6, "5");
                }
                else
                {

                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen4 + " - " + "6" + "\r\n";

                }

                Lister.Items.RemoveAt(Subjects.SelectedIndex);
                Lister.Items.Insert(Subjects.SelectedIndex, new ListBoxItem { Content = result });
            }
        }
        public void DenmarkType()
        {
            if(type == 9)
            {
                string[] valueSymbol = new string[] { "F", "Fx", "E", "D", "C", "B", "A" };
                int countDenmark = 0;
                iscountWarnString = true;
                if (result < 0)
                {
                    countType = "Fx";
                    countDenmark = 0;
                    WarningResult(0, 2, "F");
                }
                else if (result < 2)
                {
                    countType = "E";
                    countDenmark = 1;
                    WarningResult(1.5, 2, "Fx");
                }
                else if (result < 4)
                {
                    countType = "D";
                    countDenmark = 2;
                    WarningResult(2.5, 4, "E");
                }
                else if (result < 7)
                {
                    countType = "C";
                    countDenmark = 3;
                    WarningResult(3.5, 7, "D");
                }
                else if (result < 10)
                {
                    countType = "B";
                    countDenmark = 4;
                    WarningResult(5, 10, "C");
                }
                else if (result < 12)
                {
                    countType = "A";
                    countDenmark = 5;
                    WarningResult(6, 12, "B");
                }
                else
                {
                    countDenmark = 6;
                    GEN.Text = Properties.Resources.Gen + "A" + "\r\n";
                    GEN.Text += Properties.Resources.Gen4 + "\r\n";

                }
                
      
                Lister.Items.RemoveAt(Subjects.SelectedIndex);
                Lister.Items.Insert(Subjects.SelectedIndex, new ListBoxItem { Content =  valueSymbol[countDenmark]}); 
            }
        }
        public void CustomType()
        {
            if (type > 9)
            {
                    if (result <= 1.5)
                    {
                        WarningResult(1.6, 2, result.ToString());
                    }
                    else if (result <= 2.5)
                    {
                        WarningResult(2.6, 3, result.ToString());

                    }
                    else if (result <= 3.5)
                    {
                        WarningResult(3.6, 4, result.ToString());
                    }
                    else if (result <= 4.5)
                    {
                        WarningResult(4.6, 5, result.ToString());
                    }
                    else if (result <= 5.5)
                    {
                        WarningResult(5.6, 6, result.ToString());
                    }
                    else if (result <= 6.5)
                    {
                        WarningResult(6.6, 7, result.ToString());
                    }
                    else if (result <= 7.5)
                    {
                        WarningResult(7.6, 8, result.ToString());
                    }
                    else if (result <= 8.5)
                    {
                        WarningResult(8.6, 9, result.ToString());
                    }
                    else if (result <= 9.5)
                    {
                        WarningResult(9.6, 10, result.ToString());
                    }
                    else if (result <= 10.5)
                    {
                        WarningResult(10.6, 11, result.ToString());
                    }
                    else if (result <= 11.5)
                    {
                        WarningResult(11.6, 12, result.ToString());
                    }
                    else
                    {

                        GEN.Text = Properties.Resources.Gen + result + "\r\n";
                        GEN.Text += Properties.Resources.Gen4 + "\r\n";

                    }
                    Lister.Items.RemoveAt(Subjects.SelectedIndex);
                    Lister.Items.Insert(Subjects.SelectedIndex, new ListBoxItem { Content = result });
            }
        }

        public void BackgroundCheck()
        {
            backgroundCheck = 1;
            foreach (UIElement backgroundColor in Root.Children)
            {
                if (backgroundColor is TextBox)
                {
                    ((TextBox)backgroundColor).Foreground = Brushes.White;
                }
            }
            Root.Background = Brushes.Black;
            Lister.Foreground = Brushes.White;
            Score.Foreground = Brushes.White;
            
        
        }
        public void BackgroundUnCheck()
        {
            backgroundCheck = 0;
            
            
            foreach (UIElement backgroundColor in Root.Children)
            {
                if (backgroundColor is TextBox)
                {
                    ((TextBox)backgroundColor).Foreground = Brushes.Black;
                }

            }
            Root.Background = Brushes.White;
            Lister.Foreground = Brushes.Black;
            Score.Foreground = Brushes.Black;
        }

        public void Bold()
        {
            fontType = 1;
            foreach (UIElement textbold in Root.Children)
            {
                if (textbold is TextBox)
                {
                    ((TextBox)textbold).FontWeight = FontWeights.Bold;
                }

            }
            Subjects.FontWeight = FontWeights.Bold;
            Menu.FontWeight = FontWeights.Bold;
            Lister.FontWeight = FontWeights.Bold; 
            Score.FontWeight = FontWeights.Bold;
            Namer.Height = 40;
            Result.Margin = new Thickness(262, 223, 0, 0);
            Tres.Margin = new Thickness(262, 246, 0, 0);
        }
        public void Italic()
        {
            fontType = 2;
            foreach (UIElement textitalic in Root.Children)
            {
                if (textitalic is TextBox)
                {
                    ((TextBox)textitalic).FontStyle = FontStyles.Italic;
                }

            }
            Subjects.FontStyle = FontStyles.Italic;
            Menu.FontStyle = FontStyles.Italic;
            Lister.FontStyle = FontStyles.Italic;
            Score.FontStyle = FontStyles.Italic;
        }
        public void Underline()
        {
            fontType = 3;
            foreach (UIElement textunderline in Root.Children)
            {
                if (textunderline is TextBox)
                {
                    ((TextBox)textunderline).TextDecorations = TextDecorations.Underline;
                }

            }
        }
        public void Normal()
        {
            fontType = 0;
            foreach (UIElement textnormal in Root.Children)
            {
                if (textnormal is TextBox)
                {
                    ((TextBox)textnormal).FontWeight = FontWeights.Normal;
                    ((TextBox)textnormal).FontStyle = FontStyles.Normal;
                    ((TextBox)textnormal).TextDecorations = null;
                }

            }
            Subjects.FontWeight = FontWeights.Normal;
            Menu.FontWeight = FontWeights.Normal;
            Lister.FontWeight = FontWeights.Normal;
            Score.FontWeight = FontWeights.Normal;

            Subjects.FontStyle = FontStyles.Normal;
            Menu.FontStyle = FontStyles.Normal;
            Lister.FontStyle = FontStyles.Normal;
            Score.FontStyle = FontStyles.Normal;
 
        }
        
        public void ColorPickSelectColor()
        {
            SolidColorBrush ck = (SolidColorBrush)new BrushConverter().ConvertFromString(colorPick);
            foreach (UIElement textcolor in Root.Children)
            {
                if (textcolor is TextBox)
                {
                    ((TextBox)textcolor).Foreground = ck;
                }

            }
            Lister.Foreground = ck;
            Score.Foreground = ck;
        }

        void Res()
        {
            // Total Result
            if (Count == sizeS)
            {

                TotalResult /= Count;
                TotalResult = Math.Round(TotalResult, 2);
                //Russian
                if (type == 0)
                {
                    if (TotalResult <= 2.5)
                    {
                        Tres.Foreground = Brushes.Red;
                        Tres.Text = TotalResult.ToString();
                    }
                    else if (TotalResult <= 3.5)
                    {
                        Tres.Foreground = Brushes.Orange;
                        Tres.Text = TotalResult.ToString();
                    }
                    else if (TotalResult <= 4.5)
                    {
                        Tres.Foreground = Brushes.Green;
                        Tres.Text = TotalResult.ToString();
                    }
                    else if (TotalResult <= 5)
                    {
                        Tres.Foreground = Brushes.LightBlue;
                        Tres.Text = TotalResult.ToString();
                    }
                    else
                    {
                        Tres.Foreground = Brushes.DarkRed;
                        Tres.Text = "-";
                    }
                    
                }
                //English GPA
                if (type == 1)
                {

                    if (TotalResult <= 1.5)
                    {
                        Tres.Foreground = Brushes.Red;
                        Tres.Text = "F";
                    }
                    else if (TotalResult > 1.5)
                    {
                        Tres.Foreground = Brushes.HotPink;
                        Tres.Text = "E";
                    }
                    else if (TotalResult <= 2.5)
                    {
                        Tres.Foreground = Brushes.Orange;
                        Tres.Text = "D";
                    }
                    else if (TotalResult < 3 && TotalResult > 2.5)
                    {
                        Tres.Foreground = Brushes.DarkOrange;
                        Tres.Text = "D+";
                    }
                    else if (TotalResult <= 3.5)
                    {
                        Tres.Foreground = Brushes.Yellow;
                        Tres.Text = "C";
                    }
                    else if (TotalResult < 4 && TotalResult > 3.5)
                    {
                        Tres.Foreground = Brushes.Yellow;
                        Tres.Text = "C+";
                    }
                    else if (TotalResult <= 4.5)
                    {
                        Tres.Foreground = Brushes.Green;
                        Tres.Text = "B";
                    }
                    else if (TotalResult < 5 && TotalResult > 4.5)
                    {
                        Tres.Foreground = Brushes.DarkOliveGreen;
                        Tres.Text = "B+";
                    }
                    else if (TotalResult <= 5.5)
                    {
                        Tres.Foreground = Brushes.Cyan;
                        Tres.Text = "A";
                    }
                    else if (TotalResult > 5.5)
                    {
                        Tres.Foreground = Brushes.Blue;
                        Tres.Text = "A*";
                    }
                }
                //France
                if (type == 2)
                {
                    if (result <= 1.2)
                    {
                        Tres.Foreground = Brushes.Red;
                        Tres.Text = "<7";
                    }
                    if (result < 1.5 && result > 1.2)
                    {
                        Tres.Foreground = Brushes.HotPink;
                        Tres.Text = "8";
                    }
                    else if (result < 2 && result >= 1.5)
                    {
                        Tres.Foreground = Brushes.HotPink;
                        Tres.Text = "9";
                    }
                    else if (result < 2 && result >= 1.9)
                    {
                        Tres.Foreground = Brushes.Orange;
                        Tres.Text = "10";
                    }
                    else if (result < 2.5)
                    {
                        Tres.Foreground = Brushes.Orange;
                        Tres.Text = "11";
                    }
                    else if (result < 3 && result >= 2.5)
                    {
                        Tres.Foreground = Brushes.Yellow;
                        Tres.Text = "12";
                    }
                    else if (result < 3 && result >= 2.9)
                    {
                        Tres.Foreground = Brushes.Yellow;
                        Tres.Text = "13";
                    }
                    else if (result < 3.5)
                    {
                        Tres.Foreground = Brushes.GreenYellow;
                        Tres.Text = "14";
                    }
                    else if (result < 4 && result >= 3.5)
                    {
                        Tres.Foreground = Brushes.Green;
                        Tres.Text = "15";
                    }
                    else if (result < 4 && result >= 3.9)
                    {
                        Tres.Foreground = Brushes.Green;
                        Tres.Text = "16";
                    }
                    else if (result < 4.5)
                    {
                        Tres.Foreground = Brushes.Cyan;
                        Tres.Text = "17";
                    }
                    else if (result < 5 && result >= 4.5)
                    {
                        Tres.Foreground = Brushes.DarkCyan;
                        Tres.Text = "18";
                    }
                    else if (result < 5 && result >= 4.9)
                    {
                        Tres.Foreground = Brushes.Blue;
                        Tres.Text = "19";
                    }
                    else
                    {
                        Tres.Foreground = Brushes.Blue;
                        Tres.Text = "20";
                    }
                }
                //Germany
                if (type == 3)
                {
                    if (result < 3)
                    {
                        Tres.Foreground = Brushes.Red;
                        Tres.Text = "6";
                    }
                    else if (result <= 6 && result >= 3)
                    {
                        Tres.Foreground = Brushes.Orange;
                        Tres.Text = "5";
                    }
                    else if (result <= 9 && result >= 6)
                    {
                        Tres.Foreground = Brushes.Yellow;
                        Tres.Text = "4";
                    }
                    else if (result <= 12 && result >= 9)
                    {
                        Tres.Foreground = Brushes.Green;
                        Tres.Text = "3";
                    }
                    else if (result <= 15 && result >= 12)
                    {
                        Tres.Foreground = Brushes.Cyan;
                        Tres.Text = "2";
                    }
                    else
                    {
                        Tres.Foreground = Brushes.Blue;
                        Tres.Text = "1";
                    }
                }
                //Ukraine
                if (type == 4 || type > 9)
                {
                    if (TotalResult <= 1.5)
                    {
                        Tres.Foreground = Brushes.Red;
                        Tres.Text = TotalResult.ToString();
                    }
                    if (TotalResult <= 2.5)
                    {
                        Tres.Foreground = Brushes.Red;
                        Tres.Text = TotalResult.ToString();
                    }
                    if (TotalResult <= 3.5)
                    {
                        Tres.Foreground = Brushes.Red;
                        Tres.Text = TotalResult.ToString();
                    }
                    else if (TotalResult <= 4.5)
                    {
                        Tres.Foreground = Brushes.Yellow;
                        Tres.Text = TotalResult.ToString();
                    }
                    else if (TotalResult <= 5.5)
                    {
                        Tres.Foreground = Brushes.Yellow;
                        Tres.Text = TotalResult.ToString();
                    }
                    else if (TotalResult <= 6.5)
                    {
                        Tres.Foreground = Brushes.Yellow;
                        Tres.Text = TotalResult.ToString();
                    }
                    else if (TotalResult <= 7.5)
                    {
                        Tres.Foreground = Brushes.GreenYellow;
                        Tres.Text = TotalResult.ToString();
                    }
                    else if (TotalResult <= 8.5)
                    {
                        Tres.Foreground = Brushes.Green;
                        Tres.Text = TotalResult.ToString();
                    }
                    else if (TotalResult <= 9.5)
                    {
                        Tres.Foreground = Brushes.DarkGreen;
                        Tres.Text = TotalResult.ToString();
                    }
                    else if (TotalResult <= 10.5)
                    {
                        Tres.Foreground = Brushes.Cyan;
                        Tres.Text = TotalResult.ToString();
                    }
                    else if (TotalResult <= 11.5)
                    {
                        Tres.Foreground = Brushes.Blue;
                        Tres.Text = TotalResult.ToString();
                    }
                    else if (TotalResult <= 12)
                    {
                        Tres.Foreground = Brushes.DarkBlue;
                        Tres.Text = TotalResult.ToString();
                    }
                    else
                    {
                        Tres.Foreground = Brushes.DarkRed;
                        Tres.Text = "-";
                    }
                }
                //Belarus
                if (type == 5)
                {
                    if (TotalResult <= 1.5)
                    {
                        Tres.Foreground = Brushes.Red;
                        Tres.Text = TotalResult.ToString();
                    }
                    if (TotalResult <= 2.5)
                    {
                        Tres.Foreground = Brushes.HotPink;
                        Tres.Text = TotalResult.ToString();
                    }
                    if (TotalResult <= 3.5)
                    {
                        Tres.Foreground = Brushes.DarkOrange;
                        Tres.Text = TotalResult.ToString();
                    }
                    else if (TotalResult <= 4.5)
                    {
                        Tres.Foreground = Brushes.Orange;
                        Tres.Text = TotalResult.ToString();
                    }
                    else if (TotalResult <= 5.5)
                    {
                        Tres.Foreground = Brushes.Yellow;
                        Tres.Text = TotalResult.ToString();
                    }
                    else if (TotalResult <= 6.5)
                    {
                        Tres.Foreground = Brushes.GreenYellow;
                        Tres.Text = TotalResult.ToString();
                    }
                    else if (TotalResult <= 7.5)
                    {
                        Tres.Foreground = Brushes.Green;
                        Tres.Text = TotalResult.ToString();
                    }
                    else if (TotalResult <= 8.5)
                    {
                        Tres.Foreground = Brushes.Cyan;
                        Tres.Text = TotalResult.ToString();
                    }
                    else if (TotalResult <= 9.5)
                    {
                        Tres.Foreground = Brushes.Blue;
                        Tres.Text = TotalResult.ToString();
                    }


                    else
                    {
                        Tres.Foreground = Brushes.DarkRed;
                        Tres.Text = "-";
                    }
                }
                //Czech
                if (type == 6)
                {
                    if (TotalResult <= 1.5)
                    {
                        Tres.Foreground = Brushes.Red;
                        Tres.Text = TotalResult.ToString();
                    }
                    if (TotalResult <= 2.5)
                    {
                        Tres.Foreground = Brushes.Red;
                        Tres.Text = TotalResult.ToString();
                    }
                    else if (TotalResult <= 3.5)
                    {
                        Tres.Foreground = Brushes.Orange;
                        Tres.Text = TotalResult.ToString();
                    }
                    else if (TotalResult <= 4.5)
                    {
                        Tres.Foreground = Brushes.Green;
                        Tres.Text = TotalResult.ToString();
                    }
                    else if (TotalResult <= 5)
                    {
                        Tres.Foreground = Brushes.LightBlue;
                        Tres.Text = TotalResult.ToString();
                    }
                    else
                    {
                        Tres.Foreground = Brushes.DarkRed;
                        Tres.Text = "-";
                    }
                }
                //Finland
                if (type == 7)
                {
                    if (TotalResult <= 4.5)
                    {
                        Tres.Foreground = Brushes.Red;
                        Tres.Text = TotalResult.ToString();
                    }
                    else if (TotalResult <= 5.5)
                    {
                        Tres.Foreground = Brushes.Orange;
                        Tres.Text = TotalResult.ToString();
                    }
                    else if (TotalResult <= 6.5)
                    {
                        Tres.Foreground = Brushes.Yellow;
                        Tres.Text = TotalResult.ToString();
                    }
                    else if (TotalResult <= 7.5)
                    {
                        Tres.Foreground = Brushes.Green;
                        Tres.Text = TotalResult.ToString();
                    }
                    else if (TotalResult <= 8.5)
                    {
                        Tres.Foreground = Brushes.Cyan;
                        Tres.Text = TotalResult.ToString();
                    }
                    else if (TotalResult <= 9.5)
                    {
                        Tres.Foreground = Brushes.Blue;
                        Tres.Text = TotalResult.ToString();
                    }
                    else
                    {
                        Tres.Foreground = Brushes.DarkRed;
                        Tres.Text = "-";
                    }
                }
                //Bulgaria
                if (type == 8)
                {
                    if (TotalResult <= 2.5)
                    {
                        Tres.Foreground = Brushes.Red;
                        Tres.Text = TotalResult.ToString();
                    }
                    if (TotalResult <= 3.5)
                    {
                        Tres.Foreground = Brushes.Red;
                        Tres.Text = TotalResult.ToString();
                    }
                    else if (TotalResult <= 4.5)
                    {
                        Tres.Foreground = Brushes.Orange;
                        Tres.Text = TotalResult.ToString();
                    }
                    else if (TotalResult <= 5.5)
                    {
                        Tres.Foreground = Brushes.Green;
                        Tres.Text = TotalResult.ToString();
                    }
                    else
                    {
                        Tres.Foreground = Brushes.DarkRed;
                        Tres.Text = "-";
                    }
                }
                //Denmark
                if (type == 9)
                {
                    if (TotalResult < 0)
                    {
                        Tres.Foreground = Brushes.Red;
                        Tres.Text = "F";
                    }
                    else if (TotalResult < 2)
                    {
                        Tres.Foreground = Brushes.HotPink;
                        Tres.Text = "Fx";
                    }
                    else if (TotalResult < 4)
                    {
                        Tres.Foreground = Brushes.Orange;
                        Tres.Text = "E";
                    }
                    else if (TotalResult < 7)
                    {
                        Tres.Foreground = Brushes.Yellow;
                        Tres.Text = "D";
                    }
                    else if (TotalResult < 10)
                    {
                        Tres.Foreground = Brushes.Green;
                        Tres.Text = "C";
                    }
                    else if (TotalResult < 12)
                    {
                        Tres.Foreground = Brushes.Cyan;
                        Tres.Text = "B";
                    }
                    else if (TotalResult == 12)
                    {
                        Tres.Foreground = Brushes.Blue;
                        Tres.Text = "A";
                    }
                    else
                    {
                        Tres.Foreground = Brushes.DarkRed;
                        Tres.Text = "-";
                    }
                }
            }
        }
        public MainWindow()
        {
            lang = Int32.Parse(File.ReadLines("Settings.txt").Skip(7).First());
            string[] langResourcesName = new string[]{"en-US","ru-RU", "fr-FR","de-DE","uk-UA","be-BY","cs-CZ","fi-FI","bg-BG","da-DK" };

            System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo(langResourcesName[lang]);

            InitializeComponent();
            File.WriteAllText("Exit.txt", "0");
            debugCheck = Int32.Parse(File.ReadLines("Settings.txt").Skip(1).First());
            type = Int32.Parse(File.ReadLines("Settings.txt").Skip(9).First());
           summarymodeCheck = Int32.Parse(File.ReadLines("Settings.txt").Skip(13).First());
            ColorPick.IsEnabled = false;
            ColorPick.Visibility = Visibility.Hidden;
            Namer.IsEnabled = false;
            Subjects.IsEnabled = false;
            EnterC.IsEnabled = false;
            Menu.IsEnabled = false;
            Edit.IsEnabled = false;
            Delete.IsEnabled = false;
            Color.IsEnabled = false;
            //English
            if (type == 1)
            {

                C2.Visibility = Visibility.Visible;
                C3.Visibility = Visibility.Visible;
                B1.Visibility = Visibility.Visible;

                getGPAEng();

                Score.Height = 210;
                Score.Margin = new Thickness(162, 197, 0, 0);
            }
            //French
            if (type == 2)
            {

                C2.Visibility = Visibility.Visible;

                getGPAFra();
               
                T5.Width = 38;
                Score.Height = 255;
                Score.Margin = new Thickness(162, 152, 0, 0);
            }
            //German
            if (type == 3)
            {

                C3.Visibility = Visibility.Visible;
                C2.Visibility = Visibility.Visible;

                getGPAGer();
               
                Score.Height = 235;
                Score.Margin = new Thickness(162, 172, 0, 0);
            }
            //Ukraine
            if (type == 4)
            {
                D1.Content = "1";
                D2.Content = "2";
                D2.Background = Brushes.HotPink;
                D3.Content = "3";
                D3.Background = Brushes.Pink;
                C1.Content = "4";
                C1.Background = Brushes.DarkOrange;
                C2.Content = "5";
                C2.Background = Brushes.Orange;
                C3.Content = "6";
                C3.Background = Brushes.Yellow;
                B1.Content = "7";
                B1.Background = Brushes.GreenYellow;
                B2.Content = "8";
                B2.Background = Brushes.LightGreen;
                B3.Content = "9";
                B3.Background = Brushes.DarkGreen;
                A1.Content = "10";
                A1.Background = Brushes.Cyan;
                A2.Content = "11";
                A2.Background = Brushes.Blue;
                A3.Content = "12";
                A3.Background = Brushes.DarkBlue;
                C2.Visibility = Visibility.Visible;
                C3.Visibility = Visibility.Visible;
                B1.Visibility = Visibility.Visible;
                B2.Visibility = Visibility.Visible;
                B3.Visibility = Visibility.Visible;
                A1.Visibility = Visibility.Visible;
                A2.Visibility = Visibility.Visible;
                A3.Visibility = Visibility.Visible;
                Score.Height = 85;
                Score.Margin = new Thickness(162, 322, 0, 0);
            }
            //Belarus
            if (type == 5)
            {
                D1.Content = "1";
                D2.Content = "2";
                D2.Background = Brushes.HotPink;
                D3.Content = "3";
                D3.Background = Brushes.Pink;
                C1.Content = "4";
                C1.Background = Brushes.DarkOrange;
                C2.Content = "5";
                C2.Background = Brushes.Orange;
                C3.Content = "6";
                C3.Background = Brushes.Yellow;
                B1.Content = "7";
                B1.Background = Brushes.GreenYellow;
                B2.Content = "8";
                B2.Background = Brushes.Green;
                B3.Content = "9";
                B3.Background = Brushes.Cyan;
                A1.Content = "10";
                A1.Background = Brushes.Blue;
                C2.Visibility = Visibility.Visible;
                C3.Visibility = Visibility.Visible;
                B1.Visibility = Visibility.Visible;
                B2.Visibility = Visibility.Visible;
                B3.Visibility = Visibility.Visible;
                A1.Visibility = Visibility.Visible;
                Score.Height = 135;
                Score.Margin = new Thickness(162, 272, 0, 0);
            }
            //Czech Republic
            if(type == 6)
            {
                D1.Content = "1";
                D2.Content = "2";
                D2.Background = Brushes.Orange;
                D3.Content = "3";
                D3.Background = Brushes.Yellow;
                C1.Content = "4";
                C1.Background = Brushes.Green;
                C2.Content = "5";
                C2.Background = Brushes.Blue;
                C2.Visibility = Visibility.Visible;

                Score.Height = 255;
                Score.Margin = new Thickness(162, 152, 0, 0);
            }
            //Finland
            if(type == 7)
            {
                D1.Content = "4";
                D2.Content = "5";
                D2.Background = Brushes.HotPink;
                D3.Content = "6";
                D3.Background = Brushes.Orange;
                C1.Content = "7";
                C1.Background = Brushes.Yellow;
                C2.Content = "8";
                C2.Background = Brushes.Green;
                C3.Content = "9";
                C3.Background = Brushes.Cyan;
                B1.Content = "10";
                B1.Background = Brushes.Blue;
                C2.Visibility = Visibility.Visible;
                C3.Visibility = Visibility.Visible;
                B1.Visibility = Visibility.Visible;
                Score.Height = 210;
                Score.Margin = new Thickness(162, 197, 0, 0);
            }
            //Bulgaria
            if(type == 8)
            {
                D1.Content = "2";
                D2.Content = "3";
                D2.Background = Brushes.Orange;
                D3.Content = "4";
                D3.Background = Brushes.Yellow;
                C1.Content = "5";
                C1.Background = Brushes.Green;
                C2.Content = "6";
                C2.Background = Brushes.Blue;
                C2.Visibility = Visibility.Visible;

                Score.Height = 255;
                Score.Margin = new Thickness(162, 152, 0, 0);
            }
            //Denmark
            if (type == 9)
            {

                C2.Visibility = Visibility.Visible;
                C3.Visibility = Visibility.Visible;
                B1.Visibility = Visibility.Visible;

                getGPADen();

                Score.Height = 210;
                Score.Margin = new Thickness(162, 197, 0, 0);
            }
            //Custom
            if (type > 9)
            {
                double heightS = Score.Height;
                double posS = Score.Margin.Top;
               
                string path = File.ReadAllText("NameEST.txt");
                int buttons = Int32.Parse(File.ReadLines(System.IO.Path.Combine("ESTData", path + ".txt")).Skip(1).First());
                int types = buttons * 2;
                int gpa = Int32.Parse(File.ReadLines(System.IO.Path.Combine("ESTData", path + ".txt")).Skip(3).First());
                int strings = System.IO.File.ReadAllLines(System.IO.Path.Combine("ESTData", path + ".txt")).Length;
                int y = 5;
                int g = strings / 3 + 4;
                int z = strings - g + 6;
                int en = 1;
                int et = 1;
                switch (gpa)
                {
                    case 0:
                        break;
                    case 1:
                        getGPAEng();
                        break;
                    case 2:
                        getGPAGer();
                        break;
                    case 3:
                        getGPAFra();
                        break;
                    case 4:
                        getGPADen();
                        break;
                    case 5:
                        break;
                }
                foreach (UIElement es in Buttons.Children)
                {
                    string ch = File.ReadLines(System.IO.Path.Combine("ESTData", path + ".txt")).Skip(y).First();
                    string cb = File.ReadLines(System.IO.Path.Combine("ESTData", path + ".txt")).Skip(g).First();
                    SolidColorBrush ckl = (SolidColorBrush)new BrushConverter().ConvertFromString(ch);


                    if (es is Button)
                    {

                        ((Button)es).Visibility = Visibility.Visible;
                        ((Button)es).Background = ckl;
                        ((Button)es).Content = cb;
                        if (en >= 4)
                        {
                            heightS -= 25;
                            posS += 25;
                        }
                        if (en == buttons)
                        {
                            break;
                        }
                        en++;
                        y++;
                        g++;


                    }
                    Score.Height = heightS;
                    Score.Margin = new Thickness(162, posS, 0, 0);

                }
                foreach (UIElement ef in Buttons.Children)
                {

                    string cz = File.ReadLines(System.IO.Path.Combine("ESTData", path + ".txt")).Skip(z).First();
                    if (ef is TextBlock)
                    {
                        ((TextBlock)ef).Visibility = Visibility.Visible;
                        ((TextBlock)ef).Text = cz;
                       
                        
                        if (et == buttons)
                        {
                            break;
                        }
                        et++;
                        z++;
                    }
                }
            }
         
            if (lang == 2 || lang == 3 || lang == 6)
            {
                Namer.Height = 40;
                Result.Margin = new Thickness(262, 223, 0, 0);
                Tres.Margin = new Thickness(262, 246, 0, 0);
            }

            foreach (UIElement el in Buttons.Children)
                {
                    if (el is Button)
                    {
                        ((Button)el).Click += Button_Click;
                    ((Button)el).IsEnabled = false;
                    }
                
                }


            if (debugCheck == 1)
            {
                Debug.Visibility = Visibility.Visible;
            }

        }

       

        private void TextBox_MouseEnter(object sender, MouseEventArgs e)
        {
            Namer.Clear();
        }

        //Functions add and edit
        private void Namer_KeyDown(object sender, KeyEventArgs e)
        {
            if (name == true)
            {
                if (e.Key == Key.Enter)
                {
                    sizeH = Namer.Text;
                  
                    Lister.Items.Add(new ListBoxItem() { Content = "-"});
                    Subjects.Items.Add(new ListBoxItem() { Content = sizeH, Background = Brushes.Red });
                    Subjects.SelectedItem = sizeH;
                    Count++;
                    Namer.IsEnabled = false;
                    Subjects.IsEnabled = true;
                    name = false;
                    Edit.IsEnabled = false;
                    Delete.IsEnabled = false;
                    Color.IsEnabled = false;
                }
            }
            if (edit == true)
            {
                DialogeW.Text = Properties.Resources.Dialoge2;
                if (e.Key == Key.Enter)
                {

                    sizeG = Namer.Text;
                    Subjects.Items.Insert(Subjects.SelectedIndex, new ListBoxItem() { Content = sizeG, Background = Brushes.Red});
                    Subjects.Items.Remove(Subjects.SelectedItem);
                    Namer.IsEnabled = false;
                    Subjects.IsEnabled = true;
                    Edit.IsEnabled = false;
                    Delete.IsEnabled = false;
                    Color.IsEnabled = false;

                }
               
            }
          
        }

        //Exit
        protected override void OnClosing(CancelEventArgs e)
        {
            exit = Int32.Parse(File.ReadAllText("Exit.txt"));
          
            if (exit == 1)
            {
                mainE = 1;
                File.WriteAllText("Exit.txt", mainE.ToString());
                Application.Current.Shutdown();

              
            }
            if (exit == 2)
            {
                
                File.WriteAllText("Exit.txt", mainE.ToString());
          
                Application.Current.Shutdown();
                
               
            }
            if(exit == 0)
            {
                MessageBoxResult result = MessageBox.Show(Properties.Resources.Message1, Properties.Resources.Box1, MessageBoxButton.YesNo, MessageBoxImage.Warning);
                switch (result)
                {
                    case MessageBoxResult.Yes:
                      
                        mainE = 1;
                        File.WriteAllText("Exit.txt", mainE.ToString());
                        Application.Current.Shutdown();

                        break;
                    case MessageBoxResult.No:
                        e.Cancel = true;
                        break;
                }
            }
            base.OnClosing(e);
        }

        //Function call Name window 
        private void Name_MouseEnter(object sender, MouseEventArgs e)
        {
          
                n.Show();
            Name.IsEnabled = false;
            
        }

        //Functon delete for Score
        private void Score_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          
            if (res == false)
            {
                DialogeW.Text = Properties.Resources.Dialoge3;
                MessageBoxResult result = MessageBox.Show(Properties.Resources.Sure, Properties.Resources.Box2, MessageBoxButton.YesNo, MessageBoxImage.Warning);
                switch (result)
                {
                    case MessageBoxResult.Yes:


                        // Score.SelectedItem = false;
                        res = true;
                        value -= Int32.Parse(Score.SelectedItem.ToString());
                        Score.Items.Remove(Score.SelectedItem);

                        ClickS--;
                        DialogeW.Text = Properties.Resources.Dialoge4;
                       

                        break;
                    case MessageBoxResult.No:
                        Score.SelectedItem = false;
                        DialogeW.Text = Properties.Resources.Dialoge4;

                        break;

                }
            }
            res = false;
        }

   //Background pick
        private void Background_Checked(object sender, RoutedEventArgs e)
        {
            BackgroundCheck();
        }
        private void Background_Unchecked(object sender, RoutedEventArgs e)
        {
            BackgroundUnCheck();
        }
        
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show(Properties.Resources.Sure, Properties.Resources.Box2, MessageBoxButton.YesNo, MessageBoxImage.Warning);
            switch (result)
            {
                case MessageBoxResult.Yes:

                    Subjects.IsEnabled = false;
                    Namer.IsEnabled = true;
                    name = true;
                    DialogeW.Text = Properties.Resources.Dialoge5;

                    break;
                case MessageBoxResult.No:

                    break;
            }
        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show(Properties.Resources.Sure, Properties.Resources.Box2, MessageBoxButton.YesNo, MessageBoxImage.Warning);
            switch (result)
            {
                case MessageBoxResult.Yes:
                   
                        delete = true;

                        DialogeW.Text = Properties.Resources.Dialoge6;
                        Lister.Items.RemoveAt(Subjects.SelectedIndex);
                        Subjects.Items.Remove(Subjects.SelectedItem);
                        Count--;

                        DialogeW.Text = Properties.Resources.Dialoge2;
                        Edit.IsEnabled = false;
                        Delete.IsEnabled = false;
                        Color.IsEnabled = false;
                    
                 
                    break;
                case MessageBoxResult.No:
                 
                    break;
            }
        }
        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show(Properties.Resources.Sure, Properties.Resources.Box2, MessageBoxButton.YesNo, MessageBoxImage.Warning);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    edit = true;
                    Subjects.IsEnabled = false;
                    Namer.IsEnabled = true;
                    DialogeW.Text = Properties.Resources.Dialoge7;
                    
                    break;
                case MessageBoxResult.No:

                    break;
            }
        }

        private void bold_Click(object sender, RoutedEventArgs e)
        {
            Bold();
        }
        private void italic_Click(object sender, RoutedEventArgs e)
        {
            Italic();
        }
        private void underline_Click(object sender, RoutedEventArgs e)
        {
            Underline();
          
        }
        private void normal_Click(object sender, RoutedEventArgs e)
        {
            Normal();
        }
        private void ColorPick_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (ColorPick.Visibility == Visibility.Visible)
            {
                MessageBoxResult result = MessageBox.Show(Properties.Resources.Sure, Properties.Resources.Box2, MessageBoxButton.YesNo, MessageBoxImage.Warning);
                switch (result)
                {
                    case MessageBoxResult.Yes:
                        ColorPick.IsEnabled = false;
                        ColorPick.Visibility = Visibility.Hidden;
                        cls = 0;
                        cls2 = 0;
                        break;
                    case MessageBoxResult.No:

                        break;

                }
            }
        }

        //Debug functions
        private void Reset_Click(object sender, RoutedEventArgs e)
        {

            Lister.Items.Clear();
            GEN.Clear();
            Tres.Clear();
            for (int g= 0; g < Subjects.Items.Count; g++)
            {
                Lister.Items.Add( new ListBoxItem() { Content = "-"});
            }
      
            sizeS = 0;
            TotalResult = 0;

        }
    
        private void Complete_Click(object sender, RoutedEventArgs e)
        {
            Count = sizeS;
            Res();
        }

        private void Window_Activated(object sender, EventArgs e)
       
        {
            // Load function
            Count = Subjects.Items.Count;
            file = Int32.Parse(File.ReadLines("File.txt").First());
            if (file == 1)
            {
                Name.IsEnabled = false;
                Menu.IsEnabled = true;
                Subjects.IsEnabled = true;
                n.Close();

                int strings = System.IO.File.ReadAllLines("Save.txt").Length;


                Subjects.Items.Clear();
                Lister.Items.Clear();

                Name.Text = File.ReadLines("Save.txt").First();
                Sername.Text = File.ReadLines("Save.txt").Skip(1).First();
                backgroundCheck = Int32.Parse(File.ReadLines("Save.txt").Skip(2).First());
                fontType = Int32.Parse(File.ReadLines("Save.txt").Skip(3).First());
                colorPick = File.ReadLines("Save.txt").Skip(4).First();
               
                if(backgroundCheck == 1)
                {
                    BackgroundCheck();
                }
                else 
                {
                    BackgroundUnCheck();
                }
                switch(fontType)
                {
                    case 0:
                        Normal();
                        break;
                    case 1:
                        Bold();
                        break;
                    case 2:
                        Italic();
                        break;
                    case 3:
                        Underline();
                        break;

                }
                ColorPickSelectColor();
                countS = strings / 3 + 4;
                countE = strings - countS + 5;
                int y = countE;
                for (int s = 5; s < countS; s++)
                {

                    string ch = File.ReadLines("Save.txt").Skip(y).First();
                    SolidColorBrush ckl = (SolidColorBrush)new BrushConverter().ConvertFromString(ch);
                    Subjects.Items.Add(new ListBoxItem() { Content = File.ReadLines("Save.txt").Skip(s).First(), Background = ckl });
                    y++;

                }

                for (int sf = countS; sf < countE; sf++)
                {
                    Lister.Items.Add(new ListBoxItem() { Content = File.ReadLines("Save.txt").Skip(sf).First() });
                }

                file = 0;
                File.WriteAllText("File.txt", file.ToString());


            }
            if (File.ReadAllText(@"Sername.txt") != "\t")
            {

                Name.IsEnabled = false;
                Menu.IsEnabled = true;
                Subjects.IsEnabled = true;
                Sername.IsReadOnly = true;
                Name.Text = File.ReadAllText(@"Name.txt");
                Sername.Text = File.ReadAllText(@"Sername.txt");
                File.WriteAllText(@"Name.txt", "\t");
                File.WriteAllText(@"Sername.txt","\t");

            }

        }
        private void Save_Click(object sender, RoutedEventArgs e)
        {
           MessageBoxResult result = MessageBox.Show(Properties.Resources.Sure2, Properties.Resources.Box2, MessageBoxButton.YesNo, MessageBoxImage.Warning);

            switch (result)
            {
                case MessageBoxResult.Yes:
                    Name.IsEnabled = true;
                    using (System.IO.StreamWriter w = new StreamWriter(saveS))
                    {
                        w.WriteLine(Name.Text);
                        w.WriteLine(Sername.Text);
                        w.WriteLine(backgroundCheck);
                        w.WriteLine(fontType);
                        w.WriteLine(colorPick);
                        foreach (ListBoxItem s in Subjects.Items)
                        {
                            string str = s.Content + "";
                            w.WriteLine(str);
                        }
                        foreach (ListBoxItem sr in Lister.Items)
                        {
                            string ster = sr.Content + "";
                            w.WriteLine(ster);
                        }
                        foreach (ListBoxItem fs in Subjects.Items)
                        {
                            string str = fs.Background + "";
                            w.WriteLine(str);
                        }

                    }
                    Name.IsEnabled = false;
                    break;
                case MessageBoxResult.No:

                    break;

            }
         
        }
        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (Textbox1.Text != "")
                {
                    ClickS++;
                    string mSting = e.Key.ToString();
                    string NewString = mSting.TrimStart('D');
                    NumberN = ClickS;
                    value += Int32.Parse(NewString.ToString());
                    valueN = Int32.Parse(NewString.ToString());
                    Clicker.Text = ClickS.ToString();
                    Textbox1.Text = value.ToString();
                    GEN.Clear();
                    Score.Items.Add(valueN);
                    if (ClickS == sizeC)
                    {
                        valueS = value;
                        result = value / ClickS;
                        result = Math.Round(result, 2);



                        TotalResult += result;
                        RussianType();
                        EnglishType();
                        FrenchType();
                        GermanyType();
                        UkraineType();
                        BelarusType();
                        CzechType();
                        FinlandType();
                        BulgariaType();
                        DenmarkType();
                        CustomType();
                        value = 0;
                        result = 0;
                        ClickS = 0;
                        sizeC = 0;
                        if (Lister.Items[Subjects.SelectedIndex] != "-")
                        {
                            sizeS++;
                        }
                        else
                        {

                        }
                        EnterC.IsEnabled = true;
                        foreach (UIElement el in Root.Children)
                        {
                            if (el is Button)
                            {
                                ((Button)el).IsEnabled = false;
                            }

                        }
                        Textbox1.Clear();
                        EnterC.Clear();
                        EnterC.IsEnabled = false;
                        Subjects.IsEnabled = true;
                        Score.Items.Clear();
                    }
                    Res();
                }
            }

            catch (Exception exp)
            {

                ClickS--;
            }
        }
        private void AllEnabled_Click(object sender, RoutedEventArgs e)
        {
            ColorPick.IsEnabled = true;
            ColorPick.Visibility = Visibility.Visible;
            Namer.IsEnabled = true;
            Subjects.IsEnabled = true;
            EnterC.IsEnabled = true;
            Menu.IsEnabled = true;
            GEN.IsReadOnly = false;
            Namer.IsReadOnly = false;
            Namer.IsEnabled = true;
            Sername.IsReadOnly = false;
            Name.IsReadOnly = true;
            foreach (UIElement el in Root.Children)
            {
                if (el is Button)
                {
                
                    ((Button)el).IsEnabled = true;


                }

            }
        }

        private void AllPaused_Click(object sender, RoutedEventArgs e)
        {
            ColorPick.IsEnabled = false;
            ColorPick.Visibility = Visibility.Hidden;
            Namer.IsEnabled = false;
            Subjects.IsEnabled = false;
            EnterC.IsEnabled = false;
            Menu.IsEnabled = true;
            GEN.IsReadOnly = true;
            Namer.IsReadOnly = false;
            Namer.IsEnabled = false;
            Sername.IsReadOnly = true;
            Name.IsReadOnly = false;
            foreach (UIElement el in Buttons.Children)
            {
                if (el is Button)
                {

                    ((Button)el).IsEnabled = false;


                }

            }
        }

        private void ResetWindow_Click(object sender, RoutedEventArgs e)
        {
            ColorPick.IsEnabled = false;
            ColorPick.Visibility = Visibility.Hidden;
            Namer.IsEnabled = false;
            Subjects.IsEnabled = true;
            EnterC.IsEnabled = false;
            Menu.IsEnabled = true;
            GEN.IsReadOnly = true;
            Namer.IsReadOnly = false;
            Namer.IsEnabled = true;
            Sername.IsReadOnly = true;
            Name.IsReadOnly = true;
            foreach (UIElement el in Buttons.Children)
            {
                if (el is Button)
                {

                    ((Button)el).IsEnabled = false;


                }

            }
        }
        private void Color_Click(object sender, RoutedEventArgs e)
        {
            ColorPick.IsEnabled = true;
            ColorPick.Visibility = Visibility.Visible;
     
            cls2++;
        }
        private void FontColor_Click(object sender, RoutedEventArgs e)
        {
            ColorPick.IsEnabled = true;
            ColorPick.Visibility = Visibility.Visible;
            cls++;
        }
        private void ColorPick_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            if (cls == 1)
            {
                colorPick = ColorPick.SelectedColor.Value.ToString();
                switch (fontType)
                {
                    case 0:
                        Normal();
                        break;
                    case 1:
                        Bold();
                        break;
                    case 2:
                        Italic();
                        break;
                    case 3:
                        Underline();
                        break;

                }
                ColorPickSelectColor();
                DialogeW.Text = Properties.Resources.Dialoge8;
            }
            if(cls2 == 1)
            {
                string c1 = ColorPick.SelectedColor.Value.ToString();
                SolidColorBrush ck = (SolidColorBrush)new BrushConverter().ConvertFromString(c1);

                ListBoxItem lbi = Subjects.Items[Subjects.SelectedIndex] as ListBoxItem;
                lbi.Background = ck;
                DialogeW.Text = Properties.Resources.Dialoge8;

            }


            DialogeW.Text = Properties.Resources.Dialoge2;



        }
        private void EnterC_MouseEnter(object sender, MouseEventArgs e)
        {
            EnterC.Clear();
        }

        private void EnterC_KeyDown_1(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Enter)
            {
                try
                {
                    sizeC = Int32.Parse(EnterC.Text);
                    if (sizeC < 3)
                    {
                        DialogeW.Text = Properties.Resources.Dialoge9;
                        EnterC.Clear();
                    }
                    else
                    {
                        
                        DialogeW.Text = Properties.Resources.Dialoge4;
                        EnterC.IsEnabled = false;

                        foreach (UIElement el in Buttons.Children)
                        {
                            if (el is Button)
                            {
                                ((Button)el).IsEnabled = true;
                            }

                        }
                        Textbox1.Text = "0";

                    }
                }
                catch(Exception exp)
                {
                    DialogeW.Text = "Error! Only number!";
                    sizeC = 0;
                    EnterC.Clear();
                }
            }
        }


        //Main Selection
        private void Subjects_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
            cls = 0;
            cls2 = 0;


            DialogeW.Text = Properties.Resources.Dialoge2;
            if (delete == false && drop == false && edit == false)
            {
                SelectionChangedResult = MessageBox.Show(Properties.Resources.Sure, Properties.Resources.Box2, MessageBoxButton.YesNo, MessageBoxImage.Warning);

                switch (SelectionChangedResult)
                {
                    case MessageBoxResult.Yes:
                        if (summarymodeCheck != 1)
                        {
                            EnterC.IsEnabled = true;
                            Subjects.IsEnabled = false;
                        }
                        else
                        {
                            foreach (UIElement el in Buttons.Children)
                            {
                                if (el is Button)
                                {
                                    ((Button)el).IsEnabled = true;
                                }

                            }
                        }
                        break;
                    case MessageBoxResult.No:

                        Subjects.SelectedItem = false;
                        Edit.IsEnabled = true;
                        Delete.IsEnabled = true;
                        Color.IsEnabled = true;

                        break;

                }
            }
           
            edit = false;
           delete = false;
            drop = false;
           
            
        }
        private void Subjects_Drop(object sender, DragEventArgs e)
        {
            drop = true;

        }
        //main fuction
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

            if (summarymodeCheck == 1)
            {
                TotalResult += value;
                Lister.Items.RemoveAt(Subjects.SelectedIndex);
                Lister.Items.Insert(Subjects.SelectedIndex,new ListBoxItem { Content = value });
                value = 0;
                ClickS = 0;
                sizeC = 0;
                if (Lister.Items[Subjects.SelectedIndex] != "-")
                {
                    sizeS++;
                }

                Subjects.IsEnabled = true;
                Score.Items.Clear();
                foreach (UIElement el in Buttons.Children)
                {
                    if (el is Button)
                    {
                        ((Button)el).IsEnabled = false;
                    }

                }
            }
            else
            {
                if (ClickS == sizeC)
                {
                    valueS = value;
                    result = value / ClickS;
                    result = Math.Round(result, 2);

                    TotalResult += result;
                    RussianType();
                    EnglishType();
                    FrenchType();
                    GermanyType();
                    UkraineType();
                    BelarusType();
                    CzechType();
                    FinlandType();
                    BulgariaType();
                    DenmarkType();
                    CustomType();

                    value = 0;
                    result = 0;
                    ClickS = 0;
                    sizeC = 0;
                    if (Lister.Items[Subjects.SelectedIndex] != "-")
                    {
                        sizeS++;
                    }
                    else
                    {

                    }
                    foreach (UIElement el in Buttons.Children)
                    {
                        if (el is Button)
                        {
                            ((Button)el).IsEnabled = false;
                        }

                    }
                    Textbox1.Clear();
                    EnterC.Clear();
                    EnterC.IsEnabled = false;
                    Subjects.IsEnabled = true;
                    Score.Items.Clear();
                }
            }
            Res();
        }
    }
}
