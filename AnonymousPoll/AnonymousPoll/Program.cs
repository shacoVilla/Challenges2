namespace AnonymousPoll
{
    using System;
    using System.Collections.Generic;
    using AnonymousPoll.Core.Output;

    public static class Program
    {
        public static void Main(string[] args)
        {
            var studentsList = Helper.GetStudentsFromTextFile(@"../../Data/Input/students.txt");

            var distinctCases = Helper.GetDistinctStudentsCases(studentsList);

            var resultCases = new List<ResultCase>();

            int caseNr = 0;

            foreach (var caseStudent in distinctCases)
            {
                caseNr++;

                var resultCase = new ResultCase(caseNr);

                foreach (var student in studentsList)
                {
                    if (student.BelongsToStudentCase(caseStudent))
                    {
                        resultCase.Names.Add(student.Name);
                    }
                }

                resultCases.Add(resultCase);
            }

            PrintResultCases(resultCases);
        }

        private static void PrintResultCases(List<ResultCase> resultStudentCases)
        {
            foreach (var outputCase in resultStudentCases)
            {
                if (outputCase.Names.Count == 0)
                {
                    Console.WriteLine("Case #" + outputCase.CaseNumber + ": NONE");
                }
                else
                {
                    Console.WriteLine(outputCase.ToString());
                }
            }
        }
    }
}
