using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                a = int.Parse(txt1.Text);
                b = int.Parse(txt2.Text);
                lblResult.Text = "= " + (a + b) + ".";
            }
            catch(Exception ex)
            {
                MessageBox.Show("There's been an unexpected error, please try again later or contact support giver");
            }
            
            // if a generic exeption is declared you cannot declare responess to specific exeptions 
            //catch (FormatException ex)
            //{
            //    MessageBox.Show("The program admits only integer numbers...")
            //}

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
