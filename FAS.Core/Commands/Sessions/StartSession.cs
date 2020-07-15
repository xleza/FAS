namespace FAS.Core.Commands.Sessions
{
    public sealed class StartSession
    {
        public string Id { get; set; }

        public void Validate()
        {
            Ensure.NotEmpty(Id, nameof(Id));
        }
    }
}
