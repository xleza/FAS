namespace FAS.Core.Commands.Seminars
{
    public sealed class UnRegisterAttendeeAtSeminar
    {
        public string Id { get; set; }
        public string AttendeeId { get; set; }

        public void Validate()
        {
            Ensure.NotEmpty(Id, nameof(Id));
            Ensure.NotEmpty(AttendeeId, nameof(AttendeeId));
        }
    }
}
