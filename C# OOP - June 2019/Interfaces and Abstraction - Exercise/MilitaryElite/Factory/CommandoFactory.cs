﻿using MilitaryElite.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Factory
{
    public class CommandoFactory
    {
        public Commando MakeCommando(string[] args)
        {
            int id = int.Parse(args[1]);
            string firstName = args[2];
            string lastName = args[3];
            decimal salary = decimal.Parse(args[4]);
            string corp = args[5];

            Commando commando = new Commando(id, firstName, lastName, salary, corp);

            return commando;
        }
    }
}
