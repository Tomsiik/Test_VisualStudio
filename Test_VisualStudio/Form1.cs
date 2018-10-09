using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_VisualStudio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

    
 
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NewMethod();
        }

        private void NewMethod()
        {

            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            decimal CurrSensTR_value = numericUpDown3.Value;
            
            double CurrSensTR_mV = (Convert.ToDouble(CurrSensTR_value)) * 12.5;

            label7.Text = Convert.ToString(CurrSensTR_mV);
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
          
        }

        

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        class C0
        {

        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            decimal Kcp_value = numericUpDown5.Value;

            double Kcp = Math.Pow(2, Convert.ToDouble(Kcp_value - 7));

            label9.Text = Convert.ToString(Kcp);
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            decimal tpw_value = numericUpDown6.Value;

            double tpw_us = 20 + (Convert.ToDouble(tpw_value) * 1.6);

            label11.Text = Convert.ToString(tpw_us); 
        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            decimal Kci_value = numericUpDown7.Value;

            double Kci = Math.Pow(2, Convert.ToDouble(Kci_value - 7));

            label12.Text = Convert.ToString(Kci);
        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {
            decimal Dh_value = numericUpDown8.Value;

            double Dh_percent = (Convert.ToDouble(Dh_value) + 1) * 6.25;

            label15.Text = Convert.ToString(Dh_percent);
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {
            decimal thold_value = numericUpDown9.Value * 8;

            label16.Text = Convert.ToString(thold_value);
        }

        private void numericUpDown11_ValueChanged(object sender, EventArgs e)
        {
            decimal Ksp_value = numericUpDown11.Value;

            double Ksp = Math.Pow(2, Convert.ToDouble(Ksp_value - 7));

            label21.Text = Convert.ToString(Ksp);
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown12_ValueChanged(object sender, EventArgs e)
        {
            decimal Ds_value = numericUpDown12.Value;

            double Ds_percent = (Convert.ToDouble(Ds_value) + 1) * 6.25;

            label20.Text = Convert.ToString(Ds_percent);
        }

        private void numericUpDown10_ValueChanged(object sender, EventArgs e)
        {
            decimal Fst_value = numericUpDown10.Value;

            Fst_value = (Fst_value + 1) * 2;

            label18.Text = Convert.ToString(Fst_value);

        }
    }
}
