using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VY
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Введите кол-во студентов:");
                int count = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n");
                Students[] Student = new Students[count];
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("Введите Имя студента:");
                    var name = Console.ReadLine();
                    Console.WriteLine("Введите Фамилию студента:");
                    var surename = Console.ReadLine();
                    Console.WriteLine("Введите название группы");
                    var group = Console.ReadLine();
                    Student[i] = new Students(group, surename, name, count);
                }
                Student = Students.Sort(Student);
                foreach (var students in Student)
                {
                    Console.WriteLine(Student.ToString());
                }
                Console.WriteLine("Введите путь для сохранения файлов");
                var path = Console.ReadLine();
                path = "Text.txt";
                Students.SaveAs(path, Student);
                Console.ReadLine();
            }
            catch (Exception exe)
            {
                Console.WriteLine(exe.Message);
            }

        }
    }
}
