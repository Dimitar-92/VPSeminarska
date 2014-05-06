using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Igra_za_proektnu
{
    public static class AllAnimations
    {
        public static Animacija main_run;
        public static Animacija main_jump;
        public static Animacija enemy_run;
        public static Animacija enemy_2_stand;
        public static Animacija enemy_2_dead;
        public static Animacija enemy_3_run;
        public static Animacija enemy_3_dead;
        public static Animacija enemy_4_run;
        public static Animacija enemy_5_run;

        public static void InicijalizacijaAnimacii()
        {
            main_run = new Animacija(new string[] { "images/main_character/run/1.png", "images/main_character/run/2.png" },
                true);
            main_jump = new Animacija(new string[] { "images/main_character/jump/1.png", "images/main_character/jump/2.png",
                "images/main_character/jump/3.png", "images/main_character/jump/4.png" },
                true);
            enemy_run = new Animacija(new string[] { "images/protivnik_1/run/1.png", "images/protivnik_1/run/2.png",
                "images/protivnik_1/run/3.png", "images/protivnik_1/run/4.png", "images/protivnik_1/run/5.png"},
                true);
            enemy_2_stand = new Animacija(new string[] { "images/protivnik_2/stand/1.png"},
                true);
            enemy_2_dead = new Animacija(new string[] { "images/protivnik_2/dead/1.gif" },
                true);
            enemy_3_run = new Animacija(new string[] { "images/protivnik_3/run/1.png", "images/protivnik_3/run/2.png",
            "images/protivnik_3/run/3.png"},
                true);
            enemy_3_dead = new Animacija(new string[] { "images/protivnik_3/dead/1.png", "images/protivnik_3/dead/2.png",
            "images/protivnik_3/dead/3.png"},
                false);
            enemy_4_run = new Animacija(new string[] { "images/protivnik_4/run/1.png", "images/protivnik_4/run/2.png" },
                true);
            enemy_5_run = new Animacija(new string[] { "images/protivnik_5/run/1.png", "images/protivnik_5/run/2.png",
                "images/protivnik_5/run/3.png" },
                true);
        }

        public static void Increment()
        {
            main_run.SlednaSlika();
            main_jump.SlednaSlika();
            enemy_run.SlednaSlika();
            enemy_2_stand.SlednaSlika();
            enemy_2_dead.SlednaSlika();
            enemy_3_run.SlednaSlika();
            enemy_3_dead.SlednaSlika();
            enemy_4_run.SlednaSlika();
            enemy_5_run.SlednaSlika();
        }
    }
}
