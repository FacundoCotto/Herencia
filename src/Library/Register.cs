//------------------------------------------------------------------------------
// <copyright file="Register.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System.Collections.Generic;

namespace Ucu.Poo.RideShare
{
    /// <summary>
    /// Conductor común del programa.
    /// </summary>
    public class Register
    {
        private readonly IPrinter printer;

        public List<User> users { get; }

        public Register(IPrinter printer)
        {
            this.printer = printer;
            this.users = new List<User>();
        }

        public User RegisterDriver(string name, string lastName, string id, string profilePic, string bio, int qualy, Car car)
        {
            Driver driver = new Driver(name, lastName, id, profilePic, bio, qualy, car);
            this.printer.DriverWelcomeMessage(driver);
            this.users.Add(driver);
            return driver;
        }

        public User RegisterPoolDriver(string name, string lastName, string id, string profilePic, string bio, int qualy, Car car, int maxCapacity)
        {
            Pool poolDriver = new Pool(name, lastName, id, profilePic, bio, qualy, car, maxCapacity);
            this.printer.DriverWelcomeMessage(poolDriver);
            this.users.Add(poolDriver);
            return poolDriver;
        }

        public User RegisterPassenger(string name, string lastName, string id, string profilePic, int qualy)
        {

            Passenger passenger = new Passenger(name, lastName, id, profilePic, qualy);
            this.printer.PassengerWelcomeMessage(passenger);
            this.users.Add(passenger);
            return passenger;
        }
    }
}
