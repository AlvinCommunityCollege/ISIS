﻿using System;
using Ncqrs.Domain;

namespace ISIS
{

    public class Course : AggregateRootMappedByConvention
    {

        public enum Statuses
        {
            Active,
            Inactive
        }

        private string _cip;
        private string _approvalNumber;
        private string _title;
        private string _longTitle;
        private Statuses _status;

        private Course()
        {
        }

        /// <summary>
        /// Creates a new course section
        /// </summary>
        /// <param name="eventSourceId">Course id</param>
        /// <param name="rubric">Course subject. For example: BIOL</param>
        /// <param name="number">4-digit course number. For example: 2302</param>
        /// <param name="title">Course title</param>
        /// <example>new Course(Guid.NewGuid(), "BIOL","2302","Anatomy and Physiology 1");</example>
        public Course(
            Guid eventSourceId,
            string rubric,
            string number,
            string title)
            : base(eventSourceId)
        {
            ApplyEvent(new CourseCreatedEvent(eventSourceId, rubric, number));
            ApplyEvent(new CourseTitleChangedEvent(eventSourceId, title));
            ApplyEvent(new CourseLongTitleChangedEvent(eventSourceId, title));
            ApplyEvent(new CourseActivatedEvent(eventSourceId));
        }

        protected void OnCourseCreated(CourseCreatedEvent @event)
        {
        }

        /// <summary>
        /// Assigns a classification of instructional programs (CIP) code to a course
        /// </summary>
        /// <param name="cip">Classification of Instructional Programs code without punctuation. For CIP 11.0701, pass 110701</param>
        public void AssignCIP(string cip)
        {
            if (_cip != cip)
            {
                var cipEvent = new CourseCIPChangedEvent(EventSourceId, cip);
                ApplyEvent(cipEvent);
            }

            if (!string.IsNullOrEmpty(_approvalNumber))
            {
                var approvalNumberEvent = new CourseApprovalNumberChangedEvent(EventSourceId, null);
                ApplyEvent(approvalNumberEvent);
            }
        }

        protected void OnCourseCIPAssigned(CourseCIPChangedEvent @event)
        {
            _cip = @event.CIP;
        }

        /// <summary>
        /// Assigns an approval number to a course
        /// </summary>
        /// <param name="approvalNumber">A 10 digit approval number from the Academic Course Guide Manual (ACGM)</param>
        /// <remarks>ACGM: http://www.thecb.state.tx.us/AAR/UndergraduateEd/WorkforceEd/acgm.htm </remarks>
        public void AssignApprovalNumber(string approvalNumber)
        {

            if (approvalNumber == _approvalNumber)
                return;

            var approvalNumberEvent = new CourseApprovalNumberChangedEvent(EventSourceId, approvalNumber);
            ApplyEvent(approvalNumberEvent);

            var cip = approvalNumber.Substring(0, 6);
            var cipEvent = new CourseCIPChangedEvent(EventSourceId, cip);
            ApplyEvent(cipEvent);
        }

        protected void OnApprovalNumberAssigned(CourseApprovalNumberChangedEvent @event)
        {
            _approvalNumber = @event.ApprovalNumber;
        }

        public void ChangeCourseTitle(string newTitle)
        {
            if (_title == newTitle)
                return;
            if (_title == _longTitle)
                ApplyEvent(new CourseLongTitleChangedEvent(EventSourceId, newTitle));
            ApplyEvent(new CourseTitleChangedEvent(EventSourceId, newTitle));
        }

        protected void OnCourseTitleChanged(CourseTitleChangedEvent @event)
        {
            _title = @event.Title;
        }

        public void ChangeCourseLongTitle(string newLongTitle)
        {
            if (_longTitle == newLongTitle)
                return;
            ApplyEvent(new CourseLongTitleChangedEvent(EventSourceId, newLongTitle));
        }

        protected void OnCourseLongTitleChanged(CourseLongTitleChangedEvent @event)
        {
            _longTitle = @event.LongTitle;
        }

        public void ChangeDescription(string newDescription)
        {
            ApplyEvent(new CourseDescriptionChangedEvent(EventSourceId, newDescription));
        }

        protected void OnCourseDescriptionChanged(CourseDescriptionChangedEvent @event)
        {
        }

        public void Activate()
        {
            if (_status != Statuses.Active)
                ApplyEvent(new CourseActivatedEvent(EventSourceId));
        }

        protected void OnCourseActivated(CourseActivatedEvent @event)
        {
            _status = Statuses.Active;
        }

        public void Deactivate()
        {
            if (_status != Statuses.Inactive)
                ApplyEvent(new CourseDeactivatedEvent(EventSourceId));
        }

        protected void OnCourseDeactivated(CourseDeactivatedEvent @event)
        {
            _status = Statuses.Inactive;
        }

    }
}
