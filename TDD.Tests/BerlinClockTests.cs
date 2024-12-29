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

    [Test]
    public void GetHoursRow1_ShouldReturnCorrectRepresentation()
    {
        // Arrange
        var hours1 = 0;
        var hours2 = 10;
        var hours3 = 23;

        // Act
        var result1 = _berlinClock.GetHoursRow1(hours1);
        var result2 = _berlinClock.GetHoursRow1(hours2);
        var result3 = _berlinClock.GetHoursRow1(hours3);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result1, Is.EqualTo("OOOO"));
            Assert.That(result2, Is.EqualTo("RROO"));
            Assert.That(result3, Is.EqualTo("RRRR"));
        });
    }

    [Test]
    public void GetHoursRow2_ShouldReturnCorrectRepresentation()
    {
        // Arrange
        var hours1 = 0;
        var hours2 = 12;
        var hours3 = 23;

        // Act
        var result1 = _berlinClock.GetHoursRow2(hours1);
        var result2 = _berlinClock.GetHoursRow2(hours2);
        var result3 = _berlinClock.GetHoursRow2(hours3);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result1, Is.EqualTo("OOOO"));
            Assert.That(result2, Is.EqualTo("RROO"));
            Assert.That(result3, Is.EqualTo("RRRO"));
        });
    }

    [Test]
    public void GetMinutesRow1_ShouldReturnCorrectRepresentation()
    {
        // Arrange
        var minutes1 = 0;
        var minutes2 = 17;
        var minutes3 = 59;

        // Act
        var result1 = _berlinClock.GetMinutesRow1(minutes1);
        var result2 = _berlinClock.GetMinutesRow1(minutes2);
        var result3 = _berlinClock.GetMinutesRow1(minutes3);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result1, Is.EqualTo("OOOOOOOOOOO"));
            Assert.That(result2, Is.EqualTo("YYROOOOOOOO"));
            Assert.That(result3, Is.EqualTo("YYRYYRYYRYY"));
        });
    }

    [Test]
    public void GetMinutesRow2_ShouldReturnCorrectRepresentation()
    {
        // Arrange
        var minutes1 = 0;
        var minutes2 = 2;
        var minutes3 = 59;

        // Act
        var result1 = _berlinClock.GetMinutesRow2(minutes1);
        var result2 = _berlinClock.GetMinutesRow2(minutes2);
        var result3 = _berlinClock.GetMinutesRow2(minutes3);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result1, Is.EqualTo("OOOO"));
            Assert.That(result2, Is.EqualTo("YYOO"));
            Assert.That(result3, Is.EqualTo("YYYY"));
        });
    }
}
