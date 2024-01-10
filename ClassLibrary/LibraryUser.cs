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
    }
}
