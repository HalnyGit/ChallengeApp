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
        public void CheckAddGradeAsChar()
        {
            // arrange
            var employee = new Employee();

            //act
            employee.AddGrade('a');
            employee.AddGrade(2);
            float totalPoints = employee.Result;

            //assert
            Assert.That(totalPoints, Is.EqualTo(102));
        }

        [Test]
        public void CheckAddGradeAsIncorrectChar()
        {
            // arrange
            var employee = new Employee();

            //act
            employee.AddGrade('g');
            employee.AddGrade(2);
            float totalPoints = employee.Result;

            //assert
            Assert.That(totalPoints, Is.EqualTo(2));
        }

        [Test]
        public void CheckAverageLetter()
        {
            // arrange
            var employee = new Employee();

            //act
            employee.AddGrade(81);
            char avgLetter = employee.GetStatistics().AverageLetter;

            //assert
            Assert.That(avgLetter, Is.EqualTo('A'));
        }
    }
}
