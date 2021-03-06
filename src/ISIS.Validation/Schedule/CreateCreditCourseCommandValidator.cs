﻿using FluentValidation;
using System;

namespace ISIS.Schedule
{
    /// <summary>
    /// Validation rules for CreateCourseCommand
    /// </summary>
    /// <remarks>Rules based on Texas Common Course Numbering System: http://www.tccns.org/ccn/taxonomy.asp </remarks>
    public class CreateCreditCourseCommandValidator : AbstractValidator<CreateCreditCourseCommand>
    {
        public CreateCreditCourseCommandValidator()
        {

            RuleFor(cmd => cmd.CourseId)
                .NotEqual(default(Guid))
                .WithMessage("You must supply a valid course id.");

            RuleFor(cmd => cmd.Rubric)
                .NotEmpty()
                .Matches(@"^[A-Z]{4}$")
                .WithMessage("Rubric must be a 4 character code, all uppercase");

            RuleFor(cmd => cmd.CourseNumber)
                .NotEmpty()
                .Matches(@"^\d{4}$")
                .WithMessage("Course number must be a 4-digit number")
                .Matches(@"^\d[1-9]\d{2}$")
                .WithMessage("For credit courses, the 2nd digit of the course number must not be zero.");

            RuleFor(cmd => cmd.Title)
                .NotEmpty().WithMessage("Title is required");

            RuleFor(cmd => cmd.Types)
                .NotEmpty()
                .WithMessage("You must select at least one course type.");

        }
    }
}
