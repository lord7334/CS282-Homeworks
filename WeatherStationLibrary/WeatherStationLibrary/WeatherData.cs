using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStationLibrary
{
    public class WeatherData
    {
        private double temperature;
        private double humidity;
        public double Pressure;

        public double Temperature
        {
            get
            {
                return this.temperature;
            }

            set
            {
                if (value > 40)
                {
                    this.temperature = 40;
                }
                else if (value < -10)
                {
                    this.temperature = -10;
                }
                else
                {
                    this.temperature = value;
                }
            }
        }

        public double Humidity
        {
            get => humidity;
            set => humidity = value;
        }

        public void SetTemperature(double value)
        {
            if (value > 40)
            {
                this.temperature = 40;
            }
            else if (value < -10)
            {
                this.temperature = -10;
            }
            else
            {
                this.temperature = value;
            }
        }

        public double GetTemperature()
        {
            return this.temperature;
        }

        public bool Equals(WeatherData other)
        {
            return this.Temperature == other.Temperature
                   && this.Humidity == other.Humidity
                   && this.Pressure == other.Pressure;
        }
    }
}