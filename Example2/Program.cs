using Example2;

IStudents stool = new Reading();
ShowAllMyArray(stool);

static void ShowAllMyArray(IStudents items)
{
    string[] students = new string[] { "Mike", "edmund", "Mark", "Philip", "David"};
    items.Study(students);
}
