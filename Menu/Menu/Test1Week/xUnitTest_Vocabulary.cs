using Xunit;
using Menu;
namespace Test1Week1Month_xUnit
{
    public class xUnitTest_Vocabulary
    {
        [Theory]
        [InlineData(new string[] { "Katya", "Petya", "Max", "Федя" }, "Max", new string[] { "Katya", "Petya", "Федя" })]
        [InlineData(new string[] { "Max", "Katya", "Petya", "Max", "Федя" }, "Max", new string[] { "Katya", "Petya", "Федя" })]
        [InlineData(new string[] { "Katya", "Petya", "Max", "Федя" }, "Nastya", new string[] { "Katya", "Petya", "Max", "Федя" })]
        public void CheckDeleteNameFromArray(ref string[] array, string nameDelete, string[] expected)
        {
            var actual = HW4_Vocabulary.DeleteFromArray(ref array, nameDelete);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(new string[] { "Katya", "Petya", "Max"}, new string[] { "Masha", "Nastya" }, new string[] { "Katya", "Petya", "Max", "Masha", "Nastya" })]
        [InlineData(new string[] { "Katya"}, new string[] { "Masha", "Nastya", "Petya" }, new string[] { "Katya", "Masha", "Nastya", "Petya" })]
        public void CheckAddNamesToArray(ref string[] array, string[] NewArray, string[] expected)
        {
            var actual = HW4_Vocabulary.AddToArray(ref array, NewArray);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(new string[] { "Katya", "Petya", "Max" }, "Masha, Nastya" , new string[] { "Katya", "Petya", "Max", "Masha", "Nastya" })]
        [InlineData(new string[] { "Katya" },  "Masha, Nastya, Petya", new string[] { "Katya", "Masha", "Nastya", "Petya" })]
        public void CheckAddNamesToArrayFromText(ref string[] array, string namesText, string[] expected)
        {
            var actual = HW4_Vocabulary.Start(ref array, namesText);
            Assert.Equal(expected, actual);
        }
    }
}
