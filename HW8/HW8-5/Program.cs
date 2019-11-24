using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Assistant newAssistant = new Assistant(true);
            newAssistant.IntroduceYourself();
            newAssistant.CheckAnExam();
            newAssistant.CheckHomework();
            newAssistant.ConductExercise("Biology");
            newAssistant.IsChiefAssistant = true;
            newAssistant.NameAndStatus("Ivan");
            Console.Write("\n");
            CollegeTeacher newCollegeTeacher = new CollegeTeacher();
            newCollegeTeacher.IntroduceYourself("Stoyan", "Sofia University");
            newCollegeTeacher.CheckHomework();
            Console.Write("\n");
            Lecturer NewLecturer = new Lecturer();
            NewLecturer.WorkExperience = -12;
            Console.WriteLine(NewLecturer.WorkExperience);
            Console.Write("\n");
            Professor newProfessor = new Professor();
            newProfessor.TitleAndWorkExperience("Master of Science", 12);
            newProfessor.CheckHomework();
            Console.Write("\n");
            SchoolTeacher newSchoolTeacher = new SchoolTeacher(new List<string> { "2A", "4B", "5B", "6Z" });
            newSchoolTeacher.PrintClasses();  
            newSchoolTeacher.CheckHomework();
            Console.Write("\n");
            Console.WriteLine($"Person count is now: {Person.personCount}");

            SchoolTeacher schoolTeacher2= new SchoolTeacher();
            schoolTeacher2.АddClasses("6г", "6т", "7хх");
            schoolTeacher2.PrintClasses();
            Console.WriteLine("\n");
            SchoolTeacher schoolTeacher3 = new SchoolTeacher(new List<string>{"4r","10v","6e"});
            schoolTeacher3.PrintClasses();

            



        }
    }
}
