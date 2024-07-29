using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaAvengers
{
    public static class Marvel
    {
        private static List<Personaje> listaPersonaje;
        public static Personaje Personaje 
        { 
            set
            {
                listaPersonaje += value;
            } 
        } 

        static Marvel()
        {
            listaPersonaje = new List<Personaje>();
        }


        public static string MostrarInformación()
        {
            StringBuilder sb = new StringBuilder();
            foreach(Personaje personaje in listaPersonaje)
            {
                if(personaje is Avenger)
                {
                    sb.AppendFormat($"****** AVENGER ****** \n {((Avenger)personaje).MostrarAvenger()}\n");
                }
                else if (personaje is Enemigo) 
                {
                    sb.AppendFormat($"****** ENEMIGO ****** \n {((Enemigo)personaje).MostrarEnemigo()}\n");
                }
            }
            return sb.ToString();
        }

    }

}
