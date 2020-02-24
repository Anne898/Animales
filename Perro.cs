using System;

namespace Animales
{
    class Perro : Animal
    {
        public Perro(string apellido)
        {
            this.nombre = "Perro";
            this.apellido = apellido;
        }
        public override void HacerSonido()
        {

            Console.WriteLine($"{this.nombre} hace guag");

        }
    }


}

