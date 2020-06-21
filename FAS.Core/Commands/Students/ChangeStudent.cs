namespace FAS.Core.Commands.Students
{
    public sealed class ChangeStudent
    {
        public string Id { get; set; }
        public string FullName { get; set; }

        public void Validate()
        {
            Ensure.NotEmpty(Id, nameof(Id));
            Ensure.NotEmpty(FullName, nameof(FullName));
        }
    }
}
