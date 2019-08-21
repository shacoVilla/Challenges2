namespace AnonymousPoll
{
    using System;
    using System.Collections.Generic;
    using AnonymousPoll.Core.Output;
    using AnonymousPoll.CrossCutting;

    public static class Program
    {
        public static void Main(string[] args)
        {
            var fileService = new FileService(@"../../Data/Input/students.txt");

            var studentsCasesService = new StudentCasesService(fileService);

            var studentsList = studentsCasesService.GetStudents();

            var distinctCases = studentsCasesService.GetDistinctStudentsCases(studentsList);

            var resultCases = new List<IResultCase>();

            int caseNr = 0;

            foreach (var caseStudent in distinctCases)
            {
                caseNr++;

                var resultCase = new ResultCase(caseNr);

                studentsList.ForEach(o =>
                {
                    if (o.BelongsToStudentCase(caseStudent))
                    {
                        resultCase.Names.Add(o.Name);
                    }
                });

                resultCases.Add(resultCase);
            }

            OutputService.PrintResultCases(resultCases);
        }
    }
}
