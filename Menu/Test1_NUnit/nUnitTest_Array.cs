using NUnit.Framework;
using Menu;
namespace Test1_NUnit
{
    public class Tests
    {        
        [Test(Description = "Check search min element of array")]
        [TestCase(new int[] { -1, 2, 4, 5, 7, 1, 6, 0 }, -1)]
        [TestCase(new int[] { 1, 2, 4, 5, 7, 1, 6, 0 }, 0)]
        public void CheckSearchMinElemArray(int[] array, int expected)
        {
            int result = HW1_Array.GetMinElemArray(array);
            Assert.AreEqual(expected, result);
        }

        [Test(Description = "Check search max element of array")]
        [TestCase(new int[] { -1, 2, 4, 5, 7, 1, 6, 0 }, 7)]
        [TestCase(new int[] { 9, 2, 4, 5, 7, 1, 6, 0 }, 9)]
        public void CheckSearchMaxElemArray(int[] array, int expected)
        {
            int result = HW1_Array.GetMaxElemArray(array);
            Assert.AreEqual(expected, result);
        }
        [Test(Description = "Check search min index of array")]
        [TestCase(new int[] { -1, 2, 4, 5, 7, 1, 6, 0 }, 0)]
        [TestCase(new int[] { 9, 2, 4, 5, 7, 1, 6, 0 }, 7)]
        public void CheckSearchMinIndex(int[] array, int expected)
        {
            int result = HW1_Array.GetMinIndex(array);
            Assert.AreEqual(expected, result);
        }
        [Test(Description = "Check search max index of array")]
        [TestCase(new int[] { -1, 2, 4, 5, 7, 1, 6, 0 }, 4)]
        [TestCase(new int[] { 9, 2, 4, 5, 7, 1, 6, 0 }, 0)]
        public void CheckSearchMaxIndex(int[] array, int expected)
        {
            int result = HW1_Array.GetMaxIndex(array);
            Assert.AreEqual(expected, result);
        }
        [Test(Description = "Check sum of odd index in array")]
        [TestCase(new int[] { -1, 2, 4, 5, 7, 1, 6, 0 }, 8)]
        [TestCase(new int[] { 9, 3, 4, 5, 7, 1, 6, 0 }, 9)]
        public void CheckSumOfOddIndex(int[] array, int expected)
        {
            int result = HW1_Array.GetSumOfOddIndex(array);
            Assert.AreEqual(expected, result);
        }
        [Test(Description = "Check count of odd index in array")]
        [TestCase(new int[] { -1, 2, 4, 5, 7, 1, 6, 0 }, 4)]
        [TestCase(new int[] { 9, 3, 4, 5, 7, 1, 6, 0, 9, 4, 3, 9, 10 }, 6)]
        public void CheckCountOfOddIndex(int[] array, int expected)
        {
            int result = HW1_Array.CountOfOddIndex(array);
            Assert.AreEqual(expected, result);
        }
        [Test(Description = "Check Bubble Sort")]
        [TestCase(new int[] { -1, 2, 4, 5, 7, 1, 6, 0 }, new int[] { -1, 0, 1, 2, 4, 5, 6, 7 })]
        [TestCase(new int[] { 9, 3, 4, 5, 7, 1, 6, 0, 9, 4, 3, 9, 10 }, new int[] { 0, 1, 3, 3, 4, 4, 5, 6, 7, 9, 9, 9, 10 })]
        public void CheckBubleSort(int[] array, int[] expected)
        {
            int[] result = HW1_Array.BubleSort(array);
            Assert.AreEqual(expected, result);
        }
       
        [Test(Description = "Check Insertion Sort")]
        [TestCase(new int[] { -1, 2, 4, 5, 7, 1, 6, 0 }, new int[] { -1, 0, 1, 2, 4, 5, 6, 7 })]
        [TestCase(new int[] { 9, 3, 4, 5, 7, 1, 6, 0, 9, 4, 3, 9, 10 }, new int[] { 0, 1, 3, 3, 4, 4, 5, 6, 7, 9, 9, 9, 10 })]
        public void CheckInsertionSort(int[] array, int[] expected)
        {
            int[] result = HW1_Array.InsertionSort(array);
            Assert.AreEqual(expected, result);
        }
        [Test(Description = "Check Insertion Sort")]
        [TestCase(1, "MONDAY")]
        [TestCase(2, "TUESDAY")]
        [TestCase(3, "WEDNESDAY")]
        [TestCase(4, "THURSDAY")]
        [TestCase(5, "FRIDAY")]
        [TestCase(6, "SATURDAY")]
        [TestCase(7, "SUNDAY")]
        [TestCase(8, "Такого дня недели не существует ")]
        [TestCase(0, "Такого дня недели не существует ")]
        public void CheckDayOfTheWeek(int num, string expected)
        {
            string result = HW1_Functions.DayOfTheWeek( num);
            Assert.AreEqual(expected, result);
        }
        [Test(Description = "Check Distance")]
        public void CheckDistance()
        {
            double result = HW1_Functions.Distance(-1, 4, 2, 9);
            Assert.AreEqual(8.602325267042627, result);
        }
        [Test(Description = "Check convert string to number")]
        [TestCase("пятьсот четырнадцать", "514")]
        [TestCase("один", "1")]
        [TestCase("одиннадцать", "11")]
        [TestCase("двадцать четыре", "24")]
        [TestCase("девятьсот девяносто девять", "999")]
        [TestCase("ноль", "0")]
        public void CheckStringToNumber(string srtNum, string expected)
        {
            string result = HW1_Functions.StringToNumber(srtNum);
            Assert.AreEqual(expected, result);
        }
    }
}