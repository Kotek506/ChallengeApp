namespace ChallengeApp.Tests
{
    public class Tests
    {
       
        [Test]
        public void WhenEmpCollectPositiveScores_ShouldReturnCorrectResult()
        {
            //arrange
            var user = new Employee("john", "cena", 44);
            user.AddScore(5);
            user.AddScore(6);
            user.AddScore(10);

            // act
            var result = user.Result;

            // assert
            Assert.AreEqual(21, result);
        }

        [Test]
        public void WhenEmpCollectNegativeScores_ShouldReturnCorrectResult()
        {
            //arrange
            var user = new Employee("john", "swinia", 29);
            user.AddScore(-5);
            user.AddScore(-6);
            user.AddScore(-10);

            // act
            var result = user.Result;

            // assert
            Assert.AreEqual(-21, result);
        }

        [Test]
        public void WhenEmpCollectAllScores_ShouldReturnCorrectResult()
        {
            //arrange
            var user = new Employee("najnizsza", "cena", 12);
            user.AddScore(5);
            user.AddScore(6);
            user.AddScore(-10);

            // act
            var result = user.Result;

            // assert
            Assert.AreEqual(1, result);
        }
    }
}