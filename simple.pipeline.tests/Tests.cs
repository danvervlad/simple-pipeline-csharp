using System.Threading.Tasks;
using Xunit;

namespace simple.pipeline.tests
{
    public class Tests
    {
        [Theory]
        [InlineData(12, "00432")]
        [InlineData(2, "00006")]
        public async Task Test1(int multiplier, string expectedResult)
        {
            // act
            var result = await Task.FromResult(3)
                .Step(new MultiplyStep(multiplier))
                .Step(new OptionalStep<int, int>(i => i > 10, new MultiplyStep(multiplier)))
                .Step(new ConvertToStringStep());

            // assert
            Assert.True(result == expectedResult);
        }
    }
}