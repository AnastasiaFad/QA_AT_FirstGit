using System;
using Xunit;
using Menu;
namespace Test1Week
{
    public class xUnitTest1Week
    {
        [Theory]
        [InlineData(-21, "����� ����������� �� ����� ����")]
        [InlineData(-20, "�� ����� �������...")]
        [InlineData(5, "�� ����� �������...")]
        [InlineData(6, "���������...")]
        [InlineData(15, "���������...")]
        [InlineData(16, "�����))")]
        [InlineData(20, "�����))")]
        [InlineData(21, "�����((")]
        [InlineData(35, "�����((")]
        [InlineData(36, "����� �����((")]
        [InlineData(45, "����� �����((")]
        [InlineData(46, "����� ����������� �� ����� ����")]
        public void CheckTemperatureEstimate(int temp, string textTemperature)
        {
            string actual = HW1_1Week.HotOrCold(temp);
            Assert.Equal(textTemperature, actual);
        }

        [Theory]
        [InlineData(21, 3, 9, "����� 21 ����� ������ �� ��������� �����")]
        [InlineData(0, 7, 2, "����� 7 ����� ������ �� ��������� �����")]
        [InlineData(2, 1, 9, "����� 9 ����� ������ �� ��������� �����")]
        public void CheckTheLargestNumber(int number1, int number2, int number3, string expected)
        {
            string actual = HW1_1Week._3Numbers(number1, number2, number3);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("21.09.2021", "Tuesday")]
        [InlineData("23.09.2025", "��������� ���� ����������� \n")]
        [InlineData("00.09.2021", "��������� ���� ����������� \n")]
        [InlineData("08.00.2021", "��������� ���� ����������� \n")]
        [InlineData("08.10.0000", "��������� ���� ����������� \n")]
        public void CheckCorrectDayOfTheWeek(string date, string expected)
        {
            string actual = HW1_1Week.newDayOfTheWeek(date);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, 0, "�� ���� ������ ������!")]
        [InlineData(4, 2, "4 / 2 = 2")]
        [InlineData(0, 2, "0 / 2 = 0")]
        public void CheckCorrectDivision(double number1, double number2, string expected)
        {
            string actual = HW1_1Week.quotientOfNumber(number1, number2);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(499, "� ��� ��� ������...")]
        [InlineData(500, "���� ������ ���������� 50$, � ������������� ��������� ������� ���������� 450")]
        [InlineData(999, "���� ������ ���������� 50$, � ������������� ��������� ������� ���������� 949")]
        [InlineData(1000, "���� ������ ���������� 100$, � ������������� ��������� ������� ���������� 900")]
        [InlineData(1001, "���� ������ ���������� 100$, � ������������� ��������� ������� ���������� 901")]
        public void CheckCorrectSales(int price, string expected)
        {
            string actual = HW1_1Week.salesOfBuy(price);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("Nastya", 20, "Alina", 30, "Alina", "��������� Alina ������ Nastya �� 10 ���")]
        [InlineData("Nastya", 25, "Alina", 30, "Nastya", "�� ��������� Alina ������ Nastya �� 5 ���")]
        [InlineData("Nastya", 20, "Alina", 28, "Kostya", "�� ���������� ������!")]
        [InlineData("Nastya", 0, "Alina", 80, "Nastya", "�� ���������� ������!")]
        [InlineData("Nastya", 10, "Alina", -3, "Nastya", "�� ���������� ������!")]
        [InlineData("Nastya", 10, "Alina", 23, "Nastya)", "�� ���������� ������!")]
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
        [InlineData("����", 0, "�� ��������! ")]
        [InlineData("����", 1, "�� ���������... ")]
        [InlineData("�����", 0, "�� ���������... ")]
        [InlineData("�����", 1, "�� ��������! ")]
        [InlineData("hello", 1, "������� �������� ��������... ")]
        public void CheckCrossOrPile(string userValue, int compValue, string expected)
        {
            string actual = HW1_1Week.crossOrPile(userValue, compValue);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(2000, "��� 20 ���")]
        [InlineData(2001, "��� 21 ���")]
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
