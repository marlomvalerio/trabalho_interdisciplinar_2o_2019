using trabalho_interdisciplinar_388614.domain.Entities;
using trabalho_interdisciplinar_388614.domain.Interfaces.Base;
using System;
using System.IO;
using System.Threading.Tasks;

namespace trabalho_interdisciplinar_388614.services.Queries
{
    class BuildGraphCommand : IOperationWithResponseAndRequestBase<Graph, string[]>
    {
        public async Task<Graph> HandleAsync(string[] request)
        {
            throw new NotImplementedException();
        }
    }
}
