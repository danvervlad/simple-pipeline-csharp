using System.Threading.Tasks;

namespace simple.pipeline
{
    public interface IPipelineStep<in TIn, TOut>
    {
        Task<TOut> Process(TIn input);
    }
}