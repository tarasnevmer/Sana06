using System;


namespace ClassLibrary
{
    public class LibraryUser : Person
    {
        public int LibraryCardNum { get; set; }
        public DateTime DateOfIssue { get; set; }
        public decimal AmountOfMonthlyLibraryFee { get; set; }

        public LibraryUser(string firstName, string lastName,
            DateTime birthDate, int libraryCardNum, DateTime dateOfIssue, 
            decimal amountOfMonthlyLibraryFee) : base (firstName, lastName, birthDate)
        {
            LibraryCardNum = libraryCardNum;
            DateOfIssue = dateOfIssue;
            AmountOfMonthlyLibraryFee = amountOfMonthlyLibraryFee;
        }

        public override string ShowInfo()
        {
            string baseInfo = base.ShowInfo();

            string libraryUserInfo = $"Номер читацького квитка: {LibraryCardNum}\n" +
                $"Дата видачі: {DateOfIssue.ToShortDateString()}\n" + 
                $"Розмір щомісячного читацького внеску: {AmountOfMonthlyLibraryFee}";

            return $"{baseInfo}\n\n{libraryUserInfo}";
        }
    }
}
