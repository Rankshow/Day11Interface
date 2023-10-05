using Example5;
// using System.IO;

Student stds1 = new Student();
stds1.Name = "Jude";
stds1.State = "Lagos, yaba";
stds1.ExamNumber = "238495994EH";
stds1.SeatNumber = 005;
stds1.Provisional = "Oxygen";
StudentDetails(stds1);

Student stds2 = new Student();
stds2.Name = "Mike";
stds2.State = "Ogun, Ogbomoso";
stds2.ExamNumber = "103050554AJ";
stds2.SeatNumber = 004;
StudentDetails(stds2);

Student stds3 = new Student();
stds3.Name = "Philip";
stds3.State = "Abuja, gbabulada";
stds3.ExamNumber = "439494040404FY";
stds3.SeatNumber = 006;
StudentDetails(stds3);

static void StudentDetails(Student stds)
{
    Console.WriteLine("=======++++++++++++++=========");
    Console.WriteLine($"Student Name is {stds.Name}");
    Console.WriteLine($"Student State is {stds.State}");
    Console.WriteLine($"Student ExamNumber is {stds.ExamNumber}");
    Console.WriteLine($"Student SeatNumber is {stds.SeatNumber}");
    Console.WriteLine($"Student Provisional is {stds.Provisional}");
}

// string? path = @"C:\Bank\Student.Txt";

// try
// {
//     File.AppendAllText(path, StudentDetails(stds1).ToString());
// }
// catch(Exception e)
// {
//     Console.WriteLine($"Sorry, you enter a wrong file path {e.Message}");
// }


//     return stds.ToString();