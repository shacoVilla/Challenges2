// <copyright file="Student.cs" company="VOXELGROUP">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace AnonymousPoll.Model
{
    using AnonymousPoll.Core.Input;

    public class Student : IStudent
    {
        public string Gender { get; set; }

        public string Age { get; set; }

        public string Name { get; set; }

        public string Study { get; set; }

        public string AcademicYear { get; set; }

        public Student(string name, string gender, string age, string study, string academicYear)
        {
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
            this.Study = study;
            this.AcademicYear = academicYear;
        }

        public bool BelongsToStudentCase(IStudentCase other)
        {
            if (this.Gender != other.Gender || this.Age != other.Age || this.Study != other.Study || this.AcademicYear != other.AcademicYear)
            {
                return false;
            }

            return true;
        }
    }
}