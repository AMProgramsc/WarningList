using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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

        public WindowLoad()
        {
            //window.Close();
            InitializeComponent();
           
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
            }
        }
   
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            
            Close();
            
            window.Show();


        }

        private void Exiter_Click(object sender, RoutedEventArgs e)
        {
           
            window.Close();
            Close();
            Application.Current.Shutdown();
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
        private void Window_Closing_1(object sender, CancelEventArgs e)
        {
            if (ProgressLoad.Value < 100)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

       
    }
}
//(c)AMProgramms, 2021
