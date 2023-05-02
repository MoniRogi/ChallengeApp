namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string filename = "grades.txt";
        public EmployeeInFile(string name, string surname, string sex)
            : base(name, surname, sex)
        {
        }

        public override void AddGrade(float grade)
        {
            using (var writer = File.AppendText(filename))
            {
                if (grade >= 0 && grade <= 100)

                {
                    writer.WriteLine(grade);
                }

                else
                {
                    throw new Exception("invalid grade value");
                }
            }
        }

        public override void AddGrade(double grade)
        {
            using (var writer = File.AppendText(filename))
            {
                writer.WriteLine(grade);
            }
        }

        public override void AddGrade(int grade)
        {
            using (var writer = File.AppendText(filename))
            {
                writer.WriteLine(grade);
            }
        }

        public override void AddGrade(char grade)
        {
            using (var writer = File.AppendText(filename))
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
                        throw new Exception("Wrong Letter");
                }
            }

        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                using (var writer = File.AppendText(filename))
                {
                    writer.WriteLine(result);
                }
            }
            else if (char.TryParse(grade, out char res))
            {
                using (var writer = File.AppendText(filename))
                {
                    writer.WriteLine(res);
                }
            }
            else
            {
                throw new Exception("String is not float or char");
            }
        }

        public override Statistics GetStatistics()
        {
            var gradesFromFile = this.ReadGradesFromFile();
            var result = this.CountStatistics(gradesFromFile);
            return result;
        }

        private List<float> ReadGradesFromFile()
        {
            var grades = new List<float>();
            if (File.Exists($"{filename}"))
            {

                using (var reader = File.OpenText($"{filename}"))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        grades.Add(number);
                        line = reader.ReadLine();
                    }

                }
            }
            return grades;
        }
        private List<float> CountStatistics(List<float> grades)
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in grades)
            {
                if (grade >= 0)
                {
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Average += grade;
                }
            }
            statistics.Average /= grades.Count;


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
