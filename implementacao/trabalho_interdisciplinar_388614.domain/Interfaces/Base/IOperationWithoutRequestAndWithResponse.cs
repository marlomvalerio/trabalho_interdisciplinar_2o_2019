using System.Threading.Tasks;

namespace trabalho_interdisciplinar_388614.domain.Interfaces.Base
{
    public interface IOperationWithoutRequestAndWithResponse<TRequest>
    {
        Task HandleAsync();
    }
}
