//------------------------------------------------------------------------------
// <copyright file="User.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

namespace Ucu.Poo.RideShare
{
    /// <summary>
    /// Usuario del programa
    /// </summary>
    public abstract class User
    {
        protected string name;

        protected string lastName;

        protected string id;

        protected string profilePic;

        public virtual string WelcomeMessage()
        {
            return "";
        }

    }
}
