//------------------------------------------------------------------------------
// <copyright file="Driver.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

namespace Ucu.Poo.RideShare
{
    /// <summary>
    /// Conductor común del programa.
    /// </summary>
    public class Driver : User
    {
        public string Bio { get; }

        private readonly int qualy;

        private readonly Car car;

        public Driver(string name, string lastName, string id, string profilePic, string bio, int qualy, Car car)
            : base(name, lastName, id, profilePic)
        {
            this.Bio = bio;
            this.qualy = qualy;
            this.car = car;
        }
    }
}
