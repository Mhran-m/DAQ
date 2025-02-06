using System;
using System.Timers;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace SensorApplication
{
    public partial class DAQSimulator : Form
    {
        System.Timers.Timer timerSample;
        public DAQSimulator()
        {
            InitializeComponent();
            btnStopSampling.Enabled = false;
            btnLoggingOnFile.Enabled = false;
        }

        Random random = new Random();
        double loggingTime;
        double timeSpent = 0;
        string tempDataForLoggin;
        string tempDataForLogginReady;
        string DataForLogginReady;
        string LogginData;
        string path;
        int countLogeed;

        public string runLoopForSensorValue(string analogSvalue, string digitalSvalue, int analogSCount, int digitalSCount, int resolution, float lowerVol, float upperVol)
        {
            for (int i = 0; i < analogSCount; i++)
            {
                float x = (upperVol - lowerVol) / resolution;
                
                float num = random.Next(0, resolution + 1);
                analogSvalue= analogSvalue + (num * x + lowerVol).ToString("0.00") + "\n\n";
                tempDataForLoggin = tempDataForLoggin + (num * x + lowerVol).ToString("0.00") + ",";
            }

            for (int i = 0; i < digitalSCount; i++)
            {
                float x = (upperVol - lowerVol);
                int num = random.Next(2);
                digitalSvalue = digitalSvalue + (num * x + lowerVol).ToString("0.00") + "\n\n";
                tempDataForLoggin = tempDataForLoggin + (num * x + lowerVol).ToString("0.00") + ",";
            }
            tempDataForLogginReady = tempDataForLoggin;
            tempDataForLoggin = "";
            return analogSvalue + "\n\n" + digitalSvalue;
        }

        public void getSensorData() 
        {
            string analogSvalue = "";
            string digitalSvalue = "";
            //InvariantCulture need to be used to avoid confusion with . and ,
            int resolutionNum = int.Parse(numDAQResolution.Text, CultureInfo.InvariantCulture);
            float loweVoltageNum = float.Parse(numLowerVoltage.Text, CultureInfo.InvariantCulture);
            float upperVoltageNum = float.Parse(numUpperVoltage.Text, CultureInfo.InvariantCulture);
            int analogSensorCount = int.Parse(numAnalogSensorDevices.Text, CultureInfo.InvariantCulture);
            int digitalSensorCount = int.Parse(numDigitalSensorDevices.Text, CultureInfo.InvariantCulture);
            //Multithread error fixed using Invoke
            sensorValues.Invoke((MethodInvoker)(() => sensorValues.Text = runLoopForSensorValue(analogSvalue, digitalSvalue, analogSensorCount, digitalSensorCount, resolutionNum, loweVoltageNum, upperVoltageNum)));

        }

        private void btnGetSampling_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(txtNextSamplingTime.Text) & !String.IsNullOrEmpty(txtNextLoggingTime.Text))
            {
                btnGetSampling.Enabled = false;
                btnStopSampling.Enabled = true;
                timerSample = new System.Timers.Timer();
                timerSample.Interval = double.Parse(txtNextSamplingTime.Text, CultureInfo.InvariantCulture) * 1000;
                timerSample.Elapsed += OnTimeEvent;
                timerSample.Start();
                double loggingTime = double.Parse(txtNextLoggingTime.Text) * 1000;
            }

            else
            {
                // Make a message box if any of the text fields are empty
                MessageBox.Show("Please input text in all input fields", "Input Information", MessageBoxButtons.OK);
            }
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            timeSpent = timeSpent + double.Parse(txtNextSamplingTime.Text, CultureInfo.InvariantCulture) * 1000;
            getSensorData();
            loggingTime = double.Parse(txtNextLoggingTime.Text) * 1000;

            int previousValue = (int)Math.Round((timeSpent - double.Parse(txtNextSamplingTime.Text, CultureInfo.InvariantCulture) * 1000) / loggingTime);
            int newValue = (int)Math.Round(timeSpent / loggingTime);

            if (newValue > previousValue & tempDataForLogginReady != null)
            {
                btnLoggingOnFile.Invoke((MethodInvoker)(()=> btnLoggingOnFile.Enabled = true));
                String TodayTime = DateTime.Now.ToString("yyyy-MM-dd h:mm:ss tt"); //New Date format
                DataForLogginReady = TodayTime + "," + tempDataForLogginReady;
                if (LogginData != null)
                {
                    LogginData = LogginData + "\n" + DataForLogginReady;
                    countLogeed++;
                }
                else 
                {
                    LogginData = DataForLogginReady;
                    countLogeed++;
                }
            }
        }

        private void btnStopSampling_Click(object sender, EventArgs e)
        {
            btnStopSampling.Enabled = false;
            timerSample.Stop();
            btnGetSampling.Enabled = true;
        }

        private void LoggingOnFile_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNextSamplingTime.Text) & !String.IsNullOrEmpty(txtNextLoggingTime.Text))
            {
                loggingTime = double.Parse(txtNextLoggingTime.Text) * 1000;

                if (LogginData != null)
                {
                    //If path is not present, open dialog to choose file path
                    if (path == null)
                    {
                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        saveFileDialog.InitialDirectory = @"C:\Desktop";
                        saveFileDialog.Title = "Save your file, pick name and location";
                        saveFileDialog.DefaultExt = "csv";
                        saveFileDialog.Filter = "CSV file (*.csv)|*.csv| All Files (*.*)|*.*";
                        saveFileDialog.RestoreDirectory = true;
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            using (StreamWriter file = new StreamWriter(saveFileDialog.FileName, true))
                            {
                                path = Path.GetFullPath(saveFileDialog.FileName);
                                txtFileName.Text = Path.GetFileName(saveFileDialog.FileName);
                                file.WriteLine(LogginData);
                                txtEntriesCount.Text = countLogeed.ToString();
                                LogginData = null;
                                btnLoggingOnFile.Enabled = false;
                            }
                        }
                    }
                    else
                    {
                        //If file path is present, append new data
                        using (StreamWriter file = new StreamWriter(path, true))
                        {
                            file.WriteLine(LogginData);
                            txtEntriesCount.Text = countLogeed.ToString();
                            LogginData = null;
                            btnLoggingOnFile.Enabled = false;
                        }
                    }
                }
            }
            else
            {
                // Make a message box if any of the text fields are empty
                MessageBox.Show("Please input text in all input fields", "Input Information", MessageBoxButtons.OK);
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //When help clicked
            MessageBox.Show("Please input text in all input fields to sart sampling and logging process.\nSampling process is automatic once the start sampling button is pressed.\n\nTo stop sapling process once started, please press stop sampling button.\nLogging will be a manual process. At the first time you have to select the output csv file location.", "Help", MessageBoxButtons.OK);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //When about clicked
            MessageBox.Show("This is DAQ Simulation Application which is used for manually sampling and logging sensor values. \n\nThis generate sensor values randomly within defined limits to simulate sensor devices. Simulate collecting sensor values at sampling time and logging them on a csv file are performed by this application", "About", MessageBoxButtons.OK);
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
