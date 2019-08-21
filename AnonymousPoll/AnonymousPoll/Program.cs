namespace AnonymousPoll
{
    using AnonymousPoll.CrossCutting;

    public static class Program
    {
        public static void Main(string[] args)
        {
            var fileService = new FileService(@"../../Data/Input/students.txt");

            var studentsCasesService = new StudentCasesService(fileService);

            var studentsList = studentsCasesService.GetStudents();

            var distinctCases = studentsCasesService.GetDistinctStudentsCases(studentsList);

            var resultCases = studentsCasesService.GetResultCasesByDistinctStudentCases(studentsList, distinctCases);

            OutputService.PrintResultCases(resultCases);
        }
    }
}
