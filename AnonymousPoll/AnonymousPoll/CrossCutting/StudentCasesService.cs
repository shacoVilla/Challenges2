namespace AnonymousPoll.CrossCutting
{
    using System.Collections.Generic;
    using System.Linq;
    using AnonymousPoll.Core.Input;
    using AnonymousPoll.Model;

    public class StudentCasesService : IStudentCasesService
    {
        IFileService fileService;

        public StudentCasesService(IFileService fileService)
        {
            this.fileService = fileService;
        }

        public List<IStudent> GetStudents()
        {
            return this.fileService.GetStudentsFromTextFile();
        }

        public List<IStudentCase> GetDistinctStudentsCases(List<IStudent> studentsList)
        {
            var cases = new List<IStudentCase>();

            var distinctList = studentsList
                        .Select(m => new { m.Gender, m.Age, m.Study, m.AcademicYear })
                        .Distinct()
                        .ToList();

            distinctList.ForEach(o => cases.Add(new StudentCase(o.Gender, o.Age, o.Study, o.AcademicYear)));

            return cases;
        }
    }
}
