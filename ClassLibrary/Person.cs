namespace ClassLibrary
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public Person (string firstName, string lastName, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }

        public virtual string ShowInfo()
        {
            return $"Ім'я: {FirstName}\nПрізвище: {LastName}\nДата народження: {BirthDate.ToShortDateString()}";
        }
    }
}