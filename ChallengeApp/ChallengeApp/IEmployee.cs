namespace ChallengeApp
{
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }
        string Sex { get; }

        void AddGrade(float grade);

        void AddGrade(double grade);

        void AddGrade(int grade);

        void AddGrade(string grade);
 
        void AddGrade(char grade);

        Statistics GetStatistics();
    }
}
