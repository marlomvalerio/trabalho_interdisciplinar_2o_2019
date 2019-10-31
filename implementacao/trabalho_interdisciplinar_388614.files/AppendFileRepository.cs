using trabalho_interdisciplinar_388614.domain.Contracts;
using trabalho_interdisciplinar_388614.domain.Interfaces.Base;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_interdisciplinar_388614.files
{
    class AppendFileRepository : IOperationWithoutResponseAndWithRequestBase<AppendFileRequest>
    {
        public async Task HandleAsync(AppendFileRequest request)
        {
            await Task.Run(() => File.AppendAllLines(request.Path, request.Contents, Encoding.UTF8));
        }
    }
}
