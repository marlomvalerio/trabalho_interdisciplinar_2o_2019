using System.Collections.Generic;

namespace trabalho_interdisciplinar_388614.domain.Contracts
{
    public class AppendFileRequest
    {
        public string Path { get; set; }
        public IEnumerable<string> Contents { get; set; }
    }
}
