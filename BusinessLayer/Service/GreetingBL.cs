﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Interface;
using RepositoryLayer.Interface;

namespace BusinessLayer.Service
{
    public class GreetingBL : IGreetingBL
    {
        private readonly IGreetingRL _greetingRL;

        public GreetingBL(IGreetingRL greetingRL)
        {
            _greetingRL = greetingRL;
        }

        public string GetGreetingBL()

        {
            return "Hello World";
        }

        //UC3
        /// <summary>
        /// Get Greeting Method
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <returns></returns>
        public string GetGreeting(string? firstName, string? lastName)
        {

            string greetingMessage;

            if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName))
            {
                greetingMessage = $"Hello {firstName} {lastName}!";
            }
            else if (!string.IsNullOrEmpty(firstName))
            {
                greetingMessage = $"Hello {firstName}!";
            }
            else if (!string.IsNullOrEmpty(lastName))
            {
                greetingMessage = $"Hello {lastName}!";
            }
            else
            {
                greetingMessage = "Hello, World!";
            }

            return greetingMessage;
        }
    }
}
