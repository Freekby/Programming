namespace Programming 
{
    public class Discipline
    {
        private int _numOfStudents;
        private int _semester;

        public Discipline(string name, int credits, int semester)
        {
            Name = name;
            NumOfStudents = credits;
            Semester = semester;
        }

        public Discipline()
        {
        }

        private string Name { get; set; }

        public int NumOfStudents
        {
            get { return _numOfStudents; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(NumOfStudents));
                _numOfStudents = value;
            }
        }

        public int Semester
        {
            get { return _semester; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Semester));
                _semester = value;
            }
        }
    }
}
