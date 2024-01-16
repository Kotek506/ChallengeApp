namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {

        [Test]
        public void CheckEmployeeStatistics()
        {
            //arrange
            var employee = new Employee("john", "cena");
            employee.AddGrade(5);
            employee.AddGrade(6);
            employee.AddGrade(10);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(statistics.Max, 10);
            Assert.AreEqual(statistics.Min, 5);
            Assert.AreEqual(statistics.Average, 7);
        }
    }
}

 