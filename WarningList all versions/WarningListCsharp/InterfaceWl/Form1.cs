using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace InterfaceWl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Form2 newForm = new Form2();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Step = 1;
            int count = progressBar1.Maximum;

            if (count == 0)
                return;

            Task.Factory.StartNew(() =>
            {
                for (int i = 0; i < count; i++)
                {
                    this.Invoke((Action)(() =>
                    {
                        progressBar1.PerformStep();
                    }));
                    Thread.Sleep(100);

                }
                Close();
                newForm.Show();
            });

        
        }


        private void progressBar1_Click(object sender, EventArgs e)
        {
           



        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
