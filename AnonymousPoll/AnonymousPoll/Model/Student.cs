// <copyright file="Student.cs" company="VOXELGROUP">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace AnonymousPoll.Core.Model
{
    public class Student
    {
        public Student(string name, string gender, string age, string studies, string academicYear)
        {
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
            this.Studies = studies;
            this.AcademicYear = academicYear;
        }

        public string Gender { get; set; }

        public string Age { get; set; }

        public string Name { get; set; }

        public string Studies { get; set; }

        public string AcademicYear { get; set; }
    }
}