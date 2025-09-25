using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityService.Persistence.Identity
{
    public class AppUser : IdentityUser<Guid>
    {
        public string? ReferralCode { get; set; }
        public bool IsEmailVerified { get; set; }
        public bool IsPhoneVerified { get; set; }

      //  public TwoFactorType TwoFactorType { get; set; }
    }
}
