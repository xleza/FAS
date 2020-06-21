namespace FAS.Core.Commands.Seminars
{
    public sealed class ChangeSeminar
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int LecturerId { get; set; }

        public void Validate()
        {
            Ensure.IsPositive(Id, nameof(Id));
            Ensure.NotEmpty(Name, nameof(Name));
            Ensure.IsPositive(LecturerId, nameof(LecturerId));
        }
    }
}
