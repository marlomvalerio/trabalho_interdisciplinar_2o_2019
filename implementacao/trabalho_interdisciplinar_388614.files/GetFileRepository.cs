using trabalho_interdisciplinar_388614.domain.Interfaces.Base;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_interdisciplinar_388614.files
{
    class GetFileRepository : IOperationWithResponseAndRequestBase<string[], string>
    {
        public async Task<string[]> HandleAsync(string request)
        {
            return await Task.Run(() => File.ReadAllLines(request, Encoding.UTF8));
        }
    }
}
