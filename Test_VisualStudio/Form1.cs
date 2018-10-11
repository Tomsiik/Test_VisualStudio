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
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NewMethod();
        }

        private void NewMethod()
        {


        }

        /*************************************************************************Pull Control's Data to Register*********************************************************************/

        public ushort Config0_Read()
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

        public ushort Config1_Read()
        {
            ushort regPFD = 0;
            ushort regIPI = 0;
            ushort regVIL = 0;
            ushort regVDQ = 0;
            ushort regVT = 0;

            regPFD = Convert.ToUInt16(chBox_PFD.Checked);
            regIPI = Convert.ToUInt16(chBox_IPI.Checked);
            regVIL = Convert.ToUInt16(numUpDown_CurrSenseThr.Value);

            if (rBtn_DebTim.Checked)
                regVDQ = 0;
            if (rBtn_WinTim.Checked)
                regVDQ = 1;

            regVT = Convert.ToUInt16(numUpDown_VdsThr.Value / 50);

            return AS4963.ModifyReg.ConfigReg1(regPFD, regIPI, regVIL, regVDQ, regVT);


        }

        public ushort Config2_Read()
        {
            ushort regCP = 0;
            ushort regSH = 0;
            ushort regDGC = 0;
            ushort regPW = 0;

            regCP = Convert.ToUInt16(numUpDown_PropGainPosCon.Value);

            if (rBtn_OvrSpeed100.Checked)
                regSH = 0;
            if (rBtn_OvrSpeed125.Checked)
                regSH = 1;
            if (rBtn_OvrSpeed150.Checked)
                regSH = 2;
            if (rBtn_OvrSpeed200.Checked)
                regSH = 3;

            regDGC = Convert.ToUInt16(chBox_DegComp.Checked);

            regPW = Convert.ToUInt16(numUpDown_OffTime.Value);

            return AS4963.ModifyReg.ConfigReg2(regCP, regSH, regDGC, regPW);


        }

        public ushort Config3_Read()
        {
            ushort regCI = 0;
            ushort regHD = 0;
            ushort regHT = 0;

            regCI = Convert.ToUInt16(numUpDown_InGainPosCon.Value);
            regHD = Convert.ToUInt16(numUpDown_PWMDutyHold.Value);
            regHT = Convert.ToUInt16(numUpDown_HoldTime.Value);

            return AS4963.ModifyReg.ConfigReg3(regCI, regHD, regHT);
        }


        public ushort Config4_Read()
        {
            ushort regSP = 0;
            ushort regSD = 0;
            ushort regSS = 0;

            regSP = Convert.ToUInt16(numUpDown_PropGainSpeed.Value);
            regSD = Convert.ToUInt16(numUpDown_PWMDutyCycleStartup.Value);
            regSS = Convert.ToUInt16(numUpDown_StartSpeed.Value);

            return AS4963.ModifyReg.ConfigReg4(regSP, regSD, regSS);
        }


        public ushort Config5_Read()
        {
            ushort regSI = 0;
            ushort regSPO = 0;
            ushort regSMX = 0;
            ushort regPA = 0;

            regSI = Convert.ToUInt16(numUpDown_InGainSpeedCon.Value);
            

            if (rBtn_SpeedOutSelElectricFreeq.Checked)
                regSPO = 0;
            if (rBtn_SpeedOutSelCommuFreq.Checked)
                regSPO = 1;

            regSMX = Convert.ToUInt16(numUpDown_MaxSpeedHz.Value);
            regPA = Convert.ToUInt16(numUpDown_PhaseAdvance.Value);

            return AS4963.ModifyReg.ConfigReg5(regSI, regSPO, regSMX, regPA);
        }


        /***********************************************************************Config 0********************************************************************************************/


        private void rBtn_RcModeAuto_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Config0_Read());

        }

        private void rBtn_RcModeHigh_CheckedChanged(object sender, EventArgs e)
        {

            textBox1.Text = Convert.ToString(Config0_Read());
        }

        private void rBtn_RcModeLow_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Config0_Read());
        }

        private void rBtn_RcModeOff_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Config0_Read());
        }



        private void numUpDown_DeadTime_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Config0_Read());
        }

        private void numUpDown_BlankTime_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Config0_Read());
        }





        /***********************************************************************Config 1********************************************************************************************/

        private void chBox_PFD_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Config1_Read());
        }


        private void chBox_IPI_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Config1_Read());
        }


        private void rBtn_DebTim_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Config1_Read());
        }

        private void rBtn_WinTim_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Config1_Read());
        }


        private void numUpDown_CurrSenseThr_ValueChanged(object sender, EventArgs e)
        {
            decimal CurrSensTR_value = numUpDown_CurrSenseThr.Value;

            double CurrSensTR_mV = (Convert.ToDouble(CurrSensTR_value) + 1) * 12.5;

            label7.Text = Convert.ToString(CurrSensTR_mV);

            textBox1.Text = Convert.ToString(Config1_Read());
        }

        private void numUpDown_VdsThr_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Config1_Read());
        }

        /***********************************************************************Config 2********************************************************************************************/

        private void numUpDown_PropGainPosCon_ValueChanged(object sender, EventArgs e)
        {
            decimal Kcp_value = numUpDown_PropGainPosCon.Value;

            double Kcp = Math.Pow(2, Convert.ToDouble(Kcp_value - 7));

            label9.Text = Convert.ToString(Kcp);
            textBox1.Text = Convert.ToString(Config2_Read());
        }



        private void rBtn_OvrSpeed100_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Config2_Read());
        }

        private void rBtn_OvrSpeed125_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Config2_Read());
        }

        private void rBtn_OvrSpeed150_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Config2_Read());
        }

        private void rBtn_OvrSpeed200_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Config2_Read());
        }


        private void chBox_DegComp_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Config2_Read());
        }

        
       
    private void numUpDown_OffTime_ValueChanged(object sender, EventArgs e)
    {
            decimal tpw_value = numUpDown_OffTime.Value;

            double tpw_us = 20 + (Convert.ToDouble(tpw_value) * 1.6);

            label11.Text = Convert.ToString(tpw_us);

            textBox1.Text = Convert.ToString(Config2_Read());
        }



        /***********************************************************************Config 3********************************************************************************************/


        private void numUpDown_InGainPosCon_ValueChanged(object sender, EventArgs e)
        {
            decimal Kci_value = numUpDown_InGainPosCon.Value;

            double Kci = Math.Pow(2, Convert.ToDouble(Kci_value - 7));

            label12.Text = Convert.ToString(Kci);

            textBox1.Text = Convert.ToString(Config3_Read());
        }



        private void numUpDown_PWMDutyHold_ValueChanged(object sender, EventArgs e)
        {
            decimal Dh_value = numUpDown_PWMDutyHold.Value;

            double Dh_percent = (Convert.ToDouble(Dh_value) + 1) * 6.25;

            label15.Text = Convert.ToString(Dh_percent);

            textBox1.Text = Convert.ToString(Config3_Read());
        }



        private void numUpDown_HoldTime_ValueChanged(object sender, EventArgs e)
        {
            decimal thold_value = numUpDown_HoldTime.Value * 8;

            label16.Text = Convert.ToString(thold_value);

            textBox1.Text = Convert.ToString(Config3_Read());
        }


        /***********************************************************************Config 4********************************************************************************************/


        private void numUpDown_PropGainSpeed_ValueChanged(object sender, EventArgs e)
        {
            decimal Ksp_value = numUpDown_PropGainSpeed.Value;

            double Ksp = Math.Pow(2, Convert.ToDouble(Ksp_value - 7));

            label21.Text = Convert.ToString(Ksp);

            textBox1.Text = Convert.ToString(Config4_Read());
        }


        private void numUpDown_PWMDutyCycleStartup_ValueChanged(object sender, EventArgs e)
        {
            decimal Ds_value = numUpDown_PWMDutyCycleStartup.Value;

            double Ds_percent = (Convert.ToDouble(Ds_value) + 1) * 6.25;

            label20.Text = Convert.ToString(Ds_percent);

            textBox1.Text = Convert.ToString(Config4_Read());
        }



        private void numUpDown_StartSpeed_ValueChanged(object sender, EventArgs e)
        {
            decimal Fst_value = numUpDown_StartSpeed.Value;

            Fst_value = (Fst_value + 1) * 2;

            label18.Text = Convert.ToString(Fst_value);

            textBox1.Text = Convert.ToString(Config4_Read());

        }




        /***********************************************************************Config 5********************************************************************************************/




        private void numUpDown_InGainSpeedCon_ValueChanged(object sender, EventArgs e)
        {
            decimal Ksi_value = numUpDown_InGainSpeedCon.Value;

            double Ksi = Math.Pow(2, Convert.ToDouble(Ksi_value - 7));

            label29.Text = Convert.ToString(Ksi);

            textBox1.Text = Convert.ToString(Config5_Read());
        }

        
        private void numUpDown_MaxSpeedHz_ValueChanged(object sender, EventArgs e)
        {
            decimal Fmx_value = numUpDown_MaxSpeedHz.Value;

            double Fmx_hz = Convert.ToDouble((Math.Pow(2, 8 + Convert.ToDouble(Fmx_value)) - 1)) * 0.1;

            label28.Text = Convert.ToString(Fmx_hz);

            textBox1.Text = Convert.ToString(Config5_Read());
        }


        private void rBtn_SpeedOutSelElectricFreeq_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Config5_Read());
        }

        private void rBtn_SpeedOutSelCommuFreq_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Config5_Read());
        }



        private void numUpDown_PhaseAdvance_ValueChanged(object sender, EventArgs e)
        {
            decimal Oadv_value = numUpDown_PhaseAdvance.Value;

            double Oadv_hz = Convert.ToDouble(Oadv_value) * 1.875;

            label26.Text = Convert.ToString(Oadv_hz);

            textBox1.Text = Convert.ToString(Config5_Read());
        }




        /***********************************************************************Config Run********************************************************************************************/

        private void rBtn_MotConIndirect_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rBtn_MotConDirect_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rBtn_MotConClosedCurr_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rBtn_MotConClosedSpeed_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numUpDown_DutyCycleControl_ValueChanged(object sender, EventArgs e)
        {
         decimal Dc_value = numUpDown_DutyCycleControl.Value;

            Dc_value = (Dc_value * 3) + 7;

            label1.Text = Convert.ToString(Dc_value);
        }

        private void chBox_EnableStopFail_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chBox_RestartControl_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chBox_Brake_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chBox_DirectionRotation_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chBox_RunEnable_CheckedChanged(object sender, EventArgs e)
        {

        }

       
    }
}
