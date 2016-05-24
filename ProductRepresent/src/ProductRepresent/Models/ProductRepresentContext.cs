using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ProductRepresent.Models
{
    public class ApplicationUser : IdentityUser { }

    public class ProductRepresentContext : IdentityDbContext<ApplicationUser>
    {

    }
}
