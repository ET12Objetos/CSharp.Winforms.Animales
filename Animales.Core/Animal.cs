using System;

namespace Animales.Core
{
    public class Animal
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int peso { get; set; }

        public Animal(int Id, string Nombre, int Peso)
        {
            nombre = Nombre;
            id = Id;
            peso = Peso;
        }

        public Animal()
        {
        }
    }
}
