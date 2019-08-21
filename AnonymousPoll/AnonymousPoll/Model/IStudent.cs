// <copyright file="IStudent.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace AnonymousPoll.Model
{
    using AnonymousPoll.Core.Input;

    public interface IStudent
    {
        string Gender { get; set; }

        string Age { get; set; }

        string Name { get; set; }

        string Study { get; set; }

        string AcademicYear { get; set; }

        bool BelongsToStudentCase(IStudentCase other);
    }
}