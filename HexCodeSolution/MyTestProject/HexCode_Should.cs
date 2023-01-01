using ApplicationService;

namespace MyTestProject
{
    public class HexCode_Should
    {
        public static IEnumerable<object[]> trueDataToTest
               => new List<object[]>
               {
                new object[] { "#CD5C5C" },
                new object[] { "#EAECEE" },
                new object[] { "#eaecee" }
               };

        public static IEnumerable<object[]> falseDataToTest
            => new List<object[]>
            {
                new object[] { "#CD5C58C" },
                new object[] { "#CD5C5Z" },
                new object[] { "#CD5C" },
                new object[] { "CD5C5C" }
            };

        [Theory]
        [MemberData(nameof(trueDataToTest))]
        public void be_true(string code)
        {
            bool result = HexCode.IsValidHexCode(code);

            Assert.True(result);
        }

        [Theory]
        [MemberData(nameof(falseDataToTest))]
        public void be_false(string code)
        {
            bool result = HexCode.IsValidHexCode(code);

            Assert.False(result);
        }
    }
}