using System.Threading.Tasks;

namespace simple.pipeline
{
    public static class SimplePipelineStepExtensions
    {
        public static async Task<TOut> Step<TIn, TOut>(this Task<TIn> input,  IPipelineStep<TIn, TOut> step)
        {
            return await step.Process(await input);
        }
    }
}