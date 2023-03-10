using ReverseString;
using Xunit;

namespace ReverseStringTests
{
    public class StringManupulationTest
    {
        [Fact]
        public void StringManupulation_GivenString()
        {
            StringManupulation manupulation = new StringManupulation();

            string firstString = "iju#uhjjm!jhjh#kjn)";
            string secondString = "naioj!!,mna09KKJ$";
            string thirdString = "uhuqwe kljlk/"; 
            string fourthString = ".asda.1231.$jm";
            string fifthString = "uhebn*jh+das";

            string firstExpectedResult = "njk#hjhjm!jjhu#uji)";
            string secondExpectedResult = "JKKan!!,mjo09ian$";
            string thirdExpectedResult = "kljlke wquhu/";
            string fourthExpectedResult = ".mjad.1231.$sa";
            string fifthExpectedResult = "sadhj*nb+ehu";

            Assert.Equal(manupulation.ReverseString(firstString), firstExpectedResult);
            Assert.Equal(manupulation.ReverseString(secondString), secondExpectedResult);
            Assert.Equal(manupulation.ReverseString(thirdString), thirdExpectedResult);
            Assert.Equal(manupulation.ReverseString(fourthString), fourthExpectedResult);
            Assert.Equal(manupulation.ReverseString(fifthString), fifthExpectedResult);

        }

    }
}