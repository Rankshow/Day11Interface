using Example9;
using System.Collections.Generic;

List<Student> student = new List<Student>();

Student std1 = new Student();   
std1.FullName = "Mike";
std1.Age = 20;
std1.Gender = "Male";
std1.Email = "uwaoma@gmail.com";
std1.StateOfOrigin = "Lagos";

Student std2 = new Student();   
std2.FullName = "Ann";
std2.Age = 15;
std2.Gender = "Female";
std2.Email = "Ann@gmail.com";
std2.StateOfOrigin = "Benin";

Student std3 = new Student();   
std3.FullName = "Mathew";
std3.Age = 27;
std3.Gender = "Male";
std3.Email = "mathew@gmail.com";
std3.StateOfOrigin = "Abuja";

student.Add(std1);
student.Add(std2);
student.Add(std3);

foreach(Student std in student)
{
    Console.WriteLine("+++++++++============++++++++");
    Console.WriteLine($"Id : {std.StudentId}");
    Console.WriteLine($"Name : {std.FullName}");
    Console.WriteLine($"Age : {std.Age}");
    Console.WriteLine($"Gender : {std.Email}");
    Console.WriteLine($"State of Origin : {std.StateOfOrigin}");
}



