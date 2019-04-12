﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Class
{
    [DataContract]
    public class PlayerStats
    {
        [DataMember]
        public bool Pass { get; set; }
        
        [DataMember]
        public List<int> NivelesLogrados { get; set; }
        [DataMember]
        public List<Items> Inventario { get; set; }
        [DataMember]
        public int Monedas { get; set; }
        public PlayerStats()
        {
            Pass = false;
            
            NivelesLogrados = new List<int> { 0, 0, 0, 0 };
            Inventario = new List<Items> { new Items("Armadura", 0), new Items("Pocion", 0), new Items("Lagrima", 0), new Items("Amuleto", 0) };
            Monedas = 0;
        }
    }
}
