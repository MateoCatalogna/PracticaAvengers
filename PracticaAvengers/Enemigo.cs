using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaAvengers
{
    public class Enemigo : Personaje
    {
        private string objetivo;

        private string Nombre
        {
            get
            {
                return ($"Soy {this.nombre} y los voy a hacer puré ");
            }
        }

        public Enemigo(string nombre, List<EHabilidades> habilidades, string objetivo)
                      : base(habilidades, nombre)
        {
            this.objetivo = objetivo;
        }

        public string MostrarEnemigo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.Append(this.objetivo );
            return sb.ToString();
        }
    }
}
