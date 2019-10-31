using trabalho_interdisciplinar_388614.domain.Interfaces.Base;
using System.IO;
using System.Threading.Tasks;

namespace trabalho_interdisciplinar_388614.services.Queries
{
    class CreateFileCommand : IOperationWithResponseAndRequestBase<FileStream, string>
    {
        private IOperationWithResponseAndRequestBase<FileStream, string> _createFileRepository { get; set; }



        public CreateFileCommand(IOperationWithResponseAndRequestBase<FileStream, string> createFileRepository)
        {
            this._createFileRepository = createFileRepository;
        }



        public async Task<FileStream> HandleAsync(string path)
        {
            return await _createFileRepository.HandleAsync(path);
        }
    }
}
