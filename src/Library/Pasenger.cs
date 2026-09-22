//------------------------------------------------------------------------------
// <copyright file="Passenger.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

namespace Ucu.Poo.RideShare
{
    /// <summary>
    /// Usuario del programa
    /// </summary>
    public class Passenger : User
    {
        private int qualy;

        public Passenger(int qualy)
        {
            this.qualy = qualy;
        }

        public override string WelcomeMessage()
        {
            return $"{this.profilePic}. {this.name}";
        }

    }
}
