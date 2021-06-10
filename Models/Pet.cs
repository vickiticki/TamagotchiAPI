using System;
using System.Collections.Generic;

namespace TamagotchiAPI.Models
{

    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; } = DateTime.Now;
        public int HungerLevel { get; set; } = 0;
        public int HappinessLevel { get; set; } = 0;
        //public DateTime LastInteractedWith { get; set; } = DateTime.Now;
        // public bool IsDead()
        // {
        //     if ((LastInteractedWith - DateTime.Now).TotalDays < 3)
        //     {
        //         return false;
        //     }
        //     return true;
        // }
        public List<Playtime> Playtimes { get; set; }
        public List<Feeding> Feedings { get; set; }
        public List<Scolding> Scoldings { get; set; }
    }
}
