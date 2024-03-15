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
                if (value <= 0)
                {
                    throw new ArgumentException("число студентов должно быть больше 0");
                }
                _numOfStudents = value;
            }
        }

        public int Semester
        {
            get { return _semester; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Семестр должен быть больше 0");
                }
                _semester = value;
            }
        }
    }
}
