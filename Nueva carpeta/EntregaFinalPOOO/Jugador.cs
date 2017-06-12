using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaFinalPOOO
{
    public abstract class Jugador
    {
        public string nombre { get; set; }
        private int rango = 0;
        public Stack<carta> mazo;
        public List<carta> mano;

        public virtual void TerminarTurno()
        {

        }
        public void darcarta()
        {
            if (this.mano.Count() < 10)
            {
                (this.mazo.Peek()).cambiarVisibilidad();
                this.mano.Add(mazo.Pop());
            }

        }
        public void QuemarMano()
        {
            if (this.mano.Count > 10)
            {
                mazo.Pop();

            }
        }

        public virtual void ingresarmazo(Stack<carta> mazo)
        {
            this.mazo = mazo;
        }
        public virtual void ingresarmano(List<carta> mano)
        {
            this.mano = mano;
        }
        public void devolvercarta(int a)
        {
            mano[a - 1].cambiarVisibilidad();
            mano.RemoveAt(a - 1);


        }
        public void describirmano()/*return STRING MANAGER*/
        {
            foreach (carta i in mano)
            {
                Console.WriteLine(i.visibilidad);
            }
        }


        public virtual void Comunicarse(string a)
        {
            if (a == "1") { Consola.ReadInput("Rayos y centellas"); }
            if (a == "2") { Consola.ReadInput("MUEEEERE!!!"); }
            if (a == "3") { Consola.ReadInput("Hola nena"); }
            if (a == "4") { Consola.ReadInput(" :(  "); }
            if (a == "5") { Consola.ReadInput("PASANDO EL RAMO"); }

        }
        public virtual void Rendirse(int vida)
        {
            vida = 0;
            Consola.WriteOutput("¡HAS PERDIDO ESTA PARTIDA! Por favor cierra el programa e inicialo para jugar nuevamente.");
            
        }


    }
}

