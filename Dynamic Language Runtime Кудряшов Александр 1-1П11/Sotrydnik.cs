﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Sotrydnik
    {
        private readonly string surname;
        public string Surname { get => surname; }

        private readonly string name;
        public string Name { get => name; }
        private readonly string otchestvo;
        public string Otchestvo { get => otchestvo; }
        private readonly Doljnost doljnost;
        public Doljnost Doljnost { get => doljnost; }
        public Sotrydnik(string surname, string name, string otchestvo, Doljnost doljnost)
        {
            this.surname = surname;
            this.name = name;
            this.otchestvo = otchestvo;
            this.doljnost = doljnost;
        }
    }
}