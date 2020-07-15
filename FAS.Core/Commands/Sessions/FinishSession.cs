﻿namespace FAS.Core.Commands.Sessions
{
    public sealed class FinishSession
    {
        public string Id { get; set; }

        public void Validate()
        {
            Ensure.NotEmpty(Id, nameof(Id));
        }
    }
}
