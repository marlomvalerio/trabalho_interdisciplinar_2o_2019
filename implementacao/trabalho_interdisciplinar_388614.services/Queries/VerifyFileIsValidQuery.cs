using trabalho_interdisciplinar_388614.domain.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_interdisciplinar_388614.services.Queries
{
    class VerifyFileIsValidQuery : IOperationWithResponseAndRequestBase<bool, string>
    {
        private IOperationWithResponseAndRequestBase<string[], string> _getFileRepository { get; set; }



        public VerifyFileIsValidQuery(IOperationWithResponseAndRequestBase<string[], string> getFileRepository)
        {
            this._getFileRepository = getFileRepository;
        }



        public async Task<bool> HandleAsync(string path)
        {
            var response = await _getFileRepository.HandleAsync(path);

            return response != null;
        }
    }
}
