using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для WindowLoad.xaml
    /// </summary>
    public partial class WindowLoad : Window
    {
       
        
        MainWindow window = new MainWindow();
        About about = new About();

        Informations info = new Informations();
        Version ver = new Version();
        Settings set = new Settings();
        int screen = 0;
        int pb = 0;
        int lang = 0;
        int exit = 0, exit1 = 0;
        int mainE;
        int file = 0;
        int countS;
        public WindowLoad()
        {



            InitializeComponent();


            T.IsEnabled = false;
            pb = Int32.Parse(File.ReadLines("Settings.txt").Skip(5).First());

            if (screen == 1)
            {
                WindowState = WindowState.Maximized;
            }
            if (pb == 1)
            {
                ProgressLoad.Visibility = Visibility.Hidden;
            }
          
        }


        private void Window_ContentRendered(object sender, EventArgs e)
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.DoWork += worker_DoWork;
            worker.ProgressChanged += worker_ProgressChanged;

            worker.RunWorkerAsync();

        }
        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                (sender as BackgroundWorker).ReportProgress(i);
                Thread.Sleep(25);
            }

        }



        void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

            ProgressLoad.Value = e.ProgressPercentage;
            if (ProgressLoad.Value == 100)
            {
                ProgressLoad.Visibility = Visibility.Hidden;
                Button2.Visibility = Visibility.Visible;
                Exiter.Visibility = Visibility.Visible;
                T.IsEnabled = true;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            this.Visibility = Visibility.Hidden;
      
            window.Show();

            
        }

        private void Exiter_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show(Properties.Resources.Sure, Properties.Resources.Message1, MessageBoxButton.YesNo, MessageBoxImage.Warning);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    mainE = 1;
                    File.WriteAllText("Exit.txt", mainE.ToString());
                   
                    Application.Current.Shutdown();
                    break;
                case MessageBoxResult.No:

                    break;
            }
          
        }

        private void ProgressLoad_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }



        private void WarningList_Click(object sender, RoutedEventArgs e)
        {
            info.Show();

        }

        private void Version_Click(object sender, RoutedEventArgs e)
        {
            ver.Show();
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            about.Show();
        }

        private void General_Click(object sender, RoutedEventArgs e)
        {
            set.Show();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

            if (File.ReadAllText("Save.txt") != "")
            {
                file = 1;
                File.WriteAllText("File.txt", file.ToString());

                this.Visibility = Visibility.Hidden;
                window.Show();
            }
            else
            {
                MessageBox.Show("File is empty", "Error", MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }

        private void Window_Closing_1(object sender, CancelEventArgs e)
        {
            exit = Int32.Parse(File.ReadLines("Exit.txt").First());
            if (exit == 1)
            {

                File.WriteAllText("Exit.txt", mainE.ToString());
                Application.Current.Shutdown();


            }
            if (exit == 2)
            {

                File.WriteAllText("Exit.txt", mainE.ToString());
                Application.Current.Shutdown();


            }
            if (exit == 3)
            {

                File.WriteAllText("Exit.txt", mainE.ToString());
                Application.Current.Shutdown();


            }
            if (exit == 0)
            {
                MessageBoxResult result = MessageBox.Show(Properties.Resources.Sure, Properties.Resources.Message1, MessageBoxButton.YesNo, MessageBoxImage.Warning);
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
    }

}
    
}
//(c)AMProgramms, 2021
