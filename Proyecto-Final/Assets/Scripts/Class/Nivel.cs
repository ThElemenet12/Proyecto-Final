﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Class
{
    public class Nivel
    {
        public int Level { get; set; }
        public int Dificultad{ get; set; }

        public Nivel(int Dificultad)
        {
            this.Dificultad = Dificultad;
            Level = 1;
        }


    }
}
