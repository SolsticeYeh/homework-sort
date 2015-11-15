using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_sort
{
    class Program
    {
        private static List<Student> studentList;
        static void Main(string[] args)
        {
            studentList = new List<Student>();
            studentList.Add(new Student() { Age = 17, Name = "张叁", Num = "2015210666" });
            studentList.Add(new Student() { Age = 19, Name = "赵玖", Num = "2015210888" });
            studentList.Add(new Student() { Age = 18, Name = "王芭", Num = "2015210121" });
            studentList.Add(new Student() { Age = 21, Name = "李斯", Num = "2015210634" });
            Console.WriteLine("按照年龄排序");
            studentList.Sort();
            foreach (var item in studentList)
            {
                Console.Write(item.Name + "  " + item.Num + "  " + item.Age.ToString() + "\r\n");
            }
            Console.WriteLine();
            Console.WriteLine("按照名字排序");
            studentList.Sort(new SortName());
            foreach (var item in studentList)
            {
                Console.Write(item.Name + "  " + item.Num + "  " + item.Age.ToString() + "\r\n");
            }
            Console.WriteLine();
            Console.WriteLine("按照学号排序");
            studentList.Sort(new SortNum());
            foreach (var item in studentList)
            {
                Console.Write(item.Name + "  " + item.Num + "  " + item.Age.ToString() + "\r\n");
            }
        }

    }

    class Student : IComparable<Student>
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Num { get; set; }
        public int CompareTo(Student other)
        {
            return Age.CompareTo(other.Age);
        }
    }
    class SortName : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
    class SortNum : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return x.Num.CompareTo(y.Num);
        }
    }
}
