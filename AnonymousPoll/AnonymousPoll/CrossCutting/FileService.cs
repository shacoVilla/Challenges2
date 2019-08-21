namespace AnonymousPoll.CrossCutting
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using AnonymousPoll.Core.Input;
    using AnonymousPoll.Model;

    public class FileService : IFileService
    {
        private string pathFile;

        public FileService (string pathFile)
        {
            this.pathFile = pathFile;
        }

        public List<IStudent> GetStudentsFromTextFile()
        {
            string line;
            List<IStudent> studentsList = new List<IStudent>();

            try
            {
                // Read the file and display it line by line.
                System.IO.StreamReader file =
                    new System.IO.StreamReader(this.pathFile);
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
    }
}
