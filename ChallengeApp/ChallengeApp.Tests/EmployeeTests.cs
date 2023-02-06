namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void CheckSumOfPoints()
        {
            // arrange
            var employee = new Employee("Ewa", "Nowak");

            //act
            employee.AddScore(5);
            employee.AddScore(2);
            int totalPoints = employee.Result;

            //assert
            Assert.That(totalPoints, Is.EqualTo(7));
        }
        [Test]
        public void CheckSubstructionOfPoints()
        {
            // arrange
            var employee = new Employee("Ewa", "Nowak");

            //act
            employee.AddScore(5);
            employee.AddScore(2);
            employee.AddScore(-7);
            int totalPoints = employee.Result;

            //assert
            Assert.Zero(totalPoints);
        }
        [Test]
        public void CheckSubstructionOfPointsBelowZero()
        {
            // arrange
            var badEmployee = new Employee("Ewa", "Nowak");

            //act
            badEmployee.AddScore(5);
            badEmployee.AddScore(2);
            badEmployee.AddScore(-10);
            int totalPoints = badEmployee.Result;

            //assert
            Assert.Negative(totalPoints);
        }
    }
}