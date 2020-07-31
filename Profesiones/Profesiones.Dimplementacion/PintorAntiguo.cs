using Profesiones.Interface;
using System.Collections.Generic;
namespace Profesiones.Dimplementacion
{
    class PintorAntiguo : IPintor
    {
        //Utilizamos sustantivos para definir atributos
        private List <string> materialesParaPintar; //Ejemplo: Pintura, Spray
        private string nombre; //Ejemplo: Gibrán
        public string Nombre { get { return nombre;} set {nombre = value;}}
        public List<string> MaterialesParaPintar { get {return materialesParaPintar;} set {materialesParaPintar = value;}}
        //Utilizamos verbos para los nombres de los métodos
        public string Pintar()
        {
            return $"Mi nombre es {Nombre} y estoy clavando {materialesParaPintar [0]}";
        }
        public string Diseñar()
        {
            return "Estoy diseñando";
        }
        public string Lijar()
        {
            return "Estoy lijando";
        }
        public string Medir()
        {
            return "Estoy midiendo";
        }
        public string Mezclar()
        {
            return "Estoy mezclando";
        }
        public string Decorar()
        {
            return "Estoy decorando";
        }
    }
}
