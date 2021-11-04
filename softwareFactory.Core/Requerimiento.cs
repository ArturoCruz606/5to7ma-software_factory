namespace softwareFactory.Core
{
    public class Requerimiento
    {
        public int Id { get; set; }
        public Proyecto Proyecto { get; set; }
        public Tecnologia Tecnologia { get; set; }
        public string Descripcion { get; set; }
        public byte Complejidad { get; set; }
    }
}