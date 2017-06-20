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
        
        
        ImageBrush wisp = new ImageBrush();
        ImageBrush MurlocRaider = new ImageBrush();
        ImageBrush BloodfenRaptor = new ImageBrush();
        ImageBrush RiverCrocolisk = new ImageBrush();
        ImageBrush MagmaRager = new ImageBrush();
        ImageBrush ChillwindYeti = new ImageBrush();
        ImageBrush OasisSnapjaw = new ImageBrush();
        ImageBrush BoulderfistOgre = new ImageBrush();
        ImageBrush WarGolem = new ImageBrush();
        ImageBrush CoreHound = new ImageBrush();
        ImageBrush Recruit = new ImageBrush();
        ImageBrush vacio = new ImageBrush();


        List<carta> mazos = new List<carta>();
        List<carta> mazos2 = new List<carta>();

        List<Button> a2 = new List<Button>();
        List<Button> xx = new List<Button>();

        List<Button> manobot = new List<Button>();
        List<Button> manobot1 = new List<Button>();


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
            
            BitmapImage image = new BitmapImage(new Uri("http://media-hearth.cursecdn.com/avatars/147/699/273.png"));
            wisp.ImageSource = image;
            BitmapImage image1 = new BitmapImage(new Uri("https://hydra-media.cursecdn.com/hearthstone.gamepedia.com/thumb/1/1f/Murloc_Raider%2855%29_Gold.png/200px-Murloc_Raider%2855%29_Gold.png?version=883f02d505c570b0ea5c8b4b5e13f3b8"));
            MurlocRaider.ImageSource = image1;
            BitmapImage image2 = new BitmapImage(new Uri("http://wow.zamimg.com/images/hearthstone/cards/enus/original/CS2_172.png"));
            BloodfenRaptor.ImageSource = image2;
            BitmapImage image3 = new BitmapImage(new Uri("https://media-hearth.cursecdn.com/avatars/147/580/535.png"));
            RiverCrocolisk.ImageSource = image3;
            BitmapImage image4 = new BitmapImage(new Uri("https://hydra-media.cursecdn.com/hearthstone.gamepedia.com/thumb/e/e3/Magma_Rager%28362%29_Gold.png/200px-Magma_Rager%28362%29_Gold.png?version=2f74b68dc2a909f90ec5c1b281403cc4"));
            MagmaRager.ImageSource = image4;
            BitmapImage image5 = new BitmapImage(new Uri("https://hydra-media.cursecdn.com/hearthstone.gamepedia.com/thumb/1/11/Chillwind_Yeti%2831%29_Gold.png/200px-Chillwind_Yeti%2831%29_Gold.png?version=d51f12af8fc503b7aadd3775cdb4b3c4"));
            ChillwindYeti.ImageSource = image5;
            BitmapImage image6 = new BitmapImage(new Uri("http://media-hearth.cursecdn.com/avatars/147/579/15.png"));
            OasisSnapjaw.ImageSource = image6;
            BitmapImage image7 = new BitmapImage(new Uri("https://hydra-media.cursecdn.com/hearthstone.gamepedia.com/thumb/f/fd/Boulderfist_Ogre%2860%29.png/200px-Boulderfist_Ogre%2860%29.png?version=7413c2a7a083d1e07079b5a064ba544d"));
            BoulderfistOgre.ImageSource = image7;
            BitmapImage image8 = new BitmapImage(new Uri("https://hydra-media.cursecdn.com/hearthstone.gamepedia.com/thumb/5/59/War_Golem%28323%29_Gold.png/200px-War_Golem%28323%29_Gold.png?version=dadc0de413eb02f718d3073d75b23cfd"));
            WarGolem.ImageSource = image8;
            BitmapImage image9 = new BitmapImage(new Uri("https://hydra-media.cursecdn.com/hearthstone.gamepedia.com/thumb/9/9e/Core_Hound%28173%29.png/200px-Core_Hound%28173%29.png?version=61fadbe5ac356dd87a804be87e6ea538"));
            CoreHound.ImageSource = image9;
            BitmapImage image10 = new BitmapImage(new Uri("https://hydra-media.cursecdn.com/hearthstone.gamepedia.com/thumb/9/9e/Core_Hound%28173%29.png/200px-Core_Hound%28173%29.png?version=61fadbe5ac356dd87a804be87e6ea538"));
            Recruit.ImageSource = image10;


            foreach(Button b in stackpanel_Copy1.Children)
            {
                manobot.Add(b);
            }

            foreach (Button b in stackpanel_Copy.Children)
            {
                a2.Add(b);
                
            }
            foreach (Button b in stackpanel.Children)
            {
                xx.Add(b);

            }
            foreach (Button b in stackpanel_Copy2.Children)
            {
                manobot1.Add(b);

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
           
            FinTurno.Visibility = Visibility.Hidden;
            boton11.Visibility = Visibility.Hidden;
            boton12.Visibility = Visibility.Hidden;
            boton13.Visibility = Visibility.Hidden;
            boton14.Visibility = Visibility.Hidden;
            boton15.Visibility = Visibility.Hidden;
            boton16.Visibility = Visibility.Hidden;
            boton17.Visibility = Visibility.Hidden;
            FinTurno_Copy.Visibility = Visibility.Hidden;
            //Listbox_Copy.Visibility = Visibility.Hidden;
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



        public static void refreshhmano(List<carta> cartascancha, List<carta> cartascancha2, List<Button> xx, List<Button> a2, ImageBrush wisp, ImageBrush MurlocRaider, ImageBrush BloodfenRaptor, ImageBrush RiverCrocolisk, ImageBrush MagmaRager, ImageBrush ChillwindYeti, ImageBrush OasisSnapjaw, ImageBrush BoulderfistOgre, ImageBrush WarGolem, ImageBrush CoreHound, ImageBrush recruit, Heroe j1, Heroe j2)
        {
            for (int i = 0; i < cartascancha.Count; i++)
            {

                

                
                if (cartascancha[i].nombre == "Murloc Raider")
                {
                    xx[i].Background = MurlocRaider;
                }
                if (cartascancha[i].nombre == "Bloodfen Raptor")
                {
                    xx[i].Background = BloodfenRaptor;
                }
                if (cartascancha[i].nombre == "River Crocolisk")
                {
                    xx[i].Background = RiverCrocolisk;
                }
                if (cartascancha[i].nombre == "Magma Rager")
                {
                    xx[i].Background = MagmaRager;
                }
                if (cartascancha[i].nombre == "Chillwind Yeti")
                {
                    xx[i].Background = ChillwindYeti;
                }
                if (cartascancha[i].nombre == "Oasis Snapjaw")
                {
                    xx[i].Background = OasisSnapjaw;
                }
                if (cartascancha[i].nombre == "Boulderfist Ogre")
                {
                    xx[i].Background = BoulderfistOgre;
                }
                if (cartascancha[i].nombre == "War Golem")
                {
                    xx[i].Background = WarGolem;
                }
                if (cartascancha[i].nombre == "Core Hound")
                {
                    xx[i].Background = CoreHound;
                }
                if (cartascancha[i].nombre == "Recruit")
                {
                    xx[i].Background = recruit;
                }
                xx[i].Visibility = Visibility.Visible;

                xx[cartascancha.Count()].Visibility = Visibility.Hidden;
            }
            /*for (int o = 0; o < cartascancha2.Count; o++)
            {


               
                if (cartascancha2[o].nombre == "wisp")
                {
                    a2[o].Background = wisp;
                }
                if (cartascancha2[o].nombre == "Murloc Raider")
                {
                    a2[o].Background = MurlocRaider;
                }
                if (cartascancha2[o].nombre == "Bloodfen Raptor")
                {
                    a2[o].Background = BloodfenRaptor;
                }
                if (cartascancha2[o].nombre == "River Crocolisk")
                {
                    a2[o].Background = RiverCrocolisk;
                }
                if (cartascancha2[o].nombre == "Magma Rager")
                {
                    a2[o].Background = MagmaRager;
                }
                if (cartascancha2[o].nombre == "Chillwind Yeti")
                {
                    a2[o].Background = ChillwindYeti;
                }
                if (cartascancha2[o].nombre == "Oasis Snapjaw")
                {
                    a2[o].Background = OasisSnapjaw;
                }
                if (cartascancha2[o].nombre == "Boulderfist Ogre")
                {
                    a2[o].Background = BoulderfistOgre;
                }
                if (cartascancha2[o].nombre == "War Golem")
                {
                    a2[o].Background = WarGolem;
                }
                if (cartascancha2[o].nombre == "Core Hound")
                {
                    a2[o].Background = CoreHound;
                }

                a2[o].Visibility = Visibility.Visible;



            }*/
           
        }




        public static void refreshh(List<minion> cartascancha, List<minion> cartascancha2, List<Button> xx, List<Button> a2, ImageBrush wisp, ImageBrush MurlocRaider, ImageBrush BloodfenRaptor, ImageBrush RiverCrocolisk,ImageBrush MagmaRager ,ImageBrush ChillwindYeti, ImageBrush OasisSnapjaw, ImageBrush BoulderfistOgre, ImageBrush WarGolem, ImageBrush CoreHound,ImageBrush recruit, Heroe j1, Heroe j2)
        {
            for (int i = 0; i < cartascancha.Count; i++)
            {

                if (cartascancha[i].turno == false)
                {
                    xx[i].Opacity = 0.3;
                }
                if (cartascancha[i].turno == true)
                {
                    xx[i].Opacity = 1;

                }
                if (cartascancha[i].nombre == "wisp")
                {
                    xx[i].Background = wisp;
                    
                }
                if (cartascancha[i].nombre == "Murloc Raider")
                {
                    xx[i].Background = MurlocRaider;
                }
                if (cartascancha[i].nombre == "Bloodfen Raptor")
                {
                    xx[i].Background = BloodfenRaptor;
                }
                if (cartascancha[i].nombre == "River Crocolisk")
                {
                    xx[i].Background = RiverCrocolisk;
                }
                if (cartascancha[i].nombre == "Magma Rager")
                {
                    xx[i].Background = MagmaRager;
                }
                if (cartascancha[i].nombre == "Chillwind Yeti")
                {
                    xx[i].Background = ChillwindYeti;
                }
                if (cartascancha[i].nombre == "Oasis Snapjaw")
                {
                    xx[i].Background = OasisSnapjaw;
                }
                if (cartascancha[i].nombre == "Boulderfist Ogre")
                {
                    xx[i].Background = BoulderfistOgre;
                }
                if (cartascancha[i].nombre == "War Golem")
                {
                    xx[i].Background = WarGolem;
                }
                if (cartascancha[i].nombre == "Core Hound")
                {
                    xx[i].Background = CoreHound;
                }
                if (cartascancha[i].nombre == "Recruit")
                {
                    xx[i].Background = recruit;
                }
                xx[i].Visibility = Visibility.Visible;


            }
            for (int o = 0; o < cartascancha2.Count; o++)
            {


                if (cartascancha2[o].turno == false)
                {
                    a2[o].Opacity = 0.3;
                }
                if (cartascancha2[o].turno == true)
                {
                    a2[o].Opacity=1;
                }
                if (cartascancha2[o].nombre == "wisp")
                {
                    a2[o].Background = wisp;
                }
                if (cartascancha2[o].nombre == "Murloc Raider")
                {
                    a2[o].Background = MurlocRaider;
                }
                if (cartascancha2[o].nombre == "Bloodfen Raptor")
                {
                    a2[o].Background = BloodfenRaptor;
                }
                if (cartascancha2[o].nombre == "River Crocolisk")
                {
                    a2[o].Background = RiverCrocolisk;
                }
                if (cartascancha2[o].nombre == "Magma Rager")
                {
                    a2[o].Background = MagmaRager;
                }
                if (cartascancha2[o].nombre == "Chillwind Yeti")
                {
                    a2[o].Background = ChillwindYeti;
                }
                if (cartascancha2[o].nombre == "Oasis Snapjaw")
                {
                    a2[o].Background = OasisSnapjaw;
                }
                if (cartascancha2[o].nombre == "Boulderfist Ogre")
                {
                    a2[o].Background = BoulderfistOgre;
                }
                if (cartascancha2[o].nombre == "War Golem")
                {
                    a2[o].Background = WarGolem;
                }
                if (cartascancha2[o].nombre == "Core Hound")
                {
                    a2[o].Background = CoreHound;
                }
                
                a2[o].Visibility = Visibility.Visible;



            }
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
        }


       

        public static void jugarcarta(int a, List<minion> lista, Heroe h)
        {   if (lista.Count < 6)
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

        /*Elegir Heroe1*/
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
        /*Elegir Heroe 2*/
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
        /*Comenzar*/

        private void boton3_Click(object sender, RoutedEventArgs e)
        {

            boton3.Visibility = Visibility.Hidden;
            for (int i = 0; i < manos.Count; i++)
            {
                if (manos[i].nombre == "wisp")
                {
                    manobot[i].Background = wisp;

                }
                if (manos[i].nombre == "Murloc Raider")
                {
                    manobot[i].Background = MurlocRaider;
                }
                if (manos[i].nombre == "Bloodfen Raptor")
                {
                    manobot[i].Background = BloodfenRaptor;
                }
                if (manos[i].nombre == "River Crocolisk")
                {
                    manobot[i].Background = RiverCrocolisk;
                }
                if (manos[i].nombre == "Magma Rager")
                {
                    manobot[i].Background = MagmaRager;
                }
                if (manos[i].nombre == "Chillwind Yeti")
                {
                    manobot[i].Background = ChillwindYeti;
                }
                if (manos[i].nombre == "Oasis Snapjaw")
                {
                    manobot[i].Background = OasisSnapjaw;
                }
                if (manos[i].nombre == "Boulderfist Ogre")
                {
                    manobot[i].Background = BoulderfistOgre;
                }
                if (manos[i].nombre == "War Golem")
                {
                    manobot[i].Background = WarGolem;
                }
                if (manos[i].nombre == "Core Hound")
                {
                    manobot[i].Background = CoreHound;
                }

                manobot[i].Visibility = Visibility.Visible;
                for (int j = 0; j < manos2.Count; j++)
                {
                    if (manos2[j].nombre == "wisp")
                    {
                        manobot1[j].Background = wisp;

                    }
                    if (manos2[j].nombre == "Murloc Raider")
                    {
                        manobot1[j].Background = MurlocRaider;
                    }
                    if (manos2[j].nombre == "Bloodfen Raptor")
                    {
                        manobot1[j].Background = BloodfenRaptor;
                    }
                    if (manos2[j].nombre == "River Crocolisk")
                    {
                        manobot1[j].Background = RiverCrocolisk;
                    }
                    if (manos2[j].nombre == "Magma Rager")
                    {
                        manobot1[j].Background = MagmaRager;
                    }
                    if (manos2[j].nombre == "Chillwind Yeti")
                    {
                        manobot1[j].Background = ChillwindYeti;
                    }
                    if (manos2[j].nombre == "Oasis Snapjaw")
                    {
                        manobot1[j].Background = OasisSnapjaw;
                    }
                    if (manos2[j].nombre == "Boulderfist Ogre")
                    {
                        manobot1[j].Background = BoulderfistOgre;
                    }
                    if (manos2[j].nombre == "War Golem")
                    {
                        manobot1[j].Background = WarGolem;
                    }
                    if (manos2[j].nombre == "Core Hound")
                    {
                        manobot1[j].Background = CoreHound;
                    }

                    manobot1[j].Visibility = Visibility.Visible;

                }
            }
           /* Listbox_Copy.Items.Add("Tus cartas son las siguientes:");
            foreach (minion i in manos2)
            {
                Listbox_Copy.Items.Add(i.nombre + " ocupa mana: " + i.mana + "    " + " ataca  " + i.ataque + "  tiene vida  " + i.vida);
            }*/
            
            FinTurno.Visibility = Visibility.Visible;

            FinTurno_Copy.Visibility = Visibility.Visible;
            //Listbox_Copy.Visibility = Visibility.Visible;
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
            manos.Count();
        }

        private void Listbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        /*Fin Turno j1*/
        private void FinTurno_Click(object sender, RoutedEventArgs e)
        {
            
            j1.terminarturnomana();
            manatot1.Content = String.Empty;
            manatot1.Content = j1.manatotal.ToString();
            manadisp.Content = manatot1.Content;
            j1.pasarturno(j2);
            
            foreach (minion n in mazos)
            {
                n.terminarturnominion();
            }
            foreach (minion a in mazos)
            {
                if (a.visibilidad == true && a.actividad == true && a.turno == false)
                {
                    a.cambiarActividad();
                }
            }
            j1.darcarta();
           
           
            j1.QuemarMano();

            rendirse1.IsEnabled = false;
            rendirse2.IsEnabled = true;
           
            FinTurno.IsEnabled = false;
            FinTurno_Copy.IsEnabled = true;
            //Listbox_Copy.IsEnabled = true;
            habilidad2.IsEnabled = true;
            habilidad.IsEnabled = false;
            for (int i = 0; i < manos.Count; i++)
            {
                if (manos[i].nombre == "wisp")
                {
                    manobot[i].Background = wisp;

                }
                if (manos[i].nombre == "Murloc Raider")
                {
                    manobot[i].Background = MurlocRaider;
                }
                if (manos[i].nombre == "Bloodfen Raptor")
                {
                    manobot[i].Background = BloodfenRaptor;
                }
                if (manos[i].nombre == "River Crocolisk")
                {
                    manobot[i].Background = RiverCrocolisk;
                }
                if (manos[i].nombre == "Magma Rager")
                {
                    manobot[i].Background = MagmaRager;
                }
                if (manos[i].nombre == "Chillwind Yeti")
                {
                    manobot[i].Background = ChillwindYeti;
                }
                if (manos[i].nombre == "Oasis Snapjaw")
                {
                    manobot[i].Background = OasisSnapjaw;
                }
                if (manos[i].nombre == "Boulderfist Ogre")
                {
                    manobot[i].Background = BoulderfistOgre;
                }
                if (manos[i].nombre == "War Golem")
                {
                    manobot[i].Background = WarGolem;
                }
                if (manos[i].nombre == "Core Hound")
                {
                    manobot[i].Background = CoreHound;
                }
                manobot[i].Visibility = Visibility.Visible;
            }
            manobot[manos.Count()].Visibility = Visibility.Hidden;
            refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit ,j1,j2);
        

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
        /*Fin Turno j2*/
        private void FinTurno_Copy_Click(object sender, RoutedEventArgs e)
        {
            //Listbox_Copy.Items.Clear();
            j2.terminarturnomana();

            manatott.Content = j2.manatotal.ToString();
            manadisponible2.Content = manatott.Content;
            j2.darcarta();
            j2.pasarturno(j1);
            
            foreach (minion n in mazos2)
            {
                n.terminarturnominion();
            }

            foreach (minion a in mazos)
            {
                if (a.visibilidad == true && a.actividad == true && a.turno == false)
                {
                    a.cambiarActividad();
                }
            }
            /*Listbox_Copy.Items.Add("Tus cartas son las siguientes:");
            foreach (minion i in manos2)
            {
                Listbox_Copy.Items.Add(i.nombre + " oucpa mana: " + i.mana + "    " + " ataca  " + i.ataque + "  tiene vida  " + i.vida);
            }*/
            j2.QuemarMano();
            rendirse1.IsEnabled = true;
           
            FinTurno.IsEnabled = true;
            rendirse2.IsEnabled = false;
            FinTurno_Copy.IsEnabled = false;
            //Listbox_Copy.IsEnabled = false;
            habilidad.IsEnabled = true;
            habilidad2.IsEnabled = false;
            for (int i = 0; i < manos2.Count; i++)
            {
                if (manos2[i].nombre == "wisp")
                {
                    manobot1[i].Background = wisp;

                }
                if (manos2[i].nombre == "Murloc Raider")
                {
                    manobot1[i].Background = MurlocRaider;
                }
                if (manos2[i].nombre == "Bloodfen Raptor")
                {
                    manobot1[i].Background = BloodfenRaptor;
                }
                if (manos2[i].nombre == "River Crocolisk")
                {
                    manobot1[i].Background = RiverCrocolisk;
                }
                if (manos2[i].nombre == "Magma Rager")
                {
                    manobot1[i].Background = MagmaRager;
                }
                if (manos2[i].nombre == "Chillwind Yeti")
                {
                    manobot1[i].Background = ChillwindYeti;
                }
                if (manos2[i].nombre == "Oasis Snapjaw")
                {
                    manobot1[i].Background = OasisSnapjaw;
                }
                if (manos2[i].nombre == "Boulderfist Ogre")
                {
                    manobot1[i].Background = BoulderfistOgre;
                }
                if (manos2[i].nombre == "War Golem")
                {
                    manobot1[i].Background = WarGolem;
                }
                if (manos2[i].nombre == "Core Hound")
                {
                    manobot1[i].Background = CoreHound;
                }
                manobot1[i].Visibility = Visibility.Visible;
            }
            manobot1[manos2.Count()].Visibility = Visibility.Hidden;
            refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, j1, j2);


            atacar2.IsEnabled = false;

            refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit,j1, j2);

        }

                private void Listbox_Copy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }

        private void boton4_IsMouseDirectlyOverChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            popo.Content = cartascancha[0].nombre + "                \n ocupa mana: " + cartascancha[0].mana + "\n ataca  " + cartascancha[0].ataque + "\n  tiene vida  " + cartascancha[0].vida;
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
            popo.Content = cartascancha[0].nombre + "                \n ocupa mana: " + cartascancha[0].mana + "\n ataca  " + cartascancha[0].ataque + "\n  tiene vida  " + cartascancha[0].vida;
            
                    
                    

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
            popo.Content = cartascancha[1].nombre + "                \n ocupa mana: " + cartascancha[1].mana + "\n ataca  " + cartascancha[1].ataque + "\n  tiene vida  " + cartascancha[1].vida;
            if (cartascancha[1].nombre == "wisp")
            {  
                popo.Background = wisp;

            }
            if (cartascancha[1].nombre == "Murloc Raider")
            {
                popo.Background = MurlocRaider;
            }
            if (cartascancha[1].nombre == "Bloodfen Raptor")
            {
                popo.Background = BloodfenRaptor;
            }
            if (cartascancha[1].nombre == "River Crocolisk")
            {
                popo.Background = RiverCrocolisk;
            }
            if (cartascancha[1].nombre == "Magma Rager")
            {
                popo.Background = MagmaRager;
            }
            if (cartascancha[1].nombre == "Chillwind Yeti")
            {
                popo.Background = ChillwindYeti;
            }
            if (cartascancha[1].nombre == "Oasis Snapjaw")
            {
                popo.Background = OasisSnapjaw;
            }
            if (cartascancha[1].nombre == "Boulderfist Ogre")
            {
                popo.Background = BoulderfistOgre;
            }
            if (cartascancha[1].nombre == "War Golem")
            {
                popo.Background = WarGolem;
            }
            if (cartascancha[1].nombre == "Core Hound")
            {
                popo.Background = CoreHound;
            }


        }

        private void boton5_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Background = vacio;
            popo.Content = "";

        }

        private void boton6_MouseEnter(object sender, MouseEventArgs e)
        {
            popo.Content = cartascancha[2].nombre + "                \n ocupa mana: " + cartascancha[2].mana + "\n ataca  " + cartascancha[2].ataque + "\n  tiene vida  " + cartascancha[2].vida;
                    

        }

        private void boton6_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Content = "";
        }

        private void boton7_MouseEnter(object sender, MouseEventArgs e)
        {
            popo.Content = cartascancha[3].nombre + "                \n ocupa mana: " + cartascancha[3].mana + "\n ataca  " + cartascancha[3].ataque + "\n  tiene vida  " + cartascancha[3].vida;
                    
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

            popo.Content = cartascancha[4].nombre + "                \n ocupa mana: " + cartascancha[4].mana + "\n ataca  " + cartascancha[4].ataque + "\n  tiene vida  " + cartascancha[4].vida;
                    

        }

        private void boton8_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Content = "";
        }

        private void boton9_MouseEnter(object sender, MouseEventArgs e)
        {
            popo.Content = cartascancha[5].nombre + "                \n ocupa mana: " + cartascancha[5].mana + "\n ataca  " + cartascancha[5].ataque + "\n  tiene vida  " + cartascancha[5].vida;
                    

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
            popo.Content = cartascancha[6].nombre + "                \n ocupa mana: " + cartascancha[6].mana + "\n ataca  " + cartascancha[6].ataque + "\n  tiene vida  " + cartascancha[6].vida;
                    
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
            popo.Content = cartascancha2[0].nombre + "                \n ocupa mana: " + cartascancha2[0].mana + "\n ataca  " + cartascancha2[0].ataque + "\n  tiene vida  " + cartascancha2[0].vida;
              
           //a2[o].Content = cartascancha2[o].nombre + "                \n ocupa mana: " + cartascancha2[o].mana + "\n ataca  " + cartascancha2[o].ataque + "\n  tiene vida  " + cartascancha2[o].vida;
                       
        }

        private void boton11_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Content = "";
        }

        private void boton12_MouseEnter(object sender, MouseEventArgs e)
        {
            popo.Content = cartascancha2[1].nombre + "                \n ocupa mana: " + cartascancha2[1].mana + "\n ataca  " + cartascancha2[1].ataque + "\n  tiene vida  " + cartascancha2[1].vida;
              

        }

        private void boton12_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Content = "";
        }

        private void boton13_MouseEnter(object sender, MouseEventArgs e)
        {
            popo.Content = cartascancha2[2].nombre + "                \n ocupa mana: " + cartascancha2[2].mana + "\n ataca  " + cartascancha2[2].ataque + "\n  tiene vida  " + cartascancha2[2].vida;
              
        }

        private void boton13_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Content = "";
        }

        private void boton14_MouseEnter(object sender, MouseEventArgs e)
        {
            popo.Content = cartascancha2[3].nombre + "                \n ocupa mana: " + cartascancha2[3].mana + "\n ataca  " + cartascancha2[3].ataque + "\n  tiene vida  " + cartascancha2[3].vida;
              
        }

        private void boton14_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Content = "";
        }

        private void boton15_MouseEnter(object sender, MouseEventArgs e)
        {
            popo.Content = cartascancha2[4].nombre + "                \n ocupa mana: " + cartascancha2[4].mana + "\n ataca  " + cartascancha2[4].ataque + "\n  tiene vida  " + cartascancha2[4].vida;
              
        }

        private void boton15_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Content = "";
        }

        private void boton16_MouseEnter(object sender, MouseEventArgs e)
        {
            popo.Content = cartascancha2[5].nombre + "                \n ocupa mana: " + cartascancha2[5].mana + "\n ataca  " + cartascancha2[5].ataque + "\n  tiene vida  " + cartascancha2[5].vida;
              
        }

        private void boton16_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Content = "";
        }

        private void boton17_MouseEnter(object sender, MouseEventArgs e)
        {
            popo.Content = cartascancha2[6].nombre + "                \n ocupa mana: " + cartascancha2[6].mana + "\n ataca  " + cartascancha2[6].ataque + "\n  tiene vida  " + cartascancha2[6].vida;
              
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
        /*Rendirse J2*/
        private void rendirse2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(j2.nombre + "   Te has rendido ");
            Application.Current.Shutdown();

        }
        /*Comunicarse*/
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
        /*Comunicarse*/
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
        /*Habilidad j1*/
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (j1.tipo == "Paladin")
            {
                minion paladin1 = new minion("Recruit", 1, 1, true, true, 0);
                paladin1.turno = false;
                mazos.Add(paladin1);


                j1.invocar(paladin1, cartascancha);
                

            }
                if (j1.tipo == "Rogue")
            {
                minion rogue = new minion("Dagger Mastery", 2, 1, false, true, 0);
                rogue.turno = false;
                mazos.Add(rogue);
                j1.invocar(rogue, cartascancha);
            }
            if (j1.tipo == "Druid")
            {
                minion druid = new minion("Shapeshift", 2, 0, true, true, 0);
                druid.turno = false;
                mazos.Add(druid);
                j1.invocar(druid, cartascancha);
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
            refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit,j1, j2);





        }
        /*Habilidad*/
        private void habilidad2_Click(object sender, RoutedEventArgs e)
        {

            if (j2.tipo == "Paladin")
            {
                minion paladin1 = new minion("Recruit", 1, 1, true, true, 0);
                paladin1.turno = false;
                mazos.Add(paladin1);
                j2.invocar(paladin1, cartascancha2);
            }
            if (j2.tipo == "Rogue")
            {
                minion rogue = new minion("Dagger Mastery", 2, 1, true, true, 0);
                rogue.turno = false;
                mazos2.Add(rogue);
                j2.invocar(rogue, cartascancha2);
            }
            if (j2.tipo == "Druid")
            {
                minion druid = new minion("Shapeshift", 2, 0, true, true, 0);
                druid.turno = false;
                mazos2.Add(druid);
                j2.invocar(druid, cartascancha2);
            }
            Random rnd = new Random();
            if (j2.tipo == "Shaman")
            {
                int ppp = rnd.Next(4);
                if (ppp == 0)
                {
                    minion shaman1 = new minion("Heilin Totem", 2, 0, true, true, 0);
                    shaman1.turno = false;
                    mazos2.Add(shaman1);
                    j2.invocar(shaman1, cartascancha2);
                }
                if (ppp == 1)
                {
                    minion shaman5 = new minion("Seiring Totem", 1, 1, true, true, 0);
                    shaman5.turno = false;
                    mazos2.Add(shaman5);
                    j2.invocar(shaman5, cartascancha2);
                }
                if (ppp == 2)
                {
                    minion shaman3 = new minion("Stoneclaw Totem", 2, 0, true, true, 0);
                    shaman3.turno = false;
                    mazos2.Add(shaman3);
                    j2.invocar(shaman3, cartascancha2);
                }
                if (ppp == 3)
                {
                    minion shaman4 = new minion("Warth of air Totem", 2, 0, true, true, 0);
                    shaman4.turno = false;
                    mazos2.Add(shaman4);
                    j2.invocar(shaman4, cartascancha2);
                }
            }

            
            j2.habilidad(j1);
            vida1.Content = j1.vida;
            Vida2.Content = j2.vida;
            manadisponible2.Content = j2.mana;
            habilidad2.IsEnabled = false;
            refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit,j1, j2);



        }

        
        /*Jugar carta j1
        private void Listbox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
            if (cartascancha.Count() < 7)
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
                
               
            }
            refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, j1, j2);
        }
        /* Jugar carta J2*/
      /*  private void Listbox_Copy_MouseDoubleClick(object sender, MouseButtonEventArgs e)
       {   if (cartascancha2.Count() < 7)
            {
                
                if (Listbox_Copy.SelectedIndex > 0)
                {
                    if (j2.mano[Listbox_Copy.SelectedIndex - 1].mana <= j2.mana)
                    {
                        j2.jugarcarta(Listbox_Copy.SelectedIndex, cartascancha2);
                        manadisponible2.Content = j2.mana;

                        Listbox_Copy.Items.Remove(Listbox_Copy.SelectedItem);
                    }
                }
            }
            refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit,j1, j2);




        }*/

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

        /*Atacar*/
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
          
            refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit,j1, j2);


            
             
                xx[cartascancha.Count()].Visibility = Visibility.Hidden;

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

        private void habilidad_MouseEnter(object sender, MouseEventArgs e)
        {
            if (j1.tipo == "Mage")
            {
                popo.Content = ("Resta 2 de vida a quien quieras! \nMana:2");
            }
            if (j1.tipo == "Warrior")
            {
                popo.Content = ("Sube 2 de escudo a tu Heroe! \nMana:2");
            }
            if (j1.tipo == "Paladin")
            {
                popo.Content = ("Invoca A un recruit 1/1 , para que te ayude en la pelea! \nMana:2");
            }
            if (j1.tipo == "Hunter")
            {
                popo.Content = ("Restale 2 de vida al heroe de tu contrincante! \n Mana:2");
            }
            
            if (j1.tipo == "Druid")
            {
                popo.Content = ("Convierte en un Oso y ataca a tu enemigo!1/1\n Mana:2");
            }
            if (j1.tipo == "Rogue ")
            {
                popo.Content = ("Invoca un daga de 2/2! \nMana:2");
            }
            if (j1.tipo == "Shaman")
            {
                popo.Content = ("Invoca un Totem!\n Mana:2");
            }
            if (j1.tipo == "Warlock ")
            {
                popo.Content = ("Resta 2 a tu vida , obten una carta!\n Mana:2");
            }
            if (j1.tipo == "Priest")
            {
                popo.Content = ("Sumate Dos de vida!\n Mana:2");
            }
        }

        private void habilidad_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Content = "";
        }

        private void habilidad2_MouseEnter(object sender, MouseEventArgs e)
        {
            if (j2.tipo == "Mage")
            {
                popo.Content = ("Resta 2 de vida a quien quieras! \nMana:2");
            }
            if (j2.tipo == "Warrior")
            {
                popo.Content = ("Sube 2 de escudo a tu Heroe! \nMana:2");
            }
            if (j2.tipo == "Paladin")
            {
                popo.Content = ("Invoca A un recruit 1/1 , para que te ayude en la pelea! \nMana:2");
            }
            if (j2.tipo == "Hunter")
            {
                popo.Content = ("Restale 2 de vida al heroe de tu contrincante! \n Mana:2");
            }

            if (j2.tipo == "Druid")
            {
                popo.Content = ("Convierte en un Oso y ataca a tu enemigo!1/1\n Mana:2");
            }
            if (j2.tipo == "Rogue ")
            {
                popo.Content = ("Invoca un daga de 2/2! \nMana:2");
            }
            if (j2.tipo == "Shaman")
            {
                popo.Content = ("Invoca un Totem!\n Mana:2");
            }
            if (j2.tipo == "Warlock ")
            {
                popo.Content = ("Resta 2 a tu vida , obten una carta!\n Mana:2");
            }
            if (j2.tipo == "Priest")
            {
                popo.Content = ("Sumate Dos de vida!\n Mana:2");
            }
        }

        private void habilidad2_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Content = "";
        }

        private void boton18_Click(object sender, RoutedEventArgs e)
        {
            if (j1.mano[0].mana <= j1.mana)
            {
                j1.jugarcarta(1, cartascancha);
                manadisp.Content = j1.mana;

                
            }
            for (int i = 0; i < manos.Count; i++)
            {
                if (manos[i].nombre == "wisp")
                {
                    manobot[i].Background = wisp;

                }
                if (manos[i].nombre == "Murloc Raider")
                {
                    manobot[i].Background = MurlocRaider;
                }
                if (manos[i].nombre == "Bloodfen Raptor")
                {
                    manobot[i].Background = BloodfenRaptor;
                }
                if (manos[i].nombre == "River Crocolisk")
                {
                    manobot[i].Background = RiverCrocolisk;
                }
                if (manos[i].nombre == "Magma Rager")
                {
                    manobot[i].Background = MagmaRager;
                }
                if (manos[i].nombre == "Chillwind Yeti")
                {
                    manobot[i].Background = ChillwindYeti;
                }
                if (manos[i].nombre == "Oasis Snapjaw")
                {
                    manobot[i].Background = OasisSnapjaw;
                }
                if (manos[i].nombre == "Boulderfist Ogre")
                {
                    manobot[i].Background = BoulderfistOgre;
                }
                if (manos[i].nombre == "War Golem")
                {
                    manobot[i].Background = WarGolem;
                }
                if (manos[i].nombre == "Core Hound")
                {
                    manobot[i].Background = CoreHound;
                }
                manobot[i].Visibility = Visibility.Visible;
            }
            manobot[manos.Count()].Visibility = Visibility.Hidden;
            /*for (int i = 0; i < manos.Count; i++)
            {
                if (manos[i].nombre == "wisp")
                {
                    manobot[i].Background = wisp;

                }
                if (manos[i].nombre == "Murloc Raider")
                {
                    manobot[i].Background = MurlocRaider;
                }
                if (manos[i].nombre == "Bloodfen Raptor")
                {
                    manobot[i].Background = BloodfenRaptor;
                }
                if (manos[i].nombre == "River Crocolisk")
                {
                    manobot[i].Background = RiverCrocolisk;
                }
                if (manos[i].nombre == "Magma Rager")
                {
                    manobot[i].Background = MagmaRager;
                }
                if (manos[i].nombre == "Chillwind Yeti")
                {
                    manobot[i].Background = ChillwindYeti;
                }
                if (manos[i].nombre == "Oasis Snapjaw")
                {
                    manobot[i].Background = OasisSnapjaw;
                }
                if (manos[i].nombre == "Boulderfist Ogre")
                {
                    manobot[i].Background = BoulderfistOgre;
                }
                if (manos[i].nombre == "War Golem")
                {
                    manobot[i].Background = WarGolem;
                }
                if (manos[i].nombre == "Core Hound")
                {
                    manobot[i].Background = CoreHound;
                }
                manobot[i].Visibility = Visibility.Visible;
            }
            manobot[manos.Count()].Visibility = Visibility.Hidden;
             

            /*carta cc = h.mano[a];
            if (cc.GetType().Equals(typeof(minion)))
            {
                minion p = (minion)h.mano[a];
                lista.Add(p);
            }
            */
            refreshhmano(manos, manos2, manobot, manobot1, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, j1, j2);
            refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, j1, j2);

        }

        private void boton18_MouseEnter(object sender, MouseEventArgs e)
        {
            if (manos[0].nombre == "Murloc Raider")
            {
                popo.Background = MurlocRaider;
            }
            if (manos[0].nombre == "Bloodfen Raptor")
            {
                popo.Background = BloodfenRaptor;
            }
            if (manos[0].nombre == "River Crocolisk")
            {
                popo.Background = RiverCrocolisk;
            }
            if (manos[0].nombre == "Magma Rager")
            {
                popo.Background = MagmaRager;
            }
            if (manos[0].nombre == "Chillwind Yeti")
            {
                popo.Background = ChillwindYeti;
            }
            if (manos[0].nombre == "Oasis Snapjaw")
            {
                popo.Background = OasisSnapjaw;
            }
            if (manos[0].nombre == "Boulderfist Ogre")
            {
                popo.Background = BoulderfistOgre;
            }
            if (manos[0].nombre == "War Golem")
            {
                popo.Background = WarGolem;
            }
            if (manos[0].nombre == "Core Hound")
            {
                popo.Background = CoreHound;
            }
            refreshhmano(manos, manos2, manobot, manobot1, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, j1, j2);
            refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, j1, j2);
        }

        private void boton18_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Background = vacio;
        }

        private void boton19_Click(object sender, RoutedEventArgs e)
        {
            if (j1.mano[1].mana <= j1.mana)
            {
                j1.jugarcarta(2, cartascancha);
                manadisp.Content = j1.mana;


            }
            for (int i = 0; i < manos.Count; i++)
            {
                if (manos[i].nombre == "wisp")
                {
                    manobot[i].Background = wisp;

                }
                if (manos[i].nombre == "Murloc Raider")
                {
                    manobot[i].Background = MurlocRaider;
                }
                if (manos[i].nombre == "Bloodfen Raptor")
                {
                    manobot[i].Background = BloodfenRaptor;
                }
                if (manos[i].nombre == "River Crocolisk")
                {
                    manobot[i].Background = RiverCrocolisk;
                }
                if (manos[i].nombre == "Magma Rager")
                {
                    manobot[i].Background = MagmaRager;
                }
                if (manos[i].nombre == "Chillwind Yeti")
                {
                    manobot[i].Background = ChillwindYeti;
                }
                if (manos[i].nombre == "Oasis Snapjaw")
                {
                    manobot[i].Background = OasisSnapjaw;
                }
                if (manos[i].nombre == "Boulderfist Ogre")
                {
                    manobot[i].Background = BoulderfistOgre;
                }
                if (manos[i].nombre == "War Golem")
                {
                    manobot[i].Background = WarGolem;
                }
                if (manos[i].nombre == "Core Hound")
                {
                    manobot[i].Background = CoreHound;
                }
                manobot[i].Visibility = Visibility.Visible;
            }
            manobot[manos.Count()].Visibility = Visibility.Hidden;
            refreshhmano(manos, manos2, manobot, manobot1, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, j1, j2);
            refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, j1, j2);
        }

        private void boton20_Click(object sender, RoutedEventArgs e)
        {
            if (j1.mano[2].mana <= j1.mana)
            {
                j1.jugarcarta(3, cartascancha);
                manadisp.Content = j1.mana;


            }
            for (int i = 0; i < manos.Count; i++)
            {
                if (manos[i].nombre == "wisp")
                {
                    manobot[i].Background = wisp;

                }
                if (manos[i].nombre == "Murloc Raider")
                {
                    manobot[i].Background = MurlocRaider;
                }
                if (manos[i].nombre == "Bloodfen Raptor")
                {
                    manobot[i].Background = BloodfenRaptor;
                }
                if (manos[i].nombre == "River Crocolisk")
                {
                    manobot[i].Background = RiverCrocolisk;
                }
                if (manos[i].nombre == "Magma Rager")
                {
                    manobot[i].Background = MagmaRager;
                }
                if (manos[i].nombre == "Chillwind Yeti")
                {
                    manobot[i].Background = ChillwindYeti;
                }
                if (manos[i].nombre == "Oasis Snapjaw")
                {
                    manobot[i].Background = OasisSnapjaw;
                }
                if (manos[i].nombre == "Boulderfist Ogre")
                {
                    manobot[i].Background = BoulderfistOgre;
                }
                if (manos[i].nombre == "War Golem")
                {
                    manobot[i].Background = WarGolem;
                }
                if (manos[i].nombre == "Core Hound")
                {
                    manobot[i].Background = CoreHound;
                }
                manobot[i].Visibility = Visibility.Visible;
            }
            manobot[manos.Count()].Visibility = Visibility.Hidden;

            refreshhmano(manos, manos2, manobot, manobot1, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, j1, j2);
            refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, j1, j2);
        }

        private void boton21_Click(object sender, RoutedEventArgs e)
        {
            if (j1.mano[3].mana <= j1.mana)
            {
                j1.jugarcarta(4, cartascancha);
                manadisp.Content = j1.mana;


            }
            for (int i = 0; i < manos.Count; i++)
            {
                if (manos[i].nombre == "wisp")
                {
                    manobot[i].Background = wisp;

                }
                if (manos[i].nombre == "Murloc Raider")
                {
                    manobot[i].Background = MurlocRaider;
                }
                if (manos[i].nombre == "Bloodfen Raptor")
                {
                    manobot[i].Background = BloodfenRaptor;
                }
                if (manos[i].nombre == "River Crocolisk")
                {
                    manobot[i].Background = RiverCrocolisk;
                }
                if (manos[i].nombre == "Magma Rager")
                {
                    manobot[i].Background = MagmaRager;
                }
                if (manos[i].nombre == "Chillwind Yeti")
                {
                    manobot[i].Background = ChillwindYeti;
                }
                if (manos[i].nombre == "Oasis Snapjaw")
                {
                    manobot[i].Background = OasisSnapjaw;
                }
                if (manos[i].nombre == "Boulderfist Ogre")
                {
                    manobot[i].Background = BoulderfistOgre;
                }
                if (manos[i].nombre == "War Golem")
                {
                    manobot[i].Background = WarGolem;
                }
                if (manos[i].nombre == "Core Hound")
                {
                    manobot[i].Background = CoreHound;
                }
                manobot[i].Visibility = Visibility.Visible;
            }
            manobot[manos.Count()].Visibility = Visibility.Hidden;

            refreshhmano(manos, manos2, manobot, manobot1, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, j1, j2);
            refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, j1, j2);
        }

        private void boton22_Click(object sender, RoutedEventArgs e)
        {
            if (j1.mano[4].mana <= j1.mana)
            {
                j1.jugarcarta(5, cartascancha);
                manadisp.Content = j1.mana;


            }
            for (int i = 0; i < manos.Count; i++)
            {
                if (manos[i].nombre == "wisp")
                {
                    manobot[i].Background = wisp;

                }
                if (manos[i].nombre == "Murloc Raider")
                {
                    manobot[i].Background = MurlocRaider;
                }
                if (manos[i].nombre == "Bloodfen Raptor")
                {
                    manobot[i].Background = BloodfenRaptor;
                }
                if (manos[i].nombre == "River Crocolisk")
                {
                    manobot[i].Background = RiverCrocolisk;
                }
                if (manos[i].nombre == "Magma Rager")
                {
                    manobot[i].Background = MagmaRager;
                }
                if (manos[i].nombre == "Chillwind Yeti")
                {
                    manobot[i].Background = ChillwindYeti;
                }
                if (manos[i].nombre == "Oasis Snapjaw")
                {
                    manobot[i].Background = OasisSnapjaw;
                }
                if (manos[i].nombre == "Boulderfist Ogre")
                {
                    manobot[i].Background = BoulderfistOgre;
                }
                if (manos[i].nombre == "War Golem")
                {
                    manobot[i].Background = WarGolem;
                }
                if (manos[i].nombre == "Core Hound")
                {
                    manobot[i].Background = CoreHound;
                }
                manobot[i].Visibility = Visibility.Visible;
            }
            manobot[manos.Count()].Visibility = Visibility.Hidden;

            refreshhmano(manos, manos2, manobot, manobot1, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, j1, j2);
            refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, j1, j2);
        }

        private void boton23_Click(object sender, RoutedEventArgs e)
        {
            if (j1.mano[5].mana <= j1.mana)
            {
                j1.jugarcarta(6, cartascancha);
                manadisp.Content = j1.mana;


            }
            for (int i = 0; i < manos.Count; i++)
            {
                if (manos[i].nombre == "wisp")
                {
                    manobot[i].Background = wisp;

                }
                if (manos[i].nombre == "Murloc Raider")
                {
                    manobot[i].Background = MurlocRaider;
                }
                if (manos[i].nombre == "Bloodfen Raptor")
                {
                    manobot[i].Background = BloodfenRaptor;
                }
                if (manos[i].nombre == "River Crocolisk")
                {
                    manobot[i].Background = RiverCrocolisk;
                }
                if (manos[i].nombre == "Magma Rager")
                {
                    manobot[i].Background = MagmaRager;
                }
                if (manos[i].nombre == "Chillwind Yeti")
                {
                    manobot[i].Background = ChillwindYeti;
                }
                if (manos[i].nombre == "Oasis Snapjaw")
                {
                    manobot[i].Background = OasisSnapjaw;
                }
                if (manos[i].nombre == "Boulderfist Ogre")
                {
                    manobot[i].Background = BoulderfistOgre;
                }
                if (manos[i].nombre == "War Golem")
                {
                    manobot[i].Background = WarGolem;
                }
                if (manos[i].nombre == "Core Hound")
                {
                    manobot[i].Background = CoreHound;
                }
                manobot[i].Visibility = Visibility.Visible;
            }
            manobot[manos.Count()].Visibility = Visibility.Hidden;

            refreshhmano(manos, manos2, manobot, manobot1, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, j1, j2);
            refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, j1, j2);
        }

        private void boton24_Click(object sender, RoutedEventArgs e)
        {
            if (j1.mano[6].mana <= j1.mana)
            {
                j1.jugarcarta(7, cartascancha);
                manadisp.Content = j1.mana;


            }
            for (int i = 0; i < manos.Count; i++)
            {
                if (manos[i].nombre == "wisp")
                {
                    manobot[i].Background = wisp;

                }
                if (manos[i].nombre == "Murloc Raider")
                {
                    manobot[i].Background = MurlocRaider;
                }
                if (manos[i].nombre == "Bloodfen Raptor")
                {
                    manobot[i].Background = BloodfenRaptor;
                }
                if (manos[i].nombre == "River Crocolisk")
                {
                    manobot[i].Background = RiverCrocolisk;
                }
                if (manos[i].nombre == "Magma Rager")
                {
                    manobot[i].Background = MagmaRager;
                }
                if (manos[i].nombre == "Chillwind Yeti")
                {
                    manobot[i].Background = ChillwindYeti;
                }
                if (manos[i].nombre == "Oasis Snapjaw")
                {
                    manobot[i].Background = OasisSnapjaw;
                }
                if (manos[i].nombre == "Boulderfist Ogre")
                {
                    manobot[i].Background = BoulderfistOgre;
                }
                if (manos[i].nombre == "War Golem")
                {
                    manobot[i].Background = WarGolem;
                }
                if (manos[i].nombre == "Core Hound")
                {
                    manobot[i].Background = CoreHound;
                }
                manobot[i].Visibility = Visibility.Visible;
            }
            manobot[manos.Count()].Visibility = Visibility.Hidden;

            refreshhmano(manos, manos2, manobot, manobot1, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, j1, j2);
            refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, j1, j2);
        }

        private void boton25_Click(object sender, RoutedEventArgs e)
        {
            if (j1.mano[7].mana <= j1.mana)
            {
                j1.jugarcarta(8, cartascancha);
                manadisp.Content = j1.mana;


            }
            for (int i = 0; i < manos.Count; i++)
            {
                if (manos[i].nombre == "wisp")
                {
                    manobot[i].Background = wisp;

                }
                if (manos[i].nombre == "Murloc Raider")
                {
                    manobot[i].Background = MurlocRaider;
                }
                if (manos[i].nombre == "Bloodfen Raptor")
                {
                    manobot[i].Background = BloodfenRaptor;
                }
                if (manos[i].nombre == "River Crocolisk")
                {
                    manobot[i].Background = RiverCrocolisk;
                }
                if (manos[i].nombre == "Magma Rager")
                {
                    manobot[i].Background = MagmaRager;
                }
                if (manos[i].nombre == "Chillwind Yeti")
                {
                    manobot[i].Background = ChillwindYeti;
                }
                if (manos[i].nombre == "Oasis Snapjaw")
                {
                    manobot[i].Background = OasisSnapjaw;
                }
                if (manos[i].nombre == "Boulderfist Ogre")
                {
                    manobot[i].Background = BoulderfistOgre;
                }
                if (manos[i].nombre == "War Golem")
                {
                    manobot[i].Background = WarGolem;
                }
                if (manos[i].nombre == "Core Hound")
                {
                    manobot[i].Background = CoreHound;
                }
                manobot[i].Visibility = Visibility.Visible;
            }
            manobot[manos.Count()].Visibility = Visibility.Hidden;

            refreshhmano(manos, manos2, manobot, manobot1, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, j1, j2);
            refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, j1, j2);
        }

        private void boton24_Copy_Click(object sender, RoutedEventArgs e)
        {
            if (j1.mano[8].mana <= j1.mana)
            {
                j1.jugarcarta(9, cartascancha);
                manadisp.Content = j1.mana;


            }
            for (int i = 0; i < manos.Count; i++)
            {
                if (manos[i].nombre == "wisp")
                {
                    manobot[i].Background = wisp;

                }
                if (manos[i].nombre == "Murloc Raider")
                {
                    manobot[i].Background = MurlocRaider;
                }
                if (manos[i].nombre == "Bloodfen Raptor")
                {
                    manobot[i].Background = BloodfenRaptor;
                }
                if (manos[i].nombre == "River Crocolisk")
                {
                    manobot[i].Background = RiverCrocolisk;
                }
                if (manos[i].nombre == "Magma Rager")
                {
                    manobot[i].Background = MagmaRager;
                }
                if (manos[i].nombre == "Chillwind Yeti")
                {
                    manobot[i].Background = ChillwindYeti;
                }
                if (manos[i].nombre == "Oasis Snapjaw")
                {
                    manobot[i].Background = OasisSnapjaw;
                }
                if (manos[i].nombre == "Boulderfist Ogre")
                {
                    manobot[i].Background = BoulderfistOgre;
                }
                if (manos[i].nombre == "War Golem")
                {
                    manobot[i].Background = WarGolem;
                }
                if (manos[i].nombre == "Core Hound")
                {
                    manobot[i].Background = CoreHound;
                }
                manobot[i].Visibility = Visibility.Visible;
            }
            manobot[manos.Count()].Visibility = Visibility.Hidden;

            refreshhmano(manos, manos2, manobot, manobot1, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, j1, j2);
            refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, j1, j2);
        }

        private void boton24_Copy1_Click(object sender, RoutedEventArgs e)
        {
            if (j1.mano[9].mana <= j1.mana)
            {
                j1.jugarcarta(10, cartascancha);
                manadisp.Content = j1.mana;


            }
            for (int i = 0; i < manos.Count; i++)
            {
                if (manos[i].nombre == "wisp")
                {
                    manobot[i].Background = wisp;

                }
                if (manos[i].nombre == "Murloc Raider")
                {
                    manobot[i].Background = MurlocRaider;
                }
                if (manos[i].nombre == "Bloodfen Raptor")
                {
                    manobot[i].Background = BloodfenRaptor;
                }
                if (manos[i].nombre == "River Crocolisk")
                {
                    manobot[i].Background = RiverCrocolisk;
                }
                if (manos[i].nombre == "Magma Rager")
                {
                    manobot[i].Background = MagmaRager;
                }
                if (manos[i].nombre == "Chillwind Yeti")
                {
                    manobot[i].Background = ChillwindYeti;
                }
                if (manos[i].nombre == "Oasis Snapjaw")
                {
                    manobot[i].Background = OasisSnapjaw;
                }
                if (manos[i].nombre == "Boulderfist Ogre")
                {
                    manobot[i].Background = BoulderfistOgre;
                }
                if (manos[i].nombre == "War Golem")
                {
                    manobot[i].Background = WarGolem;
                }
                if (manos[i].nombre == "Core Hound")
                {
                    manobot[i].Background = CoreHound;
                }
                manobot[i].Visibility = Visibility.Visible;
            }
            manobot[manos.Count()].Visibility = Visibility.Hidden;

            refreshhmano(manos, manos2, manobot, manobot1, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, j1, j2);
            refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, j1, j2);
        }

        private void boton26_Click(object sender, RoutedEventArgs e)
        {
            if (j2.mano[0].mana <= j2.mana)
            {
                j2.jugarcarta(1, cartascancha2);
                manadisponible2.Content = j2.mana;


            }
            for (int i = 0; i < manos2.Count; i++)
            {
                if (manos2[i].nombre == "wisp")
                {
                    manobot1[i].Background = wisp;

                }
                if (manos2[i].nombre == "Murloc Raider")
                {
                    manobot1[i].Background = MurlocRaider;
                }
                if (manos2[i].nombre == "Bloodfen Raptor")
                {
                    manobot1[i].Background = BloodfenRaptor;
                }
                if (manos2[i].nombre == "River Crocolisk")
                {
                    manobot1[i].Background = RiverCrocolisk;
                }
                if (manos2[i].nombre == "Magma Rager")
                {
                    manobot1[i].Background = MagmaRager;
                }
                if (manos2[i].nombre == "Chillwind Yeti")
                {
                    manobot1[i].Background = ChillwindYeti;
                }
                if (manos2[i].nombre == "Oasis Snapjaw")
                {
                    manobot1[i].Background = OasisSnapjaw;
                }
                if (manos2[i].nombre == "Boulderfist Ogre")
                {
                    manobot1[i].Background = BoulderfistOgre;
                }
                if (manos2[i].nombre == "War Golem")
                {
                    manobot1[i].Background = WarGolem;
                }
                if (manos2[i].nombre == "Core Hound")
                {
                    manobot1[i].Background = CoreHound;
                }
                manobot1[i].Visibility = Visibility.Visible;
            }
            manobot1[manos2.Count()].Visibility = Visibility.Hidden;

            refreshhmano(manos, manos2, manobot, manobot1, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, j1, j2);
            refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, j1, j2);

        }

        private void boton27_Click(object sender, RoutedEventArgs e)
        {
            if (j2.mano[1].mana <= j2.mana)
            {
                j2.jugarcarta(2, cartascancha2);
                manadisponible2.Content = j2.mana;


            }
            for (int i = 0; i < manos2.Count; i++)
            {
                if (manos2[i].nombre == "wisp")
                {
                    manobot1[i].Background = wisp;

                }
                if (manos2[i].nombre == "Murloc Raider")
                {
                    manobot1[i].Background = MurlocRaider;
                }
                if (manos2[i].nombre == "Bloodfen Raptor")
                {
                    manobot1[i].Background = BloodfenRaptor;
                }
                if (manos2[i].nombre == "River Crocolisk")
                {
                    manobot1[i].Background = RiverCrocolisk;
                }
                if (manos2[i].nombre == "Magma Rager")
                {
                    manobot1[i].Background = MagmaRager;
                }
                if (manos2[i].nombre == "Chillwind Yeti")
                {
                    manobot1[i].Background = ChillwindYeti;
                }
                if (manos2[i].nombre == "Oasis Snapjaw")
                {
                    manobot1[i].Background = OasisSnapjaw;
                }
                if (manos2[i].nombre == "Boulderfist Ogre")
                {
                    manobot1[i].Background = BoulderfistOgre;
                }
                if (manos2[i].nombre == "War Golem")
                {
                    manobot1[i].Background = WarGolem;
                }
                if (manos2[i].nombre == "Core Hound")
                {
                    manobot1[i].Background = CoreHound;
                }
                manobot1[i].Visibility = Visibility.Visible;
            }
            manobot1[manos2.Count()].Visibility = Visibility.Hidden;

            refreshhmano(manos, manos2, manobot, manobot1, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, j1, j2);
            refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, j1, j2);

        }

        private void boton28_Click(object sender, RoutedEventArgs e)
        {
            if (j2.mano[2].mana <= j2.mana)
            {
                j2.jugarcarta(3, cartascancha2);
                manadisponible2.Content = j2.mana;


            }
            for (int i = 0; i < manos2.Count; i++)
            {
                if (manos2[i].nombre == "wisp")
                {
                    manobot1[i].Background = wisp;

                }
                if (manos2[i].nombre == "Murloc Raider")
                {
                    manobot1[i].Background = MurlocRaider;
                }
                if (manos2[i].nombre == "Bloodfen Raptor")
                {
                    manobot1[i].Background = BloodfenRaptor;
                }
                if (manos2[i].nombre == "River Crocolisk")
                {
                    manobot1[i].Background = RiverCrocolisk;
                }
                if (manos2[i].nombre == "Magma Rager")
                {
                    manobot1[i].Background = MagmaRager;
                }
                if (manos2[i].nombre == "Chillwind Yeti")
                {
                    manobot1[i].Background = ChillwindYeti;
                }
                if (manos2[i].nombre == "Oasis Snapjaw")
                {
                    manobot1[i].Background = OasisSnapjaw;
                }
                if (manos2[i].nombre == "Boulderfist Ogre")
                {
                    manobot1[i].Background = BoulderfistOgre;
                }
                if (manos2[i].nombre == "War Golem")
                {
                    manobot1[i].Background = WarGolem;
                }
                if (manos2[i].nombre == "Core Hound")
                {
                    manobot1[i].Background = CoreHound;
                }
                manobot1[i].Visibility = Visibility.Visible;
            }
            manobot1[manos2.Count()].Visibility = Visibility.Hidden;

            refreshhmano(manos, manos2, manobot, manobot1, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, j1, j2);
            refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, j1, j2);

        }

        private void boton29_Click(object sender, RoutedEventArgs e)
        {
            if (j2.mano[3].mana <= j2.mana)
            {
                j2.jugarcarta(4, cartascancha2);
                manadisponible2.Content = j2.mana;


            }
            for (int i = 0; i < manos2.Count; i++)
            {
                if (manos2[i].nombre == "wisp")
                {
                    manobot1[i].Background = wisp;

                }
                if (manos2[i].nombre == "Murloc Raider")
                {
                    manobot1[i].Background = MurlocRaider;
                }
                if (manos2[i].nombre == "Bloodfen Raptor")
                {
                    manobot1[i].Background = BloodfenRaptor;
                }
                if (manos2[i].nombre == "River Crocolisk")
                {
                    manobot1[i].Background = RiverCrocolisk;
                }
                if (manos2[i].nombre == "Magma Rager")
                {
                    manobot1[i].Background = MagmaRager;
                }
                if (manos2[i].nombre == "Chillwind Yeti")
                {
                    manobot1[i].Background = ChillwindYeti;
                }
                if (manos2[i].nombre == "Oasis Snapjaw")
                {
                    manobot1[i].Background = OasisSnapjaw;
                }
                if (manos2[i].nombre == "Boulderfist Ogre")
                {
                    manobot1[i].Background = BoulderfistOgre;
                }
                if (manos2[i].nombre == "War Golem")
                {
                    manobot1[i].Background = WarGolem;
                }
                if (manos2[i].nombre == "Core Hound")
                {
                    manobot1[i].Background = CoreHound;
                }
                manobot1[i].Visibility = Visibility.Visible;
            }
            manobot1[manos2.Count()].Visibility = Visibility.Hidden;

            refreshhmano(manos, manos2, manobot, manobot1, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, j1, j2);
            refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, j1, j2);

        }

        private void boton30_Click(object sender, RoutedEventArgs e)
        {
            if (j2.mano[4].mana <= j2.mana)
            {
                j2.jugarcarta(5, cartascancha2);
                manadisponible2.Content = j2.mana;


            }
            for (int i = 0; i < manos2.Count; i++)
            {
                if (manos2[i].nombre == "wisp")
                {
                    manobot1[i].Background = wisp;

                }
                if (manos2[i].nombre == "Murloc Raider")
                {
                    manobot1[i].Background = MurlocRaider;
                }
                if (manos2[i].nombre == "Bloodfen Raptor")
                {
                    manobot1[i].Background = BloodfenRaptor;
                }
                if (manos2[i].nombre == "River Crocolisk")
                {
                    manobot1[i].Background = RiverCrocolisk;
                }
                if (manos2[i].nombre == "Magma Rager")
                {
                    manobot1[i].Background = MagmaRager;
                }
                if (manos2[i].nombre == "Chillwind Yeti")
                {
                    manobot1[i].Background = ChillwindYeti;
                }
                if (manos2[i].nombre == "Oasis Snapjaw")
                {
                    manobot1[i].Background = OasisSnapjaw;
                }
                if (manos2[i].nombre == "Boulderfist Ogre")
                {
                    manobot1[i].Background = BoulderfistOgre;
                }
                if (manos2[i].nombre == "War Golem")
                {
                    manobot1[i].Background = WarGolem;
                }
                if (manos2[i].nombre == "Core Hound")
                {
                    manobot1[i].Background = CoreHound;
                }
                manobot1[i].Visibility = Visibility.Visible;
            }
            manobot1[manos2.Count()].Visibility = Visibility.Hidden;

            refreshhmano(manos, manos2, manobot, manobot1, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, j1, j2);
            refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, j1, j2);

        }

        private void boton31_Click(object sender, RoutedEventArgs e)
        {
            if (j2.mano[5].mana <= j2.mana)
            {
                j2.jugarcarta(6, cartascancha2);
                manadisponible2.Content = j2.mana;


            }
            for (int i = 0; i < manos2.Count; i++)
            {
                if (manos2[i].nombre == "wisp")
                {
                    manobot1[i].Background = wisp;

                }
                if (manos2[i].nombre == "Murloc Raider")
                {
                    manobot1[i].Background = MurlocRaider;
                }
                if (manos2[i].nombre == "Bloodfen Raptor")
                {
                    manobot1[i].Background = BloodfenRaptor;
                }
                if (manos2[i].nombre == "River Crocolisk")
                {
                    manobot1[i].Background = RiverCrocolisk;
                }
                if (manos2[i].nombre == "Magma Rager")
                {
                    manobot1[i].Background = MagmaRager;
                }
                if (manos2[i].nombre == "Chillwind Yeti")
                {
                    manobot1[i].Background = ChillwindYeti;
                }
                if (manos2[i].nombre == "Oasis Snapjaw")
                {
                    manobot1[i].Background = OasisSnapjaw;
                }
                if (manos2[i].nombre == "Boulderfist Ogre")
                {
                    manobot1[i].Background = BoulderfistOgre;
                }
                if (manos2[i].nombre == "War Golem")
                {
                    manobot1[i].Background = WarGolem;
                }
                if (manos2[i].nombre == "Core Hound")
                {
                    manobot1[i].Background = CoreHound;
                }
                manobot1[i].Visibility = Visibility.Visible;
            }
            manobot1[manos2.Count()].Visibility = Visibility.Hidden;

            refreshhmano(manos, manos2, manobot, manobot1, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, j1, j2);
            refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, j1, j2);

        }

        private void boton32_Click(object sender, RoutedEventArgs e)
        {
            if (j2.mano[6].mana <= j2.mana)
            {
                j2.jugarcarta(7, cartascancha2);
                manadisponible2.Content = j2.mana;


            }
            for (int i = 0; i < manos2.Count; i++)
            {
                if (manos2[i].nombre == "wisp")
                {
                    manobot1[i].Background = wisp;

                }
                if (manos2[i].nombre == "Murloc Raider")
                {
                    manobot1[i].Background = MurlocRaider;
                }
                if (manos2[i].nombre == "Bloodfen Raptor")
                {
                    manobot1[i].Background = BloodfenRaptor;
                }
                if (manos2[i].nombre == "River Crocolisk")
                {
                    manobot1[i].Background = RiverCrocolisk;
                }
                if (manos2[i].nombre == "Magma Rager")
                {
                    manobot1[i].Background = MagmaRager;
                }
                if (manos2[i].nombre == "Chillwind Yeti")
                {
                    manobot1[i].Background = ChillwindYeti;
                }
                if (manos2[i].nombre == "Oasis Snapjaw")
                {
                    manobot1[i].Background = OasisSnapjaw;
                }
                if (manos2[i].nombre == "Boulderfist Ogre")
                {
                    manobot1[i].Background = BoulderfistOgre;
                }
                if (manos2[i].nombre == "War Golem")
                {
                    manobot1[i].Background = WarGolem;
                }
                if (manos2[i].nombre == "Core Hound")
                {
                    manobot1[i].Background = CoreHound;
                }
                manobot1[i].Visibility = Visibility.Visible;
            }
            manobot1[manos2.Count()].Visibility = Visibility.Hidden;

            refreshhmano(manos, manos2, manobot, manobot1, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, j1, j2);
            refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, j1, j2);

        }

        private void boton33_Click(object sender, RoutedEventArgs e)
        {
            if (j2.mano[7].mana <= j2.mana)
            {
                j2.jugarcarta(8, cartascancha2);
                manadisponible2.Content = j2.mana;


            }
            for (int i = 0; i < manos2.Count; i++)
            {
                if (manos2[i].nombre == "wisp")
                {
                    manobot1[i].Background = wisp;

                }
                if (manos2[i].nombre == "Murloc Raider")
                {
                    manobot1[i].Background = MurlocRaider;
                }
                if (manos2[i].nombre == "Bloodfen Raptor")
                {
                    manobot1[i].Background = BloodfenRaptor;
                }
                if (manos2[i].nombre == "River Crocolisk")
                {
                    manobot1[i].Background = RiverCrocolisk;
                }
                if (manos2[i].nombre == "Magma Rager")
                {
                    manobot1[i].Background = MagmaRager;
                }
                if (manos2[i].nombre == "Chillwind Yeti")
                {
                    manobot1[i].Background = ChillwindYeti;
                }
                if (manos2[i].nombre == "Oasis Snapjaw")
                {
                    manobot1[i].Background = OasisSnapjaw;
                }
                if (manos2[i].nombre == "Boulderfist Ogre")
                {
                    manobot1[i].Background = BoulderfistOgre;
                }
                if (manos2[i].nombre == "War Golem")
                {
                    manobot1[i].Background = WarGolem;
                }
                if (manos2[i].nombre == "Core Hound")
                {
                    manobot1[i].Background = CoreHound;
                }
                manobot1[i].Visibility = Visibility.Visible;
            }
            manobot1[manos2.Count()].Visibility = Visibility.Hidden;

            refreshhmano(manos, manos2, manobot, manobot1, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, j1, j2);
            refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, j1, j2);

        }

        private void boton24_Copy3_Click(object sender, RoutedEventArgs e)
        {
            if (j2.mano[8].mana <= j2.mana)
            {
                j2.jugarcarta(9, cartascancha2);
                manadisponible2.Content = j2.mana;


            }
            for (int i = 0; i < manos2.Count; i++)
            {
                if (manos2[i].nombre == "wisp")
                {
                    manobot1[i].Background = wisp;

                }
                if (manos2[i].nombre == "Murloc Raider")
                {
                    manobot1[i].Background = MurlocRaider;
                }
                if (manos2[i].nombre == "Bloodfen Raptor")
                {
                    manobot1[i].Background = BloodfenRaptor;
                }
                if (manos2[i].nombre == "River Crocolisk")
                {
                    manobot1[i].Background = RiverCrocolisk;
                }
                if (manos2[i].nombre == "Magma Rager")
                {
                    manobot1[i].Background = MagmaRager;
                }
                if (manos2[i].nombre == "Chillwind Yeti")
                {
                    manobot1[i].Background = ChillwindYeti;
                }
                if (manos2[i].nombre == "Oasis Snapjaw")
                {
                    manobot1[i].Background = OasisSnapjaw;
                }
                if (manos2[i].nombre == "Boulderfist Ogre")
                {
                    manobot1[i].Background = BoulderfistOgre;
                }
                if (manos2[i].nombre == "War Golem")
                {
                    manobot1[i].Background = WarGolem;
                }
                if (manos2[i].nombre == "Core Hound")
                {
                    manobot1[i].Background = CoreHound;
                }
                manobot1[i].Visibility = Visibility.Visible;
            }
            manobot1[manos2.Count()].Visibility = Visibility.Hidden;

            refreshhmano(manos, manos2, manobot, manobot1, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, j1, j2);
            refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, j1, j2);

        }

        private void boton24_Copy4_Click(object sender, RoutedEventArgs e)
        {
            if (j2.mano[9].mana <= j2.mana)
            {
                j2.jugarcarta(10, cartascancha2);
                manadisponible2.Content = j2.mana;


            }
            for (int i = 0; i < manos2.Count; i++)
            {
                if (manos2[i].nombre == "wisp")
                {
                    manobot1[i].Background = wisp;

                }
                if (manos2[i].nombre == "Murloc Raider")
                {
                    manobot1[i].Background = MurlocRaider;
                }
                if (manos2[i].nombre == "Bloodfen Raptor")
                {
                    manobot1[i].Background = BloodfenRaptor;
                }
                if (manos2[i].nombre == "River Crocolisk")
                {
                    manobot1[i].Background = RiverCrocolisk;
                }
                if (manos2[i].nombre == "Magma Rager")
                {
                    manobot1[i].Background = MagmaRager;
                }
                if (manos2[i].nombre == "Chillwind Yeti")
                {
                    manobot1[i].Background = ChillwindYeti;
                }
                if (manos2[i].nombre == "Oasis Snapjaw")
                {
                    manobot1[i].Background = OasisSnapjaw;
                }
                if (manos2[i].nombre == "Boulderfist Ogre")
                {
                    manobot1[i].Background = BoulderfistOgre;
                }
                if (manos2[i].nombre == "War Golem")
                {
                    manobot1[i].Background = WarGolem;
                }
                if (manos2[i].nombre == "Core Hound")
                {
                    manobot1[i].Background = CoreHound;
                }
                manobot1[i].Visibility = Visibility.Visible;
            }
            manobot1[manos2.Count()].Visibility = Visibility.Hidden;

            refreshhmano(manos, manos2, manobot, manobot1, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, j1, j2);
            refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, j1, j2);

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