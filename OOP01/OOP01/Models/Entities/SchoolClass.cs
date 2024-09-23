using OOP01.Models.AppExceptions;

namespace OOP01.Models.Entities
{
    public class SchoolClass
    {
        private byte _grade,
                     _lastGrade;
        private char _gradeLetter;

        public byte Grade { get => _grade; set => _grade = value; }
        public char GradeLetter { get => _gradeLetter; set => _gradeLetter = value; }
        public byte LastGrade { get => _lastGrade; private set => _lastGrade = value; } // Csak az osztályon belül lehet módosítani
        public string Name => $"{_grade}. {_gradeLetter}";
        public bool HasGraduated => _grade > _lastGrade;
        public bool IsGraduateYear => _grade == _lastGrade;
        public bool IsActive => !HasGraduated;

        public void SetLastGrade(byte newGrade)
        {
            if (newGrade > _grade)
                LastGrade = newGrade;
            else
                throw new LastGradeModificationErrorException($"{nameof(SchoolClass)} osztályban, {nameof(SetLastGrade)} metódusban {nameof(newGrade)} paraméterrel hiba történt.");
        }

        public void AdvanceGrade()
        {
            if(IsActive)
                Grade = (byte)(Grade + 1);
        }

        public SchoolClass(byte grade, byte lastGrade, char gradeLetter)
        {
            _grade = grade;
            _lastGrade = lastGrade;
            _gradeLetter = gradeLetter;
        }

        public SchoolClass()
        {
            Grade = byte.MinValue;
            GradeLetter = char.MinValue;
        }

        ~SchoolClass() => Console.WriteLine($"{Name} osztály megszűnt.");
    }
}
