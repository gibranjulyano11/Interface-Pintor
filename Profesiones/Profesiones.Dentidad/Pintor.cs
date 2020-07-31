using System.Collections.Generic;
namespace Profesiones.Dentidad
{
    public class Pintor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string  Apellido { get; set; }
        public List<string> MaterialesParaPintar { get; set; }
    }
}
