using System;
using System.Globalization;
using System.Windows.Forms;

namespace SensorApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string analogS;
        string digitalS;

        public void runLoop(int analogSCount, int digitalSCount)
        {
            for (int i = 0; i < analogSCount; i++)
            {
                analogS = analogS + "Analog Sensor " + (i + 1) + "\n\n";
            } 
            
            for (int i = 0; i < digitalSCount; i++)
            {
                digitalS = digitalS + "Digital Sensor " + (i + 1) + "\n\n";
            }
            dAQSimulator.txtSensorNames.Text = analogS + "\n\n" + digitalS;
        }

        public Form1(DAQSimulator fr)
        {
            InitializeComponent();
            dAQSimulator = fr;
        }

        DAQSimulator dAQSimulator = new DAQSimulator();

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAnalogSensorDevices.Text) & !string.IsNullOrEmpty(txtDigitalSensorDevices.Text) & !string.IsNullOrEmpty(txtLowerVoltage.Text) & !string.IsNullOrEmpty(txtUpperVoltage.Text) & !string.IsNullOrEmpty(txtDAQResolution.Text))
            {
                dAQSimulator.numAnalogSensorDevices.Text = txtAnalogSensorDevices.Text;
                dAQSimulator.numDigitalSensorDevices.Text = txtDigitalSensorDevices.Text;
                dAQSimulator.numLowerVoltage.Text = txtLowerVoltage.Text;
                dAQSimulator.numUpperVoltage.Text = txtUpperVoltage.Text;
                dAQSimulator.numDAQResolution.Text = txtDAQResolution.Text;

                //Generate sensor names string

                int analogSensorCount = int.Parse(txtAnalogSensorDevices.Text, CultureInfo.InvariantCulture);
                int digitalSensorCount = int.Parse(txtDigitalSensorDevices.Text, CultureInfo.InvariantCulture);

                runLoop(analogSensorCount, digitalSensorCount);

                this.Hide();
                dAQSimulator.Closed += (s, args) => this.Close();
                dAQSimulator.Show();
            }
            else
            {
                // Make a message box if any of the text fields are empty
                MessageBox.Show("Please input text in all input fields", "Input Information", MessageBoxButtons.OK);
            }
        }
    }
}
