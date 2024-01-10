using ClassLibrary;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Person[] persons = new Person[5];
persons[0] = new Person("Тарас", "Невмержицький", new DateTime(2005, 3, 9));
persons[1] = new Applicant("Денис", "Науменко", new DateTime(2006, 5, 20), 165, 88, "ЗОШ №15");
persons[2] = new Student("Дмитро", "Стаднік", new DateTime(2004, 9, 14), 2, "КН-22-2", "ФІКТ", "Житомирська політехніка");
persons[3] = new Teacher("Оксана", "Денисюк", new DateTime(1975, 3, 16), "Доцент", "Кафедра IT", "Київська політехніка");
persons[4] = new LibraryUser("Анастасія", "Семеній", new DateTime(1996, 2, 11), 254, new DateTime(2022, 6, 3), 100);

for (int i = 0; i < persons.Length; i++)
{
    Console.WriteLine(persons[i].ShowInfo()); 
}
