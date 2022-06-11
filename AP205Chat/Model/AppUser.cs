using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AP205Chat.Model
{
    public class AppUser:IdentityUser
    {
        public string FullName { get; set; }
        public AppUserImage Image { get; set; }
    }
}
