using System.Collections.Generic;

namespace trabalho_interdisciplinar_388614.domain.Entities
{
    public class Graph
    {
        public string Identifier { get; set; }
        public IEnumerable<Vertex> Vertexes { get; set; }
        public IEnumerable<Edge> Edges { get; set; }
        public bool IsDigraph { get; set; }
    }
}
