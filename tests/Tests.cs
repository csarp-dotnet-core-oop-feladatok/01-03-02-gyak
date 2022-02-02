using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using StudentProject;

namespace StudentProject.Tests
{
    [TestClass()]
    public class Tests
    {
        [TestMethod()]
        public void TestKonstrktorAlsos()
        {
            string expected = string.Empty;
            string actual = "somthing";
            try
            {
                Student student = new Student("Jeles János", 3);
                expected = "Jeles János 3. osztályos tanuló. Alsó tagozatra jár.\r\n";

                StringWriter sw = new StringWriter();
                Console.SetOut(sw);
                student.ToConsole();
                actual = sw.ToString();
            }
            catch (Exception e)
            {
                Assert.Fail("Student osztály kivételt dob!");
            }

            Assert.AreEqual(expected, actual, "A Student->Konstruktor nem tárolja el a paraméterben lévő adatokat vagy a Balance->ToConsole nem megfelően működik.");
        }

        [TestMethod()]
        public void TestKonstrktorFelsos()
        {
            string expected = string.Empty;
            string actual = "somthing";
            try
            {
                Student student = new Student("Jeles János", 5);
                expected = "Jeles János 5. osztályos tanuló. Felső tagozatra jár.\r\n";

                StringWriter sw = new StringWriter();
                Console.SetOut(sw);
                student.ToConsole();
                actual = sw.ToString();
            }
            catch (Exception e)
            {
                Assert.Fail("Student osztály kivételt dob!");
            }

            Assert.AreEqual(expected, actual, "A Student->Konstruktor nem tárolja el a paraméterben lévő adatokat vagy a Balance->ToConsole nem megfelően működik.");
        }

        [TestMethod()]
        public void TestKonstrktorGimnazista()
        {
            string expected = string.Empty;
            string actual = "somthing";
            try
            {
                Student student = new Student("Jeles János", 10);
                expected = "Jeles János 10. osztályos tanuló. Készül az érettségire.\r\n";

                StringWriter sw = new StringWriter();
                Console.SetOut(sw);
                student.ToConsole();
                actual = sw.ToString();
            }
            catch (Exception e)
            {
                Assert.Fail("Student osztály kivételt dob!");
            }
            Assert.AreEqual(expected, actual, "A Student->Konstruktor nem tárolja el a paraméterben lévő adatokat vagy a Balance->ToConsole nem megfelően működik.");
        }

        [TestMethod()]
        public void TestKonstrktorNullaNegativ()
        {
            string expected = string.Empty;
            string actual = "somthing";
            try
            {
                Student student = new Student("Jeles János", 0);
                expected = "Jeles János 1. osztályos tanuló. Alsó tagozatra jár.\r\n";

                StringWriter sw = new StringWriter();
                Console.SetOut(sw);
                student.ToConsole();
                actual = sw.ToString();
            }
            catch (Exception e)
            {
                Assert.Fail("Student osztály kivételt dob!");
            }
            Assert.AreEqual(expected, actual, "A Student->Konstruktor nem tárolja el a paraméterben lévő adatokat vagy a Balance->ToConsole nem megfelően működik.");
        }

        [TestMethod()]
        public void TestKonstrktorNullaTulNagy()
        {
            string expected = string.Empty;
            string actual = "somthing";
            try
            {
                Student student = new Student("Jeles János", 13);
                expected = "Jeles János 1. osztályos tanuló. Alsó tagozatra jár.\r\n";

                StringWriter sw = new StringWriter();
                Console.SetOut(sw);
                student.ToConsole();
                actual = sw.ToString();
            }
            catch (Exception e)
            {
                Assert.Fail("Student osztály kivételt dob!");
            }
            Assert.AreEqual(expected, actual, "A Student->Konstruktor nem tárolja el a paraméterben lévő adatokat vagy a Balance->ToConsole nem megfelően működik.");
        }

        [TestMethod()]
        public void TestKonstrktorVegezOsztalyt()
        {
            string expected = string.Empty;
            string actual = "somthing";
            try
            {
                Student student = new Student("Jeles János", 2);
                student.CompletesStudentTheClass();
                expected = "Jeles János 3. osztályos tanuló. Alsó tagozatra jár.\r\n";

                StringWriter sw = new StringWriter();
                Console.SetOut(sw);
                student.ToConsole();
                actual = sw.ToString();
            }
            catch (Exception e)
            {
                Assert.Fail("Student osztály kivételt dob!");
            }
            Assert.AreEqual(expected, actual, "A Student->Konstruktor nem tárolja el a paraméterben lévő adatokat vagy a Balance->ToConsole nem megfelően működik.");
        }

        [TestMethod()]
        public void TestKonstrktorVegezAlsot()
        {
            string expected = string.Empty;
            string actual = "somthing";
            try
            {
                Student student = new Student("Jeles János", 4);
                student.CompletesStudentTheClass();
                expected = "Jeles János 5. osztályos tanuló. Felső tagozatra jár.\r\n";

                StringWriter sw = new StringWriter();
                Console.SetOut(sw);
                student.ToConsole();
                actual = sw.ToString();
            }
            catch (Exception e)
            {
                Assert.Fail("Student osztály kivételt dob!");
            }
            Assert.AreEqual(expected, actual, "A Student->Konstruktor nem tárolja el a paraméterben lévő adatokat vagy a Balance->ToConsole nem megfelően működik.");
        }

        [TestMethod()]
        public void TestKonstrktorVegezFelsot()
        {
            string expected = string.Empty;
            string actual = "somthing";
            try
            {
                Student student = new Student("Jeles János", 8);
                student.CompletesStudentTheClass();
                expected = "Jeles János 9. osztályos tanuló. Készül az érettségire.\r\n";

                StringWriter sw = new StringWriter();
                Console.SetOut(sw);
                student.ToConsole();
                actual = sw.ToString();
            }
            catch (Exception e)
            {
                Assert.Fail("Student osztály kivételt dob!");
            }
            Assert.AreEqual(expected, actual, "A Student->Konstruktor nem tárolja el a paraméterben lévő adatokat vagy a Balance->ToConsole nem megfelően működik.");
        }
    }
}