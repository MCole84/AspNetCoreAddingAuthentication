using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace WishList.Models
{
    [Authorize]
    public class ApplicationUser : IdentityUser
    {
        public virtual ICollection<Item> Items { get; set; }
    }
}
