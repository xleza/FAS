namespace FAS.UI.Seminars.Models
{
    public sealed class SeminarLecturerDto
    {
        public string Id { get; set; }
        public string FullName { get; set; }

        public override string ToString() => FullName;
    }
}
