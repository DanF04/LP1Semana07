using System;

{

    public class Player
    {
        private int XP
        private float health
        public string Name { get; }

        public int XP
        {
            get => xp;
            set
            {
                if (value > xp) xp = value;
            }
        }
        public int Level
        {
            get => 1 + XP/1000;
        }
        public float Health
        {
            get => health;
            set
            {
                health = value;
                if (health > MaxHealth) health = MaxHealth;
                if (health < 0) health = 0;
            }
        }
        
        public float MaxHealth
        {
            get => 100f + (Level - 1) * 20f;
        }


    }
}