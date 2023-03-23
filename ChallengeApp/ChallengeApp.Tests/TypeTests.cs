

using ChallengeApp;
using System.Runtime.InteropServices;

namespace EmployeeTests
{
    public class TypeTests
    {
        [Test]
        public void GetIntValues_ShouldReturnCorectEquals()
        {
            //arrange
            var employee1 = GetEmployee("Kuba", "Włodarczyk", 23);
            var employee2 = GetEmployee("Marysia", "Bartczak", 26);
            var employee3 = GetEmployee("Grzegorz", "Boratyn", 18);

            //act

            //assert
            Assert.AreNotEqual(employee1, employee2);

        }
        private Employee GetEmployee(string name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }


        [Test]
        public void ComparisonOfNumbersValues()
        {

            //arrange
            int number1 = 56;
            int number2 = 56;

            //act

            //assert
            Assert.AreEqual(number1, number2);

        }

        [Test]
        public void ComparisonOfNameValues()
        {

            //arrange
            string name1 = "Ola";
            string name2 = "Ola";

            //act

            //assert
            Assert.AreEqual(name1, name2);
        }

        [Test]
        public void ComparisonOfNumbersValuesDiffrent()
        {

            //arrange
            long number1 = -66;
            long number2 = 100;

            //act

            //assert
            Assert.AreNotEqual(number1, number2);
        }
    }
}
