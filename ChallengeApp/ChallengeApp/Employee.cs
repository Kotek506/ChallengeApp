namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();

        public Employee()
        {
            //this.Name = name;
            //this.Surname = surname;
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
        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;
                case 'B':
                    this.grades.Add(80);
                    break;
                case 'C':
                    this.grades.Add(60);
                    break;
                case 'D':
                    this.grades.Add(40);
                    break;
                case 'E':
                    this.grades.Add(20);
                    break;
                default:
                    throw new Exception("Wrong char letter (should be in range A-E)");
            }

            // implementacja przed dniem 12
            //if (float.TryParse(grade.ToString(), out float fchar))
            //{
            //    this.AddGrade(fchar);
            //}
            //else
            //{
            //    Console.WriteLine("this is not a number");
            //}

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
                        this.grades.Add(100);
                        break;
                    case "B":
                        this.grades.Add(80);
                        break;
                    case "C":
                        this.grades.Add(60);
                        break;
                    case "D":
                        this.grades.Add(40);
                        break;
                    case "E":
                        this.grades.Add(20);
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

            {

            }

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
