using System;

{

    public class Player
    {
        private int XP
        private float health
        public string Name { get; }

        public int XP
        {
            get => return xp;
        }

        public int Level
        {
            get => 1 + XP/1000;
        }
        public float Health
        {

            get => return health;
                

            set => (health < 0) health = 0;
                
        }

        public float MaxHealth 
        {
            get => 100 + (Level - 1) * 20
        }
    }
}