using System;
using System.Xml.Linq;


namespace ClassLibrary
{
    public class Applicant : Person
    {
        public int NumOfPointsZNO { get; set; }
        public int NumOfPointsEducDoc { get; set; }
        public string NameEducInstitution { get; set; }

        public Applicant (string firstName, string lastName, DateTime birthDate,
            int numOfPointsZNO, int numOfPointsEducDoc, string nameEducInstitution) : base(firstName, lastName, birthDate)
        {
            NumOfPointsZNO = numOfPointsZNO;
            NumOfPointsEducDoc = numOfPointsEducDoc;
            NameEducInstitution = nameEducInstitution;
        }

        public override string ShowInfo()
        {
            string baseInfo = base.ShowInfo();
            string applicantInfo = $"Бали ЗНО: {NumOfPointsZNO}\n" +
                $"Бали за документ про освіту: {NumOfPointsEducDoc}\n" +
                $"Назва навчального закладу: {NameEducInstitution}";

            return $"{baseInfo}\n\n{applicantInfo}";
        }
    }
}
