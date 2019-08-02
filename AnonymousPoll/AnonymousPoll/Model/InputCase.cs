namespace AnonymousPoll.Model
{
    public class InputCase
    {
        public string Age { get; set; }

        public string Gender { get; set; }

        public string Study { get; set; }

        public string AcademicYear { get; set; }

        public InputCase(string gender, string age, string study, string academicYear)
        {
            this.Age = age;
            this.Gender = gender;
            this.Study = study;
            this.AcademicYear = academicYear;
        }
    }
}
