﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;  // Needed for MessageBox

namespace Polymorphism
{
    class Animal
    {
        //field
        private string _species;
        //Constructor
        public Animal (string species)
        {
            _species = species;
        }

        //Species property
        public string Species
        {
            get { return _species; }
            set { _species = value; }
        }
        // MakeSound method
        public virtual void MakeSound()
        {
            MessageBox.Show("Grrrrrrr");
        }
    }
}
