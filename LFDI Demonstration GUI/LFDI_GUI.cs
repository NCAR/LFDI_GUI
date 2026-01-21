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
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Timers;




namespace LFDI_Demonstration_GUI
{

    public partial class Form1 : Form
    {
        SerialPort port = new SerialPort();
        bool portLocked = false;
        readonly ScottPlot.WinForms.FormsPlot formsPlot1;
        string[] heater1 = null;
        string[] heater2 = null;
        string[] heater3 = null;
        
        string[] compensator1 = null;
        string[] compensator2 = null;
        string[] compensator3 = null;
        System.Timers.Timer HK_Timer = new System.Timers.Timer(2000);
        string slope = "0.04";
        string intercept = "-655.27";



        public Form1()
        {   //Define Serial Port for Connection

            InitializeComponent();
            //formsPlot1 = new() { Dock = DockStyle.Fill };
            //this.Controls.Add(formsPlot1);

            //Add sample data to the plot
            //double[] data = ScottPlot.Generate.Sin();
            //formsPlot1.Plot.Add.Signal(data);
            //formsPlot1.Refresh();

            string[] ports = SerialPort.GetPortNames();
            //Find Available Comports
            foreach (string currPort in ports)
            {
                PortSelector.Items.Add(currPort);
            }
            ;






        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void TempControlBox_Enter(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                port.Close();
            }
            catch { }
            port = new SerialPort(PortSelector.SelectedItem.ToString());
            port.BaudRate = 9200;
            //port.ReadTimeout = 3;
            port.WriteTimeout = 100;
            port.NewLine = "\n";
            try
            {
                ComStatus.Text = "Status: Trying to open port " + PortSelector.SelectedItem.ToString();
                port.Open();

                ComStatus.Text = "Staus: " + PortSelector.SelectedItem.ToString() + " open.";
                if (port.IsOpen)
                {
                    if (!HK_Timer.Enabled)
                    {
                        HK_Timer.Elapsed += HK_Tick;
                        HK_Timer.Interval = 500; // Update Every Half Second
                        HK_Timer.Enabled = true;
                        HK_Timer.Start();
                    }
                    else
                    {
                        HK_Timer.Stop();
                        HK_Timer.Enabled = false;

                    }
                }

            }
            catch
            {
                ComStatus.Text = "Status: Unable to open port" + PortSelector.SelectedItem.ToString();
            }
        }

        private void RefreshCom_Click(object sender, EventArgs e)
        {
            PortSelector.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            //Find Available Comports
            foreach (string currPort in ports)
            {
                PortSelector.Items.Add(currPort);
            }
            ;
        }

        private void ProportionalRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (ProportionalRadio.Checked)
            {
                IntegralRadio.Checked = !ProportionalRadio.Checked;
                DerivativeRadio.Checked = !ProportionalRadio.Checked;
            }

        }

        private void IntegralRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (IntegralRadio.Checked)
            {
                ProportionalRadio.Checked = !IntegralRadio.Checked;
                DerivativeRadio.Checked = !IntegralRadio.Checked;
            }
        }

        private void DerivativeRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (DerivativeRadio.Checked)
            {
                ProportionalRadio.Checked = !DerivativeRadio.Checked;
                IntegralRadio.Checked = !DerivativeRadio.Checked;
            }

        }

        private void PIDSetField_TextChanged(object sender, EventArgs e)
        {

        }

        private void SendPIDControlCommand(string command, string heater)
        {
            command += heater;
            if (ProportionalRadio.Checked)
            {
                command += "KP_";
            }
            else if (IntegralRadio.Checked)
            {
                command += "KI_";
            }
            else if (DerivativeRadio.Checked)
            {
                command += "KD_";
            }
            command += PIDSetField.Text;
            while (portLocked) ;
            portLocked = true;
            port.WriteLine(command);
            portLocked = false;

        }
        private void PIDSetButton_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                float f;
                string command = "SET_HEATER_";
                if (float.TryParse(PIDSetField.Text, out f))
                {
                
                    if (Heater1checkBox.Checked)
                    {
                        SendPIDControlCommand(command, "1_");
                        
                    }
                    if (Heater2checkBox.Checked)
                    {
                        SendPIDControlCommand(command, "2_");

                    }
                    if (Heater3checkBox.Checked)
                    {
                       SendPIDControlCommand(command, "3_");

                    }                

                }
            }
        }

        private void LFDIResponse_Click(object sender, EventArgs e)
        {

        }

        private void LFDIReturn_Click(object sender, EventArgs e)
        {
           
        }

        private void TempSetButton_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                float f;
                string command = "SET_HEATER_";
                if (float.TryParse(TempSetBox.Text, out f))
                {
                    command += TempSetBox.Text;
                    while (portLocked) ; portLocked = true;
                    port.WriteLine(command);
                    portLocked = false;

                }
            }
        }

        private void WavelengthSet_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                float f;
                string command = "SET_WAVE_";
                if (float.TryParse(WavelengthInput.Text, out f))
                {
                    command += WavelengthInput.Text;
                    while (portLocked) ; portLocked = true;
                    port.WriteLine(command);
                    portLocked = false;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                string command = null;
                if (button6.Text == "Heater On")
                {
                    command = "SET_HEATER_ON";
                    button6.Text = "Stop Heating";
                    button6.BackColor = Color.Red;

                }
                else if (button6.Text == "Stop Heating")
                {
                    command = "SET_HEATER_OFF";
                    button6.Text = "Heater On";
                    button6.BackColor = DefaultBackColor;
                }
                while (portLocked) ; portLocked = true;
                port.WriteLine(command);
                portLocked = false;

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                string command = null;
                if (button8.Text == "Tuning On")
                {
                    command = "SET_TUNE_ON";
                    button8.Text = "Stop Tuning";
                    button8.BackColor = Color.Red;

                }
                else if (button8.Text == "Stop Tuning")
                {
                    command = "SET_TUNE_OFF";
                    button8.Text = "Tuning On";
                    button8.BackColor = DefaultBackColor;
                }
                while (portLocked) ; portLocked = true;
                port.WriteLine(command);
                portLocked = false;
            }
        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        public bool get_hk()
        {
            string response = null;
            if (port.IsOpen)
            {
                //Clear the Data
                port.ReadExisting();
                while (portLocked) ; portLocked = true;
                port.WriteLine("GET_HK");
                portLocked = false;
                System.Threading.Thread.Sleep(100);//Wait .1 sec allow time for print out
                response = port.ReadExisting();


                parse_hk(response);
            }
            return portLocked;

        }

        //Parse the HK Data
        //HK Data Format:
        //H[N]\t[kp]\t[ki]\t[kd]\t[Temperature]\t[setpoint]\t[HeaterStatus]\t[Current]\n
        //C[N]\t[Wavelength]\t[voltage]\t[stagesize]\n
        //Where N is the heater number 1 - 3
        //kp is the proportional gain in 3.2f format
        //ki is the integral gain in 3.2f format
        //kd is the derivative gain in 3.2f format
        //Temperature is the current temperature in 3.2f format
        //Setpoint is the current setpoint in 3.2f format
        //HeaterStatus is the heater status
        //Current is the current value in 4.0f format
        //Wavelength is the current wavelength in 3.2f format
        //Voltage is the current voltage in 3.2f format
        //Stagesize is the current stagesize in 2.2f format
        public void parse_hk(string response)
        {
            string[] lines = response.Split('\n');
            heater1 = lines[0].Split('\t');
            heater2 = lines[1].Split('\t');
            heater3 = lines[2].Split('\t');

            compensator1 = lines[3].Split('\t');
            compensator2 = lines[4].Split('\t');
            compensator3 = lines[5].Split('\t');


            //Heater 1
            if (HeaterDataGrid.InvokeRequired)
            {
                HeaterDataGrid.Invoke(new Action(UpdateHeaterDataGrid));
            }

            if (CompensatorDataGrid.InvokeRequired)
            {
                CompensatorDataGrid.Invoke(new Action(UpdateCompesatorDataGrid));
            }
            //Compensator

        }
        private void UpdateCompesatorDataGrid() {

            CompensatorDataGrid.Rows.Clear();
            CompensatorDataGrid.Rows.Add(compensator1);
            CompensatorDataGrid.Rows.Add(compensator2);
            CompensatorDataGrid.Rows.Add(compensator3);
        }

        private void UpdateHeaterDataGrid()
        {
            HeaterDataGrid.Rows.Clear();
            HeaterDataGrid.Rows.Add(heater1);
            HeaterDataGrid.Rows.Add(heater2);
            HeaterDataGrid.Rows.Add(heater3);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            //Start a new thread to get the housekeeping data every .5 seconds
            //The Timer should take control of the HeaterDataGrid and CompensatorDataGrid
            if (port.IsOpen) {
                if (!HK_Timer.Enabled) { 
                    HK_Timer.Elapsed += HK_Tick;
                    HK_Timer.Interval = 500; // Update Every Half Second
                    HK_Timer.Enabled = true;
                    HK_Timer.Start();
                }
                else
                {
                    HK_Timer.Stop();
                    HK_Timer.Enabled = false;

                }
            }

        }

        private void HK_Tick(object sender, ElapsedEventArgs e)
        {
            get_hk();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void updateSlopeInterceptLabel()
        {
            SlopeInterceptEquationLabel.Text = "y=(" + slope + ")+(" + intercept + ")";
        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                float f;
                string command = "SET_SLOPE_";
                if (float.TryParse(SlopetextBox8.Text, out f))
                {
                    command += SlopetextBox8.Text;
                    while (portLocked) ; portLocked = true;
                    port.WriteLine(command);
                    portLocked = false;
                    slope = SlopetextBox8.Text;
                    updateSlopeInterceptLabel();
                }
            }
        }

        private void InterceptSetbutton_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                float f;
                string command = "SET_INT_";
                if (float.TryParse(IntercepttextBox.Text, out f))
                {
                    command += IntercepttextBox.Text;
                    while (portLocked) ; portLocked = true;
                    port.WriteLine(command);
                    portLocked = false;
                    intercept = IntercepttextBox.Text;
                    updateSlopeInterceptLabel();
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Heater1checkBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Stage1CheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Stage3CheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void VoltageSetButton_Click(object sender, EventArgs e)
        {
            string command = null;
            if (button8.Text == "Stop Tuning")
            {
                command = "SET_TUNE_OFF";
                button8.Text = "Tuning On";
                button8.BackColor = DefaultBackColor;
                while (portLocked) ; portLocked = true;
                port.WriteLine(command);
                portLocked = false;
            }
            
            if (port.IsOpen)
            {

                float f;
                command = "SET_VOLTAGE_";
                if (float.TryParse(VoltageSetBox.Text, out f))
                {

                    if (Stage1CheckBox.Checked)
                    {
                        SendVoltageControlCommand(command, "1_");

                    }
                    if (Stage2CheckBox.Checked)
                    {
                        SendVoltageControlCommand(command, "2_");

                    }
                    if (Stage3CheckBox.Checked)
                    {
                        SendVoltageControlCommand(command, "3_");

                    }

                }
            }
        }
        private void SendVoltageControlCommand(string command, string stage)
        {
            command += stage;

            command += VoltageSetBox.Text;
            while (portLocked) ;
            portLocked = true;
            port.WriteLine(command);
            portLocked = false;

        }
    }
    

}

