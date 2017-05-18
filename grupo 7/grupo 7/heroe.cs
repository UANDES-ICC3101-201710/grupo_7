using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Heroe : Jugador
    {
        public string tipo { get; set; }
        public int vida = 30;
        public int escudo = 0;


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
        public Heroe(string tipo, string nombre, List<carta> mano, Stack<carta> mazo)
        {
            this.tipo = tipo;
            this.nombre = nombre;
            this.mano = mano;
            this.mazo = mazo;
            
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
            Console.WriteLine(nombre + " " + vida + "\nArmadura: " + escudo);
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


        public int habilidad(Heroe tipo)
        {
            
            
                if (this.tipo == "Hunter")
                {
                    if (tipo.tipo == "Hunter")
                    {

                        tipo.vida = tipo.vida - 2;
                        if (tipo.vida <= 0)
                        {
                            tipo.Rendirse(tipo.vida);
                        }
                    }
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
                    return tipo.vida;
                }


                if (this.tipo == "Warrior")
                {
                    this.escudo = this.escudo + 2;
                    return escudo;

                }
                return tipo.vida;
            }
 
            
            
        }


        
    
}





