using trabalho_interdisciplinar_388614.domain.Interfaces.Base;
using System.Threading.Tasks;

namespace trabalho_interdisciplinar_388614.services.Queries
{
    class VerifyFileExistsQuery : IOperationWithResponseAndRequestBase<bool, string>
    {
        private IOperationWithResponseAndRequestBase<bool, string> _verifyFileExistsRepository { get; set; }



        public VerifyFileExistsQuery(IOperationWithResponseAndRequestBase<bool, string> verifyFileExistsRepository)
        {
            this._verifyFileExistsRepository = verifyFileExistsRepository;
        }



        public async Task<bool> HandleAsync(string path)
        {
            return await _verifyFileExistsRepository.HandleAsync(path);
        }
    }
}
