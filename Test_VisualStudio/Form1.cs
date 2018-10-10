﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AS4963_Interface;

namespace Test_VisualStudio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //testování modifikace registrů
            textBox1.Text = Convert.ToString(AS4963.ModifyReg.ConfigReg0(2, 2, 2)) + Environment.NewLine;

            textBox1.Text = textBox1.Text + Convert.ToString(AS4963.ModifyReg.ConfigReg0(2, 4, 2));


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NewMethod();
        }

        private void NewMethod()
        {


        }

        /*************************************************************************Pull Data from Controls to Register*********************************************************************/

        public ushort Read_Config0()
        {
            ushort regRM = 0;
            ushort regBT = 0;
            ushort regDT = 0;

            if (rBtn_RcModeAuto.Checked)
                regRM = 0;
            if (rBtn_RcModeHigh.Checked)
                regRM = 1;
            if (rBtn_RcModeLow.Checked)
                regRM = 2;
            if (rBtn_RcModeOff.Checked)
                regRM = 3;


            regBT = Convert.ToUInt16(numUpDown_BlankTime.Value / 400);
            regDT = Convert.ToUInt16(numUpDown_DeadTime.Value / 50);

            return AS4963.ModifyReg.ConfigReg0(regRM, regBT, regDT);
        }





        /***********************************************************************Config 0********************************************************************************************/


        private void rBtn_RcModeAuto_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Read_Config0());
        }

        private void rBtn_RcModeHigh_CheckedChanged(object sender, EventArgs e)
        {

            textBox1.Text = Convert.ToString(Read_Config0());
        }

        private void rBtn_RcModeLow_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Read_Config0());
        }

        private void rBtn_RcModeOff_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Read_Config0());
        }

      

        private void numUpDown_DeadTime_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Read_Config0());
        }

        private void numUpDown_BlankTime_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Read_Config0());
        }





        /***********************************************************************Config 1********************************************************************************************/

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }


      



        /***********************************************************************Config 2********************************************************************************************/

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            decimal Kcp_value = numericUpDown5.Value;

            double Kcp = Math.Pow(2, Convert.ToDouble(Kcp_value - 7));

            label9.Text = Convert.ToString(Kcp);
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            decimal tpw_value = numericUpDown6.Value;

            double tpw_us = 20 + (Convert.ToDouble(tpw_value) * 1.6);

            label11.Text = Convert.ToString(tpw_us);
        }



        /***********************************************************************Config 3********************************************************************************************/


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



        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {
            decimal thold_value = numericUpDown9.Value * 8;

            label16.Text = Convert.ToString(thold_value);
        }


        /***********************************************************************Config 4********************************************************************************************/


        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            decimal CurrSensTR_value = numericUpDown3.Value;

            double CurrSensTR_mV = (Convert.ToDouble(CurrSensTR_value) + 1) * 12.5;

            label7.Text = Convert.ToString(CurrSensTR_mV);
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

        private void numericUpDown11_ValueChanged(object sender, EventArgs e)
        {
            decimal Ksp_value = numericUpDown11.Value;

            double Ksp = Math.Pow(2, Convert.ToDouble(Ksp_value - 7));

            label21.Text = Convert.ToString(Ksp);
        }


        /***********************************************************************Config 5********************************************************************************************/



        private void numericUpDown14_ValueChanged(object sender, EventArgs e)
        {
            decimal Ksi_value = numericUpDown14.Value;

            double Ksi = Math.Pow(2, Convert.ToDouble(Ksi_value - 7));

            label29.Text = Convert.ToString(Ksi);
        }

        private void numericUpDown15_ValueChanged(object sender, EventArgs e)
        {
            decimal Fmx_value = numericUpDown15.Value;

            double Fmx_hz = Convert.ToDouble((Math.Pow(2, 8 + Convert.ToDouble(Fmx_value)) - 1)) * 0.1;

            label28.Text = Convert.ToString(Fmx_hz);
        }


        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void numericUpDown13_ValueChanged(object sender, EventArgs e)
        {
            decimal Oadv_value = numericUpDown13.Value;

            double Oadv_hz = Convert.ToDouble(Oadv_value) * 1.875;

            label26.Text = Convert.ToString(Oadv_hz);
        }




        /***********************************************************************Config Run********************************************************************************************/

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown16_ValueChanged(object sender, EventArgs e)
        {
            decimal Dc_value = numericUpDown16.Value;

            Dc_value = (Dc_value * 3) + 7;

            label1.Text = Convert.ToString(Dc_value);
        }



        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

       
    }
}
