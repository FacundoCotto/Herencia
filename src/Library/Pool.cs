//------------------------------------------------------------------------------
// <copyright file="Pool.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

namespace Ucu.Poo.RideShare
{
    /// <summary>
    /// Conductor Pool del programa.
    /// </summary>
    public class Pool : Driver
    {
        private readonly int maxCapacity;

        public Pool(string name, string lastName, string id, string profilePic, string bio, int qualy, Car car, int maxCapacity)
        : base(name, lastName, id, profilePic, bio, qualy, car)
        {
            this.maxCapacity = maxCapacity;
        }
    }
}
