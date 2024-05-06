using System;

namespace Enemies
{
    ///<summary>
    ///Represent the zombie class.
    /// </summary>
    public class Zombie
    {
        ///<summary>Represent the field health.</summary>
        public int health;

        ///<summary>
        ///Constructor to set health at 0.
        ///</summary>
        public Zombie()
        {
            health = 0;
        }

        ///<summary>
        ///Constructor to initialize health to a specified value.
        ///</summary>
        public Zombie(int value)
        {

            if(value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            health = value;
        }

    }
}

