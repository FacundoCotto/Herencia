//------------------------------------------------------------------------------
// <copyright file="Driver.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

namespace Ucu.Poo.RideShare
{
    /// <summary>
    /// Usuario del programa
    /// </summary>
    public class Driver : User
    {
        private string bio;

        private int qualy;

        private Car car;

        public Driver(string bio, int qualy, Car car)
        {
            this.bio = bio;
            this.qualy = qualy;
            this.car = car;
        }

        public override string WelcomeMessage()
        {
            return $"{this.profilePic}. {this.bio}. Welcome {this.name}";
        }

    }
}
