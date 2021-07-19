using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceWl
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            const int arrx = 5;
            int[] size = new int[arrx];
            string[] arr = { "Match: ", "Rus.Iaz: ", "Physics: ", "History: ", "Eng.Iaz: ", "Chemistry: ", "Literature: ", "Socialscience: ", "Biology: ", "Geography: ", "LSF: ", "PE: ", "PD: ", "Informatics: " };
            Testbox.Items.AddRange(arr);
            Testbox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
          
        }
       
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedarr = textBox1.Enabled.ToString();
            if (selectedarr == textBox1.Enabled.ToString())
            { 
            int a = int.Parse(textBox1.Text);
            a *= 2;
           
        }
           
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void Result_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

      
       
    }
}
