using AnonymousPoll.Core.Input;
using AnonymousPoll.Core.Model;
using AnonymousPoll.Core.Output;
using AnonymousPoll.Model;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;

namespace AnonymousPollTest
{
    public class FileDataTest
    {
        [Fact]
        public void ReadStudentsFile()
        {
            // Arrange
            string line;
            StreamReader file = new System.IO.StreamReader(@"../../Data/Input/students.txt");

            // Act
            while ((line = file.ReadLine()) != null)
            {
                string[] words = line.Split(',');
                //listStudents.Add(new Person(words[0], words[1], words[2]));
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
            StreamReader file = new System.IO.StreamReader(@"../../Data/Input/students.txt");

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
        public void GetStudentsCases()
        {
            // Arrange
            List<Student> studentsList = new List<Student>();
            List<InputCase> cases = new List<InputCase>();
            var inputData = new InputData();
            List<ResultCase> listResultCases = new List<ResultCase>();
            string line;
            StreamReader file = new System.IO.StreamReader(@"../../Data/Input/students.txt");

            // Act
            while ((line = file.ReadLine()) != null)
            {
                string[] words = line.Split(',');
                studentsList.Add(new Student(words[0], words[1], words[2], words[3], words[4]));
                cases.Add(new InputCase(words[1], words[2], words[3], words[4]));
            }

            var distinctCases = cases
                        .Select(m => new { m.Age, m.Gender, m.Study, m.AcademicYear})
                        .Distinct()
                        .ToList();


            //var result = cases.GroupBy(x => new InputCase(x.Gender, x.Age, x.Study, x.AcademicYear)).Distinct().ToList();

            int caseNr = 0;

            foreach (var caseStudent in distinctCases)
            {
                caseNr++;
                
                var resultCase = new ResultCase(caseNr);

                foreach (var student in studentsList)
                {
                    if ((student.Gender == caseStudent.Gender) 
                        && (student.Age == caseStudent.Age) 
                        && (student.Studies == caseStudent.Study) 
                        && (student.AcademicYear == caseStudent.AcademicYear))
                    {
                        var studentName = student.Name;

                        resultCase.Names.Add(studentName);
                    }
                }

                listResultCases.Add(resultCase);
            }

            int countNames = 0;

            List<string> total = new List<string>();

            foreach (var item in listResultCases)
            {
                foreach (var name in item.Names)
                {
                    total.Add(name);
                }
            }

            var distinctNames = new List<string>(total.Distinct());

            listResultCases.ForEach(o => countNames = countNames + o.Names.Count());

            file.Close();

            


        }
    }
}
