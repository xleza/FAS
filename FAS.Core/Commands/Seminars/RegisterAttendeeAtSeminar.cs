namespace FAS.Core.Commands.Seminars
{
    public sealed class RegisterAttendeeAtSeminar
    {
        public int Id { get; set; }
        public string AttendeeId { get; set; }

        public void Validate()
        {
            Ensure.IsPositive(Id, nameof(Id));
            Ensure.NotEmpty(AttendeeId, nameof(AttendeeId));
        }
    }
}
