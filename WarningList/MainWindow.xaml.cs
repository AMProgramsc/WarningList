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
using GongSolutions.Wpf.DragDrop;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UserInfo user = new UserInfo();

        SernameD snr = new SernameD();
     
        NameD n = new NameD();


        MessageBoxResult resultrt;
        double value, valueS, valueN;
        double ClickS;
        double NumberN;
        double result;
        double warning = 0;
        double Tresult;
        double TotalResult;
        string inf = "Inf.txt";
        string fileS;
        string sizeN, sizeG, sizeH;
        string cj = "Black";
        string saveS = "Save.txt";
        bool delete = false;
        bool edit = false;
        bool name = false;
        bool enter = false;
        bool drop = false;
        bool res = false;
        int Count;
        int stringS,countS , countE;
        int hit = 0;
        int exit = 0, exit1;
        int iy;
        int cls, cls2;
        int check = 0;
        int lang = 0;
        int type = 0;
        int sizeS = 0, sizeC = 0;
        int mainE, file;
        int bg;
        int fs;
        public void GPAEng()
        {
            D1.Content = "1";
            D2.Content = "2";
            D2.Background = Brushes.HotPink;
            D3.Content = "3";
            D3.Background = Brushes.Orange;
            C1.Content = "4";
            C1.Background = Brushes.Yellow;
            T1.Visibility = Visibility.Visible;
            T2.Visibility = Visibility.Visible;
            T3.Visibility = Visibility.Visible;
            T4.Visibility = Visibility.Visible;
            T5.Visibility = Visibility.Visible;
            T6.Visibility = Visibility.Visible;
            T7.Visibility = Visibility.Visible;
        }
        public void GPAGer()
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
        public void GPAFra()
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
        public void GPADen()
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
        public void Russian()
        {
            if (type == 0)
            {
                if (result <= 2.5)
                {

                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen1 + "\r\n";

                    for (; warning < 2.6;)
                    {
                        warning = (valueS + 3) / (NumberN + 1);
                        valueS += 3;
                        NumberN += 1;
                        GEN.Text += Properties.Resources.GenN + 3 + Properties.Resources.GenF + warning + "\r\n";
                    }
                    warning = 0;

                }
                else if (result <= 3.5)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen2 + "3" + "\r\n";

                    for (; warning < 3.6;)
                    {
                        warning = (valueS + 4) / (NumberN + 1);
                        valueS += 4;
                        NumberN += 1;
                        GEN.Text += Properties.Resources.GenN + 4 + Properties.Resources.GenF + warning + "\r\n";
                    }

                    warning = 0;

                }
                else if (result <= 4.5)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen3 + "4" + "\r\n";

                    for (; warning < 4.6;)
                    {
                        warning = (valueS + 5) / (NumberN + 1);
                        valueS += 5;
                        NumberN += 1;
                        GEN.Text += Properties.Resources.GenN + 5 + Properties.Resources.GenF + warning + "\r\n";
                    }
                    warning = 0;

                }
                else
                {

                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen4 + "\r\n";

                }
                Lister.Items[listbox.SelectedIndex] = result;
            }
        }
        public void English()
        {
         
         
            //Main
            if (type == 1)
            {
                if (result < 2)
                {

                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen1 + " - " + "F" + "\r\n";

                    for (; warning <= 1.5;)
                    {
                        warning = (valueS + 2) / (NumberN + 1);
                        valueS += 2;
                        NumberN += 1;
                        warning = Math.Round(warning, 2);
                        GEN.Text += Properties.Resources.GenN + "E" + Properties.Resources.GenF + warning + "\r\n";

                    }
                    warning = 0;

                }
                else if (result < 3)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen2 + "E" + "\r\n";

                    for (; warning <= 2.5;)
                    {
                        warning = (valueS + 3) / (NumberN + 1);
                        valueS += 3;
                        NumberN += 1;
                        warning = Math.Round(warning, 2);
                        GEN.Text += Properties.Resources.GenN + "D" + Properties.Resources.GenF + warning + "\r\n";
                    }

                    warning = 0;

                }
                else if (result < 4)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen3 + "D" + "\r\n";

                    for (; warning < 3.5;)
                    {
                        warning = (valueS + 4) / (NumberN + 1);
                        valueS += 4;
                        NumberN += 1;
                        warning = Math.Round(warning, 2);
                        GEN.Text += Properties.Resources.GenN + "C" + Properties.Resources.GenF + warning + "\r\n";
                    }
                    warning = 0;

                }
                else if (result < 5)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen3 + "C" + "\r\n";

                    for (; warning < 4.5;)
                    {
                        warning = (valueS + 5) / (NumberN + 1);
                        valueS += 5;
                        NumberN += 1;
                        warning = Math.Round(warning, 2);
                        GEN.Text += Properties.Resources.GenN + "B" + Properties.Resources.GenF + warning + "\r\n";
                    }
                    warning = 0;

                }
                else if (result <= 6)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen3 + "B" + "\r\n";

                    for (; warning < 5.5;)
                    {
                        warning = (valueS + 6) / (NumberN + 1);
                        valueS += 6;
                        NumberN += 1;
                        warning = Math.Round(warning, 2);
                        GEN.Text += Properties.Resources.GenN + "A" + Properties.Resources.GenF + warning + "\r\n";
                    }
                    warning = 0;

                }
                else if (result < 7)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen3 + "A" + "\r\n";

                    for (; warning <= 6.5;)
                    {
                        warning = (valueS + 7) / (NumberN + 1);
                        valueS += 7;
                        NumberN += 1;
                        warning = Math.Round(warning, 2);
                        GEN.Text += Properties.Resources.GenN + "A*" + Properties.Resources.GenF + warning + "\r\n";
                    }
                    warning = 0;

                }
                else
                {

                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen4 + " - " + "A*" + "\r\n";

                }
                if (result <= 1.5)
                {
                    Lister.Items[listbox.SelectedIndex] = "F";
                }
                else if (result < 2 && result > 1.5)
                {
                    Lister.Items[listbox.SelectedIndex] = "E";
                }
                else if (result <= 2.5)
                {
                    Lister.Items[listbox.SelectedIndex] = "D";
                }
                else if (result < 3 && result > 2.5)
                {
                    Lister.Items[listbox.SelectedIndex] = "D+";
                }
                else if (result < 3 && result >= 2.9)
                {
                    Lister.Items[listbox.SelectedIndex] = "C-";
                }
                else if (result <= 3.5)
                {
                    Lister.Items[listbox.SelectedIndex] = "C";
                }
                else if (result < 4 && result > 3.5)
                {
                    Lister.Items[listbox.SelectedIndex] = "C+";
                }
                else if (result < 4 && result >= 3.9)
                {
                    Lister.Items[listbox.SelectedIndex] = "B-";
                }
                else if (result <= 4.5)
                {
                    Lister.Items[listbox.SelectedIndex] = "B";
                }
                else if (result < 5 && result > 4.5)
                {
                    Lister.Items[listbox.SelectedIndex] = "B+";
                }
                else if (result < 5 && result >= 4.9)
                {
                    Lister.Items[listbox.SelectedIndex] = "A-";
                }
                else if (result <= 5.5)
                {
                    Lister.Items[listbox.SelectedIndex] = "A";
                }
                else if (result <= 6 && result > 6.9)
                {
                    Lister.Items[listbox.SelectedIndex] = "A*";
                }
                else if (result == 6)
                {
                    Lister.Items[listbox.SelectedIndex] = "A*";
                }
                //End

            }
        }   
        public void French()
        {
            if (type == 2)
            {
                if (result <= 1.2)
                {

                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen1 + " - " + "<7" + "\r\n";

                    for (; warning <= 1.5;)
                    {
                        warning = (valueS + 2) / (NumberN + 1);
                        valueS += 2;
                        NumberN += 1;
                        warning = Math.Round(warning, 2);
                        GEN.Text += Properties.Resources.GenN + "8" + Properties.Resources.GenF + warning + "\r\n";

                    }
                    warning = 0;

                }
                else if (result > 1.2 && result < 1.5)
                {

                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen1 + " - " + "8" + "\r\n";

                    for (; warning <= 1.5;)
                    {
                        warning = (valueS + 2) / (NumberN + 1);
                        valueS += 2;
                        NumberN += 1;
                        warning = Math.Round(warning, 2);
                        GEN.Text += Properties.Resources.GenN + "9" + Properties.Resources.GenF + warning + "\r\n";

                    }
                    warning = 0;

                }
                else if (result < 2 && result > 1.5)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen2 + "9" + "\r\n";

                    for (; warning <= 2;)
                    {
                        warning = (valueS + 2) / (NumberN + 1);
                        valueS += 2;
                        NumberN += 1;
                        warning = Math.Round(warning, 2);
                        GEN.Text += Properties.Resources.GenN + "10" + Properties.Resources.GenF + warning + "\r\n";
                    }

                    warning = 0;

                }
                else if (result < 2 && result >= 1.9)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen2 + "10" + "\r\n";

                    for (; warning <= 2;)
                    {
                        warning = (valueS + 2) / (NumberN + 1);
                        valueS += 2;
                        NumberN += 1;
                        warning = Math.Round(warning, 2);
                        GEN.Text += Properties.Resources.GenN + "11" + Properties.Resources.GenF + warning + "\r\n";
                    }

                    warning = 0;

                }
                else if (result < 2.5)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen3 + "11" + "\r\n";

                    for (; warning <= 2.5;)
                    {
                        warning = (valueS + 3) / (NumberN + 1);
                        valueS += 3;
                        NumberN += 1;
                        warning = Math.Round(warning, 2);
                        GEN.Text += Properties.Resources.GenN + "12" + Properties.Resources.GenF + warning + "\r\n";
                    }
                    warning = 0;

                }
                else if (result < 3 && result > 2.5)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen3 + "12" + "\r\n";

                    for (; warning <= 3;)
                    {
                        warning = (valueS + 3) / (NumberN + 1);
                        valueS += 3;
                        NumberN += 1;
                        warning = Math.Round(warning, 2);
                        GEN.Text += Properties.Resources.GenN + "13" + Properties.Resources.GenF + warning + "\r\n";
                    }
                    warning = 0;

                }
                else if (result < 3 && result >= 2.9)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen3 + "13" + "\r\n";

                    for (; warning <= 3;)
                    {
                        warning = (valueS + 3) / (NumberN + 1);
                        valueS += 3;
                        NumberN += 1;
                        warning = Math.Round(warning, 2);
                        GEN.Text += Properties.Resources.GenN + "14" + Properties.Resources.GenF + warning + "\r\n";
                    }
                    warning = 0;

                }
                else if (result < 3.5)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen3 + "14" + "\r\n";

                    for (; warning <= 3.5;)
                    {
                        warning = (valueS + 4) / (NumberN + 1);
                        valueS += 4;
                        NumberN += 1;
                        warning = Math.Round(warning, 2);
                        GEN.Text += Properties.Resources.GenN + "15" + Properties.Resources.GenF + warning + "\r\n";
                    }
                    warning = 0;

                }
                else if (result < 4 && result > 3.5)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen3 + "15" + "\r\n";

                    for (; warning <= 4;)
                    {
                        warning = (valueS + 4) / (NumberN + 1);
                        valueS += 4;
                        NumberN += 1;
                        warning = Math.Round(warning, 2);
                        GEN.Text += Properties.Resources.GenN + "16" + Properties.Resources.GenF + warning + "\r\n";
                    }
                    warning = 0;

                }
                else if (result < 4 && result >= 3.9)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen3 + "16" + "\r\n";

                    for (; warning <= 4;)
                    {
                        warning = (valueS + 4) / (NumberN + 1);
                        valueS += 4;
                        NumberN += 1;
                        warning = Math.Round(warning, 2);
                        GEN.Text += Properties.Resources.GenN + "17" + Properties.Resources.GenF + warning + "\r\n";
                    }
                    warning = 0;

                }
                else if (result < 4.5)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen3 + "17" + "\r\n";

                    for (; warning <= 4.5;)
                    {
                        warning = (valueS + 5) / (NumberN + 1);
                        valueS += 5;
                        NumberN += 1;
                        warning = Math.Round(warning, 2);
                        GEN.Text += Properties.Resources.GenN + "18" + Properties.Resources.GenF + warning + "\r\n";
                    }
                    warning = 0;

                }
                else if (result < 5 && result > 4.5)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen3 + "18" + "\r\n";

                    for (; warning <= 5;)
                    {
                        warning = (valueS + 5) / (NumberN + 1);
                        valueS += 5;
                        NumberN += 1;
                        warning = Math.Round(warning, 2);
                        GEN.Text += Properties.Resources.GenN + "19" + Properties.Resources.GenF + warning + "\r\n";
                    }
                    warning = 0;

                }
                else if (result < 5 && result >= 4.9)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen3 + "19" + "\r\n";

                    for (; warning <= 5;)
                    {
                        warning = (valueS + 5) / (NumberN + 1);
                        valueS += 5;
                        NumberN += 1;
                        warning = Math.Round(warning, 2);
                        GEN.Text += Properties.Resources.GenN + "20" + Properties.Resources.GenF + warning + "\r\n";
                    }
                    warning = 0;

                }
                else
                {

                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen4 + " - " + "20" + "\r\n";

                }

                if (result <= 1.2)
                {
                    Lister.Items[listbox.SelectedIndex] = "<7";
                }
                else if (result > 1.2 && result < 1.5)
                {
                    Lister.Items[listbox.SelectedIndex] = "8";
                }
                else if (result < 2 && result >= 1.5)
                {
                    Lister.Items[listbox.SelectedIndex] = "9";
                }
                else if (result < 2 && result >= 1.9)
                {
                    Lister.Items[listbox.SelectedIndex] = "10";
                }
                else if (result < 2.5)
                {
                    Lister.Items[listbox.SelectedIndex] = "11";
                }
                else if (result < 3 && result >= 2.5)
                {
                    Lister.Items[listbox.SelectedIndex] = "12";
                }
                else if (result < 3 && result >= 2.9)
                {
                    Lister.Items[listbox.SelectedIndex] = "13";
                }
                else if (result < 3.5)
                {
                    Lister.Items[listbox.SelectedIndex] = "14";
                }
                else if (result < 4 && result >= 3.5)
                {
                    Lister.Items[listbox.SelectedIndex] = "15";
                }
                else if (result < 4 && result >= 3.9)
                {
                    Lister.Items[listbox.SelectedIndex] = "16";
                }
                else if (result < 4.5)
                {
                    Lister.Items[listbox.SelectedIndex] = "17";
                }
                else if (result < 5 && result >= 4.5)
                {
                    Lister.Items[listbox.SelectedIndex] = "18";
                }
                else if (result < 5 && result >= 4.9)
                {
                    Lister.Items[listbox.SelectedIndex] = "19";
                }
                else
                {
                    Lister.Items[listbox.SelectedIndex] = "20";
                }
            }
        }
        public void Germany()
        {
            if (type == 3)
            {

                if (result < 3)
                {

                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen1 + " - " + "6" + "\r\n";

                    for (; warning <= 1.5;)
                    {
                        warning = (valueS + 3) / (NumberN + 1);
                        valueS += 3;
                        NumberN += 1;
                        warning = Math.Round(warning, 2);
                        GEN.Text += Properties.Resources.GenN + "5" + Properties.Resources.GenF + warning + "\r\n";

                    }
                    warning = 0;

                }
                else if (result <= 6 && result >= 3)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen2 + "5" + "\r\n";

                    for (; warning <= 3;)
                    {
                        warning = (valueS + 6) / (NumberN + 1);
                        valueS += 6;
                        NumberN += 1;
                        warning = Math.Round(warning, 2);
                        GEN.Text += Properties.Resources.GenN + "4" + Properties.Resources.GenF + warning + "\r\n";
                    }

                    warning = 0;

                }
                else if (result <= 9 && result >= 6)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen2 + "4" + "\r\n";

                    for (; warning <= 4.5;)
                    {
                        warning = (valueS + 9) / (NumberN + 1);
                        valueS += 9;
                        NumberN += 1;
                        warning = Math.Round(warning, 2);
                        GEN.Text += Properties.Resources.GenN + "3" + Properties.Resources.GenF + warning + "\r\n";
                    }

                    warning = 0;

                }
                else if (result <= 12 && result >= 9)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen2 + "3" + "\r\n";

                    for (; warning <= 6;)
                    {
                        warning = (valueS + 12) / (NumberN + 1);
                        valueS += 12;
                        NumberN += 1;
                        warning = Math.Round(warning, 2);
                        GEN.Text += Properties.Resources.GenN + "2" + Properties.Resources.GenF + warning + "\r\n";
                    }

                    warning = 0;

                }
                else if (result <= 15 && result >= 12)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen3 + "2" + "\r\n";

                    for (; warning <= 7.5;)
                    {
                        warning = (valueS + 15) / (NumberN + 1);
                        valueS += 15;
                        NumberN += 1;
                        warning = Math.Round(warning, 2);
                        GEN.Text += Properties.Resources.GenN + "1" + Properties.Resources.GenF + warning + "\r\n";
                    }
                    warning = 0;

                }
                else
                {

                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen4 + " - " + "1" + "\r\n";

                }
                if (result < 3)
                {
                    Lister.Items[listbox.SelectedIndex] = "6";
                }
                else if (result <= 6 && result >= 3)
                {
                    Lister.Items[listbox.SelectedIndex] = "5";
                }
                else if (result <= 9 && result >= 6)
                {
                    Lister.Items[listbox.SelectedIndex] = "4";
                }
                else if (result <= 12 && result >= 9)
                {
                    Lister.Items[listbox.SelectedIndex] = "3";
                }
                else if (result <= 15 && result >= 12)
                {
                    Lister.Items[listbox.SelectedIndex] = "2";
                }
                else
                {
                    Lister.Items[listbox.SelectedIndex] = "1";
                }
            }
        }
        public void Ukraine()
        {
            if (type == 4)
            {
                if (result <= 1.5)
                {

                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen1 + " - " + "1" + "\r\n";

                    for (; warning < 1.6;)
                    {
                        warning = (valueS + 2) / (NumberN + 1);
                        valueS += 2;
                        NumberN += 1;
                        GEN.Text += Properties.Resources.GenN + "2" + Properties.Resources.GenF + warning + "\r\n";
                    }
                    warning = 0;

                }
                else if (result <= 2.5)
                {

                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen1 + " - " + "2" + "\r\n";

                    for (; warning < 2.6;)
                    {
                        warning = (valueS + 3) / (NumberN + 1);
                        valueS += 3;
                        NumberN += 1;
                        GEN.Text += Properties.Resources.GenN + "3" + Properties.Resources.GenF + warning + "\r\n";
                    }
                    warning = 0;

                }
                else if (result <= 3.5)
                {

                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen1 + " - " + "3" + "\r\n";

                    for (; warning < 3.6;)
                    {
                        warning = (valueS + 4) / (NumberN + 1);
                        valueS += 4;
                        NumberN += 1;
                        GEN.Text += Properties.Resources.GenN + "4" + Properties.Resources.GenF + warning + "\r\n";
                    }
                    warning = 0;

                }
                else if (result <= 4.5)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen2 + "4" + "\r\n";

                    for (; warning < 4.6;)
                    {
                        warning = (valueS + 5) / (NumberN + 1);
                        valueS += 5;
                        NumberN += 1;
                        GEN.Text += Properties.Resources.GenN + "5" + Properties.Resources.GenF + warning + "\r\n";
                    }

                    warning = 0;
                }
                else if (result <= 5.5)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen2 + "5" + "\r\n";

                    for (; warning < 5.6;)
                    {
                        warning = (valueS + 6) / (NumberN + 1);
                        valueS += 6;
                        NumberN += 1;
                        GEN.Text += Properties.Resources.GenN + "5" + Properties.Resources.GenF + warning + "\r\n";
                    }

                    warning = 0;
                }
                else if (result <= 6.5)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen2 + "6" + "\r\n";

                    for (; warning < 6.6;)
                    {
                        warning = (valueS + 7) / (NumberN + 1);
                        valueS += 7;
                        NumberN += 1;
                        GEN.Text += Properties.Resources.GenN + "7" + Properties.Resources.GenF + warning + "\r\n";
                    }

                    warning = 0;
                }
                else if (result <= 7.5)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen2 + "7" + "\r\n";

                    for (; warning < 7.6;)
                    {
                        warning = (valueS + 8) / (NumberN + 1);
                        valueS += 8;
                        NumberN += 1;
                        GEN.Text += Properties.Resources.GenN + "8" + Properties.Resources.GenF + warning + "\r\n";
                    }

                    warning = 0;
                }
                else if (result <= 8.5)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen2 + "8" + "\r\n";

                    for (; warning < 8.6;)
                    {
                        warning = (valueS + 9) / (NumberN + 1);
                        valueS += 9;
                        NumberN += 1;
                        GEN.Text += Properties.Resources.GenN + "9" + Properties.Resources.GenF + warning + "\r\n";
                    }

                    warning = 0;
                }
                else if (result <= 9.5)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen2 + "9" + "\r\n";

                    for (; warning < 9.6;)
                    {
                        warning = (valueS + 10) / (NumberN + 1);
                        valueS += 10;
                        NumberN += 1;
                        GEN.Text += Properties.Resources.GenN + "10" + Properties.Resources.GenF + warning + "\r\n";
                    }

                    warning = 0;
                }
                else if (result <= 10.5)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen2 + "10" + "\r\n";

                    for (; warning < 10.6;)
                    {
                        warning = (valueS + 11) / (NumberN + 1);
                        valueS += 11;
                        NumberN += 1;
                        GEN.Text += Properties.Resources.GenN + "11" + Properties.Resources.GenF + warning + "\r\n";
                    }

                    warning = 0;
                }
                else if (result <= 11.5)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen2 + "11" + "\r\n";

                    for (; warning < 11.6;)
                    {
                        warning = (valueS + 12) / (NumberN + 1);
                        valueS += 12;
                        NumberN += 1;
                        GEN.Text += Properties.Resources.GenN + "12" + Properties.Resources.GenF + warning + "\r\n";
                    }

                    warning = 0;
                }
                else
                {

                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen4 + "\r\n";

                }
                Lister.Items[listbox.SelectedIndex] = result;
            }
        }
        public void Belarus()
        {
            if (type == 5)
            {
                if (result <= 1.5)
                {

                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen1 + "\r\n";

                    for (; warning < 1.6;)
                    {
                        warning = (valueS + 2) / (NumberN + 1);
                        valueS += 2;
                        NumberN += 1;
                        GEN.Text += Properties.Resources.GenN + 2 + Properties.Resources.GenF + warning + "\r\n";
                    }
                    warning = 0;

                }
                else if (result <= 2.5)
                {

                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen1 + "\r\n";

                    for (; warning < 2.6;)
                    {
                        warning = (valueS + 3) / (NumberN + 1);
                        valueS += 3;
                        NumberN += 1;
                        GEN.Text += Properties.Resources.GenN + 3 + Properties.Resources.GenF + warning + "\r\n";
                    }
                    warning = 0;

                }
                else if (result <= 3.5)
                {

                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen1 + "\r\n";

                    for (; warning < 3.6;)
                    {
                        warning = (valueS + 4) / (NumberN + 1);
                        valueS += 4;
                        NumberN += 1;
                        GEN.Text += Properties.Resources.GenN + 4 + Properties.Resources.GenF + warning + "\r\n";
                    }
                    warning = 0;

                }
                else if (result <= 4.5)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen2 + "4" + "\r\n";

                    for (; warning < 4.6;)
                    {
                        warning = (valueS + 5) / (NumberN + 1);
                        valueS += 4;
                        NumberN += 1;
                        GEN.Text += Properties.Resources.GenN + 4 + Properties.Resources.GenF + warning + "\r\n";
                    }

                    warning = 0;
                }
                else if (result <= 5.5)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen2 + "5" + "\r\n";

                    for (; warning < 5.6;)
                    {
                        warning = (valueS + 6) / (NumberN + 1);
                        valueS += 6;
                        NumberN += 1;
                        GEN.Text += Properties.Resources.GenN + 5 + Properties.Resources.GenF + warning + "\r\n";
                    }

                    warning = 0;
                }
                else if (result <= 6.5)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen2 + "6" + "\r\n";

                    for (; warning < 6.6;)
                    {
                        warning = (valueS + 7) / (NumberN + 1);
                        valueS += 7;
                        NumberN += 1;
                        GEN.Text += Properties.Resources.GenN + 7 + Properties.Resources.GenF + warning + "\r\n";
                    }

                    warning = 0;
                }
                else if (result <= 7.5)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen2 + "7" + "\r\n";

                    for (; warning < 7.6;)
                    {
                        warning = (valueS + 8) / (NumberN + 1);
                        valueS += 8;
                        NumberN += 1;
                        GEN.Text += Properties.Resources.GenN + 8 + Properties.Resources.GenF + warning + "\r\n";
                    }

                    warning = 0;
                }
                else if (result <= 8.5)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen2 + "8" + "\r\n";

                    for (; warning < 8.6;)
                    {
                        warning = (valueS + 9) / (NumberN + 1);
                        valueS += 9;
                        NumberN += 1;
                        GEN.Text += Properties.Resources.GenN + 9 + Properties.Resources.GenF + warning + "\r\n";
                    }

                    warning = 0;
                }
                else if (result <= 9.5)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen2 + "9" + "\r\n";

                    for (; warning < 9.6;)
                    {
                        warning = (valueS + 10) / (NumberN + 1);
                        valueS += 10;
                        NumberN += 1;
                        GEN.Text += Properties.Resources.GenN + 10 + Properties.Resources.GenF + warning + "\r\n";
                    }

                    warning = 0;
                }
                else
                {

                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen4 + "\r\n";

                }
                Lister.Items[listbox.SelectedIndex] = result;
            }
        }
        public void Czech()
        {
            if (type == 6)
            {
                if (result < 1.5)
                {

                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen1 + " - " + "1" + "\r\n";

                    for (; warning <= 1.5;)
                    {
                        warning = (valueS + 2) / (NumberN + 1);
                        valueS += 2;
                        NumberN += 1;
                        warning = Math.Round(warning, 2);
                        GEN.Text += Properties.Resources.GenN + "2" + Properties.Resources.GenF + warning + "\r\n";

                    }
                    warning = 0;

                }
                else if (result < 2.5)
                {

                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen1 + " - " + "2" + "\r\n";

                    for (; warning <= 2.5;)
                    {
                        warning = (valueS + 3) / (NumberN + 1);
                        valueS += 3;
                        NumberN += 1;
                        warning = Math.Round(warning, 2);
                        GEN.Text += Properties.Resources.GenN + "3" + Properties.Resources.GenF + warning + "\r\n";

                    }
                    warning = 0;

                }
                else if (result < 3.5)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen2 + "3" + "\r\n";

                    for (; warning <= 3.5;)
                    {
                        warning = (valueS + 4) / (NumberN + 1);
                        valueS += 4;
                        NumberN += 1;
                        warning = Math.Round(warning, 2);
                        GEN.Text += Properties.Resources.GenN + "4" + Properties.Resources.GenF + warning + "\r\n";
                    }

                    warning = 0;

                }
                else if (result < 4.5)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen2 + "4" + "\r\n";

                    for (; warning <= 4.5;)
                    {
                        warning = (valueS + 5) / (NumberN + 1);
                        valueS += 5;
                        NumberN += 1;
                        warning = Math.Round(warning, 2);
                        GEN.Text += Properties.Resources.GenN + "5" + Properties.Resources.GenF + warning + "\r\n";
                    }

                    warning = 0;

                }
                else
                {

                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen4 + " - " + "5" + "\r\n";

                }

                    Lister.Items[listbox.SelectedIndex] = result;
            }
        }
        public void Finland()
        {
            if(type == 7)
            {
                if (result <= 4.5)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen1 + " - " + "4" + "\r\n";

                    for (; warning < 4.6;)
                    {
                        warning = (valueS + 5) / (NumberN + 1);
                        valueS += 5;
                        NumberN += 1;
                        warning = Math.Round(warning, 2);
                        GEN.Text += Properties.Resources.GenN + "4" + Properties.Resources.GenF + warning + "\r\n";
                    }

                    warning = 0;
                }
                else if (result <= 5.5)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen2 + "5" + "\r\n";

                    for (; warning < 5.6;)
                    {
                        warning = (valueS + 6) / (NumberN + 1);
                        valueS += 6;
                        NumberN += 1;
                        warning = Math.Round(warning, 2);
                        GEN.Text += Properties.Resources.GenN + "6" + Properties.Resources.GenF + warning + "\r\n";
                    }

                    warning = 0;
                }
                else if (result <= 6.5)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen2 + "6" + "\r\n";

                    for (; warning < 6.6;)
                    {
                        warning = (valueS + 7) / (NumberN + 1);
                        valueS += 7;
                        NumberN += 1;
                        warning = Math.Round(warning, 2);
                        GEN.Text += Properties.Resources.GenN + "7" + Properties.Resources.GenF + warning + "\r\n";
                    }

                    warning = 0;
                }
                else if (result <= 7.5)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen2 + "7" + "\r\n";

                    for (; warning < 7.6;)
                    {
                        warning = (valueS + 8) / (NumberN + 1);
                        valueS += 8;
                        NumberN += 1;
                        warning = Math.Round(warning, 2);
                        GEN.Text += Properties.Resources.GenN + "8" + Properties.Resources.GenF + warning + "\r\n";
                    }

                    warning = 0;
                }
                else if (result <= 8.5)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen2 + "8" + "\r\n";

                    for (; warning < 8.6;)
                    {
                        warning = (valueS + 9) / (NumberN + 1);
                        valueS += 9;
                        NumberN += 1;
                        warning = Math.Round(warning, 2);
                        GEN.Text += Properties.Resources.GenN + "9" + Properties.Resources.GenF + warning + "\r\n";
                    }

                    warning = 0;
                }
                else if (result <= 9.5)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen2 + "9" + "\r\n";

                    for (; warning < 9.6;)
                    {
                        warning = (valueS + 10) / (NumberN + 1);
                        valueS += 10;
                        NumberN += 1;
                        warning = Math.Round(warning, 2);
                        GEN.Text += Properties.Resources.GenN + "10" + Properties.Resources.GenF + warning + "\r\n";
                    }

                    warning = 0;
                }
                else
                {

                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen4 + "\r\n";

                }
                Lister.Items[listbox.SelectedIndex] = result;
            }
        }
        public void Bulgaria()
        {
            if (type == 8)
            {
                if (result < 2.5)
                {

                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen1 + " - " + "2" + "\r\n";

                    for (; warning <= 2.5;)
                    {
                        warning = (valueS + 3) / (NumberN + 1);
                        valueS += 3;
                        NumberN += 1;
                        warning = Math.Round(warning, 2);
                        GEN.Text += Properties.Resources.GenN + "3" + Properties.Resources.GenF + warning + "\r\n";

                    }
                    warning = 0;

                }
                else if (result < 3.5)
                {

                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen1 + " - " + "3" + "\r\n";

                    for (; warning <= 3.5;)
                    {
                        warning = (valueS + 4) / (NumberN + 1);
                        valueS += 4;
                        NumberN += 1;
                        warning = Math.Round(warning, 2);
                        GEN.Text += Properties.Resources.GenN + "4" + Properties.Resources.GenF + warning + "\r\n";

                    }
                    warning = 0;

                }
                else if (result < 4.5)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen2 + "4" + "\r\n";

                    for (; warning <= 4.5;)
                    {
                        warning = (valueS + 5) / (NumberN + 1);
                        valueS += 5;
                        NumberN += 1;
                        warning = Math.Round(warning, 2);
                        GEN.Text += Properties.Resources.GenN + "5" + Properties.Resources.GenF + warning + "\r\n";
                    }

                    warning = 0;

                }
                else if (result < 5.5)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen2 + "5" + "\r\n";

                    for (; warning <= 5.5;)
                    {
                        warning = (valueS + 6) / (NumberN + 1);
                        valueS += 6;
                        NumberN += 1;
                        warning = Math.Round(warning, 2);
                        GEN.Text += Properties.Resources.GenN + "6" + Properties.Resources.GenF + warning + "\r\n";
                    }

                    warning = 0;

                }
                else
                {

                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen4 + " - " + "6" + "\r\n";

                }

                Lister.Items[listbox.SelectedIndex] = result;
            }
        }
        public void Denmark()
        {
            if(type == 9)
            {
                if (result < 0)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen1 + " - " + "F" + "\r\n";

                    for (; warning < 0;)
                    {
                        warning = (valueS + 2) / (NumberN + 1);
                        valueS += 2;
                        NumberN += 1;
                        GEN.Text += Properties.Resources.GenN + "Fx" + Properties.Resources.GenF + warning + "\r\n";
                    }

                    warning = 0;
                }
                else if (result < 2)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen2 + "Fx" + "\r\n";

                    for (; warning < 1;)
                    {
                        warning = (valueS + 2) / (NumberN + 1);
                        valueS += 2;
                        NumberN += 1;
                        GEN.Text += Properties.Resources.GenN + "E" + Properties.Resources.GenF + warning + "\r\n";
                    }

                    warning = 0;
                }
                else if (result < 4)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen2 + "E" + "\r\n";

                    for (; warning < 2;)
                    {
                        warning = (valueS + 4) / (NumberN + 1);
                        valueS += 4;
                        NumberN += 1;
                        GEN.Text += Properties.Resources.GenN + "D" + Properties.Resources.GenF + warning + "\r\n";
                    }

                    warning = 0;
                }
                else if (result < 7)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen2 + "D" + "\r\n";

                    for (; warning < 3.5;)
                    {
                        warning = (valueS + 7) / (NumberN + 1);
                        valueS += 7;
                        NumberN += 1;
                        GEN.Text += Properties.Resources.GenN + "C" + Properties.Resources.GenF + warning + "\r\n";
                    }

                    warning = 0;
                }
                else if (result < 10)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen2 + "C" + "\r\n";

                    for (; warning < 5;)
                    {
                        warning = (valueS + 10) / (NumberN + 1);
                        valueS += 10;
                        NumberN += 1;
                        GEN.Text += Properties.Resources.GenN + "B" + Properties.Resources.GenF + warning + "\r\n";
                    }

                    warning = 0;
                }
                else if (result < 12)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen2 + "B" + "\r\n";

                    for (; warning < 6;)
                    {
                        warning = (valueS + 12) / (NumberN + 1);
                        valueS += 12;
                        NumberN += 1;
                        GEN.Text += Properties.Resources.GenN + "A" + Properties.Resources.GenF + warning + "\r\n";
                    }

                    warning = 0;
                }
                else
                {

                    GEN.Text = Properties.Resources.Gen + "A" + "\r\n";
                    GEN.Text += Properties.Resources.Gen4 + "\r\n";

                }
                if (result < 0)
                {
                    Lister.Items[listbox.SelectedIndex] = "F";
                }
                else if (result < 2)
                {
                    Lister.Items[listbox.SelectedIndex] = "Fx";
                }
                else if (result < 4)
                {
                    Lister.Items[listbox.SelectedIndex] = "E";
                }
                else if (result < 7)
                {
                    Lister.Items[listbox.SelectedIndex] = "D";
                }
                else if (result < 10)
                {
                    Lister.Items[listbox.SelectedIndex] = "C";
                }
                else if (result < 12)
                {
                    Lister.Items[listbox.SelectedIndex] = "B";
                }
                else
                {
                    Lister.Items[listbox.SelectedIndex] = "A";
                }
            }
        }
        public void Custom()
        {
            if (type > 9)
            {
                if (result <= 1.5)
                {

                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen1 + " - " + "1" + "\r\n";

                    for (; warning < 1.6;)
                    {
                        warning = (valueS + 2) / (NumberN + 1);
                        valueS += 2;
                        NumberN += 1;
                        GEN.Text += Properties.Resources.GenN + "2" + Properties.Resources.GenF + warning + "\r\n";
                    }
                    warning = 0;

                }
                else if (result <= 2.5)
                {

                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen1 + " - " + "2" + "\r\n";

                    for (; warning < 2.6;)
                    {
                        warning = (valueS + 3) / (NumberN + 1);
                        valueS += 3;
                        NumberN += 1;
                        GEN.Text += Properties.Resources.GenN + "3" + Properties.Resources.GenF + warning + "\r\n";
                    }
                    warning = 0;

                }
                else if (result <= 3.5)
                {

                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen1 + " - " + "3" + "\r\n";

                    for (; warning < 3.6;)
                    {
                        warning = (valueS + 4) / (NumberN + 1);
                        valueS += 4;
                        NumberN += 1;
                        GEN.Text += Properties.Resources.GenN + "4" + Properties.Resources.GenF + warning + "\r\n";
                    }
                    warning = 0;

                }
                else if (result <= 4.5)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen2 + "4" + "\r\n";

                    for (; warning < 4.6;)
                    {
                        warning = (valueS + 5) / (NumberN + 1);
                        valueS += 5;
                        NumberN += 1;
                        GEN.Text += Properties.Resources.GenN + "5" + Properties.Resources.GenF + warning + "\r\n";
                    }

                    warning = 0;
                }
                else if (result <= 5.5)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen2 + "5" + "\r\n";

                    for (; warning < 5.6;)
                    {
                        warning = (valueS + 6) / (NumberN + 1);
                        valueS += 6;
                        NumberN += 1;
                        GEN.Text += Properties.Resources.GenN + "5" + Properties.Resources.GenF + warning + "\r\n";
                    }

                    warning = 0;
                }
                else if (result <= 6.5)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen2 + "6" + "\r\n";

                    for (; warning < 6.6;)
                    {
                        warning = (valueS + 7) / (NumberN + 1);
                        valueS += 7;
                        NumberN += 1;
                        GEN.Text += Properties.Resources.GenN + "7" + Properties.Resources.GenF + warning + "\r\n";
                    }

                    warning = 0;
                }
                else if (result <= 7.5)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen2 + "7" + "\r\n";

                    for (; warning < 7.6;)
                    {
                        warning = (valueS + 8) / (NumberN + 1);
                        valueS += 8;
                        NumberN += 1;
                        GEN.Text += Properties.Resources.GenN + "8" + Properties.Resources.GenF + warning + "\r\n";
                    }

                    warning = 0;
                }
                else if (result <= 8.5)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen2 + "8" + "\r\n";

                    for (; warning < 8.6;)
                    {
                        warning = (valueS + 9) / (NumberN + 1);
                        valueS += 9;
                        NumberN += 1;
                        GEN.Text += Properties.Resources.GenN + "9" + Properties.Resources.GenF + warning + "\r\n";
                    }

                    warning = 0;
                }
                else if (result <= 9.5)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen2 + "9" + "\r\n";

                    for (; warning < 9.6;)
                    {
                        warning = (valueS + 10) / (NumberN + 1);
                        valueS += 10;
                        NumberN += 1;
                        GEN.Text += Properties.Resources.GenN + "10" + Properties.Resources.GenF + warning + "\r\n";
                    }

                    warning = 0;
                }
                else if (result <= 10.5)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen2 + "10" + "\r\n";

                    for (; warning < 10.6;)
                    {
                        warning = (valueS + 11) / (NumberN + 1);
                        valueS += 11;
                        NumberN += 1;
                        GEN.Text += Properties.Resources.GenN + "11" + Properties.Resources.GenF + warning + "\r\n";
                    }

                    warning = 0;
                }
                else if (result <= 11.5)
                {
                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen2 + "11" + "\r\n";

                    for (; warning < 11.6;)
                    {
                        warning = (valueS + 12) / (NumberN + 1);
                        valueS += 12;
                        NumberN += 1;
                        GEN.Text += Properties.Resources.GenN + "12" + Properties.Resources.GenF + warning + "\r\n";
                    }

                    warning = 0;
                }
                else
                {

                    GEN.Text = Properties.Resources.Gen + result + "\r\n";
                    GEN.Text += Properties.Resources.Gen4 + "\r\n";

                }
                Lister.Items[listbox.SelectedIndex] = result;
            }
        
        
        }

        public void BackgroundN()
        {
            bg = 1;
            Root.Background = Brushes.Black;
            Lister.Foreground = Brushes.White;
            EnterC.Foreground = Brushes.White;
            Textbox1.Foreground = Brushes.White;
            Name.Foreground = Brushes.White;
            Sername.Foreground = Brushes.White;
            Namer.Foreground = Brushes.White;
            Result.Foreground = Brushes.White;
            DialogeW.Foreground = Brushes.White;
            GEN.Foreground = Brushes.White;
            Score.Foreground = Brushes.White;
        }
        public void BackgroundU()
        {
            bg = 0;
            
            Root.Background = Brushes.White;
            Lister.Foreground = Brushes.Black;
            EnterC.Foreground = Brushes.Black;
            Textbox1.Foreground = Brushes.Black;
            Name.Foreground = Brushes.Black;
            Sername.Foreground = Brushes.Black;
            Namer.Foreground = Brushes.Black;
            Result.Foreground = Brushes.Black;
            DialogeW.Foreground = Brushes.Black;
            GEN.Foreground = Brushes.Black;
            Score.Foreground = Brushes.Black;
        }

        public void Bold()
        {
            fs = 1;
            listbox.FontWeight = FontWeights.Bold;
            Menu.FontWeight = FontWeights.Bold;
            Lister.FontWeight = FontWeights.Bold;
            EnterC.FontWeight = FontWeights.Bold;
            Textbox1.FontWeight = FontWeights.Bold;
            Name.FontWeight = FontWeights.Bold;
            Sername.FontWeight = FontWeights.Bold;
            Namer.FontWeight = FontWeights.Bold;
            Result.FontWeight = FontWeights.Bold;
            GEN.FontWeight = FontWeights.Bold;
            Score.FontWeight = FontWeights.Bold;
            Clicker.FontWeight = FontWeights.Bold;
            Namer.Height = 40;
            Result.Margin = new Thickness(262, 223, 0, 0);
            Tres.Margin = new Thickness(262, 246, 0, 0);
        }
        public void Italic()
        {
            fs = 2;
            listbox.FontStyle = FontStyles.Italic;
            Menu.FontStyle = FontStyles.Italic;
            Lister.FontStyle = FontStyles.Italic;
            EnterC.FontStyle = FontStyles.Italic;
            Textbox1.FontStyle = FontStyles.Italic;
            Name.FontStyle = FontStyles.Italic;
            Sername.FontStyle = FontStyles.Italic;
            Namer.FontStyle = FontStyles.Italic;
            Result.FontStyle = FontStyles.Italic;
            GEN.FontStyle = FontStyles.Italic;
            Score.FontStyle = FontStyles.Italic;
            Clicker.FontStyle = FontStyles.Italic;
        }
        public void Underline()
        {
            fs = 3;
            EnterC.TextDecorations = TextDecorations.Underline;
            Textbox1.TextDecorations = TextDecorations.Underline;
            Name.TextDecorations = TextDecorations.Underline;
            Sername.TextDecorations = TextDecorations.Underline;
            Namer.TextDecorations = TextDecorations.Underline;
            Result.TextDecorations = TextDecorations.Underline;
            GEN.TextDecorations = TextDecorations.Underline;
            Clicker.TextDecorations = TextDecorations.Underline;
        }
        public void Normal()
        {
            fs = 0;
            listbox.FontWeight = FontWeights.Normal;
            Menu.FontWeight = FontWeights.Normal;
            Lister.FontWeight = FontWeights.Normal;
            EnterC.FontWeight = FontWeights.Normal;
            Textbox1.FontWeight = FontWeights.Normal;
            Name.FontWeight = FontWeights.Normal;
            Sername.FontWeight = FontWeights.Normal;
            Namer.FontWeight = FontWeights.Normal;
            Result.FontWeight = FontWeights.Normal;
            GEN.FontWeight = FontWeights.Normal;
            Score.FontWeight = FontWeights.Normal;
            listbox.FontStyle = FontStyles.Normal;
            Clicker.FontStyle = FontStyles.Normal;
            Menu.FontStyle = FontStyles.Normal;
            Lister.FontStyle = FontStyles.Normal;
            EnterC.FontStyle = FontStyles.Normal;
            Textbox1.FontStyle = FontStyles.Normal;
            Name.FontStyle = FontStyles.Normal;
            Sername.FontStyle = FontStyles.Normal;
            Namer.FontStyle = FontStyles.Normal;
            Result.FontStyle = FontStyles.Normal;
            GEN.FontStyle = FontStyles.Normal;
            Score.FontStyle = FontStyles.Normal;
            Clicker.FontStyle = FontStyles.Normal;
            Result.TextDecorations = null;
            EnterC.TextDecorations = null;
            Textbox1.TextDecorations = null;
            Name.TextDecorations = null;
            Sername.TextDecorations = null;
            Namer.TextDecorations = null;
            Tres.TextDecorations = null;
            GEN.TextDecorations = null;
            Clicker.TextDecorations = null;
        }
        
        public void ColorPickSC()
        {
            SolidColorBrush ck = (SolidColorBrush)new BrushConverter().ConvertFromString(cj);
            Lister.Foreground = ck;
            EnterC.Foreground = ck;
            Textbox1.Foreground = ck;
            Name.Foreground = ck;
            Sername.Foreground = ck;
            Namer.Foreground = ck;
            Tres.Foreground = ck;
            DialogeW.Foreground = ck;
            GEN.Foreground = ck;
            Score.Foreground = ck;
            Clicker.Foreground = ck;
            Result.Foreground = ck;
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
            //Language pick
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
            if (lang == 6)
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("cs-CZ");
            }
            if (lang == 7 )
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("fi-FI");
            }
            if (lang == 8)
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("bg-BG");
            }
            if (lang == 9)
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("da-DK");
            }
            
            InitializeComponent();
            File.WriteAllText("Exit.txt", "0");
            check = Int32.Parse(File.ReadLines("Settings.txt").Skip(1).First());
            type = Int32.Parse(File.ReadLines("Settings.txt").Skip(9).First());
           
            ColorPick.IsEnabled = false;
            ColorPick.Visibility = Visibility.Hidden;
            Namer.IsEnabled = false;
            listbox.IsEnabled = false;
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

                GPAEng();

                Score.Height = 210;
                Score.Margin = new Thickness(162, 197, 0, 0);
            }
            //French
            if (type == 2)
            {

                C2.Visibility = Visibility.Visible;

                GPAFra();
               
                T5.Width = 38;
                Score.Height = 255;
                Score.Margin = new Thickness(162, 152, 0, 0);
            }
            //German
            if (type == 3)
            {

                C3.Visibility = Visibility.Visible;
                C2.Visibility = Visibility.Visible;

                GPAGer();
               
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

                GPADen();

                Score.Height = 210;
                Score.Margin = new Thickness(162, 197, 0, 0);
            }
            //Custom
            if (type > 9)
            {
                double heightS = Score.Height;
                double posS = Score.Margin.Top;
               
                string path = File.ReadAllText("NameEST.txt");
                int buttons = Int32.Parse(File.ReadLines(@"C:\Users\TopDesktop-1\source\repos\WarningList 1Exp\WarningList\bin\Debug\ESTData\" + path + ".txt").Skip(1).First());
                int gpa = Int32.Parse(File.ReadLines(@"C:\Users\TopDesktop-1\source\repos\WarningList 1Exp\WarningList\bin\Debug\ESTData\" + path + ".txt").Skip(3).First());
                int en = 1;

                    foreach (UIElement es in Buttons.Children)
                    {

                        if (es is Button)
                        {

                            ((Button)es).Visibility = Visibility.Visible;


                        }
                        if(en >= 4)
                    {
                        heightS -= 25;
                        posS += 25;
                    }
                    if (en == buttons)
                    {
                        break;
                      
                    }
                    en++;
                    Score.Height = heightS;
                    Score.Margin = new Thickness(162, posS, 0, 0);

                }

                switch(gpa)
                {
                    case 0:
                        break;
                    case 1:
                        GPAEng();
                        break;
                    case 2:
                        GPAGer();
                        break;
                    case 3:
                        GPAFra();
                        break;
                    case 4:
                        GPADen();
                        break;
                }




            }
            if (lang == 2 || lang == 3 || lang == 6)
            {
                Namer.Height = 40;
                Result.Margin = new Thickness(262, 223, 0, 0);
                Tres.Margin = new Thickness(262, 246, 0, 0);
            }
            //Russian - 0

            foreach (UIElement el in Buttons.Children)
                {
                    if (el is Button)
                    {
                        ((Button)el).Click += Button_Click;
                        ((Button)el).IsEnabled = false;
                    }
                
                }

            if (check == 1)
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
                  
                    //listbox.Items.Add(sizeN);
                    Lister.Items.Add(new ListBoxItem() { Content = "-"});
                    listbox.Items.Add(new ListBoxItem() { Content = sizeH, Background = Brushes.Red });
                    listbox.SelectedItem = sizeH;
                    Count++;
                    Namer.IsEnabled = false;
                    listbox.IsEnabled = true;
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
                    listbox.Items.Insert(listbox.SelectedIndex, new ListBoxItem() { Content = sizeG, Background = Brushes.Red});
                    listbox.Items.Remove(listbox.SelectedItem);
                    Namer.IsEnabled = false;
                    listbox.IsEnabled = true;
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

        //Function name and surname input 
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
            BackgroundN();
        }
        private void Background_Unchecked(object sender, RoutedEventArgs e)
        {
            BackgroundU();
        }
        
        //Mouse right click menu
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show(Properties.Resources.Sure, Properties.Resources.Box2, MessageBoxButton.YesNo, MessageBoxImage.Warning);
            switch (result)
            {
                case MessageBoxResult.Yes:

                    listbox.IsEnabled = false;
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
                        Lister.Items.RemoveAt(listbox.SelectedIndex);
                        listbox.Items.Remove(listbox.SelectedItem);
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
                    //listbox.IsEnabled = true;
                    listbox.IsEnabled = false;
                    Namer.IsEnabled = true;
                    DialogeW.Text = Properties.Resources.Dialoge7;
                    //nnr.Show();
                    
                    break;
                case MessageBoxResult.No:

                    break;
            }
        }

        //Fonts pick
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
            for (int g= 0; g < listbox.Items.Count; g++)
            {
                Lister.Items.Add( new ListBoxItem() { Content = "-"});
            }
      
            Tresult = 0;
            sizeS = 0;


        }
    
        private void Complete_Click(object sender, RoutedEventArgs e)
        {
            Count = sizeS;
            Res();
        }

        private void listbox_Drop(object sender, DragEventArgs e)
        {
            drop = true;
            
        }

        //Load function
        private void Window_Activated(object sender, EventArgs e)
        {

            Count = listbox.Items.Count;
            file = Int32.Parse(File.ReadLines("File.txt").First());
            if (file == 1)
            {
                Name.IsEnabled = false;
                Menu.IsEnabled = true;
                listbox.IsEnabled = true;
                n.Close();

                int strings = System.IO.File.ReadAllLines("Save.txt").Length;


                listbox.Items.Clear();
                Lister.Items.Clear();

                Name.Text = File.ReadLines("Save.txt").First();
                Sername.Text = File.ReadLines("Save.txt").Skip(1).First();
                bg = Int32.Parse(File.ReadLines("Save.txt").Skip(2).First());
                fs = Int32.Parse(File.ReadLines("Save.txt").Skip(3).First());
                cj = File.ReadLines("Save.txt").Skip(4).First();
               
                if(bg == 1)
                {
                    BackgroundN();
                }
                else 
                {
                    BackgroundU();
                }
                switch(fs)
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
                ColorPickSC();
                countS = strings / 3 + 4;
                countE = strings - countS + 5;
                int y = countE;
                for (int s = 5; s < countS; s++)
                {

                    string ch = File.ReadLines("Save.txt").Skip(y).First();
                    SolidColorBrush ckl = (SolidColorBrush)new BrushConverter().ConvertFromString(ch);
                    listbox.Items.Add(new ListBoxItem() { Content = File.ReadLines("Save.txt").Skip(s).First(), Background = ckl });
                    y++;

                }

                for (int sf = countS; sf < countE; sf++)
                {
                    Lister.Items.Add(new ListBoxItem() { Content = File.ReadLines("Save.txt").Skip(sf).First() });
                }

                file = 0;
                File.WriteAllText("File.txt", file.ToString());


            }
            //Name, Surname
            if (File.ReadAllText(@"Sername.txt") != "\t")
            {

                Name.IsEnabled = false;
                Menu.IsEnabled = true;
                listbox.IsEnabled = true;
                Sername.IsReadOnly = true;
                Name.Text = File.ReadAllText(@"Name.txt");
                Sername.Text = File.ReadAllText(@"Sername.txt");
                File.WriteAllText(@"Name.txt", "\t");
                File.WriteAllText(@"Sername.txt","\t");

            }

        }
        //Save function
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
                        w.WriteLine(bg);
                        w.WriteLine(fs);
                        w.WriteLine(cj);
                        foreach (ListBoxItem s in listbox.Items)
                        {
                            string str = s.Content + " ";
                            w.WriteLine(str);
                        }
                        foreach (ListBoxItem sr in Lister.Items)
                        {
                            string ster = sr.Content + " ";
                            w.WriteLine(ster);
                        }
                        foreach (ListBoxItem fs in listbox.Items)
                        {
                            string str = fs.Background + " ";
                            w.WriteLine(str);
                        }

                    }
                    Name.IsEnabled = false;
                    break;
                case MessageBoxResult.No:

                    break;

            }
         
        }

        private void Root_KeyDown(object sender, KeyEventArgs e)
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
                        //Russian
                        Russian();
                        //English
                        English();
                        //French
                        French();
                        //Germany
                        Germany();
                        //Ukraine
                        Ukraine();
                        //Belarus
                        Belarus();
                        //Czech
                        Czech();
                        //Finland
                        Finland();
                        //Bulgaria
                        Bulgaria();
                        //Denmark
                        Denmark();

                        value = 0;
                        result = 0;
                        ClickS = 0;
                        sizeC = 0;
                        if (Lister.Items[listbox.SelectedIndex] != "-")
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
                        listbox.IsEnabled = true;
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

        //Color pick
        private void AE_Click(object sender, RoutedEventArgs e)
        {
            ColorPick.IsEnabled = true;
            ColorPick.Visibility = Visibility.Visible;
            Namer.IsEnabled = true;
            listbox.IsEnabled = true;
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

        private void AP_Click(object sender, RoutedEventArgs e)
        {
            ColorPick.IsEnabled = false;
            ColorPick.Visibility = Visibility.Hidden;
            Namer.IsEnabled = false;
            listbox.IsEnabled = false;
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

        private void R_Click(object sender, RoutedEventArgs e)
        {
            ColorPick.IsEnabled = false;
            ColorPick.Visibility = Visibility.Hidden;
            Namer.IsEnabled = false;
            listbox.IsEnabled = true;
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

        //Menu Color
        private void Color_Click(object sender, RoutedEventArgs e)
        {
            ColorPick.IsEnabled = true;
            ColorPick.Visibility = Visibility.Visible;
     
            cls2++;
        }
        //Menu Font
        private void FontColor_Click(object sender, RoutedEventArgs e)
        {
            ColorPick.IsEnabled = true;
            ColorPick.Visibility = Visibility.Visible;
            cls++;
        }

 
        //ColorPicker
        private void ColorPick_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            if (cls == 1)
            {
                cj = ColorPick.SelectedColor.Value.ToString();
                switch (fs)
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
                ColorPickSC();
                DialogeW.Text = Properties.Resources.Dialoge8;
            }
            if(cls2 == 1)
            {
                string c1 = ColorPick.SelectedColor.Value.ToString();
                SolidColorBrush ck = (SolidColorBrush)new BrushConverter().ConvertFromString(c1);

                ListBoxItem lbi = listbox.Items[listbox.SelectedIndex] as ListBoxItem;
                lbi.Background = ck;
                DialogeW.Text = Properties.Resources.Dialoge8;

            }


            DialogeW.Text = Properties.Resources.Dialoge2;



        }
        //Count elements in array
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
        private void ListBox_SelectionChanged1(object sender, SelectionChangedEventArgs e)
        {
           
            cls = 0;
            cls2 = 0;

            //Item pick

            DialogeW.Text = Properties.Resources.Dialoge2;
            if (delete == false && drop == false && edit == false)
            {
                resultrt = MessageBox.Show(Properties.Resources.Sure, Properties.Resources.Box2, MessageBoxButton.YesNo, MessageBoxImage.Warning);

                switch (resultrt)
                {
                    case MessageBoxResult.Yes:
                        EnterC.IsEnabled = true;
                        listbox.IsEnabled = false;
                        break;
                    case MessageBoxResult.No:

                        listbox.SelectedItem = false;
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
//(c)AMProgramms, 2021
//Ultra main fuctions
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
                valueS = value;
                result = value / ClickS ;
               result = Math.Round(result, 2);
               
                
               
                TotalResult += result;
                //Russian
                Russian();
                //English
                English();
                //French
                French();
                //Germany
                Germany();
                //Ukraine
                Ukraine();
                //Belarus
                Belarus();
                //Czech
                Czech();
                //Finland
                Finland();
                //Bulgaria
                Bulgaria();
                //Denmark
                Denmark();
                //Custom
                Custom();

                    value = 0;
                result = 0;
                ClickS = 0;
                sizeC = 0;
                if (Lister.Items[listbox.SelectedIndex] != "-")
                {
                    sizeS++;
                }
                else
                {

                }
                EnterC.IsEnabled = true;
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
                listbox.IsEnabled = true;
                Score.Items.Clear();
            }
            Res();


        }

       
    }
}
//(c)AMProgramms, 2021