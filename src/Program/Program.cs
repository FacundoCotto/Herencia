//------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System.Threading.Tasks;

namespace Ucu.Poo.RideShare
{
    /// <summary>
    /// Programa principal.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal. En este ejercicio no cambias
        /// este método, sino <see cref="Program.MainAsync"/> que está debajo.
        /// </summary>
        public static void Main()
        {
            MainAsync().GetAwaiter().GetResult();

        }

        private static async Task MainAsync()
        {

            Register register = new Register(new DiscordPrinter());
            User passenger1 = register.RegisterPassenger("Bill", "Gates", "1234567-8", "/biil.jpg", 5);
            User passenger2 = register.RegisterPassenger("Dan", "Brown", "2345678-9", "/dan.jpg", 4);
            User passenger3 = register.RegisterPassenger("Rick", "Sanchez", "3456789-0", "/rick.jpg", 3);
            User driver = register.RegisterDriver("Rick", "Grimes", "4567890-1", "/rick.jpg",
                "Manejo desde hace 10 años", 5, new Car("Toyota Corolla", 2018));
        }
    }
}
