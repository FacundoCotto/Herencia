//------------------------------------------------------------------------------
// <copyright file="IPrinter.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System.Threading.Tasks;

namespace Ucu.Poo.RideShare
{
    /// <summary>
    /// Pasajero del programa.
    /// </summary>
    public interface IPrinter
    {
        Task DriverWelcomeMessage(Driver driver);
        Task PassengerWelcomeMessage(Passenger passenger);
    }
}
