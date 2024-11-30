﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ApplicationUser :IdentityUser
    {
        public string Address { get; set; }
        public string Image { get; set; }
    }
}
