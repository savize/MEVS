﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Bank
    {
        public int Id { get; set; }
        public string Account { get; set;}
        public User EVUser { get; set; }
    }
}
