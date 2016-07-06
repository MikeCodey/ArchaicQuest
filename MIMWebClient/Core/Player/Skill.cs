﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIMWebClient.Core.Player
{
    public class Skill
    {
        public string Name { get; set; }

        public int Proficiency { get; set; }

        public bool Passive { get; set; }

        public int Delay { get; set; }

        public int CoolDown { get; set; }

        //Says what status a skill can be used from
        // Fighting means in a fight only
        //Resting means everything
        //standing means all but resting
        //can't use skills while asleep
        public string UsableFromStatus { get; set; }

        public int LevelObtained { get; set; }

        public string HelpText { get; set; }

        public string Syntax { get; set; }
    }
}