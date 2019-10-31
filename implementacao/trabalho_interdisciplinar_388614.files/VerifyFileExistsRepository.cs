using trabalho_interdisciplinar_388614.domain.Interfaces.Base;
using System.IO;
using System.Threading.Tasks;

namespace trabalho_interdisciplinar_388614.files
{
    class VerifyFileExistsRepository : IOperationWithResponseAndRequestBase<bool, string>
    {
        public async Task<bool> HandleAsync(string path)
        {
            return await Task.Run(() => File.Exists(path));
        }
    }
}
