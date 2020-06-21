namespace FAS.Core.Commands.Seminars
{
    public sealed class FinishSession
    {
        public int Id { get; set; }

        public void Validate()
        {
            Ensure.IsPositive(Id, nameof(Id));
        }
    }
}
