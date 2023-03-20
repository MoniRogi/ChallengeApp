
using ChallengeApp;

namespace EmployeeTests
{

    public class Tests
    {

        [Test]
        public void WhenEmployeeCollectScores_ShouldCorrectResult()
        {

            //arrange

            var employee = new Employee("Monika", "Rogalska", 16);
            employee.AddScore(3);
            employee.AddScore(-4);
            employee.AddScore(1);
            employee.AddScore(-7);
            employee.AddScore(10);

            //act

            var result = employee.Result;


            //assert
            Assert.AreEqual(3, result);

        }
    }
}