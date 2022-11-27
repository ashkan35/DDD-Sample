using Domain.Enums;
using Domain.Primitives;

namespace Domain.Entities;

public class Conference:BaseEntity
{
    public Conference(Guid id) : base(id)
    {
    }
    public Member Creator { get; private set; }

    public ConferenceType Type { get; private set; }

    public string Name { get; private set; }

    public DateTime ScheduledAtUtc { get; private set; }

    public string? Location { get; private set; }

    public int? MaximumNumberOfAttendees { get; private set; }

    public DateTime? InvitationsExpireAtUtc { get; private set; }

    public int NumberOfAttendees { get; private set; }

    
}