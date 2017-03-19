using IW5_project;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingDemo
{
    [TestFixture]
    public class DBTests
    {
        [Test]
        public void Insert_Pass()
        {
            DBEntities db = new DBEntities();

            student student = new student();

            student.name = "Patrik";
            student.surname = "Burda";
            student.username = "Kamil";
            student.password = "Poruba";
            student.born_year = 1996;
            student.created_at = DateTime.Now;
            student.photo = "path";

            db.students.Add(student);

            db.SaveChanges();
        }

        [Test]
        public void GetData_Pass()
        {
            DBEntities db = new DBEntities();

            student student = new student();

            student.name = "Patrik";
            student.surname = "Burda";
            student.username = "Kamil";
            student.password = "Poruba";
            student.born_year = 1996;
            student.created_at = DateTime.Now;
            student.photo = "path";

            db.SaveChanges();

            Assert.AreEqual(student.name, "Patrik");
        }
    }
}
