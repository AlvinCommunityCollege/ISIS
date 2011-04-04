﻿using System;

namespace ISIS.Schedule
{
    public class SectionLocationChangedEvent : IEvent
    {
        public Guid SectionId { get; private set; }
        public Guid LocationId { get; private set; }
        public string LocationAbbreviation { get; private set; }
        public string LocationName { get; private set; }

        public SectionLocationChangedEvent(
            Guid sectionId,
            Guid locationId,
            string abbreviation,
            string name)
        {
            SectionId = sectionId;
            LocationId = locationId;
            LocationAbbreviation = abbreviation;
            LocationName = name;
        }



    }
}