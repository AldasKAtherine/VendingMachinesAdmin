namespace Entidades
{
    public class Compartimento
    {
        public int Id { get; set; }
        public int Posicion { get; set; }
        public int Capacidad { get; set; }
        public int Cantidad { get; set; }
        public Producto Producto { get; set; }
    }
}