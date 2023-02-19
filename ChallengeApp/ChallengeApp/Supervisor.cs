

//namespace ChallengeApp
//{
//    public class Supervisor : IEmployee
//    {
//        private List<float> grades = new List<float>();

//        public Supervisor(string name, string surname)
//        {
//            this.Name = name;
//            this.Surname = surname;
//        }

//        public string Name { get; private set; }
//        public string Surname { get; private set; }

//        public float Result
//        {
//            get
//            {
//                return this.grades.Sum();
//            }
//        }

//        public void AddGrade(float grade)
//        {
//            if (grade >= 0 && grade <= 100)
//            {
//                this.grades.Add(grade);
//            }
//            else
//            {
//                throw new Exception("Wartość musi być w przedziale od 0 do 100");
//            }
//        }

//        public void AddGrade(string grade)
//        { 
//            int addOnFactor = 0;
 
//            if (grade.Contains("+"))
//            {
//                addOnFactor = 5;    
//            }
//            else if (grade.Contains("-"))
//            {
//                addOnFactor = -5;
//            }

//            char[] charsToTrim = { '+', '-' };
//            grade = grade.Trim(charsToTrim);

//            if (float.TryParse(grade, out float result))
//            {
//                switch (result)
//                {
//                    case 6:
//                        this.grades.Add(100 + addOnFactor);
//                        break;
//                    case 5:
//                        this.grades.Add(80 + addOnFactor);
//                        break;
//                    case 4:
//                        this.grades.Add(60 + addOnFactor);
//                        break;
//                    case 3:
//                        this.grades.Add(40 + addOnFactor);
//                        break;
//                    case 2:
//                        this.grades.Add(20 + addOnFactor);
//                        break;
//                    case 1:
//                        this.grades.Add(0 + addOnFactor);
//                        break;
//                    default:
//                        throw new Exception("Niepoprawna litera");
//                }
//            }
//            else if (char.TryParse(grade, out char character))
//            {
//                this.AddGrade(character);
//            }
//            else
//            {
//                throw new Exception("Wprowadzono niepoprawną wartość");
//            }
//        }

//        public void AddGrade(char grade)
//        {
//            switch (grade)
//            {
//                case 'A':
//                case 'a':
//                    this.grades.Add(100);
//                    break;
//                case 'B':
//                case 'b':
//                    this.grades.Add(80);
//                    break;
//                case 'C':
//                case 'c':
//                    this.grades.Add(60);
//                    break;
//                case 'D':
//                case 'd':
//                    this.grades.Add(40);
//                    break;
//                case 'E':
//                case 'e':
//                    this.grades.Add(20);
//                    break;
//                default:
//                    throw new Exception("Niepoprawna litera");
//            }
//        }

//        public void AddGrade(long grade)
//        {
//            float result = grade;
//            this.AddGrade(result);
//        }

//        public void AddGrade(double grade)
//        {
//            float result = (float)grade;
//            this.AddGrade(result);
//        }

//        public void AddGrade(decimal grade)
//        {
//            float result = (float)grade;
//            this.AddGrade(result);
//        }

//        public Statistics GetStatistics()
//        {
//            var statistics = new Statistics();
//            statistics.Average = 0F;
//            statistics.Max = float.MinValue;
//            statistics.Min = float.MaxValue;

//            foreach (var grade in this.grades)
//            {
//                statistics.Max = Math.Max(statistics.Max, grade);
//                statistics.Min = Math.Min(statistics.Min, grade);
//                statistics.Average += grade;
//            }

//            statistics.Average = (float)Math.Round(statistics.Average / this.grades.Count, 2);


//            switch (statistics.Average)
//            {
//                case var average when average >= 80:
//                    statistics.AverageLetter = 'A';
//                    break;
//                case var average when average >= 60:
//                    statistics.AverageLetter = 'B';
//                    break;
//                case var average when average >= 40:
//                    statistics.AverageLetter = 'B';
//                    break;
//                case var average when average >= 20:
//                    statistics.AverageLetter = 'D';
//                    break;
//                default:
//                    statistics.AverageLetter = 'E';
//                    break;
//            }
//            return statistics;
//        }
//    }
//}

