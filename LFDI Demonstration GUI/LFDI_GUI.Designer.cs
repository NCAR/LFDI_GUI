namespace LFDI_Demonstration_GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            Instrument = new System.Windows.Forms.TabPage();
            label3 = new System.Windows.Forms.Label();
            textBox2 = new System.Windows.Forms.TextBox();
            textBox1 = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            Focus = new System.Windows.Forms.TabPage();
            button4 = new System.Windows.Forms.Button();
            textBox3 = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            button3 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            Camera = new System.Windows.Forms.TabPage();
            textBox7 = new System.Windows.Forms.TextBox();
            textBox6 = new System.Windows.Forms.TextBox();
            textBox5 = new System.Windows.Forms.TextBox();
            textBox4 = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            TuningControlBoardTab = new System.Windows.Forms.TabPage();
            groupBox1 = new System.Windows.Forms.GroupBox();
            LFDIReturn = new System.Windows.Forms.Label();
            RefreshCom = new System.Windows.Forms.Button();
            PortSelector = new System.Windows.Forms.ComboBox();
            button9 = new System.Windows.Forms.Button();
            ComStatus = new System.Windows.Forms.Label();
            HeaterData = new System.Windows.Forms.GroupBox();
            button5 = new System.Windows.Forms.Button();
            CompensatorDataGrid = new System.Windows.Forms.DataGridView();
            HeaterDataGrid = new System.Windows.Forms.DataGridView();
            TempControlBox = new System.Windows.Forms.GroupBox();
            button6 = new System.Windows.Forms.Button();
            TempSetButton = new System.Windows.Forms.Button();
            PIDSettingBox = new System.Windows.Forms.GroupBox();
            label10 = new System.Windows.Forms.Label();
            PIDSetButton = new System.Windows.Forms.Button();
            label13 = new System.Windows.Forms.Label();
            PIDSetField = new System.Windows.Forms.TextBox();
            HeaterRadioBox = new System.Windows.Forms.GroupBox();
            Heater1Radio = new System.Windows.Forms.RadioButton();
            Heater3Radio = new System.Windows.Forms.RadioButton();
            Heater2Radio = new System.Windows.Forms.RadioButton();
            PIDRadioBox = new System.Windows.Forms.GroupBox();
            ProportionalRadio = new System.Windows.Forms.RadioButton();
            DerivativeRadio = new System.Windows.Forms.RadioButton();
            IntegralRadio = new System.Windows.Forms.RadioButton();
            label12 = new System.Windows.Forms.Label();
            TempSetBox = new System.Windows.Forms.TextBox();
            TuningControlPanel = new System.Windows.Forms.GroupBox();
            button8 = new System.Windows.Forms.Button();
            WavelengthSet = new System.Windows.Forms.Button();
            label11 = new System.Windows.Forms.Label();
            WavelengthInput = new System.Windows.Forms.TextBox();
            tabControl1 = new System.Windows.Forms.TabControl();
            timer1 = new System.Windows.Forms.Timer(components);
            HeaterLabelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            KpColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            KiColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            KdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            AverageTempColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            SetPointColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            HeaterStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            StageLabelCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            WavelengthCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            VoltageCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            StageSizeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TuningCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Instrument.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Focus.SuspendLayout();
            Camera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            TuningControlBoardTab.SuspendLayout();
            groupBox1.SuspendLayout();
            HeaterData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CompensatorDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HeaterDataGrid).BeginInit();
            TempControlBox.SuspendLayout();
            PIDSettingBox.SuspendLayout();
            HeaterRadioBox.SuspendLayout();
            PIDRadioBox.SuspendLayout();
            TuningControlPanel.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // Instrument
            // 
            Instrument.BackColor = System.Drawing.Color.Linen;
            Instrument.Controls.Add(label3);
            Instrument.Controls.Add(textBox2);
            Instrument.Controls.Add(textBox1);
            Instrument.Controls.Add(label2);
            Instrument.Controls.Add(label1);
            Instrument.Controls.Add(button1);
            Instrument.Controls.Add(pictureBox1);
            Instrument.Location = new System.Drawing.Point(4, 24);
            Instrument.Name = "Instrument";
            Instrument.Padding = new System.Windows.Forms.Padding(3);
            Instrument.Size = new System.Drawing.Size(1108, 740);
            Instrument.TabIndex = 3;
            Instrument.Text = "Instrument";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label3.Location = new System.Drawing.Point(303, 424);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(55, 15);
            label3.TabIndex = 6;
            label3.Text = "SavePath";
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(303, 442);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(282, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox1.Location = new System.Drawing.Point(27, 100);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(135, 43);
            textBox1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(27, 69);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(70, 15);
            label2.TabIndex = 4;
            label2.Text = "Wavelength";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(303, 23);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(83, 15);
            label1.TabIndex = 3;
            label1.Text = "Current Image";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(303, 472);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(183, 52);
            button1.TabIndex = 2;
            button1.Text = "Capture Image";
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new System.Drawing.Point(303, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(318, 349);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Focus
            // 
            Focus.BackColor = System.Drawing.Color.LavenderBlush;
            Focus.Controls.Add(button4);
            Focus.Controls.Add(textBox3);
            Focus.Controls.Add(label7);
            Focus.Controls.Add(label6);
            Focus.Controls.Add(label5);
            Focus.Controls.Add(button3);
            Focus.Controls.Add(button2);
            Focus.Controls.Add(label4);
            Focus.Location = new System.Drawing.Point(4, 24);
            Focus.Name = "Focus";
            Focus.Padding = new System.Windows.Forms.Padding(3);
            Focus.Size = new System.Drawing.Size(1108, 740);
            Focus.TabIndex = 2;
            Focus.Text = "Focus";
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(146, 258);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(75, 23);
            button4.TabIndex = 7;
            button4.Text = "Goto";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(26, 258);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(100, 23);
            textBox3.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(26, 211);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(179, 37);
            label7.TabIndex = 5;
            label7.Text = "Goto Position";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(26, 120);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(207, 37);
            label6.TabIndex = 4;
            label6.Text = "Current Position";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(381, 106);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(59, 37);
            label5.TabIndex = 3;
            label5.Text = "Jog";
            label5.Click += label5_Click;
            // 
            // button3
            // 
            button3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button3.Location = new System.Drawing.Point(381, 258);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(180, 114);
            button3.TabIndex = 2;
            button3.Text = "backwards";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button2.Location = new System.Drawing.Point(381, 146);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(180, 93);
            button2.TabIndex = 1;
            button2.Text = "forwards";
            button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(26, 72);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(207, 37);
            label4.TabIndex = 0;
            label4.Text = "Current Position";
            label4.Click += label4_Click;
            // 
            // Camera
            // 
            Camera.BackColor = System.Drawing.Color.SkyBlue;
            Camera.Controls.Add(textBox7);
            Camera.Controls.Add(textBox6);
            Camera.Controls.Add(textBox5);
            Camera.Controls.Add(textBox4);
            Camera.Controls.Add(label9);
            Camera.Controls.Add(label8);
            Camera.Controls.Add(pictureBox2);
            Camera.Location = new System.Drawing.Point(4, 24);
            Camera.Name = "Camera";
            Camera.Padding = new System.Windows.Forms.Padding(3);
            Camera.Size = new System.Drawing.Size(1108, 740);
            Camera.TabIndex = 1;
            Camera.Text = "Camera";
            // 
            // textBox7
            // 
            textBox7.Location = new System.Drawing.Point(3, 434);
            textBox7.Name = "textBox7";
            textBox7.Size = new System.Drawing.Size(100, 23);
            textBox7.TabIndex = 8;
            // 
            // textBox6
            // 
            textBox6.Location = new System.Drawing.Point(8, 310);
            textBox6.Name = "textBox6";
            textBox6.Size = new System.Drawing.Size(100, 23);
            textBox6.TabIndex = 7;
            // 
            // textBox5
            // 
            textBox5.Location = new System.Drawing.Point(8, 180);
            textBox5.Name = "textBox5";
            textBox5.Size = new System.Drawing.Size(100, 23);
            textBox5.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(8, 46);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(100, 23);
            textBox4.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(281, 43);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(83, 15);
            label9.TabIndex = 4;
            label9.Text = "Current Image";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(8, 28);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(48, 15);
            label8.TabIndex = 3;
            label8.Text = "Binning";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new System.Drawing.Point(281, 61);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(318, 349);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // TuningControlBoardTab
            // 
            TuningControlBoardTab.BackColor = System.Drawing.Color.PaleTurquoise;
            TuningControlBoardTab.Controls.Add(groupBox1);
            TuningControlBoardTab.Controls.Add(HeaterData);
            TuningControlBoardTab.Controls.Add(TempControlBox);
            TuningControlBoardTab.Controls.Add(TuningControlPanel);
            TuningControlBoardTab.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TuningControlBoardTab.Location = new System.Drawing.Point(4, 24);
            TuningControlBoardTab.Name = "TuningControlBoardTab";
            TuningControlBoardTab.Padding = new System.Windows.Forms.Padding(3);
            TuningControlBoardTab.Size = new System.Drawing.Size(1108, 740);
            TuningControlBoardTab.TabIndex = 0;
            TuningControlBoardTab.Text = "Tuning Control Board";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.Color.Azure;
            groupBox1.Controls.Add(LFDIReturn);
            groupBox1.Controls.Add(RefreshCom);
            groupBox1.Controls.Add(PortSelector);
            groupBox1.Controls.Add(button9);
            groupBox1.Controls.Add(ComStatus);
            groupBox1.Location = new System.Drawing.Point(552, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(287, 222);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "COM ports";
            // 
            // LFDIReturn
            // 
            LFDIReturn.AutoSize = true;
            LFDIReturn.Location = new System.Drawing.Point(6, 181);
            LFDIReturn.Name = "LFDIReturn";
            LFDIReturn.Size = new System.Drawing.Size(45, 13);
            LFDIReturn.TabIndex = 13;
            LFDIReturn.Text = "Return:";
            LFDIReturn.Click += LFDIReturn_Click;
            // 
            // RefreshCom
            // 
            RefreshCom.Location = new System.Drawing.Point(189, 110);
            RefreshCom.Name = "RefreshCom";
            RefreshCom.Size = new System.Drawing.Size(92, 44);
            RefreshCom.TabIndex = 12;
            RefreshCom.Text = "Refresh";
            RefreshCom.UseVisualStyleBackColor = true;
            RefreshCom.Click += RefreshCom_Click;
            // 
            // PortSelector
            // 
            PortSelector.FormattingEnabled = true;
            PortSelector.Location = new System.Drawing.Point(6, 25);
            PortSelector.Name = "PortSelector";
            PortSelector.Size = new System.Drawing.Size(275, 21);
            PortSelector.TabIndex = 8;
            PortSelector.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button9
            // 
            button9.Location = new System.Drawing.Point(189, 56);
            button9.Name = "button9";
            button9.Size = new System.Drawing.Size(92, 44);
            button9.TabIndex = 10;
            button9.Text = "Connect";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // ComStatus
            // 
            ComStatus.AutoSize = true;
            ComStatus.Location = new System.Drawing.Point(6, 72);
            ComStatus.Name = "ComStatus";
            ComStatus.Size = new System.Drawing.Size(123, 13);
            ComStatus.TabIndex = 11;
            ComStatus.Text = "Status: Not Connected";
            // 
            // HeaterData
            // 
            HeaterData.BackColor = System.Drawing.Color.Azure;
            HeaterData.Controls.Add(button5);
            HeaterData.Controls.Add(CompensatorDataGrid);
            HeaterData.Controls.Add(HeaterDataGrid);
            HeaterData.Location = new System.Drawing.Point(8, 390);
            HeaterData.Name = "HeaterData";
            HeaterData.Size = new System.Drawing.Size(842, 341);
            HeaterData.TabIndex = 7;
            HeaterData.TabStop = false;
            HeaterData.Text = "House Keeping";
            // 
            // button5
            // 
            button5.Location = new System.Drawing.Point(756, 21);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(75, 23);
            button5.TabIndex = 2;
            button5.Text = "Refresh";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click_1;
            // 
            // CompensatorDataGrid
            // 
            CompensatorDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CompensatorDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { StageLabelCol, WavelengthCol, VoltageCol, StageSizeCol, TuningCol });
            CompensatorDataGrid.Location = new System.Drawing.Point(6, 159);
            CompensatorDataGrid.Name = "CompensatorDataGrid";
            CompensatorDataGrid.RowTemplate.Height = 25;
            CompensatorDataGrid.Size = new System.Drawing.Size(547, 150);
            CompensatorDataGrid.TabIndex = 1;
            // 
            // HeaterDataGrid
            // 
            HeaterDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HeaterDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { HeaterLabelColumn, KpColumn, KiColumn, KdColumn, AverageTempColumn, SetPointColumn, HeaterStatusColumn });
            HeaterDataGrid.Location = new System.Drawing.Point(6, 21);
            HeaterDataGrid.Name = "HeaterDataGrid";
            HeaterDataGrid.RowTemplate.Height = 25;
            HeaterDataGrid.Size = new System.Drawing.Size(744, 132);
            HeaterDataGrid.TabIndex = 0;
            // 
            // TempControlBox
            // 
            TempControlBox.BackColor = System.Drawing.Color.Azure;
            TempControlBox.Controls.Add(button6);
            TempControlBox.Controls.Add(TempSetButton);
            TempControlBox.Controls.Add(PIDSettingBox);
            TempControlBox.Controls.Add(label12);
            TempControlBox.Controls.Add(TempSetBox);
            TempControlBox.Location = new System.Drawing.Point(269, 6);
            TempControlBox.Name = "TempControlBox";
            TempControlBox.Size = new System.Drawing.Size(277, 378);
            TempControlBox.TabIndex = 6;
            TempControlBox.TabStop = false;
            TempControlBox.Text = "Temperature Control";
            TempControlBox.Enter += TempControlBox_Enter;
            // 
            // button6
            // 
            button6.Location = new System.Drawing.Point(12, 78);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(98, 29);
            button6.TabIndex = 13;
            button6.Text = "Heater On";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // TempSetButton
            // 
            TempSetButton.Location = new System.Drawing.Point(116, 44);
            TempSetButton.Name = "TempSetButton";
            TempSetButton.Size = new System.Drawing.Size(98, 29);
            TempSetButton.TabIndex = 11;
            TempSetButton.Text = "Set";
            TempSetButton.UseVisualStyleBackColor = true;
            TempSetButton.Click += TempSetButton_Click;
            // 
            // PIDSettingBox
            // 
            PIDSettingBox.Controls.Add(label10);
            PIDSettingBox.Controls.Add(PIDSetButton);
            PIDSettingBox.Controls.Add(label13);
            PIDSettingBox.Controls.Add(PIDSetField);
            PIDSettingBox.Controls.Add(HeaterRadioBox);
            PIDSettingBox.Controls.Add(PIDRadioBox);
            PIDSettingBox.Location = new System.Drawing.Point(6, 141);
            PIDSettingBox.Name = "PIDSettingBox";
            PIDSettingBox.Size = new System.Drawing.Size(262, 231);
            PIDSettingBox.TabIndex = 4;
            PIDSettingBox.TabStop = false;
            PIDSettingBox.Text = "PID Settings";
            // 
            // label10
            // 
            label10.AllowDrop = true;
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(10, 216);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(0, 13);
            label10.TabIndex = 11;
            // 
            // PIDSetButton
            // 
            PIDSetButton.Location = new System.Drawing.Point(116, 184);
            PIDSetButton.Name = "PIDSetButton";
            PIDSetButton.Size = new System.Drawing.Size(98, 29);
            PIDSetButton.TabIndex = 10;
            PIDSetButton.Text = "Set";
            PIDSetButton.UseVisualStyleBackColor = true;
            PIDSetButton.Click += PIDSetButton_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(6, 160);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(35, 13);
            label13.TabIndex = 9;
            label13.Text = "Value";
            // 
            // PIDSetField
            // 
            PIDSetField.Location = new System.Drawing.Point(0, 184);
            PIDSetField.Name = "PIDSetField";
            PIDSetField.Size = new System.Drawing.Size(100, 22);
            PIDSetField.TabIndex = 8;
            PIDSetField.TextChanged += PIDSetField_TextChanged;
            // 
            // HeaterRadioBox
            // 
            HeaterRadioBox.Controls.Add(Heater1Radio);
            HeaterRadioBox.Controls.Add(Heater3Radio);
            HeaterRadioBox.Controls.Add(Heater2Radio);
            HeaterRadioBox.Location = new System.Drawing.Point(144, 28);
            HeaterRadioBox.Name = "HeaterRadioBox";
            HeaterRadioBox.Size = new System.Drawing.Size(107, 129);
            HeaterRadioBox.TabIndex = 7;
            HeaterRadioBox.TabStop = false;
            HeaterRadioBox.Text = "HeaterBox";
            // 
            // Heater1Radio
            // 
            Heater1Radio.AutoSize = true;
            Heater1Radio.Location = new System.Drawing.Point(6, 28);
            Heater1Radio.Name = "Heater1Radio";
            Heater1Radio.Size = new System.Drawing.Size(65, 17);
            Heater1Radio.TabIndex = 6;
            Heater1Radio.TabStop = true;
            Heater1Radio.Text = "Heater1";
            Heater1Radio.UseVisualStyleBackColor = true;
            Heater1Radio.CheckedChanged += Heater1Radio_CheckedChanged;
            // 
            // Heater3Radio
            // 
            Heater3Radio.AutoSize = true;
            Heater3Radio.Location = new System.Drawing.Point(6, 90);
            Heater3Radio.Name = "Heater3Radio";
            Heater3Radio.Size = new System.Drawing.Size(65, 17);
            Heater3Radio.TabIndex = 8;
            Heater3Radio.TabStop = true;
            Heater3Radio.Text = "Heater3";
            Heater3Radio.UseVisualStyleBackColor = true;
            Heater3Radio.CheckedChanged += Heater3Radio_CheckedChanged;
            // 
            // Heater2Radio
            // 
            Heater2Radio.AutoSize = true;
            Heater2Radio.Location = new System.Drawing.Point(6, 59);
            Heater2Radio.Name = "Heater2Radio";
            Heater2Radio.Size = new System.Drawing.Size(65, 17);
            Heater2Radio.TabIndex = 7;
            Heater2Radio.TabStop = true;
            Heater2Radio.Text = "Heater2";
            Heater2Radio.UseVisualStyleBackColor = true;
            // 
            // PIDRadioBox
            // 
            PIDRadioBox.Controls.Add(ProportionalRadio);
            PIDRadioBox.Controls.Add(DerivativeRadio);
            PIDRadioBox.Controls.Add(IntegralRadio);
            PIDRadioBox.Location = new System.Drawing.Point(6, 28);
            PIDRadioBox.Name = "PIDRadioBox";
            PIDRadioBox.Size = new System.Drawing.Size(132, 129);
            PIDRadioBox.TabIndex = 6;
            PIDRadioBox.TabStop = false;
            PIDRadioBox.Text = "PIDBox";
            // 
            // ProportionalRadio
            // 
            ProportionalRadio.AutoSize = true;
            ProportionalRadio.Location = new System.Drawing.Point(6, 28);
            ProportionalRadio.Name = "ProportionalRadio";
            ProportionalRadio.Size = new System.Drawing.Size(90, 17);
            ProportionalRadio.TabIndex = 3;
            ProportionalRadio.TabStop = true;
            ProportionalRadio.Text = "Proportional";
            ProportionalRadio.UseVisualStyleBackColor = true;
            ProportionalRadio.CheckedChanged += ProportionalRadio_CheckedChanged;
            // 
            // DerivativeRadio
            // 
            DerivativeRadio.AutoSize = true;
            DerivativeRadio.Location = new System.Drawing.Point(6, 90);
            DerivativeRadio.Name = "DerivativeRadio";
            DerivativeRadio.Size = new System.Drawing.Size(75, 17);
            DerivativeRadio.TabIndex = 5;
            DerivativeRadio.TabStop = true;
            DerivativeRadio.Text = "Derivative";
            DerivativeRadio.UseVisualStyleBackColor = true;
            DerivativeRadio.CheckedChanged += DerivativeRadio_CheckedChanged;
            // 
            // IntegralRadio
            // 
            IntegralRadio.AutoSize = true;
            IntegralRadio.Location = new System.Drawing.Point(6, 59);
            IntegralRadio.Name = "IntegralRadio";
            IntegralRadio.Size = new System.Drawing.Size(65, 17);
            IntegralRadio.TabIndex = 4;
            IntegralRadio.TabStop = true;
            IntegralRadio.Text = "Integral";
            IntegralRadio.UseVisualStyleBackColor = true;
            IntegralRadio.CheckedChanged += IntegralRadio_CheckedChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(6, 25);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(134, 13);
            label12.TabIndex = 1;
            label12.Text = "Temperature Setpoint (C)";
            // 
            // TempSetBox
            // 
            TempSetBox.Location = new System.Drawing.Point(10, 49);
            TempSetBox.Name = "TempSetBox";
            TempSetBox.Size = new System.Drawing.Size(100, 22);
            TempSetBox.TabIndex = 0;
            // 
            // TuningControlPanel
            // 
            TuningControlPanel.BackColor = System.Drawing.Color.Azure;
            TuningControlPanel.Controls.Add(button8);
            TuningControlPanel.Controls.Add(WavelengthSet);
            TuningControlPanel.Controls.Add(label11);
            TuningControlPanel.Controls.Add(WavelengthInput);
            TuningControlPanel.Location = new System.Drawing.Point(8, 6);
            TuningControlPanel.Name = "TuningControlPanel";
            TuningControlPanel.Size = new System.Drawing.Size(255, 128);
            TuningControlPanel.TabIndex = 5;
            TuningControlPanel.TabStop = false;
            TuningControlPanel.Text = "Tuning";
            // 
            // button8
            // 
            button8.Location = new System.Drawing.Point(6, 78);
            button8.Name = "button8";
            button8.Size = new System.Drawing.Size(147, 29);
            button8.TabIndex = 8;
            button8.Text = "Tuning On";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // WavelengthSet
            // 
            WavelengthSet.Location = new System.Drawing.Point(143, 44);
            WavelengthSet.Name = "WavelengthSet";
            WavelengthSet.Size = new System.Drawing.Size(87, 29);
            WavelengthSet.TabIndex = 7;
            WavelengthSet.Text = "Set";
            WavelengthSet.UseVisualStyleBackColor = true;
            WavelengthSet.Click += WavelengthSet_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(6, 25);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(94, 13);
            label11.TabIndex = 6;
            label11.Text = "Wavelength (nm)";
            // 
            // WavelengthInput
            // 
            WavelengthInput.Location = new System.Drawing.Point(6, 49);
            WavelengthInput.Name = "WavelengthInput";
            WavelengthInput.Size = new System.Drawing.Size(131, 22);
            WavelengthInput.TabIndex = 5;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(TuningControlBoardTab);
            tabControl1.Controls.Add(Camera);
            tabControl1.Controls.Add(Focus);
            tabControl1.Controls.Add(Instrument);
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(1116, 768);
            tabControl1.TabIndex = 0;
            // 
            // HeaterLabelColumn
            // 
            HeaterLabelColumn.HeaderText = "Heater Label";
            HeaterLabelColumn.Name = "HeaterLabelColumn";
            // 
            // KpColumn
            // 
            KpColumn.HeaderText = "Kp";
            KpColumn.Name = "KpColumn";
            // 
            // KiColumn
            // 
            KiColumn.HeaderText = "Ki";
            KiColumn.Name = "KiColumn";
            // 
            // KdColumn
            // 
            KdColumn.HeaderText = "Kd";
            KdColumn.Name = "KdColumn";
            // 
            // AverageTempColumn
            // 
            AverageTempColumn.HeaderText = "AverageTemp";
            AverageTempColumn.Name = "AverageTempColumn";
            // 
            // SetPointColumn
            // 
            SetPointColumn.HeaderText = "Set Point";
            SetPointColumn.Name = "SetPointColumn";
            // 
            // HeaterStatusColumn
            // 
            HeaterStatusColumn.HeaderText = "HeaterStatus";
            HeaterStatusColumn.Name = "HeaterStatusColumn";
            // 
            // StageLabelCol
            // 
            StageLabelCol.HeaderText = "Stage Label";
            StageLabelCol.Name = "StageLabelCol";
            // 
            // WavelengthCol
            // 
            WavelengthCol.HeaderText = "Wavelength";
            WavelengthCol.Name = "WavelengthCol";
            // 
            // VoltageCol
            // 
            VoltageCol.HeaderText = "Voltage";
            VoltageCol.Name = "VoltageCol";
            // 
            // StageSizeCol
            // 
            StageSizeCol.HeaderText = "Stage Size";
            StageSizeCol.Name = "StageSizeCol";
            // 
            // TuningCol
            // 
            TuningCol.HeaderText = "Tuning";
            TuningCol.Name = "TuningCol";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(860, 767);
            Controls.Add(tabControl1);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Lyot Filter Demonstration Instrument Control Panel";
            Load += Form1_Load;
            Instrument.ResumeLayout(false);
            Instrument.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Focus.ResumeLayout(false);
            Focus.PerformLayout();
            Camera.ResumeLayout(false);
            Camera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            TuningControlBoardTab.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            HeaterData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CompensatorDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)HeaterDataGrid).EndInit();
            TempControlBox.ResumeLayout(false);
            TempControlBox.PerformLayout();
            PIDSettingBox.ResumeLayout(false);
            PIDSettingBox.PerformLayout();
            HeaterRadioBox.ResumeLayout(false);
            HeaterRadioBox.PerformLayout();
            PIDRadioBox.ResumeLayout(false);
            PIDRadioBox.PerformLayout();
            TuningControlPanel.ResumeLayout(false);
            TuningControlPanel.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TabPage Instrument;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage Focus;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage Camera;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabPage TuningControlBoardTab;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.GroupBox TuningControlPanel;
        private System.Windows.Forms.TextBox WavelengthInput;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button WavelengthSet;
        private System.Windows.Forms.GroupBox HeaterData;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox TempControlBox;
        private System.Windows.Forms.Button TempSetButton;
        private System.Windows.Forms.GroupBox PIDSettingBox;
        private System.Windows.Forms.Button PIDSetButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox PIDSetField;
        private System.Windows.Forms.GroupBox HeaterRadioBox;
        private System.Windows.Forms.RadioButton Heater1Radio;
        private System.Windows.Forms.RadioButton Heater3Radio;
        private System.Windows.Forms.RadioButton Heater2Radio;
        private System.Windows.Forms.GroupBox PIDRadioBox;
        private System.Windows.Forms.RadioButton ProportionalRadio;
        private System.Windows.Forms.RadioButton DerivativeRadio;
        private System.Windows.Forms.RadioButton IntegralRadio;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TempSetBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ComStatus;
        private System.Windows.Forms.ComboBox PortSelector;
        private System.Windows.Forms.Button RefreshCom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LFDIReturn;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView HeaterDataGrid;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView CompensatorDataGrid;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StageLabelCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn WavelengthCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn VoltageCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn StageSizeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TuningCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeaterLabelColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn KpColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn KiColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn KdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AverageTempColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SetPointColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeaterStatusColumn;
    }
}
