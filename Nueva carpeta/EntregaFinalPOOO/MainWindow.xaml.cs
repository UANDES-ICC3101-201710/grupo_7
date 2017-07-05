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
using System.IO;

namespace EntregaFinalPOOO
{


    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();

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
        ImageBrush wispmano = new ImageBrush();
        ImageBrush MurlocRaider = new ImageBrush();
        ImageBrush MurlocRaidermano = new ImageBrush();
        ImageBrush BloodfenRaptormano = new ImageBrush();
        ImageBrush BloodfenRaptor = new ImageBrush();
        ImageBrush BloodfenRaptor1 = new ImageBrush();
        ImageBrush RiverCrocoliskmano = new ImageBrush();
        ImageBrush RiverCrocolisk = new ImageBrush();
        ImageBrush RiverCrocolisk1 = new ImageBrush();
        ImageBrush RiverCrocolisk2 = new ImageBrush();
        ImageBrush MagmaRagermano = new ImageBrush();
        ImageBrush MagmaRager = new ImageBrush();
        ImageBrush ChillwindYetimano = new ImageBrush();
        ImageBrush ChillwindYeti = new ImageBrush();
        ImageBrush ChillwindYeti1 = new ImageBrush();
        ImageBrush ChillwindYeti2 = new ImageBrush();
        ImageBrush ChillwindYeti3 = new ImageBrush();
        ImageBrush ChillwindYeti4 = new ImageBrush();
        ImageBrush OasisSnapjawmano = new ImageBrush();
        ImageBrush OasisSnapjaw = new ImageBrush();
        ImageBrush OasisSnapjaw1 = new ImageBrush();
        ImageBrush OasisSnapjaw2 = new ImageBrush();
        ImageBrush OasisSnapjaw3 = new ImageBrush();
        ImageBrush OasisSnapjaw4 = new ImageBrush();
        ImageBrush OasisSnapjaw5 = new ImageBrush();
        ImageBrush OasisSnapjaw6 = new ImageBrush();
        ImageBrush BoulderfistOgremano = new ImageBrush();
        ImageBrush BoulderfistOgre = new ImageBrush();
        ImageBrush BoulderfistOgre1 = new ImageBrush();
        ImageBrush BoulderfistOgre2 = new ImageBrush();
        ImageBrush BoulderfistOgre3 = new ImageBrush();
        ImageBrush BoulderfistOgre4 = new ImageBrush();
        ImageBrush BoulderfistOgre5 = new ImageBrush();
        ImageBrush BoulderfistOgre6 = new ImageBrush();
        ImageBrush WarGolemmano = new ImageBrush();
        ImageBrush WarGolem = new ImageBrush();
        ImageBrush WarGolem1 = new ImageBrush();
        ImageBrush WarGolem2 = new ImageBrush();
        ImageBrush WarGolem3 = new ImageBrush();
        ImageBrush WarGolem4 = new ImageBrush();
        ImageBrush WarGolem5 = new ImageBrush();
        ImageBrush WarGolem6 = new ImageBrush();
        ImageBrush CoreHoundmano = new ImageBrush();
        ImageBrush CoreHound = new ImageBrush();
        ImageBrush CoreHound1 = new ImageBrush();
        ImageBrush CoreHound2 = new ImageBrush();
        ImageBrush CoreHound3 = new ImageBrush();
        ImageBrush CoreHound4 = new ImageBrush();

        ImageBrush playb = new ImageBrush();

        ImageBrush vacio = new ImageBrush();
        ImageBrush totem11 = new ImageBrush();
        ImageBrush totem111 = new ImageBrush();
        ImageBrush totem22 = new ImageBrush();
        ImageBrush totem221 = new ImageBrush();
        ImageBrush totem33 = new ImageBrush();
        ImageBrush totem331 = new ImageBrush();
        ImageBrush totem44 = new ImageBrush();
        ImageBrush Recruit = new ImageBrush();
        ImageBrush lala = new ImageBrush();
        ImageBrush habhunter = new ImageBrush();
        ImageBrush habmage = new ImageBrush();
        ImageBrush habpaladin = new ImageBrush();
        ImageBrush habpriest = new ImageBrush();
        ImageBrush habrogue = new ImageBrush();
        ImageBrush habshaman = new ImageBrush();
        ImageBrush habwarlock = new ImageBrush();
        ImageBrush habwarrior = new ImageBrush();
        ImageBrush habdruid = new ImageBrush();

        ImageBrush FondoIni = new ImageBrush();

        ImageBrush escudo = new ImageBrush();
        ImageBrush daga = new ImageBrush();
        ImageBrush noaudio = new ImageBrush();
        ImageBrush druidex = new ImageBrush();
        ImageBrush warriorex = new ImageBrush();
        ImageBrush mageex = new ImageBrush();
        ImageBrush priestex = new ImageBrush();
        ImageBrush warlockex = new ImageBrush();
        ImageBrush shamanex = new ImageBrush();
        ImageBrush hunterex = new ImageBrush();
        ImageBrush paladinex = new ImageBrush();
        ImageBrush rogueex = new ImageBrush();


        ImageBrush oso = new ImageBrush();




        List<carta> mazos = new List<carta>();
        List<carta> mazos2 = new List<carta>();

        List<Button> a2 = new List<Button>();
        List<Button> xx = new List<Button>();

        List<Button> manobot = new List<Button>();
        List<Button> manobot1 = new List<Button>();

        List<Button> cambioss = new List<Button>();
        List<Button> cambioss1 = new List<Button>();

        List<Button> manamana = new List<Button>();


        spells carta0 = new spells("La Moneda", 0, false, false);
        weapon atacaaar;

        List<carta> manos = new List<carta>();
        List<carta> manos2 = new List<carta>();

        List<minion> cartascancha = new List<minion>();
        List<minion> cartascancha2 = new List<minion>();
        List<minion> shaman = new List<minion>();
        List<minion> shaman2 = new List<minion>();


        List<minion> weapon1 = new List<minion>();
        List<minion> weapon2 = new List<minion>();


        Heroe j1 = new Heroe(null, null, null, null, 1, 1, true);
        Heroe j2 = new Heroe(null, null, null, null, 1, 1, false);

        minion atacar;
        minion atacado;

        Heroe hatacar;
        Heroe hatacado;




        public MainWindow()
        {
            InitializeComponent();
           
            player.SoundLocation = "../../All Star - Smash Mouth [Lyrics].wav";
            player1.SoundLocation = "../../Game of Thrones   Main Theme Official Soundtrack Version.wav";
            player1.PlayLooping();


            BitmapImage imageplay = new BitmapImage(new Uri("../../bax.png", UriKind.Relative));
            playb.ImageSource = imageplay;

            BitmapImage image = new BitmapImage(new Uri("http://media-hearth.cursecdn.com/avatars/147/699/273.png"));
            wispmano.ImageSource = image;
            BitmapImage image1 = new BitmapImage(new Uri("https://hydra-media.cursecdn.com/hearthstone.gamepedia.com/thumb/1/1f/Murloc_Raider%2855%29_Gold.png/200px-Murloc_Raider%2855%29_Gold.png?version=883f02d505c570b0ea5c8b4b5e13f3b8"));
            MurlocRaidermano.ImageSource = image1;
            BitmapImage image2 = new BitmapImage(new Uri("http://wow.zamimg.com/images/hearthstone/cards/enus/original/CS2_172.png"));
            BloodfenRaptormano.ImageSource = image2;
            BitmapImage image3 = new BitmapImage(new Uri("https://media-hearth.cursecdn.com/avatars/147/580/535.png"));
            RiverCrocoliskmano.ImageSource = image3;
            BitmapImage image4 = new BitmapImage(new Uri("https://hydra-media.cursecdn.com/hearthstone.gamepedia.com/thumb/e/e3/Magma_Rager%28362%29_Gold.png/200px-Magma_Rager%28362%29_Gold.png?version=2f74b68dc2a909f90ec5c1b281403cc4"));
            MagmaRagermano.ImageSource = image4;
            BitmapImage image5 = new BitmapImage(new Uri("https://hydra-media.cursecdn.com/hearthstone.gamepedia.com/thumb/1/11/Chillwind_Yeti%2831%29_Gold.png/200px-Chillwind_Yeti%2831%29_Gold.png?version=d51f12af8fc503b7aadd3775cdb4b3c4"));
            ChillwindYetimano.ImageSource = image5;
            BitmapImage image6 = new BitmapImage(new Uri("http://media-hearth.cursecdn.com/avatars/147/579/15.png"));
            OasisSnapjawmano.ImageSource = image6;
            BitmapImage image7 = new BitmapImage(new Uri("https://hydra-media.cursecdn.com/hearthstone.gamepedia.com/thumb/f/fd/Boulderfist_Ogre%2860%29.png/200px-Boulderfist_Ogre%2860%29.png?version=7413c2a7a083d1e07079b5a064ba544d"));
            BoulderfistOgremano.ImageSource = image7;
            BitmapImage image8 = new BitmapImage(new Uri("https://hydra-media.cursecdn.com/hearthstone.gamepedia.com/thumb/5/59/War_Golem%28323%29_Gold.png/200px-War_Golem%28323%29_Gold.png?version=dadc0de413eb02f718d3073d75b23cfd"));
            WarGolemmano.ImageSource = image8;
            BitmapImage image9 = new BitmapImage(new Uri("https://hydra-media.cursecdn.com/hearthstone.gamepedia.com/thumb/9/9e/Core_Hound%28173%29.png/200px-Core_Hound%28173%29.png?version=61fadbe5ac356dd87a804be87e6ea538"));
            CoreHoundmano.ImageSource = image9;
            BitmapImage image11 = new BitmapImage(new Uri("../../totemtaunt2.png", UriKind.Relative));
            totem11.ImageSource = image11;
            BitmapImage image111 = new BitmapImage(new Uri("../../totemtaunt1.png", UriKind.Relative));
            totem111.ImageSource = image111;
            BitmapImage image12 = new BitmapImage(new Uri("../../totemheal2.png",UriKind.Relative));
            totem22.ImageSource = image12;
            BitmapImage image121 = new BitmapImage(new Uri("../../totemheal1.png", UriKind.Relative));
            totem221.ImageSource = image121;
            BitmapImage image13 = new BitmapImage(new Uri("../../totem02.png", UriKind.Relative));
            totem33.ImageSource = image13;
            BitmapImage image131 = new BitmapImage(new Uri("../../totem01.png", UriKind.Relative));
            totem331.ImageSource = image131;
            BitmapImage image14 = new BitmapImage(new Uri("../../totem11.png", UriKind.Relative)); 
            totem44.ImageSource = image14;
            BitmapImage image15 = new BitmapImage(new Uri("../../recruit.png", UriKind.Relative));
            Recruit.ImageSource = image15;
            BitmapImage image16 = new BitmapImage(new Uri("../../wisp.png", UriKind.Relative));
            wisp.ImageSource = image16;
            BitmapImage image17 = new BitmapImage(new Uri("../../murloc raider.png", UriKind.Relative));
            MurlocRaider.ImageSource = image17;
            BitmapImage image18 = new BitmapImage(new Uri("../../Hearthstone Screenshot 06-30-17 16.10.46.png", UriKind.Relative));
            BloodfenRaptor.ImageSource = image18;
            BitmapImage image19 = new BitmapImage(new Uri("../../Hearthstone Screenshot 06-30-17 16.11.20 lal a.png", UriKind.Relative));
            BloodfenRaptor1.ImageSource = image19;
            BitmapImage image20 = new BitmapImage(new Uri("../../Hearthstone Screenshot 06-30-17 16.11.38.png", UriKind.Relative));
            RiverCrocolisk.ImageSource = image20;
            BitmapImage image21 = new BitmapImage(new Uri("../../Hearthstone Screenshot 06-30-17 16.12.11.png", UriKind.Relative));
            RiverCrocolisk2.ImageSource = image21;
            BitmapImage image22 = new BitmapImage(new Uri("../../1 vida crokolisk.png", UriKind.Relative));
            RiverCrocolisk1.ImageSource = image22;
            BitmapImage image23 = new BitmapImage(new Uri("../../magma rager.png", UriKind.Relative));
            MagmaRager.ImageSource = image23;
            BitmapImage image24 = new BitmapImage(new Uri("../../yeti 5.png", UriKind.Relative));
            ChillwindYeti.ImageSource = image24;
            BitmapImage image25 = new BitmapImage(new Uri("../../yeti 4.png", UriKind.Relative));
            ChillwindYeti4.ImageSource = image25;
            BitmapImage image26 = new BitmapImage(new Uri("../../yeti 3.png", UriKind.Relative));
            ChillwindYeti3.ImageSource = image26;
            BitmapImage image27 = new BitmapImage(new Uri("../../yeti 2.png", UriKind.Relative));
            ChillwindYeti2.ImageSource = image27;
            BitmapImage image28 = new BitmapImage(new Uri("../../yeti 1.png", UriKind.Relative));
            ChillwindYeti1.ImageSource = image28;
            BitmapImage image29 = new BitmapImage(new Uri("../../Hearthstone Screenshot 06-30-17 16.12 lol.png", UriKind.Relative));
            OasisSnapjaw.ImageSource = image29;
            BitmapImage image30 = new BitmapImage(new Uri("../../oasis 1.png", UriKind.Relative));
            OasisSnapjaw1.ImageSource = image30;
            BitmapImage image31 = new BitmapImage(new Uri("../../oasis 2.png", UriKind.Relative));
            OasisSnapjaw2.ImageSource = image31;
            BitmapImage image32 = new BitmapImage(new Uri("../../oasis 3.png", UriKind.Relative));
            OasisSnapjaw3.ImageSource = image32;
            BitmapImage image33 = new BitmapImage(new Uri("../../oasis snapjaw 4.png", UriKind.Relative));
            OasisSnapjaw4.ImageSource = image33;
            BitmapImage image34 = new BitmapImage(new Uri("../../oasis snapjaw 5.png", UriKind.Relative));
            OasisSnapjaw5.ImageSource = image34;
            BitmapImage image35 = new BitmapImage(new Uri("../../oasis 6.png", UriKind.Relative));
            OasisSnapjaw6.ImageSource = image35;
            BitmapImage image36 = new BitmapImage(new Uri("../../boulder 7.png", UriKind.Relative));
            BoulderfistOgre.ImageSource = image36;
            BitmapImage image37 = new BitmapImage(new Uri("../../boulder 6.png", UriKind.Relative));
            BoulderfistOgre6.ImageSource = image37;
            BitmapImage image38 = new BitmapImage(new Uri("../../boulder 5.png", UriKind.Relative));
            BoulderfistOgre5.ImageSource = image38;
            BitmapImage image39 = new BitmapImage(new Uri("../../boulder 4.png", UriKind.Relative));
            BoulderfistOgre4.ImageSource = image39;
            BitmapImage image40 = new BitmapImage(new Uri("../../boulder 3.png", UriKind.Relative));
            BoulderfistOgre3.ImageSource = image40;
            BitmapImage image41 = new BitmapImage(new Uri("../../boulder 2.png", UriKind.Relative));
            BoulderfistOgre2.ImageSource = image41;
            BitmapImage image42 = new BitmapImage(new Uri("../../boulder 1.png", UriKind.Relative));
            BoulderfistOgre1.ImageSource = image42;
            BitmapImage image43 = new BitmapImage(new Uri("../../wg7.png", UriKind.Relative));
            WarGolem.ImageSource = image43;
            BitmapImage image44 = new BitmapImage(new Uri("../../wg1.png", UriKind.Relative));
            WarGolem1.ImageSource = image44;
            BitmapImage image45 = new BitmapImage(new Uri("../../wg2.png", UriKind.Relative));
            WarGolem2.ImageSource = image45;
            BitmapImage image46 = new BitmapImage(new Uri("../../wg3.png", UriKind.Relative));
            WarGolem3.ImageSource = image46;
            BitmapImage image47 = new BitmapImage(new Uri("../../wg4.png", UriKind.Relative));
            WarGolem4.ImageSource = image47;
            BitmapImage image48 = new BitmapImage(new Uri("../../wg5.png", UriKind.Relative));
            WarGolem5.ImageSource = image48;
            BitmapImage image49 = new BitmapImage(new Uri("../../wg6.png", UriKind.Relative));
            WarGolem6.ImageSource = image49;
            BitmapImage image50 = new BitmapImage(new Uri("../../core hound 5.png", UriKind.Relative));
            CoreHound.ImageSource = image50;
            BitmapImage image51 = new BitmapImage(new Uri("../../core hound 1.png", UriKind.Relative));
            CoreHound1.ImageSource = image51;
            BitmapImage image52 = new BitmapImage(new Uri("../../core hound 2.png", UriKind.Relative));
            CoreHound2.ImageSource = image52;
            BitmapImage image53 = new BitmapImage(new Uri("../../core hound 3.png", UriKind.Relative));
            CoreHound3.ImageSource = image53;
            BitmapImage image54 = new BitmapImage(new Uri("../../core hound 4.png", UriKind.Relative));
            CoreHound4.ImageSource = image54;

            BitmapImage image55 = new BitmapImage(new Uri("../../HHunter.png", UriKind.Relative));
            habhunter.ImageSource = image55;
            BitmapImage image56 = new BitmapImage(new Uri("../../HMage.png", UriKind.Relative));
            habmage.ImageSource = image56;
            BitmapImage image57 = new BitmapImage(new Uri("../../HPaladin.png", UriKind.Relative));
            habpaladin.ImageSource = image57;
            BitmapImage image58 = new BitmapImage(new Uri("../../HPriest.png", UriKind.Relative));
            habpriest.ImageSource = image58;
            BitmapImage image59 = new BitmapImage(new Uri("../../HRogue.png", UriKind.Relative));
            habrogue.ImageSource = image59;
            BitmapImage image60 = new BitmapImage(new Uri("../../HShaman.png", UriKind.Relative));
            habshaman.ImageSource = image60;
            BitmapImage image61 = new BitmapImage(new Uri("../../HWarlock.png", UriKind.Relative));
            habwarlock.ImageSource = image61;
            BitmapImage image62 = new BitmapImage(new Uri("../../HWarrior.png", UriKind.Relative));
            habwarrior.ImageSource = image62;
            BitmapImage image63 = new BitmapImage(new Uri("../../Hdruid.png", UriKind.Relative));
            habdruid.ImageSource = image63;

            BitmapImage image64 = new BitmapImage(new Uri("../../fondoinicio.png", UriKind.Relative));
            FondoIni.ImageSource = image64;

            BitmapImage escudo1 = new BitmapImage(new Uri("../../Escudo.png", UriKind.Relative));
            escudo.ImageSource = escudo1;
            BitmapImage wrogue = new BitmapImage(new Uri("../../wrogue.png", UriKind.Relative));
            daga.ImageSource = wrogue;

            BitmapImage naudio = new BitmapImage(new Uri("../../nosound.png", UriKind.Relative));
            noaudio.ImageSource = naudio;

            BitmapImage manana = new BitmapImage(new Uri("../../mana.png", UriKind.Relative));
            lala.ImageSource = manana;




            BitmapImage fotito = new BitmapImage(new Uri("../../druidex.png", UriKind.Relative));
            druidex.ImageSource = fotito;
            BitmapImage fotito1 = new BitmapImage(new Uri("../../rogueex.png", UriKind.Relative));
            rogueex.ImageSource = fotito1;
            BitmapImage fotito2 = new BitmapImage(new Uri("../../priestex.png", UriKind.Relative));
            priestex.ImageSource = fotito2;
            BitmapImage fotito3 = new BitmapImage(new Uri("../../hunterex.png", UriKind.Relative));
            hunterex.ImageSource = fotito3;
            BitmapImage fotito4 = new BitmapImage(new Uri("../../paladinex.png", UriKind.Relative));
            paladinex.ImageSource = fotito4;
            BitmapImage fotito5 = new BitmapImage(new Uri("../../shamanex.png", UriKind.Relative));
            shamanex.ImageSource = fotito5;
            BitmapImage fotito6 = new BitmapImage(new Uri("../../mageex.png", UriKind.Relative));
            mageex.ImageSource = fotito6;
            BitmapImage fotito7 = new BitmapImage(new Uri("../../warriorex.png", UriKind.Relative));
            warriorex.ImageSource = fotito7;
            BitmapImage fotito8 = new BitmapImage(new Uri("../../warlockex.png", UriKind.Relative));
            warlockex.ImageSource = fotito8;

            BitmapImage fotito9 = new BitmapImage(new Uri("../../bear.png", UriKind.Relative));
            oso.ImageSource = fotito9;





            boton3.Background = playb;











            foreach (Button b in mana1.Children)
            {
                manamana.Add(b);
            }


            foreach (Button b in stackpanel_Copy1.Children)
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
            foreach (Button b in cambiocarta1.Children)
            {
                cambioss.Add(b);
            }
            foreach (Button b in cambiocartas2.Children)
            {
                cambioss1.Add(b);
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
            audio.Visibility = Visibility.Hidden;

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
            weapon1_.Visibility = Visibility.Hidden;
            fotoescudo.Visibility = Visibility.Hidden;
            fotoescudo2.Visibility = Visibility.Hidden;


            vida1.Content = j1.vida.ToString();
            Vida2.Content = j2.vida.ToString();
            manatot1.Content = j1.manatotal.ToString();
            manatott.Content = j2.manatotal.ToString();
            manadisp.Content = j1.mana.ToString();
            manadisponible2.Content = j2.mana.ToString();
            fondobatalla.Visibility = Visibility.Hidden;
            fondoinicio.Visibility = Visibility.Visible;
            cambio1.Visibility = Visibility.Hidden;
            cambio2.Visibility = Visibility.Hidden;




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

        public static void refreshmana(ImageBrush lala, List<Button> manamana, Heroe j, ImageBrush vacio)
        {
            for (int i = 0; i < j.mana; i++)
            {
                manamana[i].Background = lala;
            }
            for( int i =j.mana;i<j.manatotal; i++)
            {
                manamana[i].Background = vacio;
            }
        }

        public static void refreshhmano(List<carta> cartascancha, List<carta> cartascancha2, List<Button> xx, List<Button> a2, ImageBrush wisp, ImageBrush MurlocRaider, ImageBrush BloodfenRaptor, ImageBrush RiverCrocolisk, ImageBrush MagmaRager, ImageBrush ChillwindYeti, ImageBrush OasisSnapjaw, ImageBrush BoulderfistOgre, ImageBrush WarGolem, ImageBrush CoreHound, ImageBrush recruit, Heroe j1, Heroe j2)
        {
            for (int i = 0; i < cartascancha.Count; i++)
            {
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




        public static void refreshh(List<minion> cartascancha, List<minion> cartascancha2, List<Button> xx, List<Button> a2, ImageBrush wisp, ImageBrush MurlocRaider, ImageBrush BloodfenRaptor, ImageBrush RiverCrocolisk, ImageBrush MagmaRager, ImageBrush ChillwindYeti, ImageBrush OasisSnapjaw, ImageBrush BoulderfistOgre, ImageBrush WarGolem, ImageBrush CoreHound, ImageBrush Recruit, ImageBrush totem11, ImageBrush totem22, ImageBrush totem33, ImageBrush totem44, Heroe j1, Heroe j2, ImageBrush Rivercrocolisk1, ImageBrush BloodfenRaptor1, ImageBrush Rivercrocolisk2, ImageBrush Chillwindyeti1, ImageBrush Chillwindyeti2, ImageBrush Chillwindyeti3, ImageBrush Chillwindyeti4, ImageBrush OasisSnapjaw1, ImageBrush OasisSnapjaw2, ImageBrush OasisSnapjaw3, ImageBrush OasisSnapjaw4, ImageBrush OasisSnapjaw5, ImageBrush OasisSnapjaw6, ImageBrush BoulderfistOgre1, ImageBrush BoulderfistOgre2, ImageBrush BoulderfistOgre3, ImageBrush BoulderfistOgre4, ImageBrush BoulderfistOgre5, ImageBrush BoulderfistOgre6, ImageBrush WarGolem1, ImageBrush WarGolem2, ImageBrush WarGolem3, ImageBrush WarGolem4, ImageBrush WarGolem5, ImageBrush WarGolem6, ImageBrush CoreHound1, ImageBrush CoreHound2, ImageBrush CoreHound3, ImageBrush CoreHound4, ImageBrush totem111, ImageBrush totem221, ImageBrush totem331)
        {
            for (int i = 0; i < cartascancha.Count; i++)
            {

                if (cartascancha[i].turno == false)
                {
                    xx[i].Opacity = 0.5;
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
                if (cartascancha[i].nombre == "Bloodfen Raptor" && cartascancha[i].vida == 2)
                {
                    xx[i].Background = BloodfenRaptor;
                }
                if (cartascancha[i].nombre == "Bloodfen Raptor" && cartascancha[i].vida == 1)
                {
                    xx[i].Background = BloodfenRaptor1;
                }

                if (cartascancha[i].nombre == "River Crocolisk" && cartascancha[i].vida == 3)
                {
                    xx[i].Background = RiverCrocolisk;
                }
                if (cartascancha[i].nombre == "River Crocolisk" && cartascancha[i].vida == 2)
                {
                    xx[i].Background = Rivercrocolisk2;
                }
                if (cartascancha[i].nombre == "River Crocolisk" && cartascancha[i].vida == 1)
                {
                    xx[i].Background = Rivercrocolisk1;
                }
                if (cartascancha[i].nombre == "Magma Rager")
                {
                    xx[i].Background = MagmaRager;
                }
                if (cartascancha[i].nombre == "Chillwind Yeti" && cartascancha[i].vida == 5)
                {
                    xx[i].Background = ChillwindYeti;
                }
                if (cartascancha[i].nombre == "Chillwind Yeti" && cartascancha[i].vida == 4)
                {
                    xx[i].Background = Chillwindyeti4;
                }
                if (cartascancha[i].nombre == "Chillwind Yeti" && cartascancha[i].vida == 3)
                {
                    xx[i].Background = Chillwindyeti3;
                }
                if (cartascancha[i].nombre == "Chillwind Yeti" && cartascancha[i].vida == 2)
                {
                    xx[i].Background = Chillwindyeti2;
                }
                if (cartascancha[i].nombre == "Chillwind Yeti" && cartascancha[i].vida == 1)
                {
                    xx[i].Background = Chillwindyeti1;
                }
                if (cartascancha[i].nombre == "Oasis Snapjaw" && cartascancha[i].vida == 7)
                {
                    xx[i].Background = OasisSnapjaw;
                }
                if (cartascancha[i].nombre == "Oasis Snapjaw" && cartascancha[i].vida == 6)
                {
                    xx[i].Background = OasisSnapjaw6;
                }
                if (cartascancha[i].nombre == "Oasis Snapjaw" && cartascancha[i].vida == 5)
                {
                    xx[i].Background = OasisSnapjaw5;
                }
                if (cartascancha[i].nombre == "Oasis Snapjaw" && cartascancha[i].vida == 4)
                {
                    xx[i].Background = OasisSnapjaw4;
                }
                if (cartascancha[i].nombre == "Oasis Snapjaw" && cartascancha[i].vida == 3)
                {
                    xx[i].Background = OasisSnapjaw3;

                }
                if (cartascancha[i].nombre == "Oasis Snapjaw" && cartascancha[i].vida == 2)
                {
                    xx[i].Background = OasisSnapjaw2;
                }
                if (cartascancha[i].nombre == "Oasis Snapjaw" && cartascancha[i].vida == 1)
                {
                    xx[i].Background = OasisSnapjaw1;
                }
                if (cartascancha[i].nombre == "Boulderfist Ogre" && cartascancha[i].vida == 7)
                {
                    xx[i].Background = BoulderfistOgre;
                }
                if (cartascancha[i].nombre == "Boulderfist Ogre" && cartascancha[i].vida == 6)
                {
                    xx[i].Background = BoulderfistOgre6;
                }
                if (cartascancha[i].nombre == "Boulderfist Ogre" && cartascancha[i].vida == 5)
                {
                    xx[i].Background = BoulderfistOgre5;
                }
                if (cartascancha[i].nombre == "Boulderfist Ogre" && cartascancha[i].vida == 4)
                {
                    xx[i].Background = BoulderfistOgre4;
                }
                if (cartascancha[i].nombre == "Boulderfist Ogre" && cartascancha[i].vida == 3)
                {
                    xx[i].Background = BoulderfistOgre3;
                }
                if (cartascancha[i].nombre == "Boulderfist Ogre" && cartascancha[i].vida == 2)
                {
                    xx[i].Background = BoulderfistOgre2;
                }
                if (cartascancha[i].nombre == "Boulderfist Ogre" && cartascancha[i].vida == 1)
                {
                    xx[i].Background = BoulderfistOgre1;
                }

                if (cartascancha[i].nombre == "War Golem" && cartascancha[i].vida == 7)
                {
                    xx[i].Background = WarGolem;
                }
                if (cartascancha[i].nombre == "War Golem" && cartascancha[i].vida == 6)
                {
                    xx[i].Background = WarGolem6;
                }
                if (cartascancha[i].nombre == "War Golem" && cartascancha[i].vida == 5)
                {
                    xx[i].Background = WarGolem5;
                }
                if (cartascancha[i].nombre == "War Golem" && cartascancha[i].vida == 4)
                {
                    xx[i].Background = WarGolem4;
                }
                if (cartascancha[i].nombre == "War Golem" && cartascancha[i].vida == 3)
                {
                    xx[i].Background = WarGolem3;
                }
                if (cartascancha[i].nombre == "War Golem" && cartascancha[i].vida == 2)
                {
                    xx[i].Background = WarGolem2;
                }
                if (cartascancha[i].nombre == "War Golem" && cartascancha[i].vida == 1)
                {
                    xx[i].Background = WarGolem1;
                }

                if (cartascancha[i].nombre == "Core Hound" && cartascancha[i].vida == 5)
                {
                    xx[i].Background = CoreHound;
                }
                if (cartascancha[i].nombre == "Core Hound" && cartascancha[i].vida == 4)
                {
                    xx[i].Background = CoreHound4;
                }
                if (cartascancha[i].nombre == "Core Hound" && cartascancha[i].vida == 3)
                {
                    xx[i].Background = CoreHound3;
                }
                if (cartascancha[i].nombre == "Core Hound" && cartascancha[i].vida == 2)
                {
                    xx[i].Background = CoreHound2;

                }
                if (cartascancha[i].nombre == "Core Hound" && cartascancha[i].vida == 1)
                {
                    xx[i].Background = CoreHound1;
                }
                if (cartascancha[i].nombre == "Recruit")
                {
                    xx[i].Background = Recruit;
                }
                if (cartascancha[i].nombre == "Stoneclaw Totem")
                {
                    xx[i].Background = totem11;
                }
                if (cartascancha[i].nombre == "Heilin Totem")
                {
                    xx[i].Background = totem22;
                }
                if (cartascancha[i].nombre == "Warth of air Totem")
                {
                    xx[i].Background = totem33;
                }
                if (cartascancha[i].nombre == "Seiring Totem")
                {
                    xx[i].Background = totem44;
                }
                if (cartascancha[i].nombre == "Stoneclaw Totem" && cartascancha[i].vida == 1)
                {
                    xx[i].Background = totem111;
                }
                if (cartascancha[i].nombre == "Heilin Totem" && cartascancha[i].vida == 1)
                {
                    xx[i].Background = totem221;
                }
                if (cartascancha[i].nombre == "Warth of air Totem" && cartascancha[i].vida == 1)
                {
                    xx[i].Background = totem331;
                }


                xx[i].Visibility = Visibility.Visible;


            }
            for (int i = 0; i < cartascancha2.Count; i++)
            {

                if (cartascancha2[i].turno == false)
                {
                    a2[i].Opacity = 0.5;
                }
                if (cartascancha2[i].turno == true)
                {
                    a2[i].Opacity = 1;

                }
                if (cartascancha2[i].nombre == "wisp")
                {
                    a2[i].Background = wisp;

                }
                if (cartascancha2[i].nombre == "Murloc Raider")
                {
                    a2[i].Background = MurlocRaider;
                }
                if (cartascancha2[i].nombre == "Bloodfen Raptor" && cartascancha2[i].vida == 2)
                {
                    a2[i].Background = BloodfenRaptor;
                }
                if (cartascancha2[i].nombre == "Bloodfen Raptor" && cartascancha2[i].vida == 1)
                {
                    a2[i].Background = BloodfenRaptor1;
                }

                if (cartascancha2[i].nombre == "River Crocolisk" && cartascancha2[i].vida == 3)
                {
                    a2[i].Background = RiverCrocolisk;
                }
                if (cartascancha2[i].nombre == "River Crocolisk" && cartascancha2[i].vida == 2)
                {
                    a2[i].Background = Rivercrocolisk2;
                }
                if (cartascancha2[i].nombre == "River Crocolisk" && cartascancha2[i].vida == 1)
                {
                    a2[i].Background = Rivercrocolisk1;
                }
                if (cartascancha2[i].nombre == "Magma Rager")
                {
                    a2[i].Background = MagmaRager;
                }
                if (cartascancha2[i].nombre == "Chillwind Yeti" && cartascancha2[i].vida == 5)
                {
                    a2[i].Background = ChillwindYeti;
                }
                if (cartascancha2[i].nombre == "Chillwind Yeti" && cartascancha2[i].vida == 4)
                {
                    a2[i].Background = Chillwindyeti4;
                }
                if (cartascancha2[i].nombre == "Chillwind Yeti" && cartascancha2[i].vida == 3)
                {
                    a2[i].Background = Chillwindyeti3;
                }
                if (cartascancha2[i].nombre == "Chillwind Yeti" && cartascancha2[i].vida == 2)
                {
                    a2[i].Background = Chillwindyeti2;
                }
                if (cartascancha2[i].nombre == "Chillwind Yeti" && cartascancha2[i].vida == 1)
                {
                    a2[i].Background = Chillwindyeti1;
                }
                if (cartascancha2[i].nombre == "Oasis Snapjaw" && cartascancha2[i].vida == 7)
                {
                    a2[i].Background = OasisSnapjaw;
                }
                if (cartascancha2[i].nombre == "Oasis Snapjaw" && cartascancha2[i].vida == 6)
                {
                    a2[i].Background = OasisSnapjaw6;
                }
                if (cartascancha2[i].nombre == "Oasis Snapjaw" && cartascancha2[i].vida == 5)
                {
                    a2[i].Background = OasisSnapjaw5;
                }
                if (cartascancha2[i].nombre == "Oasis Snapjaw" && cartascancha2[i].vida == 4)
                {
                    a2[i].Background = OasisSnapjaw4;
                }
                if (cartascancha2[i].nombre == "Oasis Snapjaw" && cartascancha2[i].vida == 3)
                {
                    a2[i].Background = OasisSnapjaw3;

                }
                if (cartascancha2[i].nombre == "Oasis Snapjaw" && cartascancha2[i].vida == 2)
                {
                    a2[i].Background = OasisSnapjaw2;
                }
                if (cartascancha2[i].nombre == "Oasis Snapjaw" && cartascancha2[i].vida == 1)
                {
                    a2[i].Background = OasisSnapjaw1;
                }
                if (cartascancha2[i].nombre == "Boulderfist Ogre" && cartascancha2[i].vida == 7)
                {
                    a2[i].Background = BoulderfistOgre;
                }
                if (cartascancha2[i].nombre == "Boulderfist Ogre" && cartascancha2[i].vida == 6)
                {
                    a2[i].Background = BoulderfistOgre6;
                }
                if (cartascancha2[i].nombre == "Boulderfist Ogre" && cartascancha2[i].vida == 5)
                {
                    a2[i].Background = BoulderfistOgre5;
                }
                if (cartascancha2[i].nombre == "Boulderfist Ogre" && cartascancha2[i].vida == 4)
                {
                    a2[i].Background = BoulderfistOgre4;
                }
                if (cartascancha2[i].nombre == "Boulderfist Ogre" && cartascancha2[i].vida == 3)
                {
                    a2[i].Background = BoulderfistOgre3;
                }
                if (cartascancha2[i].nombre == "Boulderfist Ogre" && cartascancha2[i].vida == 2)
                {
                    a2[i].Background = BoulderfistOgre2;
                }
                if (cartascancha2[i].nombre == "Boulderfist Ogre" && cartascancha2[i].vida == 1)
                {
                    a2[i].Background = BoulderfistOgre1;
                }

                if (cartascancha2[i].nombre == "War Golem" && cartascancha2[i].vida == 7)
                {
                    a2[i].Background = WarGolem;
                }
                if (cartascancha2[i].nombre == "War Golem" && cartascancha2[i].vida == 6)
                {
                    a2[i].Background = WarGolem6;
                }
                if (cartascancha2[i].nombre == "War Golem" && cartascancha2[i].vida == 5)
                {
                    a2[i].Background = WarGolem5;
                }
                if (cartascancha2[i].nombre == "War Golem" && cartascancha2[i].vida == 4)
                {
                    a2[i].Background = WarGolem4;
                }
                if (cartascancha2[i].nombre == "War Golem" && cartascancha2[i].vida == 3)
                {
                    a2[i].Background = WarGolem3;
                }
                if (cartascancha2[i].nombre == "War Golem" && cartascancha2[i].vida == 2)
                {
                    a2[i].Background = WarGolem2;
                }
                if (cartascancha2[i].nombre == "War Golem" && cartascancha2[i].vida == 1)
                {
                    a2[i].Background = WarGolem1;
                }

                if (cartascancha2[i].nombre == "Core Hound" && cartascancha2[i].vida == 5)
                {
                    a2[i].Background = CoreHound;
                }
                if (cartascancha2[i].nombre == "Core Hound" && cartascancha2[i].vida == 4)
                {
                    a2[i].Background = CoreHound4;
                }
                if (cartascancha2[i].nombre == "Core Hound" && cartascancha2[i].vida == 3)
                {
                    a2[i].Background = CoreHound3;
                }
                if (cartascancha2[i].nombre == "Core Hound" && cartascancha2[i].vida == 2)
                {
                    a2[i].Background = CoreHound2;

                }
                if (cartascancha2[i].nombre == "Core Hound" && cartascancha2[i].vida == 1)
                {
                    a2[i].Background = CoreHound1;
                }
                if (cartascancha2[i].nombre == "Recruit")
                {
                    a2[i].Background = Recruit;
                }
                if (cartascancha2[i].nombre == "Stoneclaw Totem")
                {
                    a2[i].Background = totem11;
                }
                if (cartascancha2[i].nombre == "Heilin Totem")
                {
                    a2[i].Background = totem22;
                }
                if (cartascancha2[i].nombre == "Warth of air Totem")
                {
                    a2[i].Background = totem33;
                }
                if (cartascancha2[i].nombre == "Seiring Totem")
                {
                    a2[i].Background = totem44;
                }
                if (cartascancha2[i].nombre == "Stoneclaw Totem" && cartascancha2[i].vida == 1)
                {
                    a2[i].Background = totem111;
                }
                if (cartascancha2[i].nombre == "Heilin Totem" && cartascancha2[i].vida == 1)
                {
                    a2[i].Background = totem221;
                }
                if (cartascancha2[i].nombre == "Warth of air Totem" && cartascancha2[i].vida == 1)
                {
                    a2[i].Background = totem331;
                }
                a2[i].Visibility = Visibility.Visible;


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

        /*Elegir Heroe1*/
        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            eheroe1.Visibility = Visibility.Hidden;
            if (comboBox1.SelectedItem == "Warrior")
            {
                habilidad.Background = habwarrior;
                comboBox1.Visibility = Visibility.Hidden;
                text2.Visibility = Visibility.Visible;
                boton2.Visibility = Visibility.Visible;
                j1.ingresartipo("Warrior");
               
                fotoescudo.Background = escudo;
                fotoescudo.Content = j1.escudo;
                
                





            }

            if (comboBox1.SelectedItem == "Hunter")
            {
                habilidad.Background = habhunter;
                comboBox1.Visibility = Visibility.Hidden;
                text2.Visibility = Visibility.Visible;
                boton2.Visibility = Visibility.Visible;
                j1.ingresartipo("Hunter");

            }

            if (comboBox1.SelectedItem == "Mage")
            {
                habilidad.Background = habmage;
                comboBox1.Visibility = Visibility.Hidden;
                text2.Visibility = Visibility.Visible;
                boton2.Visibility = Visibility.Visible;
                j1.ingresartipo("Mage");

            }

            if (comboBox1.SelectedItem == "Paladin")
            {
                habilidad.Background = habpaladin;
                comboBox1.Visibility = Visibility.Hidden;
                text2.Visibility = Visibility.Visible;
                boton2.Visibility = Visibility.Visible;
                j1.ingresartipo("Paladin");

            }

            if (comboBox1.SelectedItem == "Priest")
            {
                habilidad.Background = habpriest;
                comboBox1.Visibility = Visibility.Hidden;
                text2.Visibility = Visibility.Visible;
                boton2.Visibility = Visibility.Visible;
                j1.ingresartipo("Priest");

            }

            if (comboBox1.SelectedItem == "Druid")
            {
                habilidad.Background = habdruid;
                comboBox1.Visibility = Visibility.Hidden;
                text2.Visibility = Visibility.Visible;
                boton2.Visibility = Visibility.Visible;
                j1.ingresartipo("Druid");
                
                fotoescudo.Background = escudo;
                fotoescudo.Content = j1.escudo;

            }

            if (comboBox1.SelectedItem == "Rogue")
            {
                habilidad.Background = habrogue;
                comboBox1.Visibility = Visibility.Hidden;
                text2.Visibility = Visibility.Visible;
                boton2.Visibility = Visibility.Visible;
                j1.ingresartipo("Rogue");

            }

            if (comboBox1.SelectedItem == "Shaman")
            {
                habilidad.Background = habshaman;
                comboBox1.Visibility = Visibility.Hidden;
                text2.Visibility = Visibility.Visible;
                boton2.Visibility = Visibility.Visible;
                j1.ingresartipo("Shaman");

            }

            if (comboBox1.SelectedItem == "Warlock")
            {
                habilidad.Background = habwarlock;
                comboBox1.Visibility = Visibility.Hidden;
                text2.Visibility = Visibility.Visible;
                boton2.Visibility = Visibility.Visible;
                j1.ingresartipo("Warlock");

            }



        }
        /*Elegir Heroe 2*/
        private void ComboBox_SelectionChanged_2(object sender, SelectionChangedEventArgs e)
        {
            eheroe2.Visibility = Visibility.Hidden;
            if (comboBox2.SelectedItem == "Warrior")
            {
                habilidad2.Background = habwarrior;
                comboBox2.Visibility = Visibility.Hidden;
                boton3.Visibility = Visibility.Visible;
                j2.ingresartipo("Warrior");
                fotoescudo2.Background = escudo;
                fotoescudo2.Content = j2.escudo;

                

            }

            if (comboBox2.SelectedItem == "Hunter")
            {
                habilidad2.Background = habhunter;
                comboBox2.Visibility = Visibility.Hidden;
                boton3.Visibility = Visibility.Visible;
                j2.ingresartipo("Hunter");

            }

            if (comboBox2.SelectedItem == "Mage")
            {
                habilidad2.Background = habmage;
                comboBox2.Visibility = Visibility.Hidden;
                boton3.Visibility = Visibility.Visible;
                j2.ingresartipo("Mage");

            }

            if (comboBox2.SelectedItem == "Paladin")
            {
                habilidad2.Background = habpaladin;
                comboBox2.Visibility = Visibility.Hidden;
                boton3.Visibility = Visibility.Visible;
                j2.ingresartipo("Paladin");

            }

            if (comboBox2.SelectedItem == "Priest")
            {
                habilidad2.Background = habpriest;
                comboBox2.Visibility = Visibility.Hidden;
                boton3.Visibility = Visibility.Visible;
                j2.ingresartipo("Priest");

            }

            if (comboBox2.SelectedItem == "Druid")
            {
                habilidad2.Background = habdruid;
                comboBox2.Visibility = Visibility.Hidden;
                boton3.Visibility = Visibility.Visible;
                j2.ingresartipo("Druid");
                fotoescudo2.Background = escudo;
                fotoescudo2.Content = j2.escudo;

            }

            if (comboBox2.SelectedItem == "Rogue")
            {
                habilidad2.Background = habrogue;
                comboBox2.Visibility = Visibility.Hidden;
                boton3.Visibility = Visibility.Visible;
                j2.ingresartipo("Rogue");

            }

            if (comboBox2.SelectedItem == "Shaman")
            {
                habilidad2.Background = habshaman;
                comboBox2.Visibility = Visibility.Hidden;
                boton3.Visibility = Visibility.Visible;
                j2.ingresartipo("Shaman");

            }

            if (comboBox2.SelectedItem == "Warlock")
            {
                habilidad2.Background = habwarlock;
                comboBox2.Visibility = Visibility.Hidden;
                boton3.Visibility = Visibility.Visible;
                j2.ingresartipo("Warlock");

            }
            fondoinicio.Visibility = Visibility.Hidden;
            fondocambio.Visibility = Visibility.Visible;
            refreshhmano(manos, manos, cambioss, cambioss, wispmano, MurlocRaidermano, BloodfenRaptormano, RiverCrocoliskmano, MagmaRagermano, ChillwindYetimano, OasisSnapjawmano, BoulderfistOgremano, WarGolemmano, CoreHoundmano, Recruit, j1, j2);
            cambio1.Visibility = Visibility.Visible;
            cambiocarta1.Visibility = Visibility.Visible;
            refreshhmano(manos2, manos2, cambioss1, cambioss1, wispmano, MurlocRaidermano, BloodfenRaptormano, RiverCrocoliskmano, MagmaRagermano, ChillwindYetimano, OasisSnapjawmano, BoulderfistOgremano, WarGolemmano, CoreHoundmano, Recruit, j1, j2);
            cambio2.Visibility = Visibility.Visible;
            cambiocartas2.Visibility = Visibility.Visible;
        }
        /*Comenzar*/

        private void boton3_Click(object sender, RoutedEventArgs e)
        {
            refreshmana(lala, manamana, j1,vacio);

            player1.Stop();
            player.PlayLooping();
            audio.Background = noaudio;
            audio.Content = "";
            audio.Visibility = Visibility.Visible;
            fondocambio.Visibility = Visibility.Hidden;
            cambio1.Visibility = Visibility.Hidden;
            cambio2.Visibility = Visibility.Hidden;
            cambiocartas2.Visibility = Visibility.Hidden;
            cambiocarta1.Visibility = Visibility.Hidden;
            if (j1.tipo == "Druid" || j1.tipo == "Warrior")
            {
                fotoescudo.Visibility = Visibility.Visible;
            }
            if (j2.tipo == "Druid" || j2.tipo == "Warrior")
            {
                fotoescudo2.Visibility = Visibility.Visible;
            }
            
            for (int i = 0; i < 3; i++)
            {
                if (manos.Count() <= 3)
                {
                    j1.darcarta();
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (manos2.Count() <= 2)
                {
                    j2.darcarta();
                }
            }

            if (comboBox1.SelectedItem == "Warrior")
            {
                pic17.Visibility = Visibility.Visible;
            }
            if (comboBox1.SelectedItem == "Hunter")
            {
                pic1.Visibility = Visibility.Visible;
            }

            if (comboBox1.SelectedItem == "Mage")
            {
                pic5.Visibility = Visibility.Visible;
            }

            if (comboBox1.SelectedItem == "Paladin")
            {
                pic7.Visibility = Visibility.Visible;
            }

            if (comboBox1.SelectedItem == "Priest")
            {
                pic9.Visibility = Visibility.Visible;
            }

            if (comboBox1.SelectedItem == "Druid")
            {
                pic3.Visibility = Visibility.Visible;
            }

            if (comboBox1.SelectedItem == "Rogue")
            {
                pic11.Visibility = Visibility.Visible;
            }

            if (comboBox1.SelectedItem == "Shaman")
            {
                pic13.Visibility = Visibility.Visible;
            }

            if (comboBox1.SelectedItem == "Warlock")
            {
                pic15.Visibility = Visibility.Visible;
            }

            if (comboBox2.SelectedItem == "Warrior")
            {
                pic18.Visibility = Visibility.Visible;
            }

            if (comboBox2.SelectedItem == "Hunter")
            {
                pic2.Visibility = Visibility.Visible;
            }

            if (comboBox2.SelectedItem == "Mage")
            {
                pic6.Visibility = Visibility.Visible;
            }

            if (comboBox2.SelectedItem == "Paladin")
            {
                pic8.Visibility = Visibility.Visible;
            }

            if (comboBox2.SelectedItem == "Priest")
            {
                pic10.Visibility = Visibility.Visible;
            }

            if (comboBox2.SelectedItem == "Druid")
            {
                pic4.Visibility = Visibility.Visible;
            }

            if (comboBox2.SelectedItem == "Rogue")
            {
                pic12.Visibility = Visibility.Visible;
            }

            if (comboBox2.SelectedItem == "Shaman")
            {
                pic14.Visibility = Visibility.Visible;
            }

            if (comboBox2.SelectedItem == "Warlock")
            {
                pic16.Visibility = Visibility.Visible;
            }

            fondobatalla.Visibility = Visibility.Visible;
            boton3.Visibility = Visibility.Hidden;
            for (int i = 0; i < manos.Count; i++)
            {
                if (manos[i].nombre == "wisp")
                {
                    manobot[i].Background = wispmano;

                }
                if (manos[i].nombre == "Murloc Raider")
                {
                    manobot[i].Background = MurlocRaidermano;
                }
                if (manos[i].nombre == "Bloodfen Raptor")
                {
                    manobot[i].Background = BloodfenRaptormano;
                }
                if (manos[i].nombre == "River Crocolisk")
                {
                    manobot[i].Background = RiverCrocoliskmano;
                }
                if (manos[i].nombre == "Magma Rager")
                {
                    manobot[i].Background = MagmaRagermano;
                }
                if (manos[i].nombre == "Chillwind Yeti")
                {
                    manobot[i].Background = ChillwindYetimano;
                }
                if (manos[i].nombre == "Oasis Snapjaw")
                {
                    manobot[i].Background = OasisSnapjawmano;
                }
                if (manos[i].nombre == "Boulderfist Ogre")
                {
                    manobot[i].Background = BoulderfistOgremano;
                }
                if (manos[i].nombre == "War Golem")
                {
                    manobot[i].Background = WarGolemmano;
                }
                if (manos[i].nombre == "Core Hound")
                {
                    manobot[i].Background = CoreHoundmano;
                }

                manobot[i].Visibility = Visibility.Visible;
                for (int j = 0; j < manos2.Count; j++)
                {
                    if (manos2[j].nombre == "wisp")
                    {
                        manobot1[j].Background = wispmano;

                    }
                    if (manos2[j].nombre == "Murloc Raider")
                    {
                        manobot1[j].Background = MurlocRaidermano;
                    }
                    if (manos2[j].nombre == "Bloodfen Raptor")
                    {
                        manobot1[j].Background = BloodfenRaptormano;
                    }
                    if (manos2[j].nombre == "River Crocolisk")
                    {
                        manobot1[j].Background = RiverCrocoliskmano;
                    }
                    if (manos2[j].nombre == "Magma Rager")
                    {
                        manobot1[j].Background = MagmaRagermano;
                    }
                    if (manos2[j].nombre == "Chillwind Yeti")
                    {
                        manobot1[j].Background = ChillwindYetimano;
                    }
                    if (manos2[j].nombre == "Oasis Snapjaw")
                    {
                        manobot1[j].Background = OasisSnapjawmano;
                    }
                    if (manos2[j].nombre == "Boulderfist Ogre")
                    {
                        manobot1[j].Background = BoulderfistOgremano;
                    }
                    if (manos2[j].nombre == "War Golem")
                    {
                        manobot1[j].Background = WarGolemmano;
                    }
                    if (manos2[j].nombre == "Core Hound")
                    {
                        manobot1[j].Background = CoreHoundmano;
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

            if (j1.tipo == "Druid") 
            {
              
                weapon1_.Background = vacio;
            }
            j1.terminarturnomana();
            refreshmana(lala, manamana, j1,vacio);
            manatot1.Content = String.Empty;
            manatot1.Content = j1.manatotal.ToString();
            manadisp.Content = manatot1.Content;
            j1.pasarturno(j2);
            weapon1_.IsEnabled = true;

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
            j2.darcarta();


            j1.QuemarMano();

            rendirse1.IsEnabled = false;
            rendirse2.IsEnabled = true;

            FinTurno.IsEnabled = false;
            FinTurno_Copy.IsEnabled = true;
            //Listbox_Copy.IsEnabled = true;
            habilidad2.IsEnabled = true;
            habilidad.IsEnabled = true;
            for (int i = 0; i < manos.Count; i++)
            {
                if (manos[i].nombre == "wisp")
                {
                    manobot[i].Background = wispmano;

                }
                if (manos[i].nombre == "Murloc Raider")
                {
                    manobot[i].Background = MurlocRaidermano;
                }
                if (manos[i].nombre == "Bloodfen Raptor")
                {
                    manobot[i].Background = BloodfenRaptormano;
                }
                if (manos[i].nombre == "River Crocolisk")
                {
                    manobot[i].Background = RiverCrocoliskmano;
                }
                if (manos[i].nombre == "Magma Rager")
                {
                    manobot[i].Background = MagmaRagermano;
                }
                if (manos[i].nombre == "Chillwind Yeti")
                {
                    manobot[i].Background = ChillwindYetimano;
                }
                if (manos[i].nombre == "Oasis Snapjaw")
                {
                    manobot[i].Background = OasisSnapjawmano;
                }
                if (manos[i].nombre == "Boulderfist Ogre")
                {
                    manobot[i].Background = BoulderfistOgremano;
                }
                if (manos[i].nombre == "War Golem")
                {
                    manobot[i].Background = WarGolemmano;
                }
                if (manos[i].nombre == "Core Hound")
                {
                    manobot[i].Background = CoreHoundmano;
                }
                manobot[i].Visibility = Visibility.Visible;
            }
            manobot[manos.Count()].Visibility = Visibility.Hidden;



            for (int i = 0; i < manos2.Count; i++)
            {
                if (manos2[i].nombre == "wisp")
                {
                    manobot1[i].Background = wispmano;

                }
                if (manos2[i].nombre == "Murloc Raider")
                {
                    manobot1[i].Background = MurlocRaidermano;
                }
                if (manos2[i].nombre == "Bloodfen Raptor")
                {
                    manobot1[i].Background = BloodfenRaptormano;
                }
                if (manos2[i].nombre == "River Crocolisk")
                {
                    manobot1[i].Background = RiverCrocoliskmano;
                }
                if (manos2[i].nombre == "Magma Rager")
                {
                    manobot1[i].Background = MagmaRagermano;
                }
                if (manos2[i].nombre == "Chillwind Yeti")
                {
                    manobot1[i].Background = ChillwindYetimano;
                }
                if (manos2[i].nombre == "Oasis Snapjaw")
                {
                    manobot1[i].Background = OasisSnapjawmano;
                }
                if (manos2[i].nombre == "Boulderfist Ogre")
                {
                    manobot1[i].Background = BoulderfistOgremano;
                }
                if (manos2[i].nombre == "War Golem")
                {
                    manobot1[i].Background = WarGolemmano;
                }
                if (manos2[i].nombre == "Core Hound")
                {
                    manobot1[i].Background = CoreHoundmano;
                }
                manobot1[i].Visibility = Visibility.Visible;
            }
            manobot1[manos2.Count()].Visibility = Visibility.Hidden;
            refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, totem11, totem22, totem33, totem44, j1, j2, RiverCrocolisk1, BloodfenRaptor1, RiverCrocolisk2, ChillwindYeti1, ChillwindYeti2, ChillwindYeti3, ChillwindYeti4, OasisSnapjaw1, OasisSnapjaw2, OasisSnapjaw3, OasisSnapjaw4, OasisSnapjaw5, OasisSnapjaw6, BoulderfistOgre1, BoulderfistOgre2, BoulderfistOgre3, BoulderfistOgre4, BoulderfistOgre5, BoulderfistOgre6, WarGolem1, WarGolem2, WarGolem3, WarGolem4, WarGolem5, WarGolem6, CoreHound1, CoreHound2, CoreHound3, CoreHound4, totem111, totem221, totem331);
            refreshmana(lala, manamana, j1, vacio);


        }


        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            atacar = cartascancha[0];
            if (atacar != null && atacado != null || hatacado != null && atacar != null)
            {

                atacar2.IsEnabled = true;


            }

        }

        private void boton17_Click(object sender, RoutedEventArgs e)
        {
            atacado = cartascancha2[6];
            if (atacar != null && atacado != null || hatacado != null && atacado != null)
            {

                atacar2.IsEnabled = true;


            }
        }
        /*Fin Turno j2*/
        private void FinTurno_Copy_Click(object sender, RoutedEventArgs e)
        {
            //Listbox_Copy.Items.Clear();

            if (j2.tipo == "Druid")
            {
                weapon2_.Background = vacio;
            }
            j2.terminarturnomana();

            manatott.Content = j2.manatotal.ToString();
            manadisponible2.Content = manatott.Content;
            j1.darcarta();
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
            habilidad2.IsEnabled = true;





            for (int i = 0; i < manos.Count; i++)
            {
                if (manos[i].nombre == "wisp")
                {
                    manobot[i].Background = wispmano;

                }
                if (manos[i].nombre == "Murloc Raider")
                {
                    manobot[i].Background = MurlocRaidermano;
                }
                if (manos[i].nombre == "Bloodfen Raptor")
                {
                    manobot[i].Background = BloodfenRaptormano;
                }
                if (manos[i].nombre == "River Crocolisk")
                {
                    manobot[i].Background = RiverCrocoliskmano;
                }
                if (manos[i].nombre == "Magma Rager")
                {
                    manobot[i].Background = MagmaRagermano;
                }
                if (manos[i].nombre == "Chillwind Yeti")
                {
                    manobot[i].Background = ChillwindYetimano;
                }
                if (manos[i].nombre == "Oasis Snapjaw")
                {
                    manobot[i].Background = OasisSnapjawmano;
                }
                if (manos[i].nombre == "Boulderfist Ogre")
                {
                    manobot[i].Background = BoulderfistOgremano;
                }
                if (manos[i].nombre == "War Golem")
                {
                    manobot[i].Background = WarGolemmano;
                }
                if (manos[i].nombre == "Core Hound")
                {
                    manobot[i].Background = CoreHoundmano;
                }
                manobot[i].Visibility = Visibility.Visible;
            }
            manobot[manos.Count()].Visibility = Visibility.Hidden;
            for (int i = 0; i < manos2.Count; i++)
            {
                if (manos2[i].nombre == "wisp")
                {
                    manobot1[i].Background = wispmano;

                }
                if (manos2[i].nombre == "Murloc Raider")
                {
                    manobot1[i].Background = MurlocRaidermano;
                }
                if (manos2[i].nombre == "Bloodfen Raptor")
                {
                    manobot1[i].Background = BloodfenRaptormano;
                }
                if (manos2[i].nombre == "River Crocolisk")
                {
                    manobot1[i].Background = RiverCrocoliskmano;
                }
                if (manos2[i].nombre == "Magma Rager")
                {
                    manobot1[i].Background = MagmaRagermano;
                }
                if (manos2[i].nombre == "Chillwind Yeti")
                {
                    manobot1[i].Background = ChillwindYetimano;
                }
                if (manos2[i].nombre == "Oasis Snapjaw")
                {
                    manobot1[i].Background = OasisSnapjawmano;
                }
                if (manos2[i].nombre == "Boulderfist Ogre")
                {
                    manobot1[i].Background = BoulderfistOgremano;
                }
                if (manos2[i].nombre == "War Golem")
                {
                    manobot1[i].Background = WarGolemmano;
                }
                if (manos2[i].nombre == "Core Hound")
                {
                    manobot1[i].Background = CoreHoundmano;
                }
                manobot1[i].Visibility = Visibility.Visible;
            }
            manobot1[manos2.Count()].Visibility = Visibility.Hidden;
            refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, totem11, totem22, totem33, totem44, j1, j2, RiverCrocolisk1, BloodfenRaptor1, RiverCrocolisk2, ChillwindYeti1, ChillwindYeti2, ChillwindYeti3, ChillwindYeti4, OasisSnapjaw1, OasisSnapjaw2, OasisSnapjaw3, OasisSnapjaw4, OasisSnapjaw5, OasisSnapjaw6, BoulderfistOgre1, BoulderfistOgre2, BoulderfistOgre3, BoulderfistOgre4, BoulderfistOgre5, BoulderfistOgre6, WarGolem1, WarGolem2, WarGolem3, WarGolem4, WarGolem5, WarGolem6, CoreHound1, CoreHound2, CoreHound3, CoreHound4, totem111, totem221, totem331);


            atacar2.IsEnabled = false;

            refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, totem11, totem22, totem33, totem44, j1, j2, RiverCrocolisk1, BloodfenRaptor1, RiverCrocolisk2, ChillwindYeti1, ChillwindYeti2, ChillwindYeti3, ChillwindYeti4, OasisSnapjaw1, OasisSnapjaw2, OasisSnapjaw3, OasisSnapjaw4, OasisSnapjaw5, OasisSnapjaw6, BoulderfistOgre1, BoulderfistOgre2, BoulderfistOgre3, BoulderfistOgre4, BoulderfistOgre5, BoulderfistOgre6, WarGolem1, WarGolem2, WarGolem3, WarGolem4, WarGolem5, WarGolem6, CoreHound1, CoreHound2, CoreHound3, CoreHound4, totem111, totem221, totem331);


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
            if (atacar != null && atacado != null || hatacado != null && atacado != null)//COPIA ESTE IF BAX SI ES PAL J1  , SI WEON TAL CUAL .Y LO PONES EN TODOS LO BOTONES DE LA CANCHA DEL J2 
            {

                atacar2.IsEnabled = true;


            }
        }

        private void popo_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void boton4_MouseEnter(object sender, MouseEventArgs e)
        {
            
            if (cartascancha[0].nombre == "wisp")
            {
                popo.Background = wisp;

            }
            if (cartascancha[0].nombre == "Murloc Raider")
            {
                popo.Background = MurlocRaider;
            }
            if (cartascancha[0].nombre == "Bloodfen Raptor" && cartascancha[0].vida == 2)
            {
                popo.Background = BloodfenRaptor;
            }
            if (cartascancha[0].nombre == "Bloodfen Raptor" && cartascancha[0].vida == 1)
            {
                popo.Background = BloodfenRaptor1;
            }

            if (cartascancha[0].nombre == "River Crocolisk" && cartascancha[0].vida == 3)
            {
                popo.Background = RiverCrocolisk;
            }
            if (cartascancha[0].nombre == "River Crocolisk" && cartascancha[0].vida == 2)
            {
                popo.Background = RiverCrocolisk2;
            }
            if (cartascancha[0].nombre == "River Crocolisk" && cartascancha[0].vida == 1)
            {
                popo.Background = RiverCrocolisk1;
            }
            if (cartascancha[0].nombre == "Magma Rager")
            {
                popo.Background = MagmaRager;
            }
            if (cartascancha[0].nombre == "Chillwind Yeti" && cartascancha[0].vida == 5)
            {
                popo.Background = ChillwindYeti;
            }
            if (cartascancha[0].nombre == "Chillwind Yeti" && cartascancha[0].vida == 4)
            {
                popo.Background = ChillwindYeti4;
            }
            if (cartascancha[0].nombre == "Chillwind Yeti" && cartascancha[0].vida == 3)
            {
                popo.Background = ChillwindYeti3;
            }
            if (cartascancha[0].nombre == "Chillwind Yeti" && cartascancha[0].vida == 2)
            {
                popo.Background = ChillwindYeti2;
            }
            if (cartascancha[0].nombre == "Chillwind Yeti" && cartascancha[0].vida == 1)
            {
                popo.Background = ChillwindYeti1;
            }
            if (cartascancha[0].nombre == "Oasis Snapjaw" && cartascancha[0].vida == 7)
            {
                popo.Background = OasisSnapjaw;
            }
            if (cartascancha[0].nombre == "Oasis Snapjaw" && cartascancha[0].vida == 6)
            {
                popo.Background = OasisSnapjaw6;
            }
            if (cartascancha[0].nombre == "Oasis Snapjaw" && cartascancha[0].vida == 5)
            {
                popo.Background = OasisSnapjaw5;
            }
            if (cartascancha[0].nombre == "Oasis Snapjaw" && cartascancha[0].vida == 4)
            {
                popo.Background = OasisSnapjaw4;
            }
            if (cartascancha[0].nombre == "Oasis Snapjaw" && cartascancha[0].vida == 3)
            {
                popo.Background = OasisSnapjaw3;

            }
            if (cartascancha[0].nombre == "Oasis Snapjaw" && cartascancha[0].vida == 2)
            {
                popo.Background = OasisSnapjaw2;
            }
            if (cartascancha[0].nombre == "Oasis Snapjaw" && cartascancha[0].vida == 1)
            {
                popo.Background = OasisSnapjaw1;
            }
            if (cartascancha[0].nombre == "Boulderfist Ogre" && cartascancha[0].vida == 7)
            {
                popo.Background = BoulderfistOgre;
            }
            if (cartascancha[0].nombre == "Boulderfist Ogre" && cartascancha[0].vida == 6)
            {
                popo.Background = BoulderfistOgre6;
            }
            if (cartascancha[0].nombre == "Boulderfist Ogre" && cartascancha[0].vida == 5)
            {
                popo.Background = BoulderfistOgre5;
            }
            if (cartascancha[0].nombre == "Boulderfist Ogre" && cartascancha[0].vida == 4)
            {
                popo.Background = BoulderfistOgre4;
            }
            if (cartascancha[0].nombre == "Boulderfist Ogre" && cartascancha[0].vida == 3)
            {
                popo.Background = BoulderfistOgre3;
            }
            if (cartascancha[0].nombre == "Boulderfist Ogre" && cartascancha[0].vida == 2)
            {
                popo.Background = BoulderfistOgre2;
            }
            if (cartascancha[0].nombre == "Boulderfist Ogre" && cartascancha[0].vida == 1)
            {
                popo.Background = BoulderfistOgre1;
            }

            if (cartascancha[0].nombre == "War Golem" && cartascancha[0].vida == 7)
            {
                popo.Background = WarGolem;
            }
            if (cartascancha[0].nombre == "War Golem" && cartascancha[0].vida == 6)
            {
                popo.Background = WarGolem6;
            }
            if (cartascancha[0].nombre == "War Golem" && cartascancha[0].vida == 5)
            {
                popo.Background = WarGolem5;
            }
            if (cartascancha[0].nombre == "War Golem" && cartascancha[0].vida == 4)
            {
                popo.Background = WarGolem4;
            }
            if (cartascancha[0].nombre == "War Golem" && cartascancha[0].vida == 3)
            {
                popo.Background = WarGolem3;
            }
            if (cartascancha[0].nombre == "War Golem" && cartascancha[0].vida == 2)
            {
                popo.Background = WarGolem2;
            }
            if (cartascancha[0].nombre == "War Golem" && cartascancha[0].vida == 1)
            {
                popo.Background = WarGolem1;
            }

            if (cartascancha[0].nombre == "Core Hound" && cartascancha[0].vida == 5)
            {
                popo.Background = CoreHound;
            }
            if (cartascancha[0].nombre == "Core Hound" && cartascancha[0].vida == 4)
            {
                popo.Background = CoreHound4;
            }
            if (cartascancha[0].nombre == "Core Hound" && cartascancha[0].vida == 3)
            {
                popo.Background = CoreHound3;
            }
            if (cartascancha[0].nombre == "Core Hound" && cartascancha[0].vida == 2)
            {
                popo.Background = CoreHound2;

            }
            if (cartascancha[0].nombre == "Core Hound" && cartascancha[0].vida == 1)
            {
                popo.Background = CoreHound1;
            }
            if (cartascancha[0].nombre == "Recruit")
            {
                popo.Background = Recruit;
            }
            if (cartascancha[0].nombre == "Stoneclaw Totem")
            {
                popo.Background = totem11;
            }
            if (cartascancha[0].nombre == "Heilin Totem")
            {
                popo.Background = totem22;
            }
            if (cartascancha[0].nombre == "Warth of air Totem")
            {
                popo.Background = totem33;
            }
            if (cartascancha[0].nombre == "Seiring Totem")
            {
                popo.Background = totem44;
            }
            if (cartascancha[0].nombre == "Stoneclaw Totem" && cartascancha[0].vida == 1)
            {
                popo.Background = totem111;
            }
            if (cartascancha[0].nombre == "Heilin Totem" && cartascancha[0].vida == 1)
            {
                popo.Background = totem221;
            }
            if (cartascancha[0].nombre == "Warth of air Totem" && cartascancha[0].vida == 1)
            {
                popo.Background = totem331;
            }

            popo.Visibility = Visibility.Visible;



        }

        private void boton4_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Background = vacio;
        }

        private void boton5_Click(object sender, RoutedEventArgs e)
        {
            atacar = cartascancha[1];
            if (atacar != null && atacado != null || hatacado != null && atacar != null)
            {

                atacar2.IsEnabled = true;


            }
        }

        private void boton5_MouseEnter(object sender, MouseEventArgs e)
        {
            
            if (cartascancha[1].nombre == "wisp")
            {
                popo.Background = wisp;

            }
            if (cartascancha[1].nombre == "Murloc Raider")
            {
                popo.Background = MurlocRaider;
            }
            if (cartascancha[1].nombre == "Bloodfen Raptor" && cartascancha[1].vida == 2)
            {
                popo.Background = BloodfenRaptor;
            }
            if (cartascancha[1].nombre == "Bloodfen Raptor" && cartascancha[1].vida == 1)
            {
                popo.Background = BloodfenRaptor1;
            }

            if (cartascancha[1].nombre == "River Crocolisk" && cartascancha[1].vida == 3)
            {
                popo.Background = RiverCrocolisk;
            }
            if (cartascancha[1].nombre == "River Crocolisk" && cartascancha[1].vida == 2)
            {
                popo.Background = RiverCrocolisk2;
            }
            if (cartascancha[1].nombre == "River Crocolisk" && cartascancha[1].vida == 1)
            {
                popo.Background = RiverCrocolisk1;
            }
            if (cartascancha[1].nombre == "Magma Rager")
            {
                popo.Background = MagmaRager;
            }
            if (cartascancha[1].nombre == "Chillwind Yeti" && cartascancha[1].vida == 5)
            {
                popo.Background = ChillwindYeti;
            }
            if (cartascancha[1].nombre == "Chillwind Yeti" && cartascancha[1].vida == 4)
            {
                popo.Background = ChillwindYeti4;
            }
            if (cartascancha[1].nombre == "Chillwind Yeti" && cartascancha[1].vida == 3)
            {
                popo.Background = ChillwindYeti3;
            }
            if (cartascancha[1].nombre == "Chillwind Yeti" && cartascancha[1].vida == 2)
            {
                popo.Background = ChillwindYeti2;
            }
            if (cartascancha[1].nombre == "Chillwind Yeti" && cartascancha[1].vida == 1)
            {
                popo.Background = ChillwindYeti1;
            }
            if (cartascancha[1].nombre == "Oasis Snapjaw" && cartascancha[1].vida == 7)
            {
                popo.Background = OasisSnapjaw;
            }
            if (cartascancha[1].nombre == "Oasis Snapjaw" && cartascancha[1].vida == 6)
            {
                popo.Background = OasisSnapjaw6;
            }
            if (cartascancha[1].nombre == "Oasis Snapjaw" && cartascancha[1].vida == 5)
            {
                popo.Background = OasisSnapjaw5;
            }
            if (cartascancha[1].nombre == "Oasis Snapjaw" && cartascancha[1].vida == 4)
            {
                popo.Background = OasisSnapjaw4;
            }
            if (cartascancha[1].nombre == "Oasis Snapjaw" && cartascancha[1].vida == 3)
            {
                popo.Background = OasisSnapjaw3;

            }
            if (cartascancha[1].nombre == "Oasis Snapjaw" && cartascancha[1].vida == 2)
            {
                popo.Background = OasisSnapjaw2;
            }
            if (cartascancha[1].nombre == "Oasis Snapjaw" && cartascancha[1].vida == 1)
            {
                popo.Background = OasisSnapjaw1;
            }
            if (cartascancha[1].nombre == "Boulderfist Ogre" && cartascancha[1].vida == 7)
            {
                popo.Background = BoulderfistOgre;
            }
            if (cartascancha[1].nombre == "Boulderfist Ogre" && cartascancha[1].vida == 6)
            {
                popo.Background = BoulderfistOgre6;
            }
            if (cartascancha[1].nombre == "Boulderfist Ogre" && cartascancha[1].vida == 5)
            {
                popo.Background = BoulderfistOgre5;
            }
            if (cartascancha[1].nombre == "Boulderfist Ogre" && cartascancha[1].vida == 4)
            {
                popo.Background = BoulderfistOgre4;
            }
            if (cartascancha[1].nombre == "Boulderfist Ogre" && cartascancha[1].vida == 3)
            {
                popo.Background = BoulderfistOgre3;
            }
            if (cartascancha[1].nombre == "Boulderfist Ogre" && cartascancha[1].vida == 2)
            {
                popo.Background = BoulderfistOgre2;
            }
            if (cartascancha[1].nombre == "Boulderfist Ogre" && cartascancha[1].vida == 1)
            {
                popo.Background = BoulderfistOgre1;
            }

            if (cartascancha[1].nombre == "War Golem" && cartascancha[1].vida == 7)
            {
                popo.Background = WarGolem;
            }
            if (cartascancha[1].nombre == "War Golem" && cartascancha[1].vida == 6)
            {
                popo.Background = WarGolem6;
            }
            if (cartascancha[1].nombre == "War Golem" && cartascancha[1].vida == 5)
            {
                popo.Background = WarGolem5;
            }
            if (cartascancha[1].nombre == "War Golem" && cartascancha[1].vida == 4)
            {
                popo.Background = WarGolem4;
            }
            if (cartascancha[1].nombre == "War Golem" && cartascancha[1].vida == 3)
            {
                popo.Background = WarGolem3;
            }
            if (cartascancha[1].nombre == "War Golem" && cartascancha[1].vida == 2)
            {
                popo.Background = WarGolem2;
            }
            if (cartascancha[1].nombre == "War Golem" && cartascancha[1].vida == 1)
            {
                popo.Background = WarGolem1;
            }

            if (cartascancha[1].nombre == "Core Hound" && cartascancha[1].vida == 5)
            {
                popo.Background = CoreHound;
            }
            if (cartascancha[1].nombre == "Core Hound" && cartascancha[1].vida == 4)
            {
                popo.Background = CoreHound4;
            }
            if (cartascancha[1].nombre == "Core Hound" && cartascancha[1].vida == 3)
            {
                popo.Background = CoreHound3;
            }
            if (cartascancha[1].nombre == "Core Hound" && cartascancha[1].vida == 2)
            {
                popo.Background = CoreHound2;

            }
            if (cartascancha[1].nombre == "Core Hound" && cartascancha[1].vida == 1)
            {
                popo.Background = CoreHound1;
            }
            if (cartascancha[1].nombre == "Recruit")
            {
                popo.Background = Recruit;
            }
            if (cartascancha[1].nombre == "Stoneclaw Totem")
            {
                popo.Background = totem11;
            }
            if (cartascancha[1].nombre == "Heilin Totem")
            {
                popo.Background = totem22;
            }
            if (cartascancha[1].nombre == "Warth of air Totem")
            {
                popo.Background = totem33;
            }
            if (cartascancha[1].nombre == "Seiring Totem")
            {
                popo.Background = totem44;
            }
            if (cartascancha[1].nombre == "Stoneclaw Totem" && cartascancha[1].vida == 1)
            {
                popo.Background = totem111;
            }
            if (cartascancha[1].nombre == "Heilin Totem" && cartascancha[1].vida == 1)
            {
                popo.Background = totem221;
            }
            if (cartascancha[1].nombre == "Warth of air Totem" && cartascancha[1].vida == 1)
            {
                popo.Background = totem331;
            }

            popo.Visibility = Visibility.Visible;

        }

        private void boton5_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Background = vacio;


        }

        private void boton6_MouseEnter(object sender, MouseEventArgs e)
        {

            if (cartascancha[2].nombre == "wisp")
            {
                popo.Background = wisp;

            }
            if (cartascancha[2].nombre == "Murloc Raider")
            {
                popo.Background = MurlocRaider;
            }
            if (cartascancha[2].nombre == "Bloodfen Raptor" && cartascancha[2].vida == 2)
            {
                popo.Background = BloodfenRaptor;
            }
            if (cartascancha[2].nombre == "Bloodfen Raptor" && cartascancha[2].vida == 1)
            {
                popo.Background = BloodfenRaptor1;
            }

            if (cartascancha[2].nombre == "River Crocolisk" && cartascancha[2].vida == 3)
            {
                popo.Background = RiverCrocolisk;
            }
            if (cartascancha[2].nombre == "River Crocolisk" && cartascancha[2].vida == 2)
            {
                popo.Background = RiverCrocolisk2;
            }
            if (cartascancha[2].nombre == "River Crocolisk" && cartascancha[2].vida == 1)
            {
                popo.Background = RiverCrocolisk1;
            }
            if (cartascancha[2].nombre == "Magma Rager")
            {
                popo.Background = MagmaRager;
            }
            if (cartascancha[2].nombre == "Chillwind Yeti" && cartascancha[2].vida == 5)
            {
                popo.Background = ChillwindYeti;
            }
            if (cartascancha[2].nombre == "Chillwind Yeti" && cartascancha[2].vida == 4)
            {
                popo.Background = ChillwindYeti4;
            }
            if (cartascancha[2].nombre == "Chillwind Yeti" && cartascancha[2].vida == 3)
            {
                popo.Background = ChillwindYeti3;
            }
            if (cartascancha[2].nombre == "Chillwind Yeti" && cartascancha[2].vida == 2)
            {
                popo.Background = ChillwindYeti2;
            }
            if (cartascancha[2].nombre == "Chillwind Yeti" && cartascancha[2].vida == 1)
            {
                popo.Background = ChillwindYeti1;
            }
            if (cartascancha[2].nombre == "Oasis Snapjaw" && cartascancha[2].vida == 7)
            {
                popo.Background = OasisSnapjaw;
            }
            if (cartascancha[2].nombre == "Oasis Snapjaw" && cartascancha[2].vida == 6)
            {
                popo.Background = OasisSnapjaw6;
            }
            if (cartascancha[2].nombre == "Oasis Snapjaw" && cartascancha[2].vida == 5)
            {
                popo.Background = OasisSnapjaw5;
            }
            if (cartascancha[2].nombre == "Oasis Snapjaw" && cartascancha[2].vida == 4)
            {
                popo.Background = OasisSnapjaw4;
            }
            if (cartascancha[2].nombre == "Oasis Snapjaw" && cartascancha[2].vida == 3)
            {
                popo.Background = OasisSnapjaw3;

            }
            if (cartascancha[2].nombre == "Oasis Snapjaw" && cartascancha[2].vida == 2)
            {
                popo.Background = OasisSnapjaw2;
            }
            if (cartascancha[2].nombre == "Oasis Snapjaw" && cartascancha[2].vida == 1)
            {
                popo.Background = OasisSnapjaw1;
            }
            if (cartascancha[2].nombre == "Boulderfist Ogre" && cartascancha[2].vida == 7)
            {
                popo.Background = BoulderfistOgre;
            }
            if (cartascancha[2].nombre == "Boulderfist Ogre" && cartascancha[2].vida == 6)
            {
                popo.Background = BoulderfistOgre6;
            }
            if (cartascancha[2].nombre == "Boulderfist Ogre" && cartascancha[2].vida == 5)
            {
                popo.Background = BoulderfistOgre5;
            }
            if (cartascancha[2].nombre == "Boulderfist Ogre" && cartascancha[2].vida == 4)
            {
                popo.Background = BoulderfistOgre4;
            }
            if (cartascancha[2].nombre == "Boulderfist Ogre" && cartascancha[2].vida == 3)
            {
                popo.Background = BoulderfistOgre3;
            }
            if (cartascancha[2].nombre == "Boulderfist Ogre" && cartascancha[2].vida == 2)
            {
                popo.Background = BoulderfistOgre2;
            }
            if (cartascancha[2].nombre == "Boulderfist Ogre" && cartascancha[2].vida == 1)
            {
                popo.Background = BoulderfistOgre1;
            }

            if (cartascancha[2].nombre == "War Golem" && cartascancha[2].vida == 7)
            {
                popo.Background = WarGolem;
            }
            if (cartascancha[2].nombre == "War Golem" && cartascancha[2].vida == 6)
            {
                popo.Background = WarGolem6;
            }
            if (cartascancha[2].nombre == "War Golem" && cartascancha[2].vida == 5)
            {
                popo.Background = WarGolem5;
            }
            if (cartascancha[2].nombre == "War Golem" && cartascancha[2].vida == 4)
            {
                popo.Background = WarGolem4;
            }
            if (cartascancha[2].nombre == "War Golem" && cartascancha[2].vida == 3)
            {
                popo.Background = WarGolem3;
            }
            if (cartascancha[2].nombre == "War Golem" && cartascancha[2].vida == 2)
            {
                popo.Background = WarGolem2;
            }
            if (cartascancha[2].nombre == "War Golem" && cartascancha[2].vida == 1)
            {
                popo.Background = WarGolem1;
            }

            if (cartascancha[2].nombre == "Core Hound" && cartascancha[2].vida == 5)
            {
                popo.Background = CoreHound;
            }
            if (cartascancha[2].nombre == "Core Hound" && cartascancha[2].vida == 4)
            {
                popo.Background = CoreHound4;
            }
            if (cartascancha[2].nombre == "Core Hound" && cartascancha[2].vida == 3)
            {
                popo.Background = CoreHound3;
            }
            if (cartascancha[2].nombre == "Core Hound" && cartascancha[2].vida == 2)
            {
                popo.Background = CoreHound2;

            }
            if (cartascancha[2].nombre == "Core Hound" && cartascancha[2].vida == 1)
            {
                popo.Background = CoreHound1;
            }
            if (cartascancha[2].nombre == "Recruit")
            {
                popo.Background = Recruit;
            }
            if (cartascancha[2].nombre == "Stoneclaw Totem")
            {
                popo.Background = totem11;
            }
            if (cartascancha[2].nombre == "Heilin Totem")
            {
                popo.Background = totem22;
            }
            if (cartascancha[2].nombre == "Warth of air Totem")
            {
                popo.Background = totem33;
            }
            if (cartascancha[2].nombre == "Seiring Totem")
            {
                popo.Background = totem44;
            }
            if (cartascancha[2].nombre == "Stoneclaw Totem" && cartascancha[2].vida == 1)
            {
                popo.Background = totem111;
            }
            if (cartascancha[2].nombre == "Heilin Totem" && cartascancha[2].vida == 1)
            {
                popo.Background = totem221;
            }
            if (cartascancha[2].nombre == "Warth of air Totem" && cartascancha[2].vida == 1)
            {
                popo.Background = totem331;
            }

            popo.Visibility = Visibility.Visible;

        }

        private void boton6_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Background = vacio;
        }

        private void boton7_MouseEnter(object sender, MouseEventArgs e)
        {
            ;
            if (cartascancha[3].nombre == "wisp")
            {
                popo.Background = wisp;

            }
            if (cartascancha[3].nombre == "Murloc Raider")
            {
                popo.Background = MurlocRaider;
            }
            if (cartascancha[3].nombre == "Bloodfen Raptor" && cartascancha[3].vida == 2)
            {
                popo.Background = BloodfenRaptor;
            }
            if (cartascancha[3].nombre == "Bloodfen Raptor" && cartascancha[3].vida == 1)
            {
                popo.Background = BloodfenRaptor1;
            }

            if (cartascancha[3].nombre == "River Crocolisk" && cartascancha[3].vida == 3)
            {
                popo.Background = RiverCrocolisk;
            }
            if (cartascancha[3].nombre == "River Crocolisk" && cartascancha[3].vida == 2)
            {
                popo.Background = RiverCrocolisk2;
            }
            if (cartascancha[3].nombre == "River Crocolisk" && cartascancha[3].vida == 1)
            {
                popo.Background = RiverCrocolisk1;
            }
            if (cartascancha[3].nombre == "Magma Rager")
            {
                popo.Background = MagmaRager;
            }
            if (cartascancha[3].nombre == "Chillwind Yeti" && cartascancha[3].vida == 5)
            {
                popo.Background = ChillwindYeti;
            }
            if (cartascancha[3].nombre == "Chillwind Yeti" && cartascancha[3].vida == 4)
            {
                popo.Background = ChillwindYeti4;
            }
            if (cartascancha[3].nombre == "Chillwind Yeti" && cartascancha[3].vida == 3)
            {
                popo.Background = ChillwindYeti3;
            }
            if (cartascancha[3].nombre == "Chillwind Yeti" && cartascancha[3].vida == 2)
            {
                popo.Background = ChillwindYeti2;
            }
            if (cartascancha[3].nombre == "Chillwind Yeti" && cartascancha[3].vida == 1)
            {
                popo.Background = ChillwindYeti1;
            }
            if (cartascancha[3].nombre == "Oasis Snapjaw" && cartascancha[3].vida == 7)
            {
                popo.Background = OasisSnapjaw;
            }
            if (cartascancha[3].nombre == "Oasis Snapjaw" && cartascancha[3].vida == 6)
            {
                popo.Background = OasisSnapjaw6;
            }
            if (cartascancha[3].nombre == "Oasis Snapjaw" && cartascancha[3].vida == 5)
            {
                popo.Background = OasisSnapjaw5;
            }
            if (cartascancha[3].nombre == "Oasis Snapjaw" && cartascancha[3].vida == 4)
            {
                popo.Background = OasisSnapjaw4;
            }
            if (cartascancha[3].nombre == "Oasis Snapjaw" && cartascancha[3].vida == 3)
            {
                popo.Background = OasisSnapjaw3;

            }
            if (cartascancha[3].nombre == "Oasis Snapjaw" && cartascancha[3].vida == 2)
            {
                popo.Background = OasisSnapjaw2;
            }
            if (cartascancha[3].nombre == "Oasis Snapjaw" && cartascancha[3].vida == 1)
            {
                popo.Background = OasisSnapjaw1;
            }
            if (cartascancha[3].nombre == "Boulderfist Ogre" && cartascancha[3].vida == 7)
            {
                popo.Background = BoulderfistOgre;
            }
            if (cartascancha[3].nombre == "Boulderfist Ogre" && cartascancha[3].vida == 6)
            {
                popo.Background = BoulderfistOgre6;
            }
            if (cartascancha[3].nombre == "Boulderfist Ogre" && cartascancha[3].vida == 5)
            {
                popo.Background = BoulderfistOgre5;
            }
            if (cartascancha[3].nombre == "Boulderfist Ogre" && cartascancha[3].vida == 4)
            {
                popo.Background = BoulderfistOgre4;
            }
            if (cartascancha[3].nombre == "Boulderfist Ogre" && cartascancha[3].vida == 3)
            {
                popo.Background = BoulderfistOgre3;
            }
            if (cartascancha[3].nombre == "Boulderfist Ogre" && cartascancha[3].vida == 2)
            {
                popo.Background = BoulderfistOgre2;
            }
            if (cartascancha[3].nombre == "Boulderfist Ogre" && cartascancha[3].vida == 1)
            {
                popo.Background = BoulderfistOgre1;
            }

            if (cartascancha[3].nombre == "War Golem" && cartascancha[3].vida == 7)
            {
                popo.Background = WarGolem;
            }
            if (cartascancha[3].nombre == "War Golem" && cartascancha[3].vida == 6)
            {
                popo.Background = WarGolem6;
            }
            if (cartascancha[3].nombre == "War Golem" && cartascancha[3].vida == 5)
            {
                popo.Background = WarGolem5;
            }
            if (cartascancha[3].nombre == "War Golem" && cartascancha[3].vida == 4)
            {
                popo.Background = WarGolem4;
            }
            if (cartascancha[3].nombre == "War Golem" && cartascancha[3].vida == 3)
            {
                popo.Background = WarGolem3;
            }
            if (cartascancha[3].nombre == "War Golem" && cartascancha[3].vida == 2)
            {
                popo.Background = WarGolem2;
            }
            if (cartascancha[3].nombre == "War Golem" && cartascancha[3].vida == 1)
            {
                popo.Background = WarGolem1;
            }

            if (cartascancha[3].nombre == "Core Hound" && cartascancha[3].vida == 5)
            {
                popo.Background = CoreHound;
            }
            if (cartascancha[3].nombre == "Core Hound" && cartascancha[3].vida == 4)
            {
                popo.Background = CoreHound4;
            }
            if (cartascancha[3].nombre == "Core Hound" && cartascancha[3].vida == 3)
            {
                popo.Background = CoreHound3;
            }
            if (cartascancha[3].nombre == "Core Hound" && cartascancha[3].vida == 2)
            {
                popo.Background = CoreHound2;

            }
            if (cartascancha[3].nombre == "Core Hound" && cartascancha[3].vida == 1)
            {
                popo.Background = CoreHound1;
            }
            if (cartascancha[3].nombre == "Recruit")
            {
                popo.Background = Recruit;
            }
            if (cartascancha[3].nombre == "Stoneclaw Totem")
            {
                popo.Background = totem11;
            }
            if (cartascancha[3].nombre == "Heilin Totem")
            {
                popo.Background = totem22;
            }
            if (cartascancha[3].nombre == "Warth of air Totem")
            {
                popo.Background = totem33;
            }
            if (cartascancha[3].nombre == "Seiring Totem")
            {
                popo.Background = totem44;
            }
            if (cartascancha[3].nombre == "Stoneclaw Totem" && cartascancha[3].vida == 1)
            {
                popo.Background = totem111;
            }
            if (cartascancha[3].nombre == "Heilin Totem" && cartascancha[3].vida == 1)
            {
                popo.Background = totem221;
            }
            if (cartascancha[3].nombre == "Warth of air Totem" && cartascancha[3].vida == 1)
            {
                popo.Background = totem331;
            }

            popo.Visibility = Visibility.Visible;
        }

        private void boton7_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Background = vacio;
        }

        private void boton8_Click(object sender, RoutedEventArgs e)
        {
            atacar = cartascancha[4];
            if (atacar != null && atacado != null || hatacado != null && atacar != null)
            {

                atacar2.IsEnabled = true;


            }
        }

        private void boton8_MouseEnter(object sender, MouseEventArgs e)
        {


            if (cartascancha[4].nombre == "wisp")
            {
                popo.Background = wisp;

            }
            if (cartascancha[4].nombre == "Murloc Raider")
            {
                popo.Background = MurlocRaider;
            }
            if (cartascancha[4].nombre == "Bloodfen Raptor" && cartascancha[4].vida == 2)
            {
                popo.Background = BloodfenRaptor;
            }
            if (cartascancha[4].nombre == "Bloodfen Raptor" && cartascancha[4].vida == 1)
            {
                popo.Background = BloodfenRaptor1;
            }

            if (cartascancha[4].nombre == "River Crocolisk" && cartascancha[4].vida == 3)
            {
                popo.Background = RiverCrocolisk;
            }
            if (cartascancha[4].nombre == "River Crocolisk" && cartascancha[4].vida == 2)
            {
                popo.Background = RiverCrocolisk2;
            }
            if (cartascancha[4].nombre == "River Crocolisk" && cartascancha[4].vida == 1)
            {
                popo.Background = RiverCrocolisk1;
            }
            if (cartascancha[4].nombre == "Magma Rager")
            {
                popo.Background = MagmaRager;
            }
            if (cartascancha[4].nombre == "Chillwind Yeti" && cartascancha[4].vida == 5)
            {
                popo.Background = ChillwindYeti;
            }
            if (cartascancha[4].nombre == "Chillwind Yeti" && cartascancha[4].vida == 4)
            {
                popo.Background = ChillwindYeti4;
            }
            if (cartascancha[4].nombre == "Chillwind Yeti" && cartascancha[4].vida == 3)
            {
                popo.Background = ChillwindYeti3;
            }
            if (cartascancha[4].nombre == "Chillwind Yeti" && cartascancha[4].vida == 2)
            {
                popo.Background = ChillwindYeti2;
            }
            if (cartascancha[4].nombre == "Chillwind Yeti" && cartascancha[4].vida == 1)
            {
                popo.Background = ChillwindYeti1;
            }
            if (cartascancha[4].nombre == "Oasis Snapjaw" && cartascancha[4].vida == 7)
            {
                popo.Background = OasisSnapjaw;
            }
            if (cartascancha[4].nombre == "Oasis Snapjaw" && cartascancha[4].vida == 6)
            {
                popo.Background = OasisSnapjaw6;
            }
            if (cartascancha[4].nombre == "Oasis Snapjaw" && cartascancha[4].vida == 5)
            {
                popo.Background = OasisSnapjaw5;
            }
            if (cartascancha[4].nombre == "Oasis Snapjaw" && cartascancha[4].vida == 4)
            {
                popo.Background = OasisSnapjaw4;
            }
            if (cartascancha[4].nombre == "Oasis Snapjaw" && cartascancha[4].vida == 3)
            {
                popo.Background = OasisSnapjaw3;

            }
            if (cartascancha[4].nombre == "Oasis Snapjaw" && cartascancha[4].vida == 2)
            {
                popo.Background = OasisSnapjaw2;
            }
            if (cartascancha[4].nombre == "Oasis Snapjaw" && cartascancha[4].vida == 1)
            {
                popo.Background = OasisSnapjaw1;
            }
            if (cartascancha[4].nombre == "Boulderfist Ogre" && cartascancha[4].vida == 7)
            {
                popo.Background = BoulderfistOgre;
            }
            if (cartascancha[4].nombre == "Boulderfist Ogre" && cartascancha[4].vida == 6)
            {
                popo.Background = BoulderfistOgre6;
            }
            if (cartascancha[4].nombre == "Boulderfist Ogre" && cartascancha[4].vida == 5)
            {
                popo.Background = BoulderfistOgre5;
            }
            if (cartascancha[4].nombre == "Boulderfist Ogre" && cartascancha[4].vida == 4)
            {
                popo.Background = BoulderfistOgre4;
            }
            if (cartascancha[4].nombre == "Boulderfist Ogre" && cartascancha[4].vida == 3)
            {
                popo.Background = BoulderfistOgre3;
            }
            if (cartascancha[4].nombre == "Boulderfist Ogre" && cartascancha[4].vida == 2)
            {
                popo.Background = BoulderfistOgre2;
            }
            if (cartascancha[4].nombre == "Boulderfist Ogre" && cartascancha[4].vida == 1)
            {
                popo.Background = BoulderfistOgre1;
            }

            if (cartascancha[4].nombre == "War Golem" && cartascancha[4].vida == 7)
            {
                popo.Background = WarGolem;
            }
            if (cartascancha[4].nombre == "War Golem" && cartascancha[4].vida == 6)
            {
                popo.Background = WarGolem6;
            }
            if (cartascancha[4].nombre == "War Golem" && cartascancha[4].vida == 5)
            {
                popo.Background = WarGolem5;
            }
            if (cartascancha[4].nombre == "War Golem" && cartascancha[4].vida == 4)
            {
                popo.Background = WarGolem4;
            }
            if (cartascancha[4].nombre == "War Golem" && cartascancha[4].vida == 3)
            {
                popo.Background = WarGolem3;
            }
            if (cartascancha[4].nombre == "War Golem" && cartascancha[4].vida == 2)
            {
                popo.Background = WarGolem2;
            }
            if (cartascancha[4].nombre == "War Golem" && cartascancha[4].vida == 1)
            {
                popo.Background = WarGolem1;
            }

            if (cartascancha[4].nombre == "Core Hound" && cartascancha[4].vida == 5)
            {
                popo.Background = CoreHound;
            }
            if (cartascancha[4].nombre == "Core Hound" && cartascancha[4].vida == 4)
            {
                popo.Background = CoreHound4;
            }
            if (cartascancha[4].nombre == "Core Hound" && cartascancha[4].vida == 3)
            {
                popo.Background = CoreHound3;
            }
            if (cartascancha[4].nombre == "Core Hound" && cartascancha[4].vida == 2)
            {
                popo.Background = CoreHound2;

            }
            if (cartascancha[4].nombre == "Core Hound" && cartascancha[4].vida == 1)
            {
                popo.Background = CoreHound1;
            }
            if (cartascancha[4].nombre == "Recruit")
            {
                popo.Background = Recruit;
            }
            if (cartascancha[4].nombre == "Heilin Totem")
            {
                popo.Background = totem11;
            }
            if (cartascancha[4].nombre == "Seiring Totem")
            {
                popo.Background = totem22;
            }
            if (cartascancha[4].nombre == "Stoneclaw Totem")
            {
                popo.Background = totem33;
            }
            if (cartascancha[4].nombre == "Warth of air Totem")
            {
                popo.Background = totem44;
            }
            if (cartascancha[4].nombre == "Stoneclaw Totem")
            {
                popo.Background = totem11;
            }
            if (cartascancha[4].nombre == "Heilin Totem")
            {
                popo.Background = totem22;
            }
            if (cartascancha[4].nombre == "Warth of air Totem")
            {
                popo.Background = totem33;
            }
            if (cartascancha[4].nombre == "Seiring Totem")
            {
                popo.Background = totem44;
            }
            if (cartascancha[4].nombre == "Stoneclaw Totem" && cartascancha[4].vida == 1)
            {
                popo.Background = totem111;
            }
            if (cartascancha[4].nombre == "Heilin Totem" && cartascancha[4].vida == 1)
            {
                popo.Background = totem221;
            }
            if (cartascancha[4].nombre == "Warth of air Totem" && cartascancha[4].vida == 1)
            {
                popo.Background = totem331;
            }

            popo.Visibility = Visibility.Visible;

        }

        private void boton8_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Background = vacio;
        }

        private void boton9_MouseEnter(object sender, MouseEventArgs e)
        {

            if (cartascancha[5].nombre == "wisp")
            {
                popo.Background = wisp;

            }
            if (cartascancha[5].nombre == "Murloc Raider")
            {
                popo.Background = MurlocRaider;
            }
            if (cartascancha[5].nombre == "Bloodfen Raptor" && cartascancha[5].vida == 2)
            {
                popo.Background = BloodfenRaptor;
            }
            if (cartascancha[5].nombre == "Bloodfen Raptor" && cartascancha[5].vida == 1)
            {
                popo.Background = BloodfenRaptor1;
            }

            if (cartascancha[5].nombre == "River Crocolisk" && cartascancha[5].vida == 3)
            {
                popo.Background = RiverCrocolisk;
            }
            if (cartascancha[5].nombre == "River Crocolisk" && cartascancha[5].vida == 2)
            {
                popo.Background = RiverCrocolisk2;
            }
            if (cartascancha[5].nombre == "River Crocolisk" && cartascancha[5].vida == 1)
            {
                popo.Background = RiverCrocolisk1;
            }
            if (cartascancha[5].nombre == "Magma Rager")
            {
                popo.Background = MagmaRager;
            }
            if (cartascancha[5].nombre == "Chillwind Yeti" && cartascancha[5].vida == 5)
            {
                popo.Background = ChillwindYeti;
            }
            if (cartascancha[5].nombre == "Chillwind Yeti" && cartascancha[5].vida == 4)
            {
                popo.Background = ChillwindYeti4;
            }
            if (cartascancha[5].nombre == "Chillwind Yeti" && cartascancha[5].vida == 3)
            {
                popo.Background = ChillwindYeti3;
            }
            if (cartascancha[5].nombre == "Chillwind Yeti" && cartascancha[5].vida == 2)
            {
                popo.Background = ChillwindYeti2;
            }
            if (cartascancha[5].nombre == "Chillwind Yeti" && cartascancha[5].vida == 1)
            {
                popo.Background = ChillwindYeti1;
            }
            if (cartascancha[5].nombre == "Oasis Snapjaw" && cartascancha[5].vida == 7)
            {
                popo.Background = OasisSnapjaw;
            }
            if (cartascancha[5].nombre == "Oasis Snapjaw" && cartascancha[5].vida == 6)
            {
                popo.Background = OasisSnapjaw6;
            }
            if (cartascancha[5].nombre == "Oasis Snapjaw" && cartascancha[5].vida == 5)
            {
                popo.Background = OasisSnapjaw5;
            }
            if (cartascancha[5].nombre == "Oasis Snapjaw" && cartascancha[5].vida == 4)
            {
                popo.Background = OasisSnapjaw4;
            }
            if (cartascancha[5].nombre == "Oasis Snapjaw" && cartascancha[5].vida == 3)
            {
                popo.Background = OasisSnapjaw3;

            }
            if (cartascancha[5].nombre == "Oasis Snapjaw" && cartascancha[5].vida == 2)
            {
                popo.Background = OasisSnapjaw2;
            }
            if (cartascancha[5].nombre == "Oasis Snapjaw" && cartascancha[5].vida == 1)
            {
                popo.Background = OasisSnapjaw1;
            }
            if (cartascancha[5].nombre == "Boulderfist Ogre" && cartascancha[5].vida == 7)
            {
                popo.Background = BoulderfistOgre;
            }
            if (cartascancha[5].nombre == "Boulderfist Ogre" && cartascancha[5].vida == 6)
            {
                popo.Background = BoulderfistOgre6;
            }
            if (cartascancha[5].nombre == "Boulderfist Ogre" && cartascancha[5].vida == 5)
            {
                popo.Background = BoulderfistOgre5;
            }
            if (cartascancha[5].nombre == "Boulderfist Ogre" && cartascancha[5].vida == 4)
            {
                popo.Background = BoulderfistOgre4;
            }
            if (cartascancha[5].nombre == "Boulderfist Ogre" && cartascancha[5].vida == 3)
            {
                popo.Background = BoulderfistOgre3;
            }
            if (cartascancha[5].nombre == "Boulderfist Ogre" && cartascancha[5].vida == 2)
            {
                popo.Background = BoulderfistOgre2;
            }
            if (cartascancha[5].nombre == "Boulderfist Ogre" && cartascancha[5].vida == 1)
            {
                popo.Background = BoulderfistOgre1;
            }

            if (cartascancha[5].nombre == "War Golem" && cartascancha[5].vida == 7)
            {
                popo.Background = WarGolem;
            }
            if (cartascancha[5].nombre == "War Golem" && cartascancha[5].vida == 6)
            {
                popo.Background = WarGolem6;
            }
            if (cartascancha[5].nombre == "War Golem" && cartascancha[5].vida == 5)
            {
                popo.Background = WarGolem5;
            }
            if (cartascancha[5].nombre == "War Golem" && cartascancha[5].vida == 4)
            {
                popo.Background = WarGolem4;
            }
            if (cartascancha[5].nombre == "War Golem" && cartascancha[5].vida == 3)
            {
                popo.Background = WarGolem3;
            }
            if (cartascancha[5].nombre == "War Golem" && cartascancha[5].vida == 2)
            {
                popo.Background = WarGolem2;
            }
            if (cartascancha[5].nombre == "War Golem" && cartascancha[5].vida == 1)
            {
                popo.Background = WarGolem1;
            }

            if (cartascancha[5].nombre == "Core Hound" && cartascancha[5].vida == 5)
            {
                popo.Background = CoreHound;
            }
            if (cartascancha[5].nombre == "Core Hound" && cartascancha[5].vida == 4)
            {
                popo.Background = CoreHound4;
            }
            if (cartascancha[5].nombre == "Core Hound" && cartascancha[5].vida == 3)
            {
                popo.Background = CoreHound3;
            }
            if (cartascancha[5].nombre == "Core Hound" && cartascancha[5].vida == 2)
            {
                popo.Background = CoreHound2;

            }
            if (cartascancha[5].nombre == "Core Hound" && cartascancha[5].vida == 1)
            {
                popo.Background = CoreHound1;
            }
            if (cartascancha[5].nombre == "Recruit")
            {
                popo.Background = Recruit;
            }
            if (cartascancha[5].nombre == "Stoneclaw Totem")
            {
                popo.Background = totem11;
            }
            if (cartascancha[5].nombre == "Heilin Totem")
            {
                popo.Background = totem22;
            }
            if (cartascancha[5].nombre == "Warth of air Totem")
            {
                popo.Background = totem33;
            }
            if (cartascancha[5].nombre == "Seiring Totem")
            {
                popo.Background = totem44;
            }
            if (cartascancha[5].nombre == "Stoneclaw Totem" && cartascancha[5].vida == 1)
            {
                popo.Background = totem111;
            }
            if (cartascancha[5].nombre == "Heilin Totem" && cartascancha[5].vida == 1)
            {
                popo.Background = totem221;
            }
            if (cartascancha[5].nombre == "Warth of air Totem" && cartascancha[5].vida == 1)
            {
                popo.Background = totem331;
            }

            popo.Visibility = Visibility.Visible;

        }

        private void boton9_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Background = vacio;
        }

        private void boton10_Click(object sender, RoutedEventArgs e)
        {
            atacar = cartascancha[6];
            if (atacar != null && atacado != null || hatacado != null && atacar != null)
            {

                atacar2.IsEnabled = true;


            }
        }

        private void boton10_MouseEnter(object sender, MouseEventArgs e)
        {

          
            if (cartascancha[6].nombre == "Murloc Raider")
            {
                popo.Background = MurlocRaider;
            }
            if (cartascancha[6].nombre == "wisp")
            {
                popo.Background = wisp;
            }
            if (cartascancha[6].nombre == "Bloodfen Raptor" && cartascancha[6].vida == 2)
            {
                popo.Background = BloodfenRaptor;
            }
            if (cartascancha[6].nombre == "Bloodfen Raptor" && cartascancha[6].vida == 1)
            {
                popo.Background = BloodfenRaptor1;
            }

            if (cartascancha[6].nombre == "River Crocolisk" && cartascancha[6].vida == 3)
            {
                popo.Background = RiverCrocolisk;
            }
            if (cartascancha[6].nombre == "River Crocolisk" && cartascancha[6].vida == 2)
            {
                popo.Background = RiverCrocolisk2;
            }
            if (cartascancha[6].nombre == "River Crocolisk" && cartascancha[6].vida == 1)
            {
                popo.Background = RiverCrocolisk1;
            }
            if (cartascancha[6].nombre == "Magma Rager")
            {
                popo.Background = MagmaRager;
            }
            if (cartascancha[6].nombre == "Chillwind Yeti" && cartascancha[6].vida == 5)
            {
                popo.Background = ChillwindYeti;
            }
            if (cartascancha[6].nombre == "Chillwind Yeti" && cartascancha[6].vida == 4)
            {
                popo.Background = ChillwindYeti4;
            }
            if (cartascancha[6].nombre == "Chillwind Yeti" && cartascancha[6].vida == 3)
            {
                popo.Background = ChillwindYeti3;
            }
            if (cartascancha[6].nombre == "Chillwind Yeti" && cartascancha[6].vida == 2)
            {
                popo.Background = ChillwindYeti2;
            }
            if (cartascancha[6].nombre == "Chillwind Yeti" && cartascancha[6].vida == 1)
            {
                popo.Background = ChillwindYeti1;
            }
            if (cartascancha[6].nombre == "Oasis Snapjaw" && cartascancha[6].vida == 7)
            {
                popo.Background = OasisSnapjaw;
            }
            if (cartascancha[6].nombre == "Oasis Snapjaw" && cartascancha[6].vida == 6)
            {
                popo.Background = OasisSnapjaw6;
            }
            if (cartascancha[6].nombre == "Oasis Snapjaw" && cartascancha[6].vida == 5)
            {
                popo.Background = OasisSnapjaw5;
            }
            if (cartascancha[6].nombre == "Oasis Snapjaw" && cartascancha[6].vida == 4)
            {
                popo.Background = OasisSnapjaw4;
            }
            if (cartascancha[6].nombre == "Oasis Snapjaw" && cartascancha[6].vida == 3)
            {
                popo.Background = OasisSnapjaw3;

            }
            if (cartascancha[6].nombre == "Oasis Snapjaw" && cartascancha[6].vida == 2)
            {
                popo.Background = OasisSnapjaw2;
            }
            if (cartascancha[6].nombre == "Oasis Snapjaw" && cartascancha[6].vida == 1)
            {
                popo.Background = OasisSnapjaw1;
            }
            if (cartascancha[6].nombre == "Boulderfist Ogre" && cartascancha[6].vida == 7)
            {
                popo.Background = BoulderfistOgre;
            }
            if (cartascancha[6].nombre == "Boulderfist Ogre" && cartascancha[6].vida == 6)
            {
                popo.Background = BoulderfistOgre6;
            }
            if (cartascancha[6].nombre == "Boulderfist Ogre" && cartascancha[6].vida == 5)
            {
                popo.Background = BoulderfistOgre5;
            }
            if (cartascancha[6].nombre == "Boulderfist Ogre" && cartascancha[6].vida == 4)
            {
                popo.Background = BoulderfistOgre4;
            }
            if (cartascancha[6].nombre == "Boulderfist Ogre" && cartascancha[6].vida == 3)
            {
                popo.Background = BoulderfistOgre3;
            }
            if (cartascancha[6].nombre == "Boulderfist Ogre" && cartascancha[6].vida == 2)
            {
                popo.Background = BoulderfistOgre2;
            }
            if (cartascancha[6].nombre == "Boulderfist Ogre" && cartascancha[6].vida == 1)
            {
                popo.Background = BoulderfistOgre1;
            }

            if (cartascancha[6].nombre == "War Golem" && cartascancha[6].vida == 7)
            {
                popo.Background = WarGolem;
            }
            if (cartascancha[6].nombre == "War Golem" && cartascancha[6].vida == 6)
            {
                popo.Background = WarGolem6;
            }
            if (cartascancha[6].nombre == "War Golem" && cartascancha[6].vida == 5)
            {
                popo.Background = WarGolem5;
            }
            if (cartascancha[6].nombre == "War Golem" && cartascancha[6].vida == 4)
            {
                popo.Background = WarGolem4;
            }
            if (cartascancha[6].nombre == "War Golem" && cartascancha[6].vida == 3)
            {
                popo.Background = WarGolem3;
            }
            if (cartascancha[6].nombre == "War Golem" && cartascancha[6].vida == 2)
            {
                popo.Background = WarGolem2;
            }
            if (cartascancha[6].nombre == "War Golem" && cartascancha[6].vida == 1)
            {
                popo.Background = WarGolem1;
            }

            if (cartascancha[6].nombre == "Core Hound" && cartascancha[6].vida == 5)
            {
                popo.Background = CoreHound;
            }
            if (cartascancha[6].nombre == "Core Hound" && cartascancha[6].vida == 4)
            {
                popo.Background = CoreHound4;
            }
            if (cartascancha[6].nombre == "Core Hound" && cartascancha[6].vida == 3)
            {
                popo.Background = CoreHound3;
            }
            if (cartascancha[6].nombre == "Core Hound" && cartascancha[6].vida == 2)
            {
                popo.Background = CoreHound2;

            }
            if (cartascancha[6].nombre == "Core Hound" && cartascancha[6].vida == 1)
            {
                popo.Background = CoreHound1;
            }
            if (cartascancha[6].nombre == "Recruit")
            {
                popo.Background = Recruit;
            }
            if (cartascancha[6].nombre == "Heilin Totem")
            {
                popo.Background = totem11;
            }
            if (cartascancha[6].nombre == "Seiring Totem")
            {
                popo.Background = totem22;
            }
            if (cartascancha[6].nombre == "Stoneclaw Totem")
            {
                popo.Background = totem33;
            }
            if (cartascancha[6].nombre == "Warth of air Totem")
            {
                popo.Background = totem44;
            }
            if (cartascancha[6].nombre == "Stoneclaw Totem")
            {
                popo.Background = totem11;
            }
            if (cartascancha[6].nombre == "Heilin Totem")
            {
                popo.Background = totem22;
            }
            if (cartascancha[6].nombre == "Warth of air Totem")
            {
                popo.Background = totem33;
            }
            if (cartascancha[6].nombre == "Seiring Totem")
            {
                popo.Background = totem44;
            }
            if (cartascancha[6].nombre == "Stoneclaw Totem" && cartascancha[6].vida == 1)
            {
                popo.Background = totem111;
            }
            if (cartascancha[6].nombre == "Heilin Totem" && cartascancha[6].vida == 1)
            {
                popo.Background = totem221;
            }
            if (cartascancha[6].nombre == "Warth of air Totem" && cartascancha[6].vida == 1)
            {
                popo.Background = totem331;
            }
            popo.Visibility = Visibility.Visible;
        }

        private void boton10_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Background = vacio;
        }

        private void popo_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void boton11_MouseEnter(object sender, MouseEventArgs e)
        {

            if (cartascancha2[0].nombre == "wisp")
            {
                popo.Background = wisp;

            }
            if (cartascancha2[0].nombre == "Murloc Raider")
            {
                popo.Background = MurlocRaider;
            }
            if (cartascancha2[0].nombre == "Bloodfen Raptor" && cartascancha2[0].vida == 2)
            {
                popo.Background = BloodfenRaptor;
            }
            if (cartascancha2[0].nombre == "Bloodfen Raptor" && cartascancha2[0].vida == 1)
            {
                popo.Background = BloodfenRaptor1;
            }

            if (cartascancha2[0].nombre == "River Crocolisk" && cartascancha2[0].vida == 3)
            {
                popo.Background = RiverCrocolisk;
            }
            if (cartascancha2[0].nombre == "River Crocolisk" && cartascancha2[0].vida == 2)
            {
                popo.Background = RiverCrocolisk2;
            }
            if (cartascancha2[0].nombre == "River Crocolisk" && cartascancha2[0].vida == 1)
            {
                popo.Background = RiverCrocolisk1;
            }
            if (cartascancha2[0].nombre == "Magma Rager")
            {
                popo.Background = MagmaRager;
            }
            if (cartascancha2[0].nombre == "Chillwind Yeti" && cartascancha2[0].vida == 5)
            {
                popo.Background = ChillwindYeti;
            }
            if (cartascancha2[0].nombre == "Chillwind Yeti" && cartascancha2[0].vida == 4)
            {
                popo.Background = ChillwindYeti4;
            }
            if (cartascancha2[0].nombre == "Chillwind Yeti" && cartascancha2[0].vida == 3)
            {
                popo.Background = ChillwindYeti3;
            }
            if (cartascancha2[0].nombre == "Chillwind Yeti" && cartascancha2[0].vida == 2)
            {
                popo.Background = ChillwindYeti2;
            }
            if (cartascancha2[0].nombre == "Chillwind Yeti" && cartascancha2[0].vida == 1)
            {
                popo.Background = ChillwindYeti1;
            }
            if (cartascancha2[0].nombre == "Oasis Snapjaw" && cartascancha2[0].vida == 7)
            {
                popo.Background = OasisSnapjaw;
            }
            if (cartascancha2[0].nombre == "Oasis Snapjaw" && cartascancha2[0].vida == 6)
            {
                popo.Background = OasisSnapjaw6;
            }
            if (cartascancha2[0].nombre == "Oasis Snapjaw" && cartascancha2[0].vida == 5)
            {
                popo.Background = OasisSnapjaw5;
            }
            if (cartascancha2[0].nombre == "Oasis Snapjaw" && cartascancha2[0].vida == 4)
            {
                popo.Background = OasisSnapjaw4;
            }
            if (cartascancha2[0].nombre == "Oasis Snapjaw" && cartascancha2[0].vida == 3)
            {
                popo.Background = OasisSnapjaw3;

            }
            if (cartascancha2[0].nombre == "Oasis Snapjaw" && cartascancha2[0].vida == 2)
            {
                popo.Background = OasisSnapjaw2;
            }
            if (cartascancha2[0].nombre == "Oasis Snapjaw" && cartascancha2[0].vida == 1)
            {
                popo.Background = OasisSnapjaw1;
            }
            if (cartascancha2[0].nombre == "Boulderfist Ogre" && cartascancha2[0].vida == 7)
            {
                popo.Background = BoulderfistOgre;
            }
            if (cartascancha2[0].nombre == "Boulderfist Ogre" && cartascancha2[0].vida == 6)
            {
                popo.Background = BoulderfistOgre6;
            }
            if (cartascancha2[0].nombre == "Boulderfist Ogre" && cartascancha2[0].vida == 5)
            {
                popo.Background = BoulderfistOgre5;
            }
            if (cartascancha2[0].nombre == "Boulderfist Ogre" && cartascancha2[0].vida == 4)
            {
                popo.Background = BoulderfistOgre4;
            }
            if (cartascancha2[0].nombre == "Boulderfist Ogre" && cartascancha2[0].vida == 3)
            {
                popo.Background = BoulderfistOgre3;
            }
            if (cartascancha2[0].nombre == "Boulderfist Ogre" && cartascancha2[0].vida == 2)
            {
                popo.Background = BoulderfistOgre2;
            }
            if (cartascancha2[0].nombre == "Boulderfist Ogre" && cartascancha2[0].vida == 1)
            {
                popo.Background = BoulderfistOgre1;
            }

            if (cartascancha2[0].nombre == "War Golem" && cartascancha2[0].vida == 7)
            {
                popo.Background = WarGolem;
            }
            if (cartascancha2[0].nombre == "War Golem" && cartascancha2[0].vida == 6)
            {
                popo.Background = WarGolem6;
            }
            if (cartascancha2[0].nombre == "War Golem" && cartascancha2[0].vida == 5)
            {
                popo.Background = WarGolem5;
            }
            if (cartascancha2[0].nombre == "War Golem" && cartascancha2[0].vida == 4)
            {
                popo.Background = WarGolem4;
            }
            if (cartascancha2[0].nombre == "War Golem" && cartascancha2[0].vida == 3)
            {
                popo.Background = WarGolem3;
            }
            if (cartascancha2[0].nombre == "War Golem" && cartascancha2[0].vida == 2)
            {
                popo.Background = WarGolem2;
            }
            if (cartascancha2[0].nombre == "War Golem" && cartascancha2[0].vida == 1)
            {
                popo.Background = WarGolem1;
            }

            if (cartascancha2[0].nombre == "Core Hound" && cartascancha2[0].vida == 5)
            {
                popo.Background = CoreHound;
            }
            if (cartascancha2[0].nombre == "Core Hound" && cartascancha2[0].vida == 4)
            {
                popo.Background = CoreHound4;
            }
            if (cartascancha2[0].nombre == "Core Hound" && cartascancha2[0].vida == 3)
            {
                popo.Background = CoreHound3;
            }
            if (cartascancha2[0].nombre == "Core Hound" && cartascancha2[0].vida == 2)
            {
                popo.Background = CoreHound2;

            }
            if (cartascancha2[0].nombre == "Core Hound" && cartascancha2[0].vida == 1)
            {
                popo.Background = CoreHound1;
            }
            if (cartascancha2[0].nombre == "Recruit")
            {
                popo.Background = Recruit;
            }
            if (cartascancha2[0].nombre == "Stoneclaw Totem")
            {
                popo.Background = totem11;
            }
            if (cartascancha2[0].nombre == "Heilin Totem")
            {
                popo.Background = totem22;
            }
            if (cartascancha2[0].nombre == "Warth of air Totem")
            {
                popo.Background = totem33;
            }
            if (cartascancha2[0].nombre == "Seiring Totem")
            {
                popo.Background = totem44;
            }
            if (cartascancha2[0].nombre == "Stoneclaw Totem" && cartascancha2[0].vida == 1)
            {
                popo.Background = totem111;
            }
            if (cartascancha2[0].nombre == "Heilin Totem" && cartascancha2[0].vida == 1)
            {
                popo.Background = totem221;
            }
            if (cartascancha2[0].nombre == "Warth of air Totem" && cartascancha2[0].vida == 1)
            {
                popo.Background = totem331;
            }

            popo.Visibility = Visibility.Visible;
            //a2[o].Content = cartascancha2[o].nombre + "                \n ocupa mana: " + cartascancha2[o].mana + "\n ataca  " + cartascancha2[o].ataque + "\n  tiene vida  " + cartascancha2[o].vida;

        }

        private void boton11_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Background = vacio;
        }

        private void boton12_MouseEnter(object sender, MouseEventArgs e)
        {

            if (cartascancha2[1].nombre == "wisp")
            {
                popo.Background = wisp;

            }
            if (cartascancha2[1].nombre == "Murloc Raider")
            {
                popo.Background = MurlocRaider;
            }
            if (cartascancha2[1].nombre == "Bloodfen Raptor" && cartascancha2[1].vida == 2)
            {
                popo.Background = BloodfenRaptor;
            }
            if (cartascancha2[1].nombre == "Bloodfen Raptor" && cartascancha2[1].vida == 1)
            {
                popo.Background = BloodfenRaptor1;
            }

            if (cartascancha2[1].nombre == "River Crocolisk" && cartascancha2[1].vida == 3)
            {
                popo.Background = RiverCrocolisk;
            }
            if (cartascancha2[1].nombre == "River Crocolisk" && cartascancha2[1].vida == 2)
            {
                popo.Background = RiverCrocolisk2;
            }
            if (cartascancha2[1].nombre == "River Crocolisk" && cartascancha2[1].vida == 1)
            {
                popo.Background = RiverCrocolisk1;
            }
            if (cartascancha2[1].nombre == "Magma Rager")
            {
                popo.Background = MagmaRager;
            }
            if (cartascancha2[1].nombre == "Chillwind Yeti" && cartascancha2[1].vida == 5)
            {
                popo.Background = ChillwindYeti;
            }
            if (cartascancha2[1].nombre == "Chillwind Yeti" && cartascancha2[1].vida == 4)
            {
                popo.Background = ChillwindYeti4;
            }
            if (cartascancha2[1].nombre == "Chillwind Yeti" && cartascancha2[1].vida == 3)
            {
                popo.Background = ChillwindYeti3;
            }
            if (cartascancha2[1].nombre == "Chillwind Yeti" && cartascancha2[1].vida == 2)
            {
                popo.Background = ChillwindYeti2;
            }
            if (cartascancha2[1].nombre == "Chillwind Yeti" && cartascancha2[1].vida == 1)
            {
                popo.Background = ChillwindYeti1;
            }
            if (cartascancha2[1].nombre == "Oasis Snapjaw" && cartascancha2[1].vida == 7)
            {
                popo.Background = OasisSnapjaw;
            }
            if (cartascancha2[1].nombre == "Oasis Snapjaw" && cartascancha2[1].vida == 6)
            {
                popo.Background = OasisSnapjaw6;
            }
            if (cartascancha2[1].nombre == "Oasis Snapjaw" && cartascancha2[1].vida == 5)
            {
                popo.Background = OasisSnapjaw5;
            }
            if (cartascancha2[1].nombre == "Oasis Snapjaw" && cartascancha2[1].vida == 4)
            {
                popo.Background = OasisSnapjaw4;
            }
            if (cartascancha2[1].nombre == "Oasis Snapjaw" && cartascancha2[1].vida == 3)
            {
                popo.Background = OasisSnapjaw3;

            }
            if (cartascancha2[1].nombre == "Oasis Snapjaw" && cartascancha2[1].vida == 2)
            {
                popo.Background = OasisSnapjaw2;
            }
            if (cartascancha2[1].nombre == "Oasis Snapjaw" && cartascancha2[1].vida == 1)
            {
                popo.Background = OasisSnapjaw1;
            }
            if (cartascancha2[1].nombre == "Boulderfist Ogre" && cartascancha2[1].vida == 7)
            {
                popo.Background = BoulderfistOgre;
            }
            if (cartascancha2[1].nombre == "Boulderfist Ogre" && cartascancha2[1].vida == 6)
            {
                popo.Background = BoulderfistOgre6;
            }
            if (cartascancha2[1].nombre == "Boulderfist Ogre" && cartascancha2[1].vida == 5)
            {
                popo.Background = BoulderfistOgre5;
            }
            if (cartascancha2[1].nombre == "Boulderfist Ogre" && cartascancha2[1].vida == 4)
            {
                popo.Background = BoulderfistOgre4;
            }
            if (cartascancha2[1].nombre == "Boulderfist Ogre" && cartascancha2[1].vida == 3)
            {
                popo.Background = BoulderfistOgre3;
            }
            if (cartascancha2[1].nombre == "Boulderfist Ogre" && cartascancha2[1].vida == 2)
            {
                popo.Background = BoulderfistOgre2;
            }
            if (cartascancha2[1].nombre == "Boulderfist Ogre" && cartascancha2[1].vida == 1)
            {
                popo.Background = BoulderfistOgre1;
            }

            if (cartascancha2[1].nombre == "War Golem" && cartascancha2[1].vida == 7)
            {
                popo.Background = WarGolem;
            }
            if (cartascancha2[1].nombre == "War Golem" && cartascancha2[1].vida == 6)
            {
                popo.Background = WarGolem6;
            }
            if (cartascancha2[1].nombre == "War Golem" && cartascancha2[1].vida == 5)
            {
                popo.Background = WarGolem5;
            }
            if (cartascancha2[1].nombre == "War Golem" && cartascancha2[1].vida == 4)
            {
                popo.Background = WarGolem4;
            }
            if (cartascancha2[1].nombre == "War Golem" && cartascancha2[1].vida == 3)
            {
                popo.Background = WarGolem3;
            }
            if (cartascancha2[1].nombre == "War Golem" && cartascancha2[1].vida == 2)
            {
                popo.Background = WarGolem2;
            }
            if (cartascancha2[1].nombre == "War Golem" && cartascancha2[1].vida == 1)
            {
                popo.Background = WarGolem1;
            }

            if (cartascancha2[1].nombre == "Core Hound" && cartascancha2[1].vida == 5)
            {
                popo.Background = CoreHound;
            }
            if (cartascancha2[1].nombre == "Core Hound" && cartascancha2[1].vida == 4)
            {
                popo.Background = CoreHound4;
            }
            if (cartascancha2[1].nombre == "Core Hound" && cartascancha2[1].vida == 3)
            {
                popo.Background = CoreHound3;
            }
            if (cartascancha2[1].nombre == "Core Hound" && cartascancha2[1].vida == 2)
            {
                popo.Background = CoreHound2;

            }
            if (cartascancha2[1].nombre == "Core Hound" && cartascancha2[1].vida == 1)
            {
                popo.Background = CoreHound1;
            }
            if (cartascancha2[1].nombre == "Stoneclaw Totem")
            {
                popo.Background = totem11;
            }
            if (cartascancha2[1].nombre == "Heilin Totem")
            {
                popo.Background = totem22;
            }
            if (cartascancha2[1].nombre == "Warth of air Totem")
            {
                popo.Background = totem33;
            }
            if (cartascancha2[1].nombre == "Seiring Totem")
            {
                popo.Background = totem44;
            }
            if (cartascancha2[1].nombre == "Stoneclaw Totem" && cartascancha2[1].vida == 1)
            {
                popo.Background = totem111;
            }
            if (cartascancha2[1].nombre == "Heilin Totem" && cartascancha2[1].vida == 1)
            {
                popo.Background = totem221;
            }
            if (cartascancha2[1].nombre == "Warth of air Totem" && cartascancha2[1].vida == 1)
            {
                popo.Background = totem331;
            }

            popo.Visibility = Visibility.Visible;

        }

        private void boton12_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Background = vacio;
        }

        private void boton13_MouseEnter(object sender, MouseEventArgs e)
        {

            if (cartascancha2[2].nombre == "wisp")
            {
                popo.Background = wisp;

            }
            if (cartascancha2[2].nombre == "Murloc Raider")
            {
                popo.Background = MurlocRaider;
            }
            if (cartascancha2[2].nombre == "Bloodfen Raptor" && cartascancha2[2].vida == 2)
            {
                popo.Background = BloodfenRaptor;
            }
            if (cartascancha2[2].nombre == "Bloodfen Raptor" && cartascancha2[2].vida == 1)
            {
                popo.Background = BloodfenRaptor1;
            }

            if (cartascancha2[2].nombre == "River Crocolisk" && cartascancha2[2].vida == 3)
            {
                popo.Background = RiverCrocolisk;
            }
            if (cartascancha2[2].nombre == "River Crocolisk" && cartascancha2[2].vida == 2)
            {
                popo.Background = RiverCrocolisk2;
            }
            if (cartascancha2[2].nombre == "River Crocolisk" && cartascancha2[2].vida == 1)
            {
                popo.Background = RiverCrocolisk1;
            }
            if (cartascancha2[2].nombre == "Magma Rager")
            {
                popo.Background = MagmaRager;
            }
            if (cartascancha2[2].nombre == "Chillwind Yeti" && cartascancha2[2].vida == 5)
            {
                popo.Background = ChillwindYeti;
            }
            if (cartascancha2[2].nombre == "Chillwind Yeti" && cartascancha2[2].vida == 4)
            {
                popo.Background = ChillwindYeti4;
            }
            if (cartascancha2[2].nombre == "Chillwind Yeti" && cartascancha2[2].vida == 3)
            {
                popo.Background = ChillwindYeti3;
            }
            if (cartascancha2[2].nombre == "Chillwind Yeti" && cartascancha2[2].vida == 2)
            {
                popo.Background = ChillwindYeti2;
            }
            if (cartascancha2[2].nombre == "Chillwind Yeti" && cartascancha2[2].vida == 1)
            {
                popo.Background = ChillwindYeti1;
            }
            if (cartascancha2[2].nombre == "Oasis Snapjaw" && cartascancha2[2].vida == 7)
            {
                popo.Background = OasisSnapjaw;
            }
            if (cartascancha2[2].nombre == "Oasis Snapjaw" && cartascancha2[2].vida == 6)
            {
                popo.Background = OasisSnapjaw6;
            }
            if (cartascancha2[2].nombre == "Oasis Snapjaw" && cartascancha2[2].vida == 5)
            {
                popo.Background = OasisSnapjaw5;
            }
            if (cartascancha2[2].nombre == "Oasis Snapjaw" && cartascancha2[2].vida == 4)
            {
                popo.Background = OasisSnapjaw4;
            }
            if (cartascancha2[2].nombre == "Oasis Snapjaw" && cartascancha2[2].vida == 3)
            {
                popo.Background = OasisSnapjaw3;

            }
            if (cartascancha2[2].nombre == "Oasis Snapjaw" && cartascancha2[2].vida == 2)
            {
                popo.Background = OasisSnapjaw2;
            }
            if (cartascancha2[2].nombre == "Oasis Snapjaw" && cartascancha2[2].vida == 1)
            {
                popo.Background = OasisSnapjaw1;
            }
            if (cartascancha2[2].nombre == "Boulderfist Ogre" && cartascancha2[2].vida == 7)
            {
                popo.Background = BoulderfistOgre;
            }
            if (cartascancha2[2].nombre == "Boulderfist Ogre" && cartascancha2[2].vida == 6)
            {
                popo.Background = BoulderfistOgre6;
            }
            if (cartascancha2[2].nombre == "Boulderfist Ogre" && cartascancha2[2].vida == 5)
            {
                popo.Background = BoulderfistOgre5;
            }
            if (cartascancha2[2].nombre == "Boulderfist Ogre" && cartascancha2[2].vida == 4)
            {
                popo.Background = BoulderfistOgre4;
            }
            if (cartascancha2[2].nombre == "Boulderfist Ogre" && cartascancha2[2].vida == 3)
            {
                popo.Background = BoulderfistOgre3;
            }
            if (cartascancha2[2].nombre == "Boulderfist Ogre" && cartascancha2[2].vida == 2)
            {
                popo.Background = BoulderfistOgre2;
            }
            if (cartascancha2[2].nombre == "Boulderfist Ogre" && cartascancha2[2].vida == 1)
            {
                popo.Background = BoulderfistOgre1;
            }

            if (cartascancha2[2].nombre == "War Golem" && cartascancha2[2].vida == 7)
            {
                popo.Background = WarGolem;
            }
            if (cartascancha2[2].nombre == "War Golem" && cartascancha2[2].vida == 6)
            {
                popo.Background = WarGolem6;
            }
            if (cartascancha2[2].nombre == "War Golem" && cartascancha2[2].vida == 5)
            {
                popo.Background = WarGolem5;
            }
            if (cartascancha2[2].nombre == "War Golem" && cartascancha2[2].vida == 4)
            {
                popo.Background = WarGolem4;
            }
            if (cartascancha2[2].nombre == "War Golem" && cartascancha2[2].vida == 3)
            {
                popo.Background = WarGolem3;
            }
            if (cartascancha2[2].nombre == "War Golem" && cartascancha2[2].vida == 2)
            {
                popo.Background = WarGolem2;
            }
            if (cartascancha2[2].nombre == "War Golem" && cartascancha2[2].vida == 1)
            {
                popo.Background = WarGolem1;
            }

            if (cartascancha2[2].nombre == "Core Hound" && cartascancha2[2].vida == 5)
            {
                popo.Background = CoreHound;
            }
            if (cartascancha2[2].nombre == "Core Hound" && cartascancha2[2].vida == 4)
            {
                popo.Background = CoreHound4;
            }
            if (cartascancha2[2].nombre == "Core Hound" && cartascancha2[2].vida == 3)
            {
                popo.Background = CoreHound3;
            }
            if (cartascancha2[2].nombre == "Core Hound" && cartascancha2[2].vida == 2)
            {
                popo.Background = CoreHound2;

            }
            if (cartascancha2[2].nombre == "Core Hound" && cartascancha2[2].vida == 1)
            {
                popo.Background = CoreHound1;
            }
            if (cartascancha2[2].nombre == "Recruit")
            {
                popo.Background = Recruit;
            }
            if (cartascancha2[2].nombre == "Stoneclaw Totem")
            {
                popo.Background = totem11;
            }
            if (cartascancha2[2].nombre == "Heilin Totem")
            {
                popo.Background = totem22;
            }
            if (cartascancha2[2].nombre == "Warth of air Totem")
            {
                popo.Background = totem33;
            }
            if (cartascancha2[2].nombre == "Seiring Totem")
            {
                popo.Background = totem44;
            }
            if (cartascancha2[2].nombre == "Stoneclaw Totem" && cartascancha2[2].vida == 1)
            {
                popo.Background = totem111;
            }
            if (cartascancha2[2].nombre == "Heilin Totem" && cartascancha2[2].vida == 1)
            {
                popo.Background = totem221;
            }
            if (cartascancha2[2].nombre == "Warth of air Totem" && cartascancha2[2].vida == 1)
            {
                popo.Background = totem331;
            }

            popo.Visibility = Visibility.Visible;
        }

        private void boton13_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Background = vacio;
        }

        private void boton14_MouseEnter(object sender, MouseEventArgs e)
        {

            if (cartascancha2[3].nombre == "wisp")
            {
                popo.Background = wisp;

            }
            if (cartascancha2[3].nombre == "Murloc Raider")
            {
                popo.Background = MurlocRaider;
            }
            if (cartascancha2[3].nombre == "Bloodfen Raptor" && cartascancha2[3].vida == 2)
            {
                popo.Background = BloodfenRaptor;
            }
            if (cartascancha2[3].nombre == "Bloodfen Raptor" && cartascancha2[3].vida == 1)
            {
                popo.Background = BloodfenRaptor1;
            }

            if (cartascancha2[3].nombre == "River Crocolisk" && cartascancha2[3].vida == 3)
            {
                popo.Background = RiverCrocolisk;
            }
            if (cartascancha2[3].nombre == "River Crocolisk" && cartascancha2[3].vida == 2)
            {
                popo.Background = RiverCrocolisk2;
            }
            if (cartascancha2[3].nombre == "River Crocolisk" && cartascancha2[3].vida == 1)
            {
                popo.Background = RiverCrocolisk1;
            }
            if (cartascancha2[3].nombre == "Magma Rager")
            {
                popo.Background = MagmaRager;
            }
            if (cartascancha2[3].nombre == "Chillwind Yeti" && cartascancha2[3].vida == 5)
            {
                popo.Background = ChillwindYeti;
            }
            if (cartascancha2[3].nombre == "Chillwind Yeti" && cartascancha2[3].vida == 4)
            {
                popo.Background = ChillwindYeti4;
            }
            if (cartascancha2[3].nombre == "Chillwind Yeti" && cartascancha2[3].vida == 3)
            {
                popo.Background = ChillwindYeti3;
            }
            if (cartascancha2[3].nombre == "Chillwind Yeti" && cartascancha2[3].vida == 2)
            {
                popo.Background = ChillwindYeti2;
            }
            if (cartascancha2[3].nombre == "Chillwind Yeti" && cartascancha2[3].vida == 1)
            {
                popo.Background = ChillwindYeti1;
            }
            if (cartascancha2[3].nombre == "Oasis Snapjaw" && cartascancha2[3].vida == 7)
            {
                popo.Background = OasisSnapjaw;
            }
            if (cartascancha2[3].nombre == "Oasis Snapjaw" && cartascancha2[3].vida == 6)
            {
                popo.Background = OasisSnapjaw6;
            }
            if (cartascancha2[3].nombre == "Oasis Snapjaw" && cartascancha2[3].vida == 5)
            {
                popo.Background = OasisSnapjaw5;
            }
            if (cartascancha2[3].nombre == "Oasis Snapjaw" && cartascancha2[3].vida == 4)
            {
                popo.Background = OasisSnapjaw4;
            }
            if (cartascancha2[3].nombre == "Oasis Snapjaw" && cartascancha2[3].vida == 3)
            {
                popo.Background = OasisSnapjaw3;

            }
            if (cartascancha2[3].nombre == "Oasis Snapjaw" && cartascancha2[3].vida == 2)
            {
                popo.Background = OasisSnapjaw2;
            }
            if (cartascancha2[3].nombre == "Oasis Snapjaw" && cartascancha2[3].vida == 1)
            {
                popo.Background = OasisSnapjaw1;
            }
            if (cartascancha2[3].nombre == "Boulderfist Ogre" && cartascancha2[3].vida == 7)
            {
                popo.Background = BoulderfistOgre;
            }
            if (cartascancha2[3].nombre == "Boulderfist Ogre" && cartascancha2[3].vida == 6)
            {
                popo.Background = BoulderfistOgre6;
            }
            if (cartascancha2[3].nombre == "Boulderfist Ogre" && cartascancha2[3].vida == 5)
            {
                popo.Background = BoulderfistOgre5;
            }
            if (cartascancha2[3].nombre == "Boulderfist Ogre" && cartascancha2[3].vida == 4)
            {
                popo.Background = BoulderfistOgre4;
            }
            if (cartascancha2[3].nombre == "Boulderfist Ogre" && cartascancha2[3].vida == 3)
            {
                popo.Background = BoulderfistOgre3;
            }
            if (cartascancha2[3].nombre == "Boulderfist Ogre" && cartascancha2[3].vida == 2)
            {
                popo.Background = BoulderfistOgre2;
            }
            if (cartascancha2[3].nombre == "Boulderfist Ogre" && cartascancha2[3].vida == 1)
            {
                popo.Background = BoulderfistOgre1;
            }

            if (cartascancha2[3].nombre == "War Golem" && cartascancha2[3].vida == 7)
            {
                popo.Background = WarGolem;
            }
            if (cartascancha2[3].nombre == "War Golem" && cartascancha2[3].vida == 6)
            {
                popo.Background = WarGolem6;
            }
            if (cartascancha2[3].nombre == "War Golem" && cartascancha2[3].vida == 5)
            {
                popo.Background = WarGolem5;
            }
            if (cartascancha2[3].nombre == "War Golem" && cartascancha2[3].vida == 4)
            {
                popo.Background = WarGolem4;
            }
            if (cartascancha2[3].nombre == "War Golem" && cartascancha2[3].vida == 3)
            {
                popo.Background = WarGolem3;
            }
            if (cartascancha2[3].nombre == "War Golem" && cartascancha2[3].vida == 2)
            {
                popo.Background = WarGolem2;
            }
            if (cartascancha2[3].nombre == "War Golem" && cartascancha2[3].vida == 1)
            {
                popo.Background = WarGolem1;
            }

            if (cartascancha2[3].nombre == "Core Hound" && cartascancha2[3].vida == 5)
            {
                popo.Background = CoreHound;
            }
            if (cartascancha2[3].nombre == "Core Hound" && cartascancha2[3].vida == 4)
            {
                popo.Background = CoreHound4;
            }
            if (cartascancha2[3].nombre == "Core Hound" && cartascancha2[3].vida == 3)
            {
                popo.Background = CoreHound3;
            }
            if (cartascancha2[3].nombre == "Core Hound" && cartascancha2[3].vida == 2)
            {
                popo.Background = CoreHound2;

            }
            if (cartascancha2[3].nombre == "Core Hound" && cartascancha2[3].vida == 1)
            {
                popo.Background = CoreHound1;
            }
            if (cartascancha2[3].nombre == "Recruit")
            {
                popo.Background = Recruit;
            }
            if (cartascancha2[3].nombre == "Stoneclaw Totem")
            {
                popo.Background = totem11;
            }
            if (cartascancha2[3].nombre == "Heilin Totem")
            {
                popo.Background = totem22;
            }
            if (cartascancha2[3].nombre == "Warth of air Totem")
            {
                popo.Background = totem33;
            }
            if (cartascancha2[3].nombre == "Seiring Totem")
            {
                popo.Background = totem44;
            }
            if (cartascancha2[3].nombre == "Stoneclaw Totem" && cartascancha2[3].vida == 1)
            {
                popo.Background = totem111;
            }
            if (cartascancha2[3].nombre == "Heilin Totem" && cartascancha2[3].vida == 1)
            {
                popo.Background = totem221;
            }
            if (cartascancha2[3].nombre == "Warth of air Totem" && cartascancha2[3].vida == 1)
            {
                popo.Background = totem331;
            }

            popo.Visibility = Visibility.Visible;
        }

        private void boton14_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Background = vacio;
        }

        private void boton15_MouseEnter(object sender, MouseEventArgs e)
        {

            if (cartascancha2[4].nombre == "wisp")
            {
                popo.Background = wisp;

            }
            if (cartascancha2[4].nombre == "Murloc Raider")
            {
                popo.Background = MurlocRaider;
            }
            if (cartascancha2[4].nombre == "Bloodfen Raptor" && cartascancha2[4].vida == 2)
            {
                popo.Background = BloodfenRaptor;
            }
            if (cartascancha2[4].nombre == "Bloodfen Raptor" && cartascancha2[4].vida == 1)
            {
                popo.Background = BloodfenRaptor1;
            }

            if (cartascancha2[4].nombre == "River Crocolisk" && cartascancha2[4].vida == 3)
            {
                popo.Background = RiverCrocolisk;
            }
            if (cartascancha2[4].nombre == "River Crocolisk" && cartascancha2[4].vida == 2)
            {
                popo.Background = RiverCrocolisk2;
            }
            if (cartascancha2[4].nombre == "River Crocolisk" && cartascancha2[4].vida == 1)
            {
                popo.Background = RiverCrocolisk1;
            }
            if (cartascancha2[4].nombre == "Magma Rager")
            {
                popo.Background = MagmaRager;
            }
            if (cartascancha2[4].nombre == "Chillwind Yeti" && cartascancha2[4].vida == 5)
            {
                popo.Background = ChillwindYeti;
            }
            if (cartascancha2[4].nombre == "Chillwind Yeti" && cartascancha2[4].vida == 4)
            {
                popo.Background = ChillwindYeti4;
            }
            if (cartascancha2[4].nombre == "Chillwind Yeti" && cartascancha2[4].vida == 3)
            {
                popo.Background = ChillwindYeti3;
            }
            if (cartascancha2[4].nombre == "Chillwind Yeti" && cartascancha2[4].vida == 2)
            {
                popo.Background = ChillwindYeti2;
            }
            if (cartascancha2[4].nombre == "Chillwind Yeti" && cartascancha2[4].vida == 1)
            {
                popo.Background = ChillwindYeti1;
            }
            if (cartascancha2[4].nombre == "Oasis Snapjaw" && cartascancha2[4].vida == 7)
            {
                popo.Background = OasisSnapjaw;
            }
            if (cartascancha2[4].nombre == "Oasis Snapjaw" && cartascancha2[4].vida == 6)
            {
                popo.Background = OasisSnapjaw6;
            }
            if (cartascancha2[4].nombre == "Oasis Snapjaw" && cartascancha2[4].vida == 5)
            {
                popo.Background = OasisSnapjaw5;
            }
            if (cartascancha2[4].nombre == "Oasis Snapjaw" && cartascancha2[4].vida == 4)
            {
                popo.Background = OasisSnapjaw4;
            }
            if (cartascancha2[4].nombre == "Oasis Snapjaw" && cartascancha2[4].vida == 3)
            {
                popo.Background = OasisSnapjaw3;

            }
            if (cartascancha2[4].nombre == "Oasis Snapjaw" && cartascancha2[4].vida == 2)
            {
                popo.Background = OasisSnapjaw2;
            }
            if (cartascancha2[4].nombre == "Oasis Snapjaw" && cartascancha2[4].vida == 1)
            {
                popo.Background = OasisSnapjaw1;
            }
            if (cartascancha2[4].nombre == "Boulderfist Ogre" && cartascancha2[4].vida == 7)
            {
                popo.Background = BoulderfistOgre;
            }
            if (cartascancha2[4].nombre == "Boulderfist Ogre" && cartascancha2[4].vida == 6)
            {
                popo.Background = BoulderfistOgre6;
            }
            if (cartascancha2[4].nombre == "Boulderfist Ogre" && cartascancha2[4].vida == 5)
            {
                popo.Background = BoulderfistOgre5;
            }
            if (cartascancha2[4].nombre == "Boulderfist Ogre" && cartascancha2[4].vida == 4)
            {
                popo.Background = BoulderfistOgre4;
            }
            if (cartascancha2[4].nombre == "Boulderfist Ogre" && cartascancha2[4].vida == 3)
            {
                popo.Background = BoulderfistOgre3;
            }
            if (cartascancha2[4].nombre == "Boulderfist Ogre" && cartascancha2[4].vida == 2)
            {
                popo.Background = BoulderfistOgre2;
            }
            if (cartascancha2[4].nombre == "Boulderfist Ogre" && cartascancha2[4].vida == 1)
            {
                popo.Background = BoulderfistOgre1;
            }

            if (cartascancha2[4].nombre == "War Golem" && cartascancha2[4].vida == 7)
            {
                popo.Background = WarGolem;
            }
            if (cartascancha2[4].nombre == "War Golem" && cartascancha2[4].vida == 6)
            {
                popo.Background = WarGolem6;
            }
            if (cartascancha2[4].nombre == "War Golem" && cartascancha2[4].vida == 5)
            {
                popo.Background = WarGolem5;
            }
            if (cartascancha2[4].nombre == "War Golem" && cartascancha2[4].vida == 4)
            {
                popo.Background = WarGolem4;
            }
            if (cartascancha2[4].nombre == "War Golem" && cartascancha2[4].vida == 3)
            {
                popo.Background = WarGolem3;
            }
            if (cartascancha2[4].nombre == "War Golem" && cartascancha2[4].vida == 2)
            {
                popo.Background = WarGolem2;
            }
            if (cartascancha2[4].nombre == "War Golem" && cartascancha2[4].vida == 1)
            {
                popo.Background = WarGolem1;
            }

            if (cartascancha2[4].nombre == "Core Hound" && cartascancha2[4].vida == 5)
            {
                popo.Background = CoreHound;
            }
            if (cartascancha2[4].nombre == "Core Hound" && cartascancha2[4].vida == 4)
            {
                popo.Background = CoreHound4;
            }
            if (cartascancha2[4].nombre == "Core Hound" && cartascancha2[4].vida == 3)
            {
                popo.Background = CoreHound3;
            }
            if (cartascancha2[4].nombre == "Core Hound" && cartascancha2[4].vida == 2)
            {
                popo.Background = CoreHound2;

            }
            if (cartascancha2[4].nombre == "Core Hound" && cartascancha2[4].vida == 1)
            {
                popo.Background = CoreHound1;
            }
            if (cartascancha2[4].nombre == "Recruit")
            {
                popo.Background = Recruit;
            }
            if (cartascancha2[4].nombre == "Stoneclaw Totem")
            {
                popo.Background = totem11;
            }
            if (cartascancha2[4].nombre == "Heilin Totem")
            {
                popo.Background = totem22;
            }
            if (cartascancha2[4].nombre == "Warth of air Totem")
            {
                popo.Background = totem33;
            }
            if (cartascancha2[4].nombre == "Seiring Totem")
            {
                popo.Background = totem44;
            }
            if (cartascancha2[4].nombre == "Stoneclaw Totem" && cartascancha2[4].vida == 1)
            {
                popo.Background = totem111;
            }
            if (cartascancha2[4].nombre == "Heilin Totem" && cartascancha2[4].vida == 1)
            {
                popo.Background = totem221;
            }
            if (cartascancha2[4].nombre == "Warth of air Totem" && cartascancha2[4].vida == 1)
            {
                popo.Background = totem331;
            }

            popo.Visibility = Visibility.Visible;
        }

        private void boton15_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Background = vacio;
        }

        private void boton16_MouseEnter(object sender, MouseEventArgs e)
        {

            if (cartascancha2[5].nombre == "wisp")
            {
                popo.Background = wisp;

            }
            if (cartascancha2[5].nombre == "Murloc Raider")
            {
                popo.Background = MurlocRaider;
            }
            if (cartascancha2[5].nombre == "Bloodfen Raptor" && cartascancha2[5].vida == 2)
            {
                popo.Background = BloodfenRaptor;
            }
            if (cartascancha2[5].nombre == "Bloodfen Raptor" && cartascancha2[5].vida == 1)
            {
                popo.Background = BloodfenRaptor1;
            }

            if (cartascancha2[5].nombre == "River Crocolisk" && cartascancha2[5].vida == 3)
            {
                popo.Background = RiverCrocolisk;
            }
            if (cartascancha2[5].nombre == "River Crocolisk" && cartascancha2[5].vida == 2)
            {
                popo.Background = RiverCrocolisk2;
            }
            if (cartascancha2[5].nombre == "River Crocolisk" && cartascancha2[5].vida == 1)
            {
                popo.Background = RiverCrocolisk1;
            }
            if (cartascancha2[5].nombre == "Magma Rager")
            {
                popo.Background = MagmaRager;
            }
            if (cartascancha2[5].nombre == "Chillwind Yeti" && cartascancha2[5].vida == 5)
            {
                popo.Background = ChillwindYeti;
            }
            if (cartascancha2[5].nombre == "Chillwind Yeti" && cartascancha2[5].vida == 4)
            {
                popo.Background = ChillwindYeti4;
            }
            if (cartascancha2[5].nombre == "Chillwind Yeti" && cartascancha2[5].vida == 3)
            {
                popo.Background = ChillwindYeti3;
            }
            if (cartascancha2[5].nombre == "Chillwind Yeti" && cartascancha2[5].vida == 2)
            {
                popo.Background = ChillwindYeti2;
            }
            if (cartascancha2[5].nombre == "Chillwind Yeti" && cartascancha2[5].vida == 1)
            {
                popo.Background = ChillwindYeti1;
            }
            if (cartascancha2[5].nombre == "Oasis Snapjaw" && cartascancha2[5].vida == 7)
            {
                popo.Background = OasisSnapjaw;
            }
            if (cartascancha2[5].nombre == "Oasis Snapjaw" && cartascancha2[5].vida == 6)
            {
                popo.Background = OasisSnapjaw6;
            }
            if (cartascancha2[5].nombre == "Oasis Snapjaw" && cartascancha2[5].vida == 5)
            {
                popo.Background = OasisSnapjaw5;
            }
            if (cartascancha2[5].nombre == "Oasis Snapjaw" && cartascancha2[5].vida == 4)
            {
                popo.Background = OasisSnapjaw4;
            }
            if (cartascancha2[5].nombre == "Oasis Snapjaw" && cartascancha2[5].vida == 3)
            {
                popo.Background = OasisSnapjaw3;


                if (cartascancha2[5].nombre == "Oasis Snapjaw" && cartascancha2[5].vida == 2)
                {
                    popo.Background = OasisSnapjaw2;
                }
                if (cartascancha2[5].nombre == "Oasis Snapjaw" && cartascancha2[5].vida == 1)
                {
                    popo.Background = OasisSnapjaw1;
                }
                if (cartascancha2[5].nombre == "Boulderfist Ogre" && cartascancha2[5].vida == 7)
                {
                    popo.Background = BoulderfistOgre;
                }
                if (cartascancha2[5].nombre == "Boulderfist Ogre" && cartascancha2[5].vida == 6)
                {
                    popo.Background = BoulderfistOgre6;
                }
                if (cartascancha2[5].nombre == "Boulderfist Ogre" && cartascancha2[5].vida == 5)
                {
                    popo.Background = BoulderfistOgre5;
                }
                if (cartascancha2[5].nombre == "Boulderfist Ogre" && cartascancha2[5].vida == 4)
                {
                    popo.Background = BoulderfistOgre4;
                }
                if (cartascancha2[5].nombre == "Boulderfist Ogre" && cartascancha2[5].vida == 3)
                {
                    popo.Background = BoulderfistOgre3;
                }
                if (cartascancha2[5].nombre == "Boulderfist Ogre" && cartascancha2[5].vida == 2)
                {
                    popo.Background = BoulderfistOgre2;
                }
                if (cartascancha2[5].nombre == "Boulderfist Ogre" && cartascancha2[5].vida == 1)
                {
                    popo.Background = BoulderfistOgre1;
                }

                if (cartascancha2[5].nombre == "War Golem" && cartascancha2[5].vida == 7)
                {
                    popo.Background = WarGolem;
                }
                if (cartascancha2[5].nombre == "War Golem" && cartascancha2[5].vida == 6)
                {
                    popo.Background = WarGolem6;
                }
                if (cartascancha2[5].nombre == "War Golem" && cartascancha2[5].vida == 5)
                {
                    popo.Background = WarGolem5;
                }
                if (cartascancha2[5].nombre == "War Golem" && cartascancha2[5].vida == 4)
                {
                    popo.Background = WarGolem4;
                }
                if (cartascancha2[5].nombre == "War Golem" && cartascancha2[5].vida == 3)
                {
                    popo.Background = WarGolem3;
                }
                if (cartascancha2[5].nombre == "War Golem" && cartascancha2[5].vida == 2)
                {
                    popo.Background = WarGolem2;
                }
                if (cartascancha2[5].nombre == "War Golem" && cartascancha2[5].vida == 1)
                {
                    popo.Background = WarGolem1;
                }

                if (cartascancha2[5].nombre == "Core Hound" && cartascancha2[5].vida == 5)
                {
                    popo.Background = CoreHound;
                }
                if (cartascancha2[5].nombre == "Core Hound" && cartascancha2[5].vida == 4)
                {
                    popo.Background = CoreHound4;
                }
                if (cartascancha2[5].nombre == "Core Hound" && cartascancha2[5].vida == 3)
                {
                    popo.Background = CoreHound3;
                }
                if (cartascancha2[5].nombre == "Core Hound" && cartascancha2[5].vida == 2)
                {
                    popo.Background = CoreHound2;

                }
                if (cartascancha2[5].nombre == "Core Hound" && cartascancha2[5].vida == 1)
                {
                    popo.Background = CoreHound1;
                }
                if (cartascancha2[5].nombre == "Recruit")
                {
                    popo.Background = Recruit;
                }
                if (cartascancha2[5].nombre == "Stoneclaw Totem")
                {
                    popo.Background = totem11;
                }
                if (cartascancha2[5].nombre == "Heilin Totem")
                {
                    popo.Background = totem22;
                }
                if (cartascancha2[5].nombre == "Warth of air Totem")
                {
                    popo.Background = totem33;
                }
                if (cartascancha2[5].nombre == "Seiring Totem")
                {
                    popo.Background = totem44;
                }
                if (cartascancha2[5].nombre == "Stoneclaw Totem" && cartascancha2[5].vida == 1)
                {
                    popo.Background = totem111;
                }
                if (cartascancha2[5].nombre == "Heilin Totem" && cartascancha2[5].vida == 1)
                {
                    popo.Background = totem221;
                }
                if (cartascancha2[5].nombre == "Warth of air Totem" && cartascancha2[5].vida == 1)
                {
                    popo.Background = totem331;
                }

                popo.Visibility = Visibility.Visible;
            }

        }

        private void boton16_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Background = vacio;
        }

        private void boton17_MouseEnter(object sender, MouseEventArgs e)
        {


            if (cartascancha2[6].nombre == "Murloc Raider")
            {
                popo.Background = MurlocRaider;
            }
            if (cartascancha2[6].nombre == "wisp")
            {
                popo.Background = wisp;

            }
            if (cartascancha2[6].nombre == "Bloodfen Raptor" && cartascancha2[6].vida == 2)
            {
                popo.Background = BloodfenRaptor;
            }
            if (cartascancha2[6].nombre == "Bloodfen Raptor" && cartascancha2[6].vida == 1)
            {
                popo.Background = BloodfenRaptor1;
            }

            if (cartascancha2[6].nombre == "River Crocolisk" && cartascancha2[6].vida == 3)
            {
                popo.Background = RiverCrocolisk;
            }
            if (cartascancha2[6].nombre == "River Crocolisk" && cartascancha2[6].vida == 2)
            {
                popo.Background = RiverCrocolisk2;
            }
            if (cartascancha2[6].nombre == "River Crocolisk" && cartascancha2[6].vida == 1)
            {
                popo.Background = RiverCrocolisk1;
            }
            if (cartascancha2[6].nombre == "Magma Rager")
            {
                popo.Background = MagmaRager;
            }
            if (cartascancha2[6].nombre == "Chillwind Yeti" && cartascancha2[6].vida == 5)
            {
                popo.Background = ChillwindYeti;
            }
            if (cartascancha2[6].nombre == "Chillwind Yeti" && cartascancha2[6].vida == 4)
            {
                popo.Background = ChillwindYeti4;
            }
            if (cartascancha2[6].nombre == "Chillwind Yeti" && cartascancha2[6].vida == 3)
            {
                popo.Background = ChillwindYeti3;
            }
            if (cartascancha2[6].nombre == "Chillwind Yeti" && cartascancha2[6].vida == 2)
            {
                popo.Background = ChillwindYeti2;
            }
            if (cartascancha2[6].nombre == "Chillwind Yeti" && cartascancha2[6].vida == 1)
            {
                popo.Background = ChillwindYeti1;
            }
            if (cartascancha2[6].nombre == "Oasis Snapjaw" && cartascancha2[6].vida == 7)
            {
                popo.Background = OasisSnapjaw;
            }
            if (cartascancha2[6].nombre == "Oasis Snapjaw" && cartascancha2[6].vida == 6)
            {
                popo.Background = OasisSnapjaw6;
            }
            if (cartascancha2[6].nombre == "Oasis Snapjaw" && cartascancha2[6].vida == 5)
            {
                popo.Background = OasisSnapjaw5;
            }
            if (cartascancha2[6].nombre == "Oasis Snapjaw" && cartascancha2[6].vida == 4)
            {
                popo.Background = OasisSnapjaw4;
            }
            if (cartascancha2[6].nombre == "Oasis Snapjaw" && cartascancha2[6].vida == 3)
            {
                popo.Background = OasisSnapjaw3;

            }
            if (cartascancha2[6].nombre == "Oasis Snapjaw" && cartascancha2[6].vida == 2)
            {
                popo.Background = OasisSnapjaw2;
            }
            if (cartascancha2[6].nombre == "Oasis Snapjaw" && cartascancha2[6].vida == 1)
            {
                popo.Background = OasisSnapjaw1;
            }
            if (cartascancha2[6].nombre == "Boulderfist Ogre" && cartascancha2[6].vida == 7)
            {
                popo.Background = BoulderfistOgre;
            }
            if (cartascancha2[6].nombre == "Boulderfist Ogre" && cartascancha2[6].vida == 6)
            {
                popo.Background = BoulderfistOgre6;
            }
            if (cartascancha2[6].nombre == "Boulderfist Ogre" && cartascancha2[6].vida == 5)
            {
                popo.Background = BoulderfistOgre5;
            }
            if (cartascancha2[6].nombre == "Boulderfist Ogre" && cartascancha2[6].vida == 4)
            {
                popo.Background = BoulderfistOgre4;
            }
            if (cartascancha2[6].nombre == "Boulderfist Ogre" && cartascancha2[6].vida == 3)
            {
                popo.Background = BoulderfistOgre3;
            }
            if (cartascancha2[6].nombre == "Boulderfist Ogre" && cartascancha2[6].vida == 2)
            {
                popo.Background = BoulderfistOgre2;
            }
            if (cartascancha2[6].nombre == "Boulderfist Ogre" && cartascancha2[6].vida == 1)
            {
                popo.Background = BoulderfistOgre1;
            }

            if (cartascancha2[6].nombre == "War Golem" && cartascancha2[6].vida == 7)
            {
                popo.Background = WarGolem;
            }
            if (cartascancha2[6].nombre == "War Golem" && cartascancha2[6].vida == 6)
            {
                popo.Background = WarGolem6;
            }
            if (cartascancha2[6].nombre == "War Golem" && cartascancha2[6].vida == 5)
            {
                popo.Background = WarGolem5;
            }
            if (cartascancha2[6].nombre == "War Golem" && cartascancha2[6].vida == 4)
            {
                popo.Background = WarGolem4;
            }
            if (cartascancha2[6].nombre == "War Golem" && cartascancha2[6].vida == 3)
            {
                popo.Background = WarGolem3;
            }
            if (cartascancha2[6].nombre == "War Golem" && cartascancha2[6].vida == 2)
            {
                popo.Background = WarGolem2;
            }
            if (cartascancha2[6].nombre == "War Golem" && cartascancha2[6].vida == 1)
            {
                popo.Background = WarGolem1;
            }

            if (cartascancha2[6].nombre == "Core Hound" && cartascancha2[6].vida == 5)
            {
                popo.Background = CoreHound;
            }
            if (cartascancha2[6].nombre == "Core Hound" && cartascancha2[6].vida == 4)
            {
                popo.Background = CoreHound4;
            }
            if (cartascancha2[6].nombre == "Core Hound" && cartascancha2[6].vida == 3)
            {
                popo.Background = CoreHound3;
            }
            if (cartascancha2[6].nombre == "Core Hound" && cartascancha2[6].vida == 2)
            {
                popo.Background = CoreHound2;

            }
            if (cartascancha2[6].nombre == "Core Hound" && cartascancha2[6].vida == 1)
            {
                popo.Background = CoreHound1;
            }
            if (cartascancha2[6].nombre == "Recruit")
            {
                popo.Background = Recruit;
            }
            if (cartascancha2[6].nombre == "Stoneclaw Totem")
            {
                popo.Background = totem11;
            }
            if (cartascancha2[6].nombre == "Heilin Totem")
            {
                popo.Background = totem22;
            }
            if (cartascancha2[6].nombre == "Warth of air Totem")
            {
                popo.Background = totem33;
            }
            if (cartascancha2[6].nombre == "Seiring Totem")
            {
                popo.Background = totem44;
            }
            if (cartascancha2[6].nombre == "Stoneclaw Totem" && cartascancha2[6].vida == 1)
            {
                popo.Background = totem111;
            }
            if (cartascancha2[6].nombre == "Heilin Totem" && cartascancha2[6].vida == 1)
            {
                popo.Background = totem221;
            }
            if (cartascancha2[6].nombre == "Warth of air Totem" && cartascancha2[6].vida == 1)
            {
                popo.Background = totem331;
            }

            popo.Visibility = Visibility.Visible;
        }

        private void boton17_MouseLeave(object sender, MouseEventArgs e)
        {

            popo.Background = vacio;


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
                MessageBox.Show(j1.nombre + " dice:\nRayos y centellas");
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

            if (j1.activo == true)
            {
                if (j1.tipo == "Paladin")
                {

                    if (cartascancha.Count() < 7)
                    {
                        minion paladin1 = new minion("Recruit", 1, 1, true, true, 0);
                        paladin1.turno = false;
                        mazos.Add(paladin1);


                        j1.invocar(paladin1, cartascancha);

                    }
                }
                if (j1.tipo == "Rogue" && j1.mana >= 2)
                {
                    contadorweapon1 = 0;

                    minion rogue = new minion("Dagger Mastery", 1, 2394, true, true, 0);
                    rogue.turno = true;
                    mazos.Add(rogue);
                    j1.invocar(rogue, weapon1);
                    weapon1_.Visibility = Visibility.Visible;
                    weapon1_.Content = " ";
                    weapon1_.Background = daga;

                }
                if (j1.tipo == "Druid" && j1.mana >= 2)
                {
                    j1.escudo = j1.escudo + 1;
                    minion druid = new minion("Shapeshift", 1, 485857, true, true, 0);
                    druid.turno = true;
                    mazos.Add(druid);
                    j1.invocar(druid, weapon1);
                    weapon1_.Visibility = Visibility.Visible;
                    weapon1_.Content = " ";
                    weapon1_.Background = oso;
                    fotoescudo.Background=escudo;
                    fotoescudo.Content = j1.escudo;
                }
                if (j1.tipo == "Mage")
                {
                    hatacado = j1;


                }
                if (j1.tipo == "Warrior" && j1.mana >= 2)
                {


                    j1.escudo = j1.escudo + 2;



                    fotoescudo.Background = escudo;
                    fotoescudo.Content = j1.escudo;


                }
                if (j1.tipo == "Warlock")
                {
                    j1.darcarta();
                    for (int i = 0; i < manos.Count; i++)
                    {
                        if (manos[i].nombre == "wisp")
                        {
                            manobot[i].Background = wispmano;

                        }
                        if (manos[i].nombre == "Murloc Raider")
                        {
                            manobot[i].Background = MurlocRaidermano;
                        }
                        if (manos[i].nombre == "Bloodfen Raptor")
                        {
                            manobot[i].Background = BloodfenRaptormano;
                        }
                        if (manos[i].nombre == "River Crocolisk")
                        {
                            manobot[i].Background = RiverCrocoliskmano;
                        }
                        if (manos[i].nombre == "Magma Rager")
                        {
                            manobot[i].Background = MagmaRagermano;
                        }
                        if (manos[i].nombre == "Chillwind Yeti")
                        {
                            manobot[i].Background = ChillwindYetimano;
                        }
                        if (manos[i].nombre == "Oasis Snapjaw")
                        {
                            manobot[i].Background = OasisSnapjawmano;
                        }
                        if (manos[i].nombre == "Boulderfist Ogre")
                        {
                            manobot[i].Background = BoulderfistOgremano;
                        }
                        if (manos[i].nombre == "War Golem")
                        {
                            manobot[i].Background = WarGolemmano;
                        }
                        if (manos[i].nombre == "Core Hound")
                        {
                            manobot[i].Background = CoreHoundmano;
                        }
                        manobot[i].Visibility = Visibility.Visible;
                    }
                    manobot[manos.Count()].Visibility = Visibility.Hidden;


                    refreshhmano(manos, manos2, manobot, manobot1, wispmano, MurlocRaidermano, BloodfenRaptormano, RiverCrocoliskmano, MagmaRagermano, ChillwindYetimano, OasisSnapjawmano, BoulderfistOgremano, WarGolemmano, CoreHoundmano, Recruit, j1, j2);
                }
                Random rnd = new Random();
                if (j1.tipo == "Shaman")
                {
                    if (cartascancha.Count() < 7)
                    {
                        int ppp = rnd.Next(4);
                        if (ppp == 0)
                        {
                            minion shaman1 = new minion("Heilin Totem", 0, 2, true, true, 0);
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

                            minion shaman3 = new minion("Stoneclaw Totem", 0, 2, true, true, 0);
                            mazos.Add(shaman3);
                            j1.invocar(shaman3, cartascancha);
                        }
                        if (ppp == 3)
                        {
                            minion shaman4 = new minion("Warth of air Totem", 0, 2, true, true, 0);
                            mazos.Add(shaman4);
                            j1.invocar(shaman4, cartascancha);
                        }



                    }

                }
                j1.habilidad(j2);
                vida1.Content = j1.vida;
                Vida2.Content = j2.vida;
                manadisp.Content = j1.mana;
                habilidad.IsEnabled = false;
                refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, totem11, totem22, totem33, totem44, j1, j2, RiverCrocolisk1, BloodfenRaptor1, RiverCrocolisk2, ChillwindYeti1, ChillwindYeti2, ChillwindYeti3, ChillwindYeti4, OasisSnapjaw1, OasisSnapjaw2, OasisSnapjaw3, OasisSnapjaw4, OasisSnapjaw5, OasisSnapjaw6, BoulderfistOgre1, BoulderfistOgre2, BoulderfistOgre3, BoulderfistOgre4, BoulderfistOgre5, BoulderfistOgre6, WarGolem1, WarGolem2, WarGolem3, WarGolem4, WarGolem5, WarGolem6, CoreHound1, CoreHound2, CoreHound3, CoreHound4, totem111, totem221, totem331);
                refreshmana(lala, manamana, j1, vacio);



            }

        }
        int contadorweapon1 = 0;
        int contadorweapon2 = 0;
        /*Habilidad*/
        private void habilidad2_Click(object sender, RoutedEventArgs e)
        {

            if (j2.activo == true)
            {
                if (j2.tipo == "Warrior" && j2.mana >= 2)
                {


                    j2.escudo = j2.escudo + 2;

                    fotoescudo2.Content = j2.escudo;




                }
                if (j2.tipo == "Paladin")
                {
                    if (cartascancha2.Count() < 7)
                    {
                        minion paladin1 = new minion("Recruit", 1, 1, true, true, 0);
                        paladin1.turno = false;
                        mazos2.Add(paladin1);


                        j2.invocar(paladin1, cartascancha2);

                    }
                }

                if (j2.tipo == "Rogue" && j2.mana >= 2)
                {
                    contadorweapon2 = 0;

                    minion rogue1 = new minion("Dagger Mastery", 1, 2394, true, true, 0);
                    rogue1.turno = true;
                    mazos2.Add(rogue1);
                    j2.invocar(rogue1, weapon2);
                    weapon2_.Visibility = Visibility.Visible;
                    weapon2_.Content = " ";
                    weapon2_.Background = daga;

                }
                if (j2.tipo == "Druid" && j2.mana >= 2)
                {
                    j2.escudo = j2.escudo + 1;
                    minion druid = new minion("Shapeshift", 1, 485857, true, true, 0);
                    druid.turno = true;
                    mazos2.Add(druid);
                    j2.invocar(druid, weapon2);
                    weapon2_.Visibility = Visibility.Visible;
                    weapon2_.Content = " ";
                    weapon2_.Background = oso;
                    fotoescudo2.Visibility = Visibility.Visible;
                    fotoescudo2.Background = escudo;
                    fotoescudo2.Content = j2.escudo;
                }
                if (j2.tipo == "Mage")
                {
                    hatacado = j2;


                }
                if (j2.tipo == "Warlock")
                {
                    j2.darcarta();

                    for (int i = 0; i < manos2.Count; i++)
                    {
                        if (manos2[i].nombre == "wisp")
                        {
                            manobot1[i].Background = wispmano;

                        }
                        if (manos2[i].nombre == "Murloc Raider")
                        {
                            manobot1[i].Background = MurlocRaidermano;
                        }
                        if (manos2[i].nombre == "Bloodfen Raptor")
                        {
                            manobot1[i].Background = BloodfenRaptormano;
                        }
                        if (manos2[i].nombre == "River Crocolisk")
                        {
                            manobot1[i].Background = RiverCrocoliskmano;
                        }
                        if (manos2[i].nombre == "Magma Rager")
                        {
                            manobot1[i].Background = MagmaRagermano;
                        }
                        if (manos2[i].nombre == "Chillwind Yeti")
                        {
                            manobot1[i].Background = ChillwindYetimano;
                        }
                        if (manos2[i].nombre == "Oasis Snapjaw")
                        {
                            manobot1[i].Background = OasisSnapjawmano;
                        }
                        if (manos2[i].nombre == "Boulderfist Ogre")
                        {
                            manobot1[i].Background = BoulderfistOgremano;
                        }
                        if (manos2[i].nombre == "War Golem")
                        {
                            manobot1[i].Background = WarGolemmano;
                        }
                        if (manos2[i].nombre == "Core Hound")
                        {
                            manobot1[i].Background = CoreHoundmano;
                        }
                        manobot1[i].Visibility = Visibility.Visible;
                    }
                    manobot1[manos2.Count()].Visibility = Visibility.Hidden;


                    refreshhmano(manos, manos2, manobot, manobot1, wispmano, MurlocRaidermano, BloodfenRaptormano, RiverCrocoliskmano, MagmaRagermano, ChillwindYetimano, OasisSnapjawmano, BoulderfistOgremano, WarGolemmano, CoreHoundmano, Recruit, j1, j2);
                }
                Random rnd = new Random();
                if (j2.tipo == "Shaman")
                {
                    if (cartascancha2.Count() < 7)
                    {
                        int ppp = rnd.Next(4);
                        if (ppp == 0)
                        {
                            minion shaman1 = new minion("Heilin Totem", 0, 2, true, true, 0);
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
                            minion shaman3 = new minion("Stoneclaw Totem", 0, 2, true, true, 0);
                            shaman3.turno = false;
                            mazos2.Add(shaman3);
                            j2.invocar(shaman3, cartascancha2);
                        }
                        if (ppp == 3)
                        {
                            minion shaman4 = new minion("Warth of air Totem", 0, 2, true, true, 0);
                            shaman4.turno = false;
                            mazos2.Add(shaman4);
                            j2.invocar(shaman4, cartascancha2);
                        }
                    }

                }
                j2.habilidad(j1);
                vida1.Content = j1.vida;
                Vida2.Content = j2.vida;
                manadisponible2.Content = j2.mana;
                habilidad2.IsEnabled = false;
                refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, totem11, totem22, totem33, totem44, j1, j2, RiverCrocolisk1, BloodfenRaptor1, RiverCrocolisk2, ChillwindYeti1, ChillwindYeti2, ChillwindYeti3, ChillwindYeti4, OasisSnapjaw1, OasisSnapjaw2, OasisSnapjaw3, OasisSnapjaw4, OasisSnapjaw5, OasisSnapjaw6, BoulderfistOgre1, BoulderfistOgre2, BoulderfistOgre3, BoulderfistOgre4, BoulderfistOgre5, BoulderfistOgre6, WarGolem1, WarGolem2, WarGolem3, WarGolem4, WarGolem5, WarGolem6, CoreHound1, CoreHound2, CoreHound3, CoreHound4, totem111, totem221, totem331);




            }
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
            if (atacar != null && atacado != null || hatacado != null && atacar != null)
            {

                atacar2.IsEnabled = true;


            }
        }

        private void boton7_Click(object sender, RoutedEventArgs e)
        {
            atacar = cartascancha[3];
            if (atacar != null && atacado != null || hatacado != null && atacar != null)
            {

                atacar2.IsEnabled = true;


            }
        }

        private void boton9_Click(object sender, RoutedEventArgs e)
        {
            atacar = cartascancha[5];
            if (atacar != null && atacado != null || hatacado != null && atacar != null)
            {

                atacar2.IsEnabled = true;


            }
        }

        private void boton12_Click(object sender, RoutedEventArgs e)
        {
            atacado = cartascancha2[1];
            if (atacar != null && atacado != null || hatacado != null && atacado != null)
            {

                atacar2.IsEnabled = true;


            }
        }

        private void boton13_Click(object sender, RoutedEventArgs e)
        {
            atacado = cartascancha2[2];
            if (atacar != null && atacado != null || hatacado != null && atacado != null)
            {

                atacar2.IsEnabled = true;


            }
        }

        private void boton14_Click(object sender, RoutedEventArgs e)
        {
            atacado = cartascancha2[3];
            if (atacar != null && atacado != null || hatacado != null && atacado != null)
            {

                atacar2.IsEnabled = true;


            }
        }

        private void boton15_Click(object sender, RoutedEventArgs e)
        {
            atacado = cartascancha2[4];
            if (atacar != null && atacado != null || hatacado != null && atacado != null)
            {

                atacar2.IsEnabled = true;


            }
        }

        private void boton16_Click(object sender, RoutedEventArgs e)
        {
            atacado = cartascancha2[5];
            if (atacar != null && atacado != null || hatacado != null && atacado != null)
            {

                atacar2.IsEnabled = true;


            }
        }

        /*Atacar*/
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (heroeatacado != null && atacado != null && j2.activo == true)
            {
                atacado.attack(null, heroeatacado, cartascancha2, cartascancha);

                heroeatacado = null;
                
            }

            if (heroeatacado != null && atacar != null && j1.activo == true)
            {
                atacar.attack(null, heroeatacado, cartascancha, cartascancha2);

                heroeatacado = null;


            }

            if (atacado != null && atacar != null && j1.activo == true)
            {
                atacar.attack(atacado, null, cartascancha, cartascancha2);
                if (j1.tipo == "Druid" || j1.tipo == "Rogue")
                {
                    if (weapon1.Count() != 0)
                    {
                        if (atacar == weapon1[0])
                        {
                            if (j1.tipo == "Rogue")
                            {
                                j1.vida = j1.vida - atacado.ataque;
                            }
                            //atacado.attack(null, j1, cartascancha, cartascancha2);
                            if (j1.tipo == "Druid")
                            {
                                if (j1.escudo == 0)
                                {
                                    j1.vida = j1.vida - atacado.ataque;
                                    if (j1.vida <= 0)
                                    {
                                        j1.Rendirse(j1.vida);
                                    }
                                }
                                if (j1.escudo > 0)
                                {
                                    j1.escudo = j1.escudo - atacado.ataque;
                                    if (j1.escudo < 0)
                                    {
                                        j1.vida = j1.vida + j1.escudo;
                                        j1.escudo = 0;
                                        if (j1.vida <= 0)
                                        {
                                            j1.Rendirse(j1.vida);
                                        }
                                    }

                                }

                            }
                        }
                    }
                }
                    
                
                atacado = null;
                atacar = null;

            }
            if (atacado != null && atacar != null && j2.activo == true)
            {


                atacado.attack(atacar, null, cartascancha2, cartascancha);
                if (j2.tipo == "Druid" || j2.tipo == "Rogue")
                {
                    if (weapon2.Count() != 0)
                    {
                        if (atacado == weapon2[0])
                        {
                            if (j2.tipo == "Rogue")
                            {
                                j2.vida = j2.vida - atacar.ataque;
                            }
                            //atacado.attack(null, j1, cartascancha, cartascancha2);
                            if (j2.tipo == "Druid")
                            {
                                if (j2.escudo == 0)
                                {
                                    j2.vida = j2.vida - atacar.ataque;
                                    if (j2.vida <= 0)
                                    {
                                        j2.Rendirse(j2.vida);
                                    }
                                }
                                if (j2.escudo > 0)
                                {
                                    j2.escudo = j2.escudo - atacar.ataque;
                                    if (j2.escudo < 0)
                                    {
                                        j2.vida = j2.vida + j2.escudo;
                                        j2.escudo = 0;
                                        if (j2.vida <= 0)
                                        {
                                            j2.Rendirse(j2.vida);
                                        }
                                    }

                                }

                            }
                        }
                    }
                }

                atacado = null;
                atacar = null;


            }
            if (hatacado != null && atacado != null && j1.activo == true)// mage 
            {
                hatacado.attack(atacado, null, null, cartascancha2);

                hatacado = null;
                atacado = null;

            }
            if (hatacado != null && heroeatacado != null && j1.activo == true)// mage 
            {
                
                hatacado.attack(null, heroeatacado, null, cartascancha2);

                hatacado = null;
                heroeatacado= null;

            }
            if (hatacado != null && atacar != null && j2.activo == true)// mage 
            {
                hatacado.attack(atacar, null, null, cartascancha);

                hatacado = null;
                atacar = null;

            }
            if (hatacado != null && heroeatacado != null && j2.activo == true)// mage 
            {
                
                hatacado.attack(null, heroeatacado, null, cartascancha);

                hatacado = null;
                heroeatacado = null;

            }
            if (j1.tipo == "Warrior")
            {
                fotoescudo.Background = escudo;
                fotoescudo.Content = j1.escudo;

            }
            if (j1.tipo == "Druid")
            {
                fotoescudo.Background = escudo;
                fotoescudo.Content = j1.escudo;

            }
            if (j2.tipo == "Warrior")
            {
                fotoescudo.Background = escudo;
                fotoescudo.Content = j2.escudo;

            }
            if (j2.tipo == "Druid")
            {
                fotoescudo.Background = escudo;
                fotoescudo.Content = j2.escudo;

            }

            vida1.Content = j1.vida;
            Vida2.Content = j2.vida;

            refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, totem11, totem22, totem33, totem44, j1, j2, RiverCrocolisk1, BloodfenRaptor1, RiverCrocolisk2, ChillwindYeti1, ChillwindYeti2, ChillwindYeti3, ChillwindYeti4, OasisSnapjaw1, OasisSnapjaw2, OasisSnapjaw3, OasisSnapjaw4, OasisSnapjaw5, OasisSnapjaw6, BoulderfistOgre1, BoulderfistOgre2, BoulderfistOgre3, BoulderfistOgre4, BoulderfistOgre5, BoulderfistOgre6, WarGolem1, WarGolem2, WarGolem3, WarGolem4, WarGolem5, WarGolem6, CoreHound1, CoreHound2, CoreHound3, CoreHound4, totem111, totem221, totem331);


            /*ver wl mayor o igual 
            if (contadorweapon1 <2 )
            {
                contadorweapon1 = contadorweapon1 + 1;
                weapon1_.IsEnabled = false;

               
            }
            else
            {
                *weapon1.RemoveAt(0);
                weapon1_.Visibility = Visibility.Hidden;
                contadorweapon1 = 0;


            }*/


            xx[cartascancha.Count()].Visibility = Visibility.Hidden;

            a2[cartascancha2.Count()].Visibility = Visibility.Hidden;
            if (j1.tipo == "Rogue")
            {
                if (contadorweapon1 == 2)
                {
                    weapon1_.Background = vacio;
                    contadorweapon1 = 0;
                }
               
            }
            if (j2.tipo == "Rogue")
            {
                if (contadorweapon2 == 2)
                {
                    weapon2_.Background = vacio;
                    contadorweapon2 = 0;
                }

            }
            if (j2.tipo == "Druid")
            {
                if (contadorweapon2 == 1)
                {
                    weapon2_.Background = vacio;
                    contadorweapon2 = 0;
                }

            }
            if (j1.tipo == "Druid" )
            {
                if (contadorweapon1 == 1)
                {
                    weapon1_.Background = vacio;
                    contadorweapon1 = 0;
                }
              
            }
            fotoescudo.Content = j1.escudo;
            fotoescudo2.Content = j2.escudo;

        }
        Heroe heroeatacado;
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            heroeatacado = j2;
            if ((atacar != null && heroeatacado != null) || (atacado != null && heroeatacado != null) || (hatacado != null && heroeatacado != null))
            {

                atacar2.IsEnabled = true;


            }


        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            heroeatacado = j1;
            if ((atacar != null && heroeatacado != null) || (atacado != null && heroeatacado != null) || (hatacado != null && heroeatacado != null))
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
                popo.Background = mageex;
            }
            if (j1.tipo == "Warrior")
            {
                popo.Background = warriorex;
            }
            if (j1.tipo == "Paladin")
            {
                popo.Background = paladinex;
            }
            if (j1.tipo == "Hunter")
            {
                popo.Background = hunterex;
            }

            if (j1.tipo == "Druid")
            {
                popo.Background = druidex;
            }
            if (j1.tipo == "Rogue")
            {
                popo.Background = rogueex;
            }
            if (j1.tipo == "Shaman")
            {
                popo.Background = shamanex;
            }
            if (j1.tipo == "Warlock ")
            {
                popo.Background = warlockex;
            }
            if (j1.tipo == "Priest")
            {
                popo.Background = priestex;
            }
        }

        private void habilidad_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Background = vacio;
        }

        private void habilidad2_MouseEnter(object sender, MouseEventArgs e)
        {
            if (j2.tipo == "Mage")
            {
                popo.Background = mageex;
            }
            if (j2.tipo == "Warrior")
            {
                popo.Background = warriorex;
            }
            if (j2.tipo == "Paladin")
            {
                popo.Background = paladinex;
            }
            if (j2.tipo == "Hunter")
            {
                popo.Background = hunterex;
            }

            if (j2.tipo == "Druid")
            {
                popo.Background = druidex;
            }
            if (j2.tipo == "Rogue")
            {
                popo.Background = rogueex;
            }
            if (j2.tipo == "Shaman")
            {
                popo.Background = shamanex;
            }
            if (j2.tipo == "Warlock ")
            {
                popo.Background = warlockex;
            }
            if (j2.tipo == "Priest")
            {
                popo.Background = priestex;
            }
        }

        private void habilidad2_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Background = vacio;
        }

        private void boton18_Click(object sender, RoutedEventArgs e)
        {
            if (cartascancha.Count < 7)
            {
                if (j1.activo == true)
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
                            manobot[i].Background = wispmano;

                        }
                        if (manos[i].nombre == "Murloc Raider")
                        {
                            manobot[i].Background = MurlocRaidermano;
                        }
                        if (manos[i].nombre == "Bloodfen Raptor")
                        {
                            manobot[i].Background = BloodfenRaptormano;
                        }
                        if (manos[i].nombre == "River Crocolisk")
                        {
                            manobot[i].Background = RiverCrocoliskmano;
                        }
                        if (manos[i].nombre == "Magma Rager")
                        {
                            manobot[i].Background = MagmaRagermano;
                        }
                        if (manos[i].nombre == "Chillwind Yeti")
                        {
                            manobot[i].Background = ChillwindYetimano;
                        }
                        if (manos[i].nombre == "Oasis Snapjaw")
                        {
                            manobot[i].Background = OasisSnapjawmano;
                        }
                        if (manos[i].nombre == "Boulderfist Ogre")
                        {
                            manobot[i].Background = BoulderfistOgremano;
                        }
                        if (manos[i].nombre == "War Golem")
                        {
                            manobot[i].Background = WarGolemmano;
                        }
                        if (manos[i].nombre == "Core Hound")
                        {
                            manobot[i].Background = CoreHoundmano;
                        }
                        manobot[i].Visibility = Visibility.Visible;
                    }
                    manobot[manos.Count()].Visibility = Visibility.Hidden;


                    refreshhmano(manos, manos2, manobot, manobot1, wispmano, MurlocRaidermano, BloodfenRaptormano, RiverCrocoliskmano, MagmaRagermano, ChillwindYetimano, OasisSnapjawmano, BoulderfistOgremano, WarGolemmano, CoreHoundmano, Recruit, j1, j2);
                    refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, totem11, totem22, totem33, totem44, j1, j2, RiverCrocolisk1, BloodfenRaptor1, RiverCrocolisk2, ChillwindYeti1, ChillwindYeti2, ChillwindYeti3, ChillwindYeti4, OasisSnapjaw1, OasisSnapjaw2, OasisSnapjaw3, OasisSnapjaw4, OasisSnapjaw5, OasisSnapjaw6, BoulderfistOgre1, BoulderfistOgre2, BoulderfistOgre3, BoulderfistOgre4, BoulderfistOgre5, BoulderfistOgre6, WarGolem1, WarGolem2, WarGolem3, WarGolem4, WarGolem5, WarGolem6, CoreHound1, CoreHound2, CoreHound3, CoreHound4, totem111, totem221, totem331);
                    refreshmana(lala, manamana, j1, vacio);
                }
            }
        }


        private void boton18_MouseEnter(object sender, MouseEventArgs e)
        {
            if (manos[0].nombre == "wisp")
            {
                popo.Background = wispmano;
            }
            if (manos[0].nombre == "Murloc Raider")
            {
                popo.Background = MurlocRaidermano;
            }
            if (manos[0].nombre == "Bloodfen Raptor")
            {
                popo.Background = BloodfenRaptormano;
            }
            if (manos[0].nombre == "River Crocolisk")
            {
                popo.Background = RiverCrocoliskmano;
            }
            if (manos[0].nombre == "Magma Rager")
            {
                popo.Background = MagmaRagermano;
            }
            if (manos[0].nombre == "Chillwind Yeti")
            {
                popo.Background = ChillwindYetimano;
            }
            if (manos[0].nombre == "Oasis Snapjaw")
            {
                popo.Background = OasisSnapjawmano;
            }
            if (manos[0].nombre == "Boulderfist Ogre")
            {
                popo.Background = BoulderfistOgremano;
            }
            if (manos[0].nombre == "War Golem")
            {
                popo.Background = WarGolemmano;
            }
            if (manos[0].nombre == "Core Hound")
            {
                popo.Background = CoreHoundmano;
            }
            refreshhmano(manos, manos2, manobot, manobot1, wispmano, MurlocRaidermano, BloodfenRaptormano, RiverCrocoliskmano, MagmaRagermano, ChillwindYetimano, OasisSnapjawmano, BoulderfistOgremano, WarGolemmano, CoreHoundmano, Recruit, j1, j2);
            refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, totem11, totem22, totem33, totem44, j1, j2, RiverCrocolisk1, BloodfenRaptor1, RiverCrocolisk2, ChillwindYeti1, ChillwindYeti2, ChillwindYeti3, ChillwindYeti4, OasisSnapjaw1, OasisSnapjaw2, OasisSnapjaw3, OasisSnapjaw4, OasisSnapjaw5, OasisSnapjaw6, BoulderfistOgre1, BoulderfistOgre2, BoulderfistOgre3, BoulderfistOgre4, BoulderfistOgre5, BoulderfistOgre6, WarGolem1, WarGolem2, WarGolem3, WarGolem4, WarGolem5, WarGolem6, CoreHound1, CoreHound2, CoreHound3, CoreHound4, totem111, totem221, totem331);
           

        }

        private void boton18_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Background = vacio;
        }

        private void boton19_Click(object sender, RoutedEventArgs e)
        {
            if (cartascancha.Count < 7)
            {
                if (j1.activo == true)
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
                            manobot[i].Background = wispmano;

                        }
                        if (manos[i].nombre == "Murloc Raider")
                        {
                            manobot[i].Background = MurlocRaidermano;
                        }
                        if (manos[i].nombre == "Bloodfen Raptor")
                        {
                            manobot[i].Background = BloodfenRaptormano;
                        }
                        if (manos[i].nombre == "River Crocolisk")
                        {
                            manobot[i].Background = RiverCrocoliskmano;
                        }
                        if (manos[i].nombre == "Magma Rager")
                        {
                            manobot[i].Background = MagmaRagermano;
                        }
                        if (manos[i].nombre == "Chillwind Yeti")
                        {
                            manobot[i].Background = ChillwindYetimano;
                        }
                        if (manos[i].nombre == "Oasis Snapjaw")
                        {
                            manobot[i].Background = OasisSnapjawmano;
                        }
                        if (manos[i].nombre == "Boulderfist Ogre")
                        {
                            manobot[i].Background = BoulderfistOgremano;
                        }
                        if (manos[i].nombre == "War Golem")
                        {
                            manobot[i].Background = WarGolemmano;
                        }
                        if (manos[i].nombre == "Core Hound")
                        {
                            manobot[i].Background = CoreHoundmano;
                        }
                        manobot[i].Visibility = Visibility.Visible;
                    }
                    manobot[manos.Count()].Visibility = Visibility.Hidden;
                    refreshhmano(manos, manos2, manobot, manobot1, wispmano, MurlocRaidermano, BloodfenRaptormano, RiverCrocoliskmano, MagmaRagermano, ChillwindYetimano, OasisSnapjawmano, BoulderfistOgremano, WarGolemmano, CoreHoundmano, Recruit, j1, j2);
                    refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, totem11, totem22, totem33, totem44, j1, j2, RiverCrocolisk1, BloodfenRaptor1, RiverCrocolisk2, ChillwindYeti1, ChillwindYeti2, ChillwindYeti3, ChillwindYeti4, OasisSnapjaw1, OasisSnapjaw2, OasisSnapjaw3, OasisSnapjaw4, OasisSnapjaw5, OasisSnapjaw6, BoulderfistOgre1, BoulderfistOgre2, BoulderfistOgre3, BoulderfistOgre4, BoulderfistOgre5, BoulderfistOgre6, WarGolem1, WarGolem2, WarGolem3, WarGolem4, WarGolem5, WarGolem6, CoreHound1, CoreHound2, CoreHound3, CoreHound4, totem111, totem221, totem331);
                    refreshmana(lala, manamana, j1, vacio);
                }
            }
        }
        private void boton19_MouseEnter(object sender, MouseEventArgs e)
        {
            if (manos[1].nombre == "wisp")
            {
                popo.Background = wispmano;
            }
            if (manos[1].nombre == "Murloc Raider")
            {
                popo.Background = MurlocRaidermano;
            }
            if (manos[1].nombre == "Bloodfen Raptor")
            {
                popo.Background = BloodfenRaptormano;
            }
            if (manos[1].nombre == "River Crocolisk")
            {
                popo.Background = RiverCrocoliskmano;
            }
            if (manos[1].nombre == "Magma Rager")
            {
                popo.Background = MagmaRagermano;
            }
            if (manos[1].nombre == "Chillwind Yeti")
            {
                popo.Background = ChillwindYetimano;
            }
            if (manos[1].nombre == "Oasis Snapjaw")
            {
                popo.Background = OasisSnapjawmano;
            }
            if (manos[1].nombre == "Boulderfist Ogre")
            {
                popo.Background = BoulderfistOgremano;
            }
            if (manos[1].nombre == "War Golem")
            {
                popo.Background = WarGolemmano;
            }
            if (manos[1].nombre == "Core Hound")
            {
                popo.Background = CoreHoundmano;
            }
            refreshhmano(manos, manos2, manobot, manobot1, wispmano, MurlocRaidermano, BloodfenRaptormano, RiverCrocoliskmano, MagmaRagermano, ChillwindYetimano, OasisSnapjawmano, BoulderfistOgremano, WarGolemmano, CoreHoundmano, Recruit, j1, j2);
            refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, totem11, totem22, totem33, totem44, j1, j2, RiverCrocolisk1, BloodfenRaptor1, RiverCrocolisk2, ChillwindYeti1, ChillwindYeti2, ChillwindYeti3, ChillwindYeti4, OasisSnapjaw1, OasisSnapjaw2, OasisSnapjaw3, OasisSnapjaw4, OasisSnapjaw5, OasisSnapjaw6, BoulderfistOgre1, BoulderfistOgre2, BoulderfistOgre3, BoulderfistOgre4, BoulderfistOgre5, BoulderfistOgre6, WarGolem1, WarGolem2, WarGolem3, WarGolem4, WarGolem5, WarGolem6, CoreHound1, CoreHound2, CoreHound3, CoreHound4, totem111, totem221, totem331);

        }
        private void boton19_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Background = vacio;
        }

        private void boton20_Click(object sender, RoutedEventArgs e)
        {
            if (cartascancha.Count < 7)
            {
                if (j1.activo == true)
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
                            manobot[i].Background = wispmano;

                        }
                        if (manos[i].nombre == "Murloc Raider")
                        {
                            manobot[i].Background = MurlocRaidermano;
                        }
                        if (manos[i].nombre == "Bloodfen Raptor")
                        {
                            manobot[i].Background = BloodfenRaptormano;
                        }
                        if (manos[i].nombre == "River Crocolisk")
                        {
                            manobot[i].Background = RiverCrocoliskmano;
                        }
                        if (manos[i].nombre == "Magma Rager")
                        {
                            manobot[i].Background = MagmaRagermano;
                        }
                        if (manos[i].nombre == "Chillwind Yeti")
                        {
                            manobot[i].Background = ChillwindYetimano;
                        }
                        if (manos[i].nombre == "Oasis Snapjaw")
                        {
                            manobot[i].Background = OasisSnapjawmano;
                        }
                        if (manos[i].nombre == "Boulderfist Ogre")
                        {
                            manobot[i].Background = BoulderfistOgremano;
                        }
                        if (manos[i].nombre == "War Golem")
                        {
                            manobot[i].Background = WarGolemmano;
                        }
                        if (manos[i].nombre == "Core Hound")
                        {
                            manobot[i].Background = CoreHoundmano;
                        }
                        manobot[i].Visibility = Visibility.Visible;
                    }
                    manobot[manos.Count()].Visibility = Visibility.Hidden;

                    refreshhmano(manos, manos2, manobot, manobot1, wispmano, MurlocRaidermano, BloodfenRaptormano, RiverCrocoliskmano, MagmaRagermano, ChillwindYetimano, OasisSnapjawmano, BoulderfistOgremano, WarGolemmano, CoreHoundmano, Recruit, j1, j2);
                    refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, totem11, totem22, totem33, totem44, j1, j2, RiverCrocolisk1, BloodfenRaptor1, RiverCrocolisk2, ChillwindYeti1, ChillwindYeti2, ChillwindYeti3, ChillwindYeti4, OasisSnapjaw1, OasisSnapjaw2, OasisSnapjaw3, OasisSnapjaw4, OasisSnapjaw5, OasisSnapjaw6, BoulderfistOgre1, BoulderfistOgre2, BoulderfistOgre3, BoulderfistOgre4, BoulderfistOgre5, BoulderfistOgre6, WarGolem1, WarGolem2, WarGolem3, WarGolem4, WarGolem5, WarGolem6, CoreHound1, CoreHound2, CoreHound3, CoreHound4, totem111, totem221, totem331);
                    refreshmana(lala, manamana, j1, vacio);
                }
            }
        }
        private void boton20_MouseEnter(object sender, MouseEventArgs e)
        {
            if (manos[2].nombre == "wisp")
            {
                popo.Background = wispmano;
            }
            if (manos[2].nombre == "Murloc Raider")
            {
                popo.Background = MurlocRaidermano;
            }
            if (manos[2].nombre == "Bloodfen Raptor")
            {
                popo.Background = BloodfenRaptormano;
            }
            if (manos[2].nombre == "River Crocolisk")
            {
                popo.Background = RiverCrocoliskmano;
            }
            if (manos[2].nombre == "Magma Rager")
            {
                popo.Background = MagmaRagermano;
            }
            if (manos[2].nombre == "Chillwind Yeti")
            {
                popo.Background = ChillwindYetimano;
            }
            if (manos[2].nombre == "Oasis Snapjaw")
            {
                popo.Background = OasisSnapjawmano;
            }
            if (manos[2].nombre == "Boulderfist Ogre")
            {
                popo.Background = BoulderfistOgremano;
            }
            if (manos[2].nombre == "War Golem")
            {
                popo.Background = WarGolemmano;
            }
            if (manos[2].nombre == "Core Hound")
            {
                popo.Background = CoreHoundmano;
            }
            refreshhmano(manos, manos2, manobot, manobot1, wispmano, MurlocRaidermano, BloodfenRaptormano, RiverCrocoliskmano, MagmaRagermano, ChillwindYetimano, OasisSnapjawmano, BoulderfistOgremano, WarGolemmano, CoreHoundmano, Recruit, j1, j2);
            refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, totem11, totem22, totem33, totem44, j1, j2, RiverCrocolisk1, BloodfenRaptor1, RiverCrocolisk2, ChillwindYeti1, ChillwindYeti2, ChillwindYeti3, ChillwindYeti4, OasisSnapjaw1, OasisSnapjaw2, OasisSnapjaw3, OasisSnapjaw4, OasisSnapjaw5, OasisSnapjaw6, BoulderfistOgre1, BoulderfistOgre2, BoulderfistOgre3, BoulderfistOgre4, BoulderfistOgre5, BoulderfistOgre6, WarGolem1, WarGolem2, WarGolem3, WarGolem4, WarGolem5, WarGolem6, CoreHound1, CoreHound2, CoreHound3, CoreHound4, totem111, totem221, totem331);

        }
        private void boton20_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Background = vacio;
        }
        private void boton21_Click(object sender, RoutedEventArgs e)
        {
            if (cartascancha.Count < 7)
            {
                if (j1.activo == true)
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
                            manobot[i].Background = wispmano;

                        }
                        if (manos[i].nombre == "Murloc Raider")
                        {
                            manobot[i].Background = MurlocRaidermano;
                        }
                        if (manos[i].nombre == "Bloodfen Raptor")
                        {
                            manobot[i].Background = BloodfenRaptormano;
                        }
                        if (manos[i].nombre == "River Crocolisk")
                        {
                            manobot[i].Background = RiverCrocoliskmano;
                        }
                        if (manos[i].nombre == "Magma Rager")
                        {
                            manobot[i].Background = MagmaRagermano;
                        }
                        if (manos[i].nombre == "Chillwind Yeti")
                        {
                            manobot[i].Background = ChillwindYetimano;
                        }
                        if (manos[i].nombre == "Oasis Snapjaw")
                        {
                            manobot[i].Background = OasisSnapjawmano;
                        }
                        if (manos[i].nombre == "Boulderfist Ogre")
                        {
                            manobot[i].Background = BoulderfistOgremano;
                        }
                        if (manos[i].nombre == "War Golem")
                        {
                            manobot[i].Background = WarGolemmano;
                        }
                        if (manos[i].nombre == "Core Hound")
                        {
                            manobot[i].Background = CoreHoundmano;
                        }
                        manobot[i].Visibility = Visibility.Visible;
                    }
                    manobot[manos.Count()].Visibility = Visibility.Hidden;

                    refreshhmano(manos, manos2, manobot, manobot1, wispmano, MurlocRaidermano, BloodfenRaptormano, RiverCrocoliskmano, MagmaRagermano, ChillwindYetimano, OasisSnapjawmano, BoulderfistOgremano, WarGolemmano, CoreHoundmano, Recruit, j1, j2);
                    refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, totem11, totem22, totem33, totem44, j1, j2, RiverCrocolisk1, BloodfenRaptor1, RiverCrocolisk2, ChillwindYeti1, ChillwindYeti2, ChillwindYeti3, ChillwindYeti4, OasisSnapjaw1, OasisSnapjaw2, OasisSnapjaw3, OasisSnapjaw4, OasisSnapjaw5, OasisSnapjaw6, BoulderfistOgre1, BoulderfistOgre2, BoulderfistOgre3, BoulderfistOgre4, BoulderfistOgre5, BoulderfistOgre6, WarGolem1, WarGolem2, WarGolem3, WarGolem4, WarGolem5, WarGolem6, CoreHound1, CoreHound2, CoreHound3, CoreHound4, totem111, totem221, totem331);
                    refreshmana(lala, manamana, j1, vacio);
                }
            }
        }
        private void boton21_MouseEnter(object sender, MouseEventArgs e)
        {
            if (manos[3].nombre == "wisp")
            {
                popo.Background = wispmano;
            }
            if (manos[3].nombre == "Murloc Raider")
            {
                popo.Background = MurlocRaidermano;
            }
            if (manos[3].nombre == "Bloodfen Raptor")
            {
                popo.Background = BloodfenRaptormano;
            }
            if (manos[3].nombre == "River Crocolisk")
            {
                popo.Background = RiverCrocoliskmano;
            }
            if (manos[3].nombre == "Magma Rager")
            {
                popo.Background = MagmaRagermano;
            }
            if (manos[3].nombre == "Chillwind Yeti")
            {
                popo.Background = ChillwindYetimano;
            }
            if (manos[3].nombre == "Oasis Snapjaw")
            {
                popo.Background = OasisSnapjawmano;
            }
            if (manos[3].nombre == "Boulderfist Ogre")
            {
                popo.Background = BoulderfistOgremano;
            }
            if (manos[3].nombre == "War Golem")
            {
                popo.Background = WarGolemmano;
            }
            if (manos[3].nombre == "Core Hound")
            {
                popo.Background = CoreHoundmano;
            }
            refreshhmano(manos, manos2, manobot, manobot1, wispmano, MurlocRaidermano, BloodfenRaptormano, RiverCrocoliskmano, MagmaRagermano, ChillwindYetimano, OasisSnapjawmano, BoulderfistOgremano, WarGolemmano, CoreHoundmano, Recruit, j1, j2);
            refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, totem11, totem22, totem33, totem44, j1, j2, RiverCrocolisk1, BloodfenRaptor1, RiverCrocolisk2, ChillwindYeti1, ChillwindYeti2, ChillwindYeti3, ChillwindYeti4, OasisSnapjaw1, OasisSnapjaw2, OasisSnapjaw3, OasisSnapjaw4, OasisSnapjaw5, OasisSnapjaw6, BoulderfistOgre1, BoulderfistOgre2, BoulderfistOgre3, BoulderfistOgre4, BoulderfistOgre5, BoulderfistOgre6, WarGolem1, WarGolem2, WarGolem3, WarGolem4, WarGolem5, WarGolem6, CoreHound1, CoreHound2, CoreHound3, CoreHound4, totem111, totem221, totem331);
        }
        private void boton21_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Background = vacio;
        }
        private void boton22_Click(object sender, RoutedEventArgs e)
        {
            if (cartascancha.Count < 7)
            {
                if (j1.activo == true)
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
                            manobot[i].Background = wispmano;

                        }
                        if (manos[i].nombre == "Murloc Raider")
                        {
                            manobot[i].Background = MurlocRaidermano;
                        }
                        if (manos[i].nombre == "Bloodfen Raptor")
                        {
                            manobot[i].Background = BloodfenRaptormano;
                        }
                        if (manos[i].nombre == "River Crocolisk")
                        {
                            manobot[i].Background = RiverCrocoliskmano;
                        }
                        if (manos[i].nombre == "Magma Rager")
                        {
                            manobot[i].Background = MagmaRagermano;
                        }
                        if (manos[i].nombre == "Chillwind Yeti")
                        {
                            manobot[i].Background = ChillwindYetimano;
                        }
                        if (manos[i].nombre == "Oasis Snapjaw")
                        {
                            manobot[i].Background = OasisSnapjawmano;
                        }
                        if (manos[i].nombre == "Boulderfist Ogre")
                        {
                            manobot[i].Background = BoulderfistOgremano;
                        }
                        if (manos[i].nombre == "War Golem")
                        {
                            manobot[i].Background = WarGolemmano;
                        }
                        if (manos[i].nombre == "Core Hound")
                        {
                            manobot[i].Background = CoreHoundmano;
                        }
                        manobot[i].Visibility = Visibility.Visible;
                    }
                    manobot[manos.Count()].Visibility = Visibility.Hidden;

                    refreshhmano(manos, manos2, manobot, manobot1, wispmano, MurlocRaidermano, BloodfenRaptormano, RiverCrocoliskmano, MagmaRagermano, ChillwindYetimano, OasisSnapjawmano, BoulderfistOgremano, WarGolemmano, CoreHoundmano, Recruit, j1, j2);
                    refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, totem11, totem22, totem33, totem44, j1, j2, RiverCrocolisk1, BloodfenRaptor1, RiverCrocolisk2, ChillwindYeti1, ChillwindYeti2, ChillwindYeti3, ChillwindYeti4, OasisSnapjaw1, OasisSnapjaw2, OasisSnapjaw3, OasisSnapjaw4, OasisSnapjaw5, OasisSnapjaw6, BoulderfistOgre1, BoulderfistOgre2, BoulderfistOgre3, BoulderfistOgre4, BoulderfistOgre5, BoulderfistOgre6, WarGolem1, WarGolem2, WarGolem3, WarGolem4, WarGolem5, WarGolem6, CoreHound1, CoreHound2, CoreHound3, CoreHound4, totem111, totem221, totem331);
                    refreshmana(lala, manamana, j1, vacio);
                }
            }
        }

        private void boton22_MouseEnter(object sender, MouseEventArgs e)
        {
                    if (manos[4].nombre == "wisp")
                    {
                         popo.Background = wispmano;

                    }
                   
                    if (manos[4].nombre == "Murloc Raider")
                    {
                        popo.Background = MurlocRaidermano;
                    }
                    if (manos[4].nombre == "Bloodfen Raptor")
                    {
                        popo.Background = BloodfenRaptormano;
                    }
                    if (manos[4].nombre == "River Crocolisk")
                    {
                        popo.Background = RiverCrocoliskmano;
                    }
                    if (manos[4].nombre == "Magma Ragermano")
                    {
                        popo.Background = MagmaRagermano;
                    }
                    if (manos[4].nombre == "Chillwind Yeti")
                    {
                        popo.Background = ChillwindYetimano;
                    }
                    if (manos[4].nombre == "Oasis Snapjaw")
                    {
                        popo.Background = OasisSnapjawmano;
                    }
                    if (manos[4].nombre == "Boulderfist Ogre")
                    {
                        popo.Background = BoulderfistOgremano;
                    }
                    if (manos[4].nombre == "War Golem")
                    {
                        popo.Background = WarGolemmano;
                    }
                    if (manos[4].nombre == "Core Hound")
                    {
                        popo.Background = CoreHoundmano;
                    }
                    refreshhmano(manos, manos2, manobot, manobot1, wispmano, MurlocRaidermano, BloodfenRaptormano, RiverCrocoliskmano, MagmaRagermano, ChillwindYetimano, OasisSnapjawmano, BoulderfistOgremano, WarGolemmano, CoreHoundmano, Recruit, j1, j2);
                    refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, totem11, totem22, totem33, totem44, j1, j2, RiverCrocolisk1, BloodfenRaptor1, RiverCrocolisk2, ChillwindYeti1, ChillwindYeti2, ChillwindYeti3, ChillwindYeti4, OasisSnapjaw1, OasisSnapjaw2, OasisSnapjaw3, OasisSnapjaw4, OasisSnapjaw5, OasisSnapjaw6, BoulderfistOgre1, BoulderfistOgre2, BoulderfistOgre3, BoulderfistOgre4, BoulderfistOgre5, BoulderfistOgre6, WarGolem1, WarGolem2, WarGolem3, WarGolem4, WarGolem5, WarGolem6, CoreHound1, CoreHound2, CoreHound3, CoreHound4, totem111, totem221, totem331);

                
            
        }
        private void boton22_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Background = vacio;
        }
        private void boton23_Click(object sender, RoutedEventArgs e)
        {
            if (cartascancha.Count < 7)
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
                        manobot[i].Background = wispmano;

                    }
                    if (manos[i].nombre == "Murloc Raider")
                    {
                        manobot[i].Background = MurlocRaidermano;
                    }
                    if (manos[i].nombre == "Bloodfen Raptor")
                    {
                        manobot[i].Background = BloodfenRaptormano;
                    }
                    if (manos[i].nombre == "River Crocolisk")
                    {
                        manobot[i].Background = RiverCrocoliskmano;
                    }
                    if (manos[i].nombre == "Magma Rager")
                    {
                        manobot[i].Background = MagmaRagermano;
                    }
                    if (manos[i].nombre == "Chillwind Yeti")
                    {
                        manobot[i].Background = ChillwindYetimano;
                    }
                    if (manos[i].nombre == "Oasis Snapjaw")
                    {
                        manobot[i].Background = OasisSnapjawmano;
                    }
                    if (manos[i].nombre == "Boulderfist Ogre")
                    {
                        manobot[i].Background = BoulderfistOgremano;
                    }
                    if (manos[i].nombre == "War Golem")
                    {
                        manobot[i].Background = WarGolemmano;
                    }
                    if (manos[i].nombre == "Core Hound")
                    {
                        manobot[i].Background = CoreHoundmano;
                    }
                    manobot[i].Visibility = Visibility.Visible;
                }
                manobot[manos.Count()].Visibility = Visibility.Hidden;

                refreshhmano(manos, manos2, manobot, manobot1, wispmano, MurlocRaidermano, BloodfenRaptormano, RiverCrocoliskmano, MagmaRagermano, ChillwindYetimano, OasisSnapjawmano, BoulderfistOgremano, WarGolemmano, CoreHoundmano, Recruit, j1, j2);
                refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, totem11, totem22, totem33, totem44, j1, j2, RiverCrocolisk1, BloodfenRaptor1, RiverCrocolisk2, ChillwindYeti1, ChillwindYeti2, ChillwindYeti3, ChillwindYeti4, OasisSnapjaw1, OasisSnapjaw2, OasisSnapjaw3, OasisSnapjaw4, OasisSnapjaw5, OasisSnapjaw6, BoulderfistOgre1, BoulderfistOgre2, BoulderfistOgre3, BoulderfistOgre4, BoulderfistOgre5, BoulderfistOgre6, WarGolem1, WarGolem2, WarGolem3, WarGolem4, WarGolem5, WarGolem6, CoreHound1, CoreHound2, CoreHound3, CoreHound4, totem111, totem221, totem331);
                refreshmana(lala, manamana, j1, vacio);
            }
        }
        private void boton23_MouseEnter(object sender, MouseEventArgs e)
        {
            
                if (manos[5].nombre == "wisp")
                {
                    popo.Background = wispmano;
                }
                if (manos[5].nombre == "Murloc Raider")
                {
                    popo.Background = MurlocRaidermano;
                }
                if (manos[5].nombre == "Bloodfen Raptor")
                {
                    popo.Background = BloodfenRaptormano;
                }
                if (manos[5].nombre == "River Crocolisk")
                {
                    popo.Background = RiverCrocoliskmano;
                }
                if (manos[5].nombre == "Magma Rager")
                {
                    popo.Background = MagmaRagermano;
                }
                if (manos[5].nombre == "Chillwind Yeti")
                {
                    popo.Background = ChillwindYetimano;
                }
                if (manos[5].nombre == "Oasis Snapjaw")
                {
                    popo.Background = OasisSnapjawmano;
                }
                if (manos[5].nombre == "Boulderfist Ogre")
                {
                    popo.Background = BoulderfistOgremano;
                }
                if (manos[5].nombre == "War Golem")
                {
                    popo.Background = WarGolemmano;
                }
                if (manos[5].nombre == "Core Hound")
                {
                    popo.Background = CoreHoundmano;
                }
                refreshhmano(manos, manos2, manobot, manobot1, wispmano, MurlocRaidermano, BloodfenRaptormano, RiverCrocoliskmano, MagmaRagermano, ChillwindYetimano, OasisSnapjawmano, BoulderfistOgremano, WarGolemmano, CoreHoundmano, Recruit, j1, j2);
                refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, totem11, totem22, totem33, totem44, j1, j2, RiverCrocolisk1, BloodfenRaptor1, RiverCrocolisk2, ChillwindYeti1, ChillwindYeti2, ChillwindYeti3, ChillwindYeti4, OasisSnapjaw1, OasisSnapjaw2, OasisSnapjaw3, OasisSnapjaw4, OasisSnapjaw5, OasisSnapjaw6, BoulderfistOgre1, BoulderfistOgre2, BoulderfistOgre3, BoulderfistOgre4, BoulderfistOgre5, BoulderfistOgre6, WarGolem1, WarGolem2, WarGolem3, WarGolem4, WarGolem5, WarGolem6, CoreHound1, CoreHound2, CoreHound3, CoreHound4, totem111, totem221, totem331);

            
        }
        private void boton23_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Background = vacio;
        }
        private void boton24_Click(object sender, RoutedEventArgs e)
        {
            if (cartascancha.Count < 7)
            {
                if (j1.activo == true)
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
                            manobot[i].Background = wispmano;

                        }
                        if (manos[i].nombre == "Murloc Raider")
                        {
                            manobot[i].Background = MurlocRaidermano;
                        }
                        if (manos[i].nombre == "Bloodfen Raptor")
                        {
                            manobot[i].Background = BloodfenRaptormano;
                        }
                        if (manos[i].nombre == "River Crocolisk")
                        {
                            manobot[i].Background = RiverCrocoliskmano;
                        }
                        if (manos[i].nombre == "Magma Rager")
                        {
                            manobot[i].Background = MagmaRagermano;
                        }
                        if (manos[i].nombre == "Chillwind Yeti")
                        {
                            manobot[i].Background = ChillwindYetimano;
                        }
                        if (manos[i].nombre == "Oasis Snapjaw")
                        {
                            manobot[i].Background = OasisSnapjawmano;
                        }
                        if (manos[i].nombre == "Boulderfist Ogre")
                        {
                            manobot[i].Background = BoulderfistOgremano;
                        }
                        if (manos[i].nombre == "War Golem")
                        {
                            manobot[i].Background = WarGolemmano;
                        }
                        if (manos[i].nombre == "Core Hound")
                        {
                            manobot[i].Background = CoreHoundmano;
                        }
                        manobot[i].Visibility = Visibility.Visible;
                    }
                    manobot[manos.Count()].Visibility = Visibility.Hidden;

                    refreshhmano(manos, manos2, manobot, manobot1, wispmano, MurlocRaidermano, BloodfenRaptormano, RiverCrocoliskmano, MagmaRagermano, ChillwindYetimano, OasisSnapjawmano, BoulderfistOgremano, WarGolemmano, CoreHoundmano, Recruit, j1, j2);
                    refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, totem11, totem22, totem33, totem44, j1, j2, RiverCrocolisk1, BloodfenRaptor1, RiverCrocolisk2, ChillwindYeti1, ChillwindYeti2, ChillwindYeti3, ChillwindYeti4, OasisSnapjaw1, OasisSnapjaw2, OasisSnapjaw3, OasisSnapjaw4, OasisSnapjaw5, OasisSnapjaw6, BoulderfistOgre1, BoulderfistOgre2, BoulderfistOgre3, BoulderfistOgre4, BoulderfistOgre5, BoulderfistOgre6, WarGolem1, WarGolem2, WarGolem3, WarGolem4, WarGolem5, WarGolem6, CoreHound1, CoreHound2, CoreHound3, CoreHound4, totem111, totem221, totem331);
                    refreshmana(lala, manamana, j1, vacio);
                }
            }
        }

        private void boton24_MouseEnter(object sender, MouseEventArgs e)
        {
            if (manos[6].nombre == "wisp")
            {
                popo.Background = wispmano;
            }
            if (manos[6].nombre == "Murloc Raider")
            {
                popo.Background = MurlocRaidermano;
            }
            if (manos[6].nombre == "Bloodfen Raptor")
            {
                popo.Background = BloodfenRaptormano;
            }
            if (manos[6].nombre == "River Crocolisk")
            {
                popo.Background = RiverCrocoliskmano;
            }
            if (manos[6].nombre == "Magma Rager")
            {
                popo.Background = MagmaRagermano;
            }
            if (manos[6].nombre == "Chillwind Yeti")
            {
                popo.Background = ChillwindYetimano;
            }
            if (manos[6].nombre == "Oasis Snapjaw")
            {
                popo.Background = OasisSnapjawmano;
            }
            if (manos[6].nombre == "Boulderfist Ogre")
            {
                popo.Background = BoulderfistOgremano;
            }
            if (manos[6].nombre == "War Golem")
            {
                popo.Background = WarGolemmano;
            }
            if (manos[6].nombre == "Core Hound")
            {
                popo.Background = CoreHound;
            }
            refreshhmano(manos, manos2, manobot, manobot1, wispmano, MurlocRaidermano, BloodfenRaptormano, RiverCrocoliskmano, MagmaRagermano, ChillwindYetimano, OasisSnapjawmano, BoulderfistOgremano, WarGolemmano, CoreHoundmano, Recruit, j1, j2);
            refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, totem11, totem22, totem33, totem44, j1, j2, RiverCrocolisk1, BloodfenRaptor1, RiverCrocolisk2, ChillwindYeti1, ChillwindYeti2, ChillwindYeti3, ChillwindYeti4, OasisSnapjaw1, OasisSnapjaw2, OasisSnapjaw3, OasisSnapjaw4, OasisSnapjaw5, OasisSnapjaw6, BoulderfistOgre1, BoulderfistOgre2, BoulderfistOgre3, BoulderfistOgre4, BoulderfistOgre5, BoulderfistOgre6, WarGolem1, WarGolem2, WarGolem3, WarGolem4, WarGolem5, WarGolem6, CoreHound1, CoreHound2, CoreHound3, CoreHound4, totem111, totem221, totem331);

        }
        private void boton24_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Background = vacio;
        }

        private void boton25_Click(object sender, RoutedEventArgs e)
        {
            if (cartascancha.Count < 7)
            {
                if (j1.activo == true)
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
                            manobot[i].Background = wispmano;

                        }
                        if (manos[i].nombre == "Murloc Raider")
                        {
                            manobot[i].Background = MurlocRaidermano;
                        }
                        if (manos[i].nombre == "Bloodfen Raptor")
                        {
                            manobot[i].Background = BloodfenRaptormano;
                        }
                        if (manos[i].nombre == "River Crocolisk")
                        {
                            manobot[i].Background = RiverCrocoliskmano;
                        }
                        if (manos[i].nombre == "Magma Rager")
                        {
                            manobot[i].Background = MagmaRagermano;
                        }
                        if (manos[i].nombre == "Chillwind Yeti")
                        {
                            manobot[i].Background = ChillwindYetimano;
                        }
                        if (manos[i].nombre == "Oasis Snapjaw")
                        {
                            manobot[i].Background = OasisSnapjawmano;
                        }
                        if (manos[i].nombre == "Boulderfist Ogre")
                        {
                            manobot[i].Background = BoulderfistOgremano;
                        }
                        if (manos[i].nombre == "War Golem")
                        {
                            manobot[i].Background = WarGolemmano;
                        }
                        if (manos[i].nombre == "Core Hound")
                        {
                            manobot[i].Background = CoreHoundmano;
                        }
                        manobot[i].Visibility = Visibility.Visible;
                    }
                    manobot[manos.Count()].Visibility = Visibility.Hidden;

                    refreshhmano(manos, manos2, manobot, manobot1, wispmano, MurlocRaidermano, BloodfenRaptormano, RiverCrocoliskmano, MagmaRagermano, ChillwindYetimano, OasisSnapjawmano, BoulderfistOgremano, WarGolemmano, CoreHoundmano, Recruit, j1, j2);
                    refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, totem11, totem22, totem33, totem44, j1, j2, RiverCrocolisk1, BloodfenRaptor1, RiverCrocolisk2, ChillwindYeti1, ChillwindYeti2, ChillwindYeti3, ChillwindYeti4, OasisSnapjaw1, OasisSnapjaw2, OasisSnapjaw3, OasisSnapjaw4, OasisSnapjaw5, OasisSnapjaw6, BoulderfistOgre1, BoulderfistOgre2, BoulderfistOgre3, BoulderfistOgre4, BoulderfistOgre5, BoulderfistOgre6, WarGolem1, WarGolem2, WarGolem3, WarGolem4, WarGolem5, WarGolem6, CoreHound1, CoreHound2, CoreHound3, CoreHound4, totem111, totem221, totem331);
                    refreshmana(lala, manamana, j1, vacio);
                }
            }
        }

        private void boton25_MouseEnter(object sender, MouseEventArgs e)
        {
            if (manos[7].nombre == "wisp")
            {
                popo.Background = wispmano;
            }
            if (manos[7].nombre == "Murloc Raider")
            {
                popo.Background = MurlocRaidermano;
            }
            if (manos[7].nombre == "Bloodfen Raptor")
            {
                popo.Background = BloodfenRaptormano;
            }
            if (manos[7].nombre == "River Crocolisk")
            {
                popo.Background = RiverCrocoliskmano;
            }
            if (manos[7].nombre == "Magma Rager")
            {
                popo.Background = MagmaRagermano;
            }
            if (manos[7].nombre == "Chillwind Yeti")
            {
                popo.Background = ChillwindYetimano;
            }
            if (manos[7].nombre == "Oasis Snapjaw")
            {
                popo.Background = OasisSnapjawmano;
            }
            if (manos[7].nombre == "Boulderfist Ogre")
            {
                popo.Background = BoulderfistOgremano;
            }
            if (manos[7].nombre == "War Golem")
            {
                popo.Background = WarGolemmano;
            }
            if (manos[7].nombre == "Core Hound")
            {
                popo.Background = CoreHoundmano;
            }
            refreshhmano(manos, manos2, manobot, manobot1, wispmano, MurlocRaidermano, BloodfenRaptormano, RiverCrocoliskmano, MagmaRagermano, ChillwindYetimano, OasisSnapjawmano, BoulderfistOgremano, WarGolemmano, CoreHoundmano, Recruit, j1, j2);
            refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, totem11, totem22, totem33, totem44, j1, j2, RiverCrocolisk1, BloodfenRaptor1, RiverCrocolisk2, ChillwindYeti1, ChillwindYeti2, ChillwindYeti3, ChillwindYeti4, OasisSnapjaw1, OasisSnapjaw2, OasisSnapjaw3, OasisSnapjaw4, OasisSnapjaw5, OasisSnapjaw6, BoulderfistOgre1, BoulderfistOgre2, BoulderfistOgre3, BoulderfistOgre4, BoulderfistOgre5, BoulderfistOgre6, WarGolem1, WarGolem2, WarGolem3, WarGolem4, WarGolem5, WarGolem6, CoreHound1, CoreHound2, CoreHound3, CoreHound4, totem111, totem221, totem331);

        }
        private void boton25_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Background = vacio;
        }
        private void boton24_Copy_Click(object sender, RoutedEventArgs e)
        {
            if (cartascancha.Count < 7)
            {
                if (j1.activo == true)
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
                            manobot[i].Background = wispmano;

                        }
                        if (manos[i].nombre == "Murloc Raider")
                        {
                            manobot[i].Background = MurlocRaidermano;
                        }
                        if (manos[i].nombre == "Bloodfen Raptor")
                        {
                            manobot[i].Background = BloodfenRaptormano;
                        }
                        if (manos[i].nombre == "River Crocolisk")
                        {
                            manobot[i].Background = RiverCrocoliskmano;
                        }
                        if (manos[i].nombre == "Magma Rager")
                        {
                            manobot[i].Background = MagmaRagermano;
                        }
                        if (manos[i].nombre == "Chillwind Yeti")
                        {
                            manobot[i].Background = ChillwindYetimano;
                        }
                        if (manos[i].nombre == "Oasis Snapjaw")
                        {
                            manobot[i].Background = OasisSnapjawmano;
                        }
                        if (manos[i].nombre == "Boulderfist Ogre")
                        {
                            manobot[i].Background = BoulderfistOgremano;
                        }
                        if (manos[i].nombre == "War Golem")
                        {
                            manobot[i].Background = WarGolemmano;
                        }
                        if (manos[i].nombre == "Core Hound")
                        {
                            manobot[i].Background = CoreHoundmano;
                        }
                        manobot[i].Visibility = Visibility.Visible;
                    }
                    manobot[manos.Count()].Visibility = Visibility.Hidden;

                    refreshhmano(manos, manos2, manobot, manobot1, wispmano, MurlocRaidermano, BloodfenRaptormano, RiverCrocoliskmano, MagmaRagermano, ChillwindYetimano, OasisSnapjawmano, BoulderfistOgremano, WarGolemmano, CoreHoundmano, Recruit, j1, j2);
                    refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, totem11, totem22, totem33, totem44, j1, j2, RiverCrocolisk1, BloodfenRaptor1, RiverCrocolisk2, ChillwindYeti1, ChillwindYeti2, ChillwindYeti3, ChillwindYeti4, OasisSnapjaw1, OasisSnapjaw2, OasisSnapjaw3, OasisSnapjaw4, OasisSnapjaw5, OasisSnapjaw6, BoulderfistOgre1, BoulderfistOgre2, BoulderfistOgre3, BoulderfistOgre4, BoulderfistOgre5, BoulderfistOgre6, WarGolem1, WarGolem2, WarGolem3, WarGolem4, WarGolem5, WarGolem6, CoreHound1, CoreHound2, CoreHound3, CoreHound4, totem111, totem221, totem331);
                    refreshmana(lala, manamana, j1, vacio);
                }
            }
        }

        private void boton241_MouseEnter(object sender, MouseEventArgs e)
        {
            if (manos[8].nombre == "wisp")
            {
                popo.Background = wispmano;
            }
            if (manos[8].nombre == "Murloc Raider")
            {
                popo.Background = MurlocRaidermano;
            }
            if (manos[8].nombre == "Bloodfen Raptor")
            {
                popo.Background = BloodfenRaptormano;
            }
            if (manos[8].nombre == "River Crocolisk")
            {
                popo.Background = RiverCrocoliskmano;
            }
            if (manos[8].nombre == "Magma Rager")
            {
                popo.Background = MagmaRagermano;
            }
            if (manos[8].nombre == "Chillwind Yeti")
            {
                popo.Background = ChillwindYetimano;
            }
            if (manos[8].nombre == "Oasis Snapjaw")
            {
                popo.Background = OasisSnapjawmano;
            }
            if (manos[8].nombre == "Boulderfist Ogre")
            {
                popo.Background = BoulderfistOgremano;
            }
            if (manos[8].nombre == "War Golem")
            {
                popo.Background = WarGolemmano;
            }
            if (manos[8].nombre == "Core Hound")
            {
                popo.Background = CoreHoundmano;
            }
            refreshhmano(manos, manos2, manobot, manobot1, wispmano, MurlocRaidermano, BloodfenRaptormano, RiverCrocoliskmano, MagmaRagermano, ChillwindYetimano, OasisSnapjawmano, BoulderfistOgremano, WarGolemmano, CoreHoundmano, Recruit, j1, j2);
            refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, totem11, totem22, totem33, totem44, j1, j2, RiverCrocolisk1, BloodfenRaptor1, RiverCrocolisk2, ChillwindYeti1, ChillwindYeti2, ChillwindYeti3, ChillwindYeti4, OasisSnapjaw1, OasisSnapjaw2, OasisSnapjaw3, OasisSnapjaw4, OasisSnapjaw5, OasisSnapjaw6, BoulderfistOgre1, BoulderfistOgre2, BoulderfistOgre3, BoulderfistOgre4, BoulderfistOgre5, BoulderfistOgre6, WarGolem1, WarGolem2, WarGolem3, WarGolem4, WarGolem5, WarGolem6, CoreHound1, CoreHound2, CoreHound3, CoreHound4, totem111, totem221, totem331);

        }
        private void boton241_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Background = vacio;
        }

        private void boton24_Copy1_Click(object sender, RoutedEventArgs e)
        {
            if (cartascancha.Count < 7)
            {
                if (j1.activo == true)
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
                            manobot[i].Background = wispmano;

                        }
                        if (manos[i].nombre == "Murloc Raider")
                        {
                            manobot[i].Background = MurlocRaidermano;
                        }
                        if (manos[i].nombre == "Bloodfen Raptor")
                        {
                            manobot[i].Background = BloodfenRaptormano;
                        }
                        if (manos[i].nombre == "River Crocolisk")
                        {
                            manobot[i].Background = RiverCrocoliskmano;
                        }
                        if (manos[i].nombre == "Magma Rager")
                        {
                            manobot[i].Background = MagmaRagermano;
                        }
                        if (manos[i].nombre == "Chillwind Yeti")
                        {
                            manobot[i].Background = ChillwindYetimano;
                        }
                        if (manos[i].nombre == "Oasis Snapjaw")
                        {
                            manobot[i].Background = OasisSnapjawmano;
                        }
                        if (manos[i].nombre == "Boulderfist Ogre")
                        {
                            manobot[i].Background = BoulderfistOgremano;
                        }
                        if (manos[i].nombre == "War Golem")
                        {
                            manobot[i].Background = WarGolemmano;
                        }
                        if (manos[i].nombre == "Core Hound")
                        {
                            manobot[i].Background = CoreHoundmano;
                        }
                        manobot[i].Visibility = Visibility.Visible;
                    }
                    manobot[manos.Count()].Visibility = Visibility.Hidden;

                    refreshhmano(manos, manos2, manobot, manobot1, wispmano, MurlocRaidermano, BloodfenRaptormano, RiverCrocoliskmano, MagmaRagermano, ChillwindYetimano, OasisSnapjawmano, BoulderfistOgremano, WarGolemmano, CoreHoundmano, Recruit, j1, j2);
                    refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, totem11, totem22, totem33, totem44, j1, j2, RiverCrocolisk1, BloodfenRaptor1, RiverCrocolisk2, ChillwindYeti1, ChillwindYeti2, ChillwindYeti3, ChillwindYeti4, OasisSnapjaw1, OasisSnapjaw2, OasisSnapjaw3, OasisSnapjaw4, OasisSnapjaw5, OasisSnapjaw6, BoulderfistOgre1, BoulderfistOgre2, BoulderfistOgre3, BoulderfistOgre4, BoulderfistOgre5, BoulderfistOgre6, WarGolem1, WarGolem2, WarGolem3, WarGolem4, WarGolem5, WarGolem6, CoreHound1, CoreHound2, CoreHound3, CoreHound4, totem111, totem221, totem331);
                    refreshmana(lala, manamana, j1, vacio);
                }
            }
        }

        private void boton242_MouseEnter(object sender, MouseEventArgs e)
        {
            if (manos[9].nombre == "wisp")
            {
                popo.Background = wispmano;
            }
            if (manos[9].nombre == "Murloc Raider")
            {
                popo.Background = MurlocRaidermano;
            }
            if (manos[9].nombre == "Bloodfen Raptor")
            {
                popo.Background = BloodfenRaptormano;
            }
            if (manos[9].nombre == "River Crocolisk")
            {
                popo.Background = RiverCrocoliskmano;
            }
            if (manos[9].nombre == "Magma Rager")
            {
                popo.Background = MagmaRagermano;
            }
            if (manos[9].nombre == "Chillwind Yeti")
            {
                popo.Background = ChillwindYetimano;
            }
            if (manos[9].nombre == "Oasis Snapjaw")
            {
                popo.Background = OasisSnapjawmano;
            }
            if (manos[9].nombre == "Boulderfist Ogre")
            {
                popo.Background = BoulderfistOgremano;
            }
            if (manos[9].nombre == "War Golem")
            {
                popo.Background = WarGolemmano;
            }
            if (manos[9].nombre == "Core Hound")
            {
                popo.Background = CoreHoundmano;
            }
            refreshhmano(manos, manos2, manobot, manobot1, wispmano, MurlocRaidermano, BloodfenRaptormano, RiverCrocoliskmano, MagmaRagermano, ChillwindYetimano, OasisSnapjawmano, BoulderfistOgremano, WarGolemmano, CoreHoundmano, Recruit, j1, j2);
            refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, totem11, totem22, totem33, totem44, j1, j2, RiverCrocolisk1, BloodfenRaptor1, RiverCrocolisk2, ChillwindYeti1, ChillwindYeti2, ChillwindYeti3, ChillwindYeti4, OasisSnapjaw1, OasisSnapjaw2, OasisSnapjaw3, OasisSnapjaw4, OasisSnapjaw5, OasisSnapjaw6, BoulderfistOgre1, BoulderfistOgre2, BoulderfistOgre3, BoulderfistOgre4, BoulderfistOgre5, BoulderfistOgre6, WarGolem1, WarGolem2, WarGolem3, WarGolem4, WarGolem5, WarGolem6, CoreHound1, CoreHound2, CoreHound3, CoreHound4, totem111, totem221, totem331);

        }
        private void boton242_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Background = vacio;
        }
        private void boton26_Click(object sender, RoutedEventArgs e)
        {
            if (cartascancha2.Count < 7)
            {
                if (j2.activo == true)
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
                            manobot1[i].Background = wispmano;

                        }
                        if (manos2[i].nombre == "Murloc Raider")
                        {
                            manobot1[i].Background = MurlocRaidermano;
                        }
                        if (manos2[i].nombre == "Bloodfen Raptor")
                        {
                            manobot1[i].Background = BloodfenRaptormano;
                        }
                        if (manos2[i].nombre == "River Crocolisk")
                        {
                            manobot1[i].Background = RiverCrocoliskmano;
                        }
                        if (manos2[i].nombre == "Magma Rager")
                        {
                            manobot1[i].Background = MagmaRagermano;
                        }
                        if (manos2[i].nombre == "Chillwind Yeti")
                        {
                            manobot1[i].Background = ChillwindYetimano;
                        }
                        if (manos2[i].nombre == "Oasis Snapjaw")
                        {
                            manobot1[i].Background = OasisSnapjawmano;
                        }
                        if (manos2[i].nombre == "Boulderfist Ogre")
                        {
                            manobot1[i].Background = BoulderfistOgremano;
                        }
                        if (manos2[i].nombre == "War Golem")
                        {
                            manobot1[i].Background = WarGolemmano;
                        }
                        if (manos2[i].nombre == "Core Hound")
                        {
                            manobot1[i].Background = CoreHoundmano;
                        }
                        manobot1[i].Visibility = Visibility.Visible;
                    }
                    manobot1[manos2.Count()].Visibility = Visibility.Hidden;

                    refreshhmano(manos, manos2, manobot, manobot1, wispmano, MurlocRaidermano, BloodfenRaptormano, RiverCrocoliskmano, MagmaRagermano, ChillwindYetimano, OasisSnapjawmano, BoulderfistOgremano, WarGolemmano, CoreHoundmano, Recruit, j1, j2);
                    refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, totem11, totem22, totem33, totem44, j1, j2, RiverCrocolisk1, BloodfenRaptor1, RiverCrocolisk2, ChillwindYeti1, ChillwindYeti2, ChillwindYeti3, ChillwindYeti4, OasisSnapjaw1, OasisSnapjaw2, OasisSnapjaw3, OasisSnapjaw4, OasisSnapjaw5, OasisSnapjaw6, BoulderfistOgre1, BoulderfistOgre2, BoulderfistOgre3, BoulderfistOgre4, BoulderfistOgre5, BoulderfistOgre6, WarGolem1, WarGolem2, WarGolem3, WarGolem4, WarGolem5, WarGolem6, CoreHound1, CoreHound2, CoreHound3, CoreHound4, totem111, totem221, totem331);

                }
            }

        }
        private void boton26_MouseEnter(object sender, MouseEventArgs e)
        {
            if (manos2[0].nombre == "wisp")
            {
                popo.Background = wispmano;
            }
            if (manos2[0].nombre == "Murloc Raider")
            {
                popo.Background = MurlocRaidermano;
            }
            if (manos2[0].nombre == "Bloodfen Raptor")
            {
                popo.Background = BloodfenRaptormano;
            }
            if (manos2[0].nombre == "River Crocolisk")
            {
                popo.Background = RiverCrocoliskmano;
            }
            if (manos2[0].nombre == "Magma Rager")
            {
                popo.Background = MagmaRagermano;
            }
            if (manos2[0].nombre == "Chillwind Yeti")
            {
                popo.Background = ChillwindYetimano;
            }
            if (manos2[0].nombre == "Oasis Snapjaw")
            {
                popo.Background = OasisSnapjawmano;
            }
            if (manos2[0].nombre == "Boulderfist Ogre")
            {
                popo.Background = BoulderfistOgremano;
            }
            if (manos2[0].nombre == "War Golem")
            {
                popo.Background = WarGolemmano;
            }
            if (manos2[0].nombre == "Core Hound")
            {
                popo.Background = CoreHoundmano;
            }
            refreshhmano(manos, manos2, manobot, manobot1, wispmano, MurlocRaidermano, BloodfenRaptormano, RiverCrocoliskmano, MagmaRagermano, ChillwindYetimano, OasisSnapjawmano, BoulderfistOgremano, WarGolemmano, CoreHoundmano, Recruit, j1, j2);
            refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, totem11, totem22, totem33, totem44, j1, j2, RiverCrocolisk1, BloodfenRaptor1, RiverCrocolisk2, ChillwindYeti1, ChillwindYeti2, ChillwindYeti3, ChillwindYeti4, OasisSnapjaw1, OasisSnapjaw2, OasisSnapjaw3, OasisSnapjaw4, OasisSnapjaw5, OasisSnapjaw6, BoulderfistOgre1, BoulderfistOgre2, BoulderfistOgre3, BoulderfistOgre4, BoulderfistOgre5, BoulderfistOgre6, WarGolem1, WarGolem2, WarGolem3, WarGolem4, WarGolem5, WarGolem6, CoreHound1, CoreHound2, CoreHound3, CoreHound4, totem111, totem221, totem331);

        }

        private void boton26_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Background = vacio;
        }

        private void boton27_Click(object sender, RoutedEventArgs e)
        {
            if (cartascancha2.Count < 7)
            {
                if (j2.activo == true)
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
                            manobot1[i].Background = wispmano;

                        }
                        if (manos2[i].nombre == "Murloc Raider")
                        {
                            manobot1[i].Background = MurlocRaidermano;
                        }
                        if (manos2[i].nombre == "Bloodfen Raptor")
                        {
                            manobot1[i].Background = BloodfenRaptormano;
                        }
                        if (manos2[i].nombre == "River Crocolisk")
                        {
                            manobot1[i].Background = RiverCrocoliskmano;
                        }
                        if (manos2[i].nombre == "Magma Rager")
                        {
                            manobot1[i].Background = MagmaRagermano;
                        }
                        if (manos2[i].nombre == "Chillwind Yeti")
                        {
                            manobot1[i].Background = ChillwindYetimano;
                        }
                        if (manos2[i].nombre == "Oasis Snapjaw")
                        {
                            manobot1[i].Background = OasisSnapjawmano;
                        }
                        if (manos2[i].nombre == "Boulderfist Ogre")
                        {
                            manobot1[i].Background = BoulderfistOgremano;
                        }
                        if (manos2[i].nombre == "War Golem")
                        {
                            manobot1[i].Background = WarGolemmano;
                        }
                        if (manos2[i].nombre == "Core Hound")
                        {
                            manobot1[i].Background = CoreHoundmano;
                        }
                        manobot1[i].Visibility = Visibility.Visible;
                    }
                    manobot1[manos2.Count()].Visibility = Visibility.Hidden;

                    refreshhmano(manos, manos2, manobot, manobot1, wispmano, MurlocRaidermano, BloodfenRaptormano, RiverCrocoliskmano, MagmaRagermano, ChillwindYetimano, OasisSnapjawmano, BoulderfistOgremano, WarGolemmano, CoreHoundmano, Recruit, j1, j2);
                    refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, totem11, totem22, totem33, totem44, j1, j2, RiverCrocolisk1, BloodfenRaptor1, RiverCrocolisk2, ChillwindYeti1, ChillwindYeti2, ChillwindYeti3, ChillwindYeti4, OasisSnapjaw1, OasisSnapjaw2, OasisSnapjaw3, OasisSnapjaw4, OasisSnapjaw5, OasisSnapjaw6, BoulderfistOgre1, BoulderfistOgre2, BoulderfistOgre3, BoulderfistOgre4, BoulderfistOgre5, BoulderfistOgre6, WarGolem1, WarGolem2, WarGolem3, WarGolem4, WarGolem5, WarGolem6, CoreHound1, CoreHound2, CoreHound3, CoreHound4, totem111, totem221, totem331);

                }
            }

        }
        private void boton27_MouseEnter(object sender, MouseEventArgs e)
        {
            if (manos2[1].nombre == "wisp")
            {
                popo.Background = wispmano;
            }
            if (manos2[1].nombre == "Murloc Raider")
            {
                popo.Background = MurlocRaidermano;
            }
            if (manos2[1].nombre == "Bloodfen Raptor")
            {
                popo.Background = BloodfenRaptormano;
            }
            if (manos2[1].nombre == "River Crocolisk")
            {
                popo.Background = RiverCrocoliskmano;
            }
            if (manos2[1].nombre == "Magma Rager")
            {
                popo.Background = MagmaRagermano;
            }
            if (manos2[1].nombre == "Chillwind Yeti")
            {
                popo.Background = ChillwindYetimano;
            }
            if (manos2[1].nombre == "Oasis Snapjaw")
            {
                popo.Background = OasisSnapjawmano;
            }
            if (manos2[1].nombre == "Boulderfist Ogre")
            {
                popo.Background = BoulderfistOgremano;
            }
            if (manos2[1].nombre == "War Golem")
            {
                popo.Background = WarGolemmano;
            }
            if (manos2[1].nombre == "Core Hound")
            {
                popo.Background = CoreHoundmano;
            }
            refreshhmano(manos, manos2, manobot, manobot1, wispmano, MurlocRaidermano, BloodfenRaptormano, RiverCrocoliskmano, MagmaRagermano, ChillwindYetimano, OasisSnapjawmano, BoulderfistOgremano, WarGolemmano, CoreHoundmano, Recruit, j1, j2);
            refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, totem11, totem22, totem33, totem44, j1, j2, RiverCrocolisk1, BloodfenRaptor1, RiverCrocolisk2, ChillwindYeti1, ChillwindYeti2, ChillwindYeti3, ChillwindYeti4, OasisSnapjaw1, OasisSnapjaw2, OasisSnapjaw3, OasisSnapjaw4, OasisSnapjaw5, OasisSnapjaw6, BoulderfistOgre1, BoulderfistOgre2, BoulderfistOgre3, BoulderfistOgre4, BoulderfistOgre5, BoulderfistOgre6, WarGolem1, WarGolem2, WarGolem3, WarGolem4, WarGolem5, WarGolem6, CoreHound1, CoreHound2, CoreHound3, CoreHound4, totem111, totem221, totem331);

        }

        private void boton27_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Background = vacio;
        }
        private void boton28_Click(object sender, RoutedEventArgs e)
        {
            if (cartascancha2.Count < 7)
            {
                if (j2.activo == true)
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
                            manobot1[i].Background = wispmano;

                        }
                        if (manos2[i].nombre == "Murloc Raider")
                        {
                            manobot1[i].Background = MurlocRaidermano;
                        }
                        if (manos2[i].nombre == "Bloodfen Raptor")
                        {
                            manobot1[i].Background = BloodfenRaptormano;
                        }
                        if (manos2[i].nombre == "River Crocolisk")
                        {
                            manobot1[i].Background = RiverCrocoliskmano;
                        }
                        if (manos2[i].nombre == "Magma Rager")
                        {
                            manobot1[i].Background = MagmaRagermano;
                        }
                        if (manos2[i].nombre == "Chillwind Yeti")
                        {
                            manobot1[i].Background = ChillwindYetimano;
                        }
                        if (manos2[i].nombre == "Oasis Snapjaw")
                        {
                            manobot1[i].Background = OasisSnapjawmano;
                        }
                        if (manos2[i].nombre == "Boulderfist Ogre")
                        {
                            manobot1[i].Background = BoulderfistOgremano;
                        }
                        if (manos2[i].nombre == "War Golem")
                        {
                            manobot1[i].Background = WarGolemmano;
                        }
                        if (manos2[i].nombre == "Core Hound")
                        {
                            manobot1[i].Background = CoreHoundmano;
                        }
                        manobot1[i].Visibility = Visibility.Visible;
                    }
                    manobot1[manos2.Count()].Visibility = Visibility.Hidden;

                    refreshhmano(manos, manos2, manobot, manobot1, wispmano, MurlocRaidermano, BloodfenRaptormano, RiverCrocoliskmano, MagmaRagermano, ChillwindYetimano, OasisSnapjawmano, BoulderfistOgremano, WarGolemmano, CoreHoundmano, Recruit, j1, j2);
                    refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, totem11, totem22, totem33, totem44, j1, j2, RiverCrocolisk1, BloodfenRaptor1, RiverCrocolisk2, ChillwindYeti1, ChillwindYeti2, ChillwindYeti3, ChillwindYeti4, OasisSnapjaw1, OasisSnapjaw2, OasisSnapjaw3, OasisSnapjaw4, OasisSnapjaw5, OasisSnapjaw6, BoulderfistOgre1, BoulderfistOgre2, BoulderfistOgre3, BoulderfistOgre4, BoulderfistOgre5, BoulderfistOgre6, WarGolem1, WarGolem2, WarGolem3, WarGolem4, WarGolem5, WarGolem6, CoreHound1, CoreHound2, CoreHound3, CoreHound4, totem111, totem221, totem331);

                }
            }

        }
        private void boton28_MouseEnter(object sender, MouseEventArgs e)
        {
            if (manos2[2].nombre == "wisp")
            {
                popo.Background = wispmano;
            }
            if (manos2[2].nombre == "Murloc Raider")
            {
                popo.Background = MurlocRaidermano;
            }
            if (manos2[2].nombre == "Bloodfen Raptor")
            {
                popo.Background = BloodfenRaptormano;
            }
            if (manos2[2].nombre == "River Crocolisk")
            {
                popo.Background = RiverCrocoliskmano;
            }
            if (manos2[2].nombre == "Magma Rager")
            {
                popo.Background = MagmaRagermano;
            }
            if (manos2[2].nombre == "Chillwind Yeti")
            {
                popo.Background = ChillwindYetimano;
            }
            if (manos2[2].nombre == "Oasis Snapjaw")
            {
                popo.Background = OasisSnapjawmano;
            }
            if (manos2[2].nombre == "Boulderfist Ogre")
            {
                popo.Background = BoulderfistOgremano;
            }
            if (manos2[2].nombre == "War Golem")
            {
                popo.Background = WarGolemmano;
            }
            if (manos2[2].nombre == "Core Hound")
            {
                popo.Background = CoreHoundmano;
            }
            refreshhmano(manos, manos2, manobot, manobot1, wispmano, MurlocRaidermano, BloodfenRaptormano, RiverCrocoliskmano, MagmaRagermano, ChillwindYetimano, OasisSnapjawmano, BoulderfistOgremano, WarGolemmano, CoreHoundmano, Recruit, j1, j2);
            refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, totem11, totem22, totem33, totem44, j1, j2, RiverCrocolisk1, BloodfenRaptor1, RiverCrocolisk2, ChillwindYeti1, ChillwindYeti2, ChillwindYeti3, ChillwindYeti4, OasisSnapjaw1, OasisSnapjaw2, OasisSnapjaw3, OasisSnapjaw4, OasisSnapjaw5, OasisSnapjaw6, BoulderfistOgre1, BoulderfistOgre2, BoulderfistOgre3, BoulderfistOgre4, BoulderfistOgre5, BoulderfistOgre6, WarGolem1, WarGolem2, WarGolem3, WarGolem4, WarGolem5, WarGolem6, CoreHound1, CoreHound2, CoreHound3, CoreHound4, totem111, totem221, totem331);

        }

        private void boton28_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Background = vacio;
        }
        private void boton29_Click(object sender, RoutedEventArgs e)
        {
            if (cartascancha2.Count < 7)
            {
                if (j2.activo == true)
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
                            manobot1[i].Background = wispmano;

                        }
                        if (manos2[i].nombre == "Murloc Raider")
                        {
                            manobot1[i].Background = MurlocRaidermano;
                        }
                        if (manos2[i].nombre == "Bloodfen Raptor")
                        {
                            manobot1[i].Background = BloodfenRaptormano;
                        }
                        if (manos2[i].nombre == "River Crocolisk")
                        {
                            manobot1[i].Background = RiverCrocoliskmano;
                        }
                        if (manos2[i].nombre == "Magma Rager")
                        {
                            manobot1[i].Background = MagmaRagermano;
                        }
                        if (manos2[i].nombre == "Chillwind Yeti")
                        {
                            manobot1[i].Background = ChillwindYetimano;
                        }
                        if (manos2[i].nombre == "Oasis Snapjaw")
                        {
                            manobot1[i].Background = OasisSnapjawmano;
                        }
                        if (manos2[i].nombre == "Boulderfist Ogre")
                        {
                            manobot1[i].Background = BoulderfistOgremano;
                        }
                        if (manos2[i].nombre == "War Golem")
                        {
                            manobot1[i].Background = WarGolemmano;
                        }
                        if (manos2[i].nombre == "Core Hound")
                        {
                            manobot1[i].Background = CoreHoundmano;
                        }
                        manobot1[i].Visibility = Visibility.Visible;
                    }
                    manobot1[manos2.Count()].Visibility = Visibility.Hidden;

                    refreshhmano(manos, manos2, manobot, manobot1, wispmano, MurlocRaidermano, BloodfenRaptormano, RiverCrocoliskmano, MagmaRagermano, ChillwindYetimano, OasisSnapjawmano, BoulderfistOgremano, WarGolemmano, CoreHoundmano, Recruit, j1, j2);
                    refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, totem11, totem22, totem33, totem44, j1, j2, RiverCrocolisk1, BloodfenRaptor1, RiverCrocolisk2, ChillwindYeti1, ChillwindYeti2, ChillwindYeti3, ChillwindYeti4, OasisSnapjaw1, OasisSnapjaw2, OasisSnapjaw3, OasisSnapjaw4, OasisSnapjaw5, OasisSnapjaw6, BoulderfistOgre1, BoulderfistOgre2, BoulderfistOgre3, BoulderfistOgre4, BoulderfistOgre5, BoulderfistOgre6, WarGolem1, WarGolem2, WarGolem3, WarGolem4, WarGolem5, WarGolem6, CoreHound1, CoreHound2, CoreHound3, CoreHound4, totem111, totem221, totem331);

                }
            }

        }
        private void boton29_MouseEnter(object sender, MouseEventArgs e)
        {
           
            if (manos2[3].nombre == "Murloc Raider")
            {
                popo.Background = MurlocRaidermano;
            }
            if (manos2[3].nombre == "wisp")
            {
                popo.Background = wispmano;
            }
            if (manos2[3].nombre == "Bloodfen Raptor")
            {
                popo.Background = BloodfenRaptormano;
            }
            if (manos2[3].nombre == "River Crocolisk")
            {
                popo.Background = RiverCrocoliskmano;
            }
            if (manos2[3].nombre == "Magma Rager")
            {
                popo.Background = MagmaRagermano;
            }
            if (manos2[3].nombre == "Chillwind Yeti")
            {
                popo.Background = ChillwindYetimano;
            }
            if (manos2[3].nombre == "Oasis Snapjaw")
            {
                popo.Background = OasisSnapjawmano;
            }
            if (manos2[3].nombre == "Boulderfist Ogre")
            {
                popo.Background = BoulderfistOgremano;
            }
            if (manos2[3].nombre == "War Golem")
            {
                popo.Background = WarGolemmano;
            }
            if (manos2[3].nombre == "Core Hound")
            {
                popo.Background = CoreHoundmano;
            }
            refreshhmano(manos, manos2, manobot, manobot1, wispmano, MurlocRaidermano, BloodfenRaptormano, RiverCrocoliskmano, MagmaRagermano, ChillwindYetimano, OasisSnapjawmano, BoulderfistOgremano, WarGolemmano, CoreHoundmano, Recruit, j1, j2);
            refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, totem11, totem22, totem33, totem44, j1, j2, RiverCrocolisk1, BloodfenRaptor1, RiverCrocolisk2, ChillwindYeti1, ChillwindYeti2, ChillwindYeti3, ChillwindYeti4, OasisSnapjaw1, OasisSnapjaw2, OasisSnapjaw3, OasisSnapjaw4, OasisSnapjaw5, OasisSnapjaw6, BoulderfistOgre1, BoulderfistOgre2, BoulderfistOgre3, BoulderfistOgre4, BoulderfistOgre5, BoulderfistOgre6, WarGolem1, WarGolem2, WarGolem3, WarGolem4, WarGolem5, WarGolem6, CoreHound1, CoreHound2, CoreHound3, CoreHound4, totem111, totem221, totem331);

        }

        private void boton29_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Background = vacio;
        }
        private void boton30_Click(object sender, RoutedEventArgs e)
        {
            if (cartascancha2.Count < 7)
            {
                if (j2.activo == true)
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
                            manobot1[i].Background = wispmano;

                        }
                        if (manos2[i].nombre == "Murloc Raider")
                        {
                            manobot1[i].Background = MurlocRaidermano;
                        }
                        if (manos2[i].nombre == "Bloodfen Raptor")
                        {
                            manobot1[i].Background = BloodfenRaptormano;
                        }
                        if (manos2[i].nombre == "River Crocolisk")
                        {
                            manobot1[i].Background = RiverCrocoliskmano;
                        }
                        if (manos2[i].nombre == "Magma Rager")
                        {
                            manobot1[i].Background = MagmaRagermano;
                        }
                        if (manos2[i].nombre == "Chillwind Yeti")
                        {
                            manobot1[i].Background = ChillwindYetimano;
                        }
                        if (manos2[i].nombre == "Oasis Snapjaw")
                        {
                            manobot1[i].Background = OasisSnapjawmano;
                        }
                        if (manos2[i].nombre == "Boulderfist Ogre")
                        {
                            manobot1[i].Background = BoulderfistOgremano;
                        }
                        if (manos2[i].nombre == "War Golem")
                        {
                            manobot1[i].Background = WarGolemmano;
                        }
                        if (manos2[i].nombre == "Core Hound")
                        {
                            manobot1[i].Background = CoreHoundmano;
                        }
                        manobot1[i].Visibility = Visibility.Visible;
                    }
                    manobot1[manos2.Count()].Visibility = Visibility.Hidden;

                    refreshhmano(manos, manos2, manobot, manobot1, wispmano, MurlocRaidermano, BloodfenRaptormano, RiverCrocoliskmano, MagmaRagermano, ChillwindYetimano, OasisSnapjawmano, BoulderfistOgremano, WarGolemmano, CoreHoundmano, Recruit, j1, j2);
                    refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, totem11, totem22, totem33, totem44, j1, j2, RiverCrocolisk1, BloodfenRaptor1, RiverCrocolisk2, ChillwindYeti1, ChillwindYeti2, ChillwindYeti3, ChillwindYeti4, OasisSnapjaw1, OasisSnapjaw2, OasisSnapjaw3, OasisSnapjaw4, OasisSnapjaw5, OasisSnapjaw6, BoulderfistOgre1, BoulderfistOgre2, BoulderfistOgre3, BoulderfistOgre4, BoulderfistOgre5, BoulderfistOgre6, WarGolem1, WarGolem2, WarGolem3, WarGolem4, WarGolem5, WarGolem6, CoreHound1, CoreHound2, CoreHound3, CoreHound4, totem111, totem221, totem331);

                }
            }

        }
        private void boton30_MouseEnter(object sender, MouseEventArgs e)
        {
           
            if (manos2[4].nombre == "Murloc Raider")
            {
                popo.Background = MurlocRaidermano;
            }
            if (manos2[4].nombre == "wisp")
            {
                popo.Background = wispmano;
            }
            if (manos2[4].nombre == "Bloodfen Raptor")
            {
                popo.Background = BloodfenRaptormano;
            }
            if (manos2[4].nombre == "River Crocolisk")
            {
                popo.Background = RiverCrocoliskmano;
            }
            if (manos2[4].nombre == "Magma Rager")
            {
                popo.Background = MagmaRagermano;
            }
            if (manos2[4].nombre == "Chillwind Yeti")
            {
                popo.Background = ChillwindYetimano;
            }
            if (manos2[4].nombre == "Oasis Snapjaw")
            {
                popo.Background = OasisSnapjawmano;
            }
            if (manos2[4].nombre == "Boulderfist Ogre")
            {
                popo.Background = BoulderfistOgremano;
            }
            if (manos2[4].nombre == "War Golem")
            {
                popo.Background = WarGolemmano;
            }
            if (manos2[4].nombre == "Core Hound")
            {
                popo.Background = CoreHoundmano;
            }
            refreshhmano(manos, manos2, manobot, manobot1, wispmano, MurlocRaidermano, BloodfenRaptormano, RiverCrocoliskmano, MagmaRagermano, ChillwindYetimano, OasisSnapjawmano, BoulderfistOgremano, WarGolemmano, CoreHoundmano, Recruit, j1, j2);
            refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, totem11, totem22, totem33, totem44, j1, j2, RiverCrocolisk1, BloodfenRaptor1, RiverCrocolisk2, ChillwindYeti1, ChillwindYeti2, ChillwindYeti3, ChillwindYeti4, OasisSnapjaw1, OasisSnapjaw2, OasisSnapjaw3, OasisSnapjaw4, OasisSnapjaw5, OasisSnapjaw6, BoulderfistOgre1, BoulderfistOgre2, BoulderfistOgre3, BoulderfistOgre4, BoulderfistOgre5, BoulderfistOgre6, WarGolem1, WarGolem2, WarGolem3, WarGolem4, WarGolem5, WarGolem6, CoreHound1, CoreHound2, CoreHound3, CoreHound4, totem111, totem221, totem331);

        }

        private void boton30_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Background = vacio;
        }
        private void boton31_Click(object sender, RoutedEventArgs e)
        {
            if (cartascancha2.Count < 7)
            {
                if (j2.activo == true)
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
                            manobot1[i].Background = wispmano;

                        }
                        if (manos2[i].nombre == "Murloc Raider")
                        {
                            manobot1[i].Background = MurlocRaidermano;
                        }
                        if (manos2[i].nombre == "Bloodfen Raptor")
                        {
                            manobot1[i].Background = BloodfenRaptormano;
                        }
                        if (manos2[i].nombre == "River Crocolisk")
                        {
                            manobot1[i].Background = RiverCrocoliskmano;
                        }
                        if (manos2[i].nombre == "Magma Rager")
                        {
                            manobot1[i].Background = MagmaRagermano;
                        }
                        if (manos2[i].nombre == "Chillwind Yeti")
                        {
                            manobot1[i].Background = ChillwindYetimano;
                        }
                        if (manos2[i].nombre == "Oasis Snapjaw")
                        {
                            manobot1[i].Background = OasisSnapjawmano;
                        }
                        if (manos2[i].nombre == "Boulderfist Ogre")
                        {
                            manobot1[i].Background = BoulderfistOgremano;
                        }
                        if (manos2[i].nombre == "War Golem")
                        {
                            manobot1[i].Background = WarGolemmano;
                        }
                        if (manos2[i].nombre == "Core Hound")
                        {
                            manobot1[i].Background = CoreHoundmano;
                        }
                        manobot1[i].Visibility = Visibility.Visible;
                    }
                    manobot1[manos2.Count()].Visibility = Visibility.Hidden;

                    refreshhmano(manos, manos2, manobot, manobot1, wispmano, MurlocRaidermano, BloodfenRaptormano, RiverCrocoliskmano, MagmaRagermano, ChillwindYetimano, OasisSnapjawmano, BoulderfistOgremano, WarGolemmano, CoreHoundmano, Recruit, j1, j2);
                    refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, totem11, totem22, totem33, totem44, j1, j2, RiverCrocolisk1, BloodfenRaptor1, RiverCrocolisk2, ChillwindYeti1, ChillwindYeti2, ChillwindYeti3, ChillwindYeti4, OasisSnapjaw1, OasisSnapjaw2, OasisSnapjaw3, OasisSnapjaw4, OasisSnapjaw5, OasisSnapjaw6, BoulderfistOgre1, BoulderfistOgre2, BoulderfistOgre3, BoulderfistOgre4, BoulderfistOgre5, BoulderfistOgre6, WarGolem1, WarGolem2, WarGolem3, WarGolem4, WarGolem5, WarGolem6, CoreHound1, CoreHound2, CoreHound3, CoreHound4, totem111, totem221, totem331);

                }
            }

        }
        private void boton31_MouseEnter(object sender, MouseEventArgs e)
        {
            if (manos2[5].nombre == "wisp")
            {
                popo.Background = wispmano;
            }
            if (manos2[5].nombre == "Murloc Raider")
            {
                popo.Background = MurlocRaidermano;
            }
            if (manos2[5].nombre == "Bloodfen Raptor")
            {
                popo.Background = BloodfenRaptormano;
            }
            if (manos2[5].nombre == "River Crocolisk")
            {
                popo.Background = RiverCrocoliskmano;
            }
            if (manos2[5].nombre == "Magma Rager")
            {
                popo.Background = MagmaRagermano;
            }
            if (manos2[5].nombre == "Chillwind Yeti")
            {
                popo.Background = ChillwindYetimano;
            }
            if (manos2[5].nombre == "Oasis Snapjaw")
            {
                popo.Background = OasisSnapjawmano;
            }
            if (manos2[5].nombre == "Boulderfist Ogre")
            {
                popo.Background = BoulderfistOgremano;
            }
            if (manos2[5].nombre == "War Golem")
            {
                popo.Background = WarGolemmano;
            }
            if (manos2[5].nombre == "Core Hound")
            {
                popo.Background = CoreHoundmano;
            }
            refreshhmano(manos, manos2, manobot, manobot1, wispmano, MurlocRaidermano, BloodfenRaptormano, RiverCrocoliskmano, MagmaRagermano, ChillwindYetimano, OasisSnapjawmano, BoulderfistOgremano, WarGolemmano, CoreHoundmano, Recruit, j1, j2);
            refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, totem11, totem22, totem33, totem44, j1, j2, RiverCrocolisk1, BloodfenRaptor1, RiverCrocolisk2, ChillwindYeti1, ChillwindYeti2, ChillwindYeti3, ChillwindYeti4, OasisSnapjaw1, OasisSnapjaw2, OasisSnapjaw3, OasisSnapjaw4, OasisSnapjaw5, OasisSnapjaw6, BoulderfistOgre1, BoulderfistOgre2, BoulderfistOgre3, BoulderfistOgre4, BoulderfistOgre5, BoulderfistOgre6, WarGolem1, WarGolem2, WarGolem3, WarGolem4, WarGolem5, WarGolem6, CoreHound1, CoreHound2, CoreHound3, CoreHound4, totem111, totem221, totem331);

        }

        private void boton31_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Background = vacio;
        }
        private void boton32_Click(object sender, RoutedEventArgs e)
        {
            if (cartascancha2.Count < 7)
            {
                if (j2.activo == true)
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
                            manobot1[i].Background = wispmano;

                        }
                        if (manos2[i].nombre == "Murloc Raider")
                        {
                            manobot1[i].Background = MurlocRaidermano;
                        }
                        if (manos2[i].nombre == "Bloodfen Raptor")
                        {
                            manobot1[i].Background = BloodfenRaptormano;
                        }
                        if (manos2[i].nombre == "River Crocolisk")
                        {
                            manobot1[i].Background = RiverCrocoliskmano;
                        }
                        if (manos2[i].nombre == "Magma Rager")
                        {
                            manobot1[i].Background = MagmaRagermano;
                        }
                        if (manos2[i].nombre == "Chillwind Yeti")
                        {
                            manobot1[i].Background = ChillwindYetimano;
                        }
                        if (manos2[i].nombre == "Oasis Snapjaw")
                        {
                            manobot1[i].Background = OasisSnapjawmano;
                        }
                        if (manos2[i].nombre == "Boulderfist Ogre")
                        {
                            manobot1[i].Background = BoulderfistOgremano;
                        }
                        if (manos2[i].nombre == "War Golem")
                        {
                            manobot1[i].Background = WarGolemmano;
                        }
                        if (manos2[i].nombre == "Core Hound")
                        {
                            manobot1[i].Background = CoreHoundmano;
                        }
                        manobot1[i].Visibility = Visibility.Visible;
                    }
                    manobot1[manos2.Count()].Visibility = Visibility.Hidden;

                    refreshhmano(manos, manos2, manobot, manobot1, wispmano, MurlocRaidermano, BloodfenRaptormano, RiverCrocoliskmano, MagmaRagermano, ChillwindYetimano, OasisSnapjawmano, BoulderfistOgremano, WarGolemmano, CoreHoundmano, Recruit, j1, j2);
                    refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, totem11, totem22, totem33, totem44, j1, j2, RiverCrocolisk1, BloodfenRaptor1, RiverCrocolisk2, ChillwindYeti1, ChillwindYeti2, ChillwindYeti3, ChillwindYeti4, OasisSnapjaw1, OasisSnapjaw2, OasisSnapjaw3, OasisSnapjaw4, OasisSnapjaw5, OasisSnapjaw6, BoulderfistOgre1, BoulderfistOgre2, BoulderfistOgre3, BoulderfistOgre4, BoulderfistOgre5, BoulderfistOgre6, WarGolem1, WarGolem2, WarGolem3, WarGolem4, WarGolem5, WarGolem6, CoreHound1, CoreHound2, CoreHound3, CoreHound4, totem111, totem221, totem331);

                }
            }

        }
        private void boton32_MouseEnter(object sender, MouseEventArgs e)
        {

            if (manos2[6].nombre == "Murloc Raider")
            {
                popo.Background = MurlocRaidermano;
            }
            if (manos2[6].nombre == "wisp")
            {
                popo.Background = wispmano;
            }
            if (manos2[6].nombre == "Bloodfen Raptor")
            {
                popo.Background = BloodfenRaptormano;
            }
            if (manos2[6].nombre == "River Crocolisk")
            {
                popo.Background = RiverCrocoliskmano;
            }
            if (manos2[6].nombre == "Magma Rager")
            {
                popo.Background = MagmaRagermano;
            }
            if (manos2[6].nombre == "Chillwind Yeti")
            {
                popo.Background = ChillwindYetimano;
            }
            if (manos2[6].nombre == "Oasis Snapjaw")
            {
                popo.Background = OasisSnapjawmano;
            }
            if (manos2[6].nombre == "Boulderfist Ogre")
            {
                popo.Background = BoulderfistOgremano;
            }
            if (manos2[6].nombre == "War Golem")
            {
                popo.Background = WarGolemmano;
            }
            if (manos2[6].nombre == "Core Hound")
            {
                popo.Background = CoreHoundmano;
            }
            refreshhmano(manos, manos2, manobot, manobot1, wispmano, MurlocRaidermano, BloodfenRaptormano, RiverCrocoliskmano, MagmaRagermano, ChillwindYetimano, OasisSnapjawmano, BoulderfistOgremano, WarGolemmano, CoreHoundmano, Recruit, j1, j2);
            refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, totem11, totem22, totem33, totem44, j1, j2, RiverCrocolisk1, BloodfenRaptor1, RiverCrocolisk2, ChillwindYeti1, ChillwindYeti2, ChillwindYeti3, ChillwindYeti4, OasisSnapjaw1, OasisSnapjaw2, OasisSnapjaw3, OasisSnapjaw4, OasisSnapjaw5, OasisSnapjaw6, BoulderfistOgre1, BoulderfistOgre2, BoulderfistOgre3, BoulderfistOgre4, BoulderfistOgre5, BoulderfistOgre6, WarGolem1, WarGolem2, WarGolem3, WarGolem4, WarGolem5, WarGolem6, CoreHound1, CoreHound2, CoreHound3, CoreHound4, totem111, totem221, totem331);

        }

        private void boton32_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Background = vacio;
        }
        private void boton33_Click(object sender, RoutedEventArgs e)
        {
            if (cartascancha2.Count < 7)
            {
                if (j2.activo == true)
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
                            manobot1[i].Background = wispmano;

                        }
                        if (manos2[i].nombre == "Murloc Raider")
                        {
                            manobot1[i].Background = MurlocRaidermano;
                        }
                        if (manos2[i].nombre == "Bloodfen Raptor")
                        {
                            manobot1[i].Background = BloodfenRaptormano;
                        }
                        if (manos2[i].nombre == "River Crocolisk")
                        {
                            manobot1[i].Background = RiverCrocoliskmano;
                        }
                        if (manos2[i].nombre == "Magma Rager")
                        {
                            manobot1[i].Background = MagmaRagermano;
                        }
                        if (manos2[i].nombre == "Chillwind Yeti")
                        {
                            manobot1[i].Background = ChillwindYetimano;
                        }
                        if (manos2[i].nombre == "Oasis Snapjaw")
                        {
                            manobot1[i].Background = OasisSnapjawmano;
                        }
                        if (manos2[i].nombre == "Boulderfist Ogre")
                        {
                            manobot1[i].Background = BoulderfistOgremano;
                        }
                        if (manos2[i].nombre == "War Golem")
                        {
                            manobot1[i].Background = WarGolemmano;
                        }
                        if (manos2[i].nombre == "Core Hound")
                        {
                            manobot1[i].Background = CoreHoundmano;
                        }
                        manobot1[i].Visibility = Visibility.Visible;
                    }
                    manobot1[manos2.Count()].Visibility = Visibility.Hidden;

                    refreshhmano(manos, manos2, manobot, manobot1, wispmano, MurlocRaidermano, BloodfenRaptormano, RiverCrocoliskmano, MagmaRagermano, ChillwindYetimano, OasisSnapjawmano, BoulderfistOgremano, WarGolemmano, CoreHoundmano, Recruit, j1, j2);
                    refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, totem11, totem22, totem33, totem44, j1, j2, RiverCrocolisk1, BloodfenRaptor1, RiverCrocolisk2, ChillwindYeti1, ChillwindYeti2, ChillwindYeti3, ChillwindYeti4, OasisSnapjaw1, OasisSnapjaw2, OasisSnapjaw3, OasisSnapjaw4, OasisSnapjaw5, OasisSnapjaw6, BoulderfistOgre1, BoulderfistOgre2, BoulderfistOgre3, BoulderfistOgre4, BoulderfistOgre5, BoulderfistOgre6, WarGolem1, WarGolem2, WarGolem3, WarGolem4, WarGolem5, WarGolem6, CoreHound1, CoreHound2, CoreHound3, CoreHound4, totem111, totem221, totem331);

                }
            }

        }
        private void boton33_MouseEnter(object sender, MouseEventArgs e)
        {
            if (manos2[7].nombre == "wisp")
            {
                popo.Background = wispmano;
            }
            if (manos2[7].nombre == "Murloc Raider")
            {
                popo.Background = MurlocRaidermano;
            }
            if (manos2[7].nombre == "Bloodfen Raptor")
            {
                popo.Background = BloodfenRaptormano;
            }
            if (manos2[7].nombre == "River Crocolisk")
            {
                popo.Background = RiverCrocoliskmano;
            }
            if (manos2[7].nombre == "Magma Rager")
            {
                popo.Background = MagmaRagermano;
            }
            if (manos2[7].nombre == "Chillwind Yeti")
            {
                popo.Background = ChillwindYetimano;
            }
            if (manos2[7].nombre == "Oasis Snapjaw")
            {
                popo.Background = OasisSnapjawmano;
            }
            if (manos2[7].nombre == "Boulderfist Ogre")
            {
                popo.Background = BoulderfistOgremano;
            }
            if (manos2[7].nombre == "War Golem")
            {
                popo.Background = WarGolemmano;
            }
            if (manos2[7].nombre == "Core Hound")
            {
                popo.Background = CoreHoundmano;
            }
            refreshhmano(manos, manos2, manobot, manobot1, wispmano, MurlocRaidermano, BloodfenRaptormano, RiverCrocoliskmano, MagmaRagermano, ChillwindYetimano, OasisSnapjawmano, BoulderfistOgremano, WarGolemmano, CoreHoundmano, Recruit, j1, j2);
            refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, totem11, totem22, totem33, totem44, j1, j2, RiverCrocolisk1, BloodfenRaptor1, RiverCrocolisk2, ChillwindYeti1, ChillwindYeti2, ChillwindYeti3, ChillwindYeti4, OasisSnapjaw1, OasisSnapjaw2, OasisSnapjaw3, OasisSnapjaw4, OasisSnapjaw5, OasisSnapjaw6, BoulderfistOgre1, BoulderfistOgre2, BoulderfistOgre3, BoulderfistOgre4, BoulderfistOgre5, BoulderfistOgre6, WarGolem1, WarGolem2, WarGolem3, WarGolem4, WarGolem5, WarGolem6, CoreHound1, CoreHound2, CoreHound3, CoreHound4, totem111, totem221, totem331);

        }

        private void boton33_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Background = vacio;
        }
        private void boton24_Copy3_Click(object sender, RoutedEventArgs e)
        {
            if (cartascancha2.Count < 7)
            {
                if (j2.activo == true)
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
                            manobot1[i].Background = wispmano;

                        }
                        if (manos2[i].nombre == "Murloc Raider")
                        {
                            manobot1[i].Background = MurlocRaidermano;
                        }
                        if (manos2[i].nombre == "Bloodfen Raptor")
                        {
                            manobot1[i].Background = BloodfenRaptormano;
                        }
                        if (manos2[i].nombre == "River Crocolisk")
                        {
                            manobot1[i].Background = RiverCrocoliskmano;
                        }
                        if (manos2[i].nombre == "Magma Rager")
                        {
                            manobot1[i].Background = MagmaRagermano;
                        }
                        if (manos2[i].nombre == "Chillwind Yeti")
                        {
                            manobot1[i].Background = ChillwindYetimano;
                        }
                        if (manos2[i].nombre == "Oasis Snapjaw")
                        {
                            manobot1[i].Background = OasisSnapjawmano;
                        }
                        if (manos2[i].nombre == "Boulderfist Ogre")
                        {
                            manobot1[i].Background = BoulderfistOgremano;
                        }
                        if (manos2[i].nombre == "War Golem")
                        {
                            manobot1[i].Background = WarGolemmano;
                        }
                        if (manos2[i].nombre == "Core Hound")
                        {
                            manobot1[i].Background = CoreHoundmano;
                        }
                        manobot1[i].Visibility = Visibility.Visible;
                    }
                    manobot1[manos2.Count()].Visibility = Visibility.Hidden;

                    refreshhmano(manos, manos2, manobot, manobot1, wispmano, MurlocRaidermano, BloodfenRaptormano, RiverCrocoliskmano, MagmaRagermano, ChillwindYetimano, OasisSnapjawmano, BoulderfistOgremano, WarGolemmano, CoreHoundmano, Recruit, j1, j2);
                    refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, totem11, totem22, totem33, totem44, j1, j2, RiverCrocolisk1, BloodfenRaptor1, RiverCrocolisk2, ChillwindYeti1, ChillwindYeti2, ChillwindYeti3, ChillwindYeti4, OasisSnapjaw1, OasisSnapjaw2, OasisSnapjaw3, OasisSnapjaw4, OasisSnapjaw5, OasisSnapjaw6, BoulderfistOgre1, BoulderfistOgre2, BoulderfistOgre3, BoulderfistOgre4, BoulderfistOgre5, BoulderfistOgre6, WarGolem1, WarGolem2, WarGolem3, WarGolem4, WarGolem5, WarGolem6, CoreHound1, CoreHound2, CoreHound3, CoreHound4, totem111, totem221, totem331);

                }
            }

        }
        private void boton243_MouseEnter(object sender, MouseEventArgs e)
        {

            if (manos2[8].nombre == "Murloc Raider")
            {
                popo.Background = MurlocRaidermano;
            }
            if (manos2[8].nombre == "wisp")
            {
                popo.Background = wispmano;
            }
            if (manos2[8].nombre == "Bloodfen Raptor")
            {
                popo.Background = BloodfenRaptormano;
            }
            if (manos2[8].nombre == "River Crocolisk")
            {
                popo.Background = RiverCrocoliskmano;
            }
            if (manos2[8].nombre == "Magma Rager")
            {
                popo.Background = MagmaRagermano;
            }
            if (manos2[8].nombre == "Chillwind Yeti")
            {
                popo.Background = ChillwindYetimano;
            }
            if (manos2[8].nombre == "Oasis Snapjaw")
            {
                popo.Background = OasisSnapjawmano;
            }
            if (manos2[8].nombre == "Boulderfist Ogre")
            {
                popo.Background = BoulderfistOgremano;
            }
            if (manos2[8].nombre == "War Golem")
            {
                popo.Background = WarGolemmano;
            }
            if (manos2[8].nombre == "Core Hound")
            {
                popo.Background = CoreHoundmano;
            }
            refreshhmano(manos, manos2, manobot, manobot1, wispmano, MurlocRaidermano, BloodfenRaptormano, RiverCrocoliskmano, MagmaRagermano, ChillwindYetimano, OasisSnapjawmano, BoulderfistOgremano, WarGolemmano, CoreHoundmano, Recruit, j1, j2);
            refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, totem11, totem22, totem33, totem44, j1, j2, RiverCrocolisk1, BloodfenRaptor1, RiverCrocolisk2, ChillwindYeti1, ChillwindYeti2, ChillwindYeti3, ChillwindYeti4, OasisSnapjaw1, OasisSnapjaw2, OasisSnapjaw3, OasisSnapjaw4, OasisSnapjaw5, OasisSnapjaw6, BoulderfistOgre1, BoulderfistOgre2, BoulderfistOgre3, BoulderfistOgre4, BoulderfistOgre5, BoulderfistOgre6, WarGolem1, WarGolem2, WarGolem3, WarGolem4, WarGolem5, WarGolem6, CoreHound1, CoreHound2, CoreHound3, CoreHound4, totem111, totem221, totem331);

        }

        private void boton243_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Background = vacio;
        }
        private void boton24_Copy4_Click(object sender, RoutedEventArgs e)
        {
            if (cartascancha2.Count < 7)
            {
                if (j2.activo == true)
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
                            manobot1[i].Background = wispmano;

                        }
                        if (manos2[i].nombre == "Murloc Raider")
                        {
                            manobot1[i].Background = MurlocRaidermano;
                        }
                        if (manos2[i].nombre == "Bloodfen Raptor")
                        {
                            manobot1[i].Background = BloodfenRaptormano;
                        }
                        if (manos2[i].nombre == "River Crocolisk")
                        {
                            manobot1[i].Background = RiverCrocoliskmano;
                        }
                        if (manos2[i].nombre == "Magma Rager")
                        {
                            manobot1[i].Background = MagmaRagermano;
                        }
                        if (manos2[i].nombre == "Chillwind Yeti")
                        {
                            manobot1[i].Background = ChillwindYetimano;
                        }
                        if (manos2[i].nombre == "Oasis Snapjaw")
                        {
                            manobot1[i].Background = OasisSnapjawmano;
                        }
                        if (manos2[i].nombre == "Boulderfist Ogre")
                        {
                            manobot1[i].Background = BoulderfistOgremano;
                        }
                        if (manos2[i].nombre == "War Golem")
                        {
                            manobot1[i].Background = WarGolemmano;
                        }
                        if (manos2[i].nombre == "Core Hound")
                        {
                            manobot1[i].Background = CoreHoundmano;
                        }
                        manobot1[i].Visibility = Visibility.Visible;
                    }
                    manobot1[manos2.Count()].Visibility = Visibility.Hidden;

                    refreshhmano(manos, manos2, manobot, manobot1, wispmano, MurlocRaidermano, BloodfenRaptormano, RiverCrocoliskmano, MagmaRagermano, ChillwindYetimano, OasisSnapjawmano, BoulderfistOgremano, WarGolemmano, CoreHoundmano, Recruit, j1, j2);
                    refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, totem11, totem22, totem33, totem44, j1, j2, RiverCrocolisk1, BloodfenRaptor1, RiverCrocolisk2, ChillwindYeti1, ChillwindYeti2, ChillwindYeti3, ChillwindYeti4, OasisSnapjaw1, OasisSnapjaw2, OasisSnapjaw3, OasisSnapjaw4, OasisSnapjaw5, OasisSnapjaw6, BoulderfistOgre1, BoulderfistOgre2, BoulderfistOgre3, BoulderfistOgre4, BoulderfistOgre5, BoulderfistOgre6, WarGolem1, WarGolem2, WarGolem3, WarGolem4, WarGolem5, WarGolem6, CoreHound1, CoreHound2, CoreHound3, CoreHound4, totem111, totem221, totem331);

                }
            }

        }
        private void boton244_MouseEnter(object sender, MouseEventArgs e)
        {
            if (manos2[9].nombre == "wisp")
            {
                popo.Background = wispmano;
            }
            if (manos2[9].nombre == "Murloc Raider")
            {
                popo.Background = MurlocRaidermano;
            }
            if (manos2[9].nombre == "Bloodfen Raptor")
            {
                popo.Background = BloodfenRaptormano;
            }
            if (manos2[9].nombre == "River Crocolisk")
            {
                popo.Background = RiverCrocoliskmano;
            }
            if (manos2[9].nombre == "Magma Rager")
            {
                popo.Background = MagmaRagermano;
            }
            if (manos2[9].nombre == "Chillwind Yeti")
            {
                popo.Background = ChillwindYetimano;
            }
            if (manos2[9].nombre == "Oasis Snapjaw")
            {
                popo.Background = OasisSnapjawmano;
            }
            if (manos2[9].nombre == "Boulderfist Ogre")
            {
                popo.Background = BoulderfistOgremano;
            }
            if (manos2[9].nombre == "War Golem")
            {
                popo.Background = WarGolemmano;
            }
            if (manos2[9].nombre == "Core Hound")
            {
                popo.Background = CoreHoundmano;
            }
            refreshhmano(manos, manos2, manobot, manobot1, wispmano, MurlocRaidermano, BloodfenRaptormano, RiverCrocoliskmano, MagmaRagermano, ChillwindYetimano, OasisSnapjawmano, BoulderfistOgremano, WarGolemmano, CoreHoundmano, Recruit, j1, j2);
            refreshh(cartascancha, cartascancha2, xx, a2, wisp, MurlocRaider, BloodfenRaptor, RiverCrocolisk, MagmaRager, ChillwindYeti, OasisSnapjaw, BoulderfistOgre, WarGolem, CoreHound, Recruit, totem11, totem22, totem33, totem44, j1, j2, RiverCrocolisk1, BloodfenRaptor1, RiverCrocolisk2, ChillwindYeti1, ChillwindYeti2, ChillwindYeti3, ChillwindYeti4, OasisSnapjaw1, OasisSnapjaw2, OasisSnapjaw3, OasisSnapjaw4, OasisSnapjaw5, OasisSnapjaw6, BoulderfistOgre1, BoulderfistOgre2, BoulderfistOgre3, BoulderfistOgre4, BoulderfistOgre5, BoulderfistOgre6, WarGolem1, WarGolem2, WarGolem3, WarGolem4, WarGolem5, WarGolem6, CoreHound1, CoreHound2, CoreHound3, CoreHound4, totem111, totem221, totem331);

        }

        private void boton244_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Background = vacio;
        }

        private void boton000_Click(object sender, RoutedEventArgs e)
        {
            manos.RemoveAt(0);
            cambioss[manos.Count()].Visibility = Visibility.Hidden;
            refreshhmano(manos, manos2, cambioss, manobot1, wispmano, MurlocRaidermano, BloodfenRaptormano, RiverCrocoliskmano, MagmaRagermano, ChillwindYetimano, OasisSnapjawmano, BoulderfistOgremano, WarGolemmano, CoreHoundmano, Recruit, j1, j2);

        }

        private void boton001_Click(object sender, RoutedEventArgs e)
        {
            manos.RemoveAt(1);
            refreshhmano(manos, manos2, cambioss, manobot1, wispmano, MurlocRaidermano, BloodfenRaptormano, RiverCrocoliskmano, MagmaRagermano, ChillwindYetimano, OasisSnapjawmano, BoulderfistOgremano, WarGolemmano, CoreHoundmano, Recruit, j1, j2);

        }

        private void boton004_Click(object sender, RoutedEventArgs e)
        {
            manos.RemoveAt(2);
            refreshhmano(manos, manos2, cambioss, manobot1, wispmano, MurlocRaidermano, BloodfenRaptormano, RiverCrocoliskmano, MagmaRagermano, ChillwindYetimano, OasisSnapjawmano, BoulderfistOgremano, WarGolemmano, CoreHoundmano, Recruit, j1, j2);

        }



        private void boton0001_Click(object sender, RoutedEventArgs e)
        {
            manos2.RemoveAt(1);
            refreshhmano(manos2, manos2, cambioss1, cambioss1, wispmano, MurlocRaidermano, BloodfenRaptormano, RiverCrocoliskmano, MagmaRagermano, ChillwindYetimano, OasisSnapjawmano, BoulderfistOgremano, WarGolemmano, CoreHoundmano, Recruit, j1, j2);

        }

        private void boton0002_Click(object sender, RoutedEventArgs e)
        {
            manos2.RemoveAt(2);
            refreshhmano(manos2, manos2, cambioss1, cambioss1, wispmano, MurlocRaidermano, BloodfenRaptormano, RiverCrocoliskmano, MagmaRagermano, ChillwindYetimano, OasisSnapjawmano, BoulderfistOgremano, WarGolemmano, CoreHoundmano, Recruit, j1, j2);

        }



        private void boton0000_Click(object sender, RoutedEventArgs e)
        {
            manos2.RemoveAt(0);
            cambioss1[manos2.Count()].Visibility = Visibility.Hidden;
            refreshhmano(manos2, manos2, cambioss1, cambioss1, wispmano, MurlocRaidermano, BloodfenRaptormano, RiverCrocoliskmano, MagmaRagermano, ChillwindYetimano, OasisSnapjawmano, BoulderfistOgremano, WarGolemmano, CoreHoundmano, Recruit, j1, j2);

        }

        private void audio_Click(object sender, RoutedEventArgs e)
        {
            player.Stop();

        }

        private void weapon1__Click(object sender, RoutedEventArgs e)
        {
            if (j1.tipo == "Rogue")
            {
                contadorweapon1 = contadorweapon1 + 1;
                atacar = weapon1[0];
            }
            if (j1.tipo == "Druid") 
            {
                atacar = weapon1[0];
                contadorweapon1 = contadorweapon1 + 1;

            }
            if (atacar != null && atacado != null)
            {

                atacar2.IsEnabled = true;


            }



        }

            //popo.Content = "actividad: " + weapon1[0].actividad + " \nvisibilidad: " + weapon1[0].visibilidad + " \nactividad: " + weapon1[0].actividad + "\n" + contadorweapon1;

        private void weapon1__MouseEnter(object sender, MouseEventArgs e)
        {
        }

        private void atacarheroe2_MouseEnter(object sender, MouseEventArgs e)
        {
            popo.Content = "Ataca al heroe enemigo!";
        }

        private void atacarheroe2_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Content = vacio;
        }

        private void atacarheroe1_MouseEnter(object sender, MouseEventArgs e)
        {
            popo.Content = "Ataca al heroe enemigo!";
        }

        private void atacarheroe1_MouseLeave(object sender, MouseEventArgs e)
        {
            popo.Content = vacio;
        }

        private void weapon2__Click(object sender, RoutedEventArgs e)
        {
            if (j2.tipo == "Rogue")
            {
                contadorweapon2 = contadorweapon2 + 1;
                atacado = weapon2[0];
            }
            if (j2.tipo == "Druid")
            {
                atacado = weapon2[0];
                contadorweapon2 = contadorweapon2 + 1;

            }
           
            if (atacar != null && atacado != null)
            {

                atacar2.IsEnabled = true;


            }

        }

        private void weapon2__MouseEnter(object sender, MouseEventArgs e)
        {
            //popo.Content = "actividad: " + weapon2[0].actividad + " \nvisibilidad: " + weapon2[0].visibilidad + " \nactividad: " + weapon2[0].actividad + "\n" + contadorweapon2;

        }

        private void boton24_Copy2_Click(object sender, RoutedEventArgs e)
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
