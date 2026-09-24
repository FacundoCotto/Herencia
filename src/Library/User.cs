//------------------------------------------------------------------------------
// <copyright file="User.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System;

namespace Ucu.Poo.RideShare
{
    /// <summary>
    /// Usuario del programa.
    /// </summary>
    public class User
    {
        private readonly string id;
        public string Name { get; }

        public string LastName { get; }

        public string ProfilePic { get; }

        public User(string name, string lastName, string id, string profilePic)
        {
            this.Name = name;
            this.LastName = lastName;
            this.id = id;
            this.ProfilePic = profilePic;
        }
    }
}
