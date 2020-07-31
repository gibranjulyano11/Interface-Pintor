using Profesiones.Interface;

namespace Profesiones.Dimplementacion
{
    public class PintorEstandar : IPintor
    {
        public string Lijar()
        {
            return "Estoy lijando con lija";
        }
        public string Medir()
        {
            return "Estoy midiendo con metro";
        }
        public string Diseñar()
        {
            return "Estoy diseñando con lápiz ";
        }
        public string Mezclar()
        {
            return "Estoy mezclando a mano";
        }
        public string Pintar()
        {
            return "Estoy pintando con brocha";
        }
        public string Decorar()
        {
            return "Estoy decorando con pincel";
        }
    }
}