namespace AnonymousPoll.Core.Input
{
    public class StudentCase : IStudentCase
    {
        public string Age { get; set; }

        public string Gender { get; set; }

        public string Study { get; set; }

        public string AcademicYear { get; set; }

        public StudentCase(string gender, string age, string study, string academicYear)
        {
            this.Age = age;
            this.Gender = gender;
            this.Study = study;
            this.AcademicYear = academicYear;
        }
    }
}
