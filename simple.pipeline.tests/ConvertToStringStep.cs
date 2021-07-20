using System.Threading.Tasks;

namespace simple.pipeline.tests
{
    public class ConvertToStringStep : IPipelineStep<int, string>
    {
        public Task<string> Process(int input)
        {
            return Task.FromResult(input.ToString("D5"));
        }
    }
}