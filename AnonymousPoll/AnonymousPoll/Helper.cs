namespace AnonymousPoll
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using AnonymousPoll.Model;

    public static class Helper
    {
        public static List<Student> GetStudentsFromTextFile(string filePath)
        {
            string line;
            List<Student> studentsList = new List<Student>();

            try
            {
                // Read the file and display it line by line.
                System.IO.StreamReader file =
                    new System.IO.StreamReader(filePath);
                while ((line = file.ReadLine()) != null)
                {
                    string[] words = line.Split(',');
                    studentsList.Add(new Student(words[0], words[1], words[2], words[3], words[4]));
                }

                file.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error found:" + e.Message);
            }

            return studentsList;
        }

        public static List<InputCase> GetDistinctStudentsCases(List<Student> studentsList)
        {
            var cases = new List<InputCase>();

            var distinctList = studentsList
                        .Select(m => new { m.Gender, m.Age, m.Study, m.AcademicYear })
                        .Distinct()
                        .ToList();

            distinctList.ForEach(o => cases.Add(new InputCase(o.Gender, o.Age, o.Study, o.AcademicYear)));

            return cases;
        }
    }
}
