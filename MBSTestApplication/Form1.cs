using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MBSTestApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MBSBLC.BLC testobj = new MBSBLC.BLC();
           testobj.AddCinema(textBox1.Text.ToString(), textBox2.Text.ToString(), textBox3.Text.ToString(), textBox4.Text.ToString(), textBox5.Text.ToString());

//            AdminServiceReference.Service1Client sc = new AdminServiceReference.Service1Client();
  //          sc.AddCinema();
            label1.Text="Cinema Added Check Database";


        }





        private void button2_Click(object sender, EventArgs e)
        {
            MBSBLC.BLC testobj = new MBSBLC.BLC();
            //testobj.AddScreen(te);

         //   AdminServiceReference.Service1Client sc = new AdminServiceReference.Service1Client();
          //  sc.AddScreen();
            label1.Text = "Screen Added Check Database";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            MBSBLC.BLC testobj = new MBSBLC.BLC();


            label1.Text = testobj.CinemaID(textBox6.Text.ToString()).ToString();
            label2.Text = testobj.CinemaName(textBox6.Text.ToString()).ToString();
            label3.Text = testobj.CinemaLocation(textBox6.Text.ToString()).ToString();
            label4.Text = testobj.NumOfScreens(textBox6.Text.ToString()).ToString();
            label5.Text = testobj.CinemaIsDeleted(textBox6.Text.ToString()).ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MBSBLC.BLC testobj = new MBSBLC.BLC();

            
            //dct= testobj.GetAllCinemas();

            //comboBox1.DataSource = new BindingSource(dct, null); 
            //comboBox1.DisplayMember = "Value";
            //comboBox1.ValueMember = "Key";
      

        }

        Dictionary<int, string> dct;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox6.Text = comboBox1.Text; 
        }


    }
}
