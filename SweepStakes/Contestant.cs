﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class Contestant
    {
        public string firstName;
        public string lastName;
        public string email;
        public int registrationNumber;

        public Contestant()
        {
            firstName = null;
            lastName = null;
            email = null;
            registrationNumber = 0;
        }
    }
}
