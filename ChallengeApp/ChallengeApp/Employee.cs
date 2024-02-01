namespace ChallengeApp
{
    public class Employee : Person
    {
        private List<float> grades = new List<float>();

        public Employee(string name, string surname, string sex)
            : base(name, surname, sex) { }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.AddGrade(grade);
            }
            else
            {
                throw new Exception("Grade outside of 0-100 range");
            }
        }
        public void AddGrade(long grade)
        {
            float flong = (float)grade;
            this.AddGrade(flong);
        }
        public void AddGrade(double grade)
        {
            float fdouble = (float)grade;
            this.AddGrade(fdouble);
        }
        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.AddGrade(100);
                    break;
                case 'B':
                    this.AddGrade(80);
                    break;
                case 'C':
                    this.AddGrade(60);
                    break;
                case 'D':
                    this.AddGrade(40);
                    break;
                case 'E':
                    this.AddGrade(20);
                    break;
                default:
                    throw new Exception("Wrong char letter (should be in range A-E)");
            }
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                switch (grade)
                {
                    case "A":
                    case "a":
                        this.AddGrade(100);
                        break;
                    case "B":
                        this.AddGrade(80);
                        break;
                    case "C":
                        this.AddGrade(60);
                        break;
                    case "D":
                        this.AddGrade(40);
                        break;
                    case "E":
                        this.AddGrade(20);
                        break;
                    default:
                        throw new Exception("Wrong Letter (A-E) or no number in range 0-100 provided");
                }
            }
        }
        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average = statistics.Average / this.grades.Count;

            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
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
