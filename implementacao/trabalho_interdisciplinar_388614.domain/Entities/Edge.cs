namespace trabalho_interdisciplinar_388614.domain.Entities
{
    public class Edge
    {
        public string Identifier { get; set; }
        public Vertex OutgoingVertex { get; set; }
        public Vertex IncidentVertex { get; set; }
        public int Weight { get; set; }
    }
}
