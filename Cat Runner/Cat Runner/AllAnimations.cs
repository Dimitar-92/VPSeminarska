using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cat_Runner
{
    public static class AllAnimations
    {
        public static Animacija main_run;
        public static Animacija main_jump;
        public static Animacija enemy_1_run;
        public static Animacija enemy_1_dead;
        public static Animacija enemy_2;
        public static Animacija enemy_3_run;
        public static Animacija enemy_3_dead;
        public static Animacija enemy_4_run;
        public static Animacija enemy_4_dead;
        public static Animacija enemy_5_run;
        public static Animacija enemy_5_dead;

        public static void InicijalizirajAnimacii()
        {
            main_run = new Animacija(new string[] { "images/main_character/run/1.png", "images/main_character/run/2.png" },
                true);
            main_jump = new Animacija(new string[] { "images/main_character/jump/1.png", "images/main_character/jump/2.png",
                "images/main_character/jump/3.png", "images/main_character/jump/4.png" },
                false);
            enemy_1_run = new Animacija(new string[] { "images/protivnik_1/run/1.png", "images/protivnik_1/run/2.png",
                "images/protivnik_1/run/3.png", "images/protivnik_1/run/4.png", "images/protivnik_1/run/5.png"},
                true);
            enemy_1_dead = new Animacija(new string[] { "images/protivnik_1/dead/1.png", "images/protivnik_1/dead/2.png", "images/protivnik_1/dead/3.png" },
                false);
            enemy_2 = new Animacija(new string[] { "images/protivnik_2/1.png" },
                false);
            enemy_3_run = new Animacija(new string[] { "images/protivnik_3/run/1.png", "images/protivnik_3/run/2.png",
            "images/protivnik_3/run/3.png"},
                true);
            enemy_3_dead = new Animacija(new string[] { "images/protivnik_3/dead/1.png", "images/protivnik_3/dead/2.png",
            "images/protivnik_3/dead/3.png"},
                false);
            enemy_4_run = new Animacija(new string[] { "images/protivnik_4/run/1.png", "images/protivnik_4/run/2.png" },
                true);
            enemy_4_dead = new Animacija(new string[] { "images/protivnik_4/dead/1.png", "images/protivnik_4/dead/2.png", "images/protivnik_4/dead/3.png" },
                false);
            enemy_5_run = new Animacija(new string[] { "images/protivnik_5/run/1.png", "images/protivnik_5/run/2.png",
                "images/protivnik_5/run/3.png" },
                true);
            enemy_5_dead = new Animacija(new string[] { "images/protivnik_5/dead/1.png", "images/protivnik_5/dead/2.png",
                "images/protivnik_5/dead/3.png", "images/protivnik_5/dead/4.png", "images/protivnik_5/dead/5.png" },
                false);
        }

        public static void OsveziAnimacii()
        {
            main_run.SlednaSlika();
            main_jump.SlednaSlika();
            enemy_1_run.SlednaSlika();
            enemy_1_dead.SlednaSlika();
            enemy_3_run.SlednaSlika();
            enemy_3_dead.SlednaSlika();
            enemy_4_run.SlednaSlika();
            enemy_4_dead.SlednaSlika();
            enemy_5_run.SlednaSlika();
            enemy_5_dead.SlednaSlika();
        }
    }
}
