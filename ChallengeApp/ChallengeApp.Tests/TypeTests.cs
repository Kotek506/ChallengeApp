namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void ValueShouldNotBeEqual()
        {
            //arrange
            int number1 = 1;
            int number2 = 2;

            // act


            // assert
            Assert.AreNotEqual(number1, number2);
        }
        [Test]
        public void DoubleShouldNotBeEqual()
        {
            //arrange
            var number1 = 1.1;
            var number2 = 2.2;

            // act


            // assert
            Assert.AreNotEqual(number1, number2);
        }

        [Test]
        public void GetUserShouldReturnDifferent()
        {
            //arrange
            var user1 = GetUser("Andreas");
            var user2 = GetUser("Tomcio");

            // act


            // assert
            Assert.AreNotEqual(user1, user2);
        }
        private User GetUser(string name)
        {
            return new User(name);

        }
        [Test]
        public void GetUserLoginShouldReturnEqual()
        {
            //arrange
            var user3 = GetUser("Andrew");
            var user4 = GetUser("Andrew");

            // act


            // assert
            Assert.AreEqual(user3.Login, user4.Login);
        }

    }
}
