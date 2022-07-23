using StandartInterfaces;

/*Auditory auditory = new Auditory();
Console.WriteLine("\n------Список студентов-------\n");

auditory.Sort(new DateComparer());

foreach (Student student in auditory)
{
    Console.WriteLine(student);
}*/

Student first = new Student
{
    FirstName = "Test",
    LastName = "TEST",
    BirthDate = new DateTime(2000, 1, 2),
    StudentCard = new StudentCard { Number = 8978798, Series = "AAAAA"}
};

Student second = (Student) first.Clone();

second.FirstName = "not test";
second.StudentCard.Series = "BBBB";

Console.WriteLine(first);