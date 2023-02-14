using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Reflection;

namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {

        private const string fileName = "grades.txt";

       public EmployeeInFile(string name, string surname)
            : base(name, surname)
        {
        }


        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }
            }
            else
            {
                throw new Exception("Wartość musi być w przedziale od 0 do 100");
            }
        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else if (char.TryParse(grade, out char character))
            {
                this.AddGrade(character);
            }
            else
            {
                throw new Exception("Wprowadzono niepoprawną wartość");
            }
        }

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A' or 'a':
                    this.AddGrade(100);
                    break;
                case 'B' or 'b':
                    this.AddGrade(80);
                    break;
                case 'C' or 'c':
                    this.AddGrade(60);
                    break;
                case 'D' or 'd':
                    this.AddGrade(40);
                    break;
                case 'E' or 'e':
                    this.AddGrade(20);
                    break;
                default:
                    throw new Exception("Niepoprawna litera");
            }
        }

        public override void AddGrade(long grade)
        {
            float result = grade;
            this.AddGrade(result);
        }

        public override void AddGrade(double grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }

        public override void AddGrade(decimal grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();

            statistics.Average = 0F;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    int counter = 0;
                    while (line != null)
                    {
                        var number = float.Parse(line);

                        statistics.Max = Math.Max(statistics.Max, number);
                        statistics.Min = Math.Min(statistics.Min, number);
                        statistics.Average += number;
                        counter++;
                    }

                    statistics.Average = (float)Math.Round(statistics.Average / counter, 2);

                    switch (statistics.Average)
                    {
                        case var average when average >= 80:
                            statistics.AverageLetter = 'A';
                            break;
                        case var average when average >= 60:
                            statistics.AverageLetter = 'B';
                            break;
                        case var average when average >= 40:
                            statistics.AverageLetter = 'B';
                            break;
                        case var average when average >= 20:
                            statistics.AverageLetter = 'D';
                            break;
                        default:
                            statistics.AverageLetter = 'E';
                            break;
                    }
                }
            }
            return statistics;
        }
    }
}
