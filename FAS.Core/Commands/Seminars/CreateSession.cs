namespace FAS.Core.Commands.Seminars
{
    public class CreateSession
    {
        public int Id { get; set; }

        public void Validate()
        {
            Ensure.IsPositive(Id, nameof(Id));
        }
    }
}
