using BrilinClock;

namespace TDD.Tests;

public class BerlinClockTests
{
    private BerlinClock _berlinClock;

    [SetUp]
    public void Setup()
    {
        _berlinClock = new BerlinClock();
    }

    [Test]
    public void GetSecondsLamp_ShouldReturnYellow_WhenSecondsAreEven()
    {
        // Arrange
        var seconds = 2;

        // Act
        var result = _berlinClock.GetSecondsLamp(seconds);

        // Assert
        Assert.That(result, Is.EqualTo("Y"));
    }

    [Test]
    public void GetSecondsLamp_ShouldReturnOff_WhenSecondsAreOdd()
    {
        // Arrange
        var seconds = 1;

        // Act
        var result = _berlinClock.GetSecondsLamp(seconds);

        // Assert
        Assert.That(result, Is.EqualTo("O"));
    }
}
