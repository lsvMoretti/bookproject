using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace LibraryCatalog.Areas.Identity.Data;

// Add profile data for application users by adding properties to the LibraryCatalogUser class
public class LibraryCatalogUser : IdentityUser
{
    [PersonalData]
    public string? Name { get; set; }
    [PersonalData]
    public DateTime DOB { get; set; }
}

