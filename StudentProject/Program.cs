// A feladat a repo-ban olvasható

using System;

namespace StudentProject
{
    public class Student
    {
        /// <summary>
        /// évfolyam adattag
        /// </summary>
        private int studentClass;
        /// <summary>
        /// tanuló neve
        /// </summary>
        private string studentName;
        /// <summary>
        /// konstruktor
        /// </summary>
        /// <param name="studentClass">osztály</param>
        /// <param name="studentName">név</param>
        public Student(string studentName, int studentClass)
        {
            if ((studentClass <= 0) || (studentClass > 12))
            {
                this.studentClass = 1;
            }
            else
            {
                this.studentClass = studentClass;
            }
            this.studentName = studentName;
        }
        /// <summary>
        /// ToConsole metódus
        /// </summary>
        public void ToConsole()
        {
            Console.Write(studentName + " " + studentClass + ". osztályos tanuló. ");
            if (studentClass < 5)
            {
                Console.WriteLine("Alsó tagozatra jár.");
            }
            else if (studentClass > 8)
            {
                Console.WriteLine("Készül az érettségire.");
            }
            else
            {
                Console.WriteLine("Felső tagozatra jár.");
            }
        }
        /// <summary>
        /// CompletesStudentTheClass metódus
        /// </summary>
        public void CompletesStudentTheClass()
        {
            studentClass = studentClass + 1;
        }
    }

    class Program
    {
       

        static void Main(string[] args)
        {
            Student studentJhon = new Student("Jeles János", 3);
            studentJhon.ToConsole();
            studentJhon.CompletesStudentTheClass();
            studentJhon.ToConsole();
            studentJhon.CompletesStudentTheClass();
            studentJhon.ToConsole();

            Student studentPeter = new Student("Példás Péter", 7);
            studentPeter.ToConsole();
            studentPeter.CompletesStudentTheClass();
            studentPeter.ToConsole();
            studentPeter.CompletesStudentTheClass();
            studentPeter.ToConsole();
        }
    }
}
