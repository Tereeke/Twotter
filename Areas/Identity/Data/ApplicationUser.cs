using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Twotter.Areas.Identity.Data;

// Add profile data for application users by adding properties to the TwotterUser class
public class ApplicationUser : IdentityUser
{
    public string Name { get; set; }
    public DateTime DOB { get; set; }
    public DateTime DateJoined { get; set; }
}

