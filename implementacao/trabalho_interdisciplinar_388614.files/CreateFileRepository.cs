using trabalho_interdisciplinar_388614.domain.Interfaces.Base;
using System.IO;
using System.Threading.Tasks;

namespace trabalho_interdisciplinar_388614.files
{
    class CreateFileRepository : IOperationWithResponseAndRequestBase<FileStream, string>
    {
        public async Task<FileStream> HandleAsync(string path)
        {
            return await Task.Run(() => File.Create(path));
        }
    }
}
