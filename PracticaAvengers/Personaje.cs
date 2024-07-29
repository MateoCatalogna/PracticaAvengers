using System.Data.Common;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace PracticaAvengers
{
    public class Personaje
    {
        private List<EHabilidades> listaHabilidades;
        protected string? nombre;


        public Personaje()
        {
            this.listaHabilidades = new List<EHabilidades>();
        }

        public Personaje(List<EHabilidades> listaHabilidades, string? nombre):this()
        {
            this.listaHabilidades = listaHabilidades;
            this.nombre = nombre;
        }

        private string ListaHabilidades
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("Habilidades:");
                foreach (EHabilidades habilidad in this.listaHabilidades)
                {
                    sb.Append($"{habilidad}");
                }
                
                return sb.ToString();
            }
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Nombre:{this.nombre}");
            sb.Append($"Habilidades:{this.listaHabilidades}");
            return sb.ToString();
        }

        public override bool Equals(object? obj)
        {
            return obj is Personaje personaje &&
                   EqualityComparer<List<EHabilidades>>.Default.Equals(listaHabilidades, personaje.listaHabilidades) &&
                   nombre == personaje.nombre &&
                   ListaHabilidades == personaje.ListaHabilidades;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(listaHabilidades, nombre, ListaHabilidades);
        }

        public static bool operator ==(List<Personaje> listaPersonajes, Personaje personaje)
        {
           foreach (Personaje auxPersonaje in listaPersonajes)
            {
                if (auxPersonaje.nombre == personaje.nombre && auxPersonaje.GetType() == personaje.GetType())
                {
                    return true;
                }
            }
           return false;    
        }

        public static bool operator !=(List<Personaje> listaPersonajes, Personaje personaje)
        {
            return !(listaPersonajes == personaje);
        }

        public static List<Personaje> operator +(List<Personaje> listaPersonajes, Personaje personaje)
        {
            if (!listaPersonajes.Contains(personaje))
            {
                listaPersonajes.Add(personaje);
            }
            return listaPersonajes;
        }

    }
}
