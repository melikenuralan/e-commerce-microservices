using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Contracts.Events.Users
{
    public record UserCreatedEvent
    {
        public Guid UserId { get; init; }
        public string Email { get; init; } = default!;
        public string UserName { get; init; } = default!;
        public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
    }
}
