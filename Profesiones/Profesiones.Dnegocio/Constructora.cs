using Profesiones.Interface;
namespace Profesiones.DNegocio
{
     public class Constructora
    {
        public IPintor Pintor { get; set; }
        public string ContratarPintor(IPintor pintor)
        {
            Pintor = pintor;
            return "Contraté un pintor";
        }
        public string PintarDormitorio()
        {
            return Pintor.Pintar() + "Dormitorio"
                + Pintor.Lijar() + "Dormitorio"
                + Pintor.Diseñar() + "Dormitorio"
                + Pintor.Decorar() + "Dormitorio"
                + Pintor.Medir() + "Dormitorio"
                + Pintor.Mezclar() + "Dormitorio";
        }
        public string ContratarPintor()
        {
            return "Contraté un pintor";
        }
    }
}

