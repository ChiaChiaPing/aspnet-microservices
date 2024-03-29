﻿using System;
namespace EventBus.Messages
{
    public class IntegrationBaseEvent
    {
        public Guid Id { get; private set; }
        public DateTime CreationDate { get; private set; }

        public IntegrationBaseEvent()
        {
            Id = Guid.NewGuid();
            CreationDate = DateTime.Now;
        }

        public IntegrationBaseEvent(Guid guid, DateTime creationDate)
        {
            Id = guid;
            CreationDate = creationDate;

        }

    }
}
