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
                new object[] { "#CD5C5K" },
                new object[] { "#CD5C5Z" },
                new object[] { "#CDD5XC" },
                new object[] { "#ZD5CPC" }
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

        [Fact]
        public void throw_ArgumentOutOfRangeException()
        {
            const string code = "#1b3";

            Assert.Throws<ArgumentOutOfRangeException>(() => HexCode.IsValidHexCode(code));
        }

        [Fact]
        public void throw_ArgumentException()
        {
            const string code = "0123ABC";

            Assert.Throws<ArgumentException>(() => HexCode.IsValidHexCode(code));
        }
    }
}