
using ChallengeApp;

namespace EmployeeTests
{

    public class EmployeeTests
    {

        [Test]
        public void DifferentStatiscicsResult_ShouldReturnMinMaxAverage()
        {

            //arrange

            var employee = new Employee("Monika", "Rogiñska");
            employee.AddGrade('a');
            employee.AddGrade("100");
            employee.AddGrade(100);

            //act

            var statistics = employee.GetStatistics();


            //assert
            Assert.AreEqual(100, statistics.Average);

        }
        

    }
}