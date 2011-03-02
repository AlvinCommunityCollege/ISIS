﻿using System;

namespace ISIS.Schedule
{
    public class CourseApprovalNumberChangedEvent
    {

        private CourseApprovalNumberChangedEvent()
        {
            
        }

        public CourseApprovalNumberChangedEvent(Guid courseId, string approvalNumber)
        {
            CourseId = courseId;
            ApprovalNumber = approvalNumber;
        }

        public Guid CourseId { get; set; }
        public string ApprovalNumber { get; set; }
    }
}