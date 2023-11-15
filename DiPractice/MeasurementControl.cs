using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DiPractice;

public class MeasurementControl
{
    private IVoltageMeasurable _voltageMeasurable;
    private ITemperatureMeasurable _temperatureMeasurable;

    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="voltageMeasurable"></param>
    /// <param name="temperatureMeasurable"></param>
    public MeasurementControl(IVoltageMeasurable voltageMeasurable, ITemperatureMeasurable temperatureMeasurable)
    {
        _voltageMeasurable = voltageMeasurable;
        _temperatureMeasurable = temperatureMeasurable;
    }

    /// <summary>
    /// 電圧を測定する
    /// </summary>
    /// <returns>電圧値</returns>
    public double GetVoltageMeasurement()
    {
        return _voltageMeasurable.MeasureVoltage();
    }

    /// <summary>
    /// 温度を測定する
    /// </summary>
    /// <returns>温度値</returns>
    public double GetTemperatureMeasurement()
    {
        return _temperatureMeasurable.MeasureTemperature();
    }
}