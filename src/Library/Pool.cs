//------------------------------------------------------------------------------
// <copyright file="Pool.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

namespace Ucu.Poo.RideShare
{
    /// <summary>
    /// Usuario del programa
    /// </summary>
    public class Pool : Driver
    {
        private int maxCapacity;

        public Pool(int maxCapacity, string bio, int qualy, Car car)
        : base(bio, qualy, car)
        {
            this.maxCapacity = maxCapacity;
        }
    }
}
