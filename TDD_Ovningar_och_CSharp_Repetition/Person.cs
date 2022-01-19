
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD_Ovningar_och_CSharp_Repetition
{
    [TestClass]
    public class Person
    {
        private string Name { get; set; }
        private int Age { get; set; }
        private DateTime BirthDate { get; set; }
        public Person(){}
        public Person(string name, DateTime birthDate)
        {
            Name = name;
            Age = getAge(birthDate);
        }

        private int getAge(DateTime birthDate)
        {
            return (int)((DateTime.Now - birthDate).TotalDays / 365.2425);
        }

        [TestMethod]
        public void PersonTest_Constructor()
        {
            var person = new Person("Elvis", GetdateForAge(41));
            Assert.AreEqual("Elvis", person.Name);
            Assert.AreEqual(41, person.Age);
        }

        [TestMethod]
        public void PersonTest_Constructor_Null_Name()
        {
            var person = new Person(null, new DateTime(2021, 6, 26));
            Assert.IsNull(person.Name);
            Assert.AreEqual((int)((DateTime.Now - (new DateTime(2021, 6, 26))).TotalDays/365.2425), person.Age);
        }

        public bool CanGetMarried
        {
            get { return Age >= 18; }
        }

        public bool CanRetireByAge
        {
            get { return Age >= 62; }
        }

        [TestMethod]
        public void CanGetMarried_Test_Age_16()
        {
            Person pelle = new Person("Pelle", new DateTime(2005, 1, 1));
            Assert.IsFalse(pelle.CanGetMarried);
            Assert.AreEqual(16, pelle.Age);
        }

        public void CanGetMarried_Test_Age_18()
        {
            Person johan = new Person("Johan", new DateTime(2003, 1, 1));
            Assert.IsTrue(johan.CanGetMarried);
            Assert.AreEqual(18, johan.Age);
        }

        private DateTime GetdateForAge(int years)
        {
            return DateTime.Now.AddYears(-years);
        }
    }
}
