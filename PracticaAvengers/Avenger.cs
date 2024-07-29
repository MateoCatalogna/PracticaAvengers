using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaAvengers
{
    public class Avenger:Personaje
    {
        public EEquipamiento equipamiento;


        public Avenger(string nombre, List<EHabilidades> habilidades, EEquipamiento eq) :base(habilidades, nombre)
        {
            this.equipamiento = eq;
        }

        public string Nombre
        {
            get
            {
                return ($"Mi nombre es {this.nombre} y si no puedo y si no puedo proteger la tierra, la vengaré");
            }
        }

        public string MostrarAvenger()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Nombre: {this.nombre}");
            sb.Append($"Habiliades:{base.Mostrar()}");
            sb.Append($"Equipamiento;{equipamiento}");
            return sb.ToString();
        }
    }
}
