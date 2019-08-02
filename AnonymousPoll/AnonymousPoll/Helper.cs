namespace AnonymousPoll
{
    using System.Collections.Generic;
    using AnonymousPoll.Core.Model;

    public static class Helper
    {
        public static List<Student> GetStudentsFromTextFile()
        {
            string line;
            List<Student> listStudents = new List<Student>();

            // Read the file and display it line by line.
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"Data/Input/students.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] words = line.Split(',');
                //listStudents.Add(new Person(words[0], words[1], words[2]));
            }

            file.Close();

            return listStudents;
        }
    }
}
