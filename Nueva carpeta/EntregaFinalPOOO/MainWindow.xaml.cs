using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;

namespace EntregaFinalPOOO
{


    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string a;
        string a1;
        minion w = new minion("wisp", 1, 1, false, false, 0);
        minion w1 = new minion("wisp", 1, 1, false, false, 0);
        minion w2 = new minion("wisp", 1, 1, false, false, 0);
        minion m = new minion("Murloc Raider", 2, 1, false, false, 1);
        minion m1 = new minion("Murloc Raider", 2, 1, false, false, 1);
        minion m2 = new minion("Murloc Raider", 2, 1, false, false, 1);
        minion b9 = new minion("Bloodfen Raptor", 3, 2, false, false, 2);
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

        List<Button> a2 = new List<Button>();
        List<Button> xx = new List<Button>();

        spells carta0 = new spells("La Moneda", 0, false, false);


        List<carta> manos = new List<carta>();
        List<carta> manos2 = new List<carta>();

        List<minion> cartascancha = new List<minion>();
        List<minion> cartascancha2 = new List<minion>();
        List<minion> shaman = new List<minion>();
        List<minion> shaman2 = new List<minion>();

        Heroe j1 = new Heroe(null, null, null, null, 1, 1,true);
        Heroe j2 = new Heroe(null, null, null, null, 1, 1,false);

        minion atacar;
        minion atacado;


        public MainWindow()
        {
            InitializeComponent();


            foreach (Button b in stackpanel_Copy.Children)
            {
                a2.Add(b);
            }
            foreach (Button b in stackpanel.Children)
            {
                xx.Add(b);
            }


            mazos.Add(w);
            mazos.Add(w1);
            mazos.Add(w2);
            mazos.Add(m);
            mazos.Add(m1);
            mazos.Add(m2);
            mazos.Add(b9);
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

            var mazo = new Stack<carta>(mazos);
            var mazo2 = new Stack<carta>(mazos2);

            j1.ingresarmazo(mazo);
            j1.ingresarmano(manos);
            j2.ingresarmazo(mazo2);
            j2.ingresarmano(manos2);

            for (int i = 0; i < 3; i++)
            {
                j1.darcarta();
            }
            for (int i = 0; i < 3; i++)
            {
                j2.darcarta();
            }

            atacarheroe1.Visibility = Visibility.Hidden;
            atacarheroe2.Visibility = Visibility.Hidden;
            boton2.Visibility = Visibility.Hidden;
            boton3.Visibility = Visibility.Hidden;
            comboBox1.Visibility = Visibility.Hidden;
            comboBox2.Visibility = Visibility.Hidden;
            text2.Visibility = Visibility.Hidden;
            pic1.Visibility = Visibility.Hidden;
            pic2.Visibility = Visibility.Hidden;
            pic3.Visibility = Visibility.Hidden;
            pic4.Visibility = Visibility.Hidden;
            pic5.Visibility = Visibility.Hidden;
            pic6.Visibility = Visibility.Hidden;
            pic7.Visibility = Visibility.Hidden;
            pic8.Visibility = Visibility.Hidden;
            pic9.Visibility = Visibility.Hidden;
            pic10.Visibility = Visibility.Hidden;
            pic11.Visibility = Visibility.Hidden;
            pic12.Visibility = Visibility.Hidden;
            pic13.Visibility = Visibility.Hidden;
            pic14.Visibility = Visibility.Hidden;
            pic15.Visibility = Visibility.Hidden;
            pic16.Visibility = Visibility.Hidden;
            pic17.Visibility = Visibility.Hidden;
            pic18.Visibility = Visibility.Hidden;
            boton4.Visibility = Visibility.Hidden;
            boton5.Visibility = Visibility.Hidden;
            boton6.Visibility = Visibility.Hidden;
            boton7.Visibility = Visibility.Hidden;
            boton8.Visibility = Visibility.Hidden;
            boton9.Visibility = Visibility.Hidden;
            boton10.Visibility = Visibility.Hidden;
            Listbox.Visibility = Visibility.Hidden;
            FinTurno.Visibility = Visibility.Hidden;
            boton11.Visibility = Visibility.Hidden;
            boton12.Visibility = Visibility.Hidden;
            boton13.Visibility = Visibility.Hidden;
            boton14.Visibility = Visibility.Hidden;
            boton15.Visibility = Visibility.Hidden;
            boton16.Visibility = Visibility.Hidden;
            boton17.Visibility = Visibility.Hidden;
            FinTurno_Copy.Visibility = Visibility.Hidden;
            Listbox_Copy.Visibility = Visibility.Hidden;
            combobox3.Visibility = Visibility.Hidden;
            Datosj1.Visibility = Visibility.Hidden;
            datosj2.Visibility = Visibility.Hidden;
            vida1.Visibility = Visibility.Hidden;
            Vida2.Visibility = Visibility.Hidden;
            manatot1.Visibility = Visibility.Hidden;
            manatott.Visibility = Visibility.Hidden;
            manadisp.Visibility = Visibility.Hidden;
            manadisponible2.Visibility = Visibility.Hidden;
            rendirse1.Visibility = Visibility.Hidden;
            rendirse2.Visibility = Visibility.Hidden;
            datos.Visibility = Visibility.Hidden;
            combobox4.Visibility = Visibility.Hidden;
            habilidad.Visibility = Visibility.Hidden;
            habilidad2.Visibility = Visibility.Hidden;
            atacar2.Visibility = Visibility.Hidden;
            eheroe1.Visibility = Visibility.Hidden;
            eheroe2.Visibility = Visibility.Hidden;
            decir1.Visibility = Visibility.Hidden;
            decir2.Visibility = Visibility.Hidden;  

            vida1.Content = j1.vida.ToString();
            Vida2.Content = j2.vida.ToString();
            manatot1.Content = j1.manatotal.ToString();
            manatott.Content = j2.manatotal.ToString();
            manadisp.Content = j1.mana.ToString();
            manadisponible2.Content = j2.mana.ToString();




            comboBox1.Items.Add("Warrior");
            comboBox1.Items.Add("Hunter");
            comboBox1.Items.Add("Druid");
            comboBox1.Items.Add("Mage");
            comboBox1.Items.Add("Paladin");
            comboBox1.Items.Add("Priest");
            comboBox1.Items.Add("Rogue");
            comboBox1.Items.Add("Shaman");
            comboBox1.Items.Add("Warlock");

            comboBox2.Items.Add("Warrior");
            comboBox2.Items.Add("Hunter");
            comboBox2.Items.Add("Druid");
            comboBox2.Items.Add("Mage");
            comboBox2.Items.Add("Paladin");
            comboBox2.Items.Add("Priest");
            comboBox2.Items.Add("Rogue");
            comboBox2.Items.Add("Shaman");
            comboBox2.Items.Add("Warlock");

            combobox3.Items.Add("OOPS");
            combobox3.Items.Add("Amenaza");
            combobox3.Items.Add("Saludar");
            combobox3.Items.Add("Llorar");
            combobox3.Items.Add("Celebrar");

            combobox4.Items.Add("OOPS");
            combobox4.Items.Add("Amenaza");
            combobox4.Items.Add("Saludar");
            combobox4.Items.Add("Llorar");
            combobox4.Items.Add("Celebrar");

        }
        public static void Rendirese() 
        {
            Application.Current.Shutdown();
        }

        public static void DescribirHeroe(Heroe t)
        {

            MessageBox.Show("Tu nombre es: " + t.nombre + "\n Heroe: " + t.tipo + "\n Tienes vida: " + t.vida + "\nArmadura: " + t.escudo);

        }

        public static void DescribirMinion(minion m)
        {
            MessageBox.Show("Minion: " + m.nombre + "\nVida: " + m.vida + "\nAtaque: " + m.ataque + "\nCosto de mana: " + m.mana + "\n");
        }
        public static void pasarramo(int bax)
        {
            MessageBox.Show(bax.ToString());
        }
        public static void Descripcionmano(Heroe b)
        {
            foreach (minion i in b.mano)
            {

                DescribirMinion(i);
            }
        }
        public static void TusCartasCanchas(List<carta> a, Heroe t)
        {
            Consola.WriteOutput(t.nombre + " tus cartas en cancha son las siguientes:  ");
            int x = 1;
            foreach (minion n in a)
            {
                if (n.actividad == true)
                {
                    Consola.WriteOutput("(" + x + ")");
                    DescribirMinion(n);
                    x = x + 1;
                }

            }
        }

        public static void jugarcarta(int a, List<minion> lista, Heroe h)
        {
            if (h.mano[a].mana <= h.mana)
            {
                h.gastarmana(h.mano[a]);


                (h.mano[a]).cambiarActividad();
                carta cc = h.mano[a];
                if (cc.GetType().Equals(typeof(minion)))
                {
                    minion p = (minion)h.mano[a];
                    lista.Add(p);
                }


                h.mano.RemoveAt(a);




            }

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            a = text1.Text;
            comboBox1.Visibility = Visibility.Visible;
            eheroe1.Visibility = Visibility.Visible;
            text1.Visibility = Visibility.Hidden;
            boton1.Visibility = Visibility.Hidden;
            j1.ingresarnombre(a);
            j1.ingresarnombre(text1.Text);

        }

        private void text2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            a1 = text2.Text;
            eheroe2.Visibility = Visibility.Visible;
            comboBox2.Visibility = Visibility.Visible;
            text2.Visibility = Visibility.Hidden;
            boton2.Visibility = Visibility.Hidden;
            j2.ingresarnombre(a1);



        }


        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            eheroe1.Visibility = Visibility.Hidden;
            if (comboBox1.SelectedItem == "Warrior")
            {

                comboBox1.Visibility = Visibility.Hidden;
                text2.Visibility = Visibility.Visible;
                boton2.Visibility = Visibility.Visible;
                pic17.Visibility = Visibility.Visible;
                j1.ingresartipo("Warrior");

            }

            if (comboBox1.SelectedItem == "Hunter")
            {
                comboBox1.Visibility = Visibility.Hidden;
                text2.Visibility = Visibility.Visible;
                boton2.Visibility = Visibility.Visible;
                pic1.Visibility = Visibility.Visible;
                j1.ingresartipo("Hunter");

            }

            if (comboBox1.SelectedItem == "Mage")
            {

                comboBox1.Visibility = Visibility.Hidden;
                text2.Visibility = Visibility.Visible;
                boton2.Visibility = Visibility.Visible;
                pic5.Visibility = Visibility.Visible;
                j1.ingresartipo("Mage");

            }

            if (comboBox1.SelectedItem == "Paladin")
            {

                comboBox1.Visibility = Visibility.Hidden;
                text2.Visibility = Visibility.Visible;
                boton2.Visibility = Visibility.Visible;
                pic7.Visibility = Visibility.Visible;
                j1.ingresartipo("Paladin");

            }

            if (comboBox1.SelectedItem == "Priest")
            {

                comboBox1.Visibility = Visibility.Hidden;
                text2.Visibility = Visibility.Visible;
                boton2.Visibility = Visibility.Visible;
                pic9.Visibility = Visibility.Visible;
                j1.ingresartipo("Priest");

            }

            if (comboBox1.SelectedItem == "Druid")
            {

                comboBox1.Visibility = Visibility.Hidden;
                text2.Visibility = Visibility.Visible;
                boton2.Visibility = Visibility.Visible;
                pic3.Visibility = Visibility.Visible;
                j1.ingresartipo("Druid");

            }

            if (comboBox1.SelectedItem == "Rogue")
            {

                comboBox1.Visibility = Visibility.Hidden;
                text2.Visibility = Visibility.Visible;
                boton2.Visibility = Visibility.Visible;
                pic11.Visibility = Visibility.Visible;
                j1.ingresartipo("Rogue");

            }

            if (comboBox1.SelectedItem == "Shaman")
            {

                comboBox1.Visibility = Visibility.Hidden;
                text2.Visibility = Visibility.Visible;
                boton2.Visibility = Visibility.Visible;
                pic13.Visibility = Visibility.Visible;
                j1.ingresartipo("Shaman");

            }

            if (comboBox1.SelectedItem == "Warlock")
            {

                comboBox1.Visibility = Visibility.Hidden;
                text2.Visibility = Visibility.Visible;
                boton2.Visibility = Visibility.Visible;
                pic15.Visibility = Visibility.Visible;
                j1.ingresartipo("Warlock");

            }
            


        }

        private void ComboBox_SelectionChanged_2(object sender, SelectionChangedEventArgs e)
        {
            eheroe2.Visibility = Visibility.Hidden;
            if (comboBox2.SelectedItem == "Warrior")
            {

                comboBox2.Visibility = Visibility.Hidden;
                boton3.Visibility = Visibility.Visible;
                pic18.Visibility = Visibility.Visible;
                j2.ingresartipo("Warrior");

            }

            if (comboBox2.SelectedItem == "Hunter")
            {

                comboBox2.Visibility = Visibility.Hidden;
                boton3.Visibility = Visibility.Visible;
                pic2.Visibility = Visibility.Visible;
                j2.ingresartipo("Hunter");

            }

            if (comboBox2.SelectedItem == "Mage")
            {

                comboBox2.Visibility = Visibility.Hidden;
                boton3.Visibility = Visibility.Visible;
                pic6.Visibility = Visibility.Visible;
                j2.ingresartipo("Mage");

            }

            if (comboBox2.SelectedItem == "Paladin")
            {

                comboBox2.Visibility = Visibility.Hidden;
                boton3.Visibility = Visibility.Visible;
                pic8.Visibility = Visibility.Visible;
                j2.ingresartipo("Paladin");

            }

            if (comboBox2.SelectedItem == "Priest")
            {

                comboBox2.Visibility = Visibility.Hidden;
                boton3.Visibility = Visibility.Visible;
                pic10.Visibility = Visibility.Visible;
                j2.ingresartipo("Priest");

            }

            if (comboBox2.SelectedItem == "Druid")
            {

                comboBox2.Visibility = Visibility.Hidden;
                boton3.Visibility = Visibility.Visible;
                pic4.Visibility = Visibility.Visible;
                j2.ingresartipo("Druid");

            }

            if (comboBox2.SelectedItem == "Rogue")
            {

                comboBox2.Visibility = Visibility.Hidden;
                boton3.Visibility = Visibility.Visible;
                pic12.Visibility = Visibility.Visible;
                j2.ingresartipo("Rogue");

            }

            if (comboBox2.SelectedItem == "Shaman")
            {

                comboBox2.Visibility = Visibility.Hidden;
                boton3.Visibility = Visibility.Visible;
                pic14.Visibility = Visibility.Visible;
                j2.ingresartipo("Shaman");

            }

            if (comboBox2.SelectedItem == "Warlock")
            {

                comboBox2.Visibility = Visibility.Hidden;
                boton3.Visibility = Visibility.Visible;
                pic16.Visibility = Visibility.Visible;
                j2.ingresartipo("Warlock");

            }
           

        }

        private void boton3_Click(object sender, RoutedEventArgs e)
        {
            boton3.Visibility = Visibility.Hidden;



            Listbox.Items.Add("Tus cartas son las siguientes:");
            foreach (minion i in manos)
            {
                Listbox.Items.Add(i.nombre + " oucpa mana: " + i.mana + "    " + " ataca  " + i.ataque + "  tiene vida  " + i.vida);
            }
            Listbox_Copy.Items.Add("Tus cartas son las siguientes:");
            foreach (minion i in manos2)
            {
                Listbox_Copy.Items.Add(i.nombre + " oucpa mana: " + i.mana + "    " + " ataca  " + i.ataque + "  tiene vida  " + i.vida);
            }
            Listbox.Visibility = Visibility.Visible;
            FinTurno.Visibility = Visibility.Visible;

            FinTurno_Copy.Visibility = Visibility.Visible;
            Listbox_Copy.Visibility = Visibility.Visible;
            manatot1.Visibility = Visibility.Visible;

            vida1.Visibility = Visibility.Visible;
            Vida2.Visibility = Visibility.Visible;
            manatot1.Visibility = Visibility.Visible;
            manatott.Visibility = Visibility.Visible;
            manadisp.Visibility = Visibility.Visible;
            manadisponible2.Visibility = Visibility.Visible;
            rendirse1.Visibility = Visibility.Visible;
            rendirse2.Visibility = Visibility.Visible;
            datos.Visibility = Visibility.Visible;
            combobox3.Visibility = Visibility.Visible;
            combobox4.Visibility = Visibility.Visible;
            habilidad.Visibility = Visibility.Visible;
            habilidad2.Visibility = Visibility.Visible;
            atacarheroe1.Visibility = Visibility.Visible;
            atacarheroe2.Visibility = Visibility.Visible;
            Datosj1.Visibility = Visibility.Visible;
            datosj2.Visibility = Visibility.Visible;
            decir1.Visibility = Visibility.Visible;
            decir2.Visibility = Visibility.Visible; 

            atacar2.Visibility = Visibility.Visible;
        }

        private void Listbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }







        private void FinTurno_Click(object sender, RoutedEventArgs e)
        {
            Listbox.Items.Clear();
            j1.terminarturnomana();
            manatot1.Content = String.Empty;
            manatot1.Content = j1.manatotal.ToString();
            manadisp.Content = manatot1.Content;
            j1.pasarturno(j2);
            
            foreach (minion n in mazos)
            {
                n.terminarturnominion();
            }

            j1.darcarta();
            Listbox.Items.Add("Tus cartas son las siguientes:");
            foreach (minion i in manos)
            {
                Listbox.Items.Add(i.nombre + " oucpa mana: " + i.mana + "    " + " ataca  " + i.ataque + "  tiene vida  " + i.vida);
            }
            j1.QuemarMano();

            rendirse1.IsEnabled = false;
            rendirse2.IsEnabled = true;
            Listbox.IsEnabled = false;
            FinTurno.IsEnabled = false;
            FinTurno_Copy.IsEnabled = true;
            Listbox_Copy.IsEnabled = true;
            habilidad2.IsEnabled = true;
            habilidad.IsEnabled = false;
            for (int i = 0; i < cartascancha.Count; i++)
            {

                
                    xx[i].Content = cartascancha[i].nombre + "                \n ocupa mana: " + cartascancha[i].mana + "\n ataca  " + cartascancha[i].ataque + "\n  tiene vida  " + cartascancha[i].vida;
                    if (cartascancha[i].turno == false)
                    {
                        xx[i].IsEnabled = false;
                    }
                    if (cartascancha[i].turno == true)
                    {
                        xx[i].IsEnabled = true;
                    }
                    xx[i].Visibility = Visibility.Visible;


                }
                for (int o = 0; o < cartascancha2.Count; o++)
                {

                    {
                        a2[o].Content = cartascancha2[o].nombre + "                \n ocupa mana: " + cartascancha2[o].mana + "\n ataca  " + cartascancha2[o].ataque + "\n  tiene vida  " + cartascancha2[o].vida;
                        if (cartascancha2[o].turno == false)
                        {
                            a2[o].IsEnabled = false;
                        }
                        if (cartascancha2[o].turno == true)
                        {
                            a2[o].IsEnabled = true;
                        }
                        a2[o].Visibility = Visibility.Visible;
                    }


                }
            
            
            





        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {   
            
            
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }
       
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            atacar = cartascancha[0];
            if (atacar != null && atacado != null)
            {
                
                atacar2.IsEnabled = true;


            }
            
        }

        private void boton17_Click(object sender, RoutedEventArgs e)
        {
            atacado = cartascancha2[6];
            if (atacar != null && atacado != null)
            {
               
                atacar2.IsEnabled = true;


            }
        }

        private void FinTurno_Copy_Click(object sender, RoutedEventArgs e)
        {
            Listbox_Copy.Items.Clear();
            j2.terminarturnomana();

            manatott.Content = j2.manatotal.ToString();
            manadisponible2.Content = manatott.Content;
            j2.darcarta();
            j2.pasarturno(j1);
            
            foreach (minion n in mazos2)
            {
                n.terminarturnominion();
            }
            Listbox_Copy.Items.Add("Tus cartas son las siguientes:");
            foreach (minion i in manos2)
            {
                Listbox_Copy.Items.Add(i.nombre + " oucpa mana: " + i.mana + "    " + " ataca  " + i.ataque + "  tiene vida  " + i.vida);
            }
            j2.QuemarMano();
            rendirse1.IsEnabled = true;
            Listbox.IsEnabled = true;
            FinTurno.IsEnabled = true;
            rendirse2.IsEnabled = false;
            FinTurno_Copy.IsEnabled = false;
            Listbox_Copy.IsEnabled = false;
            habilidad.IsEnabled = true;
            habilidad2.IsEnabled = false;
            
            atacar2.IsEnabled = false;

            for (int i = 0; i < cartascancha.Count; i++)
            {

                
                    xx[i].Content = cartascancha[i].nombre + "                \n ocupa mana: " + cartascancha[i].mana + "\n ataca  " + cartascancha[i].ataque + "\n  tiene vida  " + cartascancha[i].vida;
                    if (cartascancha[i].turno == false)
                    {
                        xx[i].IsEnabled = false;
                    }
                    if (cartascancha[i].turno == true)
                    {
                        xx[i].IsEnabled = true;
                    }
                    xx[i].Visibility = Visibility.Visible;


                }
                for (int o = 0; o < cartascancha2.Count; o++)
                {

                    {
                        a2[o].Content = cartascancha2[o].nombre + "                \n ocupa mana: " + cartascancha2[o].mana + "\n ataca  " + cartascancha2[o].ataque + "\n  tiene vida  " + cartascancha2[o].vida;
                        if (cartascancha2[o].turno == false)
                        {
                            a2[o].IsEnabled = false;
                        }
                        if (cartascancha2[o].turno == true)
                        {
                            a2[o].IsEnabled = true;
                        }
                        a2[o].Visibility = Visibility.Visible;
                    }


                }
            
        }

                private void Listbox_Copy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }

        private void boton4_IsMouseDirectlyOverChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            
        }

        private void boton11_Click(object sender, RoutedEventArgs e)
        {
            atacado = cartascancha2[0];
            if (atacar != null && atacado != null)
            {
                
                atacar2.IsEnabled = true;


            }
        }

        private void popo_MouseEnter(object sender, MouseEventArgs e)
        {
            
        }

        private void boton4_MouseEnter(object sender, MouseEventArgs e)
        {
            popo.Content = boton4.Content;

        }

        private void boton4_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Content = "";
        }

        private void boton5_Click(object sender, RoutedEventArgs e)
        {
            atacar = cartascancha[1];
            if (atacar != null && atacado != null)
            {
               
                atacar2.IsEnabled = true;


            }
        }

        private void boton5_MouseEnter(object sender, MouseEventArgs e)
        {
            popo.Content = boton5.Content;
        }

        private void boton5_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Content = "";

        }

        private void boton6_MouseEnter(object sender, MouseEventArgs e)
        {
            popo.Content = boton6.Content;

        }

        private void boton6_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Content = "";
        }

        private void boton7_MouseEnter(object sender, MouseEventArgs e)
        {
            popo.Content = boton7.Content;
        }

        private void boton7_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Content = "";
        }

        private void boton8_Click(object sender, RoutedEventArgs e)
        {
            atacar = cartascancha[4];
            if (atacar != null && atacado != null)
            {
                
                atacar2.IsEnabled = true;


            }
        }

        private void boton8_MouseEnter(object sender, MouseEventArgs e)
        {

            popo.Content = boton8.Content;

        }

        private void boton8_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Content = "";
        }

        private void boton9_MouseEnter(object sender, MouseEventArgs e)
        {
            popo.Content = boton9.Content;

        }

        private void boton9_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Content = "";
        }

        private void boton10_Click(object sender, RoutedEventArgs e)
        {
            atacar = cartascancha[6];
            if (atacar != null && atacado != null)
            {
                
                atacar2.IsEnabled = true;


            }
        }

        private void boton10_MouseEnter(object sender, MouseEventArgs e)
        {
            popo.Content = boton10.Content;
        }

        private void boton10_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Content = "";
        }

        private void popo_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void boton11_MouseEnter(object sender, MouseEventArgs e)
        {
            popo.Content = boton11.Content;

        }

        private void boton11_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Content = "";
        }

        private void boton12_MouseEnter(object sender, MouseEventArgs e)
        {
            popo.Content = boton12.Content;

        }

        private void boton12_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Content = "";
        }

        private void boton13_MouseEnter(object sender, MouseEventArgs e)
        {
            popo.Content = boton13.Content;
        }

        private void boton13_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Content = "";
        }

        private void boton14_MouseEnter(object sender, MouseEventArgs e)
        {
            popo.Content = boton14.Content;
        }

        private void boton14_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Content = "";
        }

        private void boton15_MouseEnter(object sender, MouseEventArgs e)
        {
            popo.Content = boton15.Content;
        }

        private void boton15_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Content = "";
        }

        private void boton16_MouseEnter(object sender, MouseEventArgs e)
        {
            popo.Content = boton16.Content;
        }

        private void boton16_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Content = "";
        }

        private void boton17_MouseEnter(object sender, MouseEventArgs e)
        {
            popo.Content = boton17.Content;
        }

        private void boton17_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Content = "";
        }

        private void rendirse1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(j1.nombre + "   Te has rendido ");
            Application.Current.Shutdown();
                }

        private void rendirse2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(j2.nombre + "   Te has rendido ");
            Application.Current.Shutdown();

        }

        private void combobox3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (combobox3.SelectedItem == "OOPS")
            {
                MessageBox.Show(j1.nombre +" dice:\nRayos y centellas");
            }
            if (combobox3.SelectedItem == "Amenaza")
            {
                MessageBox.Show(j1.nombre + " dice:\nMUEEEERE!!!");
            }
            if (combobox3.SelectedItem == "Saludar")
            {
                MessageBox.Show(j1.nombre + " dice:\nHola ");
            }
            if (combobox3.SelectedItem == "Llorar")
            {
                MessageBox.Show(j1.nombre + " dice:\n😞 ");
            }
            if (combobox3.SelectedItem == "Celebrar")
            {
                MessageBox.Show(j1.nombre + " dice:\nohhhhh si ");
            }
        }

        private void combobox4_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (combobox4.SelectedItem == "OOPS")
            {
                MessageBox.Show(j2.nombre + " dice:\nRayos y centellas");
            }
            if (combobox4.SelectedItem == "Amenaza")
            {
                MessageBox.Show(j2.nombre + " dice:\nMUEEEERE!!!");
            }
            if (combobox4.SelectedItem == "Saludar")
            {
                MessageBox.Show(j2.nombre + " dice:\nHola ");
            }
            if (combobox4.SelectedItem == "Llorar")
            {
                MessageBox.Show(j2.nombre + " dice:\n😞 ");
            }
            if (combobox4.SelectedItem == "Celebrar")
            {
                MessageBox.Show(j2.nombre + " dice:\nOHHHHHHHH SIIII!!!!");
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (j1.tipo == "Paladin")
            {
                minion paladin1 = new minion("Recruit", 1, 1, false, false, 0);
                mazos.Add(paladin1);
                j1.invocar(paladin1, cartascancha);                
            }
            Random rnd = new Random();
            if (j1.tipo == "Shaman")
            {
                int ppp = rnd.Next(4);
                if (ppp == 0)
                {
                    minion shaman1 = new minion("Heilin Totem", 2, 0, true, true, 0);
                    mazos.Add(shaman1);
                    j1.invocar(shaman1, cartascancha);
                }
                if (ppp == 1)
                {
                    
                    minion shaman5 = new minion("Seiring Totem", 1, 1, true, true, 0);
                    mazos.Add(shaman5);
                    j1.invocar(shaman5, cartascancha);
                }
                if (ppp == 2)
                {

                    minion shaman3 = new minion("Stoneclaw Totem", 2, 0, true, true, 0);
                    mazos.Add(shaman3);
                    j1.invocar(shaman3, cartascancha);
                }
                if (ppp == 3)
                {
                    minion shaman4 = new minion("Warth of air Totem", 2, 0, true, true, 0);
                    mazos.Add(shaman4);
                    j1.invocar(shaman4, cartascancha);
                }
            }


            j1.habilidad(j2);
            vida1.Content = j1.vida;
            Vida2.Content = j2.vida;
            manadisp.Content = j1.mana;
            habilidad.IsEnabled = false;
            MessageBox.Show(cartascancha.Count.ToString());
            for (int i = 0; i < cartascancha.Count; i++)
            {

                {
                    xx[i].Content = cartascancha[i].nombre + "                \n ocupa mana: " + cartascancha[i].mana + "\n ataca  " + cartascancha[i].ataque + "\n  tiene vida  " + cartascancha[i].vida;

                    xx[i].Visibility = Visibility.Visible;







                }

            }




        }

        private void habilidad2_Click(object sender, RoutedEventArgs e)
        {

            if (j2.tipo == "Paladin")
            {
                minion paladin1 = new minion("Recruit", 1, 1, true, true, 0);
                mazos.Add(paladin1);
                j2.invocar(paladin1, cartascancha2);
            }
            Random rnd = new Random();
            if (j2.tipo == "Shaman")
            {
                int ppp = rnd.Next(4);
                if (ppp == 0)
                {
                    minion shaman1 = new minion("Heilin Totem", 2, 0, true, true, 0);
                    mazos.Add(shaman1);
                    j2.invocar(shaman1, cartascancha2);
                }
                if (ppp == 1)
                {
                    minion shaman5 = new minion("Seiring Totem", 1, 1, true, true, 0);
                    mazos.Add(shaman5);
                    j2.invocar(shaman5, cartascancha2);
                }
                if (ppp == 2)
                {
                    minion shaman3 = new minion("Stoneclaw Totem", 2, 0, true, true, 0);
                    mazos.Add(shaman3);
                    j2.invocar(shaman3, cartascancha2);
                }
                if (ppp == 3)
                {
                    minion shaman4 = new minion("Warth of air Totem", 2, 0, true, true, 0);
                    mazos.Add(shaman4);
                    j2.invocar(shaman4, cartascancha2);
                }
            }
            j2.habilidad(j1);
            vida1.Content = j1.vida;
            Vida2.Content = j2.vida;
            manadisponible2.Content = j2.mana;
            habilidad2.IsEnabled = false;
            for (int o = 0; o < cartascancha2.Count; o++)
            {

                {
                    a2[o].Content = cartascancha2[o].nombre + "                \n ocupa mana: " + cartascancha2[o].mana + "\n ataca  " + cartascancha2[o].ataque + "\n  tiene vida  " + cartascancha2[o].vida;

                    a2[o].Visibility = Visibility.Visible;







                }

            }


        }

        

        private void Listbox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (Listbox.SelectedIndex == 0)
            {

            }
            if (Listbox.SelectedIndex > 0)
            {
                if (j1.mano[Listbox.SelectedIndex - 1].mana <= j1.mana)
                {
                    j1.jugarcarta(Listbox.SelectedIndex, cartascancha);
                    manadisp.Content = j1.mana;

                    Listbox.Items.Remove(Listbox.SelectedItem);
                }
            }



            for (int i = 0; i < cartascancha.Count; i++)
            {

                {
                    xx[i].Content = cartascancha[i].nombre + "                \n ocupa mana: " + cartascancha[i].mana + "\n ataca  " + cartascancha[i].ataque + "\n  tiene vida  " + cartascancha[i].vida;
                    if (cartascancha[i].turno == false)
                    {
                        xx[i].IsEnabled = false;
                    }
                    if (cartascancha[i].turno == true)
                    {
                        xx[i].IsEnabled = true;
                    }
                    xx[i].Visibility = Visibility.Visible;
                    







                }




            }
        }

        private void Listbox_Copy_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (Listbox_Copy.SelectedIndex == 0)
            {

            }
            if (Listbox_Copy.SelectedIndex > 0)
            {
                if (j2.mano[Listbox_Copy.SelectedIndex - 1].mana <= j2.mana)
                {
                    j2.jugarcarta(Listbox_Copy.SelectedIndex, cartascancha2);
                    manadisponible2.Content = j2.mana;

                    Listbox_Copy.Items.Remove(Listbox_Copy.SelectedItem);
                }
            }



            for (int i = 0; i < cartascancha2.Count; i++)
            {

                {
                    a2[i].Content = cartascancha2[i].nombre + "    " + cartascancha2[i].mana + cartascancha2[i].vida + cartascancha2[i].ataque;
                    if (cartascancha2[i].turno == false)
                    {
                        a2[i].IsEnabled = false;
                    }

                    a2[i].Visibility = Visibility.Visible;







                }

            }
        }

        private void Listbox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void boton6_Click(object sender, RoutedEventArgs e)
        {
            atacar = cartascancha[2];
            if (atacar != null && atacado != null)
            {
               
                atacar2.IsEnabled = true;


            }
        }

        private void boton7_Click(object sender, RoutedEventArgs e)
        {
            atacar = cartascancha[3];
            if (atacar != null && atacado != null)
            {
               
                atacar2.IsEnabled = true;


            }
        }

        private void boton9_Click(object sender, RoutedEventArgs e)
        {
            atacar = cartascancha[5];
            if (atacar != null && atacado != null)
            {
               
                atacar2.IsEnabled = true;


            }
        }

        private void boton12_Click(object sender, RoutedEventArgs e)
        {
            atacado = cartascancha2[1];
             if(atacar!=null && atacado !=null)
            {
               
                atacar2.IsEnabled = true;


            }
        }

        private void boton13_Click(object sender, RoutedEventArgs e)
        {
            atacado = cartascancha2[2];
            if (atacar != null && atacado != null)
            {
               
                atacar2.IsEnabled = true;


            }
        }

        private void boton14_Click(object sender, RoutedEventArgs e)
        {
            atacado = cartascancha2[3];
            if (atacar != null && atacado != null)
            {
           
                atacar2.IsEnabled = true;


            }
        }

        private void boton15_Click(object sender, RoutedEventArgs e)
        {
            atacado = cartascancha2[4];
            if (atacar != null && atacado != null)
            {
                
                atacar2.IsEnabled = true;


            }
        }

        private void boton16_Click(object sender, RoutedEventArgs e)
        {
            atacado = cartascancha2[5];
            if (atacar != null && atacado != null)
            {
             
                atacar2.IsEnabled = true;


            }
        }


        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (heroeatacado != null && atacado != null && j2.activo==true)
            {
                atacado.attack(null, heroeatacado, cartascancha2, cartascancha);
                
                heroeatacado = null;
               ;
            }
            
            if (heroeatacado != null && atacar != null && j1.activo==true)
            {
                atacar.attack(null, heroeatacado, cartascancha, cartascancha2);
                
                heroeatacado = null;
               
            }
            
            if (atacado != null && atacar != null&& j1.activo==true) { 
            atacar.attack(atacado, null, cartascancha, cartascancha2);
                
                atacado = null;
            atacar = null;
                
            }
            if (atacado != null && atacar != null && j2.activo == true)
            {
                atacado.attack(atacar, null, cartascancha2, cartascancha);

                atacado = null;
                atacar = null;

            }

            vida1.Content = j1.vida;
            Vida2.Content = j2.vida;
            if (j1.vida <= 0)
            {
                MessageBox.Show(j2.nombre + " GANASTE LA PARTIDA");
                Application.Current.Shutdown();
            }
            if (j2.vida <= 0)
            {
                MessageBox.Show(j1.nombre + " GANASTE LA PARTIDA");
                Application.Current.Shutdown();
            }


            
            

            /*MessageBox.Show(atacar.vida.ToString() + atacado.vida.ToString());*/
            /*if (atacar.vida <= 0)
            {
                boton4.Content = "";
                boton4.Visibility = Visibility.Hidden;

            }
            if (atacado.vida <= 0)
            {
                boton11.Content = "";
                boton11.Visibility = Visibility.Hidden;
            }*/



            for (int i = 0; i < cartascancha.Count; i++)
            {

                
                    xx[i].Content = cartascancha[i].nombre + "                \n ocupa mana: " + cartascancha[i].mana + "\n ataca  " + cartascancha[i].ataque + "\n  tiene vida  " + cartascancha[i].vida;
                    if (cartascancha[i].turno == false)
                    {
                        xx[i].IsEnabled = false;
                    }
                    if (cartascancha[i].turno == true)
                    {
                        xx[i].IsEnabled = true;
                    }
                    xx[i].Visibility = Visibility.Visible;


                }
                for (int o = 0; o < cartascancha2.Count; o++)
                {

                    {
                        a2[o].Content = cartascancha2[o].nombre + "                \n ocupa mana: " + cartascancha2[o].mana + "\n ataca  " + cartascancha2[o].ataque + "\n  tiene vida  " + cartascancha2[o].vida;
                        if (cartascancha2[o].turno == false)
                        {
                            a2[o].IsEnabled = false;
                        }
                        if (cartascancha2[o].turno == true)
                        {
                            a2[o].IsEnabled = true;
                        }
                        a2[o].Visibility = Visibility.Visible;
                    }

                }

            

            xx[cartascancha.Count()].Content = "";
            xx[cartascancha.Count()].Visibility = Visibility.Hidden;
            a2[cartascancha2.Count()].Content = "";
            a2[cartascancha2.Count()].Visibility = Visibility.Hidden;
        }
        Heroe heroeatacado;
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            heroeatacado = j2;
            if ((atacar != null && heroeatacado != null) || (atacado != null && heroeatacado != null))
            {

                atacar2.IsEnabled = true;


            }
           

        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            heroeatacado = j1;
            if ((atacar != null && heroeatacado != null) || (atacado != null && heroeatacado != null))
            {

                atacar2.IsEnabled = true;


            }
         

        }

        private void Listbox_Copy_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

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