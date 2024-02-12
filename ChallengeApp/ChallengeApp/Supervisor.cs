namespace ChallengeApp
{
    public class Supervisor : IEmployee
    {
        private List<float> grades = new List<float>();

        public Supervisor(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }


        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
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
        public void AddGrade(int grade)
        {
            float fint = (float)grade;
            this.AddGrade(fint);
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
                case 'b':
                    this.AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    this.AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    this.AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    this.AddGrade(20);
                    break;
                default:
                    throw new Exception("Wrong char letter (should be in range A-E)");
            }
        }
        public void AddGrade(string grade)
        {
            var table = new[] { "1", "2", "-2", "2-", "+2", "2+", "3", "-3", "3-", "+3", "3+", "4", "-4", "4-", "+4", "4+", "5", "-5", "5-", "+5", "5+", "6", "-6", "6-" };
            if (table.Contains(grade))
            {
                switch (grade)
                {
                    case "6":
                        this.AddGrade(100);
                        break;
                    case "-6":
                    case "6-":
                        this.AddGrade(95);
                        break;
                    case "5":
                        this.AddGrade(80);
                        break;
                    case "+5":
                    case "5+":
                        this.AddGrade(85);
                        break;
                    case "-5":
                    case "5-":
                        this.AddGrade(75);
                        break;
                    case "4":
                        this.AddGrade(60);
                        break;
                    case "+4":
                    case "4+":
                        this.AddGrade(65);
                        break;
                    case "-4":
                    case "4-":
                        this.AddGrade(55);
                        break;
                    case "3":
                        this.AddGrade(40);
                        break;
                    case "+3":
                    case "3+":
                        this.AddGrade(45);
                        break;
                    case "-3":
                    case "3-":
                        this.AddGrade(35);
                        break;
                    case "2":
                        this.AddGrade(20);
                        break;
                    case "+2":
                    case "2+":
                        this.AddGrade(25);
                        break;
                    case "-2":
                    case "2-":
                        this.AddGrade(15);
                        break;
                    case "1":
                        this.AddGrade(0);
                        break;
                    default:
                        throw new Exception("Wrong Grade - Please use school grades");
                }
            }
            else if (float.TryParse(grade, out float result))
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
                    case "b":
                        this.AddGrade(80);
                        break;
                    case "C":
                    case "c":
                        this.AddGrade(60);
                        break;
                    case "D":
                    case "d":
                        this.AddGrade(40);
                        break;
                    case "E":
                    case "e":
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
            return statistics;
        }
    }
}
