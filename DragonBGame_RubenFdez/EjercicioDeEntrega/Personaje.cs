
using System;

namespace EjercicioEntrega
{
    public class Personaje

    {
        public string nombre = "";
        public string nivel = "";

        public Personaje (string nombre, string nivel)

        {
         this.nombre = nombre;
         this.nivel = nivel ;
            nombre = Console.ReadLine();

        }




        public string getNombre()
        {
            return nombre;

        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string getNivel()
        {
            return nivel;
        }


        public void setNivel(string setNivel)
        {
            this.nivel = setNivel;
        }


        public override string ToString()

        {
            
            return $"Personaje Encontrado : {nombre}, Nivel: {nivel}";
         
           
        }


    }

    internal class Length
    {
    }

    internal class define
    {
    }
}
