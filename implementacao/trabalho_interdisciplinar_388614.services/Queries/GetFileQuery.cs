using trabalho_interdisciplinar_388614.domain.Interfaces.Base;
using System.Threading.Tasks;

namespace trabalho_interdisciplinar_388614.services.Queries
{
    class GetFileQuery : IOperationWithResponseAndRequestBase<string[], string>
    {
        private IOperationWithResponseAndRequestBase<string[], string> _getFileRepository { get; set; }



        public GetFileQuery(IOperationWithResponseAndRequestBase<string[], string> getFileRepository)
        {
            this._getFileRepository = getFileRepository;
        }



        public async Task<string[]> HandleAsync(string path)
        {
            return await _getFileRepository.HandleAsync(path);
        }
    }
}
