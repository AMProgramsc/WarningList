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
        int debugCheck = Int32.Parse(File.ReadLines("Settings.txt").Skip(1).First());
        int FscreenCheck = Int32.Parse(File.ReadLines("Settings.txt").Skip(3).First());
        int progressbarCheck = Int32.Parse(File.ReadLines("Settings.txt").Skip(5).First());
        int languageCheck = Int32.Parse(File.ReadLines("Settings.txt").Skip(7).First());
        int typeCheck = Int32.Parse(File.ReadLines("Settings.txt").Skip(9).First());
        int autoCheck = Int32.Parse(File.ReadLines("Settings.txt").Skip(11).First());
        int summarymodeCheck = Int32.Parse(File.ReadLines("Settings.txt").Skip(13).First());
        int editCustomEST;
        public int _width =100;
        public int _height = 100;

        public void WriteAllSettings()
        {
            using (StreamWriter w = new StreamWriter("Settings.txt", false, Encoding.GetEncoding(1251)))
            {
                w.WriteLine("Debug:");
                w.WriteLine(debugCheck.ToString());
                w.WriteLine("Fullscreen:");
                w.WriteLine(FscreenCheck.ToString());
                w.WriteLine("Progressbar:");
                w.WriteLine(progressbarCheck.ToString());
                w.WriteLine("Language:");
                w.WriteLine(languageCheck.ToString());
                w.WriteLine("TypeSys:");
                w.WriteLine(typeCheck.ToString());
                w.WriteLine("Auto:");
                w.WriteLine(autoCheck.ToString());
                w.WriteLine("SummaryMode:");
                w.WriteLine(summarymodeCheck.ToString());
            }
        }
    
        public Settings()
        {
         
            InitializeComponent();
            this.DataContext = CurrentModel;
     
            if (debugCheck == 1)
            {
                Debug.IsChecked = true;
                Texter.Clear();
            }
            if (FscreenCheck == 1)
            {
                Fullscreen.IsChecked = true;
                Texter.Clear();
            }
            if (progressbarCheck == 1)
            {
                Pb.IsChecked = true;
                Texter.Clear();
            }
            
            if (autoCheck == 1)
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
           
            debugCheck = 1;
            Texter.Foreground = Brushes.Green;
            Texter.Text = Properties.Resources.Succeses;

            WriteAllSettings();


        }

        private void Debug_Unchecked(object sender, RoutedEventArgs e)
        {
            debugCheck = 0;
            Texter.Foreground = Brushes.Green;
            Texter.Text = Properties.Resources.Succeses;

            WriteAllSettings();
        }

        private void Fullscreen_Checked(object sender, RoutedEventArgs e)
        {
           
            FscreenCheck = 1;
            Texter.Foreground = Brushes.Green;
            Texter.Text = Properties.Resources.Succeses;

            WriteAllSettings();
        }

        private void Fullscreen_Unchecked(object sender, RoutedEventArgs e)
        {

            FscreenCheck = 0;
            Texter.Foreground = Brushes.Green;
            Texter.Text = Properties.Resources.Succeses;

            WriteAllSettings();
        }
        private void Progressbar_Checked(object sender, RoutedEventArgs e)
        {
            progressbarCheck = 1;
            Texter.Foreground = Brushes.Green;
            Texter.Text = Properties.Resources.Succeses;


            WriteAllSettings();
        }
        private void Progressbar_Unchecked(object sender, RoutedEventArgs e)
        {
            progressbarCheck = 0;
            Texter.Foreground = Brushes.Green;
            Texter.Text = Properties.Resources.Succeses;

            WriteAllSettings();
        }
        private void Auto_Checked(object sender, RoutedEventArgs e)
        {
            autoCheck = 1;
            WriteAllSettings();
        }

        private void Auto_Unchecked(object sender, RoutedEventArgs e)
        {
            autoCheck = 0;
            WriteAllSettings();
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
        private void Progressbar_MouseEnter(object sender, MouseEventArgs e)
        {
            Texter.Text = Properties.Resources.Pb;
        }
        private void Progressbar_MouseLeave(object sender, MouseEventArgs e)
        {
            Texter.Clear();
            Texter.Foreground = Brushes.White;
        }

        private void Lang_Checked(object sender, RoutedEventArgs e)
        {
            var radioButton = sender as RadioButton;
            languageCheck = Convert.ToInt32(radioButton.TabIndex.ToString());
            if (autoCheck == 1)
            {
                typeCheck = languageCheck;
            }
            WriteAllSettings();
        }
        private void Sys_Checked(object sender, RoutedEventArgs e)
        {
            var radioButton = sender as RadioButton;
            typeCheck = Convert.ToInt32(radioButton.TabIndex.ToString());

            WriteAllSettings();

            if (radioButton.TabIndex > 9)
            {
                File.WriteAllText("NameEST.txt", radioButton.Name);
            }
            
        }
        private void SummaryMode_Checked(object sender, RoutedEventArgs e)
        {
            summarymodeCheck = 1;
            WriteAllSettings();
        }
        private void SummaryMode_Unchecked(object sender, RoutedEventArgs e)
        {
            summarymodeCheck = 0;
            WriteAllSettings();
        }
        private void Auto_MouseEnter(object sender, MouseEventArgs e)
        {
            Texter.Text = Properties.Resources.AutoT;
        }

        private void Auto_MouseLeave(object sender, MouseEventArgs e)
        {
            Texter.Clear();
        }
        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show(Properties.Resources.Box2, Properties.Resources.Sure, MessageBoxButton.YesNo, MessageBoxImage.Warning);

            switch (result)
            {
                case MessageBoxResult.Yes:
                    autoCheck = 1;
                    typeCheck = 0;
                    languageCheck = 0;
                    FscreenCheck = 0;
                    progressbarCheck = 0;
                    debugCheck = 0;
                    WriteAllSettings();
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
            CET.BCount.IsEnabled = false;
            CET.Btype.IsEnabled = false;
            CET.LoadImagePath.Clear();
            CET.NameET.Clear();
            CET.Add.Content = "Add";
            CET.EType.SelectedIndex = -1;
            CET.Btype.SelectedIndex = -1;
            CET.BCount.SelectedIndex = -1;
            CET.Show();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            try
            {
                if (CET.savedataFCustomEST == 1)
                {
                    if(editCustomEST == 1)
                    {
                        var Lines = File.ReadAllLines("EST.txt");
                        int i = 0;

                        for (; i < Lines.Length; i++)
                        {
                            if (Lines[i] == ((RadioButton)Tsys.SelectedValue).Name.ToString())
                            {
                                int type = Int32.Parse(File.ReadLines("EST.txt").Skip(i + 4).First());

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
                        System.IO.File.Delete(System.IO.Path.Combine("ESTData", ((RadioButton)Tsys.SelectedValue).Name.ToString() + ".txt"));
                        Tsys.Items.Remove(Tsys.SelectedItem);
                        editCustomEST = 0;
                    }
                    WrapPanel wrapPanel = new WrapPanel();
                    RadioButton rdn = new RadioButton();
                    if (CET.LoadImagePath.Text != "")
                    {
                        ImageSource image = new ImageSourceConverter().ConvertFromString(CET.LoadImagePath.Text) as ImageSource;
                        wrapPanel.Children.Add(new Image { Source = image, Width = 17, Height = 15 });
                    }
                    wrapPanel.Children.Add(new TextBlock { Text = CET.NameET.Text, Foreground = Brushes.White  , Name = CET.NameET.Text });
                    rdn.Name = CET.NameET.Text;
                    rdn.TabIndex = CET.tabindexType;
                    rdn.Content = wrapPanel;

                        using (StreamWriter w = new StreamWriter("EST.txt", true, Encoding.Default))
                        {
                            w.WriteLine("Name:");
                            w.WriteLine(CET.NameET.Text);
                            w.WriteLine("ImagePath:");
                            w.WriteLine(CET.LoadImagePath.Text);
                            w.WriteLine("TabIndex:");
                            w.WriteLine(CET.tabindexType.ToString());
                        }
                    if (CET.tabindexType > 9)
                    {
                        using (StreamWriter f = new StreamWriter(System.IO.Path.Combine("ESTData" , CET.NameET.Text + ".txt") ))
                        {
                            f.WriteLine("Buttons:");
                            f.WriteLine(CET.buttonsCount);
                            f.WriteLine("Buttonstype:");
                            f.WriteLine(CET.Btype.SelectedIndex);
                            f.WriteLine("ButtonsColor:");
                            foreach (ListBoxItem fs in CET.ButtonsList.Items)
                            {
                                string str = fs.Background + "";
                                f.WriteLine(str);
                            }
                            f.WriteLine("ButtonsContent:");
                            foreach (ListBoxItem fs in CET.ButtonsList.Items)
                            {
                                string str = fs.Content + "";
                                f.WriteLine(str);
                            }
                            f.WriteLine("ButtonsType:");
                            if (CET.Btype.SelectedIndex == 5)
                            {
                                foreach (ListBoxItem fs in CET.ButtonSupplement.Items)
                                {
                                    string str = fs.Content + "";
                                    f.WriteLine(str);
                                }
                            }
                            else
                            {
                                foreach (ListBoxItem fs in CET.ButtonSupplement.Items)
                                {
                                    string str = "";
                                    f.WriteLine(str);
                                }
                            }
                        }
                    }
                
                        Tsys.Items.Add(rdn);

                    CET.savedataFCustomEST = 0;
                    CET.LoadImagePath.Clear();
                    CET.NameET.Clear();
                    CET.ButtonsList.Items.Clear();
                    CET.ButtonSupplement.Items.Clear();
                    CET.Add.Content = "Add";
                    CET.EType.SelectedIndex = -1;
                    CET.Btype.SelectedIndex = -1;
                    CET.BCount.SelectedIndex = -1;
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
                   
                    var Lines = File.ReadAllLines("EST.txt");
                    int i = 0;

                    for(; i < Lines.Length; i++)
                    {
                        if(Lines[i] == ((RadioButton)Tsys.SelectedValue).Name.ToString())
                        {
                            int type = Int32.Parse(File.ReadLines("EST.txt").Skip(i + 4).First());
                            if (type > 9)
                            {
                                System.IO.File.Delete(System.IO.Path.Combine("ESTData", ((RadioButton)Tsys.SelectedValue).Name.ToString() + ".txt"));
                            }
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

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult resultEdit = MessageBox.Show("Are you sure?","Sure",MessageBoxButton.YesNo, MessageBoxImage.Question);
            try
            {
                if (resultEdit == MessageBoxResult.Yes)
                {
                 
                    if (Tsys.SelectedIndex > 9)
                    {
                        CET.Show();
                        var Lines = File.ReadAllLines("EST.txt");
                        string path = File.ReadAllText("NameEST.txt");
                        int buttons = Int32.Parse(File.ReadLines(System.IO.Path.Combine("ESTData", path + ".txt")).Skip(1).First());
                        int types = buttons * 2;
                        int gpa = Int32.Parse(File.ReadLines(System.IO.Path.Combine("ESTData", path + ".txt")).Skip(3).First());
                        int strings = System.IO.File.ReadAllLines(System.IO.Path.Combine("ESTData", path + ".txt")).Length;
                        int y = 5;
                        int g = strings / 3 + 4;
                        int z = strings - g + 6;
                        int h = g - 1;
                        int i = 0;


                        for (; i < Lines.Length; i++)
                        {
                            if (Lines[i] == ((RadioButton)Tsys.SelectedValue).Name.ToString())
                            {
                                int type = Int32.Parse(File.ReadLines("EST.txt").Skip(i + 4).First());
                                if (type > 9)
                                {

                                }
                                CET.NameET.Text = ((RadioButton)Tsys.SelectedValue).Name.ToString();
                                CET.LoadImagePath.Text = Lines[i + 2];
                                CET.EType.SelectedIndex = Int32.Parse(Lines[i + 4]);
                                CET.BCount.SelectedIndex = Int32.Parse(File.ReadLines(System.IO.Path.Combine("ESTData", path + ".txt")).Skip(1).First()) - 4;
                                CET.Btype.SelectedIndex = Int32.Parse(File.ReadLines(System.IO.Path.Combine("ESTData", path + ".txt")).Skip(3).First());
                                editCustomEST = 1;
                                CET.Add.Content = "Edit";
                                CET.ButtonsList.Items.Clear();
                                CET.ButtonSupplement.Items.Clear();
                                for (int s = y; s < h; s++)
                                {

                                    string ch = File.ReadLines(System.IO.Path.Combine("ESTData", path + ".txt")).Skip(s).First();
                                    SolidColorBrush ckl = (SolidColorBrush)new BrushConverter().ConvertFromString(ch);
                                    CET.ButtonsList.Items.Add(new ListBoxItem() { Content = File.ReadLines(System.IO.Path.Combine("ESTData", path + ".txt")).Skip(g).First(), Background = ckl, HorizontalContentAlignment = HorizontalAlignment.Center });
                                    g++;

                                }

                                for (int sf = z; sf < strings; sf++)
                                {

                                    CET.ButtonSupplement.Items.Add(new ListBoxItem() { Content = File.ReadLines(System.IO.Path.Combine("ESTData", path + ".txt")).Skip(sf).First(), Foreground = Brushes.White });
                                }

                                break;
                            }
                        }


                    }
                    else
                    {
                        MessageBox.Show("Error", "System item cannot be edited", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                   
                }
             
               
            }

            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

    }
}
//(c)AMProgramms, 2021