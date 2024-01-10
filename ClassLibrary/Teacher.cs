using System;


namespace ClassLibrary
{
    public class Teacher : Person
    {
        public string Position { get; set; }
        public string Department { get; set; }
        public string EducationInstitution { get; set; }

        public Teacher(string firstName, string lastName, 
            DateTime birthDate, string position, 
            string department, string educationInstitution) : base (firstName, lastName, birthDate)
        {
            Position = position;
            Department = department;
            EducationInstitution = educationInstitution;
        }

        public override string ShowInfo()
        {
            string baseInfo = base.ShowInfo();
            string teacherInfo = $"Посада: {Position}\n" +
                $"Кафедра: {Department}\n" +
                $"Вищий навчальний заклад: {EducationInstitution}";

            return $"{baseInfo}{teacherInfo}\n";
        }
    }
}
