using System;
using System.Security.Cryptography.X509Certificates;

namespace ClassLibrary
{
    public class Student : Person
    {
        public int Course { get; set; }
        public string Group { get; set; }
        public string Faculty { get; set; }
        public string EducationInstitution { get; set; }

        public Student(string firstName, string lastName, DateTime birthDate, int course, 
            string group, string faculty, string educationInstitution) : base (firstName, lastName, birthDate)
        {
            Course = course;
            Group = group;
            Faculty = faculty;
            EducationInstitution = educationInstitution;
        }

        public override string ShowInfo()
        {
            string baseInfo = base.ShowInfo();

            string studentInfo = $"Курс: {Course}\n" + 
                $"Група: {Group}\n" + 
                $"Факультет: {Faculty}\n" + 
                $"Вищий навчальний заклад: {EducationInstitution}";

            return $"{baseInfo}{studentInfo} \n";
        }
    }
}
