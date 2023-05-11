namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        public override event GradeAddedDelegate GradeAdded;

        private const string fileName = "grades.txt";
        public EmployeeInFile(string name, string surname, string sex)
            : base(name, surname, sex)
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

                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }

            }

            else
            {
                throw new Exception("invalid grade value");
            }

        }

        public override void AddGrade(double grade)
        {
            float gradeAsFloat = (float)grade;
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine(gradeAsFloat);
            }
        }

        public override void AddGrade(int grade)
        {
            float gradeAsFloat = (float)grade;
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine(gradeAsFloat);
            }
        }
        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {

                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }

            }
            else if (char.TryParse(grade, out char res))
            {

                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }

            }
            else
            {
                throw new Exception("String is not float or char");
            }
        }
        public override void AddGrade(char grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                switch (grade)
                {
                    case 'A':
                    case 'a':
                        writer.WriteLine(100);
                        break;
                    case 'B':
                    case 'b':
                        writer.WriteLine(80);
                        break;
                    case 'C':
                    case 'c':
                        writer.WriteLine(60);
                        break;
                    case 'D':
                    case 'd':
                        writer.WriteLine(40);
                        break;
                    case 'E':
                    case 'e':
                        writer.WriteLine(20);
                        break;
                    default:
                        throw new Exception("Wrong Letter");
                }
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
            if (File.Exists($"{fileName}"))
            {

                using (var reader = File.OpenText($"{fileName}"))
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
        private Statistics CountStatistics(List<float> grades)
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
