using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaFinalPOOO
{

    class spells : carta
    {
        public spells(string nombre, int mana, bool actividad, bool visibilidad)
        {
            this.nombre = nombre;
            this.mana = mana;
            this.actividad = actividad;
            this.visibilidad = visibilidad;
        }
        public override void Describir()
        {
            Consola.WriteOutput("Spells: " + nombre + "\nCosto de mana: " + mana + "\n");

        }

        public override void cambiarVisibilidad()
        {
            base.cambiarVisibilidad();
        }
        public override void cambiarActividad()
        {
            base.cambiarActividad();
        }
    }

}
