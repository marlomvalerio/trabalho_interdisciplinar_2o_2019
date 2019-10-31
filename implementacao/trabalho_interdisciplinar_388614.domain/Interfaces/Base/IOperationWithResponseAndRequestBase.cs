using System.Threading.Tasks;

namespace trabalho_interdisciplinar_388614.domain.Interfaces.Base
{
    public interface IOperationWithResponseAndRequestBase<TRespose, TRequest>
    {
        Task<TRespose> HandleAsync(TRequest request);
    }
}
