using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class minion : carta, Interfaceatacar
    {
        public int vida { get; set; }
        public int ataque { get; set; }


        public minion(string nombre, int vida, int ataque, Boolean actividad, Boolean visibilidad, int mana)
        {
            this.nombre = nombre;
            this.vida = vida;
            this.ataque = ataque;
            this.actividad = actividad;
            this.visibilidad = visibilidad;
            this.mana = mana;
        }

        public override void CambiarTurno()
        {
            base.CambiarTurno();
        }

        public override void Describir()
        {
            Console.WriteLine("Minion: " + nombre + "\nVida: " + vida + "\nAtaque: " + ataque + "\nCosto de mana: " + mana + "\n");


        }
        public override void cambiarActividad()
        {
            base.cambiarActividad();
        }
        public override void cambiarVisibilidad()
        {
            base.cambiarVisibilidad();
        }









        public int attack(minion nombre, Heroe jugador)
        {

            if (jugador == null)
            {
                nombre.vida = nombre.vida - this.ataque;
                this.vida = this.vida - nombre.ataque;
                return nombre.vida;

            }
            if (jugador != null)
            {
                if (jugador.tipo == "Hunter")
                {
                    jugador.vida = jugador.vida - this.ataque;
                    return jugador.vida;
                }
                if (jugador.tipo == "Warrior")
                {
                    if (jugador.escudo == 0)
                    {
                        jugador.vida = jugador.vida - this.ataque;
                        return jugador.vida;
                    }
                    if (jugador.escudo > 0)
                    {
                        int y1 = jugador.escudo - this.ataque;
                        jugador.vida = jugador.vida - y1;
                        return jugador.vida;
                    }
                }


            }



            return 0;







        }









    }
}

