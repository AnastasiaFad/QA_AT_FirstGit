using System;
using Xunit;
using Menu;
namespace Test1Week
{
    public class xUnitTest1Week
    {
        [Theory]
        [InlineData(-21, "Такая температура не может быть")]
        [InlineData(-20, "На улице холодно...")]
        [InlineData(5, "На улице холодно...")]
        [InlineData(6, "Прохладно...")]
        [InlineData(15, "Прохладно...")]
        [InlineData(16, "Тепло))")]
        [InlineData(20, "Тепло))")]
        [InlineData(21, "Жарко((")]
        [InlineData(35, "Жарко((")]
        [InlineData(36, "ОЧЕНЬ Жарко((")]
        [InlineData(45, "ОЧЕНЬ Жарко((")]
        [InlineData(46, "Такая температура не может быть")]
        public void CheckTemperatureEstimate(int temp, string textTemperature)
        {
            string actual = HW1_1Week.HotOrCold(temp);
            Assert.Equal(textTemperature, actual);
        }

        [Theory]
        [InlineData(21, 3, 9, "Число 21 самое больше из введенных чисел")]
        [InlineData(0, 7, 2, "Число 7 самое больше из введенных чисел")]
        [InlineData(2, 1, 9, "Число 9 самое больше из введенных чисел")]
        public void CheckTheLargestNumber(int number1, int number2, int number3, string expected)
        {
            string actual = HW1_1Week._3Numbers(number1, number2, number3);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("21.09.2021", "Tuesday")]
        [InlineData("23.09.2025", "Введенная дата некорректна \n")]
        [InlineData("00.09.2021", "Введенная дата некорректна \n")]
        [InlineData("08.00.2021", "Введенная дата некорректна \n")]
        [InlineData("08.10.0000", "Введенная дата некорректна \n")]
        public void CheckCorrectDayOfTheWeek(string date, string expected)
        {
            string actual = HW1_1Week.newDayOfTheWeek(date);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, 0, "На ноль делить нельзя!")]
        [InlineData(4, 2, "4 / 2 = 2")]
        [InlineData(0, 2, "0 / 2 = 0")]
        public void CheckCorrectDivision(double number1, double number2, string expected)
        {
            string actual = HW1_1Week.quotientOfNumber(number1, number2);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(499, "У вас нет скидки...")]
        [InlineData(500, "Ваша скидка составляет 50$, а окончательная стоимость покупки составляет 450")]
        [InlineData(999, "Ваша скидка составляет 50$, а окончательная стоимость покупки составляет 949")]
        [InlineData(1000, "Ваша скидка составляет 100$, а окончательная стоимость покупки составляет 900")]
        [InlineData(1001, "Ваша скидка составляет 100$, а окончательная стоимость покупки составляет 901")]
        public void CheckCorrectSales(int price, string expected)
        {
            string actual = HW1_1Week.salesOfBuy(price);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("Nastya", 20, "Alina", 30, "Alina", "Правильно Alina старше Nastya на 10 лет")]
        [InlineData("Nastya", 25, "Alina", 30, "Nastya", "Не правильно Alina старше Nastya на 5 лет")]
        [InlineData("Nastya", 20, "Alina", 28, "Kostya", "Не корректные данные!")]
        [InlineData("Nastya", 0, "Alina", 80, "Nastya", "Не корректные данные!")]
        [InlineData("Nastya", 10, "Alina", -3, "Nastya", "Не корректные данные!")]
        [InlineData("Nastya", 10, "Alina", 23, "Nastya)", "Не корректные данные!")]
        public void CheckWhatAgeIsMore(string name1, int age1, string name2, int age2, string newName, string expected)
        {
            string actual = HW1_1Week.howOldAreYou(name1, age1, name2, age2, newName);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("Nastya", true)]
        [InlineData("Nastya Fadieieva", true)]
        [InlineData("@Nastya", false)]
        [InlineData("Nastya^", false)]
        [InlineData("123Test", false)]
        public void CheckCorrectName(string name, bool expected)
        {
            bool actual = HW1_1Week.correctName(name);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("орел", 0, "Вы победили! ")]
        [InlineData("орел", 1, "Вы проиграли... ")]
        [InlineData("решка", 0, "Вы проиграли... ")]
        [InlineData("решка", 1, "Вы победили! ")]
        [InlineData("hello", 1, "Введено неверное значение... ")]
        public void CheckCrossOrPile(string userValue, int compValue, string expected)
        {
            string actual = HW1_1Week.crossOrPile(userValue, compValue);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(2000, "Это 20 век")]
        [InlineData(2001, "Это 21 век")]
        public void CheckTheCentury(int date, string expected)
        {
            string actual = HW1_1Week.TheCentury(date);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("2000", "int")]
        [InlineData("2001.9", "double")]
        [InlineData("j", "char")]
        [InlineData("true", "bool")]
        [InlineData("false", "bool")]
        [InlineData("nastya", "string")]
        public void CheckTypeOfData(string str, string expected)
        {
            string actual = HW1_1Week.TypeOfData(str);
            Assert.Equal(expected, actual);
        }
    }
}
