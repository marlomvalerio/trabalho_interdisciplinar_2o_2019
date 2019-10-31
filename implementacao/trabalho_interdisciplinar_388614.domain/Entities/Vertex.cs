using System.Collections.Generic;

namespace trabalho_interdisciplinar_388614.domain.Entities
{
    public class Vertex
    {
        public string Identifier { get; set; }
        public VertexState State { get; set; }
        public IEnumerable<Edge> Edges { get; set; }
    }
}
