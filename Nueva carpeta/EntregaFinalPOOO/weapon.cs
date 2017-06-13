using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaFinalPOOO
{
    [Serializable]
    class weapon : carta
    {
        private int ataque;
        private int durabilidad;

        public weapon(int ataque, int durabilidad, string nombre)
        {
            this.ataque = ataque;
            this.durabilidad = durabilidad;
            this.nombre = nombre;
        }

        public override void cambiarActividad()
        {
            base.cambiarActividad();
        }

        public override void cambiarVisibilidad()
        {
            base.cambiarVisibilidad();
        }




        public int atacarminion(minion nombre, Heroe tipo)
        {
            if (visibilidad == true && actividad == true)
            {
                nombre.vida = nombre.vida - this.ataque;
                if (nombre.vida <= 0)
                {
                    nombre.vida = 0;
                    nombre.cambiarActividad();
                    nombre.cambiarVisibilidad();


                }
                tipo.vida = tipo.vida - nombre.ataque;
                if (tipo.vida <= 0)
                {
                    tipo.vida = 0;
                    tipo.Rendirse(tipo.vida);
                }
                return nombre.vida;
            }
            else { Consola.WriteOutput("No se puede atacar"); Console.ReadLine(); return 0; }
        }

        public override void Describir()
        {
            Consola.WriteOutput("Weapon " + nombre);
        }
    }
}



