namespace FAS.Core.Commands.Seminars
{
    public class CreateSession
    {
        public string Id { get; set; }
        public string SeminarId { get; set; }

        public void Validate()
        {
            Ensure.NotEmpty(Id, nameof(Id));
            Ensure.NotEmpty(Id, nameof(Id));
        }
    }
}
