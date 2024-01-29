namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {

        [Test]
        public void CheckEmployeeStatistics()
        {
            //arrange
            var employee = new Employee();
            employee.AddGrade('B');
            employee.AddGrade('E');
            employee.AddGrade("50");
            employee.AddGrade(50);
            employee.AddGrade("C");


            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(statistics.Max, 80);
            Assert.AreEqual(statistics.Min, 20);
            Assert.AreEqual(statistics.Average, 52);
            Assert.AreEqual(statistics.AverageLetter, 'C');
        }
    }
}

 