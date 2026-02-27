using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberAnalyzer; 

[TestClass]
public class DigitParserTests
{
    [TestMethod]
    public void Analyze_ValidString_ReturnsCorrectResult()
    {
        // Arrange (Подготовка)
        var parser = new DigitParser();
        string input = "+1223";

        // Act (Действие)
        var result = parser.Analyze(input);

        // Assert (Проверка)
        Assert.AreEqual(3, result.MaxDigit);
        Assert.AreEqual(1, result.MinDigit);
        Assert.AreEqual(2, result.DigitCounts[2]); // Две двойки
    }

    [TestMethod]
    [ExpectedException(typeof(FormatException))]
    public void Analyze_InvalidCharacters_ThrowsException()
    {
        // Arrange
        var parser = new DigitParser();

        // Act
        parser.Analyze("12a3"); // Должно выбросить исключение
    }

    [TestMethod]
    public void Analyze_NegativeNumber_WorksCorrectly()
    {
        var parser = new DigitParser();
        var result = parser.Analyze("-505");

        Assert.AreEqual(5, result.MaxDigit);
        Assert.AreEqual(0, result.MinDigit);
        Assert.AreEqual(2, result.DigitCounts[5]);
    }
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Analyze_StringTooLong_ThrowsException()
    {
        // Arrange
        var parser = new DigitParser();
        // Создаем строку из 101 единицы (больше MAX_DIGITS = 100)
        string longInput = new string('1', 101);

        // Act
        parser.Analyze(longInput);

        // Assert
        // Ожидается ArgumentException, заданный в атрибуте выше
    }

}