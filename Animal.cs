using System;

namespace Animales
{
    abstract class Animal //una clase astracta 
    {
        protected string nombre;
        protected string apellido;
        public string Apellido{

            get => $"Señor {apellido}";
            set =>apellido=value;
        
        }
        public abstract void HacerSonido();

       
        }

 }


