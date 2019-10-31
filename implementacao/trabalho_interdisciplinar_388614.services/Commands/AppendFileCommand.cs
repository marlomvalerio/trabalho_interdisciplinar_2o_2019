using trabalho_interdisciplinar_388614.domain.Contracts;
using trabalho_interdisciplinar_388614.domain.Interfaces.Base;
using System.Threading.Tasks;

namespace trabalho_interdisciplinar_388614.services.Queries
{
    class AppendFileCommand : IOperationWithoutResponseAndWithRequestBase<AppendFileRequest>
    {
        private IOperationWithoutResponseAndWithRequestBase<AppendFileRequest> _appendFileRepository { get; set; }



        public AppendFileCommand(IOperationWithoutResponseAndWithRequestBase<AppendFileRequest> appendFileRepository)
        {
            this._appendFileRepository = appendFileRepository;
        }



        public async Task HandleAsync(AppendFileRequest request)
        {
            await _appendFileRepository.HandleAsync(request);
        }
    }
}
