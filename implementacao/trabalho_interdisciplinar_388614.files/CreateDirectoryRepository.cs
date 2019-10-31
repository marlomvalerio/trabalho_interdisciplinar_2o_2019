using trabalho_interdisciplinar_388614.domain.Interfaces.Base;
using System.IO;
using System.Threading.Tasks;

namespace trabalho_interdisciplinar_388614.files
{
    class CreateDirectoryRepository : IOperationWithResponseAndRequestBase<DirectoryInfo, string>
    {
        public async Task<DirectoryInfo> HandleAsync(string path)
        {
            return await Task.Run(() => Directory.CreateDirectory(path));
        }
    }
}
