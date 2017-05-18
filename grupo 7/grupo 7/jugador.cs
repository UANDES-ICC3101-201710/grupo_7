using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
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
            (mazo.Peek()).cambiarVisibilidad();
            mano.Add(mazo.Pop());

        }
        public void QuemarMano()
        {
            if (mano.Count > 10)
            {
                mazo.Pop();

            }
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
            if (a == "1") { Console.WriteLine("Rayos y centellas"); }
            if (a == "2") { Console.WriteLine("MUEEEERE!!!"); }
            if (a == "3") { Console.WriteLine("Hola nena"); }
            if (a == "4") { Console.WriteLine(" :(  "); }
            if (a == "5") { Console.WriteLine("PASANDO EL RAMO"); }

        }
        public virtual void Rendirse(int vida)
        {
            vida = 0;
            Console.WriteLine("¡HAS PERDIDO ESTA PARTIDA! Por favor cierra el programa e inicialo para jugar nuevamente.");
        }


    }
}

