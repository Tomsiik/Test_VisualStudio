using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using AS4963_Interface;

namespace Test_VisualStudio
{
    public partial class Form1 : Form
    {

        public static int RxbytesLen;

        public static byte[] Rxbuffer = new byte[20];

        public static bool MessageBoxState = false;

        public static bool CommandState = false;

        public Form1()
        {
            InitializeComponent();



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            toolStrip_MenuPorts.Items.AddRange(ports);
            toolStripStatusLabel1.Text = "Port Disconnected";


        }

        /***********************************************************************Config 0********************************************************************************************/
        /* Eventy ovládacích prvků konfiguračního registr 0
         */

        private void rBtn_RcModeAuto_CheckedChanged(object sender, EventArgs e)
        {
            ChangeLabel.Config0.Write(this);
        

        }

        private void rBtn_RcModeHigh_CheckedChanged(object sender, EventArgs e)
        {

            ChangeLabel.Config0.Write(this);
        }

        private void rBtn_RcModeLow_CheckedChanged(object sender, EventArgs e)
        {
            ChangeLabel.Config0.Write(this);
        }

        private void rBtn_RcModeOff_CheckedChanged(object sender, EventArgs e)
        {
            ChangeLabel.Config0.Write(this);
        }



        private void numUpDown_DeadTime_ValueChanged(object sender, EventArgs e)
        {
            ChangeLabel.Config0.Write(this);
        }

        private void numUpDown_BlankTime_ValueChanged(object sender, EventArgs e)
        {
            ChangeLabel.Config0.Write(this);
        }





        /***********************************************************************Config 1********************************************************************************************/
        /* Eventy ovládacích prvků konfiguračního registr 1
         */
        private void chBox_PFD_CheckedChanged(object sender, EventArgs e)
        {
            ChangeLabel.Config1.Write(this);
        }


        private void chBox_IPI_CheckedChanged(object sender, EventArgs e)
        {
            ChangeLabel.Config1.Write(this);
        }


        private void rBtn_DebTim_CheckedChanged(object sender, EventArgs e)
        {
            ChangeLabel.Config1.Write(this);
        }

        private void rBtn_WinTim_CheckedChanged(object sender, EventArgs e)
        {
            ChangeLabel.Config1.Write(this);
        }


        private void numUpDown_CurrSenseThr_ValueChanged(object sender, EventArgs e)
        {
            decimal CurrSensTR_value = numUpDown_CurrSenseThr.Value;

            double CurrSensTR_mV = (Convert.ToDouble(CurrSensTR_value) + 1) * 12.5;

            label7.Text = Convert.ToString(CurrSensTR_mV);
            ChangeLabel.Config1.Write(this);

        }

        private void numUpDown_VdsThr_ValueChanged(object sender, EventArgs e)
        {
            ChangeLabel.Config1.Write(this);
        }

        /***********************************************************************Config 2********************************************************************************************/
        /* Eventy ovládacích prvků konfiguračního registr 2
        */
        private void numUpDown_PropGainPosCon_ValueChanged(object sender, EventArgs e)
        {
            decimal Kcp_value = numUpDown_PropGainPosCon.Value;

            double Kcp = Math.Pow(2, Convert.ToDouble(Kcp_value - 7));

            label9.Text = Convert.ToString(Kcp);

            ChangeLabel.Config2.Write(this);
        }



        private void rBtn_OvrSpeed100_CheckedChanged(object sender, EventArgs e)
        {
            ChangeLabel.Config2.Write(this);
        }

        private void rBtn_OvrSpeed125_CheckedChanged(object sender, EventArgs e)
        {
            ChangeLabel.Config2.Write(this);
        }

        private void rBtn_OvrSpeed150_CheckedChanged(object sender, EventArgs e)
        {
            ChangeLabel.Config2.Write(this);
        }

        private void rBtn_OvrSpeed200_CheckedChanged(object sender, EventArgs e)
        {
            ChangeLabel.Config2.Write(this);
        }


        private void chBox_DegComp_CheckedChanged(object sender, EventArgs e)
        {
            ChangeLabel.Config2.Write(this);
        }



        private void numUpDown_OffTime_ValueChanged(object sender, EventArgs e)
        {
            decimal tpw_value = numUpDown_OffTime.Value;

            double tpw_us = 20 + (Convert.ToDouble(tpw_value) * 1.6);

            label11.Text = Convert.ToString(tpw_us);

            ChangeLabel.Config2.Write(this);
        }



        /***********************************************************************Config 3********************************************************************************************/
        /* Eventy ovládacích prvků konfiguračního registr 3
        */

        private void numUpDown_InGainPosCon_ValueChanged(object sender, EventArgs e)
        {
            decimal Kci_value = numUpDown_InGainPosCon.Value;

            double Kci = Math.Pow(2, Convert.ToDouble(Kci_value - 7));

            label12.Text = Convert.ToString(Kci);

            ChangeLabel.Config3.Write(this);
        }



        private void numUpDown_PWMDutyHold_ValueChanged(object sender, EventArgs e)
        {
            decimal Dh_value = numUpDown_PWMDutyHold.Value;

            double Dh_percent = (Convert.ToDouble(Dh_value) + 1) * 6.25;

            label15.Text = Convert.ToString(Dh_percent);

            ChangeLabel.Config3.Write(this);
        }



        private void numUpDown_HoldTime_ValueChanged(object sender, EventArgs e)
        {
            decimal thold_value = numUpDown_HoldTime.Value * 8;

            label16.Text = Convert.ToString(thold_value);

            ChangeLabel.Config3.Write(this);
        }


        /***********************************************************************Config 4********************************************************************************************/
        /* Eventy ovládacích prvků konfiguračního registr 4
        */

        private void numUpDown_PropGainSpeed_ValueChanged(object sender, EventArgs e)
        {
            decimal Ksp_value = numUpDown_PropGainSpeed.Value;

            double Ksp = Math.Pow(2, Convert.ToDouble(Ksp_value - 7));

            label21.Text = Convert.ToString(Ksp);

            ChangeLabel.Config4.Write(this);
        }


        private void numUpDown_PWMDutyCycleStartup_ValueChanged(object sender, EventArgs e)
        {
            decimal Ds_value = numUpDown_PWMDutyCycleStartup.Value;

            double Ds_percent = (Convert.ToDouble(Ds_value) + 1) * 6.25;

            label20.Text = Convert.ToString(Ds_percent);

            ChangeLabel.Config4.Write(this);
        }



        private void numUpDown_StartSpeed_ValueChanged(object sender, EventArgs e)
        {
            decimal Fst_value = numUpDown_StartSpeed.Value;

            Fst_value = (Fst_value + 1) * 2;

            label18.Text = Convert.ToString(Fst_value);

            ChangeLabel.Config4.Write(this);

        }




        /***********************************************************************Config 5********************************************************************************************/
        /* Eventy ovládacích prvků konfiguračního registr 5
        */



        private void numUpDown_InGainSpeedCon_ValueChanged(object sender, EventArgs e)
        {
            decimal Ksi_value = numUpDown_InGainSpeedCon.Value;

            double Ksi = Math.Pow(2, Convert.ToDouble(Ksi_value - 7));

            label29.Text = Convert.ToString(Ksi);

            ChangeLabel.Config5.Write(this);
        }


        private void numUpDown_MaxSpeedHz_ValueChanged(object sender, EventArgs e)
        {
            decimal Fmx_value = numUpDown_MaxSpeedHz.Value;

            double Fmx_hz = Convert.ToDouble((Math.Pow(2, 8 + Convert.ToDouble(Fmx_value)) - 1)) * 0.1;

            label28.Text = Convert.ToString(Fmx_hz);

            ChangeLabel.Config5.Write(this);
        }


        private void rBtn_SpeedOutSelElectricFreeq_CheckedChanged(object sender, EventArgs e)
        {
            ChangeLabel.Config5.Write(this);
        }

        private void rBtn_SpeedOutSelCommuFreq_CheckedChanged(object sender, EventArgs e)
        {
            ChangeLabel.Config5.Write(this);
        }



        private void numUpDown_PhaseAdvance_ValueChanged(object sender, EventArgs e)
        {
            decimal Oadv_value = numUpDown_PhaseAdvance.Value;

            double Oadv_hz = Convert.ToDouble(Oadv_value) * 1.875;

            label26.Text = Convert.ToString(Oadv_hz);

            ChangeLabel.Config5.Write(this);
        }




        /***********************************************************************Config Run********************************************************************************************/
        /* Eventy ovládacích prvků Run registru
        */

        private void rBtn_MotConIndirect_CheckedChanged(object sender, EventArgs e)
        {
            ChangeLabel.ConfigRun.Write(this);
        }

        private void rBtn_MotConDirect_CheckedChanged(object sender, EventArgs e)
        {
            ChangeLabel.ConfigRun.Write(this);
        }

        private void rBtn_MotConClosedCurr_CheckedChanged(object sender, EventArgs e)
        {
            ChangeLabel.ConfigRun.Write(this);
        }

        private void rBtn_MotConClosedSpeed_CheckedChanged(object sender, EventArgs e)
        {
            ChangeLabel.ConfigRun.Write(this);
        }

        private void numUpDown_DutyCycleControl_ValueChanged(object sender, EventArgs e)
        {
            decimal Dc_value = numUpDown_DutyCycleControl.Value;

            Dc_value = (Dc_value * 3) + 7;

            label1.Text = Convert.ToString(Dc_value);

            ChangeLabel.ConfigRun.Write(this);
        }

        private void chBox_EnableStopFail_CheckedChanged(object sender, EventArgs e)
        {
            ChangeLabel.ConfigRun.Write(this);
        }

        private void chBox_RestartControl_CheckedChanged(object sender, EventArgs e)
        {
            ChangeLabel.ConfigRun.Write(this);
        }

        private void chBox_Brake_CheckedChanged(object sender, EventArgs e)
        {
            ChangeLabel.ConfigRun.Write(this);
        }

        private void chBox_DirectionRotation_CheckedChanged(object sender, EventArgs e)
        {
            ChangeLabel.ConfigRun.Write(this);
        }

        private void chBox_RunEnable_CheckedChanged(object sender, EventArgs e)
        {
            ChangeLabel.ConfigRun.Write(this);
        }


        /*************************************************************************Speed Control************************************************************************************/
        /* Eventy ovládacích prvků generátoru PWM a zároveň odesílání povelu přes seriovou linku
         * komunikace pro změnu PWM probíhá automaticky při změně nějakého prvku s časovou prodlevou, kvůli nezahlcování seriové linky
         * časovou prodlevu zajišťuje timer_PwmGenControl    
         */



        /*event uvolnění tlačítka myši na track baru, dojde ke spuštění timeru, následně je pak odeslán povel seriovým portem*/
        private void trcBar_SpeedControl_MouseUp(object sender, MouseEventArgs e)
        {

            timing_PwmGenControl.Enabled = false;
            timing_PwmGenControl.Enabled = true;

        }
        private void trcBar_SpeedControl_KeyUp(object sender, KeyEventArgs e)
        {
            timing_PwmGenControl.Enabled = false;
            timing_PwmGenControl.Enabled = true;
        }
        /*label se ze změnou track baru aktualizuje nicméně není odeslán příkaz, příkaz je odeslán až po uvolnění tlačítka myši*/
        private void trcBar_SpeedControl_Scroll(object sender, EventArgs e)
        {

            lbl_SpeedControl.Text = Convert.ToString(trcBar_SpeedControl.Value * 100);


        }



        private void trcBar_DutyCycle_MouseUp(object sender, MouseEventArgs e)
        {
            timing_PwmGenControl.Enabled = false;
            timing_PwmGenControl.Enabled = true;
        }



        private void trcBar_DutyCycle_KeyUp(object sender, KeyEventArgs e)
        {
            timing_PwmGenControl.Enabled = false;
            timing_PwmGenControl.Enabled = true;
        }

        private void trcBar_DutyCycle_Scroll(object sender, EventArgs e)
        {
            lbl_DutyCycle.Text = Convert.ToString(trcBar_DutyCycle.Value);


        }
        private void chBox_PWMGenerationOn_CheckedChanged(object sender, EventArgs e)
        {
            timing_PwmGenControl.Enabled = false;
            timing_PwmGenControl.Enabled = true;
        }



        private void timing_PwmGenControl_Tick(object sender, EventArgs e)
        {

            timing_PwmGenControl.Enabled = false;

            byte[] speedcontrol = new byte[4];
            speedcontrol[0] = Convert.ToByte('P');
            speedcontrol[1] = Convert.ToByte(trcBar_SpeedControl.Value);
            speedcontrol[2] = Convert.ToByte(trcBar_DutyCycle.Value);
            speedcontrol[3] = Convert.ToByte(chBox_PWMGenerationOn.Checked);

            serialPort1.Write(speedcontrol, 0, 4);

            prgBar_CommandProgress.Value = 50;
            CommandState = true;
            timer_TimeoutCommunication.Enabled = true;
        }



        /************************************************************************Controls of Serial Ports***********************************************************************************/
        /* Eventy ovládacích prvků komunikačního rozhraní seriové linky a jeho nastavení
         *
         */
        private void toolStrip_OpenPort_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                serialPort1.PortName = toolStrip_MenuPorts.Text;
                serialPort1.BaudRate = 115200;
                serialPort1.Open();
                toolStrip_ClosePort.Enabled = true;
                toolStrip_OpenPort.Enabled = false;

                btn_WriteConfig.Enabled = true;
                btn_ReadConfig.Enabled = true;
                btn_ReadDiag.Enabled = true;
                rBtn_SingleMode.Enabled = true;
                rBtn_AutoWriteMode.Enabled = true;
                trcBar_DutyCycle.Enabled = true;
                trcBar_SpeedControl.Enabled = true;
                chBox_PWMGenerationOn.Enabled = true;
                toolStripStatusLabel1.Text = "Port Connected";

            }
            else
            {
                toolStrip_ClosePort.Enabled = false;
                toolStrip_OpenPort.Enabled = true;
                toolStripStatusLabel1.Text = "Port Disconnected";
            }
        }

        private void toolStrip_ClosePort_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {

                serialPort1.Close();
                toolStrip_ClosePort.Enabled = false;
                toolStrip_OpenPort.Enabled = true;

                btn_WriteConfig.Enabled = false;
                btn_ReadConfig.Enabled = false;
                btn_ReadDiag.Enabled = false;
                rBtn_SingleMode.Enabled = false;
                rBtn_AutoWriteMode.Enabled = false;
                trcBar_DutyCycle.Enabled = false;
                trcBar_SpeedControl.Enabled = false;
                chBox_PWMGenerationOn.Enabled = false;
                toolStripStatusLabel1.Text = "Port Disconnected";
            }
            else
            {
                toolStrip_ClosePort.Enabled = true;
                toolStrip_OpenPort.Enabled = false;
                toolStripStatusLabel1.Text = "Port Connected";
            }
        }

        private void toolStrip_RefreshPorts_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            toolStrip_MenuPorts.Items.Clear();
            toolStrip_MenuPorts.Items.AddRange(ports);

        }


        /************************************************************************Serial Port Read***********************************************************************************/
        /* Eventy přímo serial portu
         *
         */

        /*event pro příjem dat seriového portu*/
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            RxbytesLen = serialPort1.BytesToRead;

            serialPort1.Read(Rxbuffer, 0, RxbytesLen);

            this.Invoke(new EventHandler(ReadData));
        }


        private void ReadData(object sender, EventArgs e)
        {
            // byte[] RxmessageArray = new byte[RxbytesLen];
            // Array.Copy(Rxbuffer, RxmessageArray, RxbytesLen);

            //int lenght = RxmessageArray.Length;

            if (Rxbuffer[0] == Convert.ToByte('W') && RxbytesLen == 1)   //handlery pro příjem odpovědí od HW driveru na základě zvoleného příkazu nebo handler asynchronních zpráv (FAULT, SPD-RPM)
            {

                prgBar_CommandProgress.Value = 100;
                textBox1.SelectionStart = textBox1.TextLength;
                //textBox1.SelectedText = DateTime.Now.ToString("HH:mm:ss") + "    " + Convert.ToString(message);
                textBox1.AppendText(Environment.NewLine);
                //textBox1.AppendText(DateTime.Now.ToString("HH:mm:ss") + "    " + Convert.ToString(message));
                // textBox1.Text = textBox1.Text + Environment.NewLine;

                //byte[] WRdiag = Encoding.ASCII.GetBytes(message);

                CommandState = false;
                timer_TimeoutCommunication.Enabled = false; //deaktivace timeru který počítá timeout pro přijem odpovědi, odpověď přišla 
                timer_CommandProgressBar.Enabled = true;

                ChangeLabel.ClearAll(this);

            }

            else if ((Rxbuffer[0] == Convert.ToByte('R')) && (RxbytesLen == 15))
            {
                prgBar_CommandProgress.Value = 100;
                textBox1.SelectionStart = textBox1.TextLength;
                // textBox1.SelectedText = DateTime.Now.ToString("HH:mm:ss") + "    " + Convert.ToString(message);
                textBox1.AppendText(Environment.NewLine);

                UserControls.Modify.Config0(this, Rxbuffer);
                UserControls.Modify.Config1(this, Rxbuffer);
                UserControls.Modify.Config2(this, Rxbuffer);
                UserControls.Modify.Config3(this, Rxbuffer);
                UserControls.Modify.Config4(this, Rxbuffer);
                UserControls.Modify.Config5(this, Rxbuffer);
                UserControls.Modify.Run(this, Rxbuffer);



                CommandState = false;
                timer_TimeoutCommunication.Enabled = false;
                timer_CommandProgressBar.Enabled = true;

            }

            else if (Rxbuffer[0] == Convert.ToByte('D') && (RxbytesLen == 3))
            {


                textBox1.SelectionStart = textBox1.TextLength;
                // textBox1.SelectedText = DateTime.Now.ToString("HH:mm:ss") + "    " + Convert.ToString(message);
                textBox1.AppendText(Environment.NewLine);



                prgBar_CommandProgress.Value = 100;
                CommandState = false;
                timer_TimeoutCommunication.Enabled = false;
                timer_CommandProgressBar.Enabled = true;
            }

            else if (Rxbuffer[0] == Convert.ToByte('P') && (RxbytesLen == 1))
            {

                textBox1.SelectionStart = textBox1.TextLength;
                // textBox1.SelectedText = DateTime.Now.ToString("HH:mm:ss") + "    " + Convert.ToString(message);
                textBox1.AppendText(Environment.NewLine);


                CommandState = false;
                prgBar_CommandProgress.Value = 100;
                timer_TimeoutCommunication.Enabled = false;
                timer_CommandProgressBar.Enabled = true;
            }
            else {
                MessageBoxState = true;
                timer_CommandProgressBar.Enabled = false;
                timer_TimeoutCommunication.Enabled = false;

                string zprava = "Received incorrect frame!" + Environment.NewLine + Convert.ToChar(Rxbuffer[0]); //složení diagnostického message boxu s přijatými daty 
                for (int y = 1; y< RxbytesLen; y++)
                {
                    zprava = zprava + " | " + Rxbuffer[y];
                }
                MessageBox.Show(this, zprava, "Data Frame Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                timer_CommandProgressBar.Enabled = true;
                MessageBoxState = false;
            }
        }

        /************************************************************************Controls of Commands for Serial port*******************************************************************************/
        /* Eventy ovládacích prvků pro povelování seriového portu
         *
         */

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btn_WriteConfig_Click(object sender, EventArgs e)
        {


            ushort reg0 = UserControls.PullData.Config0(this);
            ushort reg1 = UserControls.PullData.Config1(this);
            ushort reg2 = UserControls.PullData.Config2(this);
            ushort reg3 = UserControls.PullData.Config3(this);
            ushort reg4 = UserControls.PullData.Config4(this);
            ushort reg5 = UserControls.PullData.Config5(this);
            ushort run = UserControls.PullData.Run(this);

            byte[] regs = new byte[15];


            regs[0] = Convert.ToByte('W');


            regs[2] = (byte)reg0;
            regs[1] = (byte)(reg0 >> 8);

            regs[4] = (byte)reg1;
            regs[3] = (byte)(reg1 >> 8);

            regs[6] = (byte)reg2;
            regs[5] = (byte)(reg2 >> 8);

            regs[8] = (byte)reg3;
            regs[7] = (byte)(reg3 >> 8);

            regs[10] = (byte)reg4;
            regs[9] = (byte)(reg4 >> 8);

            regs[12] = (byte)reg5;
            regs[11] = (byte)(reg5 >> 8);

            regs[14] = (byte)run;
            regs[13] = (byte)(run >> 8);

            serialPort1.Write(regs, 0, 15);
            prgBar_CommandProgress.Value = 50;
            CommandState = true;
            timer_TimeoutCommunication.Enabled = true;

           
          
        }


        private void btn_ReadConfig_Click(object sender, EventArgs e)
        {

            serialPort1.Write("R");
            prgBar_CommandProgress.Value = 50;
            CommandState = true;
            timer_TimeoutCommunication.Enabled = true;




        }


        private void btn_ReadDiag_Click(object sender, EventArgs e)
        {
            // byte[] command = new byte[1];
            //command[0] = Convert.ToByte('D');

            serialPort1.Write("D");
            prgBar_CommandProgress.Value = 50;
            CommandState = true;
            timer_TimeoutCommunication.Enabled = true;
        }

        /*třída State nese proměnné pro komunikaci s nadřazenými třídami, které ovládají komunikaci
          pokud se aktivuje nějaký příkaz dojde k nahození danného bitu v této třídě.*/


        /************************************************************************Timing of Serial Comunication***********************************************************************************/
        /* Eventy timerů, které časují události ohledně komunikace
         * První Timer je určen pro vyhodnocení časové prodlevy (timeout) komunikace mezi programem a HW STM32, pokud je timeout a HW neodpovídá je vyvolán messagebox po určitém čase 
         * Druhý Timer pouze určuje dobu na jak dlouho se ponechá plný progress bar, poté ho opět nuluje.
         */

        private void timer_TimeoutCommunication_Tick(object sender, EventArgs e)
        {
            if (CommandState == true)
            {
                timer_TimeoutCommunication.Enabled = false;
                if (MessageBoxState == false)
                {
                    MessageBox.Show(this, "Timeout, please check connection!", "Communication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    prgBar_CommandProgress.Value = 0;
                }
            }

        }



        private void timer_CommandProgressBar_Tick(object sender, EventArgs e)
        {

            prgBar_CommandProgress.Value = 0;
            timer_CommandProgressBar.Enabled = false;
        }


        /*************************************************************************Diagnostic Terminal****************************************************************************************/
        private void btn_ClearDiagTextBox_Click(object sender, EventArgs e)
        {

          


          
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }






        /**************************************************************************Class of User Controls***************************************************************************/
        /* Třída která definuje metody pro čtení a zápis dat do konfiguračních prvků
         *
         */

        public static class UserControls
        {

            //static Form1 frm = new Form1();

            /* změna ovládacích prvků, read commandem
             * 
             * parametr buffer je Rx rámec na Read command
             * první byte se nepoužije, slouží pro identifikaci rámce
             * 
             */
            public static class PullData
            {
                public static ushort Config0(Form1 frm)
                {
                    ushort regRM = 0;
                    ushort regBT = 0;
                    ushort regDT = 0;

                    if (frm.rBtn_RcModeAuto.Checked)
                        regRM = 0;
                    if (frm.rBtn_RcModeHigh.Checked)
                        regRM = 1;
                    if (frm.rBtn_RcModeLow.Checked)
                        regRM = 2;
                    if (frm.rBtn_RcModeOff.Checked)
                        regRM = 3;


                    regBT = Convert.ToUInt16(frm.numUpDown_BlankTime.Value / 400);
                    regDT = Convert.ToUInt16(frm.numUpDown_DeadTime.Value / 50);

                    return AS4963.ModifyReg.ConfigReg0(regRM, regBT, regDT);
                }

                public static ushort Config1(Form1 frm)
                {
                    ushort regPFD = 0;
                    ushort regIPI = 0;
                    ushort regVIL = 0;
                    ushort regVDQ = 0;
                    ushort regVT = 0;

                    regPFD = Convert.ToUInt16(frm.chBox_PFD.Checked);
                    regIPI = Convert.ToUInt16(frm.chBox_IPI.Checked);
                    regVIL = Convert.ToUInt16(frm.numUpDown_CurrSenseThr.Value);

                    if (frm.rBtn_DebTim.Checked)
                        regVDQ = 0;
                    if (frm.rBtn_WinTim.Checked)
                        regVDQ = 1;

                    regVT = Convert.ToUInt16(frm.numUpDown_VdsThr.Value / 50);

                    return AS4963.ModifyReg.ConfigReg1(regPFD, regIPI, regVIL, regVDQ, regVT);


                }

                public static ushort Config2(Form1 frm)
                {
                    ushort regCP = 0;
                    ushort regSH = 0;
                    ushort regDGC = 0;
                    ushort regPW = 0;

                    regCP = Convert.ToUInt16(frm.numUpDown_PropGainPosCon.Value);

                    if (frm.rBtn_OvrSpeed100.Checked)
                        regSH = 0;
                    if (frm.rBtn_OvrSpeed125.Checked)
                        regSH = 1;
                    if (frm.rBtn_OvrSpeed150.Checked)
                        regSH = 2;
                    if (frm.rBtn_OvrSpeed200.Checked)
                        regSH = 3;

                    regDGC = Convert.ToUInt16(frm.chBox_DegComp.Checked);

                    regPW = Convert.ToUInt16(frm.numUpDown_OffTime.Value);

                    return AS4963.ModifyReg.ConfigReg2(regCP, regSH, regDGC, regPW);


                }

                public static ushort Config3(Form1 frm)
                {
                    ushort regCI = 0;
                    ushort regHD = 0;
                    ushort regHT = 0;

                    regCI = Convert.ToUInt16(frm.numUpDown_InGainPosCon.Value);
                    regHD = Convert.ToUInt16(frm.numUpDown_PWMDutyHold.Value);
                    regHT = Convert.ToUInt16(frm.numUpDown_HoldTime.Value);

                    return AS4963.ModifyReg.ConfigReg3(regCI, regHD, regHT);
                }


                public static ushort Config4(Form1 frm)
                {
                    ushort regSP = 0;
                    ushort regSD = 0;
                    ushort regSS = 0;

                    regSP = Convert.ToUInt16(frm.numUpDown_PropGainSpeed.Value);
                    regSD = Convert.ToUInt16(frm.numUpDown_PWMDutyCycleStartup.Value);
                    regSS = Convert.ToUInt16(frm.numUpDown_StartSpeed.Value);

                    return AS4963.ModifyReg.ConfigReg4(regSP, regSD, regSS);
                }


                public static ushort Config5(Form1 frm)
                {
                    ushort regSI = 0;
                    ushort regSPO = 0;
                    ushort regSMX = 0;
                    ushort regPA = 0;

                    regSI = Convert.ToUInt16(frm.numUpDown_InGainSpeedCon.Value);


                    if (frm.rBtn_SpeedOutSelElectricFreeq.Checked)
                        regSPO = 0;
                    if (frm.rBtn_SpeedOutSelCommuFreq.Checked)
                        regSPO = 1;

                    regSMX = Convert.ToUInt16(frm.numUpDown_MaxSpeedHz.Value);
                    regPA = Convert.ToUInt16(frm.numUpDown_PhaseAdvance.Value);

                    return AS4963.ModifyReg.ConfigReg5(regSI, regSPO, regSMX, regPA);
                }

                public static ushort Run(Form1 frm)
                {
                    ushort regCM = 0;
                    ushort regESF = 0;
                    ushort regDI = 0;
                    ushort regRSC = 0;
                    ushort regBRK = 0;
                    ushort regDIR = 0;
                    ushort regRUN = 0;


                    if (frm.rBtn_MotConIndirect.Checked)
                        regCM = 0;
                    if (frm.rBtn_MotConDirect.Checked)
                        regCM = 1;
                    if (frm.rBtn_MotConClosedCurr.Checked)
                        regCM = 2;
                    if (frm.rBtn_MotConClosedSpeed.Checked)
                        regCM = 3;


                    regDI = Convert.ToUInt16(frm.numUpDown_DutyCycleControl.Value);

                    regESF = Convert.ToUInt16(frm.chBox_EnableStopFail.Checked);
                    regRSC = Convert.ToUInt16(frm.chBox_RestartControl.Checked);
                    regBRK = Convert.ToUInt16(frm.chBox_Brake.Checked);
                    regDIR = Convert.ToUInt16(frm.chBox_DirectionRotation.Checked);
                    regRUN = Convert.ToUInt16(frm.chBox_RunEnable.Checked);

                    return AS4963.ModifyReg.RunReg(regCM, regESF, regDI, regRSC, regBRK, regDIR, regRUN);

                }



            }




            public static class Modify
            {
                public static void Config0(Form1 frm, byte[] buffer)
                {
                    try
                    {
                        ushort regC0 = (ushort)((buffer[1] << 8) | buffer[2]);
                        ushort regC0_RM = (ushort)(((regC0 & (AS4963.C0.RM.Mask)) >> AS4963.C0.RM.Pos));
                        ushort regC0_BT = (ushort)(((regC0 & (AS4963.C0.BT.Mask)) >> AS4963.C0.BT.Pos));
                        ushort regC0_DT = (ushort)(((regC0 & (AS4963.C0.DT.Mask)) >> AS4963.C0.DT.Pos));

                        if (regC0_RM == 0)
                            frm.rBtn_RcModeAuto.Checked = true;
                        if (regC0_RM == 1)
                            frm.rBtn_RcModeHigh.Checked = true;
                        if (regC0_RM == 2)
                            frm.rBtn_RcModeLow.Checked = true;
                        if (regC0_RM == 3)
                            frm.rBtn_RcModeOff.Checked = true;

                        frm.numUpDown_BlankTime.Value = regC0_BT * 400;

                        frm.numUpDown_DeadTime.Value = regC0_DT * 50;
                        ChangeLabel.Config0.Read(frm);
                    }
                    catch  //DeadTime hodnota nesmí být nula, proto je zde ošetření že nula přišla, oznámění uživateli
                    {
                        MessageBoxState = true;
                        frm.timer_CommandProgressBar.Enabled = false;
                        frm.timer_TimeoutCommunication.Enabled = false;
                        MessageBox.Show(frm, "Received incorred data of correct frame!", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        frm.timer_CommandProgressBar.Enabled = true;
                        MessageBoxState = false;
                    }

                }

                public static void Config1(Form1 frm, byte[] buffer)
                {

                    ushort regC1 = (ushort)((buffer[3] << 8) | buffer[4]);
                    ushort regC1_PFD = (ushort)(((regC1 & (AS4963.C1.PFD.Mask)) >> AS4963.C1.PFD.Pos));
                    ushort regC1_IPI = (ushort)(((regC1 & (AS4963.C1.IPI.Mask)) >> AS4963.C1.IPI.Pos));
                    ushort regC1_VIL = (ushort)(((regC1 & (AS4963.C1.VIL.Mask)) >> AS4963.C1.VIL.Pos));
                    ushort regC1_VDQ = (ushort)(((regC1 & (AS4963.C1.VDQ.Mask)) >> AS4963.C1.VDQ.Pos));
                    ushort regC1_VT = (ushort)(((regC1 & (AS4963.C1.VT.Mask)) >> AS4963.C1.VT.Pos));



                    frm.chBox_PFD.Checked = Convert.ToBoolean(regC1_PFD);
                    frm.chBox_IPI.Checked = Convert.ToBoolean(regC1_IPI);
                    if (regC1_VDQ == 0)
                        frm.rBtn_DebTim.Checked = true;
                    if (regC1_VDQ == 1)
                        frm.rBtn_WinTim.Checked = true;

                    frm.numUpDown_CurrSenseThr.Value = regC1_VIL;
                    frm.numUpDown_VdsThr.Value = regC1_VT * 50;
                    frm.lbl_Config1.Visible = true;
                    ChangeLabel.Config1.Read(frm);
                }

                public static void Config2(Form1 frm, byte[] buffer)
                {
                    ushort regC2 = (ushort)((buffer[5] << 8) | buffer[6]);
                    ushort regC2_CP = (ushort)(((regC2 & (AS4963.C2.CP.Mask)) >> AS4963.C2.CP.Pos));
                    ushort regC2_SH = (ushort)(((regC2 & (AS4963.C2.SH.Mask)) >> AS4963.C2.SH.Pos));
                    ushort regC2_DGC = (ushort)(((regC2 & (AS4963.C2.DGC.Mask)) >> AS4963.C2.DGC.Pos));
                    ushort regC2_PW = (ushort)(((regC2 & (AS4963.C2.PW.Mask)) >> AS4963.C2.PW.Pos));



                    frm.numUpDown_PropGainPosCon.Value = regC2_CP;

                    if (regC2_SH == 0)
                        frm.rBtn_OvrSpeed100.Checked = true;
                    if (regC2_SH == 1)
                        frm.rBtn_OvrSpeed125.Checked = true;
                    if (regC2_SH == 2)
                        frm.rBtn_OvrSpeed150.Checked = true;
                    if (regC2_SH == 3)
                        frm.rBtn_OvrSpeed200.Checked = true;

                    frm.chBox_DegComp.Checked = Convert.ToBoolean(regC2_DGC);
                    frm.numUpDown_OffTime.Value = regC2_PW;
                    ChangeLabel.Config2.Read(frm);

                }


                public static void Config3(Form1 frm, byte[] buffer)
                {
                    ushort regC3 = (ushort)((buffer[7] << 8) | buffer[8]);
                    ushort regC3_CI = (ushort)(((regC3 & (AS4963.C3.CI.Mask)) >> AS4963.C3.CI.Pos));
                    ushort regC3_HD = (ushort)(((regC3 & (AS4963.C3.HD.Mask)) >> AS4963.C3.HD.Pos));
                    ushort regC3_HT = (ushort)(((regC3 & (AS4963.C3.HT.Mask)) >> AS4963.C3.HT.Pos));

                    frm.numUpDown_InGainPosCon.Value = regC3_CI;
                    frm.numUpDown_PWMDutyHold.Value = regC3_HD;
                    frm.numUpDown_HoldTime.Value = regC3_HT;
                    ChangeLabel.Config3.Read(frm);
                }


                public static void Config4(Form1 frm, byte[] buffer)
                {
                    ushort regC4 = (ushort)((buffer[9] << 8) | buffer[10]);
                    ushort regC4_SP = (ushort)(((regC4 & (AS4963.C4.SP.Mask)) >> AS4963.C4.SP.Pos));
                    ushort regC4_SD = (ushort)(((regC4 & (AS4963.C4.SD.Mask)) >> AS4963.C4.SD.Pos));
                    ushort regC4_SS = (ushort)(((regC4 & (AS4963.C4.SS.Mask)) >> AS4963.C4.SS.Pos));

                    frm.numUpDown_PropGainSpeed.Value = regC4_SP;
                    frm.numUpDown_PWMDutyCycleStartup.Value = regC4_SD;
                    frm.numUpDown_StartSpeed.Value = regC4_SS;
                    ChangeLabel.Config4.Read(frm);

                }

                public static void Config5(Form1 frm, byte[] buffer)
                {
                    ushort regC5 = (ushort)((buffer[11] << 8) | buffer[12]);
                    ushort regC5_SI = (ushort)(((regC5 & (AS4963.C5.SI.Mask)) >> AS4963.C5.SI.Pos));
                    ushort regC5_SPO = (ushort)(((regC5 & (AS4963.C5.SPO.Mask)) >> AS4963.C5.SPO.Pos));
                    ushort regC5_SMX = (ushort)(((regC5 & (AS4963.C5.SMX.Mask)) >> AS4963.C5.SMX.Pos));
                    ushort regC5_PA = (ushort)(((regC5 & (AS4963.C5.PA.Mask)) >> AS4963.C5.PA.Pos));


                    frm.numUpDown_InGainSpeedCon.Value = regC5_SI;
                    if (regC5_SPO == 0)
                        frm.rBtn_SpeedOutSelElectricFreeq.Checked = true;
                    if (regC5_SPO == 1)
                        frm.rBtn_SpeedOutSelCommuFreq.Checked = true;
                    frm.numUpDown_MaxSpeedHz.Value = regC5_SMX;
                    frm.numUpDown_PhaseAdvance.Value = regC5_PA;
                    ChangeLabel.Config5.Read(frm);

                }

                public static void Run(Form1 frm, byte[] buffer)
                {
                    ushort regRUN = (ushort)((buffer[13] << 8) | buffer[14]);
                    ushort regRUN_CM = (ushort)(((regRUN & (AS4963.RUN.CM.Mask)) >> AS4963.RUN.CM.Pos));
                    ushort regRUN_ESF = (ushort)(((regRUN & (AS4963.RUN.ESF.Mask)) >> AS4963.RUN.ESF.Pos));
                    ushort regRUN_DI = (ushort)(((regRUN & (AS4963.RUN.DI.Mask)) >> AS4963.RUN.DI.Pos));
                    ushort regRUN_RSC = (ushort)(((regRUN & (AS4963.RUN.RSC.Mask)) >> AS4963.RUN.RSC.Pos));
                    ushort regRUN_BRK = (ushort)(((regRUN & (AS4963.RUN.BRK.Mask)) >> AS4963.RUN.BRK.Pos));
                    ushort regRUN_DIR = (ushort)(((regRUN & (AS4963.RUN.DIR.Mask)) >> AS4963.RUN.DIR.Pos));
                    ushort regRUN_RUN = (ushort)(((regRUN & (AS4963.RUN.RRUN.Mask)) >> AS4963.RUN.RRUN.Pos));


                    if (regRUN_CM == 0)
                        frm.rBtn_MotConIndirect.Checked = true;
                    if (regRUN_CM == 1)
                        frm.rBtn_MotConDirect.Checked = true;
                    if (regRUN_CM == 2)
                        frm.rBtn_MotConClosedCurr.Checked = true;
                    if (regRUN_CM == 3)
                        frm.rBtn_MotConClosedSpeed.Checked = true;

                    frm.chBox_EnableStopFail.Checked = Convert.ToBoolean(regRUN_ESF);
                    frm.numUpDown_DutyCycleControl.Value = regRUN_DI;
                    frm.chBox_RestartControl.Checked = Convert.ToBoolean(regRUN_RSC);
                    frm.chBox_Brake.Checked = Convert.ToBoolean(regRUN_BRK);
                    frm.chBox_DirectionRotation.Checked = Convert.ToBoolean(regRUN_DIR);
                    frm.chBox_RunEnable.Checked = Convert.ToBoolean(regRUN_RUN);
                    ChangeLabel.ConfigRun.Read(frm);

                }


            }
        }


        /*************************************************************Change Status Config label*************************************************************************************************/


        public static class ChangeLabel
        {
            public static class Config0
            {
                public static void Read(Form1 frm)
                {
                    frm.lbl_Config0.Visible = true;
                    frm.lbl_Config0.Text = "R";
                    frm.lbl_Config0.BackColor = Color.FromArgb(128, 255, 128);
                 
                }
                public static void Write(Form1 frm)
                {
                    frm.lbl_Config0.Visible = true;
                    frm.lbl_Config0.Text = "W";
                    frm.lbl_Config0.BackColor =  Color.FromArgb(255, 192, 128);
                }

            }

            public static class Config1
            {
                public static void Read(Form1 frm)
                {
                    frm.lbl_Config1.Visible = true;
                    frm.lbl_Config1.Text = "R";
                    frm.lbl_Config1.BackColor = Color.FromArgb(128, 255, 128);

                }
                public static void Write(Form1 frm)
                {
                    frm.lbl_Config1.Visible = true;
                    frm.lbl_Config1.Text = "W";
                    frm.lbl_Config1.BackColor = Color.FromArgb(255, 192, 128);
                }

            }

            public static class Config2
            {
                public static void Read(Form1 frm)
                {
                    frm.lbl_Config2.Visible = true;
                    frm.lbl_Config2.Text = "R";
                    frm.lbl_Config2.BackColor = Color.FromArgb(128, 255, 128);

                }
                public static void Write(Form1 frm)
                {
                    frm.lbl_Config2.Visible = true;
                    frm.lbl_Config2.Text = "W";
                    frm.lbl_Config2.BackColor = Color.FromArgb(255, 192, 128);
                }

            }

            public static class Config3
            {
                public static void Read(Form1 frm)
                {
                    frm.lbl_Config3.Visible = true;
                    frm.lbl_Config3.Text = "R";
                    frm.lbl_Config3.BackColor = Color.FromArgb(128, 255, 128);

                }
                public static void Write(Form1 frm)
                {
                    frm.lbl_Config3.Visible = true;
                    frm.lbl_Config3.Text = "W";
                    frm.lbl_Config3.BackColor = Color.FromArgb(255, 192, 128);
                }

            }

            public static class Config4
            {
                public static void Read(Form1 frm)
                {
                    frm.lbl_Config4.Visible = true;
                    frm.lbl_Config4.Text = "R";
                    frm.lbl_Config4.BackColor = Color.FromArgb(128, 255, 128);

                }
                public static void Write(Form1 frm)
                {
                    frm.lbl_Config4.Visible = true;
                    frm.lbl_Config4.Text = "W";
                    frm.lbl_Config4.BackColor = Color.FromArgb(255, 192, 128);
                }

            }

            public static class Config5
            {
                public static void Read(Form1 frm)
                {
                    frm.lbl_Config5.Visible = true;
                    frm.lbl_Config5.Text = "R";
                    frm.lbl_Config5.BackColor = Color.FromArgb(128, 255, 128);

                }
                public static void Write(Form1 frm)
                {
                    frm.lbl_Config5.Visible = true;
                    frm.lbl_Config5.Text = "W";
                    frm.lbl_Config5.BackColor = Color.FromArgb(255, 192, 128);
                }

            }

            public static class ConfigRun
            {
                public static void Read(Form1 frm)
                {
                    frm.lbl_ConfigRun.Visible = true;
                    frm.lbl_ConfigRun.Text = "R";
                    frm.lbl_ConfigRun.BackColor = Color.FromArgb(128, 255, 128);

                }
                public static void Write(Form1 frm)
                {
                    frm.lbl_ConfigRun.Visible = true;
                    frm.lbl_ConfigRun.Text = "W";
                    frm.lbl_ConfigRun.BackColor = Color.FromArgb(255, 192, 128);
                }

            }

            public static void ClearAll(Form1 frm)
            {
                frm.lbl_Config0.Visible = false;
                frm.lbl_Config1.Visible = false;
                frm.lbl_Config2.Visible = false;
                frm.lbl_Config3.Visible = false;
                frm.lbl_Config4.Visible = false;
                frm.lbl_Config5.Visible = false;
                frm.lbl_ConfigRun.Visible = false;
            }


        }





    }
}
