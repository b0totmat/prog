using OOP01.Models.AppExceptions;

namespace OOP01.Models.Entities
{
    public class Student
    {
        private string _lastName,
                       _firstName,
                       _email,
                       _phone;
        private DateTime _birthDate;
        private bool _gender;

        // Legyen üres konstuktor
        public Student()
        {
            _lastName = _firstName = _email = _phone = string.Empty;
            _birthDate = new DateTime();
            _gender = false;
        }

        // Legyen összes konsturkor
        public Student(string lastName, string firstName, string email, string phone, DateTime birthDate, bool gender)
        {
            _lastName = lastName;
            _firstName = firstName;
            _email = email;
            _phone = phone;
            _birthDate = birthDate;
            _gender = gender;
        }

        // Lehessen létrehozni diákot email cím nélkül
        public Student(string lastName, string firstName, string phone, DateTime birthDate, bool gender)
        {
            _lastName = lastName;
            _firstName = firstName;
            _email = string.Empty;
            _phone = phone;
            _birthDate = birthDate;
            _gender = gender;
        }

        // Legyen a diák angol és magyar teljes neve
        public string EnglishFullName => _firstName + " " + _lastName;
        public string HungarianFullName => _lastName + " " + _firstName;

        public string LastName { get => _lastName; set => _lastName = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string Email { get => _email; private set => _email = value; }
        public string Phone { get => _phone; private set => _phone = value; }
        public DateTime BirthDate { get => _birthDate; set => _birthDate = value; }
        public bool Gender { get => _gender; set => _gender = value; }

        // Meg lehessen tudni a diák életkorát
        public byte Age
        {
            get
            {
                if (DateTime.Now.DayOfYear > _birthDate.DayOfYear)
                    return (byte)(DateTime.Now.Year - _birthDate.Year);
                return (byte)(DateTime.Now.Year - _birthDate.Year - 1);
            }
        }

        // Lekérdezhető legyen hogy van-e email címe a diáknak
        public bool HasEmail => _email != null && _email != "" && _email != string.Empty;

        // Lekérdezhető legyen hogy van-e telefon száma a diáknak
        public bool HasPhone => _phone != null && _phone != "" && _phone != string.Empty;

        // Lehessen könnyedén email és telefon számot változtatni, a többit csak nehezen (módosításkor az új email cím nem egyezhet meg a régi emailcimmel)
        public void SetEmail(string newEmail)
        {
            if (newEmail == _email) // Kivétel kezelések
                throw new NewEmailEqualsToOldOneException();
            else if (!newEmail.Contains('@')) // - email címben nincs kukac
                throw new EmailDoesNotContainerAtException();
            else
                _email = newEmail;
        }
        public void SetPhone(string newPhone)
        {
            if (newPhone == _phone)
                throw new NewPhoneEqualsToOldOneException();
            else
                _phone = newPhone;
        }

        // - névben csak betű, kötőjel és szököz lehet
        public string SetName(string newName)
        {
            string allowedCharacters = "öüóqwertzuiopőúasdfghjkléáűíyxcvbnm- ";

            for (int i = 0; i < newName.Length; i++)
            {
                if (!allowedCharacters.Contains(newName[i]))
                    throw new NotAllowedCharacterInNewNameException();
            }

            return newName;
        }
    }
}
