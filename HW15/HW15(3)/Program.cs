using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW15_3_
{ 
   
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Ivan");
            Teacher teacher = new Teacher("Stoyan");

            ConsoleWriteLineRepository<Student> writeLineRepositoryForStudents = new ConsoleWriteLineRepository<Student>();
            ConsoleWriteLineRepository<Teacher> writeLineRepositoryForTeachers = new ConsoleWriteLineRepository<Teacher>();

            ConsoleWriteRepository<Student> writeRepositoryForStudents = new ConsoleWriteRepository<Student>();
            ConsoleWriteRepository<Teacher> writeRepositoryForTeachers = new ConsoleWriteRepository<Teacher>();

            writeLineRepositoryForStudents.Create(student);
            writeLineRepositoryForTeachers.Create(teacher);

            writeRepositoryForStudents.Create(student);
            writeRepositoryForTeachers.Create(teacher);
        }
    }
}
