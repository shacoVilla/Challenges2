namespace AnonymousPoll.CrossCutting
{
    using System.Collections.Generic;
    using AnonymousPoll.Model;

    public interface IFileService
    {
        List<IStudent> GetStudentsFromTextFile();
    }
}