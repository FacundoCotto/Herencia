//------------------------------------------------------------------------------
// <copyright file="Passenger.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

namespace Ucu.Poo.RideShare
{
    /// <summary>
    /// Pasajero del programa.
    /// </summary>
    public class Passenger : User
    {
        private readonly int qualy;

        public Passenger(string name, string lastName, string id, string profilePic, int qualy)
            : base(name, lastName, id, profilePic)
        {
            this.qualy = qualy;
        }
    }
}
