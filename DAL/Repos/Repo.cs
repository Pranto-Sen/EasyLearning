﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class Repo
    {
        internal ELContext db;

        internal Repo() { 
            db = new ELContext();
        }
    }
}
