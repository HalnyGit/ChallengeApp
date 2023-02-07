namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void TestbyValString()
        {
            // arrange
            string word1 = "Ewa";
            string word2 = "Ewa";

            //assert
            Assert.AreEqual(word1, word2);
        }
        [Test]
        public void TestbyValInteger()
        {
            // arrange
            int num1 = 1;
            int num2 = 1;

            //assert
            Assert.AreEqual(num1, num2);
        }
        [Test]
        public void TestbyValDouble()
        {
            // arrange
            double Num1 = 6.626e-34;
            double Num2 = 6.626e-34;

            //assert
            Assert.AreEqual(Num1, Num2);
        }
        [Test]
        public void TestbyValDoubleNotation()
        {
            // arrange
            double Num1 = 1.2e-2;
            double Num2 = 0.012;

            //assert
            Assert.AreEqual(Num1, Num2);
        }
        [Test]
        public void TestbyRef()
        {
            // arrange
            var user1 = GetUser("Adam", "abc");
            var user2 = GetUser("Adam", "abc");

            //assert
            Assert.AreNotEqual(user1, user2);
        }

        private User GetUser(string login, string password)
        {
            return new User(login, password);
        }
    }
}
