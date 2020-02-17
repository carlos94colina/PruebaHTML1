using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Persona persona = new Persona() { Nombre = "Borja", Apellido1 = "Cabeza" };
            int numero = 10;

            Console.WriteLine("Nombre:" + persona.Nombre);
            Console.WriteLine("Valor:" + numero.ToString());

            Prueba(persona,  ref numero);

            Console.WriteLine("Nombre:" + persona.Nombre);
            Console.WriteLine("Valor:" + numero.ToString());


            Console.ReadKey();
        }

        static void Prueba (Persona p, ref int n)
        {
            p.Nombre = "Ana";
            n = 30;

        }
    }

    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
    }
}
