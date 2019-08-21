namespace AnonymousPoll.CrossCutting
{
    using System;
    using System.Collections.Generic;
    using AnonymousPoll.Core.Output;

    public static class OutputService
    {
        public static void PrintResultCases(List<IResultCase> resultStudentCases)
        {
            foreach (var outputCase in resultStudentCases)
            {
                Console.WriteLine(outputCase.ToString());
            }
        }
    }
}
