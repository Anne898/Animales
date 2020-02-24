using System;

namespace Animales
{
    class Pato : Animal //herencia
    {
        public Pato(string apellido)
        {
            this.nombre = "Pato";
            this.apellido = apellido;
        }
        public override void HacerSonido()
        {

            Console.WriteLine($"{this.nombre} hace Quack!");

        }
    }


}

