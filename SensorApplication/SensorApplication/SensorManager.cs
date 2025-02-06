using System;

namespace SensorApplication
{
    public class SensorManager
    {
        private Random random = new Random();
        private string tempDataForLoggin;

        public string RunLoopForSensorValue(string analogSvalue, string digitalSvalue,
            int analogSCount, int digitalSCount, int resolution, float lowerVol, float upperVol)
        {
            for (int i = 0; i < analogSCount; i++)
            {
                float x = (upperVol - lowerVol) / resolution;
                float num = random.Next(0, resolution + 1);
                analogSvalue += (num * x + lowerVol).ToString("0.00") + "\n\n";
                tempDataForLoggin += (num * x + lowerVol).ToString("0.00") + ",";
            }

            for (int i = 0; i < digitalSCount; i++)
            {
                float x = (upperVol - lowerVol);
                int num = random.Next(2);
                digitalSvalue += (num * x + lowerVol).ToString("0.00") + "\n\n";
                tempDataForLoggin += (num * x + lowerVol).ToString("0.00") + ",";
            }

            string tempDataForLogginReady = tempDataForLoggin;
            tempDataForLoggin = "";
            return analogSvalue + "\n\n" + digitalSvalue;
        }
    }
}