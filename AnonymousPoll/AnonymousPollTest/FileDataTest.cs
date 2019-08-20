using AnonymousPoll.Core.Input;
using AnonymousPoll.Core.Output;
using AnonymousPoll.Model;
using FluentAssertions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;

namespace AnonymousPollTest
{
    public class FileDataTest
    {
        const string studentsListsPath = @"../../Data/Input/students.txt";

        [Fact]
        public void ReadStudentsFile()
        {
            // Arrange
            string line;
            StreamReader file = new StreamReader(studentsListsPath);

            // Act
            while ((line = file.ReadLine()) != null)
            {
                string[] words = line.Split(',');
            }

            // Assert
            Assert.True(file.BaseStream.Length > 0);
            file.Close();
        }

        [Fact]
        public void GetStudentsList()
        {
            // Arrange
            List<Student> studentsList = new List<Student>();
            string line;
            StreamReader file = new StreamReader(studentsListsPath);

            // Act
            while ((line = file.ReadLine()) != null)
            {
                string[] words = line.Split(',');
                studentsList.Add(new Student(words[0], words[1], words[2], words[3], words[4]));
            }

            file.Close();

            // Assert
            Assert.True(studentsList.Count > 0);
        }

        [Fact]
        public void GetDistinctStudenCases_ByStudy()
        {

        }

        [Fact]
        public void GetDistinctStudenCases_ByGender()
        {
            List<InputCase> cases = new List<InputCase>
            {
                new InputCase("F", "18", "Math", "1980"),

                new InputCase("F", "18", "Math", "1980"),

                new InputCase("F", "18", "Math", "1980"),

                new InputCase("F", "18", "Math", "1980"),

                new InputCase("M", "18", "Math", "1980"),

                new InputCase("M", "18", "Math", "1980")
            };

            var result = cases.Select(m => new { m.Age, m.Gender, m.Study, m.AcademicYear }).Distinct().ToList();

            result.Should().OnlyHaveUniqueItems();
        }

        [Fact]
        public void GetDistinctStudenCases_ByAcademicYear()
        {

            List<InputCase> cases = new List<InputCase>
            {
                new InputCase("F", "18", "Math", "1980"),

                new InputCase("F", "18", "Math", "1984"),

                new InputCase("F", "18", "Math", "1985"),

                new InputCase("F", "18", "Sport", "1986"),

                new InputCase("F", "18", "Sport", "1987"),

                new InputCase("F", "18", "Sport", "1987")
            };

            var result = cases.Select(m => new { m.Age, m.Gender, m.Study, m.AcademicYear }).Distinct().ToList();

            result.Should().OnlyHaveUniqueItems();
        }

        [Fact]
        public void GetDistinctStudentsCases()
        {
            // Arrange
            List<Student> studentsList = new List<Student>();
            List<InputCase> cases = new List<InputCase>();
            string line;

            // Act
            StreamReader file = new StreamReader(studentsListsPath);
            while ((line = file.ReadLine()) != null)
            {
                string[] words = line.Split(',');
                studentsList.Add(new Student(words[0], words[1], words[2], words[3], words[4]));
            }

            file.Close();

            studentsList.ForEach(o => cases.Add(new InputCase(o.Gender, o.Age, o.Study, o.AcademicYear)));

            var distinctCases = cases
                        .Select(m => new { m.Age, m.Gender, m.Study, m.AcademicYear })
                        .Distinct()
                        .ToList();

            // Assert
            distinctCases.Should().OnlyHaveUniqueItems();
        }

        [Fact]
        public void GetStudentsCases()
        {
            // Arrange
            List<Student> studentsList = new List<Student>();
            List<InputCase> cases = new List<InputCase>();
            List<ResultCase> listResultCases = new List<ResultCase>();
            string line;
            StreamReader file = new System.IO.StreamReader(studentsListsPath);

            // Act
            while ((line = file.ReadLine()) != null)
            {
                string[] words = line.Split(',');
                studentsList.Add(new Student(words[0], words[1], words[2], words[3], words[4]));
            }

            file.Close();

            studentsList.ForEach(o => cases.Add(new InputCase(o.Gender, o.Age, o.Study, o.AcademicYear)));

            var distinctCases = cases
                        .Select(m => new { m.Age, m.Gender, m.Study, m.AcademicYear })
                        .Distinct()
                        .ToList();

            int caseNr = 0;

            foreach (var caseStudent in distinctCases)
            {
                var inputCaseStudent = new InputCase(caseStudent.Gender,
                    caseStudent.Age,
                    caseStudent.Study,
                    caseStudent.AcademicYear);

                caseNr++;

                var resultCase = new ResultCase(caseNr);

                foreach (var student in studentsList)
                {

                    if (student.BelongsToStudentCase(inputCaseStudent))
                    {

                        resultCase.Names.Add(student.Name);
                    }
                }

                listResultCases.Add(resultCase);
            }
        }

    }
}
