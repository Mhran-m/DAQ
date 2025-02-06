namespace SensorApplication
{
    partial class DAQSimulator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DAQSimulator));
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNextSamplingTime = new System.Windows.Forms.TextBox();
            this.btnGetSampling = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStopSampling = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLoggingOnFile = new System.Windows.Forms.Button();
            this.txtNextLoggingTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEntriesCount = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.sensorValues = new System.Windows.Forms.Label();
            this.txtSensorNames = new System.Windows.Forms.Label();
            this.txtAnalogSensor = new System.Windows.Forms.Label();
            this.txtDigitalSensor = new System.Windows.Forms.Label();
            this.numAnalogSensorDevices = new System.Windows.Forms.Label();
            this.numDigitalSensorDevices = new System.Windows.Forms.Label();
            this.txtDAQvoltage = new System.Windows.Forms.Label();
            this.numLowerVoltage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numUpperVoltage = new System.Windows.Forms.Label();
            this.txtDAQResolution = new System.Windows.Forms.Label();
            this.numDAQResolution = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(917, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Next Sampling Time (Sec)";
            // 
            // txtNextSamplingTime
            // 
            this.txtNextSamplingTime.Location = new System.Drawing.Point(188, 33);
            this.txtNextSamplingTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtNextSamplingTime.Name = "txtNextSamplingTime";
            this.txtNextSamplingTime.Size = new System.Drawing.Size(69, 22);
            this.txtNextSamplingTime.TabIndex = 2;
            this.txtNextSamplingTime.Tag = "";
            this.txtNextSamplingTime.Text = "1.6";
            this.txtNextSamplingTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGetSampling
            // 
            this.btnGetSampling.Location = new System.Drawing.Point(48, 79);
            this.btnGetSampling.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetSampling.Name = "btnGetSampling";
            this.btnGetSampling.Size = new System.Drawing.Size(84, 47);
            this.btnGetSampling.TabIndex = 3;
            this.btnGetSampling.Text = "Start Sampling";
            this.btnGetSampling.UseVisualStyleBackColor = true;
            this.btnGetSampling.Click += new System.EventHandler(this.btnGetSampling_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnStopSampling);
            this.groupBox1.Controls.Add(this.btnGetSampling);
            this.groupBox1.Controls.Add(this.txtNextSamplingTime);
            this.groupBox1.Location = new System.Drawing.Point(598, 49);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(299, 146);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sampling";
            // 
            // btnStopSampling
            // 
            this.btnStopSampling.Location = new System.Drawing.Point(208, 79);
            this.btnStopSampling.Margin = new System.Windows.Forms.Padding(4);
            this.btnStopSampling.Name = "btnStopSampling";
            this.btnStopSampling.Size = new System.Drawing.Size(84, 47);
            this.btnStopSampling.TabIndex = 3;
            this.btnStopSampling.Text = "Stop Sampling";
            this.btnStopSampling.UseVisualStyleBackColor = true;
            this.btnStopSampling.Click += new System.EventHandler(this.btnStopSampling_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.btnLoggingOnFile);
            this.groupBox2.Controls.Add(this.txtNextLoggingTime);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtEntriesCount);
            this.groupBox2.Controls.Add(this.txtFileName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(598, 550);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(299, 157);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Logging";
            // 
            // btnLoggingOnFile
            // 
            this.btnLoggingOnFile.Location = new System.Drawing.Point(151, 90);
            this.btnLoggingOnFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoggingOnFile.Name = "btnLoggingOnFile";
            this.btnLoggingOnFile.Size = new System.Drawing.Size(123, 28);
            this.btnLoggingOnFile.TabIndex = 2;
            this.btnLoggingOnFile.Text = "Logging on File";
            this.btnLoggingOnFile.UseVisualStyleBackColor = true;
            this.btnLoggingOnFile.Click += new System.EventHandler(this.LoggingOnFile_Click);
            // 
            // txtNextLoggingTime
            // 
            this.txtNextLoggingTime.Location = new System.Drawing.Point(188, 32);
            this.txtNextLoggingTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtNextLoggingTime.Name = "txtNextLoggingTime";
            this.txtNextLoggingTime.Size = new System.Drawing.Size(69, 22);
            this.txtNextLoggingTime.TabIndex = 1;
            this.txtNextLoggingTime.Tag = "";
            this.txtNextLoggingTime.Text = "21";
            this.txtNextLoggingTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 122);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Entry count";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEntriesCount
            // 
            this.txtEntriesCount.AutoSize = true;
            this.txtEntriesCount.Location = new System.Drawing.Point(118, 122);
            this.txtEntriesCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtEntriesCount.Name = "txtEntriesCount";
            this.txtEntriesCount.Size = new System.Drawing.Size(14, 16);
            this.txtEntriesCount.TabIndex = 0;
            this.txtEntriesCount.Text = "0";
            this.txtEntriesCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFileName
            // 
            this.txtFileName.AutoSize = true;
            this.txtFileName.Location = new System.Drawing.Point(38, 96);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(94, 16);
            this.txtFileName.TabIndex = 0;
            this.txtFileName.Text = "No file created";
            this.txtFileName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Next Logging Time (Sec)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.sensorValues);
            this.groupBox3.Controls.Add(this.txtSensorNames);
            this.groupBox3.Location = new System.Drawing.Point(0, 203);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(356, 504);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sensor Values";
            // 
            // sensorValues
            // 
            this.sensorValues.AutoSize = true;
            this.sensorValues.Location = new System.Drawing.Point(193, 62);
            this.sensorValues.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sensorValues.Name = "sensorValues";
            this.sensorValues.Size = new System.Drawing.Size(91, 16);
            this.sensorValues.TabIndex = 17;
            this.sensorValues.Text = "sensor values";
            // 
            // txtSensorNames
            // 
            this.txtSensorNames.AutoSize = true;
            this.txtSensorNames.Location = new System.Drawing.Point(32, 62);
            this.txtSensorNames.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtSensorNames.Name = "txtSensorNames";
            this.txtSensorNames.Size = new System.Drawing.Size(57, 16);
            this.txtSensorNames.TabIndex = 17;
            this.txtSensorNames.Text = "Sensors";
            // 
            // txtAnalogSensor
            // 
            this.txtAnalogSensor.AutoSize = true;
            this.txtAnalogSensor.Location = new System.Drawing.Point(20, 37);
            this.txtAnalogSensor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtAnalogSensor.Name = "txtAnalogSensor";
            this.txtAnalogSensor.Size = new System.Drawing.Size(149, 16);
            this.txtAnalogSensor.TabIndex = 7;
            this.txtAnalogSensor.Text = "Analog Sensor Devices";
            // 
            // txtDigitalSensor
            // 
            this.txtDigitalSensor.AutoSize = true;
            this.txtDigitalSensor.Location = new System.Drawing.Point(20, 62);
            this.txtDigitalSensor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtDigitalSensor.Name = "txtDigitalSensor";
            this.txtDigitalSensor.Size = new System.Drawing.Size(144, 16);
            this.txtDigitalSensor.TabIndex = 8;
            this.txtDigitalSensor.Text = "Digital Sensor Devices";
            // 
            // numAnalogSensorDevices
            // 
            this.numAnalogSensorDevices.AutoSize = true;
            this.numAnalogSensorDevices.Location = new System.Drawing.Point(207, 37);
            this.numAnalogSensorDevices.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numAnalogSensorDevices.Name = "numAnalogSensorDevices";
            this.numAnalogSensorDevices.Size = new System.Drawing.Size(51, 16);
            this.numAnalogSensorDevices.TabIndex = 9;
            this.numAnalogSensorDevices.Text = "amount";
            // 
            // numDigitalSensorDevices
            // 
            this.numDigitalSensorDevices.AutoSize = true;
            this.numDigitalSensorDevices.Location = new System.Drawing.Point(207, 62);
            this.numDigitalSensorDevices.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numDigitalSensorDevices.Name = "numDigitalSensorDevices";
            this.numDigitalSensorDevices.Size = new System.Drawing.Size(51, 16);
            this.numDigitalSensorDevices.TabIndex = 10;
            this.numDigitalSensorDevices.Text = "amount";
            // 
            // txtDAQvoltage
            // 
            this.txtDAQvoltage.AutoSize = true;
            this.txtDAQvoltage.Location = new System.Drawing.Point(20, 89);
            this.txtDAQvoltage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtDAQvoltage.Name = "txtDAQvoltage";
            this.txtDAQvoltage.Size = new System.Drawing.Size(117, 16);
            this.txtDAQvoltage.TabIndex = 11;
            this.txtDAQvoltage.Text = "DAQ Input Voltage";
            // 
            // numLowerVoltage
            // 
            this.numLowerVoltage.AutoSize = true;
            this.numLowerVoltage.Location = new System.Drawing.Point(168, 89);
            this.numLowerVoltage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numLowerVoltage.Name = "numLowerVoltage";
            this.numLowerVoltage.Size = new System.Drawing.Size(25, 16);
            this.numLowerVoltage.TabIndex = 12;
            this.numLowerVoltage.Text = "val";
            this.numLowerVoltage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "to";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "V";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "V";
            // 
            // numUpperVoltage
            // 
            this.numUpperVoltage.AutoSize = true;
            this.numUpperVoltage.Location = new System.Drawing.Point(219, 89);
            this.numUpperVoltage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numUpperVoltage.Name = "numUpperVoltage";
            this.numUpperVoltage.Size = new System.Drawing.Size(25, 16);
            this.numUpperVoltage.TabIndex = 14;
            this.numUpperVoltage.Text = "val";
            this.numUpperVoltage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDAQResolution
            // 
            this.txtDAQResolution.AutoSize = true;
            this.txtDAQResolution.Location = new System.Drawing.Point(20, 116);
            this.txtDAQResolution.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtDAQResolution.Name = "txtDAQResolution";
            this.txtDAQResolution.Size = new System.Drawing.Size(135, 16);
            this.txtDAQResolution.TabIndex = 15;
            this.txtDAQResolution.Text = "DAQ Resolution (bits)";
            // 
            // numDAQResolution
            // 
            this.numDAQResolution.AutoSize = true;
            this.numDAQResolution.Location = new System.Drawing.Point(172, 116);
            this.numDAQResolution.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numDAQResolution.Name = "numDAQResolution";
            this.numDAQResolution.Size = new System.Drawing.Size(40, 16);
            this.numDAQResolution.TabIndex = 16;
            this.numDAQResolution.Text = "value";
            this.numDAQResolution.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.numDAQResolution);
            this.groupBox4.Controls.Add(this.txtDAQResolution);
            this.groupBox4.Controls.Add(this.numUpperVoltage);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.numLowerVoltage);
            this.groupBox4.Controls.Add(this.txtDAQvoltage);
            this.groupBox4.Controls.Add(this.numDigitalSensorDevices);
            this.groupBox4.Controls.Add(this.numAnalogSensorDevices);
            this.groupBox4.Controls.Add(this.txtDigitalSensor);
            this.groupBox4.Controls.Add(this.txtAnalogSensor);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox4.Location = new System.Drawing.Point(0, 49);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(299, 146);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Informations";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // DAQSimulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(917, 792);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DAQSimulator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DAQSimulator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetSampling;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLoggingOnFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Label txtSensorNames;
        public System.Windows.Forms.Label sensorValues;
        public System.Windows.Forms.TextBox txtNextSamplingTime;
        private System.Windows.Forms.Button btnStopSampling;
        public System.Windows.Forms.TextBox txtNextLoggingTime;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label txtFileName;
        private System.Windows.Forms.Label txtEntriesCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtAnalogSensor;
        private System.Windows.Forms.Label txtDigitalSensor;
        public System.Windows.Forms.Label numAnalogSensorDevices;
        public System.Windows.Forms.Label numDigitalSensorDevices;
        private System.Windows.Forms.Label txtDAQvoltage;
        public System.Windows.Forms.Label numLowerVoltage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label numUpperVoltage;
        private System.Windows.Forms.Label txtDAQResolution;
        public System.Windows.Forms.Label numDAQResolution;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}