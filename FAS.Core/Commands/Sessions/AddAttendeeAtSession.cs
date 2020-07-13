namespace FAS.Core.Commands.Sessions
{
    public sealed class AddAttendeeAtSession
    {
        public string Id { get; set; }
        public string SessionId { get; set; }

        public void Validate()
        {
            Ensure.NotEmpty(Id, nameof(Id));
            Ensure.NotEmpty(SessionId, nameof(SessionId));
        }
    }
}
