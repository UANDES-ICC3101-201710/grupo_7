using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaFinalPOOO
{
    [Serializable]
    public class minion : carta, Interfaceatacar
    {
        public int vida { get; set; }
        public int ataque { get; set; }


        public minion(string nombre, int ataque, int vida, Boolean actividad, Boolean visibilidad, int mana)
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
            Consola.WriteOutput("Minion: " + nombre + "\nVida: " + vida + "\nAtaque: " + ataque + "\nCosto de mana: " + mana + "\n");


        }
        public override void cambiarActividad()
        {
            base.cambiarActividad();
        }
        public override void cambiarVisibilidad()
        {
            base.cambiarVisibilidad();
        }

        public void terminarturnominion()
        {
            if (this.visibilidad == true && this.actividad == true && this.turno == false)
            {
                this.CambiarTurno();
            }
        }




        public void morirminion()
        {
            this.vida = 0;
            this.cambiarActividad();
            this.cambiarVisibilidad();
            this.turno = false;


        }


        public int attack(minion nombre, Heroe jugador,List<minion> cartascancha,List<minion> cartascancha2)
        {

            if (jugador == null)
            {
                if (this.turno == true)
                {
                   
                    nombre.vida = nombre.vida - this.ataque;
                    this.vida = this.vida - nombre.ataque;
                    this.turno = false;
                    

                    if (nombre.vida <= 0)
                    {
                       nombre.morirminion();
                        cartascancha2.Remove(nombre);/*LALALALALALALALAALLALALALALALALALALALALALALA*/
                    }
                    if (this.vida <= 0)
                    {
                        this.morirminion();
                        cartascancha.Remove(this);/*ALALALALALALALALALALALAAAAAAAAAAAAAAAAAAAAAAALALAL*/
                    }


                    return nombre.vida;
                }
            }
            if (jugador != null)
            {
                if (jugador.tipo == "Hunter" || jugador.tipo == "Shaman" || jugador.tipo == "Mage" || jugador.tipo == "Paladin" || jugador.tipo == "Priest" || jugador.tipo == "Rogue" || jugador.tipo == "Warlock")
                {
                    jugador.vida = jugador.vida - this.ataque;
                    this.turno = false;
                    return jugador.vida;
                }
                if (jugador.tipo == "Warrior" || jugador.tipo == "Druid")
                {
                    if (jugador.escudo == 0)
                    {
                        jugador.vida = jugador.vida - this.ataque;
                        this.turno = false;
                        return jugador.vida;
                    }
                    if (jugador.escudo > 0)
                    {
                        int y1 = jugador.escudo - this.ataque;
                        jugador.vida = jugador.vida - y1;
                        this.turno = false;
                        return jugador.vida;
                    }
                }


            }



            return 0;







        }









    }
}





