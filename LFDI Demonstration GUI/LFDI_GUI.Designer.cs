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
            this.components = new System.ComponentModel.Container();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Instrument = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Focus = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Camera = new System.Windows.Forms.TabPage();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TuningControlBoardTab = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RefreshCom = new System.Windows.Forms.Button();
            this.PortSelector = new System.Windows.Forms.ComboBox();
            this.button9 = new System.Windows.Forms.Button();
            this.ComStatus = new System.Windows.Forms.Label();
            this.HeaterData = new System.Windows.Forms.GroupBox();
            this.CompensatorDataGrid = new System.Windows.Forms.DataGridView();
            this.StageLabelCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WavelengthCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VoltageCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StageSizeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TuningCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeaterDataGrid = new System.Windows.Forms.DataGridView();
            this.TempControlBox = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.TempSetButton = new System.Windows.Forms.Button();
            this.PIDSettingBox = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.PIDSetButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.PIDSetField = new System.Windows.Forms.TextBox();
            this.HeaterRadioBox = new System.Windows.Forms.GroupBox();
            this.Heater3checkBox = new System.Windows.Forms.CheckBox();
            this.Heater2checkBox = new System.Windows.Forms.CheckBox();
            this.Heater1checkBox = new System.Windows.Forms.CheckBox();
            this.PIDRadioBox = new System.Windows.Forms.GroupBox();
            this.ProportionalRadio = new System.Windows.Forms.RadioButton();
            this.DerivativeRadio = new System.Windows.Forms.RadioButton();
            this.IntegralRadio = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.TempSetBox = new System.Windows.Forms.TextBox();
            this.TuningControlPanel = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.WavelengthSet = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.WavelengthInput = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.HeaterLabelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KpColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KiColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AverageTempColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SetPointColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeaterStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Instrument.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Focus.SuspendLayout();
            this.Camera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.TuningControlBoardTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.HeaterData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompensatorDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeaterDataGrid)).BeginInit();
            this.TempControlBox.SuspendLayout();
            this.PIDSettingBox.SuspendLayout();
            this.HeaterRadioBox.SuspendLayout();
            this.PIDRadioBox.SuspendLayout();
            this.TuningControlPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Instrument
            // 
            this.Instrument.BackColor = System.Drawing.Color.Linen;
            this.Instrument.Controls.Add(this.label3);
            this.Instrument.Controls.Add(this.textBox2);
            this.Instrument.Controls.Add(this.textBox1);
            this.Instrument.Controls.Add(this.label2);
            this.Instrument.Controls.Add(this.label1);
            this.Instrument.Controls.Add(this.button1);
            this.Instrument.Controls.Add(this.pictureBox1);
            this.Instrument.Location = new System.Drawing.Point(4, 22);
            this.Instrument.Name = "Instrument";
            this.Instrument.Padding = new System.Windows.Forms.Padding(3);
            this.Instrument.Size = new System.Drawing.Size(949, 640);
            this.Instrument.TabIndex = 3;
            this.Instrument.Text = "Instrument";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(260, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "SavePath";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(260, 383);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(242, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.textBox1.Location = new System.Drawing.Point(23, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 43);
            this.textBox1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wavelength";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Current Image";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Capture Image";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(260, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 302);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Focus
            // 
            this.Focus.BackColor = System.Drawing.Color.LavenderBlush;
            this.Focus.Controls.Add(this.button4);
            this.Focus.Controls.Add(this.textBox3);
            this.Focus.Controls.Add(this.label7);
            this.Focus.Controls.Add(this.label6);
            this.Focus.Controls.Add(this.label5);
            this.Focus.Controls.Add(this.button3);
            this.Focus.Controls.Add(this.button2);
            this.Focus.Controls.Add(this.label4);
            this.Focus.Location = new System.Drawing.Point(4, 22);
            this.Focus.Name = "Focus";
            this.Focus.Padding = new System.Windows.Forms.Padding(3);
            this.Focus.Size = new System.Drawing.Size(949, 640);
            this.Focus.TabIndex = 2;
            this.Focus.Text = "Focus";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(125, 224);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(64, 20);
            this.button4.TabIndex = 7;
            this.button4.Text = "Goto";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(22, 224);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(86, 20);
            this.textBox3.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.label7.Location = new System.Drawing.Point(22, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 37);
            this.label7.TabIndex = 5;
            this.label7.Text = "Goto Position";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.label6.Location = new System.Drawing.Point(22, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 37);
            this.label6.TabIndex = 4;
            this.label6.Text = "Current Position";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.label5.Location = new System.Drawing.Point(327, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 37);
            this.label5.TabIndex = 3;
            this.label5.Text = "Jog";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.button3.Location = new System.Drawing.Point(327, 224);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 99);
            this.button3.TabIndex = 2;
            this.button3.Text = "backwards";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.button2.Location = new System.Drawing.Point(327, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 81);
            this.button2.TabIndex = 1;
            this.button2.Text = "forwards";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.label4.Location = new System.Drawing.Point(22, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 37);
            this.label4.TabIndex = 0;
            this.label4.Text = "Current Position";
            // 
            // Camera
            // 
            this.Camera.BackColor = System.Drawing.Color.SkyBlue;
            this.Camera.Controls.Add(this.textBox7);
            this.Camera.Controls.Add(this.textBox6);
            this.Camera.Controls.Add(this.textBox5);
            this.Camera.Controls.Add(this.textBox4);
            this.Camera.Controls.Add(this.label9);
            this.Camera.Controls.Add(this.label8);
            this.Camera.Controls.Add(this.pictureBox2);
            this.Camera.Location = new System.Drawing.Point(4, 22);
            this.Camera.Name = "Camera";
            this.Camera.Padding = new System.Windows.Forms.Padding(3);
            this.Camera.Size = new System.Drawing.Size(949, 640);
            this.Camera.TabIndex = 1;
            this.Camera.Text = "Camera";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(3, 376);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(86, 20);
            this.textBox7.TabIndex = 8;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(7, 269);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(86, 20);
            this.textBox6.TabIndex = 7;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(7, 156);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(86, 20);
            this.textBox5.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(7, 40);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(86, 20);
            this.textBox4.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(241, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Current Image";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Binning";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(241, 53);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(273, 302);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // TuningControlBoardTab
            // 
            this.TuningControlBoardTab.BackColor = System.Drawing.Color.PaleTurquoise;
            this.TuningControlBoardTab.Controls.Add(this.groupBox1);
            this.TuningControlBoardTab.Controls.Add(this.HeaterData);
            this.TuningControlBoardTab.Controls.Add(this.TempControlBox);
            this.TuningControlBoardTab.Controls.Add(this.TuningControlPanel);
            this.TuningControlBoardTab.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.TuningControlBoardTab.Location = new System.Drawing.Point(4, 22);
            this.TuningControlBoardTab.Name = "TuningControlBoardTab";
            this.TuningControlBoardTab.Padding = new System.Windows.Forms.Padding(3);
            this.TuningControlBoardTab.Size = new System.Drawing.Size(949, 640);
            this.TuningControlBoardTab.TabIndex = 0;
            this.TuningControlBoardTab.Text = "Tuning Control Board";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Azure;
            this.groupBox1.Controls.Add(this.RefreshCom);
            this.groupBox1.Controls.Add(this.PortSelector);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.ComStatus);
            this.groupBox1.Location = new System.Drawing.Point(473, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 192);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM ports";
            // 
            // RefreshCom
            // 
            this.RefreshCom.Location = new System.Drawing.Point(193, 90);
            this.RefreshCom.Name = "RefreshCom";
            this.RefreshCom.Size = new System.Drawing.Size(79, 38);
            this.RefreshCom.TabIndex = 12;
            this.RefreshCom.Text = "Refresh";
            this.RefreshCom.UseVisualStyleBackColor = true;
            this.RefreshCom.Click += new System.EventHandler(this.RefreshCom_Click);
            // 
            // PortSelector
            // 
            this.PortSelector.FormattingEnabled = true;
            this.PortSelector.Location = new System.Drawing.Point(8, 19);
            this.PortSelector.Name = "PortSelector";
            this.PortSelector.Size = new System.Drawing.Size(264, 21);
            this.PortSelector.TabIndex = 8;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(193, 46);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(79, 38);
            this.button9.TabIndex = 10;
            this.button9.Text = "Connect";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // ComStatus
            // 
            this.ComStatus.AutoSize = true;
            this.ComStatus.Location = new System.Drawing.Point(5, 62);
            this.ComStatus.Name = "ComStatus";
            this.ComStatus.Size = new System.Drawing.Size(123, 13);
            this.ComStatus.TabIndex = 11;
            this.ComStatus.Text = "Status: Not Connected";
            // 
            // HeaterData
            // 
            this.HeaterData.BackColor = System.Drawing.Color.Azure;
            this.HeaterData.Controls.Add(this.CompensatorDataGrid);
            this.HeaterData.Controls.Add(this.HeaterDataGrid);
            this.HeaterData.Location = new System.Drawing.Point(7, 338);
            this.HeaterData.Name = "HeaterData";
            this.HeaterData.Size = new System.Drawing.Size(750, 296);
            this.HeaterData.TabIndex = 7;
            this.HeaterData.TabStop = false;
            this.HeaterData.Text = "House Keeping";
            // 
            // CompensatorDataGrid
            // 
            this.CompensatorDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CompensatorDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StageLabelCol,
            this.WavelengthCol,
            this.VoltageCol,
            this.StageSizeCol,
            this.TuningCol});
            this.CompensatorDataGrid.Location = new System.Drawing.Point(5, 160);
            this.CompensatorDataGrid.Name = "CompensatorDataGrid";
            this.CompensatorDataGrid.RowTemplate.Height = 25;
            this.CompensatorDataGrid.Size = new System.Drawing.Size(545, 130);
            this.CompensatorDataGrid.TabIndex = 1;
            // 
            // StageLabelCol
            // 
            this.StageLabelCol.HeaderText = "Stage Label";
            this.StageLabelCol.Name = "StageLabelCol";
            // 
            // WavelengthCol
            // 
            this.WavelengthCol.HeaderText = "Wavelength (nm)";
            this.WavelengthCol.Name = "WavelengthCol";
            // 
            // VoltageCol
            // 
            this.VoltageCol.HeaderText = "Voltage (V)";
            this.VoltageCol.Name = "VoltageCol";
            // 
            // StageSizeCol
            // 
            this.StageSizeCol.HeaderText = "Stage Size (mm)";
            this.StageSizeCol.Name = "StageSizeCol";
            // 
            // TuningCol
            // 
            this.TuningCol.HeaderText = "Tuning";
            this.TuningCol.Name = "TuningCol";
            // 
            // HeaterDataGrid
            // 
            this.HeaterDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HeaterDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HeaterLabelColumn,
            this.KpColumn,
            this.KiColumn,
            this.KdColumn,
            this.AverageTempColumn,
            this.SetPointColumn,
            this.HeaterStatusColumn});
            this.HeaterDataGrid.Location = new System.Drawing.Point(5, 18);
            this.HeaterDataGrid.Name = "HeaterDataGrid";
            this.HeaterDataGrid.RowTemplate.Height = 25;
            this.HeaterDataGrid.Size = new System.Drawing.Size(733, 136);
            this.HeaterDataGrid.TabIndex = 0;
            // 
            // TempControlBox
            // 
            this.TempControlBox.BackColor = System.Drawing.Color.Azure;
            this.TempControlBox.Controls.Add(this.button6);
            this.TempControlBox.Controls.Add(this.TempSetButton);
            this.TempControlBox.Controls.Add(this.PIDSettingBox);
            this.TempControlBox.Controls.Add(this.label12);
            this.TempControlBox.Controls.Add(this.TempSetBox);
            this.TempControlBox.Location = new System.Drawing.Point(231, 5);
            this.TempControlBox.Name = "TempControlBox";
            this.TempControlBox.Size = new System.Drawing.Size(237, 328);
            this.TempControlBox.TabIndex = 6;
            this.TempControlBox.TabStop = false;
            this.TempControlBox.Text = "Temperature Control";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(10, 68);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(84, 25);
            this.button6.TabIndex = 13;
            this.button6.Text = "Heater On";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // TempSetButton
            // 
            this.TempSetButton.Location = new System.Drawing.Point(99, 38);
            this.TempSetButton.Name = "TempSetButton";
            this.TempSetButton.Size = new System.Drawing.Size(84, 25);
            this.TempSetButton.TabIndex = 11;
            this.TempSetButton.Text = "Set";
            this.TempSetButton.UseVisualStyleBackColor = true;
            this.TempSetButton.Click += new System.EventHandler(this.TempSetButton_Click);
            // 
            // PIDSettingBox
            // 
            this.PIDSettingBox.Controls.Add(this.label10);
            this.PIDSettingBox.Controls.Add(this.PIDSetButton);
            this.PIDSettingBox.Controls.Add(this.label13);
            this.PIDSettingBox.Controls.Add(this.PIDSetField);
            this.PIDSettingBox.Controls.Add(this.HeaterRadioBox);
            this.PIDSettingBox.Controls.Add(this.PIDRadioBox);
            this.PIDSettingBox.Location = new System.Drawing.Point(5, 122);
            this.PIDSettingBox.Name = "PIDSettingBox";
            this.PIDSettingBox.Size = new System.Drawing.Size(225, 200);
            this.PIDSettingBox.TabIndex = 4;
            this.PIDSettingBox.TabStop = false;
            this.PIDSettingBox.Text = "PID Settings";
            // 
            // label10
            // 
            this.label10.AllowDrop = true;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 11;
            // 
            // PIDSetButton
            // 
            this.PIDSetButton.Location = new System.Drawing.Point(99, 159);
            this.PIDSetButton.Name = "PIDSetButton";
            this.PIDSetButton.Size = new System.Drawing.Size(84, 25);
            this.PIDSetButton.TabIndex = 10;
            this.PIDSetButton.Text = "Set";
            this.PIDSetButton.UseVisualStyleBackColor = true;
            this.PIDSetButton.Click += new System.EventHandler(this.PIDSetButton_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(0, 143);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Value";
            // 
            // PIDSetField
            // 
            this.PIDSetField.Location = new System.Drawing.Point(4, 159);
            this.PIDSetField.Name = "PIDSetField";
            this.PIDSetField.Size = new System.Drawing.Size(86, 22);
            this.PIDSetField.TabIndex = 8;
            // 
            // HeaterRadioBox
            // 
            this.HeaterRadioBox.Controls.Add(this.Heater3checkBox);
            this.HeaterRadioBox.Controls.Add(this.Heater2checkBox);
            this.HeaterRadioBox.Controls.Add(this.Heater1checkBox);
            this.HeaterRadioBox.Location = new System.Drawing.Point(123, 24);
            this.HeaterRadioBox.Name = "HeaterRadioBox";
            this.HeaterRadioBox.Size = new System.Drawing.Size(92, 112);
            this.HeaterRadioBox.TabIndex = 7;
            this.HeaterRadioBox.TabStop = false;
            this.HeaterRadioBox.Text = "Heater Zones";
            // 
            // Heater3checkBox
            // 
            this.Heater3checkBox.AutoSize = true;
            this.Heater3checkBox.Location = new System.Drawing.Point(6, 78);
            this.Heater3checkBox.Name = "Heater3checkBox";
            this.Heater3checkBox.Size = new System.Drawing.Size(40, 17);
            this.Heater3checkBox.TabIndex = 2;
            this.Heater3checkBox.Text = "H3";
            this.Heater3checkBox.UseVisualStyleBackColor = true;
            // 
            // Heater2checkBox
            // 
            this.Heater2checkBox.AutoSize = true;
            this.Heater2checkBox.Location = new System.Drawing.Point(6, 51);
            this.Heater2checkBox.Name = "Heater2checkBox";
            this.Heater2checkBox.Size = new System.Drawing.Size(40, 17);
            this.Heater2checkBox.TabIndex = 1;
            this.Heater2checkBox.Text = "H2";
            this.Heater2checkBox.UseVisualStyleBackColor = true;
            // 
            // Heater1checkBox
            // 
            this.Heater1checkBox.AutoSize = true;
            this.Heater1checkBox.Location = new System.Drawing.Point(6, 24);
            this.Heater1checkBox.Name = "Heater1checkBox";
            this.Heater1checkBox.Size = new System.Drawing.Size(40, 17);
            this.Heater1checkBox.TabIndex = 0;
            this.Heater1checkBox.Text = "H1";
            this.Heater1checkBox.UseVisualStyleBackColor = true;
            // 
            // PIDRadioBox
            // 
            this.PIDRadioBox.Controls.Add(this.ProportionalRadio);
            this.PIDRadioBox.Controls.Add(this.DerivativeRadio);
            this.PIDRadioBox.Controls.Add(this.IntegralRadio);
            this.PIDRadioBox.Location = new System.Drawing.Point(5, 24);
            this.PIDRadioBox.Name = "PIDRadioBox";
            this.PIDRadioBox.Size = new System.Drawing.Size(113, 112);
            this.PIDRadioBox.TabIndex = 6;
            this.PIDRadioBox.TabStop = false;
            this.PIDRadioBox.Text = "Terms";
            // 
            // ProportionalRadio
            // 
            this.ProportionalRadio.AutoSize = true;
            this.ProportionalRadio.Location = new System.Drawing.Point(5, 24);
            this.ProportionalRadio.Name = "ProportionalRadio";
            this.ProportionalRadio.Size = new System.Drawing.Size(90, 17);
            this.ProportionalRadio.TabIndex = 3;
            this.ProportionalRadio.TabStop = true;
            this.ProportionalRadio.Text = "Proportional";
            this.ProportionalRadio.UseVisualStyleBackColor = true;
            // 
            // DerivativeRadio
            // 
            this.DerivativeRadio.AutoSize = true;
            this.DerivativeRadio.Location = new System.Drawing.Point(5, 78);
            this.DerivativeRadio.Name = "DerivativeRadio";
            this.DerivativeRadio.Size = new System.Drawing.Size(75, 17);
            this.DerivativeRadio.TabIndex = 5;
            this.DerivativeRadio.TabStop = true;
            this.DerivativeRadio.Text = "Derivative";
            this.DerivativeRadio.UseVisualStyleBackColor = true;
            // 
            // IntegralRadio
            // 
            this.IntegralRadio.AutoSize = true;
            this.IntegralRadio.Location = new System.Drawing.Point(5, 51);
            this.IntegralRadio.Name = "IntegralRadio";
            this.IntegralRadio.Size = new System.Drawing.Size(65, 17);
            this.IntegralRadio.TabIndex = 4;
            this.IntegralRadio.TabStop = true;
            this.IntegralRadio.Text = "Integral";
            this.IntegralRadio.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Temperature Setpoint (C)";
            // 
            // TempSetBox
            // 
            this.TempSetBox.Location = new System.Drawing.Point(9, 42);
            this.TempSetBox.Name = "TempSetBox";
            this.TempSetBox.Size = new System.Drawing.Size(86, 22);
            this.TempSetBox.TabIndex = 0;
            // 
            // TuningControlPanel
            // 
            this.TuningControlPanel.BackColor = System.Drawing.Color.Azure;
            this.TuningControlPanel.Controls.Add(this.button8);
            this.TuningControlPanel.Controls.Add(this.WavelengthSet);
            this.TuningControlPanel.Controls.Add(this.label11);
            this.TuningControlPanel.Controls.Add(this.WavelengthInput);
            this.TuningControlPanel.Location = new System.Drawing.Point(7, 5);
            this.TuningControlPanel.Name = "TuningControlPanel";
            this.TuningControlPanel.Size = new System.Drawing.Size(219, 111);
            this.TuningControlPanel.TabIndex = 5;
            this.TuningControlPanel.TabStop = false;
            this.TuningControlPanel.Text = "Wavelength Tuning";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(5, 68);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(126, 25);
            this.button8.TabIndex = 8;
            this.button8.Text = "Tuning On";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // WavelengthSet
            // 
            this.WavelengthSet.Location = new System.Drawing.Point(123, 38);
            this.WavelengthSet.Name = "WavelengthSet";
            this.WavelengthSet.Size = new System.Drawing.Size(75, 25);
            this.WavelengthSet.TabIndex = 7;
            this.WavelengthSet.Text = "Set";
            this.WavelengthSet.UseVisualStyleBackColor = true;
            this.WavelengthSet.Click += new System.EventHandler(this.WavelengthSet_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Wavelength (nm)";
            // 
            // WavelengthInput
            // 
            this.WavelengthInput.Location = new System.Drawing.Point(5, 42);
            this.WavelengthInput.Name = "WavelengthInput";
            this.WavelengthInput.Size = new System.Drawing.Size(113, 22);
            this.WavelengthInput.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TuningControlBoardTab);
            this.tabControl1.Controls.Add(this.Camera);
            this.tabControl1.Controls.Add(this.Focus);
            this.tabControl1.Controls.Add(this.Instrument);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(957, 666);
            this.tabControl1.TabIndex = 0;
            // 
            // HeaterLabelColumn
            // 
            this.HeaterLabelColumn.HeaderText = "Heater Zone";
            this.HeaterLabelColumn.Name = "HeaterLabelColumn";
            // 
            // KpColumn
            // 
            this.KpColumn.HeaderText = "Kp";
            this.KpColumn.Name = "KpColumn";
            // 
            // KiColumn
            // 
            this.KiColumn.HeaderText = "Ki";
            this.KiColumn.Name = "KiColumn";
            // 
            // KdColumn
            // 
            this.KdColumn.HeaderText = "Kd";
            this.KdColumn.Name = "KdColumn";
            // 
            // AverageTempColumn
            // 
            this.AverageTempColumn.HeaderText = "AvgTemp 2 Sec (C)";
            this.AverageTempColumn.Name = "AverageTempColumn";
            // 
            // SetPointColumn
            // 
            this.SetPointColumn.HeaderText = "Set Point (C)";
            this.SetPointColumn.Name = "SetPointColumn";
            // 
            // HeaterStatusColumn
            // 
            this.HeaterStatusColumn.HeaderText = "HeaterStatus";
            this.HeaterStatusColumn.Name = "HeaterStatusColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 665);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Lyot Filter Demonstration Instrument Control Panel";
            this.Instrument.ResumeLayout(false);
            this.Instrument.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Focus.ResumeLayout(false);
            this.Focus.PerformLayout();
            this.Camera.ResumeLayout(false);
            this.Camera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.TuningControlBoardTab.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.HeaterData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CompensatorDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeaterDataGrid)).EndInit();
            this.TempControlBox.ResumeLayout(false);
            this.TempControlBox.PerformLayout();
            this.PIDSettingBox.ResumeLayout(false);
            this.PIDSettingBox.PerformLayout();
            this.HeaterRadioBox.ResumeLayout(false);
            this.HeaterRadioBox.PerformLayout();
            this.PIDRadioBox.ResumeLayout(false);
            this.PIDRadioBox.PerformLayout();
            this.TuningControlPanel.ResumeLayout(false);
            this.TuningControlPanel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private new System.Windows.Forms.TabPage Focus;
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
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView HeaterDataGrid;
        private System.Windows.Forms.DataGridView CompensatorDataGrid;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox Heater3checkBox;
        private System.Windows.Forms.CheckBox Heater2checkBox;
        private System.Windows.Forms.CheckBox Heater1checkBox;
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
