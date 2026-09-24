//------------------------------------------------------------------------------
// <copyright file="DiscordPrinter.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System;
using Ucu.Poo.Discord;

namespace Ucu.Poo.RideShare
{
    /// <summary>
    /// Usuario del programa.
    /// </summary>
    public class DiscordPrinter : IPrinter
    {
        public async void DriverWelcomeMessage(Driver driver)
        {
            var botToken = Environment.GetEnvironmentVariable("DISCORD_BOT_TOKEN");
            var channelText = Environment.GetEnvironmentVariable("CHANNEL_ID");
            if (string.IsNullOrWhiteSpace(botToken) || string.IsNullOrWhiteSpace(channelText))
            {
                Console.WriteLine("Faltan las variables de entorno.");
                return;
            }

            if (string.IsNullOrWhiteSpace(driver.Name) || string.IsNullOrWhiteSpace(driver.ProfilePic) || string.IsNullOrWhiteSpace(driver.Bio))
            {
                Console.WriteLine("name, profilePic o bio vacios o nulos.");
                return;
            }

            ulong channelId = ulong.Parse(channelText);

            DiscordClient discord = new DiscordClient();

            Console.WriteLine("Conectando con Discord...");
            await discord.LoginAsync(botToken);
            await discord.SendMessageAsync(channelId, $"Bienvenido {driver.Name}");
            await discord.SendImageAsync(channelId, $"{driver.ProfilePic}", $"{driver.Bio}");
            Console.WriteLine("Mensajes enviados.");
        }

        public async void PassengerWelcomeMessage(Passenger passenger)
        {
            var botToken = Environment.GetEnvironmentVariable("DISCORD_BOT_TOKEN");
            var channelText = Environment.GetEnvironmentVariable("CHANNEL_ID");
            if (string.IsNullOrWhiteSpace(botToken) || string.IsNullOrWhiteSpace(channelText))
            {
                Console.WriteLine("Faltan las variables de entorno.");
                return;
            }

            if (string.IsNullOrWhiteSpace(passenger.Name) || string.IsNullOrWhiteSpace(passenger.ProfilePic))
            {
                Console.WriteLine("name o profilePic vacios o nulos.");
                return;
            }

            ulong channelId = ulong.Parse(channelText);

            DiscordClient discord = new DiscordClient();

            /*
            Mira a continuación cómo enviar mensajes y archivos a Discord;
            deberás hacer lo mismo en las clases y métodos adecuados de tu
            solución. Luego puedes comentar o eliminar este código.*/

            Console.WriteLine("Conectando con Discord...");
            await discord.LoginAsync(botToken);
            await discord.SendMessageAsync(channelId, $"Bienvenido {passenger.Name}");
            await discord.SendImageAsync(channelId, $"{passenger.ProfilePic}");
            Console.WriteLine("Mensajes enviados.");
        }
    }
}
