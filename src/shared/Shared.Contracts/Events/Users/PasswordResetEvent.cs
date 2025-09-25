using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Contracts.Events.Users
{
    public record PasswordResetEvent
    {
        public string Email { get; init; }
        public string ResetLink { get; init; }
        public DateTime RequestedAt { get; init; } = DateTime.UtcNow;
    }
}
