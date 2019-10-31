using trabalho_interdisciplinar_388614.domain.Interfaces.Base;
using System.IO;
using System.Threading.Tasks;

namespace trabalho_interdisciplinar_388614.services.Queries
{
    class CreateDirectoryCommand : IOperationWithResponseAndRequestBase<DirectoryInfo, string>
    {
        private IOperationWithResponseAndRequestBase<DirectoryInfo, string> _createDirectoryRepository { get; set; }



        public CreateDirectoryCommand(IOperationWithResponseAndRequestBase<DirectoryInfo, string> createDirectoryRepository)
        {
            this._createDirectoryRepository = createDirectoryRepository;
        }



        public async Task<DirectoryInfo> HandleAsync(string path)
        {
            return await _createDirectoryRepository.HandleAsync(path);
        }
    }
}
