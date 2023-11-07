using InstrumentsInterface;
using Moq;

public class MeasurementControlTests
{
    [Fact]
    public void GetVoltageMeasurement_ReturnsExpectedValue()
    {
        // Arrange
        var voltageValue = 10.0;
        var mockVoltageMeasurable = new Mock<IVoltageMeasurable>();
        mockVoltageMeasurable.Setup(vm => vm.MeasureVoltage()).Returns(voltageValue);

        var mockTemperatureMeasurable = new Mock<ITemperatureMeasurable>();

        var measurementControl = new MeasurementControl(mockVoltageMeasurable.Object, mockTemperatureMeasurable.Object);

        // Act
        var result = measurementControl.GetVoltageMeasurement();

        // Assert
        Assert.Equal(voltageValue, result);
    }

    [Theory]
    [InlineData(10.0)]
    [InlineData(5.5)]
    [InlineData(0.0)]
    public void GetVoltageMeasurement_WithDifferentMockedVoltages_ReturnsExpectedValues(double expectedVoltage)
    {
        // Arrange
        var mockVoltageMeasurable = new Mock<IVoltageMeasurable>();
        mockVoltageMeasurable.Setup(vm => vm.MeasureVoltage()).Returns(expectedVoltage);

        var mockTemperatureMeasurable = new Mock<ITemperatureMeasurable>();

        var measurementControl = new MeasurementControl(mockVoltageMeasurable.Object, mockTemperatureMeasurable.Object);

        // Act
        var actualVoltage = measurementControl.GetVoltageMeasurement();

        // Assert
        Assert.Equal(expectedVoltage, actualVoltage);
    }

    [Fact]
    public void GetTemperatureMeasurement_ReturnsExpectedValue()
    {
        // Arrange
        var temperatureValue = 25.0;
        var mockTemperatureMeasurable = new Mock<ITemperatureMeasurable>();
        mockTemperatureMeasurable.Setup(tm => tm.MeasureTemperature()).Returns(temperatureValue);

        var mockVoltageMeasurable = new Mock<IVoltageMeasurable>();

        var measurementControl = new MeasurementControl(mockVoltageMeasurable.Object, mockTemperatureMeasurable.Object);

        // Act
        var result = measurementControl.GetTemperatureMeasurement();

        // Assert
        Assert.Equal(temperatureValue, result);
    }
}