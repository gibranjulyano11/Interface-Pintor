using Profesiones.Dentidad;
using Profesiones.Interface;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Profesiones.Dimplementacion
{
    public class PintorModerno : Pintor, IPintor, IEquatable<PintorModerno>
    {
        public string Pintar()
        {
            return "Estoy pintando con soplete";
        }
        public string Lijar()
        {
            return "Estoy lijando con lijadora de absorción";
        }
        public string Medir()
        {
            return "Estoy midiendo con láser";
        }
        public string Diseñar()
        {
            return "Estoy diseñando con Autocad";
        }
        public string Mezclar()
        {
            return "Estoy mezclando con mezcladora de paletas ";
        }
        public string Decorar()
        {
            return "Estoy decorando con gigantografías";
        }

        public bool Equals([AllowNull] PintorModerno other)
        {
            return this.Id == other.Id;
        }
    }
}
