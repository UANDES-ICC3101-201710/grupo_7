using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaFinalPOOO
{
    [Serializable]
    public class Heroe : Jugador, Interfaceatacar
    {
        public string tipo { get; set; }
        public int vida = 30;
        public int escudo = 0;
        public int mana = 0;
        public int manatotal = 0;
        public bool activo;

        public void InfoTurno(Heroe a)
        {
            Consola.WriteOutput("---------------------------------\n" + this.nombre + "  es tu turno!");
            Consola.WriteOutput(this.nombre + " - " + this.tipo + "\nVida: " + this.vida + " - Armadura: " + this.escudo + "\nLa vida del heroe de " + a.nombre + " es: " + a.vida + " - Armadura: " + a.escudo);
            Consola.WriteOutput(this.nombre + " tu mana total es de: " + this.manatotal);
            Consola.WriteOutput(this.nombre + " tu mana disponible en el turno: " + this.mana);
        }

        public void terminarturnomana()
        {
            if (manatotal < 10)
            {
                manatotal = manatotal + 1;
            }
            mana = manatotal;
        }

        public void TusCartasCanchas(List<carta> a)
        {
            Consola.WriteOutput(this.nombre + " tus cartas en cancha son las siguientes:  ");
            int x = 1;
            foreach (minion n in a)
            {
                if (n.actividad == true)
                {
                    Consola.WriteOutput("(" + x + ")");
                    n.Describir();
                    x = x + 1;
                }

            }
        }

        public void CartasOpenCancha(List<carta> b)
        {
            Consola.WriteOutput("Las cartas en cancha de " + this.nombre + " son las siguientes:  ");
            int t = 1;
            foreach (minion n in b)
            {
                if (n.actividad == true)
                {
                    Consola.WriteOutput("(" + t + ")");
                    n.Describir();
                    t = t + 1;
                }
            }
        }

        public void invocar(minion n, List<minion> lista)
        {
            if (this.mana >= 2)
            {

                if (this.tipo == "Paladin")
                {



                    lista.Add(n);
                }
                if (this.tipo == "Shaman")
                {



                    lista.Add(n);
                }
            }



        }
        public void jugarcarta(int a, List<minion> lista)
        {


            if (this.mano[a - 1].mana <= this.mana)
            {
                this.gastarmana(this.mano[a - 1]);

                Consola.WriteOutput("---------------------------------\n" + this.nombre + " has elegido la carta " + this.mano[a - 1].nombre + "\n---------------------------------");
                (this.mano[a - 1]).cambiarActividad();
                carta cc = this.mano[a - 1];
                if (cc.GetType().Equals(typeof(minion)))
                {
                    minion p = (minion)this.mano[a - 1];
                    lista.Add(p);
                }


                this.mano.RemoveAt(a - 1);



            }

        }
        public void gastarmana(carta a)
        {
            this.mana = this.mana - a.mana;
        }
        public int Vida
        {
            get
            {
                return vida;
            }

            set
            {
                vida = value;
            }
        }
        public Heroe(string tipo, string nombre, List<carta> mano, Stack<carta> mazo, int mana, int manatotal, bool activo)
        {
            this.tipo = tipo;
            this.nombre = nombre;
            this.mano = mano;
            this.mazo = mazo;
            this.mana = mana;
            this.manatotal = manatotal;
            this.activo = activo;
        }


        public void pasarturno(Heroe j)
        {
            this.activo = false;
            j.activo = true;
        }
        public override void Comunicarse(string a)
        {
            base.Comunicarse(a);
        }


        public override void Rendirse(int vida)
        {
            base.Rendirse(vida);
        }

        public void Describir()
        {

            Consola.ReadInput(nombre + " " + vida + "\nArmadura: " + escudo);
        }

        public override void TerminarTurno()
        {
            base.TerminarTurno();
        }
        public void ingresarnombre(string nombre)
        {
            this.nombre = nombre;

        }
        public void ingresartipo(string tipo)
        {
            this.tipo = tipo;
        }
        public override void ingresarmano(List<carta> mano)
        {
            base.ingresarmano(mano);
        }

        public override void ingresarmazo(Stack<carta> mazo)
        {
            base.ingresarmazo(mazo);
        }

        public int habilidad(Heroe tipo)
        {
            if (this.mana >= 2)
            {
                this.mana = this.mana - 2;
                if (this.tipo == "Druid") { }

                if (this.tipo == "Hunter")
                {
                    if (tipo.tipo == "Warrior")
                    {
                        if (tipo.escudo == 0)
                        {
                            tipo.vida = tipo.vida - 2;
                            if (tipo.vida <= 0)
                            {
                                tipo.Rendirse(tipo.vida);
                            }
                        }
                        if (tipo.escudo > 0)
                        {
                            int y1 = tipo.escudo - 2;
                            tipo.escudo = 0;
                            tipo.vida = tipo.vida - y1;
                            if (tipo.vida <= 0)
                            {
                                tipo.Rendirse(tipo.vida);
                            }
                        }

                    }
                    else
                    {

                        tipo.vida = tipo.vida - 2;
                        if (tipo.vida <= 0)
                        {
                            tipo.Rendirse(tipo.vida);
                        }
                    }

                    return tipo.vida;
                }


                if (this.tipo == "Warrior")
                {
                    this.escudo = this.escudo + 2;
                    return escudo;

                }
                if (this.tipo == "Mage")
                {
                    /* if (tipo.tipo == "Warrior")
                     {
                         if (tipo.escudo == 0)
                         {
                             tipo.vida = tipo.vida - 2;
                             if (tipo.vida <= 0)
                             {   
                                 tipo.Rendirse(tipo.vida);
                             }
                         }
                         if (tipo.escudo > 0)
                         {
                             int y1 = tipo.escudo - 2;
                             tipo.escudo = 0;
                             tipo.vida = tipo.vida - y1;
                             if (tipo.vida <= 0)
                             {
                                 tipo.Rendirse(tipo.vida);
                             }
                         }

                     }
                     else
                     {

                         tipo.vida = tipo.vida - 2;
                         if (tipo.vida <= 0)
                         {
                             tipo.Rendirse(tipo.vida);
                         }
                     }
                 }
                 */
                }

                if (this.tipo == "Priest")
                {
                    this.vida = this.vida + 2;
                    if (this.vida >= 30)
                    {
                        this.vida = 30;
                    }
                }

                if (this.tipo == "Rogue")
                {

                }

                if (this.tipo == "Shaman")
                {

                }

                if (this.tipo == "Warlock")
                {
                    this.darcarta();
                    this.vida = this.vida - 2;
                    if (this.vida < 0)
                    {
                        this.vida = 0;
                        this.Rendirse(this.vida);
                    }
                }
            }
            return tipo.vida;


        }

        public int attack(minion nombre, Heroe jugador, List<minion> cartascancha, List<minion> cartascancha2)
        {


            if (jugador == null)
            {


                nombre.vida = nombre.vida - 2;

                if (nombre.vida <= 0)
                {
                    nombre.morirminion();// NO SE MUERE :(
                    cartascancha2.Remove(nombre);

                }


                return nombre.vida;

            }
            if (jugador != null)
            {

                jugador.vida = jugador.vida - 2;
                return jugador.vida;

            }

            return 0;



        }






    }
}