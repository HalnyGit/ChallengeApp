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
            employee.AddGrade(5);
            employee.AddGrade(2);
            float totalPoints = employee.Result;

            //assert
            Assert.That(totalPoints, Is.EqualTo(7));
        }
        [Test]
        public void CheckSubstructionOfPoints()
        {
            // arrange
            var employee = new Employee("Ewa", "Nowak");

            //act
            employee.AddGrade(5);
            employee.AddGrade(2);
            employee.AddGrade(-7);
            float totalPoints = employee.Result;

            //assert
            Assert.Zero(totalPoints);
        }
        [Test]
        public void CheckSubstructionOfPointsBelowZero()
        {
            // arrange
            var badEmployee = new Employee("Ewa", "Nowak");

            //act
            badEmployee.AddGrade(5);
            badEmployee.AddGrade(2);
            badEmployee.AddGrade(-10);
            float totalPoints = badEmployee.Result;

            //assert
            Assert.Negative(totalPoints);
        }
    }
}