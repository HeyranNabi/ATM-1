﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deletedexercise.Classes
{
    class User
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        public Card Card { get; set; }

        public User(string _name, string _surname, Card _card)
        {
            Name = _name;
            Surname = _surname;
            Card = _card;
        }
    }
}
