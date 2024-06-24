namespace Task1
{
    internal class Patient
    {
        public string Name { get; set; }
        public int NumberPolis { get; set; }
        public int BirthYear { get; set; }

        #region Constructors
        public Patient() : this("Unknown", 0, 2000)
        {
        }

        public Patient(string name, int numberPolis, int dateOfBirthday)
        {
            Name = name;
            NumberPolis = numberPolis;
            BirthYear = dateOfBirthday;
        }
        #endregion

        #region operators
        public static Patient operator ++(Patient patient)
            => new Patient
            {
                Name = patient.Name,
                NumberPolis = patient.NumberPolis,
                BirthYear = patient.BirthYear + 1
            };

        public static Patient operator +(Patient patient1, Patient patient2)
            => new Patient
            {
                Name = patient1.Name,
                NumberPolis = patient1.NumberPolis,
                BirthYear = patient1.BirthYear + patient2.BirthYear
            };

        public static bool operator true(Patient patient)
            => patient.BirthYear >= 0;

        public static bool operator false(Patient patient)
            => patient.BirthYear < 0;
        #endregion

        #region PrintMethod
        public void Print()
        {
            Console.WriteLine("Name: ", Name);
            Console.WriteLine("Polis number: ", NumberPolis);
            Console.WriteLine("Year of birth: ", BirthYear);
        }
        #endregion
    }
}