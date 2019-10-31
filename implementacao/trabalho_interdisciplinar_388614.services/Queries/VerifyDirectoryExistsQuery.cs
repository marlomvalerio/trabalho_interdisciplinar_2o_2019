using trabalho_interdisciplinar_388614.domain.Interfaces.Base;
using System.Threading.Tasks;

namespace trabalho_interdisciplinar_388614.services.Queries
{
    class VerifyDirectoryExistsQuery : IOperationWithResponseAndRequestBase<bool, string>
    {
        private IOperationWithResponseAndRequestBase<bool, string> _verifyDirectoryExistsRepository { get; set; }



        public VerifyDirectoryExistsQuery(IOperationWithResponseAndRequestBase<bool, string> verifyDirectoryExistsRepository)
        {
            this._verifyDirectoryExistsRepository = verifyDirectoryExistsRepository;
        }



        public async Task<bool> HandleAsync(string path)
        {
            return await _verifyDirectoryExistsRepository.HandleAsync(path);
        }
    }
}
