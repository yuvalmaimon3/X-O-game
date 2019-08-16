using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    
    public partial class Form1 : Form
    {
        bool Result = false ;  
        int WhoPlay;
        public Form1()
        {
            InitializeComponent();
        }

        private void Mark(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            Button button = (Button) sender;
            if (button.Text != "X" && button.Text != "O")
            {
                if (WhoPlay % 2 == 0)
                    button.Text = "X";
                else
                    button.Text = "O";
                if (WhoPlay >= 4)
                    button1.PerformClick();
                WhoPlay++;
              
            }
            else
                MessageBox.Show("Erro");
            
               
                


        }

         private void button1_Click(object sender, EventArgs e)
         {
               Form1 f = new Form1();
            Result = false;
                //רוחב
            if (window1.Text == window2.Text && window1.Text == window3.Text)
                Result = true;
            else if (window4.Text == window5.Text && window4.Text == window6.Text)
                Result = true;
            else if (window7.Text == window8.Text && window7.Text == window9.Text)
                Result = true;

                //אורך
            else if (window1.Text == window4.Text && window1.Text == window7.Text)
                Result = true;
            else if (window2.Text == window5.Text && window2.Text == window8.Text)
                Result = true;
            else if (window3.Text == window6.Text && window3.Text == window9.Text)
                Result = true;

                //אלכסונים
            else if (window1.Text == window5.Text && window1.Text == window9.Text)
                Result = true;
            else if (window3.Text == window5.Text && window3.Text == window7.Text)
                Result = true;

            if (Result)
            {
                if (WhoPlay % 2 == 0)
                    MessageBox.Show("X Win");
                else
                    MessageBox.Show("O Win");

                Application.Exit();
            }
         }
    }
}
