
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace VY
{

    class Students : Object
    {
        private string name;
        private string surname;
        private string group;
        private int count;

        public string Name { get => name; set => name = value; }
        public string Group { get => group; set => group = value; }
        public string Surname { get => surname; set => surname = value; }
        public Int32 Count { get => count; set => count = value; }

        public Students(string group, string surname, string name, int count)
        {
            this.Name = name;
            this.Surname = surname;
            this.Group = group;
            this.count = count;
        }
        public Students()
        {
            this.Name = "";
            this.Group = "";
            this.Surname = "";
        }
        public static Students[] Sort(Students[] students)
        {
            {

                for (int i = 0; i < students.Length; i++)
                {
                    for (int j = i + 1; j < students.Length; j++)
                    {
                        if (students[i].surname == students[j].surname && students[i].name == students[j].name && students[i].group == students[j].group)
                        {
                            var temp = students[i];
                            students[i] = students[j];
                            students[j] = temp;
                        }
                    }
                }

                return students;
            }
        }

        public static bool SaveAs(string path, Students[] stu)
        {
            if (File.Exists(path.ToString()))
            {

                Console.WriteLine("Файл уже существует,перезаписать файл?(Y/N)");
                string answer = Console.ReadLine();
                if (answer == "y" || answer == "Y" || answer == "у" || answer == "У" || answer == "д" || answer == "Д")
                {
                    File.Delete(path);
                    TextWriter opnFile = new StreamWriter(path);
                    foreach (var stud in stu)
                    {
                        opnFile.WriteLine(stud.ToString());
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                using (TextWriter opnFile = new StreamWriter(path.ToString()))
                {
                    foreach (var stud in stu)
                    {
                        opnFile.WriteLine(stud.ToString());
                    }
                    opnFile.Close();
                }
                return true;
            }
        }
        public override string ToString()
        {
            return "Группа:" + Group + "\nФамилия Студента:" + Surname + "\nИмя Студента:" + Name + "\n";
        }

    }
}
