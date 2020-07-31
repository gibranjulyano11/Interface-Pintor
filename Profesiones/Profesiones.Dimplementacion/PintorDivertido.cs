using Profesiones.Dentidad;
using Profesiones.Interface;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Profesiones.Dimplementacion
{
    public class PintorDivertido : IPintor, IEquatable<PintorDivertido>
    {
        private Pintor pintor = new Pintor();
        public int Id { get { return pintor.Id; } set { pintor.Id = value;} }
        public string Pintar()
        {
            return "Estoy pintando y vacilando";
        }
        public string Decorar()
        {
            return "Estoy decorando escuchando cumbia";
        }
        public string Diseñar()
        {
            return "Estoy diseñando y bailando";
        }
        public string Lijar()
        {
            return "Estoy lijando y silbando";
        }
        public string Medir()
        {
            return "Estoy midiendo y saltando";
        }
        public string Mezclar()
        {
            return "Estoy mezclando y piropeando";
        }

        public bool Equals([AllowNull] PintorDivertido other)
        {
            return this.Id == other.Id;
        }
    }
}
