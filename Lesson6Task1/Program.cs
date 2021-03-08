using System;

namespace Lesson6Task1
{
    class Program
    {
        static void Main()
        {
            Student student0 = new Student("Alieksei", "Valkovich");
            Student student1 = new Student("Viktor", "Popov  ");
            Student student2 = new Student("Genady", "Gorin  ");
            Student student3 = new Student("Shapka", "Ushanka");
            Student student4 = new Student("Bus", "Trolley   ");
            Student student5 = new Student("Aleksandr", "Shevchuk");
            Student student6 = new Student("Gerbert", "Shildt    ");
            Student student7 = new Student("Jeffrey", "Richter    ");
            Student student8 = new Student("Sam", "Fisher    ");
            Student student9 = new Student("Jack", "Sparrow    ");
            Student student10 = new Student("Seryozha", "Makarosha");

            Group AspDotNetCoreDevelopers = new Group(220116, student0, student1, student2, student3, student4);
            Group UnityDevelopers = new Group(220117, student5, student6, student7, student8, student9);

            Console.WriteLine(new string('-',120));
            Console.WriteLine(AspDotNetCoreDevelopers.ShowGroupInfo());
            Console.WriteLine(UnityDevelopers.ShowGroupInfo());
            Console.WriteLine(new string('-', 120));

            UnityDevelopers.MoveStudentToAnotherGroup(UnityDevelopers[0], AspDotNetCoreDevelopers);
            UnityDevelopers.MoveStudentToAnotherGroup(UnityDevelopers[1], AspDotNetCoreDevelopers);
            UnityDevelopers.MoveStudentToAnotherGroup(UnityDevelopers[2], AspDotNetCoreDevelopers);
            AspDotNetCoreDevelopers.MoveStudentToAnotherGroup(AspDotNetCoreDevelopers[2], UnityDevelopers);

            Console.WriteLine(new string('-', 120));
            Console.WriteLine(AspDotNetCoreDevelopers.ShowGroupInfo());
            Console.WriteLine(UnityDevelopers.ShowGroupInfo());
            Console.WriteLine(new string('-', 120));
        }
    }
}
