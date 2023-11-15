using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiPractice
{
    public class InstrumentA : ITemperatureMeasurable, IHumidityMeasurable, IVoltageMeasurable, IVibrationMeasurable
    {
        public double MeasureHumidity()
        {
            return SendHumidity();
        }

        public double MeasureTemperature()
        {
            return SendTemperature();
        }

        public double MeasureVibration()
        {
            return SendVibration();
        }

        public double MeasureVoltage()
        {
            return SendVoltage();
        }

        private double SendHumidity()
        {
            //ここでは固定値を返します
            return 1.0;
        }
        private double SendTemperature()
        {
            //ここでは固定値を返します
            return 5.0;
        }

        private double SendVibration()
        {
            //ここでは固定値を返します
            return 10.0;
        }

        private double SendVoltage()
        {
            //ここでは固定値を返します
            return 100.0;
        }
    }
}