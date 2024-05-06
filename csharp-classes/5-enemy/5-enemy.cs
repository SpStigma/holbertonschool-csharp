using System;

namespace Enemies
{
    ///<summary>
    ///Represent the zombie class.
    /// </summary>
    public class Zombie
    {
        // health of the zombie
        private int health;
        // name of the zombie
        private string name = "(No name)";

        ///<summary>
        ///Constructor to set health at 0.
        ///</summary>
        public Zombie()
        {
            health = 0;
        }

        ///<summary>Properties of name.</summary>
        public string Name
        {
            get {return name;}
            set {name = value;}
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

        ///<summary>Return the health oh the zombie.</summary>
        public int GetHealth()
        {
            return health;
        }

        ///<summary>Overrides the ToString method to print the Zombie object's attributes.</summary>
        public override string ToString()
        {
            return $"Zombie Name: {name} / Total Health: {health}";
        }
    }
}



