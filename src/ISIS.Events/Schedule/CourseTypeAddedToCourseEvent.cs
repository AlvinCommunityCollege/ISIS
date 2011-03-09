﻿using System;
using System.Collections.Generic;

namespace ISIS.Schedule
{
    public class CourseTypeAddedToCourseEvent
    {
        public Guid CourseId { get; private set; }
        public CourseTypes TypeAdded { get; private set; }
        public IEnumerable<CourseTypes> CurrentTypes { get; private set; }

        private CourseTypeAddedToCourseEvent()
        {
        }

        public CourseTypeAddedToCourseEvent(Guid courseId, CourseTypes type, IEnumerable<CourseTypes> currentTypes)
        {
            CourseId = courseId;
            TypeAdded = type;
            CurrentTypes = currentTypes;
        }
    }
}