using System;

namespace Enemies
{
    /// <summary> Empty public class. </summary>
    public class Zombie
    {
        /// <summary> Private field. </summary>
        private int health;

        /// <summary> Public constructor. </summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary> New public constructor with int value. </summary>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            health = value;
        }

        /// <summary> Private field. </summary>
        private string name = "(No name)";

        /// <summary> Public property (get) (set). </summary>
        public string Name 
        {
            get {return name;}
            set {name = value;}
        }

        /// <summary> Public method. </summary>
        public int GetHealth()
        {
            return health;
        }
    }
}