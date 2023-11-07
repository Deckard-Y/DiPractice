using InstrumentsInterface;

namespace DiPractice
{
    public static class Program
    {
        private static void Main(string[] args)
        {
        }
    }
}

public class MeasurementControl
{
    private IVoltageMeasurable _voltageMeasurable;
    private ITemperatureMeasurable _temperatureMeasurable;

    public MeasurementControl(IVoltageMeasurable voltageMeasurable, ITemperatureMeasurable temperatureMeasurable)
    {
        _voltageMeasurable = voltageMeasurable;
        _temperatureMeasurable = temperatureMeasurable;
    }

    public double GetVoltageMeasurement()
    {
        return _voltageMeasurable.MeasureVoltage();
    }

    public double GetTemperatureMeasurement()
    {
        return _temperatureMeasurable.MeasureTemperature();
    }
}