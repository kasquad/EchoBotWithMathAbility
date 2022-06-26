﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Console_EchoBot.Services;
using System;
using System.Data;

namespace Console_EchoBot
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Console EchoBot is online. I will repeat any message you send me!");
            Console.WriteLine("Say \"quit\" to end.");
            
            // Create the Console Adapter, and add Conversation State
            // to the Bot. The Conversation State will be stored in memory.
            var adapter = new ConsoleAdapter();

            // Create the instance of our Bot.
            var echoBot = new EchoBot(new MathService(),new TextClassifierService());

            // Connect the Console Adapter to the Bot.
            adapter.ProcessActivityAsync(
                async (turnContext, cancellationToken) => await echoBot.OnTurnAsync(turnContext)).Wait();
        }
    }
}