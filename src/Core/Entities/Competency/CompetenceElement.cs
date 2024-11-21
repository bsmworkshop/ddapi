﻿using Core.Interfaces;

namespace Core.Entities.Competency
{
    public class CompetenceElement : BaseEntity<int>, IAggregateRoot
    {
#pragma warning disable CS8618
        private CompetenceElement()
        {
        }

        public string Label { get; private set; }
        public int CompetenceElementGroupId { get; private set; }
        public CompetenceElementGroup CompetenceElementGroup { get; private set; }
    }
}