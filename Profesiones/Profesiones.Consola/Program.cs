using System;
using Profesiones.Dimplementacion;
using Profesiones.DNegocio;
using Profesiones.DaccesoDatos;
using Profesiones.Dentidad;

namespace Profesiones.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo!");
            Constructora MiConstructora = new Constructora();

            MiConstructora.ContratarPintor(new PintorEstandar());
            MiConstructora.PintarDormitorio();
            
            var pintor1 = new PintorModerno();
            pintor1.Id = 1;
            MiConstructora.ContratarPintor(new PintorModerno());
            MiConstructora.PintarDormitorio();
            
            var pintor = new PintorDivertido();
            pintor.Id = 1;
            
            MiConstructora.ContratarPintor(pintor);
            MiConstructora.PintarDormitorio();

            ApplicationDbContext applicationDbContext = new ApplicationDbContext();
            applicationDbContext.Pintores.Add(new Pintor());
            applicationDbContext.SaveChanges();
            Console.ReadKey();
        }
    }
}
