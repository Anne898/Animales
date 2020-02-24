using System;

namespace Animales
{
    class Animales
    {

         
        static void Main(string[] args)
        {

            Pato pato = new Pato("con tenis");
            pato.HacerSonido();
    
           Console.WriteLine(pato.Apellido);
           pato.Apellido="Donald";
           Console.WriteLine(pato.Apellido);
       

            Perro perro = new Perro("Firulais");
            Pato pato2 = new Pato("McDonal");

            Animal[] mascotas = new Animal[2];
            mascotas[0]=perro;
            mascotas[1]=pato2;

            perro.HacerSonido();

           Console.WriteLine(perro.Apellido);
           perro.Apellido="Perro";
           Console.WriteLine(perro.Apellido);
           

        }
    }
}
