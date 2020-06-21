namespace FAS.Core.Commands.Students
{
    public sealed class DeleteStudent
    {
        public string Id { get; set; }
        public void Validate()
        {
            Ensure.NotEmpty(Id, nameof(Id));
        }
    }
}
