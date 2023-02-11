namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();

        public Employee()
        {
        }

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        
        public float Result
        {
            get
            {
                return this.grades.Sum();
            }
        }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Wartość musi być w przedziale od 0 do 100");
                //Console.WriteLine("Wartość musi być w przedziale od 0 do 100");
            }   
        }

        public void AddGrade(string grade)
        {
            if(float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else if(char.TryParse(grade, out char character))
            {
                this.AddGrade(character);
            }
            else
            {
                throw new Exception("Wprowadzono niepoprawną wartość");
                //Console.WriteLine("Wprowadzono niepoprawną wartość");
            }
        }

        public void AddGrade(char grade)
        {
            switch (grade) 
            { 
                case'A':
                case'a':
                    this.grades.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.grades.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.grades.Add(20);
                    break;
                default:
                    throw new Exception("Niepoprawna litera");
                    //Console.WriteLine("Niepoprawna litera");
                    // break; przy throw juz niepotrzebny break
            }
        }

        public void AddGrade(long grade)
        {
                float result = grade;
                this.AddGrade(result);
        }

        public void AddGrade(double grade)
        {
                float result = (float)grade;
                this.AddGrade(result);
        }

        public void AddGrade(decimal grade)
        {
                float result = (float)grade;
                this.AddGrade(result);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0F;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach( var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average = (float)Math.Round(statistics.Average / this.grades.Count, 2);
            
          
            switch(statistics.Average)
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
            return statistics;
        }
    }
}
