namespace FAS.Core.Commands.Seminars
{
    public sealed class CreateSeminar
    {
        public string Name { get; set; }
        public int LecturerId { get; set; }

        public void Validate()
        {
            Ensure.NotEmpty(Name, nameof(Name));
            Ensure.IsPositive(LecturerId, nameof(LecturerId));
        }
    }
}
