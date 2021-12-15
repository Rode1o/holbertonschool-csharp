using System;

namespace Enemies
{
    /// <summary> Empty public class. </summary>
    public class Zombie
    {
        /// <summary> Public field. </summary>
        public int health;

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
    }
}