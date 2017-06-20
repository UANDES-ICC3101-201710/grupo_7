using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaFinalPOOO
{

    [Serializable]
    public abstract class carta
    {

        public Boolean actividad { get; set; }
        public string nombre { get; set; }
        public Boolean visibilidad { get; set; }
        public int mana { get; set; }
        public Boolean turno { get; set; } // no sabemos   ocupar//


        public virtual void CambiarTurno()
        {
            if (turno == false)
            {
                turno = true;
            }
            else
            {
                turno = false;
            }
        }


        public virtual void Describir()
        {
        }
        public virtual void habilidad()
        {

        }



        public virtual void cambiarActividad()
        {
            if (actividad == false)
            {
                actividad = true;
            }
            else
            {
                actividad = false;
            }

        }
        public virtual void cambiarVisibilidad()
        {
            if (visibilidad == false)
            {
                visibilidad = true;
            }
            else
            {
                visibilidad = false;
            }


        }
    }
}

