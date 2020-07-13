namespace FAS.Core.Commands.Sessions
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
