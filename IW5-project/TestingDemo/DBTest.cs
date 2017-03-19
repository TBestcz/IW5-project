using System;
using IW5_project;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestingDemo
{
    [TestFixture]
    public class DBTest
    {
        [Test]
        public void ShouldInsertData()
        {
            DBEntities db = new DBEntities();

            student student = new student();

            student.name = "Patrik";
            student.surname = "Burda";
            student.username = "Kamil";
            student.password = "Poruba";
            student.photo = "path";

            db.students.Add(student);
            db.SaveChanges();

            Assert.Pass("student data insert passed");
        }
    }
}
