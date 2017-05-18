using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp2
{

    class Program
    {
        static void Main(string[] args)
        {

            minion w = new minion("wisp", 1, 1, false, false, 0);
            minion w1 = new minion("wisp", 1, 1, false, false, 0);
            minion w2 = new minion("wisp", 1, 1, false, false, 0);
            minion m = new minion("Murloc Raider", 2, 1, false, false, 1);
            minion m1 = new minion("Murloc Raider", 2, 1, false, false, 1);
            minion m2 = new minion("Murloc Raider", 2, 1, false, false, 1);
            minion b = new minion("Bloodfen Raptor", 3, 2, false, false, 2);
            minion b1 = new minion("Bloodfen Raptor", 3, 2, false, false, 2);
            minion b2 = new minion("Bloodfen Raptor", 3, 2, false, false, 2);
            minion Rv = new minion("River Crocolisk", 2, 3, false, false, 2);
            minion Rv1 = new minion("River Crocolisk", 2, 3, false, false, 2);
            minion Rv2 = new minion("River Crocolisk", 2, 3, false, false, 2);
            minion Mr = new minion("Magma Rager", 5, 1, false, false, 3);
            minion Mr1 = new minion("Magma Rager", 5, 1, false, false, 3);
            minion Mr2 = new minion("Magma Rager", 5, 1, false, false, 3);
            minion CY = new minion("Chillwind Yeti", 4, 5, false, false, 4);
            minion CY1 = new minion("Chillwind Yeti", 4, 5, false, false, 4);
            minion CY2 = new minion("Chillwind Yeti", 4, 5, false, false, 4);
            minion OS = new minion("Oasis Snapjaw", 2, 7, false, false, 4);
            minion OS1 = new minion("Oasis Snapjaw", 2, 7, false, false, 4);
            minion OS2 = new minion("Oasis Snapjaw", 2, 7, false, false, 4);
            minion BO = new minion("Boulderfist Ogre", 6, 7, false, false, 6);
            minion BO1 = new minion("Boulderfist Ogre", 6, 7, false, false, 6);
            minion BO2 = new minion("Boulderfist Ogre", 6, 7, false, false, 6);
            minion WG = new minion("War Golem", 7, 7, false, false, 7);
            minion WG1 = new minion("War Golem", 7, 7, false, false, 7);
            minion WG2 = new minion("War Golem", 7, 7, false, false, 7);
            minion CH = new minion("Core Hound", 9, 5, false, false, 7);
            minion CH1 = new minion("Core Hound", 9, 5, false, false, 7);
            minion CH2 = new minion("Core Hound", 9, 5, false, false, 7);


            minion w5 = new minion("wisp", 1, 1, false, false, 0);
            minion w15 = new minion("wisp", 1, 1, false, false, 0);
            minion w25 = new minion("wisp", 1, 1, false, false, 0);
            minion m5 = new minion("Murloc Raider", 2, 1, false, false, 1);
            minion m15 = new minion("Murloc Raider", 2, 1, false, false, 1);
            minion m25 = new minion("Murloc Raider", 2, 1, false, false, 1);
            minion b5 = new minion("Bloodfen Raptor", 3, 2, false, false, 2);
            minion b15 = new minion("Bloodfen Raptor", 3, 2, false, false, 2);
            minion b25 = new minion("Bloodfen Raptor", 3, 2, false, false, 2);
            minion Rv5 = new minion("River Crocolisk", 2, 3, false, false, 2);
            minion Rv15 = new minion("River Crocolisk", 2, 3, false, false, 2);
            minion Rv25 = new minion("River Crocolisk", 2, 3, false, false, 2);
            minion Mr5 = new minion("Magma Rager", 5, 1, false, false, 3);
            minion Mr15 = new minion("Magma Rager", 5, 1, false, false, 3);
            minion Mr25 = new minion("Magma Rager", 5, 1, false, false, 3);
            minion CY5 = new minion("Chillwind Yeti", 4, 5, false, false, 4);
            minion CY15 = new minion("Chillwind Yeti", 4, 5, false, false, 4);
            minion CY25 = new minion("Chillwind Yeti", 4, 5, false, false, 4);
            minion OS5 = new minion("Oasis Snapjaw", 2, 7, false, false, 4);
            minion OS15 = new minion("Oasis Snapjaw", 2, 7, false, false, 4);
            minion OS25 = new minion("Oasis Snapjaw", 2, 7, false, false, 4);
            minion BO5 = new minion("Boulderfist Ogre", 6, 7, false, false, 6);
            minion BO15 = new minion("Boulderfist Ogre", 6, 7, false, false, 6);
            minion BO25 = new minion("Boulderfist Ogre", 6, 7, false, false, 6);
            minion WG5 = new minion("War Golem", 7, 7, false, false, 7);
            minion WG15 = new minion("War Golem", 7, 7, false, false, 7);
            minion WG25 = new minion("War Golem", 7, 7, false, false, 7);
            minion CH5 = new minion("Core Hound", 9, 5, false, false, 7);
            minion CH15 = new minion("Core Hound", 9, 5, false, false, 7);
            minion CH25 = new minion("Core Hound", 9, 5, false, false, 7);





            List<carta> mazos = new List<carta>();
            List<carta> mazos2 = new List<carta>();

            mazos.Add(w);
            mazos.Add(w1);
            mazos.Add(w2);
            mazos.Add(m);
            mazos.Add(m1);
            mazos.Add(m2);
            mazos.Add(b);
            mazos.Add(b1);
            mazos.Add(b2);
            mazos.Add(Rv);
            mazos.Add(Rv1);
            mazos.Add(Rv2);
            mazos.Add(Mr);
            mazos.Add(Mr1);
            mazos.Add(Mr2);
            mazos.Add(CY);
            mazos.Add(CY1);
            mazos.Add(CY2);
            mazos.Add(OS);
            mazos.Add(OS1);
            mazos.Add(OS2);
            mazos.Add(BO);
            mazos.Add(BO1);
            mazos.Add(BO2);
            mazos.Add(WG);
            mazos.Add(WG1);
            mazos.Add(WG2);
            mazos.Add(CH);
            mazos.Add(CH1);
            mazos.Add(CH2);
            mazos.Shuffle();




            mazos2.Add(w5);
            mazos2.Add(w15);
            mazos2.Add(w25);
            mazos2.Add(m5);
            mazos2.Add(m15);
            mazos2.Add(m25);
            mazos2.Add(b5);
            mazos2.Add(b15);
            mazos2.Add(b25);
            mazos2.Add(Rv5);
            mazos2.Add(Rv15);
            mazos2.Add(Rv25);
            mazos2.Add(Mr5);
            mazos2.Add(Mr15);
            mazos2.Add(Mr25);
            mazos2.Add(CY5);
            mazos2.Add(CY15);
            mazos2.Add(CY25);
            mazos2.Add(OS5);
            mazos2.Add(OS15);
            mazos2.Add(OS25);
            mazos2.Add(BO5);
            mazos2.Add(BO15);
            mazos2.Add(BO25);
            mazos2.Add(WG5);
            mazos2.Add(WG15);
            mazos2.Add(WG25);
            mazos2.Add(CH5);
            mazos2.Add(CH15);
            mazos2.Add(CH25);
            mazos2.Shuffle();
            spells carta0 = new spells("La Moneda", 0, false, false);


            var mazo = new Stack<carta>(mazos);

            var mazo2 = new Stack<carta>(mazos2);


            /*Contadores*/
            int mana1 = 1;
            int mana2 = 1;
            int manatotal = 1;
            int manatotal2 = 1;
            /*Listas Vacias que son las manos*/
            List<carta> manos = new List<carta>();
            List<carta> manos2 = new List<carta>();
            List<minion> cartascancha = new List<minion>();
            List<minion> cartascancha2 = new List<minion>();
            /*Se crean los jugadores */
            Heroe j1 = new Heroe(null, null, manos, mazo);
            Heroe j2 = new Heroe(null, null, manos2, mazo2);
            string opcionj1;
            string opcionj2;
            
            Random rnd = new Random();
            int partida = rnd.Next(2);



            string opcion2;
            string opcion3;
            string nombre1;
            string nombre2;
            /*mano incial de 3 HAY QUE VER QUIEN PARTE*/

            for (int i = 0; i < 3; i++)
            {
                j1.darcarta();


            }
            for (int i = 0; i < 3; i++)
            {
                j2.darcarta();

            }


            Console.WriteLine("---------------------------------\n Jugador 1: Escribe  Tu Nombre \n---------------------------------\n");
            nombre1 = Console.ReadLine();
            Console.WriteLine("\n---------------------------------\n Jugador 2: Escribe  Tu Nombre \n---------------------------------\n");
            nombre2 = Console.ReadLine();


            Console.WriteLine("---------------------------------\n Jugador 1: Elige tu Heroe\n---------------------------------\n(1) Warrior \n(2) Hunter\n---------------------------------");
            opcionj1 = Console.ReadLine();


            Console.WriteLine("---------------------------------\n Jugador 2: Elige tu Heroe\n---------------------------------\n(1) Warrior \n(2) Hunter\n---------------------------------");
            opcionj2 = Console.ReadLine();


            if (partida == 0)
            {

                switch (opcionj1)
                {

                    case "1":
                        Console.WriteLine(nombre1 + " has elegido a Warrior como tu heroe");
                        j1.ingresarnombre(nombre1);
                        j1.ingresartipo("Warrior");
                        break;

                    case "2":
                        Console.WriteLine(nombre1 + " has elegido a Hunter como tu heroe");
                        j1.ingresarnombre(nombre1);
                        j1.ingresartipo("Hunter");
                        break;

                }


                switch (opcionj2)
                {

                    case "1":
                        Console.WriteLine(nombre2 + " has elegido a Warrior como tu heroe");
                        j2.ingresarnombre(nombre2);
                        j2.ingresartipo("Warrior");


                        break;

                    case "2":
                        Console.WriteLine(nombre2 + " has elegido a Hunter como tu heroe");
                        j2.ingresarnombre(nombre2);
                        j2.ingresartipo("Hunter");

                        break;
                }




                Console.WriteLine("\n" + j1.nombre + ", ¿Que carta deseas cambiar?\n");

                for (int i = 0; i < 3; i++)
                {
                    int contmano = 1;
                    Console.WriteLine(j1.nombre + " tu mano es la siguiente: ");
                    foreach (carta n in j1.mano)
                    {

                        Console.WriteLine("(" + contmano + ")" + n.nombre + " / Costo de Mana: " + n.mana);
                        contmano = contmano + 1;

                    }
                    Console.WriteLine("(0)Si no deseas devolver mas cartas");

                    int dev = Convert.ToInt32(Console.ReadLine());
                    if (dev == 0) { break; }
                    j1.devolvercarta(dev);
                }
                while (j1.mano.Count < 3)
                {
                    j1.darcarta();
                }

                Console.WriteLine("\n" + j2.nombre + ", ¿Que carta deseas cambiar?\n");

                for (int i = 0; i < 3; i++)
                {
                    int contmano = 1;
                    Console.WriteLine(j2.nombre + " tu mano es la siguiente: ");
                    foreach (carta n in j2.mano)
                    {

                        Console.WriteLine("(" + contmano + ")" + n.nombre + " / Costo de Mana: " + n.mana);
                        contmano = contmano + 1;

                    }
                    Console.WriteLine("(0)Si no deseas devolver mas cartas");
                    int dev = Convert.ToInt32(Console.ReadLine());

                    if (dev == 0) { break; }
                    j2.devolvercarta(dev);
                }
                while (j2.mano.Count < 3)
                {
                    j2.darcarta();
                }






                Console.WriteLine("--------------------------------------------------");


                j2.mano.Add(carta0);

                bool carta = true;
                bool carta2 = true;

                bool poder1 = true;
                bool poder2 = true;


                bool muerte1 = false;
                bool muerte2 = false;

                /*PARTE EL JUEGO*/
                while (true)
                {
                    while (true)
                    {
                        Console.WriteLine("---------------------------------\n" + j1.nombre + "  es tu turno!");
                        Console.WriteLine(j1.nombre + " - " + j1.tipo + "\nVida: " + j1.vida + " - Armadura: " + j1.escudo + "\nLa vida del heroe de " + j2.nombre + " es: " + j2.vida + " - Armadura: " + j2.escudo);
                        Console.WriteLine(j1.nombre + " tu mana total es de: " + manatotal);
                        Console.WriteLine(j1.nombre + " tu mana disponible en el turno: " + mana1);
                        Console.WriteLine(j1.nombre + " tus cartas en cancha son las siguientes:  ");
                        int x = 1;
                        foreach (minion n in mazos)
                        {
                            if (n.actividad == true)
                            {
                                Console.WriteLine("(" + x + ")");
                                n.Describir();
                                x = x + 1;
                            }

                        }
                        Console.WriteLine("Las cartas en cancha de " + j2.nombre + " son las siguientes:  ");
                        int t = 1;
                        foreach (minion n in mazos2)
                        {
                            if (n.actividad == true)
                            {
                                Console.WriteLine("(" + t + ")");
                                n.Describir();
                                t = t + 1;
                            }
                        }

                        Console.WriteLine("¿Que deseas hacer?\n---------------------------------\n(1) Jugar Carta de la mano \n(2) Atacar\n(3) Habilidad Heroe/Utiliza 2 de Mana/\n(4) Terminar Turno\n(5) Comunicarse \n(0) Rendirse\n---------------------------------");

                        opcion2 = Console.ReadLine();

                        if (mana1 == 1 && carta == true)
                        {
                            j1.darcarta();
                            carta = false;
                        }
                        if (opcion2 == "1")
                            if (cartascancha.Count() < 7)
                            {

                                {
                                    Console.WriteLine("---------------------------------\n" + j1.nombre + " tu mano consiste de las siguientes cartas, ¿Que carta deseas ocupar?\n---------------------------------");
                                    int z = 1;
                                    foreach (minion i in j1.mano)
                                    {

                                        Console.WriteLine("(" + z + ")");
                                        i.Describir();

                                        z = z + 1;
                                    }
                                    Console.WriteLine("(0) Si deseas regresar al menu anterior");
                                    int a = Convert.ToInt32(Console.ReadLine());
                                    string hi;
                                    if (a > j1.mano.Count())
                                    {
                                        Console.WriteLine("PARTE DENUEVO COMPADRE");
                                        continue;
                                    }

                                    if (a == 0)
                                    {
                                        continue;
                                    }

                                    if (j1.mano[a - 1].mana <= mana1)
                                    {
                                        mana1 = mana1 - j1.mano[a - 1].mana;
                                        Console.WriteLine("---------------------------------\n" + j1.nombre + " has elegido la carta " + j1.mano[a - 1].nombre + "\n---------------------------------");
                                        (j1.mano[a - 1]).cambiarActividad();
                                        carta cc = j1.mano[a - 1];
                                        if (cc.GetType().Equals(typeof(minion)))
                                        {
                                            minion p = (minion)j1.mano[a - 1];
                                            cartascancha.Add(p);
                                        }


                                        j1.mano.RemoveAt(a - 1);



                                    }

                                }
                            }
                        if (opcion2 == "2")
                        {
                            int re = 1;
                            Console.WriteLine("¿Que carta quieres que ataque?");
                            foreach (minion a in mazos)
                            {
                                if (a.actividad == true && a.visibilidad == true && a.turno == true)
                                {

                                    Console.WriteLine("(" + re + ")" + cartascancha[re - 1].nombre);

                                    re = re + 1;
                                }

                            }
                            Console.WriteLine("(0)Para regresar al menu");
                            int ata = Convert.ToInt32(Console.ReadLine());
                            if (ata == 0)
                            {
                                continue;

                            }

                            Console.WriteLine("¿Que carta quieres atacar?");
                            int z = 1;
                            foreach (minion n in mazos2)
                            {
                                if (n.actividad == true)
                                {
                                    Console.WriteLine("(" + z + ")" + cartascancha2[z - 1].nombre);
                                    ;
                                    z = z + 1;
                                }

                            }
                            Console.WriteLine("(8)Para regresar al menu");
                            Console.WriteLine("(0) Atacar heroe de " + j2.nombre);


                            int ati = Convert.ToInt32(Console.ReadLine());
                            if (ati == 8) { continue; }
                            if (ati == 0)
                            {
                                cartascancha[ata - 1].attack(null, j2);
                                cartascancha[ata - 1].turno = false;
                                if (j2.vida <= 0)
                                {
                                    j2.Rendirse(j2.vida);
                                }
                                j2.Describir();
                                continue;
                            }

                            if (cartascancha[ata - 1].turno == true)
                            {
                                cartascancha[ata - 1].Describir();
                                cartascancha2[ati - 1].Describir();
                                cartascancha[ata - 1].attack(cartascancha2[ati - 1], null);
                                cartascancha[ata - 1].turno = false;
                                if (cartascancha2[ati - 1].vida <= 0)
                                {
                                    cartascancha2[ati - 1].vida = 0;
                                    cartascancha2[ati - 1].cambiarActividad();
                                    cartascancha2[ati - 1].cambiarVisibilidad();
                                    cartascancha2[ati - 1].turno = false;
                                    cartascancha2.RemoveAt(ati - 1);
                                }
                                if (cartascancha[ata - 1].vida <= 0)
                                {
                                    cartascancha[ata - 1].vida = 0;
                                    cartascancha[ata - 1].cambiarActividad();
                                    cartascancha[ata - 1].cambiarVisibilidad();
                                    cartascancha[ata - 1].turno = false;
                                    cartascancha.RemoveAt(ata - 1);
                                }
                            }

                        }
                        if (opcion2 == "3" && poder1 == true)
                        {
                            if (mana1 > 1)
                            {

                                mana1 = mana1 - 2;


                                j1.habilidad(j2);
                                poder1 = false;

                                /*Habilidad heroe*/
                            }
                        }
                        if (opcion2 == "4")
                        {
                            poder1 = true;
                            if (manatotal < 10)
                            {
                                manatotal = manatotal + 1;
                            }
                            mana1 = manatotal;
                            if (j1.mano.Count() < 10)
                            {
                                j1.darcarta();
                            }
                            if (j1.mano.Count() > 10)
                            {
                                j1.QuemarMano();

                            }
                            foreach (minion n in mazos)
                            {
                                if (n.visibilidad == true && n.actividad == true && n.turno == false)
                                {
                                    n.CambiarTurno();
                                }
                            }
                            break;
                            /*terminar turno*/
                        }

                        if (opcion2 == "5")
                        {
                            Console.WriteLine("---------------------------------\n¿Que deseas decir?\n---------------------------------\n(1) OOOPS\n(2) Amenaza\n(3) Saludar \n(4) Llorar\n(5) Celebarar\n---------------------------------");
                            string p = Console.ReadLine();
                            Console.WriteLine(j1.nombre + " dice: ");
                            j1.Comunicarse(p);
                            Console.WriteLine(" ");
                        }

                        if (opcion2 == "0")
                        {
                            j1.Rendirse(j1.vida);
                            muerte1 = true;
                            break;
                        }

                    }
                    if (muerte1 == true)
                    {
                        Console.Read();
                        break;
                    }
                    while (true)
                    {
                        Console.WriteLine("---------------------------------\n" + j2.nombre + "  es tu turno!");
                        Console.WriteLine(j2.nombre + " - " + j2.tipo + "\nVida: " + j2.vida + " - Armadura: " + j2.escudo + "\nLa vida del heroe de " + j1.nombre + " es: " + j1.vida + " - Armadura: " + j1.escudo);
                        Console.WriteLine(j2.nombre + " tu mana total es de: " + manatotal2);
                        Console.WriteLine(j2.nombre + " tu mana disponible en el turno: " + mana2);
                        Console.WriteLine(j2.nombre + " tus cartas en cancha son las siguientes:  ");
                        int x = 1;
                        foreach (minion n in mazos2)
                        {
                            if (n.actividad == true)
                            {
                                Console.WriteLine("(" + x + ")");
                                n.Describir();
                                x = x + 1;
                            }

                        }

                        Console.WriteLine("Las cartas en cancha de " + j1.nombre + " son las siguientes: ");
                        int y = 1;
                        foreach (minion n in mazos)
                        {
                            if (n.actividad == true)
                            {
                                Console.WriteLine("(" + y + ")");
                                n.Describir();
                                y = y + 1;
                            }
                        }

                        Console.WriteLine("¿Que deseas hacer?\n---------------------------------\n(1) Jugar Carta de la mano \n(2) Atacar\n(3) Habilidad Heroe/Utiliza 2 de Mana/\n(4) Terminar Turno\n(5) Comunicarse \n(0) Rendirse\n---------------------------------");

                        opcion2 = Console.ReadLine();

                        if (carta2 == true && mana2 == 1)
                        {
                            j2.darcarta();
                            carta2 = false;
                        }
                        if (opcion2 == "1")
                        {
                            if (cartascancha.Count() < 7)
                            {
                                Console.WriteLine("---------------------------------\n" + j2.nombre + "tu mano consiste de las siguientes cartas, ¿Que carta deseas ocupar?\n---------------------------------");
                                int z = 1;
                                foreach (carta i in j2.mano)
                                {
                                    Console.WriteLine("(" + z + ")");
                                    i.Describir();
                                    z = z + 1;
                                }
                                Console.WriteLine("(0) Si deseas regresar al menu anterior");
                                int a = Convert.ToInt32(Console.ReadLine());


                                if (a > j2.mano.Count())
                                {
                                    Console.WriteLine("PARTE DENUEVO COMPADRE");
                                    continue;
                                }

                                if (a == 0)
                                {
                                    continue;
                                }

                                if (j2.mano[a - 1].mana <= mana2)
                                {
                                    mana2 = mana2 - j2.mano[a - 1].mana;
                                    Console.WriteLine("---------------------------------\n" + j2.nombre + "  has elegido la carta   " + j2.mano[a - 1].nombre + "\n---------------------------------");

                                    (j2.mano[a - 1]).cambiarActividad();
                                    carta cc = j2.mano[a - 1];
                                    if (cc.GetType().Equals(typeof(minion)))
                                    {
                                        minion p = (minion)j2.mano[a - 1];
                                        cartascancha2.Add(p);

                                    }
                                    if (cc.GetType().Equals(typeof(spells)))
                                    {
                                        spells p = (spells)j2.mano[a - 1];
                                        mana2 = mana2 + 1;


                                    }

                                    j2.mano.RemoveAt(a - 1);
                                }

                            }
                        }
                        if (opcion2 == "2")
                        {
                            int re = 1;
                            Console.WriteLine("¿Que carta quieres que ataque?");
                            foreach (minion a in mazos2)
                            {
                                if (a.actividad == true && a.visibilidad == true && a.turno == true)
                                {

                                    Console.WriteLine("(" + re + ")" + cartascancha2[re - 1].nombre);

                                    re = re + 1;
                                }

                            }
                            Console.WriteLine("(0)Para regresar al menu");
                            int ata = Convert.ToInt32(Console.ReadLine());
                            if (ata == 0)
                            {
                                continue;
                            }


                            Console.WriteLine("¿Que carta quieres atacar?");
                            int z = 1;
                            foreach (minion n in mazos)
                            {
                                if (n.actividad == true)
                                {
                                    Console.WriteLine("(" + z + ")" + cartascancha[z - 1].nombre);
                                    ;
                                    z = z + 1;
                                }

                            }
                            Console.WriteLine("(0) Atacar Heroe de: " + j1.nombre);
                            Console.WriteLine("(8) Para regresar al menu");
                            int ati = Convert.ToInt32(Console.ReadLine());
                            if (ati == 8)
                            {
                                continue;
                            }
                            if (ati == 0)
                            {
                                cartascancha2[ata - 1].attack(null, j1);
                                cartascancha2[ata - 1].turno = false;
                                if (j1.vida <= 0)
                                {
                                    j1.Rendirse(j1.vida);
                                }
                                j1.Describir();
                                continue;

                            }
                            if (cartascancha2[ata - 1].turno == true)
                            {
                                cartascancha2[ata - 1].Describir();
                                cartascancha[ati - 1].Describir();
                                cartascancha2[ata - 1].attack(cartascancha[ati - 1], null);
                                cartascancha2[ata - 1].turno = false;

                                if (cartascancha[ati - 1].vida <= 0)
                                {
                                    cartascancha[ati - 1].vida = 0;
                                    cartascancha[ati - 1].cambiarActividad();
                                    cartascancha[ati - 1].cambiarVisibilidad();
                                    cartascancha[ati - 1].turno = false;
                                    cartascancha.RemoveAt(ati - 1);
                                }
                                if (cartascancha2[ata - 1].vida <= 0)
                                {
                                    cartascancha2[ata - 1].vida = 0;
                                    cartascancha2[ata - 1].cambiarActividad();
                                    cartascancha2[ata - 1].cambiarVisibilidad();
                                    cartascancha2[ata - 1].turno = false;
                                    cartascancha2.RemoveAt(ata - 1);
                                }










                            }





                        }
                        if (opcion2 == "3" && poder2 == true)
                        {
                            if (mana2 > 1)
                            {
                                mana2 = mana2 - 2;


                                j2.habilidad(j1);
                                poder2 = false;

                            }
                        }
                        if (opcion2 == "4")
                        {
                            poder2 = true;
                            if (manatotal2 < 10)
                            {
                                manatotal2 = manatotal2 + 1;
                            }
                            mana2 = manatotal2;
                            if (j2.mano.Count() < 10)
                            {
                                j2.darcarta();
                            }
                            if (j2.mano.Count() > 10)
                            {
                                j2.QuemarMano();

                            }


                            foreach (minion n in mazos2)
                            {
                                if (n.visibilidad == true && n.actividad == true && n.turno == false)
                                {
                                    n.CambiarTurno();
                                }
                            }


                            break;
                            /*terminar turno*/
                        }
                        if (opcion2 == "5")
                        {
                            Console.WriteLine("---------------------------------\n¿Que deseas decir?\n---------------------------------\n(1) OOOPS\n(2) Amenaza\n(3) Saludar \n(4) Llorar\n(5) Celebarar\n---------------------------------");
                            string p = Console.ReadLine();
                            Console.WriteLine(j2.nombre + " dice: ");
                            j2.Comunicarse(p);
                            Console.WriteLine(" ");
                        }


                        if (opcion2 == "0")
                        {
                            j2.Rendirse(j2.vida);
                            muerte2 = true;
                            break;

                        }
                    }

                    if (muerte2 == true)
                    {
                        Console.Read();
                        break;
                    }
                }
            }

            if (partida == 1)
            {

                switch (opcionj1)
                {

                    case "1":
                        Console.WriteLine(nombre2 + " has elegido a Warrior como tu heroe");
                        j2.ingresarnombre(nombre2);
                        j2.ingresartipo("Warrior");
                        break;

                    case "2":
                        Console.WriteLine(nombre2 + " has elegido a Hunter como tu heroe");
                        j2.ingresarnombre(nombre2);
                        j2.ingresartipo("Hunter");
                        break;

                }


                switch (opcionj2)
                {

                    case "1":
                        Console.WriteLine(nombre1 + " has elegido a Warrior como tu heroe");
                        j1.ingresarnombre(nombre1);
                        j1.ingresartipo("Warrior");


                        break;

                    case "2":
                        Console.WriteLine(nombre1 + " has elegido a Hunter como tu heroe");
                        j1.ingresarnombre(nombre1);
                        j1.ingresartipo("Hunter");

                        break;
                }




                Console.WriteLine("\n" + j2.nombre + ", ¿Que carta deseas cambiar?\n");/*aca vamos!!!!*/

                for (int i = 0; i < 3; i++)
                {
                    int contmano = 1;
                    Console.WriteLine(j2.nombre + " tu mano es la siguiente: ");
                    foreach (carta n in j2.mano)
                    {

                        Console.WriteLine("(" + contmano + ")" + n.nombre + " / Costo de Mana: " + n.mana);
                        contmano = contmano + 1;

                    }
                    Console.WriteLine("(0)Si no deseas devolver mas cartas");

                    int dev = Convert.ToInt32(Console.ReadLine());
                    if (dev == 0) { break; }
                    j2.devolvercarta(dev);
                }
                while (j2.mano.Count < 3)
                {
                    j2.darcarta();
                }

                Console.WriteLine("\n" + j1.nombre + ", ¿Que carta deseas cambiar?\n");

                for (int i = 0; i < 3; i++)
                {
                    int contmano = 1;
                    Console.WriteLine(j1.nombre + " tu mano es la siguiente: ");
                    foreach (carta n in j1.mano)
                    {

                        Console.WriteLine("(" + contmano + ")" + n.nombre + " / Costo de Mana: " + n.mana);
                        contmano = contmano + 1;

                    }
                    Console.WriteLine("(0)Si no deseas devolver mas cartas");
                    int dev = Convert.ToInt32(Console.ReadLine());

                    if (dev == 0) { break; }
                    j1.devolvercarta(dev);
                }
                while (j1.mano.Count < 3)
                {
                    j1.darcarta();
                }






                Console.WriteLine("--------------------------------------------------");


                j1.mano.Add(carta0);

                bool carta = true;
                bool carta2 = true;

                bool poder1 = true;
                bool poder2 = true;


                bool muerte1 = false;
                bool muerte2 = false;

                /*PARTE EL JUEGO*/
                while (true)
                {
                    while (true)
                    {
                        Console.WriteLine("---------------------------------\n" + j2.nombre + "  es tu turno!");
                        Console.WriteLine(j2.nombre + " - " + j2.tipo + "\nVida: " + j2.vida + " - Armadura: " + j2.escudo + "\nLa vida del heroe de " + j1.nombre + " es: " + j1.vida + " - Armadura: " + j1.escudo);
                        Console.WriteLine(j2.nombre + " tu mana total es de: " + manatotal);
                        Console.WriteLine(j2.nombre + " tu mana disponible en el turno: " + mana1);
                        Console.WriteLine(j2.nombre + " tus cartas en cancha son las siguientes:  ");
                        int x = 1;
                        foreach (minion n in mazos)
                        {
                            if (n.actividad == true)
                            {
                                Console.WriteLine("(" + x + ")");
                                n.Describir();
                                x = x + 1;
                            }

                        }
                        Console.WriteLine("Las cartas en cancha de " + j1.nombre + " son las siguientes:  ");
                        int t = 1;
                        foreach (minion n in mazos2)
                        {
                            if (n.actividad == true)
                            {
                                Console.WriteLine("(" + t + ")");
                                n.Describir();
                                t = t + 1;
                            }
                        }

                        Console.WriteLine("¿Que deseas hacer?\n---------------------------------\n(1) Jugar Carta de la mano \n(2) Atacar\n(3) Habilidad Heroe/Utiliza 2 de Mana/\n(4) Terminar Turno\n(5) Comunicarse \n(0) Rendirse\n---------------------------------");

                        opcion2 = Console.ReadLine();

                        if (mana1 == 1 && carta == true)
                        {
                            j2.darcarta();
                            carta = false;
                        }
                        if (opcion2 == "1")
                            if (cartascancha.Count() < 7)
                            {

                                {
                                    Console.WriteLine("---------------------------------\n" + j2.nombre + " tu mano consiste de las siguientes cartas, ¿Que carta deseas ocupar?\n---------------------------------");
                                    int z = 1;
                                    foreach (carta i in j1.mano)
                                    {

                                        Console.WriteLine("(" + z + ")");
                                        i.Describir();

                                        z = z + 1;
                                    }
                                    Console.WriteLine("(0) Si deseas regresar al menu anterior");
                                    int a = Convert.ToInt32(Console.ReadLine());
                                    string hi;
                                    if (a > j2.mano.Count())
                                    {
                                        Console.WriteLine("PARTE DENUEVO COMPADRE");
                                        continue;
                                    }

                                    if (a == 0)
                                    {
                                        continue;
                                    }

                                    if (j2.mano[a - 1].mana <= mana1)
                                    {
                                        mana1 = mana1 - j2.mano[a - 1].mana;
                                        Console.WriteLine("---------------------------------\n" + j2.nombre + " has elegido la carta " + j2.mano[a - 1].nombre + "\n---------------------------------");
                                        (j2.mano[a - 1]).cambiarActividad();
                                        carta cc = j2.mano[a - 1];
                                        if (cc.GetType().Equals(typeof(spells)))
                                        {
                                            spells p = (spells)j2.mano[a - 1];
                                            mana1 = mana1 + 1;


                                        }

                                        if (cc.GetType().Equals(typeof(minion)))
                                        {
                                            minion p = (minion)j2.mano[a - 1];
                                            cartascancha.Add(p);
                                        }

                                        j2.mano.RemoveAt(a - 1);



                                    }

                                }
                            }
                        if (opcion2 == "2")
                        {
                            int re = 1;
                            Console.WriteLine("¿Que carta quieres que ataque?");
                            foreach (minion a in mazos)
                            {
                                if (a.actividad == true && a.visibilidad == true && a.turno == true)
                                {

                                    Console.WriteLine("(" + re + ")" + cartascancha[re - 1].nombre);

                                    re = re + 1;
                                }

                            }
                            Console.WriteLine("(0)Para regresar al menu");
                            int ata = Convert.ToInt32(Console.ReadLine());
                            if (ata == 0)
                            {
                                continue;

                            }

                            Console.WriteLine("¿Que carta quieres atacar?");
                            int z = 1;
                            foreach (minion n in mazos2)
                            {
                                if (n.actividad == true)
                                {
                                    Console.WriteLine("(" + z + ")" + cartascancha2[z - 1].nombre);
                                    ;
                                    z = z + 1;
                                }

                            }
                            Console.WriteLine("(8)Para regresar al menu");
                            Console.WriteLine("(0) Atacar heroe de " + j1.nombre);


                            int ati = Convert.ToInt32(Console.ReadLine());
                            if (ati == 8) { continue; }
                            if (ati == 0)
                            {
                                cartascancha[ata - 1].attack(null, j2);
                                cartascancha[ata - 1].turno = false;
                                if (j1.vida <= 0)
                                {
                                    j1.Rendirse(j1.vida);
                                }
                                j1.Describir();
                                continue;
                            }

                            if (cartascancha[ata - 1].turno == true)
                            {
                                cartascancha[ata - 1].Describir();
                                cartascancha2[ati - 1].Describir();
                                cartascancha[ata - 1].attack(cartascancha2[ati - 1], null);
                                cartascancha[ata - 1].turno = false;
                                if (cartascancha2[ati - 1].vida <= 0)
                                {
                                    cartascancha2[ati - 1].vida = 0;
                                    cartascancha2[ati - 1].cambiarActividad();
                                    cartascancha2[ati - 1].cambiarVisibilidad();
                                    cartascancha2[ati - 1].turno = false;
                                    cartascancha2.RemoveAt(ati - 1);
                                }
                                if (cartascancha[ata - 1].vida <= 0)
                                {
                                    cartascancha[ata - 1].vida = 0;
                                    cartascancha[ata - 1].cambiarActividad();
                                    cartascancha[ata - 1].cambiarVisibilidad();
                                    cartascancha[ata - 1].turno = false;
                                    cartascancha.RemoveAt(ata - 1);
                                }
                            }

                        }
                        if (opcion2 == "3" && poder1 == true)
                        {
                            if (mana1 > 1)
                            {

                                mana1 = mana1 - 2;


                                j2.habilidad(j1);
                                poder1 = false;

                                /*Habilidad heroe*/
                            }
                        }
                        if (opcion2 == "4")
                        {
                            poder1 = true;
                            if (manatotal < 10)
                            {
                                manatotal = manatotal + 1;
                            }
                            mana1 = manatotal;
                            if (j2.mano.Count() < 10)
                            {
                                j2.darcarta();
                            }
                            if (j2.mano.Count() > 10)
                            {
                                j2.QuemarMano();

                            }
                            foreach (minion n in mazos)
                            {
                                if (n.visibilidad == true && n.actividad == true && n.turno == false)
                                {
                                    n.CambiarTurno();
                                }
                            }
                            break;
                            /*terminar turno*/
                        }

                        if (opcion2 == "5")
                        {
                            Console.WriteLine("---------------------------------\n¿Que deseas decir?\n---------------------------------\n(1) OOOPS\n(2) Amenaza\n(3) Saludar \n(4) Llorar\n(5) Celebarar\n---------------------------------");
                            string p = Console.ReadLine();
                            Console.WriteLine(j2.nombre + " dice: ");
                            j1.Comunicarse(p);
                            Console.WriteLine(" ");
                        }

                        if (opcion2 == "0")
                        {
                            j2.Rendirse(j2.vida);
                            muerte1 = true;
                            break;
                        }

                    }
                    if (muerte1 == true)
                    {
                        Console.Read();
                        break;
                    }
                    while (true)
                    {
                        Console.WriteLine("---------------------------------\n" + j1.nombre + "  es tu turno!");
                        Console.WriteLine(j1.nombre + " - " + j1.tipo + "\nVida: " + j1.vida + " - Armadura: " + j1.escudo + "\nLa vida del heroe de " + j2.nombre + " es: " + j2.vida + " - Armadura: " + j2.escudo);
                        Console.WriteLine(j1.nombre + " tu mana total es de: " + manatotal2);
                        Console.WriteLine(j1.nombre + " tu mana disponible en el turno: " + mana2);
                        Console.WriteLine(j1.nombre + " tus cartas en cancha son las siguientes:  ");
                        int x = 1;
                        foreach (minion n in mazos2)
                        {
                            if (n.actividad == true)
                            {
                                Console.WriteLine("(" + x + ")");
                                n.Describir();
                                x = x + 1;
                            }

                        }

                        Console.WriteLine("Las cartas en cancha de " + j2.nombre + " son las siguientes: ");
                        int y = 1;
                        foreach (minion n in mazos)
                        {
                            if (n.actividad == true)
                            {
                                Console.WriteLine("(" + y + ")");
                                n.Describir();
                                y = y + 1;
                            }
                        }

                        Console.WriteLine("¿Que deseas hacer?\n---------------------------------\n(1) Jugar Carta de la mano \n(2) Atacar\n(3) Habilidad Heroe/Utiliza 2 de Mana/\n(4) Terminar Turno\n(5) Comunicarse \n(0) Rendirse\n---------------------------------");

                        opcion2 = Console.ReadLine();

                        if (carta2 == true && mana2 == 1)
                        {
                            j1.darcarta();
                            carta2 = false;
                        }
                        if (opcion2 == "1")
                        {
                            if (cartascancha.Count() < 7)
                            {
                                Console.WriteLine("---------------------------------\n" + j1.nombre + "tu mano consiste de las siguientes cartas, ¿Que carta deseas ocupar?\n---------------------------------");
                                int z = 1;
                                foreach (carta i in j1.mano)
                                {
                                    Console.WriteLine("(" + z + ")");
                                    i.Describir();
                                    z = z + 1;
                                }
                                Console.WriteLine("(0) Si deseas regresar al menu anterior");
                                int a = Convert.ToInt32(Console.ReadLine());


                                if (a > j1.mano.Count())
                                {
                                    Console.WriteLine("PARTE DENUEVO COMPADRE");
                                    continue;
                                }

                                if (a == 0)
                                {
                                    continue;
                                }

                                if (j1.mano[a - 1].mana <= mana2)
                                {
                                    mana2 = mana2 - j1.mano[a - 1].mana;
                                    Console.WriteLine("---------------------------------\n" + j1.nombre + "  has elegido la carta   " + j1.mano[a - 1].nombre + "\n---------------------------------");

                                    (j1.mano[a - 1]).cambiarActividad();
                                    carta cc = j1.mano[a - 1];
                                    if (cc.GetType().Equals(typeof(minion)))
                                    {
                                        minion p = (minion)j1.mano[a - 1];
                                        cartascancha2.Add(p);

                                    }
                                    if (cc.GetType().Equals(typeof(spells)))
                                    {
                                        spells p = (spells)j1.mano[a - 1];
                                        mana2 = mana2 + 1;


                                    }

                                    j1.mano.RemoveAt(a - 1);
                                }

                            }
                        }
                        if (opcion2 == "2")
                        {
                            int re = 1;
                            Console.WriteLine("¿Que carta quieres que ataque?");
                            foreach (minion a in mazos2)
                            {
                                if (a.actividad == true && a.visibilidad == true && a.turno == true)
                                {

                                    Console.WriteLine("(" + re + ")" + cartascancha2[re - 1].nombre);

                                    re = re + 1;
                                }

                            }
                            Console.WriteLine("(0)Para regresar al menu");
                            int ata = Convert.ToInt32(Console.ReadLine());
                            if (ata == 0)
                            {
                                continue;
                            }


                            Console.WriteLine("¿Que carta quieres atacar?");
                            int z = 1;
                            foreach (minion n in mazos)
                            {
                                if (n.actividad == true)
                                {
                                    Console.WriteLine("(" + z + ")" + cartascancha[z - 1].nombre);
                                    ;
                                    z = z + 1;
                                }

                            }
                            Console.WriteLine("(0) Atacar Heroe de: " + j2.nombre);
                            Console.WriteLine("(8) Para regresar al menu");
                            int ati = Convert.ToInt32(Console.ReadLine());
                            if (ati == 8)
                            {
                                continue;
                            }
                            if (ati == 0)
                            {
                                cartascancha2[ata - 1].attack(null, j1);
                                cartascancha2[ata - 1].turno = false;
                                if (j2.vida <= 0)
                                {
                                    j2.Rendirse(j2.vida);
                                }
                                j2.Describir();
                                continue;

                            }
                            if (cartascancha2[ata - 1].turno == true)
                            {
                                cartascancha2[ata - 1].Describir();
                                cartascancha[ati - 1].Describir();
                                cartascancha2[ata - 1].attack(cartascancha[ati - 1], null);
                                cartascancha2[ata - 1].turno = false;

                                if (cartascancha[ati - 1].vida <= 0)
                                {
                                    cartascancha[ati - 1].vida = 0;
                                    cartascancha[ati - 1].cambiarActividad();
                                    cartascancha[ati - 1].cambiarVisibilidad();
                                    cartascancha[ati - 1].turno = false;
                                    cartascancha.RemoveAt(ati - 1);
                                }
                                if (cartascancha2[ata - 1].vida <= 0)
                                {
                                    cartascancha2[ata - 1].vida = 0;
                                    cartascancha2[ata - 1].cambiarActividad();
                                    cartascancha2[ata - 1].cambiarVisibilidad();
                                    cartascancha2[ata - 1].turno = false;
                                    cartascancha2.RemoveAt(ata - 1);
                                }










                            }





                        }
                        if (opcion2 == "3" && poder2 == true)
                        {
                            if (mana2 > 1)
                            {
                                mana2 = mana2 - 2;


                                j1.habilidad(j2);
                                poder2 = false;

                            }
                        }
                        if (opcion2 == "4")
                        {
                            poder2 = true;
                            if (manatotal2 < 10)
                            {
                                manatotal2 = manatotal2 + 1;
                            }
                            mana2 = manatotal2;
                            if (j1.mano.Count() < 10)
                            {
                                j1.darcarta();
                            }
                            if (j1.mano.Count() > 10)
                            {
                                j1.QuemarMano();

                            }


                            foreach (minion n in mazos2)
                            {
                                if (n.visibilidad == true && n.actividad == true && n.turno == false)
                                {
                                    n.CambiarTurno();
                                }
                            }


                            break;
                            /*terminar turno*/
                        }
                        if (opcion2 == "5")
                        {
                            Console.WriteLine("---------------------------------\n¿Que deseas decir?\n---------------------------------\n(1) OOOPS\n(2) Amenaza\n(3) Saludar \n(4) Llorar\n(5) Celebarar\n---------------------------------");
                            string p = Console.ReadLine();
                            Console.WriteLine(j1.nombre + " dice: ");
                            j1.Comunicarse(p);
                            Console.WriteLine(" ");
                        }


                        if (opcion2 == "0")
                        {
                            j1.Rendirse(j1.vida);
                            muerte2 = true;
                            break;

                        }
                    }

                    if (muerte2 == true)
                    {
                        Console.Read();
                        break;
                    }
                }
            }

        }
    }
    public static class ThreadSafeRandom
    {
        [ThreadStatic]
        private static Random Local;

        public static Random ThisThreadsRandom
        {
            get { return Local ?? (Local = new Random(unchecked(Environment.TickCount * 31 + Thread.CurrentThread.ManagedThreadId))); }
        }
    }

    static class MyExtensions
    {
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = ThreadSafeRandom.ThisThreadsRandom.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

    }

}



