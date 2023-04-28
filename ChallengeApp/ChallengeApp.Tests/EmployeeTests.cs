
using ChallengeApp;

namespace EmployeeTests
{

    public class EmployeeTests
    {

        [Test]
        public void DifferentStatiscicsResult_ShouldReturnMinMaxAverage()
        {

            //arrange

            var employee = new Employee("Monika", "Rogiñska", "K");
            employee.AddGrade('a');
            employee.AddGrade("100");
            employee.AddGrade(100);

            //act

            var statistics = employee.GetStatistics();


            //assert
            Assert.AreEqual(100, statistics.Average);

        }

        [Test]
        public void WriteNumberValue_ShouldReturnAverage()
        {
            var employee = new Employee("Monika", "Rogiñska", "K");
            employee.AddGrade(30);
            employee.AddGrade(80);
            employee.AddGrade(100);


            var statistics = employee.GetStatistics();
            Assert.AreEqual(70, statistics.Average);
        }
        [Test]
        public void AverageValueUnderLetterTestByChar()
        {
            var employee = new Employee("Monika", "Rogiñska", "K");
            employee.AddGrade(35);
            employee.AddGrade(67);
            employee.AddGrade(23);


            var statistics = employee.GetStatistics();
            Assert.AreEqual('C', statistics.AverageLetter);
        }

        [Test]
        public void GetMinStatisticsValue()
        {
            var employee = new Employee("Monika", "Rogiñska", "K");
            employee.AddGrade('C');
            employee.AddGrade('d');
            employee.AddGrade('A');


            var statistics = employee.GetStatistics();
            Assert.AreEqual(40, statistics.Min);
        }
    }
}