namespace ChallengeApp.Tests
{
    public class Test
    {
        [Test]
        public void CheckMaxGrade()
        {
            // arrange
            var employee = new Employee("Ewa", "Nowak");
            //act
            employee.AddGrade(5);
            employee.AddGrade(2);
            employee.AddGrade(3);
            var stats = employee.GetStatistics();
            //assert
            Assert.That(stats.Max, Is.EqualTo(5));
        }
        [Test]
        public void CheckMinGrade()
        {
            // arrange
            var employee = new Employee("Ewa", "Nowak");
            //act
            employee.AddGrade(5);
            employee.AddGrade(2);
            employee.AddGrade(3);
            var stats = employee.GetStatistics();
            //assert
            Assert.That(stats.Min, Is.EqualTo(2));
        }
        [Test]
        public void CheckAverageGrade()
        {
            // arrange
            var employee = new Employee("Ewa", "Nowak");
            //act
            employee.AddGrade(5);
            employee.AddGrade(2);
            employee.AddGrade(5);
            var stats = employee.GetStatistics();
            //assert
            Assert.That(stats.Average, Is.EqualTo(4));
        }
    }
}
