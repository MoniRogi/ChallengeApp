
using ChallengeApp;

namespace EmployeeTests
{

    public class EmployeeTests
    {

        [Test]
        public void DifferentStatiscicsResult_ShouldReturnMinMaxAverage()
        {

            //arrange

            var employee = new Employee("Monika", "Rogalska");
            employee.AddGrade(3);
            employee.AddGrade(-4);
            employee.AddGrade(1);
            employee.AddGrade(-7);
            employee.AddGrade(10);

            //act

            var statistics = employee.GetStatistics();


            //assert
            Assert.AreEqual(-7, statistics.Min);
            Assert.AreEqual(10, statistics.Max);
            Assert.AreEqual(Math.Round(0.6,2), Math.Round(statistics.Average,2));
            Assert.AreNotEqual(statistics.Min, statistics.Max);

        }
    }
}