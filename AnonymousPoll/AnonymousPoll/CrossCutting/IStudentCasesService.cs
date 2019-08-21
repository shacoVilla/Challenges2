namespace AnonymousPoll.CrossCutting
{
    using System.Collections.Generic;
    using AnonymousPoll.Core.Input;
    using AnonymousPoll.Model;

    public interface IStudentCasesService
    {
        List<IStudentCase> GetDistinctStudentsCases(List<IStudent> studentsList);
    }
}