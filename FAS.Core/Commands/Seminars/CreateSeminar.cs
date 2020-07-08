namespace FAS.Core.Commands.Seminars
{
    public sealed class CreateSeminar
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string LecturerId { get; set; }

        public void Validate()
        {
            Ensure.NotEmpty(Id, nameof(Id));
            Ensure.NotEmpty(Name, nameof(Name));
            Ensure.NotEmpty(LecturerId, nameof(LecturerId));
        }
    }
}
